
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSkillBL
 表名:vSysSkill(01120653)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:24
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
public static class  clsvSysSkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysSkillEN GetObj(this K_SkillId_vSysSkill myKey)
{
clsvSysSkillEN objvSysSkillEN = clsvSysSkillBL.vSysSkillDA.GetObjBySkillId(myKey.Value);
return objvSysSkillEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetSkillId(this clsvSysSkillEN objvSysSkillEN, string strSkillId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, convSysSkill.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, convSysSkill.SkillId);
}
objvSysSkillEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.SkillId) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.SkillId, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.SkillId] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetSkillName(this clsvSysSkillEN objvSysSkillEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, convSysSkill.SkillName);
}
objvSysSkillEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.SkillName) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.SkillName, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.SkillName] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetProcess(this clsvSysSkillEN objvSysSkillEN, string strProcess, string strComparisonOp="")
	{
objvSysSkillEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.Process) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.Process, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.Process] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetOperationTypeId(this clsvSysSkillEN objvSysSkillEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convSysSkill.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convSysSkill.OperationTypeId);
}
objvSysSkillEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.OperationTypeId) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.OperationTypeId, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.OperationTypeId] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetLevelId(this clsvSysSkillEN objvSysSkillEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convSysSkill.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convSysSkill.LevelId);
}
objvSysSkillEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.LevelId) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.LevelId, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.LevelId] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetLevelName(this clsvSysSkillEN objvSysSkillEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convSysSkill.LevelName);
}
objvSysSkillEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.LevelName) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.LevelName, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.LevelName] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetUpdUser(this clsvSysSkillEN objvSysSkillEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysSkill.UpdUser);
}
objvSysSkillEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.UpdUser) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.UpdUser, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.UpdUser] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetUpdDate(this clsvSysSkillEN objvSysSkillEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysSkill.UpdDate);
}
objvSysSkillEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.UpdDate) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.UpdDate, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.UpdDate] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetIsSubmit(this clsvSysSkillEN objvSysSkillEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvSysSkillEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.IsSubmit) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.IsSubmit, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.IsSubmit] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetCitationId(this clsvSysSkillEN objvSysSkillEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convSysSkill.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convSysSkill.CitationId);
}
objvSysSkillEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.CitationId) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.CitationId, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.CitationId] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetOkCount(this clsvSysSkillEN objvSysSkillEN, int? intOkCount, string strComparisonOp="")
	{
objvSysSkillEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.OkCount) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.OkCount, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.OkCount] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetAppraiseCount(this clsvSysSkillEN objvSysSkillEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvSysSkillEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.AppraiseCount) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.AppraiseCount, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.AppraiseCount] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetScore(this clsvSysSkillEN objvSysSkillEN, float? fltScore, string strComparisonOp="")
	{
objvSysSkillEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.Score) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.Score, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.Score] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetStuScore(this clsvSysSkillEN objvSysSkillEN, float? fltStuScore, string strComparisonOp="")
	{
objvSysSkillEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.StuScore) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.StuScore, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.StuScore] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetTeaScore(this clsvSysSkillEN objvSysSkillEN, float? fltTeaScore, string strComparisonOp="")
	{
objvSysSkillEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.TeaScore) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.TeaScore, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.TeaScore] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetIdCurrEduCls(this clsvSysSkillEN objvSysSkillEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysSkill.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysSkill.IdCurrEduCls);
}
objvSysSkillEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.IdCurrEduCls) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetPdfContent(this clsvSysSkillEN objvSysSkillEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convSysSkill.PdfContent);
}
objvSysSkillEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.PdfContent) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.PdfContent, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.PdfContent] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetPdfPageNum(this clsvSysSkillEN objvSysSkillEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvSysSkillEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.PdfPageNum) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.PdfPageNum, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.PdfPageNum] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetCitationCount(this clsvSysSkillEN objvSysSkillEN, int? intCitationCount, string strComparisonOp="")
	{
objvSysSkillEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.CitationCount) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.CitationCount, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.CitationCount] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetVersionCount(this clsvSysSkillEN objvSysSkillEN, int? intVersionCount, string strComparisonOp="")
	{
objvSysSkillEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.VersionCount) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.VersionCount, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.VersionCount] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetMemo(this clsvSysSkillEN objvSysSkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysSkill.Memo);
}
objvSysSkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.Memo) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.Memo, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.Memo] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetOperationTypeName(this clsvSysSkillEN objvSysSkillEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convSysSkill.OperationTypeName);
}
objvSysSkillEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.OperationTypeName) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.OperationTypeName, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.OperationTypeName] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetCreateDate(this clsvSysSkillEN objvSysSkillEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convSysSkill.CreateDate);
}
objvSysSkillEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.CreateDate) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.CreateDate, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.CreateDate] = strComparisonOp;
}
}
return objvSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysSkillEN SetShareId(this clsvSysSkillEN objvSysSkillEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convSysSkill.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convSysSkill.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convSysSkill.ShareId);
}
objvSysSkillEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysSkillEN.dicFldComparisonOp.ContainsKey(convSysSkill.ShareId) == false)
{
objvSysSkillEN.dicFldComparisonOp.Add(convSysSkill.ShareId, strComparisonOp);
}
else
{
objvSysSkillEN.dicFldComparisonOp[convSysSkill.ShareId] = strComparisonOp;
}
}
return objvSysSkillEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <param name = "objvSysSkillENT">目标对象</param>
 public static void CopyTo(this clsvSysSkillEN objvSysSkillENS, clsvSysSkillEN objvSysSkillENT)
{
try
{
objvSysSkillENT.SkillId = objvSysSkillENS.SkillId; //技能Id
objvSysSkillENT.SkillName = objvSysSkillENS.SkillName; //技能名称
objvSysSkillENT.Process = objvSysSkillENS.Process; //实施过程
objvSysSkillENT.OperationTypeId = objvSysSkillENS.OperationTypeId; //操作类型ID
objvSysSkillENT.LevelId = objvSysSkillENS.LevelId; //级别Id
objvSysSkillENT.LevelName = objvSysSkillENS.LevelName; //级别名称
objvSysSkillENT.UpdUser = objvSysSkillENS.UpdUser; //修改人
objvSysSkillENT.UpdDate = objvSysSkillENS.UpdDate; //修改日期
objvSysSkillENT.IsSubmit = objvSysSkillENS.IsSubmit; //是否提交
objvSysSkillENT.CitationId = objvSysSkillENS.CitationId; //引用Id
objvSysSkillENT.OkCount = objvSysSkillENS.OkCount; //点赞统计
objvSysSkillENT.AppraiseCount = objvSysSkillENS.AppraiseCount; //评论数
objvSysSkillENT.Score = objvSysSkillENS.Score; //评分
objvSysSkillENT.StuScore = objvSysSkillENS.StuScore; //学生平均分
objvSysSkillENT.TeaScore = objvSysSkillENS.TeaScore; //教师评分
objvSysSkillENT.IdCurrEduCls = objvSysSkillENS.IdCurrEduCls; //教学班流水号
objvSysSkillENT.PdfContent = objvSysSkillENS.PdfContent; //Pdf内容
objvSysSkillENT.PdfPageNum = objvSysSkillENS.PdfPageNum; //Pdf页码
objvSysSkillENT.CitationCount = objvSysSkillENS.CitationCount; //引用统计
objvSysSkillENT.VersionCount = objvSysSkillENS.VersionCount; //版本统计
objvSysSkillENT.Memo = objvSysSkillENS.Memo; //备注
objvSysSkillENT.OperationTypeName = objvSysSkillENS.OperationTypeName; //操作类型名
objvSysSkillENT.CreateDate = objvSysSkillENS.CreateDate; //建立日期
objvSysSkillENT.ShareId = objvSysSkillENS.ShareId; //分享Id
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
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <returns>目标对象=>clsvSysSkillEN:objvSysSkillENT</returns>
 public static clsvSysSkillEN CopyTo(this clsvSysSkillEN objvSysSkillENS)
{
try
{
 clsvSysSkillEN objvSysSkillENT = new clsvSysSkillEN()
{
SkillId = objvSysSkillENS.SkillId, //技能Id
SkillName = objvSysSkillENS.SkillName, //技能名称
Process = objvSysSkillENS.Process, //实施过程
OperationTypeId = objvSysSkillENS.OperationTypeId, //操作类型ID
LevelId = objvSysSkillENS.LevelId, //级别Id
LevelName = objvSysSkillENS.LevelName, //级别名称
UpdUser = objvSysSkillENS.UpdUser, //修改人
UpdDate = objvSysSkillENS.UpdDate, //修改日期
IsSubmit = objvSysSkillENS.IsSubmit, //是否提交
CitationId = objvSysSkillENS.CitationId, //引用Id
OkCount = objvSysSkillENS.OkCount, //点赞统计
AppraiseCount = objvSysSkillENS.AppraiseCount, //评论数
Score = objvSysSkillENS.Score, //评分
StuScore = objvSysSkillENS.StuScore, //学生平均分
TeaScore = objvSysSkillENS.TeaScore, //教师评分
IdCurrEduCls = objvSysSkillENS.IdCurrEduCls, //教学班流水号
PdfContent = objvSysSkillENS.PdfContent, //Pdf内容
PdfPageNum = objvSysSkillENS.PdfPageNum, //Pdf页码
CitationCount = objvSysSkillENS.CitationCount, //引用统计
VersionCount = objvSysSkillENS.VersionCount, //版本统计
Memo = objvSysSkillENS.Memo, //备注
OperationTypeName = objvSysSkillENS.OperationTypeName, //操作类型名
CreateDate = objvSysSkillENS.CreateDate, //建立日期
ShareId = objvSysSkillENS.ShareId, //分享Id
};
 return objvSysSkillENT;
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
public static void CheckProperty4Condition(this clsvSysSkillEN objvSysSkillEN)
{
 clsvSysSkillBL.vSysSkillDA.CheckProperty4Condition(objvSysSkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysSkillEN objvSysSkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysSkillCond.IsUpdated(convSysSkill.SkillId) == true)
{
string strComparisonOpSkillId = objvSysSkillCond.dicFldComparisonOp[convSysSkill.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.SkillId, objvSysSkillCond.SkillId, strComparisonOpSkillId);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.SkillName) == true)
{
string strComparisonOpSkillName = objvSysSkillCond.dicFldComparisonOp[convSysSkill.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.SkillName, objvSysSkillCond.SkillName, strComparisonOpSkillName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvSysSkillCond.IsUpdated(convSysSkill.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvSysSkillCond.dicFldComparisonOp[convSysSkill.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.OperationTypeId, objvSysSkillCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.LevelId) == true)
{
string strComparisonOpLevelId = objvSysSkillCond.dicFldComparisonOp[convSysSkill.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.LevelId, objvSysSkillCond.LevelId, strComparisonOpLevelId);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.LevelName) == true)
{
string strComparisonOpLevelName = objvSysSkillCond.dicFldComparisonOp[convSysSkill.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.LevelName, objvSysSkillCond.LevelName, strComparisonOpLevelName);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysSkillCond.dicFldComparisonOp[convSysSkill.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.UpdUser, objvSysSkillCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysSkillCond.dicFldComparisonOp[convSysSkill.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.UpdDate, objvSysSkillCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.IsSubmit) == true)
{
if (objvSysSkillCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSysSkill.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSysSkill.IsSubmit);
}
}
if (objvSysSkillCond.IsUpdated(convSysSkill.CitationId) == true)
{
string strComparisonOpCitationId = objvSysSkillCond.dicFldComparisonOp[convSysSkill.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.CitationId, objvSysSkillCond.CitationId, strComparisonOpCitationId);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.OkCount) == true)
{
string strComparisonOpOkCount = objvSysSkillCond.dicFldComparisonOp[convSysSkill.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.OkCount, objvSysSkillCond.OkCount, strComparisonOpOkCount);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvSysSkillCond.dicFldComparisonOp[convSysSkill.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.AppraiseCount, objvSysSkillCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.Score) == true)
{
string strComparisonOpScore = objvSysSkillCond.dicFldComparisonOp[convSysSkill.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.Score, objvSysSkillCond.Score, strComparisonOpScore);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.StuScore) == true)
{
string strComparisonOpStuScore = objvSysSkillCond.dicFldComparisonOp[convSysSkill.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.StuScore, objvSysSkillCond.StuScore, strComparisonOpStuScore);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.TeaScore) == true)
{
string strComparisonOpTeaScore = objvSysSkillCond.dicFldComparisonOp[convSysSkill.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.TeaScore, objvSysSkillCond.TeaScore, strComparisonOpTeaScore);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysSkillCond.dicFldComparisonOp[convSysSkill.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.IdCurrEduCls, objvSysSkillCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.PdfContent) == true)
{
string strComparisonOpPdfContent = objvSysSkillCond.dicFldComparisonOp[convSysSkill.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.PdfContent, objvSysSkillCond.PdfContent, strComparisonOpPdfContent);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvSysSkillCond.dicFldComparisonOp[convSysSkill.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.PdfPageNum, objvSysSkillCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.CitationCount) == true)
{
string strComparisonOpCitationCount = objvSysSkillCond.dicFldComparisonOp[convSysSkill.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.CitationCount, objvSysSkillCond.CitationCount, strComparisonOpCitationCount);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.VersionCount) == true)
{
string strComparisonOpVersionCount = objvSysSkillCond.dicFldComparisonOp[convSysSkill.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convSysSkill.VersionCount, objvSysSkillCond.VersionCount, strComparisonOpVersionCount);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.Memo) == true)
{
string strComparisonOpMemo = objvSysSkillCond.dicFldComparisonOp[convSysSkill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.Memo, objvSysSkillCond.Memo, strComparisonOpMemo);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvSysSkillCond.dicFldComparisonOp[convSysSkill.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.OperationTypeName, objvSysSkillCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.CreateDate) == true)
{
string strComparisonOpCreateDate = objvSysSkillCond.dicFldComparisonOp[convSysSkill.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.CreateDate, objvSysSkillCond.CreateDate, strComparisonOpCreateDate);
}
if (objvSysSkillCond.IsUpdated(convSysSkill.ShareId) == true)
{
string strComparisonOpShareId = objvSysSkillCond.dicFldComparisonOp[convSysSkill.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysSkill.ShareId, objvSysSkillCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysSkill
{
public virtual bool UpdRelaTabDate(string strSkillId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 技能表视图(vSysSkill)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysSkillBL
{
public static RelatedActions_vSysSkill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysSkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysSkillDA vSysSkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysSkillDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysSkillBL()
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
if (string.IsNullOrEmpty(clsvSysSkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysSkillEN._ConnectString);
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
public static DataTable GetDataTable_vSysSkill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysSkillDA.GetDataTable_vSysSkill(strWhereCond);
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
objDT = vSysSkillDA.GetDataTable(strWhereCond);
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
objDT = vSysSkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysSkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysSkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysSkillDA.GetDataTable_Top(objTopPara);
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
objDT = vSysSkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysSkillEN> GetObjLstBySkillIdLst(List<string> arrSkillIdLst)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSkillIdLst, true);
 string strWhereCond = string.Format("SkillId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysSkillEN> GetObjLstBySkillIdLstCache(List<string> arrSkillIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvSysSkillEN._CurrTabName, strIdCurrEduCls);
List<clsvSysSkillEN> arrvSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSkillEN> arrvSysSkillObjLst_Sel =
arrvSysSkillObjLstCache
.Where(x => arrSkillIdLst.Contains(x.SkillId));
return arrvSysSkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSkillEN> GetObjLst(string strWhereCond)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
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
public static List<clsvSysSkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysSkillEN> GetSubObjLstCache(clsvSysSkillEN objvSysSkillCond)
{
 string strIdCurrEduCls = objvSysSkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSysSkillBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSysSkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysSkill.AttributeName)
{
if (objvSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objvSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSkillCond[strFldName].ToString());
}
else
{
if (objvSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysSkillCond[strFldName]));
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
public static List<clsvSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
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
public static List<clsvSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
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
List<clsvSysSkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysSkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
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
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
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
public static List<clsvSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysSkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
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
public static List<clsvSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysSkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysSkillEN> arrObjLst = new List<clsvSysSkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysSkillEN objvSysSkillEN = new clsvSysSkillEN();
try
{
objvSysSkillEN.SkillId = objRow[convSysSkill.SkillId].ToString().Trim(); //技能Id
objvSysSkillEN.SkillName = objRow[convSysSkill.SkillName] == DBNull.Value ? null : objRow[convSysSkill.SkillName].ToString().Trim(); //技能名称
objvSysSkillEN.Process = objRow[convSysSkill.Process] == DBNull.Value ? null : objRow[convSysSkill.Process].ToString().Trim(); //实施过程
objvSysSkillEN.OperationTypeId = objRow[convSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvSysSkillEN.LevelId = objRow[convSysSkill.LevelId] == DBNull.Value ? null : objRow[convSysSkill.LevelId].ToString().Trim(); //级别Id
objvSysSkillEN.LevelName = objRow[convSysSkill.LevelName] == DBNull.Value ? null : objRow[convSysSkill.LevelName].ToString().Trim(); //级别名称
objvSysSkillEN.UpdUser = objRow[convSysSkill.UpdUser] == DBNull.Value ? null : objRow[convSysSkill.UpdUser].ToString().Trim(); //修改人
objvSysSkillEN.UpdDate = objRow[convSysSkill.UpdDate] == DBNull.Value ? null : objRow[convSysSkill.UpdDate].ToString().Trim(); //修改日期
objvSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvSysSkillEN.CitationId = objRow[convSysSkill.CitationId] == DBNull.Value ? null : objRow[convSysSkill.CitationId].ToString().Trim(); //引用Id
objvSysSkillEN.OkCount = objRow[convSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.OkCount].ToString().Trim()); //点赞统计
objvSysSkillEN.AppraiseCount = objRow[convSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvSysSkillEN.Score = objRow[convSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.Score].ToString().Trim()); //评分
objvSysSkillEN.StuScore = objRow[convSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.StuScore].ToString().Trim()); //学生平均分
objvSysSkillEN.TeaScore = objRow[convSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysSkill.TeaScore].ToString().Trim()); //教师评分
objvSysSkillEN.IdCurrEduCls = objRow[convSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysSkillEN.PdfContent = objRow[convSysSkill.PdfContent] == DBNull.Value ? null : objRow[convSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvSysSkillEN.PdfPageNum = objRow[convSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvSysSkillEN.CitationCount = objRow[convSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.CitationCount].ToString().Trim()); //引用统计
objvSysSkillEN.VersionCount = objRow[convSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSysSkill.VersionCount].ToString().Trim()); //版本统计
objvSysSkillEN.Memo = objRow[convSysSkill.Memo] == DBNull.Value ? null : objRow[convSysSkill.Memo].ToString().Trim(); //备注
objvSysSkillEN.OperationTypeName = objRow[convSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvSysSkillEN.CreateDate = objRow[convSysSkill.CreateDate] == DBNull.Value ? null : objRow[convSysSkill.CreateDate].ToString().Trim(); //建立日期
objvSysSkillEN.ShareId = objRow[convSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysSkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysSkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysSkill(ref clsvSysSkillEN objvSysSkillEN)
{
bool bolResult = vSysSkillDA.GetvSysSkill(ref objvSysSkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysSkillEN GetObjBySkillId(string strSkillId)
{
if (strSkillId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSkillId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSkillId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSysSkillEN objvSysSkillEN = vSysSkillDA.GetObjBySkillId(strSkillId);
return objvSysSkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysSkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysSkillEN objvSysSkillEN = vSysSkillDA.GetFirstObj(strWhereCond);
 return objvSysSkillEN;
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
public static clsvSysSkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysSkillEN objvSysSkillEN = vSysSkillDA.GetObjByDataRow(objRow);
 return objvSysSkillEN;
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
public static clsvSysSkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysSkillEN objvSysSkillEN = vSysSkillDA.GetObjByDataRow(objRow);
 return objvSysSkillEN;
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
 /// <param name = "strSkillId">所给的关键字</param>
 /// <param name = "lstvSysSkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysSkillEN GetObjBySkillIdFromList(string strSkillId, List<clsvSysSkillEN> lstvSysSkillObjLst)
{
foreach (clsvSysSkillEN objvSysSkillEN in lstvSysSkillObjLst)
{
if (objvSysSkillEN.SkillId == strSkillId)
{
return objvSysSkillEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strSkillId;
 try
 {
 strSkillId = new clsvSysSkillDA().GetFirstID(strWhereCond);
 return strSkillId;
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
 arrList = vSysSkillDA.GetID(strWhereCond);
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
bool bolIsExist = vSysSkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSkillId)
{
if (string.IsNullOrEmpty(strSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSkillId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSysSkillDA.IsExist(strSkillId);
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
 bolIsExist = clsvSysSkillDA.IsExistTable();
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
 bolIsExist = vSysSkillDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysSkillENS">源对象</param>
 /// <param name = "objvSysSkillENT">目标对象</param>
 public static void CopyTo(clsvSysSkillEN objvSysSkillENS, clsvSysSkillEN objvSysSkillENT)
{
try
{
objvSysSkillENT.SkillId = objvSysSkillENS.SkillId; //技能Id
objvSysSkillENT.SkillName = objvSysSkillENS.SkillName; //技能名称
objvSysSkillENT.Process = objvSysSkillENS.Process; //实施过程
objvSysSkillENT.OperationTypeId = objvSysSkillENS.OperationTypeId; //操作类型ID
objvSysSkillENT.LevelId = objvSysSkillENS.LevelId; //级别Id
objvSysSkillENT.LevelName = objvSysSkillENS.LevelName; //级别名称
objvSysSkillENT.UpdUser = objvSysSkillENS.UpdUser; //修改人
objvSysSkillENT.UpdDate = objvSysSkillENS.UpdDate; //修改日期
objvSysSkillENT.IsSubmit = objvSysSkillENS.IsSubmit; //是否提交
objvSysSkillENT.CitationId = objvSysSkillENS.CitationId; //引用Id
objvSysSkillENT.OkCount = objvSysSkillENS.OkCount; //点赞统计
objvSysSkillENT.AppraiseCount = objvSysSkillENS.AppraiseCount; //评论数
objvSysSkillENT.Score = objvSysSkillENS.Score; //评分
objvSysSkillENT.StuScore = objvSysSkillENS.StuScore; //学生平均分
objvSysSkillENT.TeaScore = objvSysSkillENS.TeaScore; //教师评分
objvSysSkillENT.IdCurrEduCls = objvSysSkillENS.IdCurrEduCls; //教学班流水号
objvSysSkillENT.PdfContent = objvSysSkillENS.PdfContent; //Pdf内容
objvSysSkillENT.PdfPageNum = objvSysSkillENS.PdfPageNum; //Pdf页码
objvSysSkillENT.CitationCount = objvSysSkillENS.CitationCount; //引用统计
objvSysSkillENT.VersionCount = objvSysSkillENS.VersionCount; //版本统计
objvSysSkillENT.Memo = objvSysSkillENS.Memo; //备注
objvSysSkillENT.OperationTypeName = objvSysSkillENS.OperationTypeName; //操作类型名
objvSysSkillENT.CreateDate = objvSysSkillENS.CreateDate; //建立日期
objvSysSkillENT.ShareId = objvSysSkillENS.ShareId; //分享Id
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
 /// <param name = "objvSysSkillEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysSkillEN objvSysSkillEN)
{
try
{
objvSysSkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysSkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysSkill.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.SkillId = objvSysSkillEN.SkillId; //技能Id
}
if (arrFldSet.Contains(convSysSkill.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.SkillName = objvSysSkillEN.SkillName == "[null]" ? null :  objvSysSkillEN.SkillName; //技能名称
}
if (arrFldSet.Contains(convSysSkill.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.Process = objvSysSkillEN.Process == "[null]" ? null :  objvSysSkillEN.Process; //实施过程
}
if (arrFldSet.Contains(convSysSkill.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.OperationTypeId = objvSysSkillEN.OperationTypeId == "[null]" ? null :  objvSysSkillEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convSysSkill.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.LevelId = objvSysSkillEN.LevelId == "[null]" ? null :  objvSysSkillEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convSysSkill.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.LevelName = objvSysSkillEN.LevelName == "[null]" ? null :  objvSysSkillEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convSysSkill.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.UpdUser = objvSysSkillEN.UpdUser == "[null]" ? null :  objvSysSkillEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysSkill.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.UpdDate = objvSysSkillEN.UpdDate == "[null]" ? null :  objvSysSkillEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysSkill.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.IsSubmit = objvSysSkillEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convSysSkill.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.CitationId = objvSysSkillEN.CitationId == "[null]" ? null :  objvSysSkillEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convSysSkill.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.OkCount = objvSysSkillEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convSysSkill.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.AppraiseCount = objvSysSkillEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convSysSkill.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.Score = objvSysSkillEN.Score; //评分
}
if (arrFldSet.Contains(convSysSkill.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.StuScore = objvSysSkillEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convSysSkill.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.TeaScore = objvSysSkillEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convSysSkill.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.IdCurrEduCls = objvSysSkillEN.IdCurrEduCls == "[null]" ? null :  objvSysSkillEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysSkill.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.PdfContent = objvSysSkillEN.PdfContent == "[null]" ? null :  objvSysSkillEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convSysSkill.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.PdfPageNum = objvSysSkillEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convSysSkill.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.CitationCount = objvSysSkillEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convSysSkill.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.VersionCount = objvSysSkillEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convSysSkill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.Memo = objvSysSkillEN.Memo == "[null]" ? null :  objvSysSkillEN.Memo; //备注
}
if (arrFldSet.Contains(convSysSkill.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.OperationTypeName = objvSysSkillEN.OperationTypeName == "[null]" ? null :  objvSysSkillEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convSysSkill.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.CreateDate = objvSysSkillEN.CreateDate == "[null]" ? null :  objvSysSkillEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convSysSkill.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysSkillEN.ShareId = objvSysSkillEN.ShareId; //分享Id
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
 /// <param name = "objvSysSkillEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysSkillEN objvSysSkillEN)
{
try
{
if (objvSysSkillEN.SkillName == "[null]") objvSysSkillEN.SkillName = null; //技能名称
if (objvSysSkillEN.Process == "[null]") objvSysSkillEN.Process = null; //实施过程
if (objvSysSkillEN.OperationTypeId == "[null]") objvSysSkillEN.OperationTypeId = null; //操作类型ID
if (objvSysSkillEN.LevelId == "[null]") objvSysSkillEN.LevelId = null; //级别Id
if (objvSysSkillEN.LevelName == "[null]") objvSysSkillEN.LevelName = null; //级别名称
if (objvSysSkillEN.UpdUser == "[null]") objvSysSkillEN.UpdUser = null; //修改人
if (objvSysSkillEN.UpdDate == "[null]") objvSysSkillEN.UpdDate = null; //修改日期
if (objvSysSkillEN.CitationId == "[null]") objvSysSkillEN.CitationId = null; //引用Id
if (objvSysSkillEN.IdCurrEduCls == "[null]") objvSysSkillEN.IdCurrEduCls = null; //教学班流水号
if (objvSysSkillEN.PdfContent == "[null]") objvSysSkillEN.PdfContent = null; //Pdf内容
if (objvSysSkillEN.Memo == "[null]") objvSysSkillEN.Memo = null; //备注
if (objvSysSkillEN.OperationTypeName == "[null]") objvSysSkillEN.OperationTypeName = null; //操作类型名
if (objvSysSkillEN.CreateDate == "[null]") objvSysSkillEN.CreateDate = null; //建立日期
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
public static void CheckProperty4Condition(clsvSysSkillEN objvSysSkillEN)
{
 vSysSkillDA.CheckProperty4Condition(objvSysSkillEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SkillIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[技能表视图]...","0");
List<clsvSysSkillEN> arrvSysSkillObjLst = GetAllvSysSkillObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convSysSkill.SkillId;
objDDL.DataTextField = convSysSkill.OperationTypeId;
objDDL.DataSource = arrvSysSkillObjLst;
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
if (clsSysSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSkillBL没有刷新缓存机制(clsSysSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSecurityLevelBL没有刷新缓存机制(clsSysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysOperationTypeBL没有刷新缓存机制(clsSysOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SkillId");
//if (arrvSysSkillObjLstCache == null)
//{
//arrvSysSkillObjLstCache = vSysSkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSkillId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysSkillEN GetObjBySkillIdCache(string strSkillId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysSkillEN._CurrTabName, strIdCurrEduCls);
List<clsvSysSkillEN> arrvSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSkillEN> arrvSysSkillObjLst_Sel =
arrvSysSkillObjLstCache
.Where(x=> x.SkillId == strSkillId 
);
if (arrvSysSkillObjLst_Sel.Count() == 0)
{
   clsvSysSkillEN obj = clsvSysSkillBL.GetObjBySkillId(strSkillId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSkillId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvSysSkillObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeNameBySkillIdCache(string strSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strSkillId) == true) return "";
//获取缓存中的对象列表
clsvSysSkillEN objvSysSkill = GetObjBySkillIdCache(strSkillId, strIdCurrEduCls);
if (objvSysSkill == null) return "";
return objvSysSkill.OperationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySkillIdCache(string strSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strSkillId) == true) return "";
//获取缓存中的对象列表
clsvSysSkillEN objvSysSkill = GetObjBySkillIdCache(strSkillId, strIdCurrEduCls);
if (objvSysSkill == null) return "";
return objvSysSkill.OperationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysSkillEN> GetAllvSysSkillObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvSysSkillEN> arrvSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvSysSkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysSkillEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysSkillEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvSysSkillEN> arrvSysSkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSysSkillObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSysSkillEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strSkillId, string strIdCurrEduCls)
{
if (strInFldName != convSysSkill.SkillId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysSkill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysSkill.AttributeName));
throw new Exception(strMsg);
}
var objvSysSkill = clsvSysSkillBL.GetObjBySkillIdCache(strSkillId, strIdCurrEduCls);
if (objvSysSkill == null) return "";
return objvSysSkill[strOutFldName].ToString();
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
int intRecCount = clsvSysSkillDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysSkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysSkillDA.GetRecCount();
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
int intRecCount = clsvSysSkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysSkillEN objvSysSkillCond)
{
 string strIdCurrEduCls = objvSysSkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSysSkillBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSysSkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysSkill.AttributeName)
{
if (objvSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objvSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSkillCond[strFldName].ToString());
}
else
{
if (objvSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysSkillCond[strFldName]));
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
 List<string> arrList = clsvSysSkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysSkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysSkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}