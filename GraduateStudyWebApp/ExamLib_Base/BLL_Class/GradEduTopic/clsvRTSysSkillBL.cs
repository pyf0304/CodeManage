
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSkillBL
 表名:vRTSysSkill(01120656)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
public static class  clsvRTSysSkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTSysSkillEN GetObj(this K_mId_vRTSysSkill myKey)
{
clsvRTSysSkillEN objvRTSysSkillEN = clsvRTSysSkillBL.vRTSysSkillDA.GetObjBymId(myKey.Value);
return objvRTSysSkillEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetTopicName(this clsvRTSysSkillEN objvRTSysSkillEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTSysSkill.TopicName);
}
objvRTSysSkillEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.TopicName) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.TopicName, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.TopicName] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetSkillName(this clsvRTSysSkillEN objvRTSysSkillEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, convRTSysSkill.SkillName);
}
objvRTSysSkillEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.SkillName) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.SkillName, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.SkillName] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetOperationTypeId(this clsvRTSysSkillEN objvRTSysSkillEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convRTSysSkill.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convRTSysSkill.OperationTypeId);
}
objvRTSysSkillEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.OperationTypeId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.OperationTypeId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.OperationTypeId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetProcess(this clsvRTSysSkillEN objvRTSysSkillEN, string strProcess, string strComparisonOp="")
	{
objvRTSysSkillEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.Process) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.Process, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.Process] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetLevelId(this clsvRTSysSkillEN objvRTSysSkillEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convRTSysSkill.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convRTSysSkill.LevelId);
}
objvRTSysSkillEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.LevelId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.LevelId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.LevelId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetLevelName(this clsvRTSysSkillEN objvRTSysSkillEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convRTSysSkill.LevelName);
}
objvRTSysSkillEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.LevelName) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.LevelName, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.LevelName] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetSkillUpdUser(this clsvRTSysSkillEN objvRTSysSkillEN, string strSkillUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillUpdUser, 20, convRTSysSkill.SkillUpdUser);
}
objvRTSysSkillEN.SkillUpdUser = strSkillUpdUser; //SkillUpdUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.SkillUpdUser) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.SkillUpdUser, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.SkillUpdUser] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetSkillUpdDate(this clsvRTSysSkillEN objvRTSysSkillEN, string strSkillUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillUpdDate, 20, convRTSysSkill.SkillUpdDate);
}
objvRTSysSkillEN.SkillUpdDate = strSkillUpdDate; //SkillUpdDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.SkillUpdDate) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.SkillUpdDate, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.SkillUpdDate] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetOrderNum(this clsvRTSysSkillEN objvRTSysSkillEN, int? intOrderNum, string strComparisonOp="")
	{
objvRTSysSkillEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.OrderNum) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.OrderNum, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.OrderNum] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetIdCurrEduCls(this clsvRTSysSkillEN objvRTSysSkillEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTSysSkill.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTSysSkill.IdCurrEduCls);
}
objvRTSysSkillEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.IdCurrEduCls) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetTopicProposePeople(this clsvRTSysSkillEN objvRTSysSkillEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTSysSkill.TopicProposePeople);
}
objvRTSysSkillEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.TopicProposePeople) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.TopicProposePeople, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.TopicProposePeople] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetTopicContent(this clsvRTSysSkillEN objvRTSysSkillEN, string strTopicContent, string strComparisonOp="")
	{
objvRTSysSkillEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.TopicContent) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.TopicContent, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.TopicContent] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetIsSubmit(this clsvRTSysSkillEN objvRTSysSkillEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTSysSkillEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.IsSubmit) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.IsSubmit, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.IsSubmit] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetAppraiseCount(this clsvRTSysSkillEN objvRTSysSkillEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTSysSkillEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.AppraiseCount) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.AppraiseCount, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.AppraiseCount] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetScore(this clsvRTSysSkillEN objvRTSysSkillEN, float? fltScore, string strComparisonOp="")
	{
objvRTSysSkillEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.Score) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.Score, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.Score] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetStuScore(this clsvRTSysSkillEN objvRTSysSkillEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTSysSkillEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.StuScore) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.StuScore, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.StuScore] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetTeaScore(this clsvRTSysSkillEN objvRTSysSkillEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTSysSkillEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.TeaScore) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.TeaScore, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.TeaScore] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetPdfContent(this clsvRTSysSkillEN objvRTSysSkillEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTSysSkill.PdfContent);
}
objvRTSysSkillEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.PdfContent) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.PdfContent, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.PdfContent] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetPdfPageNum(this clsvRTSysSkillEN objvRTSysSkillEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvRTSysSkillEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.PdfPageNum) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.PdfPageNum, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.PdfPageNum] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetCitationCount(this clsvRTSysSkillEN objvRTSysSkillEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTSysSkillEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.CitationCount) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.CitationCount, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.CitationCount] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetVersionCount(this clsvRTSysSkillEN objvRTSysSkillEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTSysSkillEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.VersionCount) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.VersionCount, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.VersionCount] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetOperationTypeName(this clsvRTSysSkillEN objvRTSysSkillEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convRTSysSkill.OperationTypeName);
}
objvRTSysSkillEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.OperationTypeName) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.OperationTypeName, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.OperationTypeName] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetOkCount(this clsvRTSysSkillEN objvRTSysSkillEN, int? intOkCount, string strComparisonOp="")
	{
objvRTSysSkillEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.OkCount) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.OkCount, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.OkCount] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetCitationId(this clsvRTSysSkillEN objvRTSysSkillEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convRTSysSkill.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convRTSysSkill.CitationId);
}
objvRTSysSkillEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.CitationId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.CitationId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.CitationId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetmId(this clsvRTSysSkillEN objvRTSysSkillEN, long lngmId, string strComparisonOp="")
	{
objvRTSysSkillEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.mId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.mId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.mId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetTopicId(this clsvRTSysSkillEN objvRTSysSkillEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTSysSkill.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTSysSkill.TopicId);
}
objvRTSysSkillEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.TopicId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.TopicId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.TopicId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetSkillId(this clsvRTSysSkillEN objvRTSysSkillEN, string strSkillId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillId, convRTSysSkill.SkillId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, convRTSysSkill.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, convRTSysSkill.SkillId);
}
objvRTSysSkillEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.SkillId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.SkillId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.SkillId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetUpdDate(this clsvRTSysSkillEN objvRTSysSkillEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTSysSkill.UpdDate);
}
objvRTSysSkillEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.UpdDate) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.UpdDate, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.UpdDate] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetMemo(this clsvRTSysSkillEN objvRTSysSkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTSysSkill.Memo);
}
objvRTSysSkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.Memo) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.Memo, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.Memo] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetUpdUser(this clsvRTSysSkillEN objvRTSysSkillEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTSysSkill.UpdUser);
}
objvRTSysSkillEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.UpdUser) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.UpdUser, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.UpdUser] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetCreateDate(this clsvRTSysSkillEN objvRTSysSkillEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTSysSkill.CreateDate);
}
objvRTSysSkillEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.CreateDate) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.CreateDate, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.CreateDate] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetShareId(this clsvRTSysSkillEN objvRTSysSkillEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTSysSkill.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTSysSkill.ShareId);
}
objvRTSysSkillEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.ShareId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.ShareId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.ShareId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillEN SetClassificationId(this clsvRTSysSkillEN objvRTSysSkillEN, string strClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationId, 10, convRTSysSkill.ClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassificationId, 10, convRTSysSkill.ClassificationId);
}
objvRTSysSkillEN.ClassificationId = strClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillEN.dicFldComparisonOp.ContainsKey(convRTSysSkill.ClassificationId) == false)
{
objvRTSysSkillEN.dicFldComparisonOp.Add(convRTSysSkill.ClassificationId, strComparisonOp);
}
else
{
objvRTSysSkillEN.dicFldComparisonOp[convRTSysSkill.ClassificationId] = strComparisonOp;
}
}
return objvRTSysSkillEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTSysSkillENS">源对象</param>
 /// <param name = "objvRTSysSkillENT">目标对象</param>
 public static void CopyTo(this clsvRTSysSkillEN objvRTSysSkillENS, clsvRTSysSkillEN objvRTSysSkillENT)
{
try
{
objvRTSysSkillENT.TopicName = objvRTSysSkillENS.TopicName; //栏目主题
objvRTSysSkillENT.SkillName = objvRTSysSkillENS.SkillName; //技能名称
objvRTSysSkillENT.OperationTypeId = objvRTSysSkillENS.OperationTypeId; //操作类型ID
objvRTSysSkillENT.Process = objvRTSysSkillENS.Process; //实施过程
objvRTSysSkillENT.LevelId = objvRTSysSkillENS.LevelId; //级别Id
objvRTSysSkillENT.LevelName = objvRTSysSkillENS.LevelName; //级别名称
objvRTSysSkillENT.SkillUpdUser = objvRTSysSkillENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillENT.SkillUpdDate = objvRTSysSkillENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillENT.OrderNum = objvRTSysSkillENS.OrderNum; //序号
objvRTSysSkillENT.IdCurrEduCls = objvRTSysSkillENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillENT.TopicProposePeople = objvRTSysSkillENS.TopicProposePeople; //主题提出人
objvRTSysSkillENT.TopicContent = objvRTSysSkillENS.TopicContent; //主题内容
objvRTSysSkillENT.IsSubmit = objvRTSysSkillENS.IsSubmit; //是否提交
objvRTSysSkillENT.AppraiseCount = objvRTSysSkillENS.AppraiseCount; //评论数
objvRTSysSkillENT.Score = objvRTSysSkillENS.Score; //评分
objvRTSysSkillENT.StuScore = objvRTSysSkillENS.StuScore; //学生平均分
objvRTSysSkillENT.TeaScore = objvRTSysSkillENS.TeaScore; //教师评分
objvRTSysSkillENT.PdfContent = objvRTSysSkillENS.PdfContent; //Pdf内容
objvRTSysSkillENT.PdfPageNum = objvRTSysSkillENS.PdfPageNum; //Pdf页码
objvRTSysSkillENT.CitationCount = objvRTSysSkillENS.CitationCount; //引用统计
objvRTSysSkillENT.VersionCount = objvRTSysSkillENS.VersionCount; //版本统计
objvRTSysSkillENT.OperationTypeName = objvRTSysSkillENS.OperationTypeName; //操作类型名
objvRTSysSkillENT.OkCount = objvRTSysSkillENS.OkCount; //点赞统计
objvRTSysSkillENT.CitationId = objvRTSysSkillENS.CitationId; //引用Id
objvRTSysSkillENT.mId = objvRTSysSkillENS.mId; //mId
objvRTSysSkillENT.TopicId = objvRTSysSkillENS.TopicId; //主题Id
objvRTSysSkillENT.SkillId = objvRTSysSkillENS.SkillId; //技能Id
objvRTSysSkillENT.UpdDate = objvRTSysSkillENS.UpdDate; //修改日期
objvRTSysSkillENT.Memo = objvRTSysSkillENS.Memo; //备注
objvRTSysSkillENT.UpdUser = objvRTSysSkillENS.UpdUser; //修改人
objvRTSysSkillENT.CreateDate = objvRTSysSkillENS.CreateDate; //建立日期
objvRTSysSkillENT.ShareId = objvRTSysSkillENS.ShareId; //分享Id
objvRTSysSkillENT.ClassificationId = objvRTSysSkillENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillENS">源对象</param>
 /// <returns>目标对象=>clsvRTSysSkillEN:objvRTSysSkillENT</returns>
 public static clsvRTSysSkillEN CopyTo(this clsvRTSysSkillEN objvRTSysSkillENS)
{
try
{
 clsvRTSysSkillEN objvRTSysSkillENT = new clsvRTSysSkillEN()
{
TopicName = objvRTSysSkillENS.TopicName, //栏目主题
SkillName = objvRTSysSkillENS.SkillName, //技能名称
OperationTypeId = objvRTSysSkillENS.OperationTypeId, //操作类型ID
Process = objvRTSysSkillENS.Process, //实施过程
LevelId = objvRTSysSkillENS.LevelId, //级别Id
LevelName = objvRTSysSkillENS.LevelName, //级别名称
SkillUpdUser = objvRTSysSkillENS.SkillUpdUser, //SkillUpdUser
SkillUpdDate = objvRTSysSkillENS.SkillUpdDate, //SkillUpdDate
OrderNum = objvRTSysSkillENS.OrderNum, //序号
IdCurrEduCls = objvRTSysSkillENS.IdCurrEduCls, //教学班流水号
TopicProposePeople = objvRTSysSkillENS.TopicProposePeople, //主题提出人
TopicContent = objvRTSysSkillENS.TopicContent, //主题内容
IsSubmit = objvRTSysSkillENS.IsSubmit, //是否提交
AppraiseCount = objvRTSysSkillENS.AppraiseCount, //评论数
Score = objvRTSysSkillENS.Score, //评分
StuScore = objvRTSysSkillENS.StuScore, //学生平均分
TeaScore = objvRTSysSkillENS.TeaScore, //教师评分
PdfContent = objvRTSysSkillENS.PdfContent, //Pdf内容
PdfPageNum = objvRTSysSkillENS.PdfPageNum, //Pdf页码
CitationCount = objvRTSysSkillENS.CitationCount, //引用统计
VersionCount = objvRTSysSkillENS.VersionCount, //版本统计
OperationTypeName = objvRTSysSkillENS.OperationTypeName, //操作类型名
OkCount = objvRTSysSkillENS.OkCount, //点赞统计
CitationId = objvRTSysSkillENS.CitationId, //引用Id
mId = objvRTSysSkillENS.mId, //mId
TopicId = objvRTSysSkillENS.TopicId, //主题Id
SkillId = objvRTSysSkillENS.SkillId, //技能Id
UpdDate = objvRTSysSkillENS.UpdDate, //修改日期
Memo = objvRTSysSkillENS.Memo, //备注
UpdUser = objvRTSysSkillENS.UpdUser, //修改人
CreateDate = objvRTSysSkillENS.CreateDate, //建立日期
ShareId = objvRTSysSkillENS.ShareId, //分享Id
ClassificationId = objvRTSysSkillENS.ClassificationId, //分类Id
};
 return objvRTSysSkillENT;
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
public static void CheckProperty4Condition(this clsvRTSysSkillEN objvRTSysSkillEN)
{
 clsvRTSysSkillBL.vRTSysSkillDA.CheckProperty4Condition(objvRTSysSkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTSysSkillEN objvRTSysSkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.TopicName) == true)
{
string strComparisonOpTopicName = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.TopicName, objvRTSysSkillCond.TopicName, strComparisonOpTopicName);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.SkillName) == true)
{
string strComparisonOpSkillName = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.SkillName, objvRTSysSkillCond.SkillName, strComparisonOpSkillName);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.OperationTypeId, objvRTSysSkillCond.OperationTypeId, strComparisonOpOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.LevelId) == true)
{
string strComparisonOpLevelId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.LevelId, objvRTSysSkillCond.LevelId, strComparisonOpLevelId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.LevelName) == true)
{
string strComparisonOpLevelName = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.LevelName, objvRTSysSkillCond.LevelName, strComparisonOpLevelName);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.SkillUpdUser) == true)
{
string strComparisonOpSkillUpdUser = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.SkillUpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.SkillUpdUser, objvRTSysSkillCond.SkillUpdUser, strComparisonOpSkillUpdUser);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.SkillUpdDate) == true)
{
string strComparisonOpSkillUpdDate = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.SkillUpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.SkillUpdDate, objvRTSysSkillCond.SkillUpdDate, strComparisonOpSkillUpdDate);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.OrderNum) == true)
{
string strComparisonOpOrderNum = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.OrderNum, objvRTSysSkillCond.OrderNum, strComparisonOpOrderNum);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.IdCurrEduCls, objvRTSysSkillCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.TopicProposePeople, objvRTSysSkillCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.IsSubmit) == true)
{
if (objvRTSysSkillCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTSysSkill.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTSysSkill.IsSubmit);
}
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.AppraiseCount, objvRTSysSkillCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.Score) == true)
{
string strComparisonOpScore = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.Score, objvRTSysSkillCond.Score, strComparisonOpScore);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.StuScore) == true)
{
string strComparisonOpStuScore = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.StuScore, objvRTSysSkillCond.StuScore, strComparisonOpStuScore);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.TeaScore, objvRTSysSkillCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.PdfContent, objvRTSysSkillCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.PdfPageNum, objvRTSysSkillCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.CitationCount, objvRTSysSkillCond.CitationCount, strComparisonOpCitationCount);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.VersionCount, objvRTSysSkillCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.OperationTypeName, objvRTSysSkillCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.OkCount) == true)
{
string strComparisonOpOkCount = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.OkCount, objvRTSysSkillCond.OkCount, strComparisonOpOkCount);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.CitationId) == true)
{
string strComparisonOpCitationId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.CitationId, objvRTSysSkillCond.CitationId, strComparisonOpCitationId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.mId) == true)
{
string strComparisonOpmId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkill.mId, objvRTSysSkillCond.mId, strComparisonOpmId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.TopicId) == true)
{
string strComparisonOpTopicId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.TopicId, objvRTSysSkillCond.TopicId, strComparisonOpTopicId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.SkillId) == true)
{
string strComparisonOpSkillId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.SkillId, objvRTSysSkillCond.SkillId, strComparisonOpSkillId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.UpdDate, objvRTSysSkillCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.Memo) == true)
{
string strComparisonOpMemo = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.Memo, objvRTSysSkillCond.Memo, strComparisonOpMemo);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.UpdUser, objvRTSysSkillCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.CreateDate, objvRTSysSkillCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.ShareId) == true)
{
string strComparisonOpShareId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.ShareId, objvRTSysSkillCond.ShareId, strComparisonOpShareId);
}
if (objvRTSysSkillCond.IsUpdated(convRTSysSkill.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTSysSkillCond.dicFldComparisonOp[convRTSysSkill.ClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkill.ClassificationId, objvRTSysSkillCond.ClassificationId, strComparisonOpClassificationId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vRTSysSkill(vRTSysSkill), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvRTSysSkillEN objvRTSysSkillEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvRTSysSkillEN == null) return true;
if (objvRTSysSkillEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillEN.mId);
if (clsvRTSysSkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTSysSkillEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillEN.mId);
if (clsvRTSysSkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vRTSysSkill(vRTSysSkill), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvRTSysSkillEN objvRTSysSkillEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvRTSysSkillEN == null) return "";
if (objvRTSysSkillEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTSysSkillEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTSysSkill
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTSysSkill(vRTSysSkill)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTSysSkillBL
{
public static RelatedActions_vRTSysSkill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTSysSkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTSysSkillDA vRTSysSkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTSysSkillDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTSysSkillBL()
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
if (string.IsNullOrEmpty(clsvRTSysSkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSkillEN._ConnectString);
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
public static DataTable GetDataTable_vRTSysSkill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTSysSkillDA.GetDataTable_vRTSysSkill(strWhereCond);
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
objDT = vRTSysSkillDA.GetDataTable(strWhereCond);
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
objDT = vRTSysSkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTSysSkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTSysSkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTSysSkillDA.GetDataTable_Top(objTopPara);
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
objDT = vRTSysSkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTSysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTSysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvRTSysSkillEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTSysSkillEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTSysSkillEN._CurrTabName);
List<clsvRTSysSkillEN> arrvRTSysSkillObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillEN> arrvRTSysSkillObjLst_Sel =
arrvRTSysSkillObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTSysSkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillEN> GetObjLst(string strWhereCond)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
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
public static List<clsvRTSysSkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTSysSkillEN> GetSubObjLstCache(clsvRTSysSkillEN objvRTSysSkillCond)
{
List<clsvRTSysSkillEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSkill.AttributeName)
{
if (objvRTSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillCond[strFldName].ToString());
}
else
{
if (objvRTSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillCond[strFldName]));
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
public static List<clsvRTSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
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
public static List<clsvRTSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
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
List<clsvRTSysSkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTSysSkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
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
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
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
public static List<clsvRTSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTSysSkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
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
public static List<clsvRTSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTSysSkillEN> arrObjLst = new List<clsvRTSysSkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN();
try
{
objvRTSysSkillEN.TopicName = objRow[convRTSysSkill.TopicName] == DBNull.Value ? null : objRow[convRTSysSkill.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillEN.SkillName = objRow[convRTSysSkill.SkillName] == DBNull.Value ? null : objRow[convRTSysSkill.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillEN.OperationTypeId = objRow[convRTSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillEN.Process = objRow[convRTSysSkill.Process] == DBNull.Value ? null : objRow[convRTSysSkill.Process].ToString().Trim(); //实施过程
objvRTSysSkillEN.LevelId = objRow[convRTSysSkill.LevelId] == DBNull.Value ? null : objRow[convRTSysSkill.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillEN.LevelName = objRow[convRTSysSkill.LevelName] == DBNull.Value ? null : objRow[convRTSysSkill.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillEN.SkillUpdUser = objRow[convRTSysSkill.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillEN.SkillUpdDate = objRow[convRTSysSkill.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillEN.OrderNum = objRow[convRTSysSkill.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OrderNum].ToString().Trim()); //序号
objvRTSysSkillEN.IdCurrEduCls = objRow[convRTSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillEN.TopicProposePeople = objRow[convRTSysSkill.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkill.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillEN.TopicContent = objRow[convRTSysSkill.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkill.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkill.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillEN.AppraiseCount = objRow[convRTSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillEN.Score = objRow[convRTSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.Score].ToString().Trim()); //评分
objvRTSysSkillEN.StuScore = objRow[convRTSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillEN.TeaScore = objRow[convRTSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkill.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillEN.PdfContent = objRow[convRTSysSkill.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillEN.PdfPageNum = objRow[convRTSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillEN.CitationCount = objRow[convRTSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillEN.VersionCount = objRow[convRTSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillEN.OperationTypeName = objRow[convRTSysSkill.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkill.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillEN.OkCount = objRow[convRTSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkill.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillEN.CitationId = objRow[convRTSysSkill.CitationId] == DBNull.Value ? null : objRow[convRTSysSkill.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillEN.mId = Int32.Parse(objRow[convRTSysSkill.mId].ToString().Trim()); //mId
objvRTSysSkillEN.TopicId = objRow[convRTSysSkill.TopicId] == DBNull.Value ? null : objRow[convRTSysSkill.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillEN.SkillId = objRow[convRTSysSkill.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillEN.UpdDate = objRow[convRTSysSkill.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkill.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillEN.Memo = objRow[convRTSysSkill.Memo] == DBNull.Value ? null : objRow[convRTSysSkill.Memo].ToString().Trim(); //备注
objvRTSysSkillEN.UpdUser = objRow[convRTSysSkill.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkill.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillEN.CreateDate = objRow[convRTSysSkill.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkill.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillEN.ShareId = objRow[convRTSysSkill.ShareId] == DBNull.Value ? null : objRow[convRTSysSkill.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillEN.ClassificationId = objRow[convRTSysSkill.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkill.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTSysSkill(ref clsvRTSysSkillEN objvRTSysSkillEN)
{
bool bolResult = vRTSysSkillDA.GetvRTSysSkill(ref objvRTSysSkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTSysSkillEN GetObjBymId(long lngmId)
{
clsvRTSysSkillEN objvRTSysSkillEN = vRTSysSkillDA.GetObjBymId(lngmId);
return objvRTSysSkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTSysSkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTSysSkillEN objvRTSysSkillEN = vRTSysSkillDA.GetFirstObj(strWhereCond);
 return objvRTSysSkillEN;
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
public static clsvRTSysSkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTSysSkillEN objvRTSysSkillEN = vRTSysSkillDA.GetObjByDataRow(objRow);
 return objvRTSysSkillEN;
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
public static clsvRTSysSkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTSysSkillEN objvRTSysSkillEN = vRTSysSkillDA.GetObjByDataRow(objRow);
 return objvRTSysSkillEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvRTSysSkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSkillEN GetObjBymIdFromList(long lngmId, List<clsvRTSysSkillEN> lstvRTSysSkillObjLst)
{
foreach (clsvRTSysSkillEN objvRTSysSkillEN in lstvRTSysSkillObjLst)
{
if (objvRTSysSkillEN.mId == lngmId)
{
return objvRTSysSkillEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvRTSysSkillDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vRTSysSkillDA.GetID(strWhereCond);
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
bool bolIsExist = vRTSysSkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vRTSysSkillDA.IsExist(lngmId);
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
 bolIsExist = clsvRTSysSkillDA.IsExistTable();
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
 bolIsExist = vRTSysSkillDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTSysSkillENS">源对象</param>
 /// <param name = "objvRTSysSkillENT">目标对象</param>
 public static void CopyTo(clsvRTSysSkillEN objvRTSysSkillENS, clsvRTSysSkillEN objvRTSysSkillENT)
{
try
{
objvRTSysSkillENT.TopicName = objvRTSysSkillENS.TopicName; //栏目主题
objvRTSysSkillENT.SkillName = objvRTSysSkillENS.SkillName; //技能名称
objvRTSysSkillENT.OperationTypeId = objvRTSysSkillENS.OperationTypeId; //操作类型ID
objvRTSysSkillENT.Process = objvRTSysSkillENS.Process; //实施过程
objvRTSysSkillENT.LevelId = objvRTSysSkillENS.LevelId; //级别Id
objvRTSysSkillENT.LevelName = objvRTSysSkillENS.LevelName; //级别名称
objvRTSysSkillENT.SkillUpdUser = objvRTSysSkillENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillENT.SkillUpdDate = objvRTSysSkillENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillENT.OrderNum = objvRTSysSkillENS.OrderNum; //序号
objvRTSysSkillENT.IdCurrEduCls = objvRTSysSkillENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillENT.TopicProposePeople = objvRTSysSkillENS.TopicProposePeople; //主题提出人
objvRTSysSkillENT.TopicContent = objvRTSysSkillENS.TopicContent; //主题内容
objvRTSysSkillENT.IsSubmit = objvRTSysSkillENS.IsSubmit; //是否提交
objvRTSysSkillENT.AppraiseCount = objvRTSysSkillENS.AppraiseCount; //评论数
objvRTSysSkillENT.Score = objvRTSysSkillENS.Score; //评分
objvRTSysSkillENT.StuScore = objvRTSysSkillENS.StuScore; //学生平均分
objvRTSysSkillENT.TeaScore = objvRTSysSkillENS.TeaScore; //教师评分
objvRTSysSkillENT.PdfContent = objvRTSysSkillENS.PdfContent; //Pdf内容
objvRTSysSkillENT.PdfPageNum = objvRTSysSkillENS.PdfPageNum; //Pdf页码
objvRTSysSkillENT.CitationCount = objvRTSysSkillENS.CitationCount; //引用统计
objvRTSysSkillENT.VersionCount = objvRTSysSkillENS.VersionCount; //版本统计
objvRTSysSkillENT.OperationTypeName = objvRTSysSkillENS.OperationTypeName; //操作类型名
objvRTSysSkillENT.OkCount = objvRTSysSkillENS.OkCount; //点赞统计
objvRTSysSkillENT.CitationId = objvRTSysSkillENS.CitationId; //引用Id
objvRTSysSkillENT.mId = objvRTSysSkillENS.mId; //mId
objvRTSysSkillENT.TopicId = objvRTSysSkillENS.TopicId; //主题Id
objvRTSysSkillENT.SkillId = objvRTSysSkillENS.SkillId; //技能Id
objvRTSysSkillENT.UpdDate = objvRTSysSkillENS.UpdDate; //修改日期
objvRTSysSkillENT.Memo = objvRTSysSkillENS.Memo; //备注
objvRTSysSkillENT.UpdUser = objvRTSysSkillENS.UpdUser; //修改人
objvRTSysSkillENT.CreateDate = objvRTSysSkillENS.CreateDate; //建立日期
objvRTSysSkillENT.ShareId = objvRTSysSkillENS.ShareId; //分享Id
objvRTSysSkillENT.ClassificationId = objvRTSysSkillENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTSysSkillEN objvRTSysSkillEN)
{
try
{
objvRTSysSkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTSysSkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTSysSkill.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.TopicName = objvRTSysSkillEN.TopicName == "[null]" ? null :  objvRTSysSkillEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTSysSkill.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.SkillName = objvRTSysSkillEN.SkillName == "[null]" ? null :  objvRTSysSkillEN.SkillName; //技能名称
}
if (arrFldSet.Contains(convRTSysSkill.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.OperationTypeId = objvRTSysSkillEN.OperationTypeId == "[null]" ? null :  objvRTSysSkillEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convRTSysSkill.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.Process = objvRTSysSkillEN.Process == "[null]" ? null :  objvRTSysSkillEN.Process; //实施过程
}
if (arrFldSet.Contains(convRTSysSkill.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.LevelId = objvRTSysSkillEN.LevelId == "[null]" ? null :  objvRTSysSkillEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convRTSysSkill.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.LevelName = objvRTSysSkillEN.LevelName == "[null]" ? null :  objvRTSysSkillEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convRTSysSkill.SkillUpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.SkillUpdUser = objvRTSysSkillEN.SkillUpdUser == "[null]" ? null :  objvRTSysSkillEN.SkillUpdUser; //SkillUpdUser
}
if (arrFldSet.Contains(convRTSysSkill.SkillUpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.SkillUpdDate = objvRTSysSkillEN.SkillUpdDate == "[null]" ? null :  objvRTSysSkillEN.SkillUpdDate; //SkillUpdDate
}
if (arrFldSet.Contains(convRTSysSkill.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.OrderNum = objvRTSysSkillEN.OrderNum; //序号
}
if (arrFldSet.Contains(convRTSysSkill.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.IdCurrEduCls = objvRTSysSkillEN.IdCurrEduCls == "[null]" ? null :  objvRTSysSkillEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTSysSkill.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.TopicProposePeople = objvRTSysSkillEN.TopicProposePeople == "[null]" ? null :  objvRTSysSkillEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTSysSkill.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.TopicContent = objvRTSysSkillEN.TopicContent == "[null]" ? null :  objvRTSysSkillEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTSysSkill.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.IsSubmit = objvRTSysSkillEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTSysSkill.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.AppraiseCount = objvRTSysSkillEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTSysSkill.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.Score = objvRTSysSkillEN.Score; //评分
}
if (arrFldSet.Contains(convRTSysSkill.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.StuScore = objvRTSysSkillEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTSysSkill.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.TeaScore = objvRTSysSkillEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTSysSkill.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.PdfContent = objvRTSysSkillEN.PdfContent == "[null]" ? null :  objvRTSysSkillEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTSysSkill.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.PdfPageNum = objvRTSysSkillEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convRTSysSkill.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.CitationCount = objvRTSysSkillEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTSysSkill.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.VersionCount = objvRTSysSkillEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTSysSkill.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.OperationTypeName = objvRTSysSkillEN.OperationTypeName == "[null]" ? null :  objvRTSysSkillEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convRTSysSkill.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.OkCount = objvRTSysSkillEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTSysSkill.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.CitationId = objvRTSysSkillEN.CitationId == "[null]" ? null :  objvRTSysSkillEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convRTSysSkill.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.mId = objvRTSysSkillEN.mId; //mId
}
if (arrFldSet.Contains(convRTSysSkill.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.TopicId = objvRTSysSkillEN.TopicId == "[null]" ? null :  objvRTSysSkillEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTSysSkill.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.SkillId = objvRTSysSkillEN.SkillId; //技能Id
}
if (arrFldSet.Contains(convRTSysSkill.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.UpdDate = objvRTSysSkillEN.UpdDate == "[null]" ? null :  objvRTSysSkillEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTSysSkill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.Memo = objvRTSysSkillEN.Memo == "[null]" ? null :  objvRTSysSkillEN.Memo; //备注
}
if (arrFldSet.Contains(convRTSysSkill.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.UpdUser = objvRTSysSkillEN.UpdUser == "[null]" ? null :  objvRTSysSkillEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTSysSkill.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.CreateDate = objvRTSysSkillEN.CreateDate == "[null]" ? null :  objvRTSysSkillEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTSysSkill.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.ShareId = objvRTSysSkillEN.ShareId == "[null]" ? null :  objvRTSysSkillEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTSysSkill.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillEN.ClassificationId = objvRTSysSkillEN.ClassificationId == "[null]" ? null :  objvRTSysSkillEN.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTSysSkillEN objvRTSysSkillEN)
{
try
{
if (objvRTSysSkillEN.TopicName == "[null]") objvRTSysSkillEN.TopicName = null; //栏目主题
if (objvRTSysSkillEN.SkillName == "[null]") objvRTSysSkillEN.SkillName = null; //技能名称
if (objvRTSysSkillEN.OperationTypeId == "[null]") objvRTSysSkillEN.OperationTypeId = null; //操作类型ID
if (objvRTSysSkillEN.Process == "[null]") objvRTSysSkillEN.Process = null; //实施过程
if (objvRTSysSkillEN.LevelId == "[null]") objvRTSysSkillEN.LevelId = null; //级别Id
if (objvRTSysSkillEN.LevelName == "[null]") objvRTSysSkillEN.LevelName = null; //级别名称
if (objvRTSysSkillEN.SkillUpdUser == "[null]") objvRTSysSkillEN.SkillUpdUser = null; //SkillUpdUser
if (objvRTSysSkillEN.SkillUpdDate == "[null]") objvRTSysSkillEN.SkillUpdDate = null; //SkillUpdDate
if (objvRTSysSkillEN.IdCurrEduCls == "[null]") objvRTSysSkillEN.IdCurrEduCls = null; //教学班流水号
if (objvRTSysSkillEN.TopicProposePeople == "[null]") objvRTSysSkillEN.TopicProposePeople = null; //主题提出人
if (objvRTSysSkillEN.TopicContent == "[null]") objvRTSysSkillEN.TopicContent = null; //主题内容
if (objvRTSysSkillEN.PdfContent == "[null]") objvRTSysSkillEN.PdfContent = null; //Pdf内容
if (objvRTSysSkillEN.OperationTypeName == "[null]") objvRTSysSkillEN.OperationTypeName = null; //操作类型名
if (objvRTSysSkillEN.CitationId == "[null]") objvRTSysSkillEN.CitationId = null; //引用Id
if (objvRTSysSkillEN.TopicId == "[null]") objvRTSysSkillEN.TopicId = null; //主题Id
if (objvRTSysSkillEN.UpdDate == "[null]") objvRTSysSkillEN.UpdDate = null; //修改日期
if (objvRTSysSkillEN.Memo == "[null]") objvRTSysSkillEN.Memo = null; //备注
if (objvRTSysSkillEN.UpdUser == "[null]") objvRTSysSkillEN.UpdUser = null; //修改人
if (objvRTSysSkillEN.CreateDate == "[null]") objvRTSysSkillEN.CreateDate = null; //建立日期
if (objvRTSysSkillEN.ShareId == "[null]") objvRTSysSkillEN.ShareId = null; //分享Id
if (objvRTSysSkillEN.ClassificationId == "[null]") objvRTSysSkillEN.ClassificationId = null; //分类Id
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
public static void CheckProperty4Condition(clsvRTSysSkillEN objvRTSysSkillEN)
{
 vRTSysSkillDA.CheckProperty4Condition(objvRTSysSkillEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convRTSysSkill.mId); 
List<clsvRTSysSkillEN> arrObjLst = clsvRTSysSkillBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvRTSysSkillEN objvRTSysSkillEN = new clsvRTSysSkillEN()
{
mId = 0,
OperationTypeId = "选[vRTSysSkill]..."
};
arrObjLst.Insert(0, objvRTSysSkillEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convRTSysSkill.mId;
objComboBox.DisplayMember = convRTSysSkill.OperationTypeId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vRTSysSkill]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convRTSysSkill.mId); 
IEnumerable<clsvRTSysSkillEN> arrObjLst = clsvRTSysSkillBL.GetObjLst(strCondition);
objDDL.DataValueField = convRTSysSkill.mId;
objDDL.DataTextField = convRTSysSkill.OperationTypeId;
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
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vRTSysSkill]...","0");
List<clsvRTSysSkillEN> arrvRTSysSkillObjLst = GetAllvRTSysSkillObjLstCache(); 
arrvRTSysSkillObjLst = arrvRTSysSkillObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = convRTSysSkill.mId;
objDDL.DataTextField = convRTSysSkill.OperationTypeId;
objDDL.DataSource = arrvRTSysSkillObjLst;
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTSysSkillRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTSysSkillRelaBL没有刷新缓存机制(clsRTSysSkillRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTSysSkillObjLstCache == null)
//{
//arrvRTSysSkillObjLstCache = vRTSysSkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSkillEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTSysSkillEN._CurrTabName);
List<clsvRTSysSkillEN> arrvRTSysSkillObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillEN> arrvRTSysSkillObjLst_Sel =
arrvRTSysSkillObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTSysSkillObjLst_Sel.Count() == 0)
{
   clsvRTSysSkillEN obj = clsvRTSysSkillBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTSysSkillObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetLevelIdBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvRTSysSkillEN objvRTSysSkill = GetObjBymIdCache(lngmId);
if (objvRTSysSkill == null) return "";
return objvRTSysSkill.LevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvRTSysSkillEN objvRTSysSkill = GetObjBymIdCache(lngmId);
if (objvRTSysSkill == null) return "";
return objvRTSysSkill.LevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSkillEN> GetAllvRTSysSkillObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTSysSkillEN> arrvRTSysSkillObjLstCache = GetObjLstCache(); 
return arrvRTSysSkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSkillEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTSysSkillEN._CurrTabName);
List<clsvRTSysSkillEN> arrvRTSysSkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTSysSkillObjLstCache;
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
string strKey = string.Format("{0}", clsvRTSysSkillEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvRTSysSkillEN objvRTSysSkillEN)
{
//检测记录是否存在
string strResult = vRTSysSkillDA.GetUniCondStr(objvRTSysSkillEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convRTSysSkill.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTSysSkill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTSysSkill.AttributeName));
throw new Exception(strMsg);
}
var objvRTSysSkill = clsvRTSysSkillBL.GetObjBymIdCache(lngmId);
if (objvRTSysSkill == null) return "";
return objvRTSysSkill[strOutFldName].ToString();
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
int intRecCount = clsvRTSysSkillDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTSysSkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTSysSkillDA.GetRecCount();
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
int intRecCount = clsvRTSysSkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTSysSkillEN objvRTSysSkillCond)
{
List<clsvRTSysSkillEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSkill.AttributeName)
{
if (objvRTSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillCond[strFldName].ToString());
}
else
{
if (objvRTSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillCond[strFldName]));
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
 List<string> arrList = clsvRTSysSkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}