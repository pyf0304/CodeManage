
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCase_Resource_RelBL
 表名:vPubClassCase_Resource_Rel(01120407)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvPubClassCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObj(this K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel myKey)
{
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = clsvPubClassCase_Resource_RelBL.vPubClassCase_Resource_RelDA.GetObjByIdPubClassCaseResourceRel(myKey.Value);
return objvPubClassCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIdPubClassCaseResourceRel(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, long lngIdPubClassCaseResourceRel, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel; //案例与资源关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIdPubClassCase(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPubClassCase_Resource_Rel.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubClassCase_Resource_Rel.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubClassCase_Resource_Rel.IdPubClassCase);
}
objvPubClassCase_Resource_RelEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IdPubClassCase) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IdPubClassCase, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdPubClassCase] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseID(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCase_Resource_Rel.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCase_Resource_Rel.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCase_Resource_Rel.PubClassCaseID);
}
objvPubClassCase_Resource_RelEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.PubClassCaseID) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.PubClassCaseID, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseID] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCase_Resource_Rel.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCase_Resource_Rel.PubClassCaseName);
}
objvPubClassCase_Resource_RelEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.PubClassCaseName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.PubClassCaseName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseExecutor(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCase_Resource_Rel.PubClassCaseExecutor);
}
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.PubClassCaseExecutor) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetDisciplineName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubClassCase_Resource_Rel.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCase_Resource_Rel.DisciplineName);
}
objvPubClassCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.DisciplineName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubCaseTypeName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCase_Resource_Rel.PubCaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCase_Resource_Rel.PubCaseTypeName);
}
objvPubClassCase_Resource_RelEN.PubCaseTypeName = strPubCaseTypeName; //公开课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.PubCaseTypeName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.PubCaseTypeName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubCaseTypeName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetStudyLevelName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubClassCase_Resource_Rel.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCase_Resource_Rel.StudyLevelName);
}
objvPubClassCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.StudyLevelName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIntroduction(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strIntroduction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPubClassCase_Resource_Rel.Introduction);
}
objvPubClassCase_Resource_RelEN.Introduction = strIntroduction; //简要介绍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.Introduction) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.Introduction, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.Introduction] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIsDualVideo(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IsDualVideo) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetRecommendedDegreeId(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPubClassCase_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPubClassCase_Resource_Rel.RecommendedDegreeId);
}
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetRecommendedDegreeName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPubClassCase_Resource_Rel.RecommendedDegreeName);
}
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetBrowseCount4Case(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.BrowseCount4Case) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIdResource(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convPubClassCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convPubClassCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convPubClassCase_Resource_Rel.IdResource);
}
objvPubClassCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IdResource) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetResourceID(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPubClassCase_Resource_Rel.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubClassCase_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubClassCase_Resource_Rel.ResourceID);
}
objvPubClassCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.ResourceID) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetResourceName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convPubClassCase_Resource_Rel.ResourceName);
}
objvPubClassCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.ResourceName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIsExistFile(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IsExistFile) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetFileNewName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubClassCase_Resource_Rel.FileNewName);
}
objvPubClassCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.FileNewName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetFileOldName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubClassCase_Resource_Rel.FileOldName);
}
objvPubClassCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.FileOldName) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIsMain(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IsMain) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIndexNO(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IndexNO) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetMemo(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubClassCase_Resource_Rel.Memo);
}
objvPubClassCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.Memo) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIsVisible(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.IsVisible) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetBrowseCount(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.BrowseCount) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objvPubClassCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENS, clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENT)
{
try
{
objvPubClassCase_Resource_RelENT.IdPubClassCaseResourceRel = objvPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPubClassCase_Resource_RelENT.IdPubClassCase = objvPubClassCase_Resource_RelENS.IdPubClassCase; //案例流水号
objvPubClassCase_Resource_RelENT.PubClassCaseID = objvPubClassCase_Resource_RelENS.PubClassCaseID; //案例ID
objvPubClassCase_Resource_RelENT.PubClassCaseName = objvPubClassCase_Resource_RelENS.PubClassCaseName; //案例课题名称
objvPubClassCase_Resource_RelENT.PubClassCaseExecutor = objvPubClassCase_Resource_RelENS.PubClassCaseExecutor; //案例执教者
objvPubClassCase_Resource_RelENT.DisciplineName = objvPubClassCase_Resource_RelENS.DisciplineName; //学科名称
objvPubClassCase_Resource_RelENT.PubCaseTypeName = objvPubClassCase_Resource_RelENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCase_Resource_RelENT.StudyLevelName = objvPubClassCase_Resource_RelENS.StudyLevelName; //学段名称
objvPubClassCase_Resource_RelENT.Introduction = objvPubClassCase_Resource_RelENS.Introduction; //简要介绍
objvPubClassCase_Resource_RelENT.IsDualVideo = objvPubClassCase_Resource_RelENS.IsDualVideo; //是否双视频
objvPubClassCase_Resource_RelENT.RecommendedDegreeId = objvPubClassCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvPubClassCase_Resource_RelENT.RecommendedDegreeName = objvPubClassCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvPubClassCase_Resource_RelENT.BrowseCount4Case = objvPubClassCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvPubClassCase_Resource_RelENT.IdResource = objvPubClassCase_Resource_RelENS.IdResource; //资源流水号
objvPubClassCase_Resource_RelENT.ResourceID = objvPubClassCase_Resource_RelENS.ResourceID; //资源ID
objvPubClassCase_Resource_RelENT.ResourceName = objvPubClassCase_Resource_RelENS.ResourceName; //资源名称
objvPubClassCase_Resource_RelENT.IsExistFile = objvPubClassCase_Resource_RelENS.IsExistFile; //是否存在文件
objvPubClassCase_Resource_RelENT.FileNewName = objvPubClassCase_Resource_RelENS.FileNewName; //新文件名
objvPubClassCase_Resource_RelENT.FileOldName = objvPubClassCase_Resource_RelENS.FileOldName; //旧文件名
objvPubClassCase_Resource_RelENT.IsMain = objvPubClassCase_Resource_RelENS.IsMain; //是否主资源
objvPubClassCase_Resource_RelENT.IndexNO = objvPubClassCase_Resource_RelENS.IndexNO; //序号
objvPubClassCase_Resource_RelENT.Memo = objvPubClassCase_Resource_RelENS.Memo; //备注
objvPubClassCase_Resource_RelENT.IsVisible = objvPubClassCase_Resource_RelENS.IsVisible; //是否显示
objvPubClassCase_Resource_RelENT.BrowseCount = objvPubClassCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objvPubClassCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCase_Resource_RelEN:objvPubClassCase_Resource_RelENT</returns>
 public static clsvPubClassCase_Resource_RelEN CopyTo(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENS)
{
try
{
 clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENT = new clsvPubClassCase_Resource_RelEN()
{
IdPubClassCaseResourceRel = objvPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel, //案例与资源关系表流水号
IdPubClassCase = objvPubClassCase_Resource_RelENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubClassCase_Resource_RelENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubClassCase_Resource_RelENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objvPubClassCase_Resource_RelENS.PubClassCaseExecutor, //案例执教者
DisciplineName = objvPubClassCase_Resource_RelENS.DisciplineName, //学科名称
PubCaseTypeName = objvPubClassCase_Resource_RelENS.PubCaseTypeName, //公开课案例类型名称
StudyLevelName = objvPubClassCase_Resource_RelENS.StudyLevelName, //学段名称
Introduction = objvPubClassCase_Resource_RelENS.Introduction, //简要介绍
IsDualVideo = objvPubClassCase_Resource_RelENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objvPubClassCase_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvPubClassCase_Resource_RelENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvPubClassCase_Resource_RelENS.BrowseCount4Case, //课例浏览次数
IdResource = objvPubClassCase_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvPubClassCase_Resource_RelENS.ResourceID, //资源ID
ResourceName = objvPubClassCase_Resource_RelENS.ResourceName, //资源名称
IsExistFile = objvPubClassCase_Resource_RelENS.IsExistFile, //是否存在文件
FileNewName = objvPubClassCase_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvPubClassCase_Resource_RelENS.FileOldName, //旧文件名
IsMain = objvPubClassCase_Resource_RelENS.IsMain, //是否主资源
IndexNO = objvPubClassCase_Resource_RelENS.IndexNO, //序号
Memo = objvPubClassCase_Resource_RelENS.Memo, //备注
IsVisible = objvPubClassCase_Resource_RelENS.IsVisible, //是否显示
BrowseCount = objvPubClassCase_Resource_RelENS.BrowseCount, //浏览次数
};
 return objvPubClassCase_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
 clsvPubClassCase_Resource_RelBL.vPubClassCase_Resource_RelDA.CheckProperty4Condition(objvPubClassCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel) == true)
{
string strComparisonOpIdPubClassCaseResourceRel = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, objvPubClassCase_Resource_RelCond.IdPubClassCaseResourceRel, strComparisonOpIdPubClassCaseResourceRel);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.IdPubClassCase, objvPubClassCase_Resource_RelCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseID, objvPubClassCase_Resource_RelCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseName, objvPubClassCase_Resource_RelCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseExecutor, objvPubClassCase_Resource_RelCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.DisciplineName, objvPubClassCase_Resource_RelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.PubCaseTypeName) == true)
{
string strComparisonOpPubCaseTypeName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubCaseTypeName, objvPubClassCase_Resource_RelCond.PubCaseTypeName, strComparisonOpPubCaseTypeName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.StudyLevelName, objvPubClassCase_Resource_RelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.Introduction) == true)
{
string strComparisonOpIntroduction = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.Introduction, objvPubClassCase_Resource_RelCond.Introduction, strComparisonOpIntroduction);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IsDualVideo) == true)
{
if (objvPubClassCase_Resource_RelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsDualVideo);
}
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.RecommendedDegreeId, objvPubClassCase_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.RecommendedDegreeName, objvPubClassCase_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.BrowseCount4Case, objvPubClassCase_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.IdResource, objvPubClassCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.ResourceID, objvPubClassCase_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.ResourceName, objvPubClassCase_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IsExistFile) == true)
{
if (objvPubClassCase_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsExistFile);
}
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.FileNewName, objvPubClassCase_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.FileOldName, objvPubClassCase_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IsMain) == true)
{
if (objvPubClassCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsMain);
}
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.IndexNO, objvPubClassCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.Memo, objvPubClassCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.IsVisible) == true)
{
if (objvPubClassCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsVisible);
}
}
if (objvPubClassCase_Resource_RelCond.IsUpdated(convPubClassCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.BrowseCount, objvPubClassCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例与资源关系(vPubClassCase_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCase_Resource_RelBL
{
public static RelatedActions_vPubClassCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCase_Resource_RelDA vPubClassCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCase_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvPubClassCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vPubClassCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCase_Resource_RelDA.GetDataTable_vPubClassCase_Resource_Rel(strWhereCond);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubClassCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByIdPubClassCaseResourceRelLst(List<long> arrIdPubClassCaseResourceRelLst)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseResourceRelLst);
 string strWhereCond = string.Format("IdPubClassCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCase_Resource_RelEN> GetObjLstByIdPubClassCaseResourceRelLstCache(List<long> arrIdPubClassCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Sel =
arrvPubClassCase_Resource_RelObjLstCache
.Where(x => arrIdPubClassCaseResourceRelLst.Contains(x.IdPubClassCaseResourceRel));
return arrvPubClassCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCase_Resource_RelEN> GetSubObjLstCache(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelCond)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCase_Resource_Rel.AttributeName)
{
if (objvPubClassCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvPubClassCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCase_Resource_RelCond[strFldName]));
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
List<clsvPubClassCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubClassCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubClassCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
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
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
public static List<clsvPubClassCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLst = new List<clsvPubClassCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = new clsvPubClassCase_Resource_RelEN();
try
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPubClassCase_Resource_RelEN.IdPubClassCase = objRow[convPubClassCase_Resource_Rel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCase_Resource_RelEN.PubClassCaseID = objRow[convPubClassCase_Resource_Rel.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCase_Resource_RelEN.PubClassCaseName = objRow[convPubClassCase_Resource_Rel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCase_Resource_RelEN.DisciplineName = objRow[convPubClassCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objRow[convPubClassCase_Resource_Rel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPubClassCase_Resource_RelEN.StudyLevelName = objRow[convPubClassCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvPubClassCase_Resource_RelEN.Introduction = objRow[convPubClassCase_Resource_Rel.Introduction] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Introduction].ToString().Trim(); //简要介绍
objvPubClassCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objRow[convPubClassCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvPubClassCase_Resource_RelEN.IdResource = objRow[convPubClassCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvPubClassCase_Resource_RelEN.ResourceID = objRow[convPubClassCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvPubClassCase_Resource_RelEN.ResourceName = objRow[convPubClassCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvPubClassCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvPubClassCase_Resource_RelEN.FileNewName = objRow[convPubClassCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvPubClassCase_Resource_RelEN.FileOldName = objRow[convPubClassCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvPubClassCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvPubClassCase_Resource_RelEN.IndexNO = objRow[convPubClassCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvPubClassCase_Resource_RelEN.Memo = objRow[convPubClassCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convPubClassCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvPubClassCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvPubClassCase_Resource_RelEN.BrowseCount = objRow[convPubClassCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCase_Resource_Rel(ref clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
bool bolResult = vPubClassCase_Resource_RelDA.GetvPubClassCase_Resource_Rel(ref objvPubClassCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = vPubClassCase_Resource_RelDA.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
return objvPubClassCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = vPubClassCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvPubClassCase_Resource_RelEN;
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
public static clsvPubClassCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = vPubClassCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvPubClassCase_Resource_RelEN;
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
public static clsvPubClassCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = vPubClassCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvPubClassCase_Resource_RelEN;
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
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvPubClassCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRelFromList(long lngIdPubClassCaseResourceRel, List<clsvPubClassCase_Resource_RelEN> lstvPubClassCase_Resource_RelObjLst)
{
foreach (clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN in lstvPubClassCase_Resource_RelObjLst)
{
if (objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel)
{
return objvPubClassCase_Resource_RelEN;
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
 long lngIdPubClassCaseResourceRel;
 try
 {
 lngIdPubClassCaseResourceRel = new clsvPubClassCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseResourceRel;
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
 arrList = vPubClassCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vPubClassCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vPubClassCase_Resource_RelDA.IsExist(lngIdPubClassCaseResourceRel);
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
 bolIsExist = clsvPubClassCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = vPubClassCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objvPubClassCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENS, clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENT)
{
try
{
objvPubClassCase_Resource_RelENT.IdPubClassCaseResourceRel = objvPubClassCase_Resource_RelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPubClassCase_Resource_RelENT.IdPubClassCase = objvPubClassCase_Resource_RelENS.IdPubClassCase; //案例流水号
objvPubClassCase_Resource_RelENT.PubClassCaseID = objvPubClassCase_Resource_RelENS.PubClassCaseID; //案例ID
objvPubClassCase_Resource_RelENT.PubClassCaseName = objvPubClassCase_Resource_RelENS.PubClassCaseName; //案例课题名称
objvPubClassCase_Resource_RelENT.PubClassCaseExecutor = objvPubClassCase_Resource_RelENS.PubClassCaseExecutor; //案例执教者
objvPubClassCase_Resource_RelENT.DisciplineName = objvPubClassCase_Resource_RelENS.DisciplineName; //学科名称
objvPubClassCase_Resource_RelENT.PubCaseTypeName = objvPubClassCase_Resource_RelENS.PubCaseTypeName; //公开课案例类型名称
objvPubClassCase_Resource_RelENT.StudyLevelName = objvPubClassCase_Resource_RelENS.StudyLevelName; //学段名称
objvPubClassCase_Resource_RelENT.Introduction = objvPubClassCase_Resource_RelENS.Introduction; //简要介绍
objvPubClassCase_Resource_RelENT.IsDualVideo = objvPubClassCase_Resource_RelENS.IsDualVideo; //是否双视频
objvPubClassCase_Resource_RelENT.RecommendedDegreeId = objvPubClassCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvPubClassCase_Resource_RelENT.RecommendedDegreeName = objvPubClassCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvPubClassCase_Resource_RelENT.BrowseCount4Case = objvPubClassCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvPubClassCase_Resource_RelENT.IdResource = objvPubClassCase_Resource_RelENS.IdResource; //资源流水号
objvPubClassCase_Resource_RelENT.ResourceID = objvPubClassCase_Resource_RelENS.ResourceID; //资源ID
objvPubClassCase_Resource_RelENT.ResourceName = objvPubClassCase_Resource_RelENS.ResourceName; //资源名称
objvPubClassCase_Resource_RelENT.IsExistFile = objvPubClassCase_Resource_RelENS.IsExistFile; //是否存在文件
objvPubClassCase_Resource_RelENT.FileNewName = objvPubClassCase_Resource_RelENS.FileNewName; //新文件名
objvPubClassCase_Resource_RelENT.FileOldName = objvPubClassCase_Resource_RelENS.FileOldName; //旧文件名
objvPubClassCase_Resource_RelENT.IsMain = objvPubClassCase_Resource_RelENS.IsMain; //是否主资源
objvPubClassCase_Resource_RelENT.IndexNO = objvPubClassCase_Resource_RelENS.IndexNO; //序号
objvPubClassCase_Resource_RelENT.Memo = objvPubClassCase_Resource_RelENS.Memo; //备注
objvPubClassCase_Resource_RelENT.IsVisible = objvPubClassCase_Resource_RelENS.IsVisible; //是否显示
objvPubClassCase_Resource_RelENT.BrowseCount = objvPubClassCase_Resource_RelENS.BrowseCount; //浏览次数
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
 /// <param name = "objvPubClassCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
try
{
objvPubClassCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel = objvPubClassCase_Resource_RelEN.IdPubClassCaseResourceRel; //案例与资源关系表流水号
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IdPubClassCase = objvPubClassCase_Resource_RelEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.PubClassCaseID = objvPubClassCase_Resource_RelEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.PubClassCaseName = objvPubClassCase_Resource_RelEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = objvPubClassCase_Resource_RelEN.PubClassCaseExecutor == "[null]" ? null :  objvPubClassCase_Resource_RelEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.DisciplineName = objvPubClassCase_Resource_RelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.PubCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.PubCaseTypeName = objvPubClassCase_Resource_RelEN.PubCaseTypeName; //公开课案例类型名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.StudyLevelName = objvPubClassCase_Resource_RelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.Introduction, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.Introduction = objvPubClassCase_Resource_RelEN.Introduction == "[null]" ? null :  objvPubClassCase_Resource_RelEN.Introduction; //简要介绍
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IsDualVideo = objvPubClassCase_Resource_RelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.RecommendedDegreeId = objvPubClassCase_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvPubClassCase_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.RecommendedDegreeName = objvPubClassCase_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvPubClassCase_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.BrowseCount4Case = objvPubClassCase_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IdResource = objvPubClassCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.ResourceID = objvPubClassCase_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.ResourceName = objvPubClassCase_Resource_RelEN.ResourceName == "[null]" ? null :  objvPubClassCase_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IsExistFile = objvPubClassCase_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.FileNewName = objvPubClassCase_Resource_RelEN.FileNewName == "[null]" ? null :  objvPubClassCase_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.FileOldName = objvPubClassCase_Resource_RelEN.FileOldName == "[null]" ? null :  objvPubClassCase_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IsMain = objvPubClassCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IndexNO = objvPubClassCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.Memo = objvPubClassCase_Resource_RelEN.Memo == "[null]" ? null :  objvPubClassCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.IsVisible = objvPubClassCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convPubClassCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCase_Resource_RelEN.BrowseCount = objvPubClassCase_Resource_RelEN.BrowseCount; //浏览次数
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
 /// <param name = "objvPubClassCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
try
{
if (objvPubClassCase_Resource_RelEN.PubClassCaseExecutor == "[null]") objvPubClassCase_Resource_RelEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubClassCase_Resource_RelEN.Introduction == "[null]") objvPubClassCase_Resource_RelEN.Introduction = null; //简要介绍
if (objvPubClassCase_Resource_RelEN.RecommendedDegreeId == "[null]") objvPubClassCase_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvPubClassCase_Resource_RelEN.RecommendedDegreeName == "[null]") objvPubClassCase_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvPubClassCase_Resource_RelEN.ResourceName == "[null]") objvPubClassCase_Resource_RelEN.ResourceName = null; //资源名称
if (objvPubClassCase_Resource_RelEN.FileNewName == "[null]") objvPubClassCase_Resource_RelEN.FileNewName = null; //新文件名
if (objvPubClassCase_Resource_RelEN.FileOldName == "[null]") objvPubClassCase_Resource_RelEN.FileOldName = null; //旧文件名
if (objvPubClassCase_Resource_RelEN.Memo == "[null]") objvPubClassCase_Resource_RelEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN)
{
 vPubClassCase_Resource_RelDA.CheckProperty4Condition(objvPubClassCase_Resource_RelEN);
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
if (clsPubClassCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCase_Resource_RelBL没有刷新缓存机制(clsPubClassCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeBL没有刷新缓存机制(clsPubCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseResourceRel");
//if (arrvPubClassCase_Resource_RelObjLstCache == null)
//{
//arrvPubClassCase_Resource_RelObjLstCache = vPubClassCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByIdPubClassCaseResourceRelCache(long lngIdPubClassCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Sel =
arrvPubClassCase_Resource_RelObjLstCache
.Where(x=> x.IdPubClassCaseResourceRel == lngIdPubClassCaseResourceRel 
);
if (arrvPubClassCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvPubClassCase_Resource_RelEN obj = clsvPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRel(lngIdPubClassCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetAllvPubClassCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvPubClassCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseResourceRel)
{
if (strInFldName != convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCase_Resource_Rel = clsvPubClassCase_Resource_RelBL.GetObjByIdPubClassCaseResourceRelCache(lngIdPubClassCaseResourceRel);
if (objvPubClassCase_Resource_Rel == null) return "";
return objvPubClassCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvPubClassCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubClassCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvPubClassCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelCond)
{
List<clsvPubClassCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCase_Resource_Rel.AttributeName)
{
if (objvPubClassCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvPubClassCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvPubClassCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}