
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibRelaInfoBL
 表名:vVideoLibRelaInfo(01120405)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
public static class  clsvVideoLibRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibRelaInfoEN GetObj(this K_IdMicroTeachCaseRelaInfo_vVideoLibRelaInfo myKey)
{
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = clsvVideoLibRelaInfoBL.vVideoLibRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(myKey.Value);
return objvVideoLibRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdMicroTeachCaseRelaInfo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, long lngIdMicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFuncModuleId(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibRelaInfo.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibRelaInfo.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibRelaInfo.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFuncModuleName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibRelaInfo.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdMicroteachCase(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convVideoLibRelaInfo.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convVideoLibRelaInfo.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convVideoLibRelaInfo.IdMicroteachCase);
}
objvVideoLibRelaInfoEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdMicroteachCase) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdMicroteachCase, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroteachCase] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdVideoLib(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdVideoLib, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdVideoLib, 8, convVideoLibRelaInfo.IdVideoLib);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdVideoLib, 8, convVideoLibRelaInfo.IdVideoLib);
}
objvVideoLibRelaInfoEN.IdVideoLib = strIdVideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdVideoLib) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdVideoLib, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdVideoLib] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetVideoLibName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strVideoLibName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibRelaInfo.VideoLibName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdXzCollege(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convVideoLibRelaInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convVideoLibRelaInfo.IdXzCollege);
}
objvVideoLibRelaInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdXzCollege) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdXzCollege, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdXzCollege] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibRelaInfo.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibRelaInfo.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeNameA(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLibRelaInfo.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseId(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibRelaInfo.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibRelaInfo.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseCode(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibRelaInfo.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibRelaInfo.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdResource(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convVideoLibRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convVideoLibRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convVideoLibRelaInfo.IdResource);
}
objvVideoLibRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdResource) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdResource, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdResource] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoLibRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoLibRelaInfo.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdFtpResource(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convVideoLibRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convVideoLibRelaInfo.IdFtpResource);
}
objvVideoLibRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdFtpResource) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFtpResourceID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoLibRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoLibRelaInfo.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOriginalName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoLibRelaInfo.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileDirName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoLibRelaInfo.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileRename(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoLibRelaInfo.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileUpDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoLibRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoLibRelaInfo.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileUpTime(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoLibRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoLibRelaInfo.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileSize(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoLibRelaInfo.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoLibRelaInfo.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceOwner(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoLibRelaInfo.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdFile(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convVideoLibRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convVideoLibRelaInfo.IdFile);
}
objvVideoLibRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdFile) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdFile, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdFile] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoLibRelaInfo.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetSaveDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoLibRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoLibRelaInfo.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetSaveTime(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoLibRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoLibRelaInfo.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOriginName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoLibRelaInfo.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdResourceType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convVideoLibRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convVideoLibRelaInfo.IdResourceType);
}
objvVideoLibRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdResourceType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceTypeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoLibRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoLibRelaInfo.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceTypeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoLibRelaInfo.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileNewName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoLibRelaInfo.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOldName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoLibRelaInfo.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpFileType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoLibRelaInfo.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpFileSize(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoLibRelaInfo.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpResourceOwner(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoLibRelaInfo.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIdMicroTeachCaseRelaInfoType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType);
}
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetBrowseCount(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFlag(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFlag, 50, convVideoLibRelaInfo.Flag);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetUpdDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLibRelaInfo.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetUpdUser(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLibRelaInfo.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMemo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLibRelaInfo.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoENS">源对象</param>
 /// <param name = "objvVideoLibRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENS, clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENT)
{
try
{
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoLibRelaInfoENT.FuncModuleId = objvVideoLibRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoLibRelaInfoENT.FuncModuleName = objvVideoLibRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoLibRelaInfoENT.IdMicroteachCase = objvVideoLibRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibRelaInfoENT.IdVideoLib = objvVideoLibRelaInfoENS.IdVideoLib; //视频库流水号
objvVideoLibRelaInfoENT.VideoLibName = objvVideoLibRelaInfoENS.VideoLibName; //视频名称
objvVideoLibRelaInfoENT.IdXzCollege = objvVideoLibRelaInfoENS.IdXzCollege; //学院流水号
objvVideoLibRelaInfoENT.CollegeID = objvVideoLibRelaInfoENS.CollegeID; //学院ID
objvVideoLibRelaInfoENT.CollegeName = objvVideoLibRelaInfoENS.CollegeName; //学院名称
objvVideoLibRelaInfoENT.CollegeNameA = objvVideoLibRelaInfoENS.CollegeNameA; //学院名称简写
objvVideoLibRelaInfoENT.CourseId = objvVideoLibRelaInfoENS.CourseId; //课程Id
objvVideoLibRelaInfoENT.CourseCode = objvVideoLibRelaInfoENS.CourseCode; //课程代码
objvVideoLibRelaInfoENT.CourseName = objvVideoLibRelaInfoENS.CourseName; //课程名称
objvVideoLibRelaInfoENT.IdResource = objvVideoLibRelaInfoENS.IdResource; //资源流水号
objvVideoLibRelaInfoENT.ResourceID = objvVideoLibRelaInfoENS.ResourceID; //资源ID
objvVideoLibRelaInfoENT.SaveMode = objvVideoLibRelaInfoENS.SaveMode; //文件存放方式
objvVideoLibRelaInfoENT.IdFtpResource = objvVideoLibRelaInfoENS.IdFtpResource; //FTP资源流水号
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
objvVideoLibRelaInfoENT.IdFile = objvVideoLibRelaInfoENS.IdFile; //文件流水号
objvVideoLibRelaInfoENT.FileName = objvVideoLibRelaInfoENS.FileName; //文件名称
objvVideoLibRelaInfoENT.SaveDate = objvVideoLibRelaInfoENS.SaveDate; //创建日期
objvVideoLibRelaInfoENT.SaveTime = objvVideoLibRelaInfoENS.SaveTime; //创建时间
objvVideoLibRelaInfoENT.FileOriginName = objvVideoLibRelaInfoENS.FileOriginName; //原文件名
objvVideoLibRelaInfoENT.IdResourceType = objvVideoLibRelaInfoENS.IdResourceType; //资源类型流水号
objvVideoLibRelaInfoENT.ResourceTypeID = objvVideoLibRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoLibRelaInfoENT.ResourceTypeName = objvVideoLibRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoLibRelaInfoENT.FileNewName = objvVideoLibRelaInfoENS.FileNewName; //新文件名
objvVideoLibRelaInfoENT.FileOldName = objvVideoLibRelaInfoENS.FileOldName; //旧文件名
objvVideoLibRelaInfoENT.ftpFileType = objvVideoLibRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoLibRelaInfoENT.ftpFileSize = objvVideoLibRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoLibRelaInfoENT.ftpResourceOwner = objvVideoLibRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
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
 /// <param name = "objvVideoLibRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvVideoLibRelaInfoEN:objvVideoLibRelaInfoENT</returns>
 public static clsvVideoLibRelaInfoEN CopyTo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENS)
{
try
{
 clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENT = new clsvVideoLibRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfo, //案例相关信息流水号
FuncModuleId = objvVideoLibRelaInfoENS.FuncModuleId, //功能模块Id
FuncModuleName = objvVideoLibRelaInfoENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvVideoLibRelaInfoENS.IdMicroteachCase, //微格教学案例流水号
IdVideoLib = objvVideoLibRelaInfoENS.IdVideoLib, //视频库流水号
VideoLibName = objvVideoLibRelaInfoENS.VideoLibName, //视频名称
IdXzCollege = objvVideoLibRelaInfoENS.IdXzCollege, //学院流水号
CollegeID = objvVideoLibRelaInfoENS.CollegeID, //学院ID
CollegeName = objvVideoLibRelaInfoENS.CollegeName, //学院名称
CollegeNameA = objvVideoLibRelaInfoENS.CollegeNameA, //学院名称简写
CourseId = objvVideoLibRelaInfoENS.CourseId, //课程Id
CourseCode = objvVideoLibRelaInfoENS.CourseCode, //课程代码
CourseName = objvVideoLibRelaInfoENS.CourseName, //课程名称
IdResource = objvVideoLibRelaInfoENS.IdResource, //资源流水号
ResourceID = objvVideoLibRelaInfoENS.ResourceID, //资源ID
SaveMode = objvVideoLibRelaInfoENS.SaveMode, //文件存放方式
IdFtpResource = objvVideoLibRelaInfoENS.IdFtpResource, //FTP资源流水号
FtpResourceID = objvVideoLibRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvVideoLibRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvVideoLibRelaInfoENS.FileDirName, //文件目录名
FileRename = objvVideoLibRelaInfoENS.FileRename, //文件新名
FileUpDate = objvVideoLibRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvVideoLibRelaInfoENS.FileUpTime, //创建时间
FileSize = objvVideoLibRelaInfoENS.FileSize, //文件大小
FileType = objvVideoLibRelaInfoENS.FileType, //文件类型
ResourceOwner = objvVideoLibRelaInfoENS.ResourceOwner, //上传者
IsExistFile = objvVideoLibRelaInfoENS.IsExistFile, //是否存在文件
IdFile = objvVideoLibRelaInfoENS.IdFile, //文件流水号
FileName = objvVideoLibRelaInfoENS.FileName, //文件名称
SaveDate = objvVideoLibRelaInfoENS.SaveDate, //创建日期
SaveTime = objvVideoLibRelaInfoENS.SaveTime, //创建时间
FileOriginName = objvVideoLibRelaInfoENS.FileOriginName, //原文件名
IdResourceType = objvVideoLibRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvVideoLibRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvVideoLibRelaInfoENS.ResourceTypeName, //资源类型名称
FileNewName = objvVideoLibRelaInfoENS.FileNewName, //新文件名
FileOldName = objvVideoLibRelaInfoENS.FileOldName, //旧文件名
ftpFileType = objvVideoLibRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvVideoLibRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvVideoLibRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
IdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeID, //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeName, //微格案例相关信息类型名称
IsVisible = objvVideoLibRelaInfoENS.IsVisible, //是否显示
BrowseCount = objvVideoLibRelaInfoENS.BrowseCount, //浏览次数
Flag = objvVideoLibRelaInfoENS.Flag, //标志
UpdDate = objvVideoLibRelaInfoENS.UpdDate, //修改日期
UpdUser = objvVideoLibRelaInfoENS.UpdUser, //修改人
Memo = objvVideoLibRelaInfoENS.Memo, //备注
};
 return objvVideoLibRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
 clsvVideoLibRelaInfoBL.vVideoLibRelaInfoDA.CheckProperty4Condition(objvVideoLibRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo, objvVideoLibRelaInfoCond.IdMicroTeachCaseRelaInfo, strComparisonOpIdMicroTeachCaseRelaInfo);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FuncModuleId, objvVideoLibRelaInfoCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FuncModuleName, objvVideoLibRelaInfoCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdMicroteachCase, objvVideoLibRelaInfoCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdVideoLib) == true)
{
string strComparisonOpIdVideoLib = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdVideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdVideoLib, objvVideoLibRelaInfoCond.IdVideoLib, strComparisonOpIdVideoLib);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.VideoLibName) == true)
{
string strComparisonOpVideoLibName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.VideoLibName, objvVideoLibRelaInfoCond.VideoLibName, strComparisonOpVideoLibName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdXzCollege, objvVideoLibRelaInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CollegeID) == true)
{
string strComparisonOpCollegeID = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeID, objvVideoLibRelaInfoCond.CollegeID, strComparisonOpCollegeID);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CollegeName) == true)
{
string strComparisonOpCollegeName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeName, objvVideoLibRelaInfoCond.CollegeName, strComparisonOpCollegeName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeNameA, objvVideoLibRelaInfoCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CourseId) == true)
{
string strComparisonOpCourseId = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseId, objvVideoLibRelaInfoCond.CourseId, strComparisonOpCourseId);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CourseCode) == true)
{
string strComparisonOpCourseCode = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseCode, objvVideoLibRelaInfoCond.CourseCode, strComparisonOpCourseCode);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.CourseName) == true)
{
string strComparisonOpCourseName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseName, objvVideoLibRelaInfoCond.CourseName, strComparisonOpCourseName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdResource, objvVideoLibRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceID, objvVideoLibRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.SaveMode) == true)
{
if (objvVideoLibRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.SaveMode);
}
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdFtpResource, objvVideoLibRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FtpResourceID, objvVideoLibRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOriginalName, objvVideoLibRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileDirName, objvVideoLibRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileRename, objvVideoLibRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileUpDate, objvVideoLibRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileUpTime, objvVideoLibRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileSize, objvVideoLibRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileType, objvVideoLibRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceOwner, objvVideoLibRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IsExistFile) == true)
{
if (objvVideoLibRelaInfoCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.IsExistFile);
}
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdFile, objvVideoLibRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileName, objvVideoLibRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.SaveDate, objvVideoLibRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.SaveTime, objvVideoLibRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOriginName, objvVideoLibRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdResourceType, objvVideoLibRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceTypeID, objvVideoLibRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceTypeName, objvVideoLibRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileNewName, objvVideoLibRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOldName, objvVideoLibRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpFileType, objvVideoLibRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpFileSize, objvVideoLibRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpResourceOwner, objvVideoLibRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType, objvVideoLibRelaInfoCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID, objvVideoLibRelaInfoCond.MicroTeachCaseRelaInfoTypeID, strComparisonOpMicroTeachCaseRelaInfoTypeID);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName, objvVideoLibRelaInfoCond.MicroTeachCaseRelaInfoTypeName, strComparisonOpMicroTeachCaseRelaInfoTypeName);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.IsVisible) == true)
{
if (objvVideoLibRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.IsVisible);
}
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibRelaInfo.BrowseCount, objvVideoLibRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.Flag) == true)
{
string strComparisonOpFlag = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.Flag, objvVideoLibRelaInfoCond.Flag, strComparisonOpFlag);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.UpdDate, objvVideoLibRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.UpdUser, objvVideoLibRelaInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objvVideoLibRelaInfoCond.IsUpdated(convVideoLibRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvVideoLibRelaInfoCond.dicFldComparisonOp[convVideoLibRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.Memo, objvVideoLibRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vVideoLibRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v视频库相关信息(vVideoLibRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibRelaInfoBL
{
public static RelatedActions_vVideoLibRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvVideoLibRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvVideoLibRelaInfoDA vVideoLibRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvVideoLibRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvVideoLibRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvVideoLibRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoLibRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vVideoLibRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vVideoLibRelaInfoDA.GetDataTable_vVideoLibRelaInfo(strWhereCond);
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
objDT = vVideoLibRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vVideoLibRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vVideoLibRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vVideoLibRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vVideoLibRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vVideoLibRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vVideoLibRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vVideoLibRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLst(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroTeachCaseRelaInfoLst);
 string strWhereCond = string.Format("IdMicroTeachCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvVideoLibRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLstCache(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Sel =
arrvVideoLibRelaInfoObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoLst.Contains(x.IdMicroTeachCaseRelaInfo));
return arrvVideoLibRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvVideoLibRelaInfoEN> GetSubObjLstCache(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoCond)
{
List<clsvVideoLibRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibRelaInfo.AttributeName)
{
if (objvVideoLibRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibRelaInfoCond[strFldName].ToString());
}
else
{
if (objvVideoLibRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibRelaInfoCond[strFldName]));
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
List<clsvVideoLibRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvVideoLibRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvVideoLibRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
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
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
public static List<clsvVideoLibRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvVideoLibRelaInfoEN> arrObjLst = new List<clsvVideoLibRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = new clsvVideoLibRelaInfoEN();
try
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvVideoLibRelaInfoEN.FuncModuleId = objRow[convVideoLibRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoLibRelaInfoEN.FuncModuleName = objRow[convVideoLibRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoLibRelaInfoEN.IdMicroteachCase = objRow[convVideoLibRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoLibRelaInfoEN.IdVideoLib = objRow[convVideoLibRelaInfo.IdVideoLib] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdVideoLib].ToString().Trim(); //视频库流水号
objvVideoLibRelaInfoEN.VideoLibName = objRow[convVideoLibRelaInfo.VideoLibName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.VideoLibName].ToString().Trim(); //视频名称
objvVideoLibRelaInfoEN.IdXzCollege = objRow[convVideoLibRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoLibRelaInfoEN.CollegeID = objRow[convVideoLibRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvVideoLibRelaInfoEN.CollegeName = objRow[convVideoLibRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvVideoLibRelaInfoEN.CollegeNameA = objRow[convVideoLibRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoLibRelaInfoEN.CourseId = objRow[convVideoLibRelaInfo.CourseId] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseId].ToString().Trim(); //课程Id
objvVideoLibRelaInfoEN.CourseCode = objRow[convVideoLibRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvVideoLibRelaInfoEN.CourseName = objRow[convVideoLibRelaInfo.CourseName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.CourseName].ToString().Trim(); //课程名称
objvVideoLibRelaInfoEN.IdResource = objRow[convVideoLibRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvVideoLibRelaInfoEN.ResourceID = objRow[convVideoLibRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvVideoLibRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvVideoLibRelaInfoEN.IdFtpResource = objRow[convVideoLibRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvVideoLibRelaInfoEN.FtpResourceID = objRow[convVideoLibRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvVideoLibRelaInfoEN.FileOriginalName = objRow[convVideoLibRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvVideoLibRelaInfoEN.FileDirName = objRow[convVideoLibRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvVideoLibRelaInfoEN.FileRename = objRow[convVideoLibRelaInfo.FileRename] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileRename].ToString().Trim(); //文件新名
objvVideoLibRelaInfoEN.FileUpDate = objRow[convVideoLibRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.FileUpTime = objRow[convVideoLibRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileSize = objRow[convVideoLibRelaInfo.FileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileSize].ToString().Trim(); //文件大小
objvVideoLibRelaInfoEN.FileType = objRow[convVideoLibRelaInfo.FileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileType].ToString().Trim(); //文件类型
objvVideoLibRelaInfoEN.ResourceOwner = objRow[convVideoLibRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvVideoLibRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvVideoLibRelaInfoEN.IdFile = objRow[convVideoLibRelaInfo.IdFile] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvVideoLibRelaInfoEN.FileName = objRow[convVideoLibRelaInfo.FileName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileName].ToString().Trim(); //文件名称
objvVideoLibRelaInfoEN.SaveDate = objRow[convVideoLibRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvVideoLibRelaInfoEN.SaveTime = objRow[convVideoLibRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvVideoLibRelaInfoEN.FileOriginName = objRow[convVideoLibRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvVideoLibRelaInfoEN.IdResourceType = objRow[convVideoLibRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvVideoLibRelaInfoEN.ResourceTypeID = objRow[convVideoLibRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvVideoLibRelaInfoEN.ResourceTypeName = objRow[convVideoLibRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvVideoLibRelaInfoEN.FileNewName = objRow[convVideoLibRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvVideoLibRelaInfoEN.FileOldName = objRow[convVideoLibRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvVideoLibRelaInfoEN.ftpFileType = objRow[convVideoLibRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvVideoLibRelaInfoEN.ftpFileSize = objRow[convVideoLibRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvVideoLibRelaInfoEN.ftpResourceOwner = objRow[convVideoLibRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvVideoLibRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convVideoLibRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvVideoLibRelaInfoEN.BrowseCount = objRow[convVideoLibRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoLibRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvVideoLibRelaInfoEN.Flag = objRow[convVideoLibRelaInfo.Flag] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Flag].ToString().Trim(); //标志
objvVideoLibRelaInfoEN.UpdDate = objRow[convVideoLibRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvVideoLibRelaInfoEN.UpdUser = objRow[convVideoLibRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.UpdUser].ToString().Trim(); //修改人
objvVideoLibRelaInfoEN.Memo = objRow[convVideoLibRelaInfo.Memo] == DBNull.Value ? null : objRow[convVideoLibRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvVideoLibRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvVideoLibRelaInfo(ref clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
bool bolResult = vVideoLibRelaInfoDA.GetvVideoLibRelaInfo(ref objvVideoLibRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = vVideoLibRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
return objvVideoLibRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvVideoLibRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = vVideoLibRelaInfoDA.GetFirstObj(strWhereCond);
 return objvVideoLibRelaInfoEN;
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
public static clsvVideoLibRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = vVideoLibRelaInfoDA.GetObjByDataRow(objRow);
 return objvVideoLibRelaInfoEN;
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
public static clsvVideoLibRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = vVideoLibRelaInfoDA.GetObjByDataRow(objRow);
 return objvVideoLibRelaInfoEN;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstvVideoLibRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoFromList(long lngIdMicroTeachCaseRelaInfo, List<clsvVideoLibRelaInfoEN> lstvVideoLibRelaInfoObjLst)
{
foreach (clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN in lstvVideoLibRelaInfoObjLst)
{
if (objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo)
{
return objvVideoLibRelaInfoEN;
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
 long lngIdMicroTeachCaseRelaInfo;
 try
 {
 lngIdMicroTeachCaseRelaInfo = new clsvVideoLibRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdMicroTeachCaseRelaInfo;
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
 arrList = vVideoLibRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vVideoLibRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = vVideoLibRelaInfoDA.IsExist(lngIdMicroTeachCaseRelaInfo);
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
 bolIsExist = clsvVideoLibRelaInfoDA.IsExistTable();
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
 bolIsExist = vVideoLibRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvVideoLibRelaInfoENS">源对象</param>
 /// <param name = "objvVideoLibRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENS, clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENT)
{
try
{
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoLibRelaInfoENT.FuncModuleId = objvVideoLibRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoLibRelaInfoENT.FuncModuleName = objvVideoLibRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoLibRelaInfoENT.IdMicroteachCase = objvVideoLibRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvVideoLibRelaInfoENT.IdVideoLib = objvVideoLibRelaInfoENS.IdVideoLib; //视频库流水号
objvVideoLibRelaInfoENT.VideoLibName = objvVideoLibRelaInfoENS.VideoLibName; //视频名称
objvVideoLibRelaInfoENT.IdXzCollege = objvVideoLibRelaInfoENS.IdXzCollege; //学院流水号
objvVideoLibRelaInfoENT.CollegeID = objvVideoLibRelaInfoENS.CollegeID; //学院ID
objvVideoLibRelaInfoENT.CollegeName = objvVideoLibRelaInfoENS.CollegeName; //学院名称
objvVideoLibRelaInfoENT.CollegeNameA = objvVideoLibRelaInfoENS.CollegeNameA; //学院名称简写
objvVideoLibRelaInfoENT.CourseId = objvVideoLibRelaInfoENS.CourseId; //课程Id
objvVideoLibRelaInfoENT.CourseCode = objvVideoLibRelaInfoENS.CourseCode; //课程代码
objvVideoLibRelaInfoENT.CourseName = objvVideoLibRelaInfoENS.CourseName; //课程名称
objvVideoLibRelaInfoENT.IdResource = objvVideoLibRelaInfoENS.IdResource; //资源流水号
objvVideoLibRelaInfoENT.ResourceID = objvVideoLibRelaInfoENS.ResourceID; //资源ID
objvVideoLibRelaInfoENT.SaveMode = objvVideoLibRelaInfoENS.SaveMode; //文件存放方式
objvVideoLibRelaInfoENT.IdFtpResource = objvVideoLibRelaInfoENS.IdFtpResource; //FTP资源流水号
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
objvVideoLibRelaInfoENT.IdFile = objvVideoLibRelaInfoENS.IdFile; //文件流水号
objvVideoLibRelaInfoENT.FileName = objvVideoLibRelaInfoENS.FileName; //文件名称
objvVideoLibRelaInfoENT.SaveDate = objvVideoLibRelaInfoENS.SaveDate; //创建日期
objvVideoLibRelaInfoENT.SaveTime = objvVideoLibRelaInfoENS.SaveTime; //创建时间
objvVideoLibRelaInfoENT.FileOriginName = objvVideoLibRelaInfoENS.FileOriginName; //原文件名
objvVideoLibRelaInfoENT.IdResourceType = objvVideoLibRelaInfoENS.IdResourceType; //资源类型流水号
objvVideoLibRelaInfoENT.ResourceTypeID = objvVideoLibRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoLibRelaInfoENT.ResourceTypeName = objvVideoLibRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoLibRelaInfoENT.FileNewName = objvVideoLibRelaInfoENS.FileNewName; //新文件名
objvVideoLibRelaInfoENT.FileOldName = objvVideoLibRelaInfoENS.FileOldName; //旧文件名
objvVideoLibRelaInfoENT.ftpFileType = objvVideoLibRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoLibRelaInfoENT.ftpFileSize = objvVideoLibRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoLibRelaInfoENT.ftpResourceOwner = objvVideoLibRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLibRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
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
 /// <param name = "objvVideoLibRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
try
{
objvVideoLibRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvVideoLibRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo = objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FuncModuleId = objvVideoLibRelaInfoEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FuncModuleName = objvVideoLibRelaInfoEN.FuncModuleName == "[null]" ? null :  objvVideoLibRelaInfoEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdMicroteachCase = objvVideoLibRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdVideoLib, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdVideoLib = objvVideoLibRelaInfoEN.IdVideoLib == "[null]" ? null :  objvVideoLibRelaInfoEN.IdVideoLib; //视频库流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.VideoLibName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.VideoLibName = objvVideoLibRelaInfoEN.VideoLibName == "[null]" ? null :  objvVideoLibRelaInfoEN.VideoLibName; //视频名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdXzCollege = objvVideoLibRelaInfoEN.IdXzCollege == "[null]" ? null :  objvVideoLibRelaInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CollegeID = objvVideoLibRelaInfoEN.CollegeID == "[null]" ? null :  objvVideoLibRelaInfoEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CollegeName = objvVideoLibRelaInfoEN.CollegeName == "[null]" ? null :  objvVideoLibRelaInfoEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CollegeNameA = objvVideoLibRelaInfoEN.CollegeNameA == "[null]" ? null :  objvVideoLibRelaInfoEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CourseId = objvVideoLibRelaInfoEN.CourseId == "[null]" ? null :  objvVideoLibRelaInfoEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CourseCode = objvVideoLibRelaInfoEN.CourseCode == "[null]" ? null :  objvVideoLibRelaInfoEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convVideoLibRelaInfo.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.CourseName = objvVideoLibRelaInfoEN.CourseName == "[null]" ? null :  objvVideoLibRelaInfoEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdResource = objvVideoLibRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ResourceID = objvVideoLibRelaInfoEN.ResourceID == "[null]" ? null :  objvVideoLibRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convVideoLibRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.SaveMode = objvVideoLibRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdFtpResource = objvVideoLibRelaInfoEN.IdFtpResource == "[null]" ? null :  objvVideoLibRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FtpResourceID = objvVideoLibRelaInfoEN.FtpResourceID == "[null]" ? null :  objvVideoLibRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileOriginalName = objvVideoLibRelaInfoEN.FileOriginalName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileDirName = objvVideoLibRelaInfoEN.FileDirName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileRename = objvVideoLibRelaInfoEN.FileRename == "[null]" ? null :  objvVideoLibRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileUpDate = objvVideoLibRelaInfoEN.FileUpDate == "[null]" ? null :  objvVideoLibRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileUpTime = objvVideoLibRelaInfoEN.FileUpTime == "[null]" ? null :  objvVideoLibRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileSize = objvVideoLibRelaInfoEN.FileSize == "[null]" ? null :  objvVideoLibRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileType = objvVideoLibRelaInfoEN.FileType == "[null]" ? null :  objvVideoLibRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ResourceOwner = objvVideoLibRelaInfoEN.ResourceOwner == "[null]" ? null :  objvVideoLibRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IsExistFile = objvVideoLibRelaInfoEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdFile = objvVideoLibRelaInfoEN.IdFile == "[null]" ? null :  objvVideoLibRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileName = objvVideoLibRelaInfoEN.FileName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.SaveDate = objvVideoLibRelaInfoEN.SaveDate == "[null]" ? null :  objvVideoLibRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convVideoLibRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.SaveTime = objvVideoLibRelaInfoEN.SaveTime == "[null]" ? null :  objvVideoLibRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileOriginName = objvVideoLibRelaInfoEN.FileOriginName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdResourceType = objvVideoLibRelaInfoEN.IdResourceType == "[null]" ? null :  objvVideoLibRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ResourceTypeID = objvVideoLibRelaInfoEN.ResourceTypeID == "[null]" ? null :  objvVideoLibRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ResourceTypeName = objvVideoLibRelaInfoEN.ResourceTypeName == "[null]" ? null :  objvVideoLibRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileNewName = objvVideoLibRelaInfoEN.FileNewName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.FileOldName = objvVideoLibRelaInfoEN.FileOldName == "[null]" ? null :  objvVideoLibRelaInfoEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ftpFileType = objvVideoLibRelaInfoEN.ftpFileType == "[null]" ? null :  objvVideoLibRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ftpFileSize = objvVideoLibRelaInfoEN.ftpFileSize == "[null]" ? null :  objvVideoLibRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convVideoLibRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.ftpResourceOwner = objvVideoLibRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvVideoLibRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]" ? null :  objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]" ? null :  objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
}
if (arrFldSet.Contains(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]" ? null :  objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
}
if (arrFldSet.Contains(convVideoLibRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.IsVisible = objvVideoLibRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convVideoLibRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.BrowseCount = objvVideoLibRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convVideoLibRelaInfo.Flag, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.Flag = objvVideoLibRelaInfoEN.Flag == "[null]" ? null :  objvVideoLibRelaInfoEN.Flag; //标志
}
if (arrFldSet.Contains(convVideoLibRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.UpdDate = objvVideoLibRelaInfoEN.UpdDate == "[null]" ? null :  objvVideoLibRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convVideoLibRelaInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.UpdUser = objvVideoLibRelaInfoEN.UpdUser == "[null]" ? null :  objvVideoLibRelaInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convVideoLibRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvVideoLibRelaInfoEN.Memo = objvVideoLibRelaInfoEN.Memo == "[null]" ? null :  objvVideoLibRelaInfoEN.Memo; //备注
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
 /// <param name = "objvVideoLibRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
try
{
if (objvVideoLibRelaInfoEN.FuncModuleName == "[null]") objvVideoLibRelaInfoEN.FuncModuleName = null; //功能模块名称
if (objvVideoLibRelaInfoEN.IdVideoLib == "[null]") objvVideoLibRelaInfoEN.IdVideoLib = null; //视频库流水号
if (objvVideoLibRelaInfoEN.VideoLibName == "[null]") objvVideoLibRelaInfoEN.VideoLibName = null; //视频名称
if (objvVideoLibRelaInfoEN.IdXzCollege == "[null]") objvVideoLibRelaInfoEN.IdXzCollege = null; //学院流水号
if (objvVideoLibRelaInfoEN.CollegeID == "[null]") objvVideoLibRelaInfoEN.CollegeID = null; //学院ID
if (objvVideoLibRelaInfoEN.CollegeName == "[null]") objvVideoLibRelaInfoEN.CollegeName = null; //学院名称
if (objvVideoLibRelaInfoEN.CollegeNameA == "[null]") objvVideoLibRelaInfoEN.CollegeNameA = null; //学院名称简写
if (objvVideoLibRelaInfoEN.CourseId == "[null]") objvVideoLibRelaInfoEN.CourseId = null; //课程Id
if (objvVideoLibRelaInfoEN.CourseCode == "[null]") objvVideoLibRelaInfoEN.CourseCode = null; //课程代码
if (objvVideoLibRelaInfoEN.CourseName == "[null]") objvVideoLibRelaInfoEN.CourseName = null; //课程名称
if (objvVideoLibRelaInfoEN.ResourceID == "[null]") objvVideoLibRelaInfoEN.ResourceID = null; //资源ID
if (objvVideoLibRelaInfoEN.IdFtpResource == "[null]") objvVideoLibRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvVideoLibRelaInfoEN.FtpResourceID == "[null]") objvVideoLibRelaInfoEN.FtpResourceID = null; //FTP资源ID
if (objvVideoLibRelaInfoEN.FileOriginalName == "[null]") objvVideoLibRelaInfoEN.FileOriginalName = null; //文件原名
if (objvVideoLibRelaInfoEN.FileDirName == "[null]") objvVideoLibRelaInfoEN.FileDirName = null; //文件目录名
if (objvVideoLibRelaInfoEN.FileRename == "[null]") objvVideoLibRelaInfoEN.FileRename = null; //文件新名
if (objvVideoLibRelaInfoEN.FileUpDate == "[null]") objvVideoLibRelaInfoEN.FileUpDate = null; //创建日期
if (objvVideoLibRelaInfoEN.FileUpTime == "[null]") objvVideoLibRelaInfoEN.FileUpTime = null; //创建时间
if (objvVideoLibRelaInfoEN.FileSize == "[null]") objvVideoLibRelaInfoEN.FileSize = null; //文件大小
if (objvVideoLibRelaInfoEN.FileType == "[null]") objvVideoLibRelaInfoEN.FileType = null; //文件类型
if (objvVideoLibRelaInfoEN.ResourceOwner == "[null]") objvVideoLibRelaInfoEN.ResourceOwner = null; //上传者
if (objvVideoLibRelaInfoEN.IdFile == "[null]") objvVideoLibRelaInfoEN.IdFile = null; //文件流水号
if (objvVideoLibRelaInfoEN.FileName == "[null]") objvVideoLibRelaInfoEN.FileName = null; //文件名称
if (objvVideoLibRelaInfoEN.SaveDate == "[null]") objvVideoLibRelaInfoEN.SaveDate = null; //创建日期
if (objvVideoLibRelaInfoEN.SaveTime == "[null]") objvVideoLibRelaInfoEN.SaveTime = null; //创建时间
if (objvVideoLibRelaInfoEN.FileOriginName == "[null]") objvVideoLibRelaInfoEN.FileOriginName = null; //原文件名
if (objvVideoLibRelaInfoEN.IdResourceType == "[null]") objvVideoLibRelaInfoEN.IdResourceType = null; //资源类型流水号
if (objvVideoLibRelaInfoEN.ResourceTypeID == "[null]") objvVideoLibRelaInfoEN.ResourceTypeID = null; //资源类型ID
if (objvVideoLibRelaInfoEN.ResourceTypeName == "[null]") objvVideoLibRelaInfoEN.ResourceTypeName = null; //资源类型名称
if (objvVideoLibRelaInfoEN.FileNewName == "[null]") objvVideoLibRelaInfoEN.FileNewName = null; //新文件名
if (objvVideoLibRelaInfoEN.FileOldName == "[null]") objvVideoLibRelaInfoEN.FileOldName = null; //旧文件名
if (objvVideoLibRelaInfoEN.ftpFileType == "[null]") objvVideoLibRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvVideoLibRelaInfoEN.ftpFileSize == "[null]") objvVideoLibRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvVideoLibRelaInfoEN.ftpResourceOwner == "[null]") objvVideoLibRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]") objvVideoLibRelaInfoEN.IdMicroTeachCaseRelaInfoType = null; //微格案例相关信息类型流水号
if (objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]") objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = null; //微格案例相关信息类型ID
if (objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]") objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = null; //微格案例相关信息类型名称
if (objvVideoLibRelaInfoEN.Flag == "[null]") objvVideoLibRelaInfoEN.Flag = null; //标志
if (objvVideoLibRelaInfoEN.UpdDate == "[null]") objvVideoLibRelaInfoEN.UpdDate = null; //修改日期
if (objvVideoLibRelaInfoEN.UpdUser == "[null]") objvVideoLibRelaInfoEN.UpdUser = null; //修改人
if (objvVideoLibRelaInfoEN.Memo == "[null]") objvVideoLibRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN)
{
 vVideoLibRelaInfoDA.CheckProperty4Condition(objvVideoLibRelaInfoEN);
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
if (clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoBL没有刷新缓存机制(clsMicroTeachCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibBL没有刷新缓存机制(clsVideoLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeBL没有刷新缓存机制(clsVideoLibTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogBL没有刷新缓存机制(clsVideoLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoPlayLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogBL没有刷新缓存机制(clsVideoPlayLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfo");
//if (arrvVideoLibRelaInfoObjLstCache == null)
//{
//arrvVideoLibRelaInfoObjLstCache = vVideoLibRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLibRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoCache(long lngIdMicroTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Sel =
arrvVideoLibRelaInfoObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo 
);
if (arrvVideoLibRelaInfoObjLst_Sel.Count() == 0)
{
   clsvVideoLibRelaInfoEN obj = clsvVideoLibRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvVideoLibRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetAllvVideoLibRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLstCache = GetObjLstCache(); 
return arrvVideoLibRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroTeachCaseRelaInfo)
{
if (strInFldName != convVideoLibRelaInfo.IdMicroTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convVideoLibRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convVideoLibRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvVideoLibRelaInfo = clsvVideoLibRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfoCache(lngIdMicroTeachCaseRelaInfo);
if (objvVideoLibRelaInfo == null) return "";
return objvVideoLibRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvVideoLibRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvVideoLibRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvVideoLibRelaInfoDA.GetRecCount();
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
int intRecCount = clsvVideoLibRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoCond)
{
List<clsvVideoLibRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvVideoLibRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convVideoLibRelaInfo.AttributeName)
{
if (objvVideoLibRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvVideoLibRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibRelaInfoCond[strFldName].ToString());
}
else
{
if (objvVideoLibRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvVideoLibRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvVideoLibRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvVideoLibRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvVideoLibRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvVideoLibRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvVideoLibRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvVideoLibRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vVideoLibRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}