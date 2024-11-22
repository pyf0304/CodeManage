
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SocialRelationsBL
 表名:vzx_SocialRelations(01120852)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_SocialRelationsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SocialRelationsEN GetObj(this K_zxSocialId_vzx_SocialRelations myKey)
{
clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = clsvzx_SocialRelationsBL.vzx_SocialRelationsDA.GetObjByzxSocialId(myKey.Value);
return objvzx_SocialRelationsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetzxSocialId(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strzxSocialId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSocialId, 10, convzx_SocialRelations.zxSocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSocialId, 10, convzx_SocialRelations.zxSocialId);
}
objvzx_SocialRelationsEN.zxSocialId = strzxSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.zxSocialId) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.zxSocialId, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.zxSocialId] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetFullName(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, convzx_SocialRelations.FullName);
}
objvzx_SocialRelationsEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.FullName) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.FullName, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.FullName] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetNationality(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convzx_SocialRelations.Nationality);
}
objvzx_SocialRelationsEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.Nationality) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.Nationality, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.Nationality] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetWorkUnit(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convzx_SocialRelations.WorkUnit);
}
objvzx_SocialRelationsEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.WorkUnit) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.WorkUnit, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.WorkUnit] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetMajor(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convzx_SocialRelations.Major);
}
objvzx_SocialRelationsEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.Major) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.Major, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.Major] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetAchievement(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convzx_SocialRelations.Achievement);
}
objvzx_SocialRelationsEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.Achievement) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.Achievement, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.Achievement] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetDetailedDescription(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strDetailedDescription, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.DetailedDescription) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.DetailedDescription, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.DetailedDescription] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetUpdUser(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_SocialRelations.UpdUser);
}
objvzx_SocialRelationsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.UpdUser) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.UpdUser, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.UpdUser] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetCreateDate(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_SocialRelations.CreateDate);
}
objvzx_SocialRelationsEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.CreateDate) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.CreateDate, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.CreateDate] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetUpdDate(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_SocialRelations.UpdDate);
}
objvzx_SocialRelationsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.UpdDate) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.UpdDate, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.UpdDate] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetIsSubmit(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.IsSubmit) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.IsSubmit, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.IsSubmit] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetVoteCount(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.VoteCount) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.VoteCount, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.VoteCount] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetCitationCount(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intCitationCount, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.CitationCount) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.CitationCount, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.CitationCount] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetVersionCount(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.VersionCount) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.VersionCount, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.VersionCount] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetIdCurrEduCls(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_SocialRelations.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_SocialRelations.IdCurrEduCls);
}
objvzx_SocialRelationsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.IdCurrEduCls) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetAppraiseCount(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.AppraiseCount) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.AppraiseCount, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.AppraiseCount] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetScore(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, float? fltScore, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.Score) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.Score, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.Score] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetGroupTextId(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_SocialRelations.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_SocialRelations.GroupTextId);
}
objvzx_SocialRelationsEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.GroupTextId) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.GroupTextId, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.GroupTextId] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfZoom(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_SocialRelations.PdfZoom);
}
objvzx_SocialRelationsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfZoom) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfZoom, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfZoom] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfPageTop(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfPageTop) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfPageTop, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfPageTop] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfPageNumIn(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_SocialRelations.PdfPageNumIn);
}
objvzx_SocialRelationsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfPageNumIn) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfDivTop(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_SocialRelations.PdfDivTop);
}
objvzx_SocialRelationsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfDivTop) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfDivTop, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfDivTop] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfDivLet(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_SocialRelations.PdfDivLet);
}
objvzx_SocialRelationsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfDivLet) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfDivLet, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfDivLet] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetMemo(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_SocialRelations.Memo);
}
objvzx_SocialRelationsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.Memo) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.Memo, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.Memo] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfPageNum(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfPageNum) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfPageNum, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfPageNum] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetPdfContent(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_SocialRelations.PdfContent);
}
objvzx_SocialRelationsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.PdfContent) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.PdfContent, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.PdfContent] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetzxShareId(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_SocialRelations.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_SocialRelations.zxShareId);
}
objvzx_SocialRelationsEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.zxShareId) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.zxShareId, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.zxShareId] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetTextId(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_SocialRelations.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_SocialRelations.TextId);
}
objvzx_SocialRelationsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.TextId) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.TextId, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.TextId] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetTeaScore(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.TeaScore) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.TeaScore, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.TeaScore] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetStuScore(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_SocialRelationsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.StuScore) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.StuScore, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.StuScore] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SocialRelationsEN SetzxLevelId(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, convzx_SocialRelations.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, convzx_SocialRelations.zxLevelId);
}
objvzx_SocialRelationsEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(convzx_SocialRelations.zxLevelId) == false)
{
objvzx_SocialRelationsEN.dicFldComparisonOp.Add(convzx_SocialRelations.zxLevelId, strComparisonOp);
}
else
{
objvzx_SocialRelationsEN.dicFldComparisonOp[convzx_SocialRelations.zxLevelId] = strComparisonOp;
}
}
return objvzx_SocialRelationsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <param name = "objvzx_SocialRelationsENT">目标对象</param>
 public static void CopyTo(this clsvzx_SocialRelationsEN objvzx_SocialRelationsENS, clsvzx_SocialRelationsEN objvzx_SocialRelationsENT)
{
try
{
objvzx_SocialRelationsENT.zxSocialId = objvzx_SocialRelationsENS.zxSocialId; //社会Id
objvzx_SocialRelationsENT.FullName = objvzx_SocialRelationsENS.FullName; //姓名
objvzx_SocialRelationsENT.Nationality = objvzx_SocialRelationsENS.Nationality; //国籍
objvzx_SocialRelationsENT.WorkUnit = objvzx_SocialRelationsENS.WorkUnit; //工作单位
objvzx_SocialRelationsENT.Major = objvzx_SocialRelationsENS.Major; //专业
objvzx_SocialRelationsENT.Achievement = objvzx_SocialRelationsENS.Achievement; //成就
objvzx_SocialRelationsENT.DetailedDescription = objvzx_SocialRelationsENS.DetailedDescription; //详细说明
objvzx_SocialRelationsENT.UpdUser = objvzx_SocialRelationsENS.UpdUser; //修改人
objvzx_SocialRelationsENT.CreateDate = objvzx_SocialRelationsENS.CreateDate; //建立日期
objvzx_SocialRelationsENT.UpdDate = objvzx_SocialRelationsENS.UpdDate; //修改日期
objvzx_SocialRelationsENT.IsSubmit = objvzx_SocialRelationsENS.IsSubmit; //是否提交
objvzx_SocialRelationsENT.VoteCount = objvzx_SocialRelationsENS.VoteCount; //点赞计数
objvzx_SocialRelationsENT.CitationCount = objvzx_SocialRelationsENS.CitationCount; //引用统计
objvzx_SocialRelationsENT.VersionCount = objvzx_SocialRelationsENS.VersionCount; //版本统计
objvzx_SocialRelationsENT.IdCurrEduCls = objvzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objvzx_SocialRelationsENT.AppraiseCount = objvzx_SocialRelationsENS.AppraiseCount; //评论数
objvzx_SocialRelationsENT.Score = objvzx_SocialRelationsENS.Score; //评分
objvzx_SocialRelationsENT.GroupTextId = objvzx_SocialRelationsENS.GroupTextId; //小组Id
objvzx_SocialRelationsENT.PdfZoom = objvzx_SocialRelationsENS.PdfZoom; //PdfZoom
objvzx_SocialRelationsENT.PdfPageTop = objvzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objvzx_SocialRelationsENT.PdfPageNumIn = objvzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_SocialRelationsENT.PdfDivTop = objvzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objvzx_SocialRelationsENT.PdfDivLet = objvzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objvzx_SocialRelationsENT.Memo = objvzx_SocialRelationsENS.Memo; //备注
objvzx_SocialRelationsENT.PdfPageNum = objvzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objvzx_SocialRelationsENT.PdfContent = objvzx_SocialRelationsENS.PdfContent; //Pdf内容
objvzx_SocialRelationsENT.zxShareId = objvzx_SocialRelationsENS.zxShareId; //分享Id
objvzx_SocialRelationsENT.TextId = objvzx_SocialRelationsENS.TextId; //课件Id
objvzx_SocialRelationsENT.TeaScore = objvzx_SocialRelationsENS.TeaScore; //教师评分
objvzx_SocialRelationsENT.StuScore = objvzx_SocialRelationsENS.StuScore; //学生平均分
objvzx_SocialRelationsENT.zxLevelId = objvzx_SocialRelationsENS.zxLevelId; //级别Id
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
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SocialRelationsEN:objvzx_SocialRelationsENT</returns>
 public static clsvzx_SocialRelationsEN CopyTo(this clsvzx_SocialRelationsEN objvzx_SocialRelationsENS)
{
try
{
 clsvzx_SocialRelationsEN objvzx_SocialRelationsENT = new clsvzx_SocialRelationsEN()
{
zxSocialId = objvzx_SocialRelationsENS.zxSocialId, //社会Id
FullName = objvzx_SocialRelationsENS.FullName, //姓名
Nationality = objvzx_SocialRelationsENS.Nationality, //国籍
WorkUnit = objvzx_SocialRelationsENS.WorkUnit, //工作单位
Major = objvzx_SocialRelationsENS.Major, //专业
Achievement = objvzx_SocialRelationsENS.Achievement, //成就
DetailedDescription = objvzx_SocialRelationsENS.DetailedDescription, //详细说明
UpdUser = objvzx_SocialRelationsENS.UpdUser, //修改人
CreateDate = objvzx_SocialRelationsENS.CreateDate, //建立日期
UpdDate = objvzx_SocialRelationsENS.UpdDate, //修改日期
IsSubmit = objvzx_SocialRelationsENS.IsSubmit, //是否提交
VoteCount = objvzx_SocialRelationsENS.VoteCount, //点赞计数
CitationCount = objvzx_SocialRelationsENS.CitationCount, //引用统计
VersionCount = objvzx_SocialRelationsENS.VersionCount, //版本统计
IdCurrEduCls = objvzx_SocialRelationsENS.IdCurrEduCls, //教学班流水号
AppraiseCount = objvzx_SocialRelationsENS.AppraiseCount, //评论数
Score = objvzx_SocialRelationsENS.Score, //评分
GroupTextId = objvzx_SocialRelationsENS.GroupTextId, //小组Id
PdfZoom = objvzx_SocialRelationsENS.PdfZoom, //PdfZoom
PdfPageTop = objvzx_SocialRelationsENS.PdfPageTop, //pdf页面顶部位置
PdfPageNumIn = objvzx_SocialRelationsENS.PdfPageNumIn, //PdfPageNumIn
PdfDivTop = objvzx_SocialRelationsENS.PdfDivTop, //PdfDivTop
PdfDivLet = objvzx_SocialRelationsENS.PdfDivLet, //PdfDivLet
Memo = objvzx_SocialRelationsENS.Memo, //备注
PdfPageNum = objvzx_SocialRelationsENS.PdfPageNum, //Pdf页码
PdfContent = objvzx_SocialRelationsENS.PdfContent, //Pdf内容
zxShareId = objvzx_SocialRelationsENS.zxShareId, //分享Id
TextId = objvzx_SocialRelationsENS.TextId, //课件Id
TeaScore = objvzx_SocialRelationsENS.TeaScore, //教师评分
StuScore = objvzx_SocialRelationsENS.StuScore, //学生平均分
zxLevelId = objvzx_SocialRelationsENS.zxLevelId, //级别Id
};
 return objvzx_SocialRelationsENT;
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
public static void CheckProperty4Condition(this clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
 clsvzx_SocialRelationsBL.vzx_SocialRelationsDA.CheckProperty4Condition(objvzx_SocialRelationsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SocialRelationsEN objvzx_SocialRelationsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.zxSocialId) == true)
{
string strComparisonOpzxSocialId = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.zxSocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.zxSocialId, objvzx_SocialRelationsCond.zxSocialId, strComparisonOpzxSocialId);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.FullName) == true)
{
string strComparisonOpFullName = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.FullName, objvzx_SocialRelationsCond.FullName, strComparisonOpFullName);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.Nationality) == true)
{
string strComparisonOpNationality = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.Nationality, objvzx_SocialRelationsCond.Nationality, strComparisonOpNationality);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.WorkUnit, objvzx_SocialRelationsCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.Major) == true)
{
string strComparisonOpMajor = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.Major, objvzx_SocialRelationsCond.Major, strComparisonOpMajor);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.Achievement) == true)
{
string strComparisonOpAchievement = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.Achievement, objvzx_SocialRelationsCond.Achievement, strComparisonOpAchievement);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.UpdUser, objvzx_SocialRelationsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.CreateDate, objvzx_SocialRelationsCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.UpdDate, objvzx_SocialRelationsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.IsSubmit) == true)
{
if (objvzx_SocialRelationsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_SocialRelations.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_SocialRelations.IsSubmit);
}
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.VoteCount, objvzx_SocialRelationsCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.CitationCount) == true)
{
string strComparisonOpCitationCount = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.CitationCount, objvzx_SocialRelationsCond.CitationCount, strComparisonOpCitationCount);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.VersionCount, objvzx_SocialRelationsCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.IdCurrEduCls, objvzx_SocialRelationsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.AppraiseCount, objvzx_SocialRelationsCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.Score) == true)
{
string strComparisonOpScore = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.Score, objvzx_SocialRelationsCond.Score, strComparisonOpScore);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.GroupTextId, objvzx_SocialRelationsCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.PdfZoom, objvzx_SocialRelationsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.PdfPageTop, objvzx_SocialRelationsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.PdfPageNumIn, objvzx_SocialRelationsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.PdfDivTop, objvzx_SocialRelationsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.PdfDivLet, objvzx_SocialRelationsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.Memo) == true)
{
string strComparisonOpMemo = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.Memo, objvzx_SocialRelationsCond.Memo, strComparisonOpMemo);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.PdfPageNum, objvzx_SocialRelationsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.PdfContent, objvzx_SocialRelationsCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.zxShareId, objvzx_SocialRelationsCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.TextId) == true)
{
string strComparisonOpTextId = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.TextId, objvzx_SocialRelationsCond.TextId, strComparisonOpTextId);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.TeaScore, objvzx_SocialRelationsCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SocialRelations.StuScore, objvzx_SocialRelationsCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_SocialRelationsCond.IsUpdated(convzx_SocialRelations.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objvzx_SocialRelationsCond.dicFldComparisonOp[convzx_SocialRelations.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SocialRelations.zxLevelId, objvzx_SocialRelationsCond.zxLevelId, strComparisonOpzxLevelId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_SocialRelations
{
public virtual bool UpdRelaTabDate(string strzxSocialId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_SocialRelations(vzx_SocialRelations)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SocialRelationsBL
{
public static RelatedActions_vzx_SocialRelations relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SocialRelationsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SocialRelationsDA vzx_SocialRelationsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SocialRelationsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SocialRelationsBL()
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
if (string.IsNullOrEmpty(clsvzx_SocialRelationsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SocialRelationsEN._ConnectString);
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
public static DataTable GetDataTable_vzx_SocialRelations(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SocialRelationsDA.GetDataTable_vzx_SocialRelations(strWhereCond);
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
objDT = vzx_SocialRelationsDA.GetDataTable(strWhereCond);
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
objDT = vzx_SocialRelationsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SocialRelationsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SocialRelationsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SocialRelationsDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SocialRelationsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetObjLstByZxSocialIdLst(List<string> arrZxSocialIdLst)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxSocialIdLst, true);
 string strWhereCond = string.Format("zxSocialId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SocialRelationsEN> GetObjLstByZxSocialIdLstCache(List<string> arrZxSocialIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLst_Sel =
arrvzx_SocialRelationsObjLstCache
.Where(x => arrZxSocialIdLst.Contains(x.zxSocialId));
return arrvzx_SocialRelationsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
public static List<clsvzx_SocialRelationsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SocialRelationsEN> GetSubObjLstCache(clsvzx_SocialRelationsEN objvzx_SocialRelationsCond)
{
 string strIdCurrEduCls = objvzx_SocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_SocialRelationsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_SocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SocialRelations.AttributeName)
{
if (objvzx_SocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SocialRelationsCond[strFldName].ToString());
}
else
{
if (objvzx_SocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SocialRelationsCond[strFldName]));
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
public static List<clsvzx_SocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
public static List<clsvzx_SocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
List<clsvzx_SocialRelationsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SocialRelationsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
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
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
public static List<clsvzx_SocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
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
public static List<clsvzx_SocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SocialRelationsEN> arrObjLst = new List<clsvzx_SocialRelationsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = new clsvzx_SocialRelationsEN();
try
{
objvzx_SocialRelationsEN.zxSocialId = objRow[convzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objvzx_SocialRelationsEN.FullName = objRow[convzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[convzx_SocialRelations.FullName].ToString().Trim(); //姓名
objvzx_SocialRelationsEN.Nationality = objRow[convzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[convzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objvzx_SocialRelationsEN.WorkUnit = objRow[convzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[convzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objvzx_SocialRelationsEN.Major = objRow[convzx_SocialRelations.Major] == DBNull.Value ? null : objRow[convzx_SocialRelations.Major].ToString().Trim(); //专业
objvzx_SocialRelationsEN.Achievement = objRow[convzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[convzx_SocialRelations.Achievement].ToString().Trim(); //成就
objvzx_SocialRelationsEN.DetailedDescription = objRow[convzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[convzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objvzx_SocialRelationsEN.UpdUser = objRow[convzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objvzx_SocialRelationsEN.CreateDate = objRow[convzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objvzx_SocialRelationsEN.UpdDate = objRow[convzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[convzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objvzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objvzx_SocialRelationsEN.VoteCount = objRow[convzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objvzx_SocialRelationsEN.CitationCount = objRow[convzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objvzx_SocialRelationsEN.VersionCount = objRow[convzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objvzx_SocialRelationsEN.IdCurrEduCls = objRow[convzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SocialRelationsEN.AppraiseCount = objRow[convzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objvzx_SocialRelationsEN.Score = objRow[convzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.Score].ToString().Trim()); //评分
objvzx_SocialRelationsEN.GroupTextId = objRow[convzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
objvzx_SocialRelationsEN.PdfZoom = objRow[convzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SocialRelationsEN.PdfPageTop = objRow[convzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SocialRelationsEN.PdfPageNumIn = objRow[convzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SocialRelationsEN.PdfDivTop = objRow[convzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SocialRelationsEN.PdfDivLet = objRow[convzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SocialRelationsEN.Memo = objRow[convzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[convzx_SocialRelations.Memo].ToString().Trim(); //备注
objvzx_SocialRelationsEN.PdfPageNum = objRow[convzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SocialRelationsEN.PdfContent = objRow[convzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[convzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objvzx_SocialRelationsEN.zxShareId = objRow[convzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objvzx_SocialRelationsEN.TextId = objRow[convzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[convzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objvzx_SocialRelationsEN.TeaScore = objRow[convzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objvzx_SocialRelationsEN.StuScore = objRow[convzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objvzx_SocialRelationsEN.zxLevelId = objRow[convzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[convzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SocialRelationsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_SocialRelations(ref clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
bool bolResult = vzx_SocialRelationsDA.Getvzx_SocialRelations(ref objvzx_SocialRelationsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SocialRelationsEN GetObjByzxSocialId(string strzxSocialId)
{
if (strzxSocialId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxSocialId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxSocialId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = vzx_SocialRelationsDA.GetObjByzxSocialId(strzxSocialId);
return objvzx_SocialRelationsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SocialRelationsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = vzx_SocialRelationsDA.GetFirstObj(strWhereCond);
 return objvzx_SocialRelationsEN;
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
public static clsvzx_SocialRelationsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = vzx_SocialRelationsDA.GetObjByDataRow(objRow);
 return objvzx_SocialRelationsEN;
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
public static clsvzx_SocialRelationsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = vzx_SocialRelationsDA.GetObjByDataRow(objRow);
 return objvzx_SocialRelationsEN;
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
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <param name = "lstvzx_SocialRelationsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SocialRelationsEN GetObjByzxSocialIdFromList(string strzxSocialId, List<clsvzx_SocialRelationsEN> lstvzx_SocialRelationsObjLst)
{
foreach (clsvzx_SocialRelationsEN objvzx_SocialRelationsEN in lstvzx_SocialRelationsObjLst)
{
if (objvzx_SocialRelationsEN.zxSocialId == strzxSocialId)
{
return objvzx_SocialRelationsEN;
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
 string strMaxZxSocialId;
 try
 {
 strMaxZxSocialId = clsvzx_SocialRelationsDA.GetMaxStrId();
 return strMaxZxSocialId;
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
 string strzxSocialId;
 try
 {
 strzxSocialId = new clsvzx_SocialRelationsDA().GetFirstID(strWhereCond);
 return strzxSocialId;
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
 arrList = vzx_SocialRelationsDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SocialRelationsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxSocialId)
{
if (string.IsNullOrEmpty(strzxSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxSocialId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_SocialRelationsDA.IsExist(strzxSocialId);
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
 bolIsExist = clsvzx_SocialRelationsDA.IsExistTable();
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
 bolIsExist = vzx_SocialRelationsDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <param name = "objvzx_SocialRelationsENT">目标对象</param>
 public static void CopyTo(clsvzx_SocialRelationsEN objvzx_SocialRelationsENS, clsvzx_SocialRelationsEN objvzx_SocialRelationsENT)
{
try
{
objvzx_SocialRelationsENT.zxSocialId = objvzx_SocialRelationsENS.zxSocialId; //社会Id
objvzx_SocialRelationsENT.FullName = objvzx_SocialRelationsENS.FullName; //姓名
objvzx_SocialRelationsENT.Nationality = objvzx_SocialRelationsENS.Nationality; //国籍
objvzx_SocialRelationsENT.WorkUnit = objvzx_SocialRelationsENS.WorkUnit; //工作单位
objvzx_SocialRelationsENT.Major = objvzx_SocialRelationsENS.Major; //专业
objvzx_SocialRelationsENT.Achievement = objvzx_SocialRelationsENS.Achievement; //成就
objvzx_SocialRelationsENT.DetailedDescription = objvzx_SocialRelationsENS.DetailedDescription; //详细说明
objvzx_SocialRelationsENT.UpdUser = objvzx_SocialRelationsENS.UpdUser; //修改人
objvzx_SocialRelationsENT.CreateDate = objvzx_SocialRelationsENS.CreateDate; //建立日期
objvzx_SocialRelationsENT.UpdDate = objvzx_SocialRelationsENS.UpdDate; //修改日期
objvzx_SocialRelationsENT.IsSubmit = objvzx_SocialRelationsENS.IsSubmit; //是否提交
objvzx_SocialRelationsENT.VoteCount = objvzx_SocialRelationsENS.VoteCount; //点赞计数
objvzx_SocialRelationsENT.CitationCount = objvzx_SocialRelationsENS.CitationCount; //引用统计
objvzx_SocialRelationsENT.VersionCount = objvzx_SocialRelationsENS.VersionCount; //版本统计
objvzx_SocialRelationsENT.IdCurrEduCls = objvzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objvzx_SocialRelationsENT.AppraiseCount = objvzx_SocialRelationsENS.AppraiseCount; //评论数
objvzx_SocialRelationsENT.Score = objvzx_SocialRelationsENS.Score; //评分
objvzx_SocialRelationsENT.GroupTextId = objvzx_SocialRelationsENS.GroupTextId; //小组Id
objvzx_SocialRelationsENT.PdfZoom = objvzx_SocialRelationsENS.PdfZoom; //PdfZoom
objvzx_SocialRelationsENT.PdfPageTop = objvzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objvzx_SocialRelationsENT.PdfPageNumIn = objvzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_SocialRelationsENT.PdfDivTop = objvzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objvzx_SocialRelationsENT.PdfDivLet = objvzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objvzx_SocialRelationsENT.Memo = objvzx_SocialRelationsENS.Memo; //备注
objvzx_SocialRelationsENT.PdfPageNum = objvzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objvzx_SocialRelationsENT.PdfContent = objvzx_SocialRelationsENS.PdfContent; //Pdf内容
objvzx_SocialRelationsENT.zxShareId = objvzx_SocialRelationsENS.zxShareId; //分享Id
objvzx_SocialRelationsENT.TextId = objvzx_SocialRelationsENS.TextId; //课件Id
objvzx_SocialRelationsENT.TeaScore = objvzx_SocialRelationsENS.TeaScore; //教师评分
objvzx_SocialRelationsENT.StuScore = objvzx_SocialRelationsENS.StuScore; //学生平均分
objvzx_SocialRelationsENT.zxLevelId = objvzx_SocialRelationsENS.zxLevelId; //级别Id
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
 /// <param name = "objvzx_SocialRelationsEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
try
{
objvzx_SocialRelationsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SocialRelationsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_SocialRelations.zxSocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.zxSocialId = objvzx_SocialRelationsEN.zxSocialId; //社会Id
}
if (arrFldSet.Contains(convzx_SocialRelations.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.FullName = objvzx_SocialRelationsEN.FullName == "[null]" ? null :  objvzx_SocialRelationsEN.FullName; //姓名
}
if (arrFldSet.Contains(convzx_SocialRelations.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.Nationality = objvzx_SocialRelationsEN.Nationality == "[null]" ? null :  objvzx_SocialRelationsEN.Nationality; //国籍
}
if (arrFldSet.Contains(convzx_SocialRelations.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.WorkUnit = objvzx_SocialRelationsEN.WorkUnit == "[null]" ? null :  objvzx_SocialRelationsEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convzx_SocialRelations.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.Major = objvzx_SocialRelationsEN.Major == "[null]" ? null :  objvzx_SocialRelationsEN.Major; //专业
}
if (arrFldSet.Contains(convzx_SocialRelations.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.Achievement = objvzx_SocialRelationsEN.Achievement == "[null]" ? null :  objvzx_SocialRelationsEN.Achievement; //成就
}
if (arrFldSet.Contains(convzx_SocialRelations.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.DetailedDescription = objvzx_SocialRelationsEN.DetailedDescription == "[null]" ? null :  objvzx_SocialRelationsEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(convzx_SocialRelations.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.UpdUser = objvzx_SocialRelationsEN.UpdUser == "[null]" ? null :  objvzx_SocialRelationsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_SocialRelations.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.CreateDate = objvzx_SocialRelationsEN.CreateDate == "[null]" ? null :  objvzx_SocialRelationsEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_SocialRelations.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.UpdDate = objvzx_SocialRelationsEN.UpdDate == "[null]" ? null :  objvzx_SocialRelationsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_SocialRelations.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.IsSubmit = objvzx_SocialRelationsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_SocialRelations.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.VoteCount = objvzx_SocialRelationsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_SocialRelations.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.CitationCount = objvzx_SocialRelationsEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convzx_SocialRelations.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.VersionCount = objvzx_SocialRelationsEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_SocialRelations.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.IdCurrEduCls = objvzx_SocialRelationsEN.IdCurrEduCls == "[null]" ? null :  objvzx_SocialRelationsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_SocialRelations.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.AppraiseCount = objvzx_SocialRelationsEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_SocialRelations.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.Score = objvzx_SocialRelationsEN.Score; //评分
}
if (arrFldSet.Contains(convzx_SocialRelations.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.GroupTextId = objvzx_SocialRelationsEN.GroupTextId == "[null]" ? null :  objvzx_SocialRelationsEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfZoom = objvzx_SocialRelationsEN.PdfZoom == "[null]" ? null :  objvzx_SocialRelationsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfPageTop = objvzx_SocialRelationsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfPageNumIn = objvzx_SocialRelationsEN.PdfPageNumIn == "[null]" ? null :  objvzx_SocialRelationsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfDivTop = objvzx_SocialRelationsEN.PdfDivTop == "[null]" ? null :  objvzx_SocialRelationsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfDivLet = objvzx_SocialRelationsEN.PdfDivLet == "[null]" ? null :  objvzx_SocialRelationsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_SocialRelations.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.Memo = objvzx_SocialRelationsEN.Memo == "[null]" ? null :  objvzx_SocialRelationsEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfPageNum = objvzx_SocialRelationsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_SocialRelations.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.PdfContent = objvzx_SocialRelationsEN.PdfContent == "[null]" ? null :  objvzx_SocialRelationsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_SocialRelations.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.zxShareId = objvzx_SocialRelationsEN.zxShareId == "[null]" ? null :  objvzx_SocialRelationsEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_SocialRelations.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.TextId = objvzx_SocialRelationsEN.TextId == "[null]" ? null :  objvzx_SocialRelationsEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_SocialRelations.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.TeaScore = objvzx_SocialRelationsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_SocialRelations.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.StuScore = objvzx_SocialRelationsEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_SocialRelations.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SocialRelationsEN.zxLevelId = objvzx_SocialRelationsEN.zxLevelId == "[null]" ? null :  objvzx_SocialRelationsEN.zxLevelId; //级别Id
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
 /// <param name = "objvzx_SocialRelationsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
try
{
if (objvzx_SocialRelationsEN.FullName == "[null]") objvzx_SocialRelationsEN.FullName = null; //姓名
if (objvzx_SocialRelationsEN.Nationality == "[null]") objvzx_SocialRelationsEN.Nationality = null; //国籍
if (objvzx_SocialRelationsEN.WorkUnit == "[null]") objvzx_SocialRelationsEN.WorkUnit = null; //工作单位
if (objvzx_SocialRelationsEN.Major == "[null]") objvzx_SocialRelationsEN.Major = null; //专业
if (objvzx_SocialRelationsEN.Achievement == "[null]") objvzx_SocialRelationsEN.Achievement = null; //成就
if (objvzx_SocialRelationsEN.DetailedDescription == "[null]") objvzx_SocialRelationsEN.DetailedDescription = null; //详细说明
if (objvzx_SocialRelationsEN.UpdUser == "[null]") objvzx_SocialRelationsEN.UpdUser = null; //修改人
if (objvzx_SocialRelationsEN.CreateDate == "[null]") objvzx_SocialRelationsEN.CreateDate = null; //建立日期
if (objvzx_SocialRelationsEN.UpdDate == "[null]") objvzx_SocialRelationsEN.UpdDate = null; //修改日期
if (objvzx_SocialRelationsEN.IdCurrEduCls == "[null]") objvzx_SocialRelationsEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_SocialRelationsEN.GroupTextId == "[null]") objvzx_SocialRelationsEN.GroupTextId = null; //小组Id
if (objvzx_SocialRelationsEN.PdfZoom == "[null]") objvzx_SocialRelationsEN.PdfZoom = null; //PdfZoom
if (objvzx_SocialRelationsEN.PdfPageNumIn == "[null]") objvzx_SocialRelationsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_SocialRelationsEN.PdfDivTop == "[null]") objvzx_SocialRelationsEN.PdfDivTop = null; //PdfDivTop
if (objvzx_SocialRelationsEN.PdfDivLet == "[null]") objvzx_SocialRelationsEN.PdfDivLet = null; //PdfDivLet
if (objvzx_SocialRelationsEN.Memo == "[null]") objvzx_SocialRelationsEN.Memo = null; //备注
if (objvzx_SocialRelationsEN.PdfContent == "[null]") objvzx_SocialRelationsEN.PdfContent = null; //Pdf内容
if (objvzx_SocialRelationsEN.zxShareId == "[null]") objvzx_SocialRelationsEN.zxShareId = null; //分享Id
if (objvzx_SocialRelationsEN.TextId == "[null]") objvzx_SocialRelationsEN.TextId = null; //课件Id
if (objvzx_SocialRelationsEN.zxLevelId == "[null]") objvzx_SocialRelationsEN.zxLevelId = null; //级别Id
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
public static void CheckProperty4Condition(clsvzx_SocialRelationsEN objvzx_SocialRelationsEN)
{
 vzx_SocialRelationsDA.CheckProperty4Condition(objvzx_SocialRelationsEN);
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
if (clszx_SocialRelationsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SocialRelationsBL没有刷新缓存机制(clszx_SocialRelationsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysSecurityLevelBL没有刷新缓存机制(clszx_SysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxSocialId");
//if (arrvzx_SocialRelationsObjLstCache == null)
//{
//arrvzx_SocialRelationsObjLstCache = vzx_SocialRelationsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SocialRelationsEN GetObjByzxSocialIdCache(string strzxSocialId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLst_Sel =
arrvzx_SocialRelationsObjLstCache
.Where(x=> x.zxSocialId == strzxSocialId 
);
if (arrvzx_SocialRelationsObjLst_Sel.Count() == 0)
{
   clsvzx_SocialRelationsEN obj = clsvzx_SocialRelationsBL.GetObjByzxSocialId(strzxSocialId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxSocialId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_SocialRelationsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetAllvzx_SocialRelationsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_SocialRelationsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SocialRelationsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_SocialRelationsEN> arrvzx_SocialRelationsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_SocialRelationsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxSocialId, string strIdCurrEduCls)
{
if (strInFldName != convzx_SocialRelations.zxSocialId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_SocialRelations.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_SocialRelations.AttributeName));
throw new Exception(strMsg);
}
var objvzx_SocialRelations = clsvzx_SocialRelationsBL.GetObjByzxSocialIdCache(strzxSocialId, strIdCurrEduCls);
if (objvzx_SocialRelations == null) return "";
return objvzx_SocialRelations[strOutFldName].ToString();
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
int intRecCount = clsvzx_SocialRelationsDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SocialRelationsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SocialRelationsDA.GetRecCount();
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
int intRecCount = clsvzx_SocialRelationsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SocialRelationsEN objvzx_SocialRelationsCond)
{
 string strIdCurrEduCls = objvzx_SocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_SocialRelationsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_SocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SocialRelations.AttributeName)
{
if (objvzx_SocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SocialRelationsCond[strFldName].ToString());
}
else
{
if (objvzx_SocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SocialRelationsCond[strFldName]));
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
 List<string> arrList = clsvzx_SocialRelationsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SocialRelationsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SocialRelationsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}