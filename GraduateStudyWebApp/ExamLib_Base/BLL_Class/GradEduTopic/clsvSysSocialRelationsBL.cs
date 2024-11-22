
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSocialRelationsBL
 表名:vSysSocialRelations(01120654)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvSysSocialRelationsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysSocialRelationsEN GetObj(this K_SocialId_vSysSocialRelations myKey)
{
clsvSysSocialRelationsEN objvSysSocialRelationsEN = clsvSysSocialRelationsBL.vSysSocialRelationsDA.GetObjBySocialId(myKey.Value);
return objvSysSocialRelationsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetSocialId(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strSocialId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialId, 10, convSysSocialRelations.SocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSocialId, 10, convSysSocialRelations.SocialId);
}
objvSysSocialRelationsEN.SocialId = strSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.SocialId) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.SocialId, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.SocialId] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetFullName(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, convSysSocialRelations.FullName);
}
objvSysSocialRelationsEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.FullName) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.FullName, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.FullName] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetNationality(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convSysSocialRelations.Nationality);
}
objvSysSocialRelationsEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.Nationality) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.Nationality, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.Nationality] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetWorkUnit(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convSysSocialRelations.WorkUnit);
}
objvSysSocialRelationsEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.WorkUnit) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.WorkUnit, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.WorkUnit] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetMajor(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convSysSocialRelations.Major);
}
objvSysSocialRelationsEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.Major) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.Major, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.Major] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetAchievement(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convSysSocialRelations.Achievement);
}
objvSysSocialRelationsEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.Achievement) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.Achievement, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.Achievement] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetDetailedDescription(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strDetailedDescription, string strComparisonOp="")
	{
objvSysSocialRelationsEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.DetailedDescription) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.DetailedDescription, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.DetailedDescription] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetLevelId(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convSysSocialRelations.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convSysSocialRelations.LevelId);
}
objvSysSocialRelationsEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.LevelId) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.LevelId, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.LevelId] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetLevelName(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convSysSocialRelations.LevelName);
}
objvSysSocialRelationsEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.LevelName) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.LevelName, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.LevelName] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetUpdUser(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysSocialRelations.UpdUser);
}
objvSysSocialRelationsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.UpdUser) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.UpdUser, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.UpdUser] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetUpdDate(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysSocialRelations.UpdDate);
}
objvSysSocialRelationsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.UpdDate) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.UpdDate, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.UpdDate] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetIsSubmit(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvSysSocialRelationsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.IsSubmit) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.IsSubmit, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.IsSubmit] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetOkCount(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, int? intOkCount, string strComparisonOp="")
	{
objvSysSocialRelationsEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.OkCount) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.OkCount, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.OkCount] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetCitationCount(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, int? intCitationCount, string strComparisonOp="")
	{
objvSysSocialRelationsEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.CitationCount) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.CitationCount, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.CitationCount] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetVersionCount(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, int? intVersionCount, string strComparisonOp="")
	{
objvSysSocialRelationsEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.VersionCount) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.VersionCount, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.VersionCount] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetIdCurrEduCls(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysSocialRelations.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysSocialRelations.IdCurrEduCls);
}
objvSysSocialRelationsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.IdCurrEduCls) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetMemo(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysSocialRelations.Memo);
}
objvSysSocialRelationsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.Memo) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.Memo, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.Memo] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetAppraiseCount(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvSysSocialRelationsEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.AppraiseCount) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.AppraiseCount, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.AppraiseCount] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetScore(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, float? fltScore, string strComparisonOp="")
	{
objvSysSocialRelationsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.Score) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.Score, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.Score] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetStuScore(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, float? fltStuScore, string strComparisonOp="")
	{
objvSysSocialRelationsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.StuScore) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.StuScore, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.StuScore] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetTeaScore(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, float? fltTeaScore, string strComparisonOp="")
	{
objvSysSocialRelationsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.TeaScore) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.TeaScore, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.TeaScore] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetCitationId(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convSysSocialRelations.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convSysSocialRelations.CitationId);
}
objvSysSocialRelationsEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.CitationId) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.CitationId, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.CitationId] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetCreateDate(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convSysSocialRelations.CreateDate);
}
objvSysSocialRelationsEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.CreateDate) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.CreateDate, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.CreateDate] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetShareId(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convSysSocialRelations.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convSysSocialRelations.ShareId);
}
objvSysSocialRelationsEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.ShareId) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.ShareId, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.ShareId] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetPdfContent(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convSysSocialRelations.PdfContent);
}
objvSysSocialRelationsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.PdfContent) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.PdfContent, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.PdfContent] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSocialRelationsEN SetPdfPageNum(this clsvSysSocialRelationsEN objvSysSocialRelationsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvSysSocialRelationsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(convSysSocialRelations.PdfPageNum) == false)
{
objvSysSocialRelationsEN.dicFldComparisonOp.Add(convSysSocialRelations.PdfPageNum, strComparisonOp);
}
else
{
objvSysSocialRelationsEN.dicFldComparisonOp[convSysSocialRelations.PdfPageNum] = strComparisonOp;
}
}
return objvSysSocialRelationsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysSocialRelationsENS">源对象</param>
 /// <param name = "objvSysSocialRelationsENT">目标对象</param>
 public static void CopyTo(this clsvSysSocialRelationsEN objvSysSocialRelationsENS, clsvSysSocialRelationsEN objvSysSocialRelationsENT)
{
try
{
objvSysSocialRelationsENT.SocialId = objvSysSocialRelationsENS.SocialId; //社会Id
objvSysSocialRelationsENT.FullName = objvSysSocialRelationsENS.FullName; //姓名
objvSysSocialRelationsENT.Nationality = objvSysSocialRelationsENS.Nationality; //国籍
objvSysSocialRelationsENT.WorkUnit = objvSysSocialRelationsENS.WorkUnit; //工作单位
objvSysSocialRelationsENT.Major = objvSysSocialRelationsENS.Major; //专业
objvSysSocialRelationsENT.Achievement = objvSysSocialRelationsENS.Achievement; //成就
objvSysSocialRelationsENT.DetailedDescription = objvSysSocialRelationsENS.DetailedDescription; //详细说明
objvSysSocialRelationsENT.LevelId = objvSysSocialRelationsENS.LevelId; //级别Id
objvSysSocialRelationsENT.LevelName = objvSysSocialRelationsENS.LevelName; //级别名称
objvSysSocialRelationsENT.UpdUser = objvSysSocialRelationsENS.UpdUser; //修改人
objvSysSocialRelationsENT.UpdDate = objvSysSocialRelationsENS.UpdDate; //修改日期
objvSysSocialRelationsENT.IsSubmit = objvSysSocialRelationsENS.IsSubmit; //是否提交
objvSysSocialRelationsENT.OkCount = objvSysSocialRelationsENS.OkCount; //点赞统计
objvSysSocialRelationsENT.CitationCount = objvSysSocialRelationsENS.CitationCount; //引用统计
objvSysSocialRelationsENT.VersionCount = objvSysSocialRelationsENS.VersionCount; //版本统计
objvSysSocialRelationsENT.IdCurrEduCls = objvSysSocialRelationsENS.IdCurrEduCls; //教学班流水号
objvSysSocialRelationsENT.Memo = objvSysSocialRelationsENS.Memo; //备注
objvSysSocialRelationsENT.AppraiseCount = objvSysSocialRelationsENS.AppraiseCount; //评论数
objvSysSocialRelationsENT.Score = objvSysSocialRelationsENS.Score; //评分
objvSysSocialRelationsENT.StuScore = objvSysSocialRelationsENS.StuScore; //学生平均分
objvSysSocialRelationsENT.TeaScore = objvSysSocialRelationsENS.TeaScore; //教师评分
objvSysSocialRelationsENT.CitationId = objvSysSocialRelationsENS.CitationId; //引用Id
objvSysSocialRelationsENT.CreateDate = objvSysSocialRelationsENS.CreateDate; //建立日期
objvSysSocialRelationsENT.ShareId = objvSysSocialRelationsENS.ShareId; //分享Id
objvSysSocialRelationsENT.PdfContent = objvSysSocialRelationsENS.PdfContent; //Pdf内容
objvSysSocialRelationsENT.PdfPageNum = objvSysSocialRelationsENS.PdfPageNum; //Pdf页码
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
 /// <param name = "objvSysSocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clsvSysSocialRelationsEN:objvSysSocialRelationsENT</returns>
 public static clsvSysSocialRelationsEN CopyTo(this clsvSysSocialRelationsEN objvSysSocialRelationsENS)
{
try
{
 clsvSysSocialRelationsEN objvSysSocialRelationsENT = new clsvSysSocialRelationsEN()
{
SocialId = objvSysSocialRelationsENS.SocialId, //社会Id
FullName = objvSysSocialRelationsENS.FullName, //姓名
Nationality = objvSysSocialRelationsENS.Nationality, //国籍
WorkUnit = objvSysSocialRelationsENS.WorkUnit, //工作单位
Major = objvSysSocialRelationsENS.Major, //专业
Achievement = objvSysSocialRelationsENS.Achievement, //成就
DetailedDescription = objvSysSocialRelationsENS.DetailedDescription, //详细说明
LevelId = objvSysSocialRelationsENS.LevelId, //级别Id
LevelName = objvSysSocialRelationsENS.LevelName, //级别名称
UpdUser = objvSysSocialRelationsENS.UpdUser, //修改人
UpdDate = objvSysSocialRelationsENS.UpdDate, //修改日期
IsSubmit = objvSysSocialRelationsENS.IsSubmit, //是否提交
OkCount = objvSysSocialRelationsENS.OkCount, //点赞统计
CitationCount = objvSysSocialRelationsENS.CitationCount, //引用统计
VersionCount = objvSysSocialRelationsENS.VersionCount, //版本统计
IdCurrEduCls = objvSysSocialRelationsENS.IdCurrEduCls, //教学班流水号
Memo = objvSysSocialRelationsENS.Memo, //备注
AppraiseCount = objvSysSocialRelationsENS.AppraiseCount, //评论数
Score = objvSysSocialRelationsENS.Score, //评分
StuScore = objvSysSocialRelationsENS.StuScore, //学生平均分
TeaScore = objvSysSocialRelationsENS.TeaScore, //教师评分
CitationId = objvSysSocialRelationsENS.CitationId, //引用Id
CreateDate = objvSysSocialRelationsENS.CreateDate, //建立日期
ShareId = objvSysSocialRelationsENS.ShareId, //分享Id
PdfContent = objvSysSocialRelationsENS.PdfContent, //Pdf内容
PdfPageNum = objvSysSocialRelationsENS.PdfPageNum, //Pdf页码
};
 return objvSysSocialRelationsENT;
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
public static void CheckProperty4Condition(this clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
 clsvSysSocialRelationsBL.vSysSocialRelationsDA.CheckProperty4Condition(objvSysSocialRelationsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysSocialRelationsEN objvSysSocialRelationsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.SocialId) == true)
{
string strComparisonOpSocialId = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.SocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.SocialId, objvSysSocialRelationsCond.SocialId, strComparisonOpSocialId);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.FullName) == true)
{
string strComparisonOpFullName = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.FullName, objvSysSocialRelationsCond.FullName, strComparisonOpFullName);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.Nationality) == true)
{
string strComparisonOpNationality = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.Nationality, objvSysSocialRelationsCond.Nationality, strComparisonOpNationality);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.WorkUnit, objvSysSocialRelationsCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.Major) == true)
{
string strComparisonOpMajor = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.Major, objvSysSocialRelationsCond.Major, strComparisonOpMajor);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.Achievement) == true)
{
string strComparisonOpAchievement = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.Achievement, objvSysSocialRelationsCond.Achievement, strComparisonOpAchievement);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.LevelId) == true)
{
string strComparisonOpLevelId = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.LevelId, objvSysSocialRelationsCond.LevelId, strComparisonOpLevelId);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.LevelName) == true)
{
string strComparisonOpLevelName = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.LevelName, objvSysSocialRelationsCond.LevelName, strComparisonOpLevelName);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.UpdUser, objvSysSocialRelationsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.UpdDate, objvSysSocialRelationsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.IsSubmit) == true)
{
if (objvSysSocialRelationsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSysSocialRelations.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSysSocialRelations.IsSubmit);
}
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.OkCount) == true)
{
string strComparisonOpOkCount = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.OkCount, objvSysSocialRelationsCond.OkCount, strComparisonOpOkCount);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.CitationCount) == true)
{
string strComparisonOpCitationCount = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.CitationCount, objvSysSocialRelationsCond.CitationCount, strComparisonOpCitationCount);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.VersionCount) == true)
{
string strComparisonOpVersionCount = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.VersionCount, objvSysSocialRelationsCond.VersionCount, strComparisonOpVersionCount);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.IdCurrEduCls, objvSysSocialRelationsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.Memo) == true)
{
string strComparisonOpMemo = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.Memo, objvSysSocialRelationsCond.Memo, strComparisonOpMemo);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.AppraiseCount, objvSysSocialRelationsCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.Score) == true)
{
string strComparisonOpScore = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.Score, objvSysSocialRelationsCond.Score, strComparisonOpScore);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.StuScore) == true)
{
string strComparisonOpStuScore = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.StuScore, objvSysSocialRelationsCond.StuScore, strComparisonOpStuScore);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.TeaScore) == true)
{
string strComparisonOpTeaScore = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.TeaScore, objvSysSocialRelationsCond.TeaScore, strComparisonOpTeaScore);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.CitationId) == true)
{
string strComparisonOpCitationId = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.CitationId, objvSysSocialRelationsCond.CitationId, strComparisonOpCitationId);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.CreateDate) == true)
{
string strComparisonOpCreateDate = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.CreateDate, objvSysSocialRelationsCond.CreateDate, strComparisonOpCreateDate);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.ShareId) == true)
{
string strComparisonOpShareId = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.ShareId, objvSysSocialRelationsCond.ShareId, strComparisonOpShareId);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.PdfContent) == true)
{
string strComparisonOpPdfContent = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSocialRelations.PdfContent, objvSysSocialRelationsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvSysSocialRelationsCond.IsUpdated(convSysSocialRelations.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvSysSocialRelationsCond.dicFldComparisonOp[convSysSocialRelations.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSocialRelations.PdfPageNum, objvSysSocialRelationsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vSysSocialRelations(社会关系表视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvSysSocialRelationsEN == null) return true;
if (objvSysSocialRelationsEN.SocialId == null || objvSysSocialRelationsEN.SocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objvSysSocialRelationsEN.SocialId);
if (clsvSysSocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SocialId !=  '{0}'", objvSysSocialRelationsEN.SocialId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objvSysSocialRelationsEN.SocialId);
if (clsvSysSocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vSysSocialRelations(社会关系表视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvSysSocialRelationsEN == null) return "";
if (objvSysSocialRelationsEN.SocialId == null || objvSysSocialRelationsEN.SocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objvSysSocialRelationsEN.SocialId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SocialId !=  '{0}'", objvSysSocialRelationsEN.SocialId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objvSysSocialRelationsEN.SocialId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysSocialRelations
{
public virtual bool UpdRelaTabDate(string strSocialId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 社会关系表视图(vSysSocialRelations)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysSocialRelationsBL
{
public static RelatedActions_vSysSocialRelations relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysSocialRelationsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysSocialRelationsDA vSysSocialRelationsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysSocialRelationsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysSocialRelationsBL()
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
if (string.IsNullOrEmpty(clsvSysSocialRelationsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysSocialRelationsEN._ConnectString);
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
public static DataTable GetDataTable_vSysSocialRelations(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysSocialRelationsDA.GetDataTable_vSysSocialRelations(strWhereCond);
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
objDT = vSysSocialRelationsDA.GetDataTable(strWhereCond);
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
objDT = vSysSocialRelationsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysSocialRelationsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysSocialRelationsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysSocialRelationsDA.GetDataTable_Top(objTopPara);
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
objDT = vSysSocialRelationsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysSocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysSocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetObjLstBySocialIdLst(List<string> arrSocialIdLst)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSocialIdLst, true);
 string strWhereCond = string.Format("SocialId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysSocialRelationsEN> GetObjLstBySocialIdLstCache(List<string> arrSocialIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLst_Sel =
arrvSysSocialRelationsObjLstCache
.Where(x => arrSocialIdLst.Contains(x.SocialId));
return arrvSysSocialRelationsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetObjLst(string strWhereCond)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
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
public static List<clsvSysSocialRelationsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysSocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysSocialRelationsEN> GetSubObjLstCache(clsvSysSocialRelationsEN objvSysSocialRelationsCond)
{
 string strIdCurrEduCls = objvSysSocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSysSocialRelationsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSysSocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysSocialRelations.AttributeName)
{
if (objvSysSocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objvSysSocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSocialRelationsCond[strFldName].ToString());
}
else
{
if (objvSysSocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysSocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysSocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysSocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysSocialRelationsCond[strFldName]));
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
public static List<clsvSysSocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
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
public static List<clsvSysSocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
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
List<clsvSysSocialRelationsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysSocialRelationsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysSocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
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
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
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
public static List<clsvSysSocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysSocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
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
public static List<clsvSysSocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysSocialRelationsEN> arrObjLst = new List<clsvSysSocialRelationsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN();
try
{
objvSysSocialRelationsEN.SocialId = objRow[convSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objvSysSocialRelationsEN.FullName = objRow[convSysSocialRelations.FullName] == DBNull.Value ? null : objRow[convSysSocialRelations.FullName].ToString().Trim(); //姓名
objvSysSocialRelationsEN.Nationality = objRow[convSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[convSysSocialRelations.Nationality].ToString().Trim(); //国籍
objvSysSocialRelationsEN.WorkUnit = objRow[convSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvSysSocialRelationsEN.Major = objRow[convSysSocialRelations.Major] == DBNull.Value ? null : objRow[convSysSocialRelations.Major].ToString().Trim(); //专业
objvSysSocialRelationsEN.Achievement = objRow[convSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[convSysSocialRelations.Achievement].ToString().Trim(); //成就
objvSysSocialRelationsEN.DetailedDescription = objRow[convSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvSysSocialRelationsEN.LevelId = objRow[convSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objvSysSocialRelationsEN.LevelName = objRow[convSysSocialRelations.LevelName] == DBNull.Value ? null : objRow[convSysSocialRelations.LevelName].ToString().Trim(); //级别名称
objvSysSocialRelationsEN.UpdUser = objRow[convSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objvSysSocialRelationsEN.UpdDate = objRow[convSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[convSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objvSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvSysSocialRelationsEN.OkCount = objRow[convSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objvSysSocialRelationsEN.CitationCount = objRow[convSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objvSysSocialRelationsEN.VersionCount = objRow[convSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objvSysSocialRelationsEN.IdCurrEduCls = objRow[convSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSocialRelationsEN.Memo = objRow[convSysSocialRelations.Memo] == DBNull.Value ? null : objRow[convSysSocialRelations.Memo].ToString().Trim(); //备注
objvSysSocialRelationsEN.AppraiseCount = objRow[convSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvSysSocialRelationsEN.Score = objRow[convSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.Score].ToString().Trim()); //评分
objvSysSocialRelationsEN.StuScore = objRow[convSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objvSysSocialRelationsEN.TeaScore = objRow[convSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objvSysSocialRelationsEN.CitationId = objRow[convSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[convSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objvSysSocialRelationsEN.CreateDate = objRow[convSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[convSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objvSysSocialRelationsEN.ShareId = objRow[convSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[convSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objvSysSocialRelationsEN.PdfContent = objRow[convSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[convSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvSysSocialRelationsEN.PdfPageNum = objRow[convSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSocialRelationsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysSocialRelations(ref clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
bool bolResult = vSysSocialRelationsDA.GetvSysSocialRelations(ref objvSysSocialRelationsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysSocialRelationsEN GetObjBySocialId(string strSocialId)
{
if (strSocialId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSocialId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSocialId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSysSocialRelationsEN objvSysSocialRelationsEN = vSysSocialRelationsDA.GetObjBySocialId(strSocialId);
return objvSysSocialRelationsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysSocialRelationsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysSocialRelationsEN objvSysSocialRelationsEN = vSysSocialRelationsDA.GetFirstObj(strWhereCond);
 return objvSysSocialRelationsEN;
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
public static clsvSysSocialRelationsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysSocialRelationsEN objvSysSocialRelationsEN = vSysSocialRelationsDA.GetObjByDataRow(objRow);
 return objvSysSocialRelationsEN;
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
public static clsvSysSocialRelationsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysSocialRelationsEN objvSysSocialRelationsEN = vSysSocialRelationsDA.GetObjByDataRow(objRow);
 return objvSysSocialRelationsEN;
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
 /// <param name = "strSocialId">所给的关键字</param>
 /// <param name = "lstvSysSocialRelationsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysSocialRelationsEN GetObjBySocialIdFromList(string strSocialId, List<clsvSysSocialRelationsEN> lstvSysSocialRelationsObjLst)
{
foreach (clsvSysSocialRelationsEN objvSysSocialRelationsEN in lstvSysSocialRelationsObjLst)
{
if (objvSysSocialRelationsEN.SocialId == strSocialId)
{
return objvSysSocialRelationsEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxSocialId;
 try
 {
 strMaxSocialId = clsvSysSocialRelationsDA.GetMaxStrId();
 return strMaxSocialId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strSocialId;
 try
 {
 strSocialId = new clsvSysSocialRelationsDA().GetFirstID(strWhereCond);
 return strSocialId;
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
 arrList = vSysSocialRelationsDA.GetID(strWhereCond);
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
bool bolIsExist = vSysSocialRelationsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSocialId)
{
if (string.IsNullOrEmpty(strSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSocialId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSysSocialRelationsDA.IsExist(strSocialId);
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
 bolIsExist = clsvSysSocialRelationsDA.IsExistTable();
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
 bolIsExist = vSysSocialRelationsDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysSocialRelationsENS">源对象</param>
 /// <param name = "objvSysSocialRelationsENT">目标对象</param>
 public static void CopyTo(clsvSysSocialRelationsEN objvSysSocialRelationsENS, clsvSysSocialRelationsEN objvSysSocialRelationsENT)
{
try
{
objvSysSocialRelationsENT.SocialId = objvSysSocialRelationsENS.SocialId; //社会Id
objvSysSocialRelationsENT.FullName = objvSysSocialRelationsENS.FullName; //姓名
objvSysSocialRelationsENT.Nationality = objvSysSocialRelationsENS.Nationality; //国籍
objvSysSocialRelationsENT.WorkUnit = objvSysSocialRelationsENS.WorkUnit; //工作单位
objvSysSocialRelationsENT.Major = objvSysSocialRelationsENS.Major; //专业
objvSysSocialRelationsENT.Achievement = objvSysSocialRelationsENS.Achievement; //成就
objvSysSocialRelationsENT.DetailedDescription = objvSysSocialRelationsENS.DetailedDescription; //详细说明
objvSysSocialRelationsENT.LevelId = objvSysSocialRelationsENS.LevelId; //级别Id
objvSysSocialRelationsENT.LevelName = objvSysSocialRelationsENS.LevelName; //级别名称
objvSysSocialRelationsENT.UpdUser = objvSysSocialRelationsENS.UpdUser; //修改人
objvSysSocialRelationsENT.UpdDate = objvSysSocialRelationsENS.UpdDate; //修改日期
objvSysSocialRelationsENT.IsSubmit = objvSysSocialRelationsENS.IsSubmit; //是否提交
objvSysSocialRelationsENT.OkCount = objvSysSocialRelationsENS.OkCount; //点赞统计
objvSysSocialRelationsENT.CitationCount = objvSysSocialRelationsENS.CitationCount; //引用统计
objvSysSocialRelationsENT.VersionCount = objvSysSocialRelationsENS.VersionCount; //版本统计
objvSysSocialRelationsENT.IdCurrEduCls = objvSysSocialRelationsENS.IdCurrEduCls; //教学班流水号
objvSysSocialRelationsENT.Memo = objvSysSocialRelationsENS.Memo; //备注
objvSysSocialRelationsENT.AppraiseCount = objvSysSocialRelationsENS.AppraiseCount; //评论数
objvSysSocialRelationsENT.Score = objvSysSocialRelationsENS.Score; //评分
objvSysSocialRelationsENT.StuScore = objvSysSocialRelationsENS.StuScore; //学生平均分
objvSysSocialRelationsENT.TeaScore = objvSysSocialRelationsENS.TeaScore; //教师评分
objvSysSocialRelationsENT.CitationId = objvSysSocialRelationsENS.CitationId; //引用Id
objvSysSocialRelationsENT.CreateDate = objvSysSocialRelationsENS.CreateDate; //建立日期
objvSysSocialRelationsENT.ShareId = objvSysSocialRelationsENS.ShareId; //分享Id
objvSysSocialRelationsENT.PdfContent = objvSysSocialRelationsENS.PdfContent; //Pdf内容
objvSysSocialRelationsENT.PdfPageNum = objvSysSocialRelationsENS.PdfPageNum; //Pdf页码
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
 /// <param name = "objvSysSocialRelationsEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
try
{
objvSysSocialRelationsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysSocialRelationsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysSocialRelations.SocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.SocialId = objvSysSocialRelationsEN.SocialId; //社会Id
}
if (arrFldSet.Contains(convSysSocialRelations.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.FullName = objvSysSocialRelationsEN.FullName == "[null]" ? null :  objvSysSocialRelationsEN.FullName; //姓名
}
if (arrFldSet.Contains(convSysSocialRelations.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.Nationality = objvSysSocialRelationsEN.Nationality == "[null]" ? null :  objvSysSocialRelationsEN.Nationality; //国籍
}
if (arrFldSet.Contains(convSysSocialRelations.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.WorkUnit = objvSysSocialRelationsEN.WorkUnit == "[null]" ? null :  objvSysSocialRelationsEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convSysSocialRelations.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.Major = objvSysSocialRelationsEN.Major == "[null]" ? null :  objvSysSocialRelationsEN.Major; //专业
}
if (arrFldSet.Contains(convSysSocialRelations.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.Achievement = objvSysSocialRelationsEN.Achievement == "[null]" ? null :  objvSysSocialRelationsEN.Achievement; //成就
}
if (arrFldSet.Contains(convSysSocialRelations.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.DetailedDescription = objvSysSocialRelationsEN.DetailedDescription == "[null]" ? null :  objvSysSocialRelationsEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(convSysSocialRelations.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.LevelId = objvSysSocialRelationsEN.LevelId == "[null]" ? null :  objvSysSocialRelationsEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convSysSocialRelations.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.LevelName = objvSysSocialRelationsEN.LevelName == "[null]" ? null :  objvSysSocialRelationsEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convSysSocialRelations.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.UpdUser = objvSysSocialRelationsEN.UpdUser == "[null]" ? null :  objvSysSocialRelationsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysSocialRelations.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.UpdDate = objvSysSocialRelationsEN.UpdDate == "[null]" ? null :  objvSysSocialRelationsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysSocialRelations.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.IsSubmit = objvSysSocialRelationsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convSysSocialRelations.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.OkCount = objvSysSocialRelationsEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convSysSocialRelations.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.CitationCount = objvSysSocialRelationsEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convSysSocialRelations.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.VersionCount = objvSysSocialRelationsEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convSysSocialRelations.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.IdCurrEduCls = objvSysSocialRelationsEN.IdCurrEduCls == "[null]" ? null :  objvSysSocialRelationsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysSocialRelations.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.Memo = objvSysSocialRelationsEN.Memo == "[null]" ? null :  objvSysSocialRelationsEN.Memo; //备注
}
if (arrFldSet.Contains(convSysSocialRelations.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.AppraiseCount = objvSysSocialRelationsEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convSysSocialRelations.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.Score = objvSysSocialRelationsEN.Score; //评分
}
if (arrFldSet.Contains(convSysSocialRelations.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.StuScore = objvSysSocialRelationsEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convSysSocialRelations.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.TeaScore = objvSysSocialRelationsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convSysSocialRelations.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.CitationId = objvSysSocialRelationsEN.CitationId == "[null]" ? null :  objvSysSocialRelationsEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convSysSocialRelations.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.CreateDate = objvSysSocialRelationsEN.CreateDate == "[null]" ? null :  objvSysSocialRelationsEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convSysSocialRelations.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.ShareId = objvSysSocialRelationsEN.ShareId == "[null]" ? null :  objvSysSocialRelationsEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convSysSocialRelations.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.PdfContent = objvSysSocialRelationsEN.PdfContent == "[null]" ? null :  objvSysSocialRelationsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convSysSocialRelations.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSocialRelationsEN.PdfPageNum = objvSysSocialRelationsEN.PdfPageNum; //Pdf页码
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
 /// <param name = "objvSysSocialRelationsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
try
{
if (objvSysSocialRelationsEN.FullName == "[null]") objvSysSocialRelationsEN.FullName = null; //姓名
if (objvSysSocialRelationsEN.Nationality == "[null]") objvSysSocialRelationsEN.Nationality = null; //国籍
if (objvSysSocialRelationsEN.WorkUnit == "[null]") objvSysSocialRelationsEN.WorkUnit = null; //工作单位
if (objvSysSocialRelationsEN.Major == "[null]") objvSysSocialRelationsEN.Major = null; //专业
if (objvSysSocialRelationsEN.Achievement == "[null]") objvSysSocialRelationsEN.Achievement = null; //成就
if (objvSysSocialRelationsEN.DetailedDescription == "[null]") objvSysSocialRelationsEN.DetailedDescription = null; //详细说明
if (objvSysSocialRelationsEN.LevelId == "[null]") objvSysSocialRelationsEN.LevelId = null; //级别Id
if (objvSysSocialRelationsEN.LevelName == "[null]") objvSysSocialRelationsEN.LevelName = null; //级别名称
if (objvSysSocialRelationsEN.UpdUser == "[null]") objvSysSocialRelationsEN.UpdUser = null; //修改人
if (objvSysSocialRelationsEN.UpdDate == "[null]") objvSysSocialRelationsEN.UpdDate = null; //修改日期
if (objvSysSocialRelationsEN.IdCurrEduCls == "[null]") objvSysSocialRelationsEN.IdCurrEduCls = null; //教学班流水号
if (objvSysSocialRelationsEN.Memo == "[null]") objvSysSocialRelationsEN.Memo = null; //备注
if (objvSysSocialRelationsEN.CitationId == "[null]") objvSysSocialRelationsEN.CitationId = null; //引用Id
if (objvSysSocialRelationsEN.CreateDate == "[null]") objvSysSocialRelationsEN.CreateDate = null; //建立日期
if (objvSysSocialRelationsEN.ShareId == "[null]") objvSysSocialRelationsEN.ShareId = null; //分享Id
if (objvSysSocialRelationsEN.PdfContent == "[null]") objvSysSocialRelationsEN.PdfContent = null; //Pdf内容
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
public static void CheckProperty4Condition(clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
 vSysSocialRelationsDA.CheckProperty4Condition(objvSysSocialRelationsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_SocialId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSysSocialRelations.SocialId); 
List<clsvSysSocialRelationsEN> arrObjLst = clsvSysSocialRelationsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSysSocialRelationsEN objvSysSocialRelationsEN = new clsvSysSocialRelationsEN()
{
SocialId = "0",
LevelName = "选[社会关系表视图]..."
};
arrObjLstSel.Insert(0, objvSysSocialRelationsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSysSocialRelations.SocialId;
objComboBox.DisplayMember = convSysSocialRelations.LevelName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_SocialId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[社会关系表视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convSysSocialRelations.SocialId); 
IEnumerable<clsvSysSocialRelationsEN> arrObjLst = clsvSysSocialRelationsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
objDDL.DataValueField = convSysSocialRelations.SocialId;
objDDL.DataTextField = convSysSocialRelations.LevelName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SocialIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[社会关系表视图]...","0");
List<clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLst = GetAllvSysSocialRelationsObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convSysSocialRelations.SocialId;
objDDL.DataTextField = convSysSocialRelations.LevelName;
objDDL.DataSource = arrvSysSocialRelationsObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsSysSocialRelationsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSocialRelationsBL没有刷新缓存机制(clsSysSocialRelationsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSecurityLevelBL没有刷新缓存机制(clsSysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SocialId");
//if (arrvSysSocialRelationsObjLstCache == null)
//{
//arrvSysSocialRelationsObjLstCache = vSysSocialRelationsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSocialId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysSocialRelationsEN GetObjBySocialIdCache(string strSocialId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLst_Sel =
arrvSysSocialRelationsObjLstCache
.Where(x=> x.SocialId == strSocialId 
);
if (arrvSysSocialRelationsObjLst_Sel.Count() == 0)
{
   clsvSysSocialRelationsEN obj = clsvSysSocialRelationsBL.GetObjBySocialId(strSocialId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSocialId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvSysSocialRelationsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSocialId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetLevelNameBySocialIdCache(string strSocialId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strSocialId) == true) return "";
//获取缓存中的对象列表
clsvSysSocialRelationsEN objvSysSocialRelations = GetObjBySocialIdCache(strSocialId, strIdCurrEduCls);
if (objvSysSocialRelations == null) return "";
return objvSysSocialRelations.LevelName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSocialId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySocialIdCache(string strSocialId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strSocialId) == true) return "";
//获取缓存中的对象列表
clsvSysSocialRelationsEN objvSysSocialRelations = GetObjBySocialIdCache(strSocialId, strIdCurrEduCls);
if (objvSysSocialRelations == null) return "";
return objvSysSocialRelations.LevelName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetAllvSysSocialRelationsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvSysSocialRelationsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysSocialRelationsEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvSysSocialRelationsEN> arrvSysSocialRelationsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSysSocialRelationsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vSysSocialRelations(社会关系表视图)
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvSysSocialRelationsEN objvSysSocialRelationsEN)
{
//检测记录是否存在
string strResult = vSysSocialRelationsDA.GetUniCondStr(objvSysSocialRelationsEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strSocialId, string strIdCurrEduCls)
{
if (strInFldName != convSysSocialRelations.SocialId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysSocialRelations.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysSocialRelations.AttributeName));
throw new Exception(strMsg);
}
var objvSysSocialRelations = clsvSysSocialRelationsBL.GetObjBySocialIdCache(strSocialId, strIdCurrEduCls);
if (objvSysSocialRelations == null) return "";
return objvSysSocialRelations[strOutFldName].ToString();
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
int intRecCount = clsvSysSocialRelationsDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysSocialRelationsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysSocialRelationsDA.GetRecCount();
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
int intRecCount = clsvSysSocialRelationsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysSocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysSocialRelationsEN objvSysSocialRelationsCond)
{
 string strIdCurrEduCls = objvSysSocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSysSocialRelationsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSysSocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysSocialRelations.AttributeName)
{
if (objvSysSocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objvSysSocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSocialRelationsCond[strFldName].ToString());
}
else
{
if (objvSysSocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysSocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysSocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysSocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysSocialRelationsCond[strFldName]));
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
 List<string> arrList = clsvSysSocialRelationsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysSocialRelationsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysSocialRelationsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}