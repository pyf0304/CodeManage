
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCase_Resource_RelWApi
 表名:vPubClassCase_Resource_Rel(01120407)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubClassCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN Setid_PubClassCase_Resource_Rel(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, long lngid_PubClassCase_Resource_Rel, string strComparisonOp="")
	{
objvPubClassCase_Resource_RelEN.id_PubClassCase_Resource_Rel = lngid_PubClassCase_Resource_Rel; //案例与资源关系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN Setid_PubClassCase(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPubClassCase_Resource_Rel.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubClassCase_Resource_Rel.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubClassCase_Resource_Rel.id_PubClassCase);
objvPubClassCase_Resource_RelEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.id_PubClassCase) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.id_PubClassCase, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_PubClassCase] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseID(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, convPubClassCase_Resource_Rel.PubClassCaseID);
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCase_Resource_Rel.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCase_Resource_Rel.PubClassCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, convPubClassCase_Resource_Rel.PubClassCaseName);
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCase_Resource_Rel.PubClassCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubClassCaseExecutor(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCase_Resource_Rel.PubClassCaseExecutor);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetDisciplineName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convPubClassCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convPubClassCase_Resource_Rel.DisciplineName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetPubCaseTypeName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strPubCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubCaseTypeName, convPubClassCase_Resource_Rel.PubCaseTypeName);
clsCheckSql.CheckFieldLen(strPubCaseTypeName, 50, convPubClassCase_Resource_Rel.PubCaseTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetStudyLevelName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convPubClassCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convPubClassCase_Resource_Rel.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIntroduction(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, convPubClassCase_Resource_Rel.Introduction);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetRecommendedDegreeId(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convPubClassCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convPubClassCase_Resource_Rel.RecommendedDegreeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetRecommendedDegreeName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convPubClassCase_Resource_Rel.RecommendedDegreeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetBrowseCount4Case(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN Setid_Resource(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convPubClassCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convPubClassCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convPubClassCase_Resource_Rel.id_Resource);
objvPubClassCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convPubClassCase_Resource_Rel.id_Resource) == false)
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp.Add(convPubClassCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvPubClassCase_Resource_RelEN.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvPubClassCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetResourceID(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convPubClassCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convPubClassCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convPubClassCase_Resource_Rel.ResourceID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetResourceName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convPubClassCase_Resource_Rel.ResourceName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetFileNewName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convPubClassCase_Resource_Rel.FileNewName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetFileOldName(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convPubClassCase_Resource_Rel.FileOldName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetIndexNO(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetMemo(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPubClassCase_Resource_Rel.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCase_Resource_RelEN SetBrowseCount(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel) == true)
{
string strComparisonOp_id_PubClassCase_Resource_Rel = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel, objvPubClassCase_Resource_Rel_Cond.id_PubClassCase_Resource_Rel, strComparisonOp_id_PubClassCase_Resource_Rel);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.id_PubClassCase, objvPubClassCase_Resource_Rel_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseID, objvPubClassCase_Resource_Rel_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseName, objvPubClassCase_Resource_Rel_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubClassCaseExecutor, objvPubClassCase_Resource_Rel_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.DisciplineName, objvPubClassCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.PubCaseTypeName) == true)
{
string strComparisonOp_PubCaseTypeName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.PubCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.PubCaseTypeName, objvPubClassCase_Resource_Rel_Cond.PubCaseTypeName, strComparisonOp_PubCaseTypeName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.StudyLevelName, objvPubClassCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.Introduction) == true)
{
string strComparisonOp_Introduction = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.Introduction, objvPubClassCase_Resource_Rel_Cond.Introduction, strComparisonOp_Introduction);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.IsDualVideo) == true)
{
if (objvPubClassCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsDualVideo);
}
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.RecommendedDegreeId, objvPubClassCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.RecommendedDegreeName, objvPubClassCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.BrowseCount4Case, objvPubClassCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.id_Resource, objvPubClassCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.ResourceID, objvPubClassCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.ResourceName, objvPubClassCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.IsExistFile) == true)
{
if (objvPubClassCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsExistFile);
}
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.FileNewName, objvPubClassCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.FileOldName, objvPubClassCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.IsMain) == true)
{
if (objvPubClassCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsMain);
}
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.IndexNO, objvPubClassCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCase_Resource_Rel.Memo, objvPubClassCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.IsVisible) == true)
{
if (objvPubClassCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCase_Resource_Rel.IsVisible);
}
}
if (objvPubClassCase_Resource_Rel_Cond.IsUpdated(convPubClassCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvPubClassCase_Resource_Rel_Cond.dicFldComparisonOp[convPubClassCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCase_Resource_Rel.BrowseCount, objvPubClassCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例与资源关系(vPubClassCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vPubClassCase_Resource_RelApi";

 public clsvPubClassCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByid_PubClassCase_Resource_Rel(long lngid_PubClassCase_Resource_Rel)
{
string strAction = "GetObjByid_PubClassCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvPubClassCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCase_Resource_RelEN;
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByid_PubClassCase_Resource_Rel_WA_Cache(long lngid_PubClassCase_Resource_Rel)
{
string strAction = "GetObjByid_PubClassCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvPubClassCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCase_Resource_RelEN;
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
public static clsvPubClassCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelEN = null;
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
objvPubClassCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvPubClassCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCase_Resource_RelEN;
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCase_Resource_RelEN GetObjByid_PubClassCase_Resource_Rel_Cache(long lngid_PubClassCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName_S);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Sel =
from objvPubClassCase_Resource_RelEN in arrvPubClassCase_Resource_RelObjLst_Cache
where objvPubClassCase_Resource_RelEN.id_PubClassCase_Resource_Rel == lngid_PubClassCase_Resource_Rel
select objvPubClassCase_Resource_RelEN;
if (arrvPubClassCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvPubClassCase_Resource_RelEN obj = clsvPubClassCase_Resource_RelWApi.GetObjByid_PubClassCase_Resource_Rel(lngid_PubClassCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstById_PubClassCase_Resource_RelLst(List<long> arrId_PubClassCase_Resource_Rel)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubClassCase_Resource_RelEN> GetObjLstById_PubClassCase_Resource_RelLst_Cache(List<long> arrId_PubClassCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName_S);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Sel =
from objvPubClassCase_Resource_RelEN in arrvPubClassCase_Resource_RelObjLst_Cache
where arrId_PubClassCase_Resource_Rel.Contains(objvPubClassCase_Resource_RelEN.id_PubClassCase_Resource_Rel)
select objvPubClassCase_Resource_RelEN;
return arrvPubClassCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstById_PubClassCase_Resource_RelLst_WA_Cache(List<long> arrId_PubClassCase_Resource_Rel)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_PubClassCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCase_Resource_Rel"] = lngid_PubClassCase_Resource_Rel.ToString()
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
 /// <param name = "objvPubClassCase_Resource_RelENS">源对象</param>
 /// <param name = "objvPubClassCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENS, clsvPubClassCase_Resource_RelEN objvPubClassCase_Resource_RelENT)
{
try
{
objvPubClassCase_Resource_RelENT.id_PubClassCase_Resource_Rel = objvPubClassCase_Resource_RelENS.id_PubClassCase_Resource_Rel; //案例与资源关系表流水号
objvPubClassCase_Resource_RelENT.id_PubClassCase = objvPubClassCase_Resource_RelENS.id_PubClassCase; //案例流水号
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
objvPubClassCase_Resource_RelENT.id_Resource = objvPubClassCase_Resource_RelENS.id_Resource; //资源流水号
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
public static DataTable ToDataTable(List<clsvPubClassCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCase_Resource_RelEN.AttributeName)
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
if (clsPubClassCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCase_Resource_RelWApi没有刷新缓存机制(clsPubClassCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCase_Resource_Rel");
//if (arrvPubClassCase_Resource_RelObjLst_Cache == null)
//{
//arrvPubClassCase_Resource_RelObjLst_Cache = await clsvPubClassCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvPubClassCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCase_Resource_RelEN._CurrTabName_S);
List<clsvPubClassCase_Resource_RelEN> arrvPubClassCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.PubCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.Introduction, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
foreach (clsvPubClassCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel] = objInFor[convPubClassCase_Resource_Rel.id_PubClassCase_Resource_Rel];
objDR[convPubClassCase_Resource_Rel.id_PubClassCase] = objInFor[convPubClassCase_Resource_Rel.id_PubClassCase];
objDR[convPubClassCase_Resource_Rel.PubClassCaseID] = objInFor[convPubClassCase_Resource_Rel.PubClassCaseID];
objDR[convPubClassCase_Resource_Rel.PubClassCaseName] = objInFor[convPubClassCase_Resource_Rel.PubClassCaseName];
objDR[convPubClassCase_Resource_Rel.PubClassCaseExecutor] = objInFor[convPubClassCase_Resource_Rel.PubClassCaseExecutor];
objDR[convPubClassCase_Resource_Rel.DisciplineName] = objInFor[convPubClassCase_Resource_Rel.DisciplineName];
objDR[convPubClassCase_Resource_Rel.PubCaseTypeName] = objInFor[convPubClassCase_Resource_Rel.PubCaseTypeName];
objDR[convPubClassCase_Resource_Rel.StudyLevelName] = objInFor[convPubClassCase_Resource_Rel.StudyLevelName];
objDR[convPubClassCase_Resource_Rel.Introduction] = objInFor[convPubClassCase_Resource_Rel.Introduction];
objDR[convPubClassCase_Resource_Rel.IsDualVideo] = objInFor[convPubClassCase_Resource_Rel.IsDualVideo];
objDR[convPubClassCase_Resource_Rel.RecommendedDegreeId] = objInFor[convPubClassCase_Resource_Rel.RecommendedDegreeId];
objDR[convPubClassCase_Resource_Rel.RecommendedDegreeName] = objInFor[convPubClassCase_Resource_Rel.RecommendedDegreeName];
objDR[convPubClassCase_Resource_Rel.BrowseCount4Case] = objInFor[convPubClassCase_Resource_Rel.BrowseCount4Case];
objDR[convPubClassCase_Resource_Rel.id_Resource] = objInFor[convPubClassCase_Resource_Rel.id_Resource];
objDR[convPubClassCase_Resource_Rel.ResourceID] = objInFor[convPubClassCase_Resource_Rel.ResourceID];
objDR[convPubClassCase_Resource_Rel.ResourceName] = objInFor[convPubClassCase_Resource_Rel.ResourceName];
objDR[convPubClassCase_Resource_Rel.IsExistFile] = objInFor[convPubClassCase_Resource_Rel.IsExistFile];
objDR[convPubClassCase_Resource_Rel.FileNewName] = objInFor[convPubClassCase_Resource_Rel.FileNewName];
objDR[convPubClassCase_Resource_Rel.FileOldName] = objInFor[convPubClassCase_Resource_Rel.FileOldName];
objDR[convPubClassCase_Resource_Rel.IsMain] = objInFor[convPubClassCase_Resource_Rel.IsMain];
objDR[convPubClassCase_Resource_Rel.IndexNO] = objInFor[convPubClassCase_Resource_Rel.IndexNO];
objDR[convPubClassCase_Resource_Rel.Memo] = objInFor[convPubClassCase_Resource_Rel.Memo];
objDR[convPubClassCase_Resource_Rel.IsVisible] = objInFor[convPubClassCase_Resource_Rel.IsVisible];
objDR[convPubClassCase_Resource_Rel.BrowseCount] = objInFor[convPubClassCase_Resource_Rel.BrowseCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}