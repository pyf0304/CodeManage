
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExcellenttTeachingTeamWApi
 表名:cc_ExcellenttTeachingTeam(01120092)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:优秀教学团队管理
 模块英文名:ExcellentTeamManage
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
public static class clscc_ExcellenttTeachingTeamWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetExcellenttTeachingTeamID(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, long lngExcellenttTeachingTeamID, string strComparisonOp="")
	{
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID = lngExcellenttTeachingTeamID; //优秀教学团队编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetViewCount(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, int intViewCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intViewCount, concc_ExcellenttTeachingTeam.ViewCount);
objcc_ExcellenttTeachingTeamEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.ViewCount) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.ViewCount, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ViewCount] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetCourseTypeID(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, concc_ExcellenttTeachingTeam.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, concc_ExcellenttTeachingTeam.CourseTypeID);
objcc_ExcellenttTeachingTeamEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.CourseTypeID) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.CourseTypeID, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.CourseTypeID] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN Setid_XzCollege(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, concc_ExcellenttTeachingTeam.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, concc_ExcellenttTeachingTeam.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, concc_ExcellenttTeachingTeam.id_XzCollege);
objcc_ExcellenttTeachingTeamEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.id_XzCollege) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.id_XzCollege, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.id_XzCollege] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamName(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeamName, concc_ExcellenttTeachingTeam.TeamName);
clsCheckSql.CheckFieldLen(strTeamName, 100, concc_ExcellenttTeachingTeam.TeamName);
objcc_ExcellenttTeachingTeamEN.TeamName = strTeamName; //团队名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamName) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamName, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamName] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamLeader(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamLeader, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeamLeader, 100, concc_ExcellenttTeachingTeam.TeamLeader);
objcc_ExcellenttTeachingTeamEN.TeamLeader = strTeamLeader; //团队带头人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamLeader) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamLeader, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamLeader] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetYear(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYear, 50, concc_ExcellenttTeachingTeam.Year);
objcc_ExcellenttTeachingTeamEN.Year = strYear; //年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.Year) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.Year, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Year] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetRecommendCount(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, int intRecommendCount, string strComparisonOp="")
	{
objcc_ExcellenttTeachingTeamEN.RecommendCount = intRecommendCount; //推荐次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.RecommendCount) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.RecommendCount, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.RecommendCount] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamIntroduction(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeamIntroduction, 5000, concc_ExcellenttTeachingTeam.TeamIntroduction);
objcc_ExcellenttTeachingTeamEN.TeamIntroduction = strTeamIntroduction; //团队简介
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamIntroduction) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamIntroduction, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamIntroduction] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamMembers(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamMembers, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeamMembers, 1000, concc_ExcellenttTeachingTeam.TeamMembers);
objcc_ExcellenttTeachingTeamEN.TeamMembers = strTeamMembers; //团队成员
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamMembers) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamMembers, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamMembers] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeaching(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeaching, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeaching, 8000, concc_ExcellenttTeachingTeam.Teaching);
objcc_ExcellenttTeachingTeamEN.Teaching = strTeaching; //教学工作
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.Teaching) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.Teaching, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Teaching] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetResearchWorking(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strResearchWorking, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResearchWorking, 8000, concc_ExcellenttTeachingTeam.ResearchWorking);
objcc_ExcellenttTeachingTeamEN.ResearchWorking = strResearchWorking; //科研工作
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.ResearchWorking) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.ResearchWorking, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ResearchWorking] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamPlanning(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamPlanning, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeamPlanning, 8000, concc_ExcellenttTeachingTeam.TeamPlanning);
objcc_ExcellenttTeachingTeamEN.TeamPlanning = strTeamPlanning; //团队规划
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamPlanning) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamPlanning, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamPlanning] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetTeamCourse(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strTeamCourse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeamCourse, 8000, concc_ExcellenttTeachingTeam.TeamCourse);
objcc_ExcellenttTeachingTeamEN.TeamCourse = strTeamCourse; //团队课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.TeamCourse) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.TeamCourse, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamCourse] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExcellenttTeachingTeamEN SetMemo(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExcellenttTeachingTeam.Memo);
objcc_ExcellenttTeachingTeamEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.ContainsKey(concc_ExcellenttTeachingTeam.Memo) == false)
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp.Add(concc_ExcellenttTeachingTeam.Memo, strComparisonOp);
}
else
{
objcc_ExcellenttTeachingTeamEN.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Memo] = strComparisonOp;
}
}
return objcc_ExcellenttTeachingTeamEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeam_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID) == true)
{
string strComparisonOp_ExcellenttTeachingTeamID = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID, objcc_ExcellenttTeachingTeam_Cond.ExcellenttTeachingTeamID, strComparisonOp_ExcellenttTeachingTeamID);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.ViewCount) == true)
{
string strComparisonOp_ViewCount = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExcellenttTeachingTeam.ViewCount, objcc_ExcellenttTeachingTeam_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.CourseTypeID, objcc_ExcellenttTeachingTeam_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.id_XzCollege, objcc_ExcellenttTeachingTeam_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamName) == true)
{
string strComparisonOp_TeamName = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamName, objcc_ExcellenttTeachingTeam_Cond.TeamName, strComparisonOp_TeamName);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamLeader) == true)
{
string strComparisonOp_TeamLeader = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamLeader];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamLeader, objcc_ExcellenttTeachingTeam_Cond.TeamLeader, strComparisonOp_TeamLeader);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.Year) == true)
{
string strComparisonOp_Year = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.Year, objcc_ExcellenttTeachingTeam_Cond.Year, strComparisonOp_Year);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.RecommendCount) == true)
{
string strComparisonOp_RecommendCount = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.RecommendCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExcellenttTeachingTeam.RecommendCount, objcc_ExcellenttTeachingTeam_Cond.RecommendCount, strComparisonOp_RecommendCount);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamIntroduction) == true)
{
string strComparisonOp_TeamIntroduction = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamIntroduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamIntroduction, objcc_ExcellenttTeachingTeam_Cond.TeamIntroduction, strComparisonOp_TeamIntroduction);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamMembers) == true)
{
string strComparisonOp_TeamMembers = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamMembers];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamMembers, objcc_ExcellenttTeachingTeam_Cond.TeamMembers, strComparisonOp_TeamMembers);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.Teaching) == true)
{
string strComparisonOp_Teaching = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Teaching];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.Teaching, objcc_ExcellenttTeachingTeam_Cond.Teaching, strComparisonOp_Teaching);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.ResearchWorking) == true)
{
string strComparisonOp_ResearchWorking = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.ResearchWorking];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.ResearchWorking, objcc_ExcellenttTeachingTeam_Cond.ResearchWorking, strComparisonOp_ResearchWorking);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamPlanning) == true)
{
string strComparisonOp_TeamPlanning = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamPlanning];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamPlanning, objcc_ExcellenttTeachingTeam_Cond.TeamPlanning, strComparisonOp_TeamPlanning);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.TeamCourse) == true)
{
string strComparisonOp_TeamCourse = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.TeamCourse];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.TeamCourse, objcc_ExcellenttTeachingTeam_Cond.TeamCourse, strComparisonOp_TeamCourse);
}
if (objcc_ExcellenttTeachingTeam_Cond.IsUpdated(concc_ExcellenttTeachingTeam.Memo) == true)
{
string strComparisonOp_Memo = objcc_ExcellenttTeachingTeam_Cond.dicFldComparisonOp[concc_ExcellenttTeachingTeam.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExcellenttTeachingTeam.Memo, objcc_ExcellenttTeachingTeam_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
 if (objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_ExcellenttTeachingTeamEN.sf_UpdFldSetStr = objcc_ExcellenttTeachingTeamEN.getsf_UpdFldSetStr();
clscc_ExcellenttTeachingTeamWApi.CheckPropertyNew(objcc_ExcellenttTeachingTeamEN); 
bool bolResult = clscc_ExcellenttTeachingTeamWApi.UpdateRecord(objcc_ExcellenttTeachingTeamEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_ExcellenttTeachingTeam(优秀教学团队), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_XzCollege_CourseTypeID(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExcellenttTeachingTeamEN == null) return "";
if (objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_XzCollege = '{0}'", objcc_ExcellenttTeachingTeamEN.id_XzCollege);
 sbCondition.AppendFormat(" and CourseTypeID = '{0}'", objcc_ExcellenttTeachingTeamEN.CourseTypeID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ExcellenttTeachingTeamID !=  {0}", objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID);
 sbCondition.AppendFormat(" and id_XzCollege = '{0}'", objcc_ExcellenttTeachingTeamEN.id_XzCollege);
 sbCondition.AppendFormat(" and CourseTypeID = '{0}'", objcc_ExcellenttTeachingTeamEN.CourseTypeID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
try
{
clscc_ExcellenttTeachingTeamWApi.CheckPropertyNew(objcc_ExcellenttTeachingTeamEN); 
bool bolResult = clscc_ExcellenttTeachingTeamWApi.AddNewRecord(objcc_ExcellenttTeachingTeamEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strWhereCond)
{
try
{
clscc_ExcellenttTeachingTeamWApi.CheckPropertyNew(objcc_ExcellenttTeachingTeamEN); 
bool bolResult = clscc_ExcellenttTeachingTeamWApi.UpdateWithCondition(objcc_ExcellenttTeachingTeamEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 优秀教学团队(cc_ExcellenttTeachingTeam)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_ExcellenttTeachingTeamWApi
{
private static readonly string mstrApiControllerName = "cc_ExcellenttTeachingTeamApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_ExcellenttTeachingTeamWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.CourseTypeID) && GetStrLen(objcc_ExcellenttTeachingTeamEN.CourseTypeID) > 4)
{
 throw new Exception("字段[课程类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.id_XzCollege) && GetStrLen(objcc_ExcellenttTeachingTeamEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamName) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamName) > 100)
{
 throw new Exception("字段[团队名称]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamLeader) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamLeader) > 100)
{
 throw new Exception("字段[团队带头人]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.Year) && GetStrLen(objcc_ExcellenttTeachingTeamEN.Year) > 50)
{
 throw new Exception("字段[年份]的长度不能超过50!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamIntroduction) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamIntroduction) > 5000)
{
 throw new Exception("字段[团队简介]的长度不能超过5000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamMembers) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamMembers) > 1000)
{
 throw new Exception("字段[团队成员]的长度不能超过1000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.Teaching) && GetStrLen(objcc_ExcellenttTeachingTeamEN.Teaching) > 8000)
{
 throw new Exception("字段[教学工作]的长度不能超过8000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.ResearchWorking) && GetStrLen(objcc_ExcellenttTeachingTeamEN.ResearchWorking) > 8000)
{
 throw new Exception("字段[科研工作]的长度不能超过8000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamPlanning) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamPlanning) > 8000)
{
 throw new Exception("字段[团队规划]的长度不能超过8000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.TeamCourse) && GetStrLen(objcc_ExcellenttTeachingTeamEN.TeamCourse) > 8000)
{
 throw new Exception("字段[团队课程]的长度不能超过8000!");
}
if (!Object.Equals(null, objcc_ExcellenttTeachingTeamEN.Memo) && GetStrLen(objcc_ExcellenttTeachingTeamEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_ExcellenttTeachingTeamEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngExcellenttTeachingTeamID">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExcellenttTeachingTeamEN GetObjByExcellenttTeachingTeamID(long lngExcellenttTeachingTeamID)
{
string strAction = "GetObjByExcellenttTeachingTeamID";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellenttTeachingTeamID"] = lngExcellenttTeachingTeamID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExcellenttTeachingTeamEN = JsonConvert.DeserializeObject<clscc_ExcellenttTeachingTeamEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExcellenttTeachingTeamEN;
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
 /// <param name = "lngExcellenttTeachingTeamID">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExcellenttTeachingTeamEN GetObjByExcellenttTeachingTeamID_WA_Cache(long lngExcellenttTeachingTeamID)
{
string strAction = "GetObjByExcellenttTeachingTeamID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellenttTeachingTeamID"] = lngExcellenttTeachingTeamID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExcellenttTeachingTeamEN = JsonConvert.DeserializeObject<clscc_ExcellenttTeachingTeamEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExcellenttTeachingTeamEN;
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
public static clscc_ExcellenttTeachingTeamEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = null;
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
objcc_ExcellenttTeachingTeamEN = JsonConvert.DeserializeObject<clscc_ExcellenttTeachingTeamEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExcellenttTeachingTeamEN;
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
 /// <param name = "lngExcellenttTeachingTeamID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExcellenttTeachingTeamEN GetObjByExcellenttTeachingTeamID_Cache(long lngExcellenttTeachingTeamID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExcellenttTeachingTeamEN._CurrTabName_S);
List<clscc_ExcellenttTeachingTeamEN> arrcc_ExcellenttTeachingTeamObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExcellenttTeachingTeamEN> arrcc_ExcellenttTeachingTeamObjLst_Sel =
from objcc_ExcellenttTeachingTeamEN in arrcc_ExcellenttTeachingTeamObjLst_Cache
where objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID == lngExcellenttTeachingTeamID
select objcc_ExcellenttTeachingTeamEN;
if (arrcc_ExcellenttTeachingTeamObjLst_Sel.Count() == 0)
{
   clscc_ExcellenttTeachingTeamEN obj = clscc_ExcellenttTeachingTeamWApi.GetObjByExcellenttTeachingTeamID(lngExcellenttTeachingTeamID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_ExcellenttTeachingTeamObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLst(string strWhereCond)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLstByExcellenttTeachingTeamIDLst(List<long> arrExcellenttTeachingTeamID)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
string strAction = "GetObjLstByExcellenttTeachingTeamIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrExcellenttTeachingTeamID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngExcellenttTeachingTeamID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_ExcellenttTeachingTeamEN> GetObjLstByExcellenttTeachingTeamIDLst_Cache(List<long> arrExcellenttTeachingTeamID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExcellenttTeachingTeamEN._CurrTabName_S);
List<clscc_ExcellenttTeachingTeamEN> arrcc_ExcellenttTeachingTeamObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExcellenttTeachingTeamEN> arrcc_ExcellenttTeachingTeamObjLst_Sel =
from objcc_ExcellenttTeachingTeamEN in arrcc_ExcellenttTeachingTeamObjLst_Cache
where arrExcellenttTeachingTeamID.Contains(objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID)
select objcc_ExcellenttTeachingTeamEN;
return arrcc_ExcellenttTeachingTeamObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLstByExcellenttTeachingTeamIDLst_WA_Cache(List<long> arrExcellenttTeachingTeamID)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
string strAction = "GetObjLstByExcellenttTeachingTeamIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrExcellenttTeachingTeamID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExcellenttTeachingTeamEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_ExcellenttTeachingTeamEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExcellenttTeachingTeamEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngExcellenttTeachingTeamID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN = clscc_ExcellenttTeachingTeamWApi.GetObjByExcellenttTeachingTeamID(lngExcellenttTeachingTeamID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngExcellenttTeachingTeamID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_ExcellenttTeachingTeams(List<string> arrExcellenttTeachingTeamID)
{
string strAction = "Delcc_ExcellenttTeachingTeams";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrExcellenttTeachingTeamID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_ExcellenttTeachingTeamsByCond(string strWhereCond)
{
string strAction = "Delcc_ExcellenttTeachingTeamsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExcellenttTeachingTeamEN>(objcc_ExcellenttTeachingTeamEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExcellenttTeachingTeamEN>(objcc_ExcellenttTeachingTeamEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN)
{
if (string.IsNullOrEmpty(objcc_ExcellenttTeachingTeamEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExcellenttTeachingTeamEN>(objcc_ExcellenttTeachingTeamEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_ExcellenttTeachingTeamEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExcellenttTeachingTeamEN.ExcellenttTeachingTeamID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExcellenttTeachingTeamEN>(objcc_ExcellenttTeachingTeamEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(long lngExcellenttTeachingTeamID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ExcellenttTeachingTeamID"] = lngExcellenttTeachingTeamID.ToString()
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objcc_ExcellenttTeachingTeamENS">源对象</param>
 /// <param name = "objcc_ExcellenttTeachingTeamENT">目标对象</param>
 public static void CopyTo(clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamENS, clscc_ExcellenttTeachingTeamEN objcc_ExcellenttTeachingTeamENT)
{
try
{
objcc_ExcellenttTeachingTeamENT.ExcellenttTeachingTeamID = objcc_ExcellenttTeachingTeamENS.ExcellenttTeachingTeamID; //优秀教学团队编号
objcc_ExcellenttTeachingTeamENT.ViewCount = objcc_ExcellenttTeachingTeamENS.ViewCount; //浏览量
objcc_ExcellenttTeachingTeamENT.CourseTypeID = objcc_ExcellenttTeachingTeamENS.CourseTypeID; //课程类型ID
objcc_ExcellenttTeachingTeamENT.id_XzCollege = objcc_ExcellenttTeachingTeamENS.id_XzCollege; //学院流水号
objcc_ExcellenttTeachingTeamENT.TeamName = objcc_ExcellenttTeachingTeamENS.TeamName; //团队名称
objcc_ExcellenttTeachingTeamENT.TeamLeader = objcc_ExcellenttTeachingTeamENS.TeamLeader; //团队带头人
objcc_ExcellenttTeachingTeamENT.Year = objcc_ExcellenttTeachingTeamENS.Year; //年份
objcc_ExcellenttTeachingTeamENT.RecommendCount = objcc_ExcellenttTeachingTeamENS.RecommendCount; //推荐次数
objcc_ExcellenttTeachingTeamENT.TeamIntroduction = objcc_ExcellenttTeachingTeamENS.TeamIntroduction; //团队简介
objcc_ExcellenttTeachingTeamENT.TeamMembers = objcc_ExcellenttTeachingTeamENS.TeamMembers; //团队成员
objcc_ExcellenttTeachingTeamENT.Teaching = objcc_ExcellenttTeachingTeamENS.Teaching; //教学工作
objcc_ExcellenttTeachingTeamENT.ResearchWorking = objcc_ExcellenttTeachingTeamENS.ResearchWorking; //科研工作
objcc_ExcellenttTeachingTeamENT.TeamPlanning = objcc_ExcellenttTeachingTeamENS.TeamPlanning; //团队规划
objcc_ExcellenttTeachingTeamENT.TeamCourse = objcc_ExcellenttTeachingTeamENS.TeamCourse; //团队课程
objcc_ExcellenttTeachingTeamENT.Memo = objcc_ExcellenttTeachingTeamENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_ExcellenttTeachingTeamEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_ExcellenttTeachingTeamEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_ExcellenttTeachingTeamEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_ExcellenttTeachingTeamEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_ExcellenttTeachingTeamEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_ExcellenttTeachingTeamEN.AttributeName)
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
if (clscc_ExcellenttTeachingTeamWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellenttTeachingTeamWApi没有刷新缓存机制(clscc_ExcellenttTeachingTeamWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ExcellenttTeachingTeamID");
//if (arrcc_ExcellenttTeachingTeamObjLst_Cache == null)
//{
//arrcc_ExcellenttTeachingTeamObjLst_Cache = await clscc_ExcellenttTeachingTeamWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_ExcellenttTeachingTeamEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_ExcellenttTeachingTeamWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_ExcellenttTeachingTeamEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_ExcellenttTeachingTeamWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExcellenttTeachingTeamEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_ExcellenttTeachingTeamEN._CurrTabName_S);
List<clscc_ExcellenttTeachingTeamEN> arrcc_ExcellenttTeachingTeamObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_ExcellenttTeachingTeamObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_ExcellenttTeachingTeamEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamName, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamLeader, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.Year, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.RecommendCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamIntroduction, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamMembers, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.Teaching, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.ResearchWorking, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamPlanning, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.TeamCourse, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExcellenttTeachingTeam.Memo, Type.GetType("System.String"));
foreach (clscc_ExcellenttTeachingTeamEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID] = objInFor[concc_ExcellenttTeachingTeam.ExcellenttTeachingTeamID];
objDR[concc_ExcellenttTeachingTeam.ViewCount] = objInFor[concc_ExcellenttTeachingTeam.ViewCount];
objDR[concc_ExcellenttTeachingTeam.CourseTypeID] = objInFor[concc_ExcellenttTeachingTeam.CourseTypeID];
objDR[concc_ExcellenttTeachingTeam.id_XzCollege] = objInFor[concc_ExcellenttTeachingTeam.id_XzCollege];
objDR[concc_ExcellenttTeachingTeam.TeamName] = objInFor[concc_ExcellenttTeachingTeam.TeamName];
objDR[concc_ExcellenttTeachingTeam.TeamLeader] = objInFor[concc_ExcellenttTeachingTeam.TeamLeader];
objDR[concc_ExcellenttTeachingTeam.Year] = objInFor[concc_ExcellenttTeachingTeam.Year];
objDR[concc_ExcellenttTeachingTeam.RecommendCount] = objInFor[concc_ExcellenttTeachingTeam.RecommendCount];
objDR[concc_ExcellenttTeachingTeam.TeamIntroduction] = objInFor[concc_ExcellenttTeachingTeam.TeamIntroduction];
objDR[concc_ExcellenttTeachingTeam.TeamMembers] = objInFor[concc_ExcellenttTeachingTeam.TeamMembers];
objDR[concc_ExcellenttTeachingTeam.Teaching] = objInFor[concc_ExcellenttTeachingTeam.Teaching];
objDR[concc_ExcellenttTeachingTeam.ResearchWorking] = objInFor[concc_ExcellenttTeachingTeam.ResearchWorking];
objDR[concc_ExcellenttTeachingTeam.TeamPlanning] = objInFor[concc_ExcellenttTeachingTeam.TeamPlanning];
objDR[concc_ExcellenttTeachingTeam.TeamCourse] = objInFor[concc_ExcellenttTeachingTeam.TeamCourse];
objDR[concc_ExcellenttTeachingTeam.Memo] = objInFor[concc_ExcellenttTeachingTeam.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 优秀教学团队(cc_ExcellenttTeachingTeam)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_ExcellenttTeachingTeam : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExcellenttTeachingTeamWApi.ReFreshThisCache();
}
}

}