
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnDetailWApi
 表名:KnowledgeLearnDetail(01120153)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsKnowledgeLearnDetailWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetmId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, long lngmId, string strComparisonOp="")
	{
objKnowledgeLearnDetailEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.mId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.mId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.mId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUserId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conKnowledgeLearnDetail.UserId);
objKnowledgeLearnDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UserId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UserId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UserId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetLearnDate(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strLearnDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnDate, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(strLearnDate, 14, conKnowledgeLearnDetail.LearnDate);
objKnowledgeLearnDetailEN.LearnDate = strLearnDate; //学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.LearnDate) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.LearnDate, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.LearnDate] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetLearnModeId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strLearnModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLearnModeId, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(strLearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldForeignKey(strLearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
objKnowledgeLearnDetailEN.LearnModeId = strLearnModeId; //学习模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.LearnModeId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.LearnModeId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.LearnModeId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetCourseKnowledgeId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
objKnowledgeLearnDetailEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.CourseKnowledgeId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.CourseKnowledgeId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.CourseKnowledgeId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetId_Case(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, conKnowledgeLearnDetail.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, conKnowledgeLearnDetail.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, conKnowledgeLearnDetail.Id_Case);
objKnowledgeLearnDetailEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.Id_Case) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.Id_Case, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.Id_Case] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetId_CaseType(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strId_CaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CaseType, 4, conKnowledgeLearnDetail.Id_CaseType);
clsCheckSql.CheckFieldForeignKey(strId_CaseType, 4, conKnowledgeLearnDetail.Id_CaseType);
objKnowledgeLearnDetailEN.Id_CaseType = strId_CaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.Id_CaseType) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.Id_CaseType, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.Id_CaseType] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsRight(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsRight, string strComparisonOp="")
	{
objKnowledgeLearnDetailEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsRight) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsRight, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsRight] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsMaster(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsMaster, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMaster, conKnowledgeLearnDetail.IsMaster);
objKnowledgeLearnDetailEN.IsMaster = bolIsMaster; //是否掌握
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsMaster) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsMaster, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsMaster] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMasterDegree(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, int intMasterDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intMasterDegree, conKnowledgeLearnDetail.MasterDegree);
objKnowledgeLearnDetailEN.MasterDegree = intMasterDegree; //掌握程度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MasterDegree) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MasterDegree, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MasterDegree] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMarkerId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, conKnowledgeLearnDetail.MarkerId);
objKnowledgeLearnDetailEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MarkerId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MarkerId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MarkerId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMarkTime(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMarkTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkTime, 14, conKnowledgeLearnDetail.MarkTime);
objKnowledgeLearnDetailEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.MarkTime) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.MarkTime, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.MarkTime] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetIsAnalysis(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, bool bolIsAnalysis, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsAnalysis, conKnowledgeLearnDetail.IsAnalysis);
objKnowledgeLearnDetailEN.IsAnalysis = bolIsAnalysis; //是否分析
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.IsAnalysis) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.IsAnalysis, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.IsAnalysis] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetCourseId(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conKnowledgeLearnDetail.CourseId);
objKnowledgeLearnDetailEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.CourseId) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.CourseId, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.CourseId] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUpdDate(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeLearnDetail.UpdDate);
objKnowledgeLearnDetailEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UpdDate) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UpdDate, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UpdDate] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetUpdUser(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeLearnDetail.UpdUser);
objKnowledgeLearnDetailEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.UpdUser) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.UpdUser, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.UpdUser] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeLearnDetailEN SetMemo(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeLearnDetail.Memo);
objKnowledgeLearnDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeLearnDetailEN.dicFldComparisonOp.ContainsKey(conKnowledgeLearnDetail.Memo) == false)
{
objKnowledgeLearnDetailEN.dicFldComparisonOp.Add(conKnowledgeLearnDetail.Memo, strComparisonOp);
}
else
{
objKnowledgeLearnDetailEN.dicFldComparisonOp[conKnowledgeLearnDetail.Memo] = strComparisonOp;
}
}
return objKnowledgeLearnDetailEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetail_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.mId) == true)
{
string strComparisonOp_mId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnDetail.mId, objKnowledgeLearnDetail_Cond.mId, strComparisonOp_mId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.UserId) == true)
{
string strComparisonOp_UserId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UserId, objKnowledgeLearnDetail_Cond.UserId, strComparisonOp_UserId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.LearnDate) == true)
{
string strComparisonOp_LearnDate = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.LearnDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.LearnDate, objKnowledgeLearnDetail_Cond.LearnDate, strComparisonOp_LearnDate);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.LearnModeId) == true)
{
string strComparisonOp_LearnModeId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.LearnModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.LearnModeId, objKnowledgeLearnDetail_Cond.LearnModeId, strComparisonOp_LearnModeId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.CourseKnowledgeId, objKnowledgeLearnDetail_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.Id_Case) == true)
{
string strComparisonOp_Id_Case = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.Id_Case, objKnowledgeLearnDetail_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.Id_CaseType) == true)
{
string strComparisonOp_Id_CaseType = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.Id_CaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.Id_CaseType, objKnowledgeLearnDetail_Cond.Id_CaseType, strComparisonOp_Id_CaseType);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.IsRight) == true)
{
if (objKnowledgeLearnDetail_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsRight);
}
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.IsMaster) == true)
{
if (objKnowledgeLearnDetail_Cond.IsMaster == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsMaster);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsMaster);
}
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.MasterDegree) == true)
{
string strComparisonOp_MasterDegree = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.MasterDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeLearnDetail.MasterDegree, objKnowledgeLearnDetail_Cond.MasterDegree, strComparisonOp_MasterDegree);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.MarkerId) == true)
{
string strComparisonOp_MarkerId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.MarkerId, objKnowledgeLearnDetail_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.MarkTime) == true)
{
string strComparisonOp_MarkTime = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.MarkTime, objKnowledgeLearnDetail_Cond.MarkTime, strComparisonOp_MarkTime);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.IsAnalysis) == true)
{
if (objKnowledgeLearnDetail_Cond.IsAnalysis == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKnowledgeLearnDetail.IsAnalysis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKnowledgeLearnDetail.IsAnalysis);
}
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.CourseId) == true)
{
string strComparisonOp_CourseId = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.CourseId, objKnowledgeLearnDetail_Cond.CourseId, strComparisonOp_CourseId);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.UpdDate) == true)
{
string strComparisonOp_UpdDate = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UpdDate, objKnowledgeLearnDetail_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.UpdUser) == true)
{
string strComparisonOp_UpdUser = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.UpdUser, objKnowledgeLearnDetail_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objKnowledgeLearnDetail_Cond.IsUpdated(conKnowledgeLearnDetail.Memo) == true)
{
string strComparisonOp_Memo = objKnowledgeLearnDetail_Cond.dicFldComparisonOp[conKnowledgeLearnDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeLearnDetail.Memo, objKnowledgeLearnDetail_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 if (objKnowledgeLearnDetailEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objKnowledgeLearnDetailEN.sf_UpdFldSetStr = objKnowledgeLearnDetailEN.getsf_UpdFldSetStr();
clsKnowledgeLearnDetailWApi.CheckPropertyNew(objKnowledgeLearnDetailEN); 
bool bolResult = clsKnowledgeLearnDetailWApi.UpdateRecord(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--KnowledgeLearnDetail(知识点学习情况), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_UserId_CourseKnowledgeId_Id_Case(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeLearnDetailEN == null) return "";
if (objKnowledgeLearnDetailEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
 sbCondition.AppendFormat(" and Id_Case = '{0}'", objKnowledgeLearnDetailEN.Id_Case);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objKnowledgeLearnDetailEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
 sbCondition.AppendFormat(" and Id_Case = '{0}'", objKnowledgeLearnDetailEN.Id_Case);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
try
{
clsKnowledgeLearnDetailWApi.CheckPropertyNew(objKnowledgeLearnDetailEN); 
bool bolResult = clsKnowledgeLearnDetailWApi.AddNewRecord(objKnowledgeLearnDetailEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strWhereCond)
{
try
{
clsKnowledgeLearnDetailWApi.CheckPropertyNew(objKnowledgeLearnDetailEN); 
bool bolResult = clsKnowledgeLearnDetailWApi.UpdateWithCondition(objKnowledgeLearnDetailEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeLearnDetailWApi
{
private static readonly string mstrApiControllerName = "KnowledgeLearnDetailApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsKnowledgeLearnDetailWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
if (!Object.Equals(null, objKnowledgeLearnDetailEN.UserId) && GetStrLen(objKnowledgeLearnDetailEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.LearnDate) && GetStrLen(objKnowledgeLearnDetailEN.LearnDate) > 14)
{
 throw new Exception("字段[学习日期]的长度不能超过14!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.LearnModeId) && GetStrLen(objKnowledgeLearnDetailEN.LearnModeId) > 4)
{
 throw new Exception("字段[学习模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.CourseKnowledgeId) && GetStrLen(objKnowledgeLearnDetailEN.CourseKnowledgeId) > 8)
{
 throw new Exception("字段[知识点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.Id_Case) && GetStrLen(objKnowledgeLearnDetailEN.Id_Case) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.Id_CaseType) && GetStrLen(objKnowledgeLearnDetailEN.Id_CaseType) > 4)
{
 throw new Exception("字段[案例类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.MarkerId) && GetStrLen(objKnowledgeLearnDetailEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.MarkTime) && GetStrLen(objKnowledgeLearnDetailEN.MarkTime) > 14)
{
 throw new Exception("字段[批改时间]的长度不能超过14!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.CourseId) && GetStrLen(objKnowledgeLearnDetailEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.UpdDate) && GetStrLen(objKnowledgeLearnDetailEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.UpdUser) && GetStrLen(objKnowledgeLearnDetailEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeLearnDetailEN.Memo) && GetStrLen(objKnowledgeLearnDetailEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objKnowledgeLearnDetailEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = null;
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
objKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnDetailEN;
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
public static clsKnowledgeLearnDetailEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = null;
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
objKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnDetailEN;
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
public static clsKnowledgeLearnDetailEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = null;
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
objKnowledgeLearnDetailEN = JsonConvert.DeserializeObject<clsKnowledgeLearnDetailEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeLearnDetailEN;
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
public static clsKnowledgeLearnDetailEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeLearnDetailEN._CurrTabName_S);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Sel =
from objKnowledgeLearnDetailEN in arrKnowledgeLearnDetailObjLst_Cache
where objKnowledgeLearnDetailEN.mId == lngmId
select objKnowledgeLearnDetailEN;
if (arrKnowledgeLearnDetailObjLst_Sel.Count() == 0)
{
   clsKnowledgeLearnDetailEN obj = clsKnowledgeLearnDetailWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrKnowledgeLearnDetailObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLst(string strWhereCond)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsKnowledgeLearnDetailEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeLearnDetailEN._CurrTabName_S);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Sel =
from objKnowledgeLearnDetailEN in arrKnowledgeLearnDetailObjLst_Cache
where arrMId.Contains(objKnowledgeLearnDetailEN.mId)
select objKnowledgeLearnDetailEN;
return arrKnowledgeLearnDetailObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnDetailEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeLearnDetailEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsKnowledgeLearnDetailEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeLearnDetailEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
public static int DelKnowledgeLearnDetails(List<string> arrmId)
{
string strAction = "DelKnowledgeLearnDetails";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
public static int DelKnowledgeLearnDetailsByCond(string strWhereCond)
{
string strAction = "DelKnowledgeLearnDetailsByCond";
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
public static bool AddNewRecord(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnDetailEN>(objKnowledgeLearnDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnDetailEN>(objKnowledgeLearnDetailEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeLearnDetailWApi.ReFreshCache();
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
public static bool UpdateRecord(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
if (string.IsNullOrEmpty(objKnowledgeLearnDetailEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnDetailEN>(objKnowledgeLearnDetailEN);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objKnowledgeLearnDetailEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeLearnDetailEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeLearnDetailEN>(objKnowledgeLearnDetailEN);
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
 /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objKnowledgeLearnDetailENT">目标对象</param>
 public static void CopyTo(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS, clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT)
{
try
{
objKnowledgeLearnDetailENT.mId = objKnowledgeLearnDetailENS.mId; //mId
objKnowledgeLearnDetailENT.UserId = objKnowledgeLearnDetailENS.UserId; //用户ID
objKnowledgeLearnDetailENT.LearnDate = objKnowledgeLearnDetailENS.LearnDate; //学习日期
objKnowledgeLearnDetailENT.LearnModeId = objKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objKnowledgeLearnDetailENT.CourseKnowledgeId = objKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnDetailENT.Id_Case = objKnowledgeLearnDetailENS.Id_Case; //案例流水号
objKnowledgeLearnDetailENT.Id_CaseType = objKnowledgeLearnDetailENS.Id_CaseType; //案例类型流水号
objKnowledgeLearnDetailENT.IsRight = objKnowledgeLearnDetailENS.IsRight; //是否正确
objKnowledgeLearnDetailENT.IsMaster = objKnowledgeLearnDetailENS.IsMaster; //是否掌握
objKnowledgeLearnDetailENT.MasterDegree = objKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objKnowledgeLearnDetailENT.MarkerId = objKnowledgeLearnDetailENS.MarkerId; //打分者
objKnowledgeLearnDetailENT.MarkTime = objKnowledgeLearnDetailENS.MarkTime; //批改时间
objKnowledgeLearnDetailENT.IsAnalysis = objKnowledgeLearnDetailENS.IsAnalysis; //是否分析
objKnowledgeLearnDetailENT.CourseId = objKnowledgeLearnDetailENS.CourseId; //课程Id
objKnowledgeLearnDetailENT.UpdDate = objKnowledgeLearnDetailENS.UpdDate; //修改日期
objKnowledgeLearnDetailENT.UpdUser = objKnowledgeLearnDetailENS.UpdUser; //修改人
objKnowledgeLearnDetailENT.Memo = objKnowledgeLearnDetailENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsKnowledgeLearnDetailEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsKnowledgeLearnDetailEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsKnowledgeLearnDetailEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsKnowledgeLearnDetailEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsKnowledgeLearnDetailEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsKnowledgeLearnDetailEN.AttributeName)
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
if (clsKnowledgeLearnDetailWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeLearnDetailWApi没有刷新缓存机制(clsKnowledgeLearnDetailWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrKnowledgeLearnDetailObjLst_Cache == null)
//{
//arrKnowledgeLearnDetailObjLst_Cache = await clsKnowledgeLearnDetailWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsKnowledgeLearnDetailEN._CurrTabName_S);
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
if (clsKnowledgeLearnDetailWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsKnowledgeLearnDetailEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsKnowledgeLearnDetailWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeLearnDetailEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsKnowledgeLearnDetailEN._CurrTabName_S);
List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrKnowledgeLearnDetailObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsKnowledgeLearnDetailEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conKnowledgeLearnDetail.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conKnowledgeLearnDetail.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.LearnDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.LearnModeId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.Id_CaseType, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKnowledgeLearnDetail.IsMaster, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKnowledgeLearnDetail.MasterDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeLearnDetail.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.MarkTime, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.IsAnalysis, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKnowledgeLearnDetail.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeLearnDetail.Memo, Type.GetType("System.String"));
foreach (clsKnowledgeLearnDetailEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conKnowledgeLearnDetail.mId] = objInFor[conKnowledgeLearnDetail.mId];
objDR[conKnowledgeLearnDetail.UserId] = objInFor[conKnowledgeLearnDetail.UserId];
objDR[conKnowledgeLearnDetail.LearnDate] = objInFor[conKnowledgeLearnDetail.LearnDate];
objDR[conKnowledgeLearnDetail.LearnModeId] = objInFor[conKnowledgeLearnDetail.LearnModeId];
objDR[conKnowledgeLearnDetail.CourseKnowledgeId] = objInFor[conKnowledgeLearnDetail.CourseKnowledgeId];
objDR[conKnowledgeLearnDetail.Id_Case] = objInFor[conKnowledgeLearnDetail.Id_Case];
objDR[conKnowledgeLearnDetail.Id_CaseType] = objInFor[conKnowledgeLearnDetail.Id_CaseType];
objDR[conKnowledgeLearnDetail.IsRight] = objInFor[conKnowledgeLearnDetail.IsRight];
objDR[conKnowledgeLearnDetail.IsMaster] = objInFor[conKnowledgeLearnDetail.IsMaster];
objDR[conKnowledgeLearnDetail.MasterDegree] = objInFor[conKnowledgeLearnDetail.MasterDegree];
objDR[conKnowledgeLearnDetail.MarkerId] = objInFor[conKnowledgeLearnDetail.MarkerId];
objDR[conKnowledgeLearnDetail.MarkTime] = objInFor[conKnowledgeLearnDetail.MarkTime];
objDR[conKnowledgeLearnDetail.IsAnalysis] = objInFor[conKnowledgeLearnDetail.IsAnalysis];
objDR[conKnowledgeLearnDetail.CourseId] = objInFor[conKnowledgeLearnDetail.CourseId];
objDR[conKnowledgeLearnDetail.UpdDate] = objInFor[conKnowledgeLearnDetail.UpdDate];
objDR[conKnowledgeLearnDetail.UpdUser] = objInFor[conKnowledgeLearnDetail.UpdUser];
objDR[conKnowledgeLearnDetail.Memo] = objInFor[conKnowledgeLearnDetail.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4KnowledgeLearnDetail : clsCommFun4BL
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
clsKnowledgeLearnDetailWApi.ReFreshThisCache();
clsvKnowledgeLearnDetailWApi.ReFreshThisCache();
}
}

}