
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSkillRelaBL
 表名:vRTSysSkillRela(01120656)
 * 版本:2023.11.03.1(服务器:WIN-SRV103-116)
 日期:2023/11/07 15:53:45
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
public static class  clsvRTSysSkillRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTSysSkillRelaEN GetObj(this K_mId_vRTSysSkillRela myKey)
{
clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = clsvRTSysSkillRelaBL.vRTSysSkillRelaDA.GetObjBymId(myKey.Value);
return objvRTSysSkillRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetTopicName(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTSysSkillRela.TopicName);
}
objvRTSysSkillRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.TopicName) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.TopicName, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.TopicName] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetSkillName(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, convRTSysSkillRela.SkillName);
}
objvRTSysSkillRelaEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.SkillName) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.SkillName, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.SkillName] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetOperationTypeId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convRTSysSkillRela.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convRTSysSkillRela.OperationTypeId);
}
objvRTSysSkillRelaEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.OperationTypeId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.OperationTypeId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.OperationTypeId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetProcess(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strProcess, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.Process) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.Process, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.Process] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetLevelId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convRTSysSkillRela.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convRTSysSkillRela.LevelId);
}
objvRTSysSkillRelaEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.LevelId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.LevelId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.LevelId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetLevelName(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convRTSysSkillRela.LevelName);
}
objvRTSysSkillRelaEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.LevelName) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.LevelName, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.LevelName] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetSkillUpdUser(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strSkillUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillUpdUser, 20, convRTSysSkillRela.SkillUpdUser);
}
objvRTSysSkillRelaEN.SkillUpdUser = strSkillUpdUser; //SkillUpdUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.SkillUpdUser) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.SkillUpdUser, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.SkillUpdUser] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetSkillUpdDate(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strSkillUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillUpdDate, 20, convRTSysSkillRela.SkillUpdDate);
}
objvRTSysSkillRelaEN.SkillUpdDate = strSkillUpdDate; //SkillUpdDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.SkillUpdDate) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.SkillUpdDate, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.SkillUpdDate] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetOrderNum(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.OrderNum) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.OrderNum, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.OrderNum] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetIdCurrEduCls(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTSysSkillRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTSysSkillRela.IdCurrEduCls);
}
objvRTSysSkillRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.IdCurrEduCls) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetTopicProposePeople(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTSysSkillRela.TopicProposePeople);
}
objvRTSysSkillRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.TopicProposePeople) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetTopicContent(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.TopicContent) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.TopicContent, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.TopicContent] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetIsSubmit(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.IsSubmit) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.IsSubmit, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.IsSubmit] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetAppraiseCount(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.AppraiseCount) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetScore(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.Score) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.Score, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.Score] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetStuScore(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.StuScore) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.StuScore, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.StuScore] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetTeaScore(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.TeaScore) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.TeaScore, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.TeaScore] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetPdfContent(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTSysSkillRela.PdfContent);
}
objvRTSysSkillRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.PdfContent) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.PdfContent, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.PdfContent] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetPdfPageNum(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.PdfPageNum) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.PdfPageNum, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.PdfPageNum] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetCitationCount(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.CitationCount) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.CitationCount, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.CitationCount] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetVersionCount(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.VersionCount) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.VersionCount, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.VersionCount] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetOperationTypeName(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convRTSysSkillRela.OperationTypeName);
}
objvRTSysSkillRelaEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.OperationTypeName) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.OperationTypeName, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.OperationTypeName] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetOkCount(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.OkCount) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.OkCount, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.OkCount] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetCitationId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convRTSysSkillRela.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convRTSysSkillRela.CitationId);
}
objvRTSysSkillRelaEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.CitationId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.CitationId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.CitationId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetmId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTSysSkillRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.mId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.mId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.mId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetTopicId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTSysSkillRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTSysSkillRela.TopicId);
}
objvRTSysSkillRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.TopicId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.TopicId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.TopicId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetSkillId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strSkillId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillId, convRTSysSkillRela.SkillId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, convRTSysSkillRela.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, convRTSysSkillRela.SkillId);
}
objvRTSysSkillRelaEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.SkillId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.SkillId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.SkillId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetUpdDate(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTSysSkillRela.UpdDate);
}
objvRTSysSkillRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.UpdDate) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.UpdDate, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.UpdDate] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetMemo(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTSysSkillRela.Memo);
}
objvRTSysSkillRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.Memo) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.Memo, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.Memo] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetUpdUser(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTSysSkillRela.UpdUser);
}
objvRTSysSkillRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.UpdUser) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.UpdUser, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.UpdUser] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetCreateDate(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTSysSkillRela.CreateDate);
}
objvRTSysSkillRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.CreateDate) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.CreateDate, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.CreateDate] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetShareId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTSysSkillRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTSysSkillRela.ShareId);
}
objvRTSysSkillRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.ShareId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.ShareId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.ShareId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSkillRelaEN SetClassificationId(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN, string strClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationId, 10, convRTSysSkillRela.ClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassificationId, 10, convRTSysSkillRela.ClassificationId);
}
objvRTSysSkillRelaEN.ClassificationId = strClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSkillRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSkillRela.ClassificationId) == false)
{
objvRTSysSkillRelaEN.dicFldComparisonOp.Add(convRTSysSkillRela.ClassificationId, strComparisonOp);
}
else
{
objvRTSysSkillRelaEN.dicFldComparisonOp[convRTSysSkillRela.ClassificationId] = strComparisonOp;
}
}
return objvRTSysSkillRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaENS">源对象</param>
 /// <param name = "objvRTSysSkillRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTSysSkillRelaEN objvRTSysSkillRelaENS, clsvRTSysSkillRelaEN objvRTSysSkillRelaENT)
{
try
{
objvRTSysSkillRelaENT.TopicName = objvRTSysSkillRelaENS.TopicName; //栏目主题
objvRTSysSkillRelaENT.SkillName = objvRTSysSkillRelaENS.SkillName; //技能名称
objvRTSysSkillRelaENT.OperationTypeId = objvRTSysSkillRelaENS.OperationTypeId; //操作类型ID
objvRTSysSkillRelaENT.Process = objvRTSysSkillRelaENS.Process; //实施过程
objvRTSysSkillRelaENT.LevelId = objvRTSysSkillRelaENS.LevelId; //级别Id
objvRTSysSkillRelaENT.LevelName = objvRTSysSkillRelaENS.LevelName; //级别名称
objvRTSysSkillRelaENT.SkillUpdUser = objvRTSysSkillRelaENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillRelaENT.SkillUpdDate = objvRTSysSkillRelaENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillRelaENT.OrderNum = objvRTSysSkillRelaENS.OrderNum; //序号
objvRTSysSkillRelaENT.IdCurrEduCls = objvRTSysSkillRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillRelaENT.TopicProposePeople = objvRTSysSkillRelaENS.TopicProposePeople; //主题提出人
objvRTSysSkillRelaENT.TopicContent = objvRTSysSkillRelaENS.TopicContent; //主题内容
objvRTSysSkillRelaENT.IsSubmit = objvRTSysSkillRelaENS.IsSubmit; //是否提交
objvRTSysSkillRelaENT.AppraiseCount = objvRTSysSkillRelaENS.AppraiseCount; //评论数
objvRTSysSkillRelaENT.Score = objvRTSysSkillRelaENS.Score; //评分
objvRTSysSkillRelaENT.StuScore = objvRTSysSkillRelaENS.StuScore; //学生平均分
objvRTSysSkillRelaENT.TeaScore = objvRTSysSkillRelaENS.TeaScore; //教师评分
objvRTSysSkillRelaENT.PdfContent = objvRTSysSkillRelaENS.PdfContent; //Pdf内容
objvRTSysSkillRelaENT.PdfPageNum = objvRTSysSkillRelaENS.PdfPageNum; //Pdf页码
objvRTSysSkillRelaENT.CitationCount = objvRTSysSkillRelaENS.CitationCount; //引用统计
objvRTSysSkillRelaENT.VersionCount = objvRTSysSkillRelaENS.VersionCount; //版本统计
objvRTSysSkillRelaENT.OperationTypeName = objvRTSysSkillRelaENS.OperationTypeName; //操作类型名
objvRTSysSkillRelaENT.OkCount = objvRTSysSkillRelaENS.OkCount; //点赞统计
objvRTSysSkillRelaENT.CitationId = objvRTSysSkillRelaENS.CitationId; //引用Id
objvRTSysSkillRelaENT.mId = objvRTSysSkillRelaENS.mId; //mId
objvRTSysSkillRelaENT.TopicId = objvRTSysSkillRelaENS.TopicId; //主题Id
objvRTSysSkillRelaENT.SkillId = objvRTSysSkillRelaENS.SkillId; //技能Id
objvRTSysSkillRelaENT.UpdDate = objvRTSysSkillRelaENS.UpdDate; //修改日期
objvRTSysSkillRelaENT.Memo = objvRTSysSkillRelaENS.Memo; //备注
objvRTSysSkillRelaENT.UpdUser = objvRTSysSkillRelaENS.UpdUser; //修改人
objvRTSysSkillRelaENT.CreateDate = objvRTSysSkillRelaENS.CreateDate; //建立日期
objvRTSysSkillRelaENT.ShareId = objvRTSysSkillRelaENS.ShareId; //分享Id
objvRTSysSkillRelaENT.ClassificationId = objvRTSysSkillRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTSysSkillRelaEN:objvRTSysSkillRelaENT</returns>
 public static clsvRTSysSkillRelaEN CopyTo(this clsvRTSysSkillRelaEN objvRTSysSkillRelaENS)
{
try
{
 clsvRTSysSkillRelaEN objvRTSysSkillRelaENT = new clsvRTSysSkillRelaEN()
{
TopicName = objvRTSysSkillRelaENS.TopicName, //栏目主题
SkillName = objvRTSysSkillRelaENS.SkillName, //技能名称
OperationTypeId = objvRTSysSkillRelaENS.OperationTypeId, //操作类型ID
Process = objvRTSysSkillRelaENS.Process, //实施过程
LevelId = objvRTSysSkillRelaENS.LevelId, //级别Id
LevelName = objvRTSysSkillRelaENS.LevelName, //级别名称
SkillUpdUser = objvRTSysSkillRelaENS.SkillUpdUser, //SkillUpdUser
SkillUpdDate = objvRTSysSkillRelaENS.SkillUpdDate, //SkillUpdDate
OrderNum = objvRTSysSkillRelaENS.OrderNum, //序号
IdCurrEduCls = objvRTSysSkillRelaENS.IdCurrEduCls, //教学班流水号
TopicProposePeople = objvRTSysSkillRelaENS.TopicProposePeople, //主题提出人
TopicContent = objvRTSysSkillRelaENS.TopicContent, //主题内容
IsSubmit = objvRTSysSkillRelaENS.IsSubmit, //是否提交
AppraiseCount = objvRTSysSkillRelaENS.AppraiseCount, //评论数
Score = objvRTSysSkillRelaENS.Score, //评分
StuScore = objvRTSysSkillRelaENS.StuScore, //学生平均分
TeaScore = objvRTSysSkillRelaENS.TeaScore, //教师评分
PdfContent = objvRTSysSkillRelaENS.PdfContent, //Pdf内容
PdfPageNum = objvRTSysSkillRelaENS.PdfPageNum, //Pdf页码
CitationCount = objvRTSysSkillRelaENS.CitationCount, //引用统计
VersionCount = objvRTSysSkillRelaENS.VersionCount, //版本统计
OperationTypeName = objvRTSysSkillRelaENS.OperationTypeName, //操作类型名
OkCount = objvRTSysSkillRelaENS.OkCount, //点赞统计
CitationId = objvRTSysSkillRelaENS.CitationId, //引用Id
mId = objvRTSysSkillRelaENS.mId, //mId
TopicId = objvRTSysSkillRelaENS.TopicId, //主题Id
SkillId = objvRTSysSkillRelaENS.SkillId, //技能Id
UpdDate = objvRTSysSkillRelaENS.UpdDate, //修改日期
Memo = objvRTSysSkillRelaENS.Memo, //备注
UpdUser = objvRTSysSkillRelaENS.UpdUser, //修改人
CreateDate = objvRTSysSkillRelaENS.CreateDate, //建立日期
ShareId = objvRTSysSkillRelaENS.ShareId, //分享Id
ClassificationId = objvRTSysSkillRelaENS.ClassificationId, //分类Id
};
 return objvRTSysSkillRelaENT;
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
public static void CheckProperty4Condition(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
 clsvRTSysSkillRelaBL.vRTSysSkillRelaDA.CheckProperty4Condition(objvRTSysSkillRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTSysSkillRelaEN objvRTSysSkillRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.TopicName, objvRTSysSkillRelaCond.TopicName, strComparisonOpTopicName);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.SkillName) == true)
{
string strComparisonOpSkillName = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.SkillName, objvRTSysSkillRelaCond.SkillName, strComparisonOpSkillName);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.OperationTypeId, objvRTSysSkillRelaCond.OperationTypeId, strComparisonOpOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.LevelId) == true)
{
string strComparisonOpLevelId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.LevelId, objvRTSysSkillRelaCond.LevelId, strComparisonOpLevelId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.LevelName) == true)
{
string strComparisonOpLevelName = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.LevelName, objvRTSysSkillRelaCond.LevelName, strComparisonOpLevelName);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.SkillUpdUser) == true)
{
string strComparisonOpSkillUpdUser = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.SkillUpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.SkillUpdUser, objvRTSysSkillRelaCond.SkillUpdUser, strComparisonOpSkillUpdUser);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.SkillUpdDate) == true)
{
string strComparisonOpSkillUpdDate = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.SkillUpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.SkillUpdDate, objvRTSysSkillRelaCond.SkillUpdDate, strComparisonOpSkillUpdDate);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.OrderNum, objvRTSysSkillRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.IdCurrEduCls, objvRTSysSkillRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.TopicProposePeople, objvRTSysSkillRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.IsSubmit) == true)
{
if (objvRTSysSkillRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTSysSkillRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTSysSkillRela.IsSubmit);
}
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.AppraiseCount, objvRTSysSkillRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.Score) == true)
{
string strComparisonOpScore = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.Score, objvRTSysSkillRelaCond.Score, strComparisonOpScore);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.StuScore, objvRTSysSkillRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.TeaScore, objvRTSysSkillRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.PdfContent, objvRTSysSkillRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.PdfPageNum, objvRTSysSkillRelaCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.CitationCount, objvRTSysSkillRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.VersionCount, objvRTSysSkillRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.OperationTypeName, objvRTSysSkillRelaCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.OkCount, objvRTSysSkillRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.CitationId) == true)
{
string strComparisonOpCitationId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.CitationId, objvRTSysSkillRelaCond.CitationId, strComparisonOpCitationId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.mId) == true)
{
string strComparisonOpmId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSkillRela.mId, objvRTSysSkillRelaCond.mId, strComparisonOpmId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.TopicId, objvRTSysSkillRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.SkillId) == true)
{
string strComparisonOpSkillId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.SkillId, objvRTSysSkillRelaCond.SkillId, strComparisonOpSkillId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.UpdDate, objvRTSysSkillRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.Memo) == true)
{
string strComparisonOpMemo = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.Memo, objvRTSysSkillRelaCond.Memo, strComparisonOpMemo);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.UpdUser, objvRTSysSkillRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.CreateDate, objvRTSysSkillRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.ShareId) == true)
{
string strComparisonOpShareId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.ShareId, objvRTSysSkillRelaCond.ShareId, strComparisonOpShareId);
}
if (objvRTSysSkillRelaCond.IsUpdated(convRTSysSkillRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTSysSkillRelaCond.dicFldComparisonOp[convRTSysSkillRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSkillRela.ClassificationId, objvRTSysSkillRelaCond.ClassificationId, strComparisonOpClassificationId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vRTSysSkillRela(vRTSysSkillRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvRTSysSkillRelaEN == null) return true;
if (objvRTSysSkillRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillRelaEN.mId);
if (clsvRTSysSkillRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTSysSkillRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillRelaEN.mId);
if (clsvRTSysSkillRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vRTSysSkillRela(vRTSysSkillRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvRTSysSkillRelaEN == null) return "";
if (objvRTSysSkillRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillRelaEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTSysSkillRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTSysSkillRelaEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTSysSkillRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTSysSkillRela(vRTSysSkillRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTSysSkillRelaBL
{
public static RelatedActions_vRTSysSkillRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTSysSkillRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTSysSkillRelaDA vRTSysSkillRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTSysSkillRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTSysSkillRelaBL()
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
if (string.IsNullOrEmpty(clsvRTSysSkillRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSkillRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTSysSkillRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTSysSkillRelaDA.GetDataTable_vRTSysSkillRela(strWhereCond);
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
objDT = vRTSysSkillRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTSysSkillRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTSysSkillRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTSysSkillRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTSysSkillRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTSysSkillRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTSysSkillRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTSysSkillRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvRTSysSkillRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
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
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTSysSkillRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTSysSkillRelaEN._CurrTabName);
List<clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLst_Sel =
arrvRTSysSkillRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTSysSkillRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
public static List<clsvRTSysSkillRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTSysSkillRelaEN> GetSubObjLstCache(clsvRTSysSkillRelaEN objvRTSysSkillRelaCond)
{
List<clsvRTSysSkillRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSkillRela.AttributeName)
{
if (objvRTSysSkillRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSkillRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillRelaCond[strFldName].ToString());
}
else
{
if (objvRTSysSkillRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSkillRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSkillRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillRelaCond[strFldName]));
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
public static List<clsvRTSysSkillRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
public static List<clsvRTSysSkillRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
List<clsvRTSysSkillRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTSysSkillRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTSysSkillRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
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
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
public static List<clsvRTSysSkillRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTSysSkillRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
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
public static List<clsvRTSysSkillRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTSysSkillRelaEN> arrObjLst = new List<clsvRTSysSkillRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN();
try
{
objvRTSysSkillRelaEN.TopicName = objRow[convRTSysSkillRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSkillRelaEN.SkillName = objRow[convRTSysSkillRela.SkillName] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillName].ToString().Trim(); //技能名称
objvRTSysSkillRelaEN.OperationTypeId = objRow[convRTSysSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTSysSkillRelaEN.Process = objRow[convRTSysSkillRela.Process] == DBNull.Value ? null : objRow[convRTSysSkillRela.Process].ToString().Trim(); //实施过程
objvRTSysSkillRelaEN.LevelId = objRow[convRTSysSkillRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSkillRelaEN.LevelName = objRow[convRTSysSkillRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSkillRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSkillRelaEN.SkillUpdUser = objRow[convRTSysSkillRela.SkillUpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdUser].ToString().Trim(); //SkillUpdUser
objvRTSysSkillRelaEN.SkillUpdDate = objRow[convRTSysSkillRela.SkillUpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.SkillUpdDate].ToString().Trim(); //SkillUpdDate
objvRTSysSkillRelaEN.OrderNum = objRow[convRTSysSkillRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OrderNum].ToString().Trim()); //序号
objvRTSysSkillRelaEN.IdCurrEduCls = objRow[convRTSysSkillRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSkillRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSkillRelaEN.TopicProposePeople = objRow[convRTSysSkillRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSkillRelaEN.TopicContent = objRow[convRTSysSkillRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSkillRelaEN.AppraiseCount = objRow[convRTSysSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSkillRelaEN.Score = objRow[convRTSysSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.Score].ToString().Trim()); //评分
objvRTSysSkillRelaEN.StuScore = objRow[convRTSysSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSkillRelaEN.TeaScore = objRow[convRTSysSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSkillRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSkillRelaEN.PdfContent = objRow[convRTSysSkillRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSkillRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSkillRelaEN.PdfPageNum = objRow[convRTSysSkillRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTSysSkillRelaEN.CitationCount = objRow[convRTSysSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.CitationCount].ToString().Trim()); //引用统计
objvRTSysSkillRelaEN.VersionCount = objRow[convRTSysSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.VersionCount].ToString().Trim()); //版本统计
objvRTSysSkillRelaEN.OperationTypeName = objRow[convRTSysSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convRTSysSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvRTSysSkillRelaEN.OkCount = objRow[convRTSysSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSkillRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSkillRelaEN.CitationId = objRow[convRTSysSkillRela.CitationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.CitationId].ToString().Trim(); //引用Id
objvRTSysSkillRelaEN.mId = Int32.Parse(objRow[convRTSysSkillRela.mId].ToString().Trim()); //mId
objvRTSysSkillRelaEN.TopicId = objRow[convRTSysSkillRela.TopicId] == DBNull.Value ? null : objRow[convRTSysSkillRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSkillRelaEN.SkillId = objRow[convRTSysSkillRela.SkillId].ToString().Trim(); //技能Id
objvRTSysSkillRelaEN.UpdDate = objRow[convRTSysSkillRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSkillRelaEN.Memo = objRow[convRTSysSkillRela.Memo] == DBNull.Value ? null : objRow[convRTSysSkillRela.Memo].ToString().Trim(); //备注
objvRTSysSkillRelaEN.UpdUser = objRow[convRTSysSkillRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSkillRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSkillRelaEN.CreateDate = objRow[convRTSysSkillRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSkillRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSkillRelaEN.ShareId = objRow[convRTSysSkillRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSkillRelaEN.ClassificationId = objRow[convRTSysSkillRela.ClassificationId] == DBNull.Value ? null : objRow[convRTSysSkillRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSkillRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTSysSkillRela(ref clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
bool bolResult = vRTSysSkillRelaDA.GetvRTSysSkillRela(ref objvRTSysSkillRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTSysSkillRelaEN GetObjBymId(long lngmId)
{
clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = vRTSysSkillRelaDA.GetObjBymId(lngmId);
return objvRTSysSkillRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTSysSkillRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = vRTSysSkillRelaDA.GetFirstObj(strWhereCond);
 return objvRTSysSkillRelaEN;
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
public static clsvRTSysSkillRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = vRTSysSkillRelaDA.GetObjByDataRow(objRow);
 return objvRTSysSkillRelaEN;
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
public static clsvRTSysSkillRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = vRTSysSkillRelaDA.GetObjByDataRow(objRow);
 return objvRTSysSkillRelaEN;
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
 /// <param name = "lstvRTSysSkillRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSkillRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTSysSkillRelaEN> lstvRTSysSkillRelaObjLst)
{
foreach (clsvRTSysSkillRelaEN objvRTSysSkillRelaEN in lstvRTSysSkillRelaObjLst)
{
if (objvRTSysSkillRelaEN.mId == lngmId)
{
return objvRTSysSkillRelaEN;
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
 lngmId = new clsvRTSysSkillRelaDA().GetFirstID(strWhereCond);
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
 arrList = vRTSysSkillRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTSysSkillRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vRTSysSkillRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTSysSkillRelaDA.IsExistTable();
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
 bolIsExist = vRTSysSkillRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTSysSkillRelaENS">源对象</param>
 /// <param name = "objvRTSysSkillRelaENT">目标对象</param>
 public static void CopyTo(clsvRTSysSkillRelaEN objvRTSysSkillRelaENS, clsvRTSysSkillRelaEN objvRTSysSkillRelaENT)
{
try
{
objvRTSysSkillRelaENT.TopicName = objvRTSysSkillRelaENS.TopicName; //栏目主题
objvRTSysSkillRelaENT.SkillName = objvRTSysSkillRelaENS.SkillName; //技能名称
objvRTSysSkillRelaENT.OperationTypeId = objvRTSysSkillRelaENS.OperationTypeId; //操作类型ID
objvRTSysSkillRelaENT.Process = objvRTSysSkillRelaENS.Process; //实施过程
objvRTSysSkillRelaENT.LevelId = objvRTSysSkillRelaENS.LevelId; //级别Id
objvRTSysSkillRelaENT.LevelName = objvRTSysSkillRelaENS.LevelName; //级别名称
objvRTSysSkillRelaENT.SkillUpdUser = objvRTSysSkillRelaENS.SkillUpdUser; //SkillUpdUser
objvRTSysSkillRelaENT.SkillUpdDate = objvRTSysSkillRelaENS.SkillUpdDate; //SkillUpdDate
objvRTSysSkillRelaENT.OrderNum = objvRTSysSkillRelaENS.OrderNum; //序号
objvRTSysSkillRelaENT.IdCurrEduCls = objvRTSysSkillRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSkillRelaENT.TopicProposePeople = objvRTSysSkillRelaENS.TopicProposePeople; //主题提出人
objvRTSysSkillRelaENT.TopicContent = objvRTSysSkillRelaENS.TopicContent; //主题内容
objvRTSysSkillRelaENT.IsSubmit = objvRTSysSkillRelaENS.IsSubmit; //是否提交
objvRTSysSkillRelaENT.AppraiseCount = objvRTSysSkillRelaENS.AppraiseCount; //评论数
objvRTSysSkillRelaENT.Score = objvRTSysSkillRelaENS.Score; //评分
objvRTSysSkillRelaENT.StuScore = objvRTSysSkillRelaENS.StuScore; //学生平均分
objvRTSysSkillRelaENT.TeaScore = objvRTSysSkillRelaENS.TeaScore; //教师评分
objvRTSysSkillRelaENT.PdfContent = objvRTSysSkillRelaENS.PdfContent; //Pdf内容
objvRTSysSkillRelaENT.PdfPageNum = objvRTSysSkillRelaENS.PdfPageNum; //Pdf页码
objvRTSysSkillRelaENT.CitationCount = objvRTSysSkillRelaENS.CitationCount; //引用统计
objvRTSysSkillRelaENT.VersionCount = objvRTSysSkillRelaENS.VersionCount; //版本统计
objvRTSysSkillRelaENT.OperationTypeName = objvRTSysSkillRelaENS.OperationTypeName; //操作类型名
objvRTSysSkillRelaENT.OkCount = objvRTSysSkillRelaENS.OkCount; //点赞统计
objvRTSysSkillRelaENT.CitationId = objvRTSysSkillRelaENS.CitationId; //引用Id
objvRTSysSkillRelaENT.mId = objvRTSysSkillRelaENS.mId; //mId
objvRTSysSkillRelaENT.TopicId = objvRTSysSkillRelaENS.TopicId; //主题Id
objvRTSysSkillRelaENT.SkillId = objvRTSysSkillRelaENS.SkillId; //技能Id
objvRTSysSkillRelaENT.UpdDate = objvRTSysSkillRelaENS.UpdDate; //修改日期
objvRTSysSkillRelaENT.Memo = objvRTSysSkillRelaENS.Memo; //备注
objvRTSysSkillRelaENT.UpdUser = objvRTSysSkillRelaENS.UpdUser; //修改人
objvRTSysSkillRelaENT.CreateDate = objvRTSysSkillRelaENS.CreateDate; //建立日期
objvRTSysSkillRelaENT.ShareId = objvRTSysSkillRelaENS.ShareId; //分享Id
objvRTSysSkillRelaENT.ClassificationId = objvRTSysSkillRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
try
{
objvRTSysSkillRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTSysSkillRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTSysSkillRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.TopicName = objvRTSysSkillRelaEN.TopicName == "[null]" ? null :  objvRTSysSkillRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTSysSkillRela.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.SkillName = objvRTSysSkillRelaEN.SkillName == "[null]" ? null :  objvRTSysSkillRelaEN.SkillName; //技能名称
}
if (arrFldSet.Contains(convRTSysSkillRela.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.OperationTypeId = objvRTSysSkillRelaEN.OperationTypeId == "[null]" ? null :  objvRTSysSkillRelaEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convRTSysSkillRela.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.Process = objvRTSysSkillRelaEN.Process == "[null]" ? null :  objvRTSysSkillRelaEN.Process; //实施过程
}
if (arrFldSet.Contains(convRTSysSkillRela.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.LevelId = objvRTSysSkillRelaEN.LevelId == "[null]" ? null :  objvRTSysSkillRelaEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convRTSysSkillRela.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.LevelName = objvRTSysSkillRelaEN.LevelName == "[null]" ? null :  objvRTSysSkillRelaEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convRTSysSkillRela.SkillUpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.SkillUpdUser = objvRTSysSkillRelaEN.SkillUpdUser == "[null]" ? null :  objvRTSysSkillRelaEN.SkillUpdUser; //SkillUpdUser
}
if (arrFldSet.Contains(convRTSysSkillRela.SkillUpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.SkillUpdDate = objvRTSysSkillRelaEN.SkillUpdDate == "[null]" ? null :  objvRTSysSkillRelaEN.SkillUpdDate; //SkillUpdDate
}
if (arrFldSet.Contains(convRTSysSkillRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.OrderNum = objvRTSysSkillRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convRTSysSkillRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.IdCurrEduCls = objvRTSysSkillRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTSysSkillRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTSysSkillRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.TopicProposePeople = objvRTSysSkillRelaEN.TopicProposePeople == "[null]" ? null :  objvRTSysSkillRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTSysSkillRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.TopicContent = objvRTSysSkillRelaEN.TopicContent == "[null]" ? null :  objvRTSysSkillRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTSysSkillRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.IsSubmit = objvRTSysSkillRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTSysSkillRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.AppraiseCount = objvRTSysSkillRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTSysSkillRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.Score = objvRTSysSkillRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTSysSkillRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.StuScore = objvRTSysSkillRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTSysSkillRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.TeaScore = objvRTSysSkillRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTSysSkillRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.PdfContent = objvRTSysSkillRelaEN.PdfContent == "[null]" ? null :  objvRTSysSkillRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTSysSkillRela.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.PdfPageNum = objvRTSysSkillRelaEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convRTSysSkillRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.CitationCount = objvRTSysSkillRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTSysSkillRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.VersionCount = objvRTSysSkillRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTSysSkillRela.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.OperationTypeName = objvRTSysSkillRelaEN.OperationTypeName == "[null]" ? null :  objvRTSysSkillRelaEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convRTSysSkillRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.OkCount = objvRTSysSkillRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTSysSkillRela.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.CitationId = objvRTSysSkillRelaEN.CitationId == "[null]" ? null :  objvRTSysSkillRelaEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convRTSysSkillRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.mId = objvRTSysSkillRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTSysSkillRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.TopicId = objvRTSysSkillRelaEN.TopicId == "[null]" ? null :  objvRTSysSkillRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTSysSkillRela.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.SkillId = objvRTSysSkillRelaEN.SkillId; //技能Id
}
if (arrFldSet.Contains(convRTSysSkillRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.UpdDate = objvRTSysSkillRelaEN.UpdDate == "[null]" ? null :  objvRTSysSkillRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTSysSkillRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.Memo = objvRTSysSkillRelaEN.Memo == "[null]" ? null :  objvRTSysSkillRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convRTSysSkillRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.UpdUser = objvRTSysSkillRelaEN.UpdUser == "[null]" ? null :  objvRTSysSkillRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTSysSkillRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.CreateDate = objvRTSysSkillRelaEN.CreateDate == "[null]" ? null :  objvRTSysSkillRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTSysSkillRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.ShareId = objvRTSysSkillRelaEN.ShareId == "[null]" ? null :  objvRTSysSkillRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTSysSkillRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSkillRelaEN.ClassificationId = objvRTSysSkillRelaEN.ClassificationId == "[null]" ? null :  objvRTSysSkillRelaEN.ClassificationId; //分类Id
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
 /// <param name = "objvRTSysSkillRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
try
{
if (objvRTSysSkillRelaEN.TopicName == "[null]") objvRTSysSkillRelaEN.TopicName = null; //栏目主题
if (objvRTSysSkillRelaEN.SkillName == "[null]") objvRTSysSkillRelaEN.SkillName = null; //技能名称
if (objvRTSysSkillRelaEN.OperationTypeId == "[null]") objvRTSysSkillRelaEN.OperationTypeId = null; //操作类型ID
if (objvRTSysSkillRelaEN.Process == "[null]") objvRTSysSkillRelaEN.Process = null; //实施过程
if (objvRTSysSkillRelaEN.LevelId == "[null]") objvRTSysSkillRelaEN.LevelId = null; //级别Id
if (objvRTSysSkillRelaEN.LevelName == "[null]") objvRTSysSkillRelaEN.LevelName = null; //级别名称
if (objvRTSysSkillRelaEN.SkillUpdUser == "[null]") objvRTSysSkillRelaEN.SkillUpdUser = null; //SkillUpdUser
if (objvRTSysSkillRelaEN.SkillUpdDate == "[null]") objvRTSysSkillRelaEN.SkillUpdDate = null; //SkillUpdDate
if (objvRTSysSkillRelaEN.IdCurrEduCls == "[null]") objvRTSysSkillRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTSysSkillRelaEN.TopicProposePeople == "[null]") objvRTSysSkillRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTSysSkillRelaEN.TopicContent == "[null]") objvRTSysSkillRelaEN.TopicContent = null; //主题内容
if (objvRTSysSkillRelaEN.PdfContent == "[null]") objvRTSysSkillRelaEN.PdfContent = null; //Pdf内容
if (objvRTSysSkillRelaEN.OperationTypeName == "[null]") objvRTSysSkillRelaEN.OperationTypeName = null; //操作类型名
if (objvRTSysSkillRelaEN.CitationId == "[null]") objvRTSysSkillRelaEN.CitationId = null; //引用Id
if (objvRTSysSkillRelaEN.TopicId == "[null]") objvRTSysSkillRelaEN.TopicId = null; //主题Id
if (objvRTSysSkillRelaEN.UpdDate == "[null]") objvRTSysSkillRelaEN.UpdDate = null; //修改日期
if (objvRTSysSkillRelaEN.Memo == "[null]") objvRTSysSkillRelaEN.Memo = null; //备注
if (objvRTSysSkillRelaEN.UpdUser == "[null]") objvRTSysSkillRelaEN.UpdUser = null; //修改人
if (objvRTSysSkillRelaEN.CreateDate == "[null]") objvRTSysSkillRelaEN.CreateDate = null; //建立日期
if (objvRTSysSkillRelaEN.ShareId == "[null]") objvRTSysSkillRelaEN.ShareId = null; //分享Id
if (objvRTSysSkillRelaEN.ClassificationId == "[null]") objvRTSysSkillRelaEN.ClassificationId = null; //分类Id
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
public static void CheckProperty4Condition(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
 vRTSysSkillRelaDA.CheckProperty4Condition(objvRTSysSkillRelaEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convRTSysSkillRela.mId); 
List<clsvRTSysSkillRelaEN> arrObjLst = clsvRTSysSkillRelaBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvRTSysSkillRelaEN objvRTSysSkillRelaEN = new clsvRTSysSkillRelaEN()
{
mId = 0,
OperationTypeId = "选[vRTSysSkillRela]..."
};
arrObjLst.Insert(0, objvRTSysSkillRelaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convRTSysSkillRela.mId;
objComboBox.DisplayMember = convRTSysSkillRela.OperationTypeId;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vRTSysSkillRela]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convRTSysSkillRela.mId); 
IEnumerable<clsvRTSysSkillRelaEN> arrObjLst = clsvRTSysSkillRelaBL.GetObjLst(strCondition);
objDDL.DataValueField = convRTSysSkillRela.mId;
objDDL.DataTextField = convRTSysSkillRela.OperationTypeId;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vRTSysSkillRela]...","0");
List<clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLst = GetAllvRTSysSkillRelaObjLstCache(); 
arrvRTSysSkillRelaObjLst = arrvRTSysSkillRelaObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = convRTSysSkillRela.mId;
objDDL.DataTextField = convRTSysSkillRela.OperationTypeId;
objDDL.DataSource = arrvRTSysSkillRelaObjLst;
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
//if (arrvRTSysSkillRelaObjLstCache == null)
//{
//arrvRTSysSkillRelaObjLstCache = vRTSysSkillRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSkillRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTSysSkillRelaEN._CurrTabName);
List<clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLst_Sel =
arrvRTSysSkillRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTSysSkillRelaObjLst_Sel.Count() == 0)
{
   clsvRTSysSkillRelaEN obj = clsvRTSysSkillRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTSysSkillRelaObjLst_Sel.First();
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
clsvRTSysSkillRelaEN objvRTSysSkillRela = GetObjBymIdCache(lngmId);
if (objvRTSysSkillRela == null) return "";
return objvRTSysSkillRela.LevelId;
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
clsvRTSysSkillRelaEN objvRTSysSkillRela = GetObjBymIdCache(lngmId);
if (objvRTSysSkillRela == null) return "";
return objvRTSysSkillRela.LevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetAllvRTSysSkillRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLstCache = GetObjLstCache(); 
return arrvRTSysSkillRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSkillRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTSysSkillRelaEN._CurrTabName);
List<clsvRTSysSkillRelaEN> arrvRTSysSkillRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTSysSkillRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvRTSysSkillRelaEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vRTSysSkillRela(vRTSysSkillRela)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvRTSysSkillRelaEN objvRTSysSkillRelaEN)
{
//检测记录是否存在
string strResult = vRTSysSkillRelaDA.GetUniCondStr(objvRTSysSkillRelaEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-07
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convRTSysSkillRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTSysSkillRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTSysSkillRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTSysSkillRela = clsvRTSysSkillRelaBL.GetObjBymIdCache(lngmId);
if (objvRTSysSkillRela == null) return "";
return objvRTSysSkillRela[strOutFldName].ToString();
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
int intRecCount = clsvRTSysSkillRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTSysSkillRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTSysSkillRelaDA.GetRecCount();
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
int intRecCount = clsvRTSysSkillRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTSysSkillRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTSysSkillRelaEN objvRTSysSkillRelaCond)
{
List<clsvRTSysSkillRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSkillRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSkillRela.AttributeName)
{
if (objvRTSysSkillRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSkillRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillRelaCond[strFldName].ToString());
}
else
{
if (objvRTSysSkillRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSkillRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSkillRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSkillRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSkillRelaCond[strFldName]));
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
 List<string> arrList = clsvRTSysSkillRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSkillRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSkillRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}