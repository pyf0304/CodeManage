
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseRelaInfoBL
 表名:vTeachingCaseResCaseRelaInfo(01120394)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
public static class  clsvTeachingCaseResCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObj(this K_IdMicroTeachCaseRelaInfo_vTeachingCaseResCaseRelaInfo myKey)
{
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = clsvTeachingCaseResCaseRelaInfoBL.vTeachingCaseResCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(myKey.Value);
return objvTeachingCaseResCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdMicroTeachCaseRelaInfo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, long lngIdMicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = lngIdMicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFuncModuleId(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCaseRelaInfo.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCaseRelaInfo.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCaseRelaInfo.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFuncModuleName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCaseRelaInfo.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdMicroteachCase(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convTeachingCaseResCaseRelaInfo.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convTeachingCaseResCaseRelaInfo.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convTeachingCaseResCaseRelaInfo.IdMicroteachCase);
}
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdMicroteachCase) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdMicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdTeachingCaseResCase(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdTeachingCaseResCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCase, 8, convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCase, 8, convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase);
}
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = strIdTeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdXzCollege(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachingCaseResCaseRelaInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachingCaseResCaseRelaInfo.IdXzCollege);
}
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdXzCollege) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdXzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdXzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCaseRelaInfo.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCaseRelaInfo.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeNameA(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCaseRelaInfo.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMajorID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCaseRelaInfo.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCaseRelaInfo.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMajorName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCaseRelaInfo.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseId(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCaseRelaInfo.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCaseRelaInfo.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseCode(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCaseRelaInfo.CourseCode);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCaseRelaInfo.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdResource(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convTeachingCaseResCaseRelaInfo.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convTeachingCaseResCaseRelaInfo.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convTeachingCaseResCaseRelaInfo.IdResource);
}
objvTeachingCaseResCaseRelaInfoEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdResource) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdResource, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdResource] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachingCaseResCaseRelaInfo.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachingCaseResCaseRelaInfo.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdFtpResource(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convTeachingCaseResCaseRelaInfo.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convTeachingCaseResCaseRelaInfo.IdFtpResource);
}
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdFtpResource) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdFtpResource, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdFtpResource] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdFile(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convTeachingCaseResCaseRelaInfo.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convTeachingCaseResCaseRelaInfo.IdFile);
}
objvTeachingCaseResCaseRelaInfoEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdFile) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdFile, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdFile] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachingCaseResCaseRelaInfo.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachingCaseResCaseRelaInfo.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetSaveDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachingCaseResCaseRelaInfo.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachingCaseResCaseRelaInfo.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileSize(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachingCaseResCaseRelaInfo.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetSaveTime(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachingCaseResCaseRelaInfo.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachingCaseResCaseRelaInfo.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFtpResourceID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachingCaseResCaseRelaInfo.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachingCaseResCaseRelaInfo.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOriginalName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachingCaseResCaseRelaInfo.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileDirName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachingCaseResCaseRelaInfo.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileRename(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachingCaseResCaseRelaInfo.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileUpDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachingCaseResCaseRelaInfo.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachingCaseResCaseRelaInfo.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileUpTime(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachingCaseResCaseRelaInfo.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachingCaseResCaseRelaInfo.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdResourceType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convTeachingCaseResCaseRelaInfo.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convTeachingCaseResCaseRelaInfo.IdResourceType);
}
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdResourceType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdResourceType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdResourceType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceTypeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceTypeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachingCaseResCaseRelaInfo.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceOwner(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpFileType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCaseRelaInfo.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpFileSize(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachingCaseResCaseRelaInfo.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpResourceOwner(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOriginName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachingCaseResCaseRelaInfo.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileNewName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachingCaseResCaseRelaInfo.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOldName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachingCaseResCaseRelaInfo.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIdMicroTeachCaseRelaInfoType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strIdMicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroTeachCaseRelaInfoType, 4, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroTeachCaseRelaInfoType, 4, convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
}
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetBrowseCount(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFlag(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFlag, 50, convTeachingCaseResCaseRelaInfo.Flag);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetUpdDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCaseRelaInfo.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetUpdUser(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCaseRelaInfo.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMemo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCaseRelaInfo.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENS, clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENT)
{
try
{
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoENT.FuncModuleId = objvTeachingCaseResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseRelaInfoENT.FuncModuleName = objvTeachingCaseResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseRelaInfoENT.IdMicroteachCase = objvTeachingCaseResCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoENT.IdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoENT.TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoENT.IdXzCollege = objvTeachingCaseResCaseRelaInfoENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseRelaInfoENT.CollegeID = objvTeachingCaseResCaseRelaInfoENS.CollegeID; //学院ID
objvTeachingCaseResCaseRelaInfoENT.CollegeName = objvTeachingCaseResCaseRelaInfoENS.CollegeName; //学院名称
objvTeachingCaseResCaseRelaInfoENT.CollegeNameA = objvTeachingCaseResCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseRelaInfoENT.MajorID = objvTeachingCaseResCaseRelaInfoENS.MajorID; //专业ID
objvTeachingCaseResCaseRelaInfoENT.MajorName = objvTeachingCaseResCaseRelaInfoENS.MajorName; //专业名称
objvTeachingCaseResCaseRelaInfoENT.CourseId = objvTeachingCaseResCaseRelaInfoENS.CourseId; //课程Id
objvTeachingCaseResCaseRelaInfoENT.CourseCode = objvTeachingCaseResCaseRelaInfoENS.CourseCode; //课程代码
objvTeachingCaseResCaseRelaInfoENT.CourseName = objvTeachingCaseResCaseRelaInfoENS.CourseName; //课程名称
objvTeachingCaseResCaseRelaInfoENT.IdResource = objvTeachingCaseResCaseRelaInfoENS.IdResource; //资源流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceID = objvTeachingCaseResCaseRelaInfoENS.ResourceID; //资源ID
objvTeachingCaseResCaseRelaInfoENT.IdFtpResource = objvTeachingCaseResCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachingCaseResCaseRelaInfoENT.IdFile = objvTeachingCaseResCaseRelaInfoENS.IdFile; //文件流水号
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
objvTeachingCaseResCaseRelaInfoENT.IdResourceType = objvTeachingCaseResCaseRelaInfoENS.IdResourceType; //资源类型流水号
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
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
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
 /// <param name = "objvTeachingCaseResCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvTeachingCaseResCaseRelaInfoEN:objvTeachingCaseResCaseRelaInfoENT</returns>
 public static clsvTeachingCaseResCaseRelaInfoEN CopyTo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENS)
{
try
{
 clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENT = new clsvTeachingCaseResCaseRelaInfoEN()
{
IdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo, //案例相关信息流水号
FuncModuleId = objvTeachingCaseResCaseRelaInfoENS.FuncModuleId, //功能模块Id
FuncModuleName = objvTeachingCaseResCaseRelaInfoENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvTeachingCaseResCaseRelaInfoENS.IdMicroteachCase, //微格教学案例流水号
IdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoENS.IdTeachingCaseResCase, //教学案例资源案例流水号
TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoENS.TeachingCaseResCaseName, //教学案例资源案例名称
IdXzCollege = objvTeachingCaseResCaseRelaInfoENS.IdXzCollege, //学院流水号
CollegeID = objvTeachingCaseResCaseRelaInfoENS.CollegeID, //学院ID
CollegeName = objvTeachingCaseResCaseRelaInfoENS.CollegeName, //学院名称
CollegeNameA = objvTeachingCaseResCaseRelaInfoENS.CollegeNameA, //学院名称简写
MajorID = objvTeachingCaseResCaseRelaInfoENS.MajorID, //专业ID
MajorName = objvTeachingCaseResCaseRelaInfoENS.MajorName, //专业名称
CourseId = objvTeachingCaseResCaseRelaInfoENS.CourseId, //课程Id
CourseCode = objvTeachingCaseResCaseRelaInfoENS.CourseCode, //课程代码
CourseName = objvTeachingCaseResCaseRelaInfoENS.CourseName, //课程名称
IdResource = objvTeachingCaseResCaseRelaInfoENS.IdResource, //资源流水号
ResourceID = objvTeachingCaseResCaseRelaInfoENS.ResourceID, //资源ID
IdFtpResource = objvTeachingCaseResCaseRelaInfoENS.IdFtpResource, //FTP资源流水号
IdFile = objvTeachingCaseResCaseRelaInfoENS.IdFile, //文件流水号
FileName = objvTeachingCaseResCaseRelaInfoENS.FileName, //文件名称
FileType = objvTeachingCaseResCaseRelaInfoENS.FileType, //文件类型
SaveDate = objvTeachingCaseResCaseRelaInfoENS.SaveDate, //创建日期
FileSize = objvTeachingCaseResCaseRelaInfoENS.FileSize, //文件大小
SaveTime = objvTeachingCaseResCaseRelaInfoENS.SaveTime, //创建时间
FtpResourceID = objvTeachingCaseResCaseRelaInfoENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvTeachingCaseResCaseRelaInfoENS.FileOriginalName, //文件原名
FileDirName = objvTeachingCaseResCaseRelaInfoENS.FileDirName, //文件目录名
FileRename = objvTeachingCaseResCaseRelaInfoENS.FileRename, //文件新名
FileUpDate = objvTeachingCaseResCaseRelaInfoENS.FileUpDate, //创建日期
FileUpTime = objvTeachingCaseResCaseRelaInfoENS.FileUpTime, //创建时间
SaveMode = objvTeachingCaseResCaseRelaInfoENS.SaveMode, //文件存放方式
IdResourceType = objvTeachingCaseResCaseRelaInfoENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ResourceOwner, //上传者
ftpFileType = objvTeachingCaseResCaseRelaInfoENS.ftpFileType, //ftp文件类型
ftpFileSize = objvTeachingCaseResCaseRelaInfoENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvTeachingCaseResCaseRelaInfoENS.FileOriginName, //原文件名
IsExistFile = objvTeachingCaseResCaseRelaInfoENS.IsExistFile, //是否存在文件
FileNewName = objvTeachingCaseResCaseRelaInfoENS.FileNewName, //新文件名
FileOldName = objvTeachingCaseResCaseRelaInfoENS.FileOldName, //旧文件名
IdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType, //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID, //微格案例相关信息类型ID
MicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName, //微格案例相关信息类型名称
IsVisible = objvTeachingCaseResCaseRelaInfoENS.IsVisible, //是否显示
BrowseCount = objvTeachingCaseResCaseRelaInfoENS.BrowseCount, //浏览次数
Flag = objvTeachingCaseResCaseRelaInfoENS.Flag, //标志
UpdDate = objvTeachingCaseResCaseRelaInfoENS.UpdDate, //修改日期
UpdUser = objvTeachingCaseResCaseRelaInfoENS.UpdUser, //修改人
Memo = objvTeachingCaseResCaseRelaInfoENS.Memo, //备注
};
 return objvTeachingCaseResCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
 clsvTeachingCaseResCaseRelaInfoBL.vTeachingCaseResCaseRelaInfoDA.CheckProperty4Condition(objvTeachingCaseResCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo, objvTeachingCaseResCaseRelaInfoCond.IdMicroTeachCaseRelaInfo, strComparisonOpIdMicroTeachCaseRelaInfo);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FuncModuleId, objvTeachingCaseResCaseRelaInfoCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FuncModuleName, objvTeachingCaseResCaseRelaInfoCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdMicroteachCase, objvTeachingCaseResCaseRelaInfoCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase) == true)
{
string strComparisonOpIdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase, objvTeachingCaseResCaseRelaInfoCond.IdTeachingCaseResCase, strComparisonOpIdTeachingCaseResCase);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName, objvTeachingCaseResCaseRelaInfoCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdXzCollege, objvTeachingCaseResCaseRelaInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeID, objvTeachingCaseResCaseRelaInfoCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeName, objvTeachingCaseResCaseRelaInfoCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeNameA, objvTeachingCaseResCaseRelaInfoCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.MajorID) == true)
{
string strComparisonOpMajorID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MajorID, objvTeachingCaseResCaseRelaInfoCond.MajorID, strComparisonOpMajorID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.MajorName) == true)
{
string strComparisonOpMajorName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MajorName, objvTeachingCaseResCaseRelaInfoCond.MajorName, strComparisonOpMajorName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseId) == true)
{
string strComparisonOpCourseId = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseId, objvTeachingCaseResCaseRelaInfoCond.CourseId, strComparisonOpCourseId);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseCode) == true)
{
string strComparisonOpCourseCode = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseCode, objvTeachingCaseResCaseRelaInfoCond.CourseCode, strComparisonOpCourseCode);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseName) == true)
{
string strComparisonOpCourseName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseName, objvTeachingCaseResCaseRelaInfoCond.CourseName, strComparisonOpCourseName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdResource) == true)
{
string strComparisonOpIdResource = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdResource, objvTeachingCaseResCaseRelaInfoCond.IdResource, strComparisonOpIdResource);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceID) == true)
{
string strComparisonOpResourceID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceID, objvTeachingCaseResCaseRelaInfoCond.ResourceID, strComparisonOpResourceID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdFtpResource, objvTeachingCaseResCaseRelaInfoCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdFile) == true)
{
string strComparisonOpIdFile = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdFile, objvTeachingCaseResCaseRelaInfoCond.IdFile, strComparisonOpIdFile);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileName) == true)
{
string strComparisonOpFileName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileName, objvTeachingCaseResCaseRelaInfoCond.FileName, strComparisonOpFileName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileType) == true)
{
string strComparisonOpFileType = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileType, objvTeachingCaseResCaseRelaInfoCond.FileType, strComparisonOpFileType);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveDate) == true)
{
string strComparisonOpSaveDate = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.SaveDate, objvTeachingCaseResCaseRelaInfoCond.SaveDate, strComparisonOpSaveDate);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileSize) == true)
{
string strComparisonOpFileSize = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileSize, objvTeachingCaseResCaseRelaInfoCond.FileSize, strComparisonOpFileSize);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveTime) == true)
{
string strComparisonOpSaveTime = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.SaveTime, objvTeachingCaseResCaseRelaInfoCond.SaveTime, strComparisonOpSaveTime);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FtpResourceID, objvTeachingCaseResCaseRelaInfoCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOriginalName, objvTeachingCaseResCaseRelaInfoCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileDirName) == true)
{
string strComparisonOpFileDirName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileDirName, objvTeachingCaseResCaseRelaInfoCond.FileDirName, strComparisonOpFileDirName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileRename) == true)
{
string strComparisonOpFileRename = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileRename, objvTeachingCaseResCaseRelaInfoCond.FileRename, strComparisonOpFileRename);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileUpDate, objvTeachingCaseResCaseRelaInfoCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileUpTime, objvTeachingCaseResCaseRelaInfoCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveMode) == true)
{
if (objvTeachingCaseResCaseRelaInfoCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.SaveMode);
}
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdResourceType, objvTeachingCaseResCaseRelaInfoCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceTypeID, objvTeachingCaseResCaseRelaInfoCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceTypeName, objvTeachingCaseResCaseRelaInfoCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceOwner, objvTeachingCaseResCaseRelaInfoCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpFileType, objvTeachingCaseResCaseRelaInfoCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpFileSize, objvTeachingCaseResCaseRelaInfoCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpResourceOwner, objvTeachingCaseResCaseRelaInfoCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOriginName, objvTeachingCaseResCaseRelaInfoCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IsExistFile) == true)
{
if (objvTeachingCaseResCaseRelaInfoCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.IsExistFile);
}
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileNewName) == true)
{
string strComparisonOpFileNewName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileNewName, objvTeachingCaseResCaseRelaInfoCond.FileNewName, strComparisonOpFileNewName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOldName) == true)
{
string strComparisonOpFileOldName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOldName, objvTeachingCaseResCaseRelaInfoCond.FileOldName, strComparisonOpFileOldName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType) == true)
{
string strComparisonOpIdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType, objvTeachingCaseResCaseRelaInfoCond.IdMicroTeachCaseRelaInfoType, strComparisonOpIdMicroTeachCaseRelaInfoType);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvTeachingCaseResCaseRelaInfoCond.MicroTeachCaseRelaInfoTypeID, strComparisonOpMicroTeachCaseRelaInfoTypeID);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOpMicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvTeachingCaseResCaseRelaInfoCond.MicroTeachCaseRelaInfoTypeName, strComparisonOpMicroTeachCaseRelaInfoTypeName);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.IsVisible) == true)
{
if (objvTeachingCaseResCaseRelaInfoCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.IsVisible);
}
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseRelaInfo.BrowseCount, objvTeachingCaseResCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.Flag) == true)
{
string strComparisonOpFlag = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.Flag, objvTeachingCaseResCaseRelaInfoCond.Flag, strComparisonOpFlag);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.UpdDate, objvTeachingCaseResCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.UpdUser, objvTeachingCaseResCaseRelaInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(convTeachingCaseResCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.Memo, objvTeachingCaseResCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachingCaseResCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdMicroTeachCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教学案例资源案例相关信息(vTeachingCaseResCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseRelaInfoBL
{
public static RelatedActions_vTeachingCaseResCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachingCaseResCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachingCaseResCaseRelaInfoDA vTeachingCaseResCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachingCaseResCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachingCaseResCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vTeachingCaseResCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable_vTeachingCaseResCaseRelaInfo(strWhereCond);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachingCaseResCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLst(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
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
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroTeachCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByIdMicroTeachCaseRelaInfoLstCache(List<long> arrIdMicroTeachCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Sel =
arrvTeachingCaseResCaseRelaInfoObjLstCache
.Where(x => arrIdMicroTeachCaseRelaInfoLst.Contains(x.IdMicroTeachCaseRelaInfo));
return arrvTeachingCaseResCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachingCaseResCaseRelaInfoEN> GetSubObjLstCache(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoCond)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCaseRelaInfo.AttributeName)
{
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseRelaInfoCond[strFldName]));
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
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
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = new List<clsvTeachingCaseResCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = new clsvTeachingCaseResCaseRelaInfoEN();
try
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objRow[convTeachingCaseResCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objRow[convTeachingCaseResCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objRow[convTeachingCaseResCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseRelaInfoEN.MajorID = objRow[convTeachingCaseResCaseRelaInfo.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseRelaInfoEN.MajorName = objRow[convTeachingCaseResCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseRelaInfoEN.CourseId = objRow[convTeachingCaseResCaseRelaInfo.CourseId] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objRow[convTeachingCaseResCaseRelaInfo.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseRelaInfoEN.CourseName = objRow[convTeachingCaseResCaseRelaInfo.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseRelaInfoEN.IdResource = objRow[convTeachingCaseResCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objRow[convTeachingCaseResCaseRelaInfo.ResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachingCaseResCaseRelaInfoEN.IdFile = objRow[convTeachingCaseResCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvTeachingCaseResCaseRelaInfoEN.FileName = objRow[convTeachingCaseResCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvTeachingCaseResCaseRelaInfoEN.FileType = objRow[convTeachingCaseResCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objRow[convTeachingCaseResCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileSize = objRow[convTeachingCaseResCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objRow[convTeachingCaseResCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objRow[convTeachingCaseResCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvTeachingCaseResCaseRelaInfoEN.FileRename = objRow[convTeachingCaseResCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objRow[convTeachingCaseResCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objRow[convTeachingCaseResCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvTeachingCaseResCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objRow[convTeachingCaseResCaseRelaInfo.IdResourceType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objRow[convTeachingCaseResCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objRow[convTeachingCaseResCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objRow[convTeachingCaseResCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objRow[convTeachingCaseResCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID].ToString().Trim(); //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objRow[convTeachingCaseResCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvTeachingCaseResCaseRelaInfoEN.Flag = objRow[convTeachingCaseResCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Flag].ToString().Trim(); //标志
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objRow[convTeachingCaseResCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objRow[convTeachingCaseResCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvTeachingCaseResCaseRelaInfoEN.Memo = objRow[convTeachingCaseResCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachingCaseResCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachingCaseResCaseRelaInfo(ref clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
bool bolResult = vTeachingCaseResCaseRelaInfoDA.GetvTeachingCaseResCaseRelaInfo(ref objvTeachingCaseResCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = vTeachingCaseResCaseRelaInfoDA.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
return objvTeachingCaseResCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = vTeachingCaseResCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvTeachingCaseResCaseRelaInfoEN;
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
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = vTeachingCaseResCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseRelaInfoEN;
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
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = vTeachingCaseResCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvTeachingCaseResCaseRelaInfoEN;
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
 /// <param name = "lstvTeachingCaseResCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoFromList(long lngIdMicroTeachCaseRelaInfo, List<clsvTeachingCaseResCaseRelaInfoEN> lstvTeachingCaseResCaseRelaInfoObjLst)
{
foreach (clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN in lstvTeachingCaseResCaseRelaInfoObjLst)
{
if (objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo)
{
return objvTeachingCaseResCaseRelaInfoEN;
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
 lngIdMicroTeachCaseRelaInfo = new clsvTeachingCaseResCaseRelaInfoDA().GetFirstID(strWhereCond);
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
 arrList = vTeachingCaseResCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCaseRelaInfoDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vTeachingCaseResCaseRelaInfoDA.IsExist(lngIdMicroTeachCaseRelaInfo);
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
 bolIsExist = clsvTeachingCaseResCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vTeachingCaseResCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachingCaseResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENS, clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENT)
{
try
{
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoENT.FuncModuleId = objvTeachingCaseResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseRelaInfoENT.FuncModuleName = objvTeachingCaseResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseRelaInfoENT.IdMicroteachCase = objvTeachingCaseResCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoENT.IdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoENT.TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoENT.IdXzCollege = objvTeachingCaseResCaseRelaInfoENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseRelaInfoENT.CollegeID = objvTeachingCaseResCaseRelaInfoENS.CollegeID; //学院ID
objvTeachingCaseResCaseRelaInfoENT.CollegeName = objvTeachingCaseResCaseRelaInfoENS.CollegeName; //学院名称
objvTeachingCaseResCaseRelaInfoENT.CollegeNameA = objvTeachingCaseResCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseRelaInfoENT.MajorID = objvTeachingCaseResCaseRelaInfoENS.MajorID; //专业ID
objvTeachingCaseResCaseRelaInfoENT.MajorName = objvTeachingCaseResCaseRelaInfoENS.MajorName; //专业名称
objvTeachingCaseResCaseRelaInfoENT.CourseId = objvTeachingCaseResCaseRelaInfoENS.CourseId; //课程Id
objvTeachingCaseResCaseRelaInfoENT.CourseCode = objvTeachingCaseResCaseRelaInfoENS.CourseCode; //课程代码
objvTeachingCaseResCaseRelaInfoENT.CourseName = objvTeachingCaseResCaseRelaInfoENS.CourseName; //课程名称
objvTeachingCaseResCaseRelaInfoENT.IdResource = objvTeachingCaseResCaseRelaInfoENS.IdResource; //资源流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceID = objvTeachingCaseResCaseRelaInfoENS.ResourceID; //资源ID
objvTeachingCaseResCaseRelaInfoENT.IdFtpResource = objvTeachingCaseResCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvTeachingCaseResCaseRelaInfoENT.IdFile = objvTeachingCaseResCaseRelaInfoENS.IdFile; //文件流水号
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
objvTeachingCaseResCaseRelaInfoENT.IdResourceType = objvTeachingCaseResCaseRelaInfoENS.IdResourceType; //资源类型流水号
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
objvTeachingCaseResCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
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
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
try
{
objvTeachingCaseResCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachingCaseResCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = objvTeachingCaseResCaseRelaInfoEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = objvTeachingCaseResCaseRelaInfoEN.FuncModuleName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase = objvTeachingCaseResCaseRelaInfoEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdTeachingCaseResCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase; //教学案例资源案例流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = objvTeachingCaseResCaseRelaInfoEN.IdXzCollege == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CollegeID = objvTeachingCaseResCaseRelaInfoEN.CollegeID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CollegeName = objvTeachingCaseResCaseRelaInfoEN.CollegeName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = objvTeachingCaseResCaseRelaInfoEN.CollegeNameA == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.MajorID = objvTeachingCaseResCaseRelaInfoEN.MajorID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.MajorName = objvTeachingCaseResCaseRelaInfoEN.MajorName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CourseId = objvTeachingCaseResCaseRelaInfoEN.CourseId == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CourseCode = objvTeachingCaseResCaseRelaInfoEN.CourseCode == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.CourseName = objvTeachingCaseResCaseRelaInfoEN.CourseName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdResource = objvTeachingCaseResCaseRelaInfoEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ResourceID = objvTeachingCaseResCaseRelaInfoEN.ResourceID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = objvTeachingCaseResCaseRelaInfoEN.IdFtpResource == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdFile = objvTeachingCaseResCaseRelaInfoEN.IdFile == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileName = objvTeachingCaseResCaseRelaInfoEN.FileName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileName; //文件名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileType = objvTeachingCaseResCaseRelaInfoEN.FileType == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileType; //文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.SaveDate = objvTeachingCaseResCaseRelaInfoEN.SaveDate == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileSize = objvTeachingCaseResCaseRelaInfoEN.FileSize == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.SaveTime = objvTeachingCaseResCaseRelaInfoEN.SaveTime == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = objvTeachingCaseResCaseRelaInfoEN.FtpResourceID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = objvTeachingCaseResCaseRelaInfoEN.FileOriginalName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileDirName = objvTeachingCaseResCaseRelaInfoEN.FileDirName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileRename = objvTeachingCaseResCaseRelaInfoEN.FileRename == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = objvTeachingCaseResCaseRelaInfoEN.FileUpDate == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = objvTeachingCaseResCaseRelaInfoEN.FileUpTime == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.SaveMode = objvTeachingCaseResCaseRelaInfoEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdResourceType = objvTeachingCaseResCaseRelaInfoEN.IdResourceType == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = objvTeachingCaseResCaseRelaInfoEN.ResourceOwner == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = objvTeachingCaseResCaseRelaInfoEN.ftpFileType == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = objvTeachingCaseResCaseRelaInfoEN.ftpFileSize == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = objvTeachingCaseResCaseRelaInfoEN.FileOriginName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = objvTeachingCaseResCaseRelaInfoEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileNewName = objvTeachingCaseResCaseRelaInfoEN.FileNewName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.FileOldName = objvTeachingCaseResCaseRelaInfoEN.FileOldName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.IsVisible = objvTeachingCaseResCaseRelaInfoEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = objvTeachingCaseResCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.Flag, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.Flag = objvTeachingCaseResCaseRelaInfoEN.Flag == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.Flag; //标志
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.UpdDate = objvTeachingCaseResCaseRelaInfoEN.UpdDate == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.UpdUser = objvTeachingCaseResCaseRelaInfoEN.UpdUser == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convTeachingCaseResCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachingCaseResCaseRelaInfoEN.Memo = objvTeachingCaseResCaseRelaInfoEN.Memo == "[null]" ? null :  objvTeachingCaseResCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
try
{
if (objvTeachingCaseResCaseRelaInfoEN.FuncModuleName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = null; //功能模块名称
if (objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdTeachingCaseResCase = null; //教学案例资源案例流水号
if (objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName == "[null]") objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = null; //教学案例资源案例名称
if (objvTeachingCaseResCaseRelaInfoEN.IdXzCollege == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdXzCollege = null; //学院流水号
if (objvTeachingCaseResCaseRelaInfoEN.CollegeID == "[null]") objvTeachingCaseResCaseRelaInfoEN.CollegeID = null; //学院ID
if (objvTeachingCaseResCaseRelaInfoEN.CollegeName == "[null]") objvTeachingCaseResCaseRelaInfoEN.CollegeName = null; //学院名称
if (objvTeachingCaseResCaseRelaInfoEN.CollegeNameA == "[null]") objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = null; //学院名称简写
if (objvTeachingCaseResCaseRelaInfoEN.MajorID == "[null]") objvTeachingCaseResCaseRelaInfoEN.MajorID = null; //专业ID
if (objvTeachingCaseResCaseRelaInfoEN.MajorName == "[null]") objvTeachingCaseResCaseRelaInfoEN.MajorName = null; //专业名称
if (objvTeachingCaseResCaseRelaInfoEN.CourseId == "[null]") objvTeachingCaseResCaseRelaInfoEN.CourseId = null; //课程Id
if (objvTeachingCaseResCaseRelaInfoEN.CourseCode == "[null]") objvTeachingCaseResCaseRelaInfoEN.CourseCode = null; //课程代码
if (objvTeachingCaseResCaseRelaInfoEN.CourseName == "[null]") objvTeachingCaseResCaseRelaInfoEN.CourseName = null; //课程名称
if (objvTeachingCaseResCaseRelaInfoEN.ResourceID == "[null]") objvTeachingCaseResCaseRelaInfoEN.ResourceID = null; //资源ID
if (objvTeachingCaseResCaseRelaInfoEN.IdFtpResource == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdFtpResource = null; //FTP资源流水号
if (objvTeachingCaseResCaseRelaInfoEN.IdFile == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdFile = null; //文件流水号
if (objvTeachingCaseResCaseRelaInfoEN.FileName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileName = null; //文件名称
if (objvTeachingCaseResCaseRelaInfoEN.FileType == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileType = null; //文件类型
if (objvTeachingCaseResCaseRelaInfoEN.SaveDate == "[null]") objvTeachingCaseResCaseRelaInfoEN.SaveDate = null; //创建日期
if (objvTeachingCaseResCaseRelaInfoEN.FileSize == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileSize = null; //文件大小
if (objvTeachingCaseResCaseRelaInfoEN.SaveTime == "[null]") objvTeachingCaseResCaseRelaInfoEN.SaveTime = null; //创建时间
if (objvTeachingCaseResCaseRelaInfoEN.FtpResourceID == "[null]") objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = null; //FTP资源ID
if (objvTeachingCaseResCaseRelaInfoEN.FileOriginalName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = null; //文件原名
if (objvTeachingCaseResCaseRelaInfoEN.FileDirName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileDirName = null; //文件目录名
if (objvTeachingCaseResCaseRelaInfoEN.FileRename == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileRename = null; //文件新名
if (objvTeachingCaseResCaseRelaInfoEN.FileUpDate == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileUpDate = null; //创建日期
if (objvTeachingCaseResCaseRelaInfoEN.FileUpTime == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileUpTime = null; //创建时间
if (objvTeachingCaseResCaseRelaInfoEN.IdResourceType == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdResourceType = null; //资源类型流水号
if (objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID == "[null]") objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = null; //资源类型ID
if (objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName == "[null]") objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = null; //资源类型名称
if (objvTeachingCaseResCaseRelaInfoEN.ResourceOwner == "[null]") objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = null; //上传者
if (objvTeachingCaseResCaseRelaInfoEN.ftpFileType == "[null]") objvTeachingCaseResCaseRelaInfoEN.ftpFileType = null; //ftp文件类型
if (objvTeachingCaseResCaseRelaInfoEN.ftpFileSize == "[null]") objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = null; //ftp文件大小
if (objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner == "[null]") objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvTeachingCaseResCaseRelaInfoEN.FileOriginName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileOriginName = null; //原文件名
if (objvTeachingCaseResCaseRelaInfoEN.FileNewName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileNewName = null; //新文件名
if (objvTeachingCaseResCaseRelaInfoEN.FileOldName == "[null]") objvTeachingCaseResCaseRelaInfoEN.FileOldName = null; //旧文件名
if (objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType == "[null]") objvTeachingCaseResCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = null; //微格案例相关信息类型流水号
if (objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID == "[null]") objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = null; //微格案例相关信息类型ID
if (objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName == "[null]") objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = null; //微格案例相关信息类型名称
if (objvTeachingCaseResCaseRelaInfoEN.Flag == "[null]") objvTeachingCaseResCaseRelaInfoEN.Flag = null; //标志
if (objvTeachingCaseResCaseRelaInfoEN.UpdDate == "[null]") objvTeachingCaseResCaseRelaInfoEN.UpdDate = null; //修改日期
if (objvTeachingCaseResCaseRelaInfoEN.UpdUser == "[null]") objvTeachingCaseResCaseRelaInfoEN.UpdUser = null; //修改人
if (objvTeachingCaseResCaseRelaInfoEN.Memo == "[null]") objvTeachingCaseResCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN)
{
 vTeachingCaseResCaseRelaInfoDA.CheckProperty4Condition(objvTeachingCaseResCaseRelaInfoEN);
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseBL没有刷新缓存机制(clsTeachingCaseResCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeBL没有刷新缓存机制(clsTeachingCaseResCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroTeachCaseRelaInfo");
//if (arrvTeachingCaseResCaseRelaInfoObjLstCache == null)
//{
//arrvTeachingCaseResCaseRelaInfoObjLstCache = vTeachingCaseResCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfoCache(long lngIdMicroTeachCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Sel =
arrvTeachingCaseResCaseRelaInfoObjLstCache
.Where(x=> x.IdMicroTeachCaseRelaInfo == lngIdMicroTeachCaseRelaInfo 
);
if (arrvTeachingCaseResCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseRelaInfoEN obj = clsvTeachingCaseResCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfo(lngIdMicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachingCaseResCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetAllvTeachingCaseResCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvTeachingCaseResCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName);
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
if (strInFldName != convTeachingCaseResCaseRelaInfo.IdMicroTeachCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachingCaseResCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachingCaseResCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvTeachingCaseResCaseRelaInfo = clsvTeachingCaseResCaseRelaInfoBL.GetObjByIdMicroTeachCaseRelaInfoCache(lngIdMicroTeachCaseRelaInfo);
if (objvTeachingCaseResCaseRelaInfo == null) return "";
return objvTeachingCaseResCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvTeachingCaseResCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachingCaseResCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachingCaseResCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvTeachingCaseResCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoCond)
{
List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachingCaseResCaseRelaInfo.AttributeName)
{
if (objvTeachingCaseResCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachingCaseResCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachingCaseResCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachingCaseResCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvTeachingCaseResCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachingCaseResCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}