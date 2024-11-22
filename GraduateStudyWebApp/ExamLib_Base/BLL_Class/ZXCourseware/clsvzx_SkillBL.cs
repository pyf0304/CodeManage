
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SkillBL
 表名:vzx_Skill(01120835)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:07
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
public static class  clsvzx_SkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SkillEN GetObj(this K_zxSkillId_vzx_Skill myKey)
{
clsvzx_SkillEN objvzx_SkillEN = clsvzx_SkillBL.vzx_SkillDA.GetObjByzxSkillId(myKey.Value);
return objvzx_SkillEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetOperationTypeName(this clsvzx_SkillEN objvzx_SkillEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convzx_Skill.OperationTypeName);
}
objvzx_SkillEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.OperationTypeName) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.OperationTypeName, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.OperationTypeName] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetLevelName(this clsvzx_SkillEN objvzx_SkillEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convzx_Skill.LevelName);
}
objvzx_SkillEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.LevelName) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.LevelName, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.LevelName] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetzxSkillId(this clsvzx_SkillEN objvzx_SkillEN, string strzxSkillId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSkillId, 10, convzx_Skill.zxSkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSkillId, 10, convzx_Skill.zxSkillId);
}
objvzx_SkillEN.zxSkillId = strzxSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.zxSkillId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.zxSkillId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.zxSkillId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetSkillName(this clsvzx_SkillEN objvzx_SkillEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, convzx_Skill.SkillName);
}
objvzx_SkillEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.SkillName) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.SkillName, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.SkillName] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetzxOperationTypeId(this clsvzx_SkillEN objvzx_SkillEN, string strzxOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxOperationTypeId, 2, convzx_Skill.zxOperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxOperationTypeId, 2, convzx_Skill.zxOperationTypeId);
}
objvzx_SkillEN.zxOperationTypeId = strzxOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.zxOperationTypeId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.zxOperationTypeId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.zxOperationTypeId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetProcess(this clsvzx_SkillEN objvzx_SkillEN, string strProcess, string strComparisonOp="")
	{
objvzx_SkillEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.Process) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.Process, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.Process] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetzxLevelId(this clsvzx_SkillEN objvzx_SkillEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, convzx_Skill.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, convzx_Skill.zxLevelId);
}
objvzx_SkillEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.zxLevelId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.zxLevelId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.zxLevelId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetUpdUser(this clsvzx_SkillEN objvzx_SkillEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Skill.UpdUser);
}
objvzx_SkillEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.UpdUser) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.UpdUser, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.UpdUser] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetCreateDate(this clsvzx_SkillEN objvzx_SkillEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_Skill.CreateDate);
}
objvzx_SkillEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.CreateDate) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.CreateDate, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.CreateDate] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetUpdDate(this clsvzx_SkillEN objvzx_SkillEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Skill.UpdDate);
}
objvzx_SkillEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.UpdDate) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.UpdDate, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.UpdDate] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetIsSubmit(this clsvzx_SkillEN objvzx_SkillEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_SkillEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.IsSubmit) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.IsSubmit, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.IsSubmit] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetTextId(this clsvzx_SkillEN objvzx_SkillEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Skill.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Skill.TextId);
}
objvzx_SkillEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.TextId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.TextId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.TextId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetVoteCount(this clsvzx_SkillEN objvzx_SkillEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_SkillEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.VoteCount) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.VoteCount, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.VoteCount] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetAppraiseCount(this clsvzx_SkillEN objvzx_SkillEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_SkillEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.AppraiseCount) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.AppraiseCount, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.AppraiseCount] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetScore(this clsvzx_SkillEN objvzx_SkillEN, float? fltScore, string strComparisonOp="")
	{
objvzx_SkillEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.Score) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.Score, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.Score] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetStuScore(this clsvzx_SkillEN objvzx_SkillEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_SkillEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.StuScore) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.StuScore, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.StuScore] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetTeaScore(this clsvzx_SkillEN objvzx_SkillEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_SkillEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.TeaScore) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.TeaScore, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.TeaScore] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetIdCurrEduCls(this clsvzx_SkillEN objvzx_SkillEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Skill.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Skill.IdCurrEduCls);
}
objvzx_SkillEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.IdCurrEduCls) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetGroupTextId(this clsvzx_SkillEN objvzx_SkillEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_Skill.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_Skill.GroupTextId);
}
objvzx_SkillEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.GroupTextId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.GroupTextId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.GroupTextId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfZoom(this clsvzx_SkillEN objvzx_SkillEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_Skill.PdfZoom);
}
objvzx_SkillEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfZoom) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfZoom, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfZoom] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfPageTop(this clsvzx_SkillEN objvzx_SkillEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_SkillEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfPageTop) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfPageTop, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfPageTop] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfPageNumIn(this clsvzx_SkillEN objvzx_SkillEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_Skill.PdfPageNumIn);
}
objvzx_SkillEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfPageNumIn) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfDivTop(this clsvzx_SkillEN objvzx_SkillEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_Skill.PdfDivTop);
}
objvzx_SkillEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfDivTop) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfDivTop, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfDivTop] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfDivLet(this clsvzx_SkillEN objvzx_SkillEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_Skill.PdfDivLet);
}
objvzx_SkillEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfDivLet) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfDivLet, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfDivLet] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetMemo(this clsvzx_SkillEN objvzx_SkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Skill.Memo);
}
objvzx_SkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.Memo) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.Memo, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.Memo] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetzxShareId(this clsvzx_SkillEN objvzx_SkillEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_Skill.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_Skill.zxShareId);
}
objvzx_SkillEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.zxShareId) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.zxShareId, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.zxShareId] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetVersionCount(this clsvzx_SkillEN objvzx_SkillEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_SkillEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.VersionCount) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.VersionCount, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.VersionCount] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetCitationCount(this clsvzx_SkillEN objvzx_SkillEN, int? intCitationCount, string strComparisonOp="")
	{
objvzx_SkillEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.CitationCount) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.CitationCount, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.CitationCount] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfPageNum(this clsvzx_SkillEN objvzx_SkillEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_SkillEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfPageNum) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfPageNum, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfPageNum] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SkillEN SetPdfContent(this clsvzx_SkillEN objvzx_SkillEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_Skill.PdfContent);
}
objvzx_SkillEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SkillEN.dicFldComparisonOp.ContainsKey(convzx_Skill.PdfContent) == false)
{
objvzx_SkillEN.dicFldComparisonOp.Add(convzx_Skill.PdfContent, strComparisonOp);
}
else
{
objvzx_SkillEN.dicFldComparisonOp[convzx_Skill.PdfContent] = strComparisonOp;
}
}
return objvzx_SkillEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SkillENS">源对象</param>
 /// <param name = "objvzx_SkillENT">目标对象</param>
 public static void CopyTo(this clsvzx_SkillEN objvzx_SkillENS, clsvzx_SkillEN objvzx_SkillENT)
{
try
{
objvzx_SkillENT.OperationTypeName = objvzx_SkillENS.OperationTypeName; //操作类型名
objvzx_SkillENT.LevelName = objvzx_SkillENS.LevelName; //级别名称
objvzx_SkillENT.zxSkillId = objvzx_SkillENS.zxSkillId; //技能Id
objvzx_SkillENT.SkillName = objvzx_SkillENS.SkillName; //技能名称
objvzx_SkillENT.zxOperationTypeId = objvzx_SkillENS.zxOperationTypeId; //操作类型ID
objvzx_SkillENT.Process = objvzx_SkillENS.Process; //实施过程
objvzx_SkillENT.zxLevelId = objvzx_SkillENS.zxLevelId; //级别Id
objvzx_SkillENT.UpdUser = objvzx_SkillENS.UpdUser; //修改人
objvzx_SkillENT.CreateDate = objvzx_SkillENS.CreateDate; //建立日期
objvzx_SkillENT.UpdDate = objvzx_SkillENS.UpdDate; //修改日期
objvzx_SkillENT.IsSubmit = objvzx_SkillENS.IsSubmit; //是否提交
objvzx_SkillENT.TextId = objvzx_SkillENS.TextId; //课件Id
objvzx_SkillENT.VoteCount = objvzx_SkillENS.VoteCount; //点赞计数
objvzx_SkillENT.AppraiseCount = objvzx_SkillENS.AppraiseCount; //评论数
objvzx_SkillENT.Score = objvzx_SkillENS.Score; //评分
objvzx_SkillENT.StuScore = objvzx_SkillENS.StuScore; //学生平均分
objvzx_SkillENT.TeaScore = objvzx_SkillENS.TeaScore; //教师评分
objvzx_SkillENT.IdCurrEduCls = objvzx_SkillENS.IdCurrEduCls; //教学班流水号
objvzx_SkillENT.GroupTextId = objvzx_SkillENS.GroupTextId; //小组Id
objvzx_SkillENT.PdfZoom = objvzx_SkillENS.PdfZoom; //PdfZoom
objvzx_SkillENT.PdfPageTop = objvzx_SkillENS.PdfPageTop; //pdf页面顶部位置
objvzx_SkillENT.PdfPageNumIn = objvzx_SkillENS.PdfPageNumIn; //PdfPageNumIn
objvzx_SkillENT.PdfDivTop = objvzx_SkillENS.PdfDivTop; //PdfDivTop
objvzx_SkillENT.PdfDivLet = objvzx_SkillENS.PdfDivLet; //PdfDivLet
objvzx_SkillENT.Memo = objvzx_SkillENS.Memo; //备注
objvzx_SkillENT.zxShareId = objvzx_SkillENS.zxShareId; //分享Id
objvzx_SkillENT.VersionCount = objvzx_SkillENS.VersionCount; //版本统计
objvzx_SkillENT.CitationCount = objvzx_SkillENS.CitationCount; //引用统计
objvzx_SkillENT.PdfPageNum = objvzx_SkillENS.PdfPageNum; //Pdf页码
objvzx_SkillENT.PdfContent = objvzx_SkillENS.PdfContent; //Pdf内容
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
 /// <param name = "objvzx_SkillENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SkillEN:objvzx_SkillENT</returns>
 public static clsvzx_SkillEN CopyTo(this clsvzx_SkillEN objvzx_SkillENS)
{
try
{
 clsvzx_SkillEN objvzx_SkillENT = new clsvzx_SkillEN()
{
OperationTypeName = objvzx_SkillENS.OperationTypeName, //操作类型名
LevelName = objvzx_SkillENS.LevelName, //级别名称
zxSkillId = objvzx_SkillENS.zxSkillId, //技能Id
SkillName = objvzx_SkillENS.SkillName, //技能名称
zxOperationTypeId = objvzx_SkillENS.zxOperationTypeId, //操作类型ID
Process = objvzx_SkillENS.Process, //实施过程
zxLevelId = objvzx_SkillENS.zxLevelId, //级别Id
UpdUser = objvzx_SkillENS.UpdUser, //修改人
CreateDate = objvzx_SkillENS.CreateDate, //建立日期
UpdDate = objvzx_SkillENS.UpdDate, //修改日期
IsSubmit = objvzx_SkillENS.IsSubmit, //是否提交
TextId = objvzx_SkillENS.TextId, //课件Id
VoteCount = objvzx_SkillENS.VoteCount, //点赞计数
AppraiseCount = objvzx_SkillENS.AppraiseCount, //评论数
Score = objvzx_SkillENS.Score, //评分
StuScore = objvzx_SkillENS.StuScore, //学生平均分
TeaScore = objvzx_SkillENS.TeaScore, //教师评分
IdCurrEduCls = objvzx_SkillENS.IdCurrEduCls, //教学班流水号
GroupTextId = objvzx_SkillENS.GroupTextId, //小组Id
PdfZoom = objvzx_SkillENS.PdfZoom, //PdfZoom
PdfPageTop = objvzx_SkillENS.PdfPageTop, //pdf页面顶部位置
PdfPageNumIn = objvzx_SkillENS.PdfPageNumIn, //PdfPageNumIn
PdfDivTop = objvzx_SkillENS.PdfDivTop, //PdfDivTop
PdfDivLet = objvzx_SkillENS.PdfDivLet, //PdfDivLet
Memo = objvzx_SkillENS.Memo, //备注
zxShareId = objvzx_SkillENS.zxShareId, //分享Id
VersionCount = objvzx_SkillENS.VersionCount, //版本统计
CitationCount = objvzx_SkillENS.CitationCount, //引用统计
PdfPageNum = objvzx_SkillENS.PdfPageNum, //Pdf页码
PdfContent = objvzx_SkillENS.PdfContent, //Pdf内容
};
 return objvzx_SkillENT;
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
public static void CheckProperty4Condition(this clsvzx_SkillEN objvzx_SkillEN)
{
 clsvzx_SkillBL.vzx_SkillDA.CheckProperty4Condition(objvzx_SkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SkillEN objvzx_SkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SkillCond.IsUpdated(convzx_Skill.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.OperationTypeName, objvzx_SkillCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.LevelName) == true)
{
string strComparisonOpLevelName = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.LevelName, objvzx_SkillCond.LevelName, strComparisonOpLevelName);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.zxSkillId) == true)
{
string strComparisonOpzxSkillId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.zxSkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.zxSkillId, objvzx_SkillCond.zxSkillId, strComparisonOpzxSkillId);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.SkillName) == true)
{
string strComparisonOpSkillName = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.SkillName, objvzx_SkillCond.SkillName, strComparisonOpSkillName);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.zxOperationTypeId) == true)
{
string strComparisonOpzxOperationTypeId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.zxOperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.zxOperationTypeId, objvzx_SkillCond.zxOperationTypeId, strComparisonOpzxOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_SkillCond.IsUpdated(convzx_Skill.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.zxLevelId, objvzx_SkillCond.zxLevelId, strComparisonOpzxLevelId);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.UpdUser, objvzx_SkillCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.CreateDate, objvzx_SkillCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.UpdDate, objvzx_SkillCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.IsSubmit) == true)
{
if (objvzx_SkillCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Skill.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Skill.IsSubmit);
}
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.TextId) == true)
{
string strComparisonOpTextId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.TextId, objvzx_SkillCond.TextId, strComparisonOpTextId);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.VoteCount, objvzx_SkillCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.AppraiseCount, objvzx_SkillCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.Score) == true)
{
string strComparisonOpScore = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.Score, objvzx_SkillCond.Score, strComparisonOpScore);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.StuScore, objvzx_SkillCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.TeaScore, objvzx_SkillCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.IdCurrEduCls, objvzx_SkillCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.GroupTextId, objvzx_SkillCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.PdfZoom, objvzx_SkillCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.PdfPageTop, objvzx_SkillCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.PdfPageNumIn, objvzx_SkillCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.PdfDivTop, objvzx_SkillCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.PdfDivLet, objvzx_SkillCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.Memo) == true)
{
string strComparisonOpMemo = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.Memo, objvzx_SkillCond.Memo, strComparisonOpMemo);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.zxShareId, objvzx_SkillCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.VersionCount, objvzx_SkillCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.CitationCount) == true)
{
string strComparisonOpCitationCount = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.CitationCount, objvzx_SkillCond.CitationCount, strComparisonOpCitationCount);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Skill.PdfPageNum, objvzx_SkillCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_SkillCond.IsUpdated(convzx_Skill.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_SkillCond.dicFldComparisonOp[convzx_Skill.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Skill.PdfContent, objvzx_SkillCond.PdfContent, strComparisonOpPdfContent);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Skill
{
public virtual bool UpdRelaTabDate(string strzxSkillId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Skill(vzx_Skill)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SkillBL
{
public static RelatedActions_vzx_Skill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SkillDA vzx_SkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SkillDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SkillBL()
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
if (string.IsNullOrEmpty(clsvzx_SkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SkillEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Skill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SkillDA.GetDataTable_vzx_Skill(strWhereCond);
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
objDT = vzx_SkillDA.GetDataTable(strWhereCond);
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
objDT = vzx_SkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SkillDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_SkillEN> GetObjLstByZxSkillIdLst(List<string> arrZxSkillIdLst)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxSkillIdLst, true);
 string strWhereCond = string.Format("zxSkillId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SkillEN> GetObjLstByZxSkillIdLstCache(List<string> arrZxSkillIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_SkillEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SkillEN> arrvzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SkillEN> arrvzx_SkillObjLst_Sel =
arrvzx_SkillObjLstCache
.Where(x => arrZxSkillIdLst.Contains(x.zxSkillId));
return arrvzx_SkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SkillEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
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
public static List<clsvzx_SkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SkillEN> GetSubObjLstCache(clsvzx_SkillEN objvzx_SkillCond)
{
 string strIdCurrEduCls = objvzx_SkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_SkillBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_SkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Skill.AttributeName)
{
if (objvzx_SkillCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SkillCond[strFldName].ToString());
}
else
{
if (objvzx_SkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SkillCond[strFldName]));
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
public static List<clsvzx_SkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
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
public static List<clsvzx_SkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
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
List<clsvzx_SkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
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
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
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
public static List<clsvzx_SkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
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
public static List<clsvzx_SkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SkillEN> arrObjLst = new List<clsvzx_SkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN();
try
{
objvzx_SkillEN.OperationTypeName = objRow[convzx_Skill.OperationTypeName] == DBNull.Value ? null : objRow[convzx_Skill.OperationTypeName].ToString().Trim(); //操作类型名
objvzx_SkillEN.LevelName = objRow[convzx_Skill.LevelName] == DBNull.Value ? null : objRow[convzx_Skill.LevelName].ToString().Trim(); //级别名称
objvzx_SkillEN.zxSkillId = objRow[convzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objvzx_SkillEN.SkillName = objRow[convzx_Skill.SkillName] == DBNull.Value ? null : objRow[convzx_Skill.SkillName].ToString().Trim(); //技能名称
objvzx_SkillEN.zxOperationTypeId = objRow[convzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[convzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objvzx_SkillEN.Process = objRow[convzx_Skill.Process] == DBNull.Value ? null : objRow[convzx_Skill.Process].ToString().Trim(); //实施过程
objvzx_SkillEN.zxLevelId = objRow[convzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[convzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objvzx_SkillEN.UpdUser = objRow[convzx_Skill.UpdUser] == DBNull.Value ? null : objRow[convzx_Skill.UpdUser].ToString().Trim(); //修改人
objvzx_SkillEN.CreateDate = objRow[convzx_Skill.CreateDate] == DBNull.Value ? null : objRow[convzx_Skill.CreateDate].ToString().Trim(); //建立日期
objvzx_SkillEN.UpdDate = objRow[convzx_Skill.UpdDate] == DBNull.Value ? null : objRow[convzx_Skill.UpdDate].ToString().Trim(); //修改日期
objvzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objvzx_SkillEN.TextId = objRow[convzx_Skill.TextId] == DBNull.Value ? null : objRow[convzx_Skill.TextId].ToString().Trim(); //课件Id
objvzx_SkillEN.VoteCount = objRow[convzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objvzx_SkillEN.AppraiseCount = objRow[convzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objvzx_SkillEN.Score = objRow[convzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.Score].ToString().Trim()); //评分
objvzx_SkillEN.StuScore = objRow[convzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.StuScore].ToString().Trim()); //学生平均分
objvzx_SkillEN.TeaScore = objRow[convzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Skill.TeaScore].ToString().Trim()); //教师评分
objvzx_SkillEN.IdCurrEduCls = objRow[convzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SkillEN.GroupTextId = objRow[convzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[convzx_Skill.GroupTextId].ToString().Trim(); //小组Id
objvzx_SkillEN.PdfZoom = objRow[convzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[convzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_SkillEN.PdfPageTop = objRow[convzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_SkillEN.PdfPageNumIn = objRow[convzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_SkillEN.PdfDivTop = objRow[convzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_SkillEN.PdfDivLet = objRow[convzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_SkillEN.Memo = objRow[convzx_Skill.Memo] == DBNull.Value ? null : objRow[convzx_Skill.Memo].ToString().Trim(); //备注
objvzx_SkillEN.zxShareId = objRow[convzx_Skill.zxShareId] == DBNull.Value ? null : objRow[convzx_Skill.zxShareId].ToString().Trim(); //分享Id
objvzx_SkillEN.VersionCount = objRow[convzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.VersionCount].ToString().Trim()); //版本统计
objvzx_SkillEN.CitationCount = objRow[convzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.CitationCount].ToString().Trim()); //引用统计
objvzx_SkillEN.PdfPageNum = objRow[convzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_SkillEN.PdfContent = objRow[convzx_Skill.PdfContent] == DBNull.Value ? null : objRow[convzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Skill(ref clsvzx_SkillEN objvzx_SkillEN)
{
bool bolResult = vzx_SkillDA.Getvzx_Skill(ref objvzx_SkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SkillEN GetObjByzxSkillId(string strzxSkillId)
{
if (strzxSkillId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxSkillId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxSkillId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_SkillEN objvzx_SkillEN = vzx_SkillDA.GetObjByzxSkillId(strzxSkillId);
return objvzx_SkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SkillEN objvzx_SkillEN = vzx_SkillDA.GetFirstObj(strWhereCond);
 return objvzx_SkillEN;
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
public static clsvzx_SkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SkillEN objvzx_SkillEN = vzx_SkillDA.GetObjByDataRow(objRow);
 return objvzx_SkillEN;
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
public static clsvzx_SkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SkillEN objvzx_SkillEN = vzx_SkillDA.GetObjByDataRow(objRow);
 return objvzx_SkillEN;
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
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <param name = "lstvzx_SkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SkillEN GetObjByzxSkillIdFromList(string strzxSkillId, List<clsvzx_SkillEN> lstvzx_SkillObjLst)
{
foreach (clsvzx_SkillEN objvzx_SkillEN in lstvzx_SkillObjLst)
{
if (objvzx_SkillEN.zxSkillId == strzxSkillId)
{
return objvzx_SkillEN;
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
 string strMaxZxSkillId;
 try
 {
 strMaxZxSkillId = clsvzx_SkillDA.GetMaxStrId();
 return strMaxZxSkillId;
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
 string strzxSkillId;
 try
 {
 strzxSkillId = new clsvzx_SkillDA().GetFirstID(strWhereCond);
 return strzxSkillId;
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
 arrList = vzx_SkillDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxSkillId)
{
if (string.IsNullOrEmpty(strzxSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxSkillId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_SkillDA.IsExist(strzxSkillId);
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
 bolIsExist = clsvzx_SkillDA.IsExistTable();
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
 bolIsExist = vzx_SkillDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SkillENS">源对象</param>
 /// <param name = "objvzx_SkillENT">目标对象</param>
 public static void CopyTo(clsvzx_SkillEN objvzx_SkillENS, clsvzx_SkillEN objvzx_SkillENT)
{
try
{
objvzx_SkillENT.OperationTypeName = objvzx_SkillENS.OperationTypeName; //操作类型名
objvzx_SkillENT.LevelName = objvzx_SkillENS.LevelName; //级别名称
objvzx_SkillENT.zxSkillId = objvzx_SkillENS.zxSkillId; //技能Id
objvzx_SkillENT.SkillName = objvzx_SkillENS.SkillName; //技能名称
objvzx_SkillENT.zxOperationTypeId = objvzx_SkillENS.zxOperationTypeId; //操作类型ID
objvzx_SkillENT.Process = objvzx_SkillENS.Process; //实施过程
objvzx_SkillENT.zxLevelId = objvzx_SkillENS.zxLevelId; //级别Id
objvzx_SkillENT.UpdUser = objvzx_SkillENS.UpdUser; //修改人
objvzx_SkillENT.CreateDate = objvzx_SkillENS.CreateDate; //建立日期
objvzx_SkillENT.UpdDate = objvzx_SkillENS.UpdDate; //修改日期
objvzx_SkillENT.IsSubmit = objvzx_SkillENS.IsSubmit; //是否提交
objvzx_SkillENT.TextId = objvzx_SkillENS.TextId; //课件Id
objvzx_SkillENT.VoteCount = objvzx_SkillENS.VoteCount; //点赞计数
objvzx_SkillENT.AppraiseCount = objvzx_SkillENS.AppraiseCount; //评论数
objvzx_SkillENT.Score = objvzx_SkillENS.Score; //评分
objvzx_SkillENT.StuScore = objvzx_SkillENS.StuScore; //学生平均分
objvzx_SkillENT.TeaScore = objvzx_SkillENS.TeaScore; //教师评分
objvzx_SkillENT.IdCurrEduCls = objvzx_SkillENS.IdCurrEduCls; //教学班流水号
objvzx_SkillENT.GroupTextId = objvzx_SkillENS.GroupTextId; //小组Id
objvzx_SkillENT.PdfZoom = objvzx_SkillENS.PdfZoom; //PdfZoom
objvzx_SkillENT.PdfPageTop = objvzx_SkillENS.PdfPageTop; //pdf页面顶部位置
objvzx_SkillENT.PdfPageNumIn = objvzx_SkillENS.PdfPageNumIn; //PdfPageNumIn
objvzx_SkillENT.PdfDivTop = objvzx_SkillENS.PdfDivTop; //PdfDivTop
objvzx_SkillENT.PdfDivLet = objvzx_SkillENS.PdfDivLet; //PdfDivLet
objvzx_SkillENT.Memo = objvzx_SkillENS.Memo; //备注
objvzx_SkillENT.zxShareId = objvzx_SkillENS.zxShareId; //分享Id
objvzx_SkillENT.VersionCount = objvzx_SkillENS.VersionCount; //版本统计
objvzx_SkillENT.CitationCount = objvzx_SkillENS.CitationCount; //引用统计
objvzx_SkillENT.PdfPageNum = objvzx_SkillENS.PdfPageNum; //Pdf页码
objvzx_SkillENT.PdfContent = objvzx_SkillENS.PdfContent; //Pdf内容
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
 /// <param name = "objvzx_SkillEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SkillEN objvzx_SkillEN)
{
try
{
objvzx_SkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Skill.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.OperationTypeName = objvzx_SkillEN.OperationTypeName == "[null]" ? null :  objvzx_SkillEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convzx_Skill.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.LevelName = objvzx_SkillEN.LevelName == "[null]" ? null :  objvzx_SkillEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convzx_Skill.zxSkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.zxSkillId = objvzx_SkillEN.zxSkillId; //技能Id
}
if (arrFldSet.Contains(convzx_Skill.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.SkillName = objvzx_SkillEN.SkillName == "[null]" ? null :  objvzx_SkillEN.SkillName; //技能名称
}
if (arrFldSet.Contains(convzx_Skill.zxOperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.zxOperationTypeId = objvzx_SkillEN.zxOperationTypeId == "[null]" ? null :  objvzx_SkillEN.zxOperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convzx_Skill.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.Process = objvzx_SkillEN.Process == "[null]" ? null :  objvzx_SkillEN.Process; //实施过程
}
if (arrFldSet.Contains(convzx_Skill.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.zxLevelId = objvzx_SkillEN.zxLevelId == "[null]" ? null :  objvzx_SkillEN.zxLevelId; //级别Id
}
if (arrFldSet.Contains(convzx_Skill.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.UpdUser = objvzx_SkillEN.UpdUser == "[null]" ? null :  objvzx_SkillEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Skill.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.CreateDate = objvzx_SkillEN.CreateDate == "[null]" ? null :  objvzx_SkillEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_Skill.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.UpdDate = objvzx_SkillEN.UpdDate == "[null]" ? null :  objvzx_SkillEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Skill.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.IsSubmit = objvzx_SkillEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Skill.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.TextId = objvzx_SkillEN.TextId == "[null]" ? null :  objvzx_SkillEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Skill.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.VoteCount = objvzx_SkillEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Skill.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.AppraiseCount = objvzx_SkillEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_Skill.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.Score = objvzx_SkillEN.Score; //评分
}
if (arrFldSet.Contains(convzx_Skill.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.StuScore = objvzx_SkillEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_Skill.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.TeaScore = objvzx_SkillEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_Skill.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.IdCurrEduCls = objvzx_SkillEN.IdCurrEduCls == "[null]" ? null :  objvzx_SkillEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Skill.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.GroupTextId = objvzx_SkillEN.GroupTextId == "[null]" ? null :  objvzx_SkillEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_Skill.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfZoom = objvzx_SkillEN.PdfZoom == "[null]" ? null :  objvzx_SkillEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_Skill.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfPageTop = objvzx_SkillEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_Skill.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfPageNumIn = objvzx_SkillEN.PdfPageNumIn == "[null]" ? null :  objvzx_SkillEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_Skill.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfDivTop = objvzx_SkillEN.PdfDivTop == "[null]" ? null :  objvzx_SkillEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_Skill.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfDivLet = objvzx_SkillEN.PdfDivLet == "[null]" ? null :  objvzx_SkillEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_Skill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.Memo = objvzx_SkillEN.Memo == "[null]" ? null :  objvzx_SkillEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Skill.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.zxShareId = objvzx_SkillEN.zxShareId == "[null]" ? null :  objvzx_SkillEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_Skill.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.VersionCount = objvzx_SkillEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_Skill.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.CitationCount = objvzx_SkillEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convzx_Skill.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfPageNum = objvzx_SkillEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_Skill.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SkillEN.PdfContent = objvzx_SkillEN.PdfContent == "[null]" ? null :  objvzx_SkillEN.PdfContent; //Pdf内容
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
 /// <param name = "objvzx_SkillEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SkillEN objvzx_SkillEN)
{
try
{
if (objvzx_SkillEN.OperationTypeName == "[null]") objvzx_SkillEN.OperationTypeName = null; //操作类型名
if (objvzx_SkillEN.LevelName == "[null]") objvzx_SkillEN.LevelName = null; //级别名称
if (objvzx_SkillEN.SkillName == "[null]") objvzx_SkillEN.SkillName = null; //技能名称
if (objvzx_SkillEN.zxOperationTypeId == "[null]") objvzx_SkillEN.zxOperationTypeId = null; //操作类型ID
if (objvzx_SkillEN.Process == "[null]") objvzx_SkillEN.Process = null; //实施过程
if (objvzx_SkillEN.zxLevelId == "[null]") objvzx_SkillEN.zxLevelId = null; //级别Id
if (objvzx_SkillEN.UpdUser == "[null]") objvzx_SkillEN.UpdUser = null; //修改人
if (objvzx_SkillEN.CreateDate == "[null]") objvzx_SkillEN.CreateDate = null; //建立日期
if (objvzx_SkillEN.UpdDate == "[null]") objvzx_SkillEN.UpdDate = null; //修改日期
if (objvzx_SkillEN.TextId == "[null]") objvzx_SkillEN.TextId = null; //课件Id
if (objvzx_SkillEN.IdCurrEduCls == "[null]") objvzx_SkillEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_SkillEN.GroupTextId == "[null]") objvzx_SkillEN.GroupTextId = null; //小组Id
if (objvzx_SkillEN.PdfZoom == "[null]") objvzx_SkillEN.PdfZoom = null; //PdfZoom
if (objvzx_SkillEN.PdfPageNumIn == "[null]") objvzx_SkillEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_SkillEN.PdfDivTop == "[null]") objvzx_SkillEN.PdfDivTop = null; //PdfDivTop
if (objvzx_SkillEN.PdfDivLet == "[null]") objvzx_SkillEN.PdfDivLet = null; //PdfDivLet
if (objvzx_SkillEN.Memo == "[null]") objvzx_SkillEN.Memo = null; //备注
if (objvzx_SkillEN.zxShareId == "[null]") objvzx_SkillEN.zxShareId = null; //分享Id
if (objvzx_SkillEN.PdfContent == "[null]") objvzx_SkillEN.PdfContent = null; //Pdf内容
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
public static void CheckProperty4Condition(clsvzx_SkillEN objvzx_SkillEN)
{
 vzx_SkillDA.CheckProperty4Condition(objvzx_SkillEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_zxSkillId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convzx_Skill.zxSkillId); 
List<clsvzx_SkillEN> arrObjLst = clsvzx_SkillBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvzx_SkillEN objvzx_SkillEN = new clsvzx_SkillEN()
{
zxSkillId = "0",
zxOperationTypeId = "选[vzx_Skill]..."
};
arrObjLst.Insert(0, objvzx_SkillEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convzx_Skill.zxSkillId;
objComboBox.DisplayMember = convzx_Skill.zxOperationTypeId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_zxSkillId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vzx_Skill]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convzx_Skill.zxSkillId); 
IEnumerable<clsvzx_SkillEN> arrObjLst = clsvzx_SkillBL.GetObjLst(strCondition);
objDDL.DataValueField = convzx_Skill.zxSkillId;
objDDL.DataTextField = convzx_Skill.zxOperationTypeId;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_zxSkillIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vzx_Skill]...","0");
List<clsvzx_SkillEN> arrvzx_SkillObjLst = GetAllvzx_SkillObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convzx_Skill.zxSkillId;
objDDL.DataTextField = convzx_Skill.zxOperationTypeId;
objDDL.DataSource = arrvzx_SkillObjLst;
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
if (clszx_SkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SkillBL没有刷新缓存机制(clszx_SkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysOperationTypeBL没有刷新缓存机制(clszx_SysOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysSecurityLevelBL没有刷新缓存机制(clszx_SysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxSkillId");
//if (arrvzx_SkillObjLstCache == null)
//{
//arrvzx_SkillObjLstCache = vzx_SkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SkillEN GetObjByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SkillEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SkillEN> arrvzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SkillEN> arrvzx_SkillObjLst_Sel =
arrvzx_SkillObjLstCache
.Where(x=> x.zxSkillId == strzxSkillId 
);
if (arrvzx_SkillObjLst_Sel.Count() == 0)
{
   clsvzx_SkillEN obj = clsvzx_SkillBL.GetObjByzxSkillId(strzxSkillId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxSkillId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_SkillObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetzxLevelIdByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSkillId) == true) return "";
//获取缓存中的对象列表
clsvzx_SkillEN objvzx_Skill = GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objvzx_Skill == null) return "";
return objvzx_Skill.zxLevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSkillId) == true) return "";
//获取缓存中的对象列表
clsvzx_SkillEN objvzx_Skill = GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objvzx_Skill == null) return "";
return objvzx_Skill.zxLevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SkillEN> GetAllvzx_SkillObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_SkillEN> arrvzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_SkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SkillEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SkillEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_SkillEN> arrvzx_SkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_SkillObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_SkillEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strzxSkillId, string strIdCurrEduCls)
{
if (strInFldName != convzx_Skill.zxSkillId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Skill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Skill.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Skill = clsvzx_SkillBL.GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objvzx_Skill == null) return "";
return objvzx_Skill[strOutFldName].ToString();
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
int intRecCount = clsvzx_SkillDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SkillDA.GetRecCount();
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
int intRecCount = clsvzx_SkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SkillEN objvzx_SkillCond)
{
 string strIdCurrEduCls = objvzx_SkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_SkillBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_SkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Skill.AttributeName)
{
if (objvzx_SkillCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SkillCond[strFldName].ToString());
}
else
{
if (objvzx_SkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SkillCond[strFldName]));
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
 List<string> arrList = clsvzx_SkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}