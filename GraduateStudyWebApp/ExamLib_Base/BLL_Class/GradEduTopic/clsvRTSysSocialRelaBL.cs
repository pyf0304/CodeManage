
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTSysSocialRelaBL
 表名:vRTSysSocialRela(01120655)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:39
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
public static class  clsvRTSysSocialRelaBL_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetSubViewpointId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, long lngSubViewpointId, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.SubViewpointId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.SubViewpointId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.SubViewpointId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetTopicId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTSysSocialRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTSysSocialRela.TopicId);
}
objvRTSysSocialRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.TopicId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.TopicId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.TopicId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetTopicName(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTSysSocialRela.TopicName);
}
objvRTSysSocialRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.TopicName) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.TopicName, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.TopicName] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetTopicContent(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.TopicContent) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.TopicContent, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.TopicContent] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetTopicProposePeople(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTSysSocialRela.TopicProposePeople);
}
objvRTSysSocialRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.TopicProposePeople) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetOrderNum(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.OrderNum) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.OrderNum, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.OrderNum] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetIdCurrEduCls(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTSysSocialRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTSysSocialRela.IdCurrEduCls);
}
objvRTSysSocialRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.IdCurrEduCls) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetFullName(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, convRTSysSocialRela.FullName);
}
objvRTSysSocialRelaEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.FullName) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.FullName, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.FullName] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetNationality(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convRTSysSocialRela.Nationality);
}
objvRTSysSocialRelaEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.Nationality) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.Nationality, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.Nationality] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetWorkUnit(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convRTSysSocialRela.WorkUnit);
}
objvRTSysSocialRelaEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.WorkUnit) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.WorkUnit, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.WorkUnit] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetMajor(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convRTSysSocialRela.Major);
}
objvRTSysSocialRelaEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.Major) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.Major, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.Major] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetAchievement(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convRTSysSocialRela.Achievement);
}
objvRTSysSocialRelaEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.Achievement) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.Achievement, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.Achievement] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetDetailedDescription(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strDetailedDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailedDescription, 5000, convRTSysSocialRela.DetailedDescription);
}
objvRTSysSocialRelaEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.DetailedDescription) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.DetailedDescription, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.DetailedDescription] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetLevelId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convRTSysSocialRela.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convRTSysSocialRela.LevelId);
}
objvRTSysSocialRelaEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.LevelId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.LevelId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.LevelId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetLevelName(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convRTSysSocialRela.LevelName);
}
objvRTSysSocialRelaEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.LevelName) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.LevelName, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.LevelName] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetSocialUpdUser(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strSocialUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialUpdUser, 20, convRTSysSocialRela.SocialUpdUser);
}
objvRTSysSocialRelaEN.SocialUpdUser = strSocialUpdUser; //SocialUpdUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.SocialUpdUser) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.SocialUpdUser, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.SocialUpdUser] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetSocialUpdDate(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strSocialUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialUpdDate, 20, convRTSysSocialRela.SocialUpdDate);
}
objvRTSysSocialRelaEN.SocialUpdDate = strSocialUpdDate; //SocialUpdDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.SocialUpdDate) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.SocialUpdDate, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.SocialUpdDate] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetIsSubmit(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.IsSubmit) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.IsSubmit, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.IsSubmit] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetOkCount(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.OkCount) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.OkCount, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.OkCount] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetUpdDate(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTSysSocialRela.UpdDate);
}
objvRTSysSocialRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.UpdDate) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.UpdDate, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.UpdDate] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetUpdUser(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTSysSocialRela.UpdUser);
}
objvRTSysSocialRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.UpdUser) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.UpdUser, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.UpdUser] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetMemo(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTSysSocialRela.Memo);
}
objvRTSysSocialRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.Memo) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.Memo, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.Memo] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetAppraiseCount(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.AppraiseCount) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetScore(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.Score) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.Score, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.Score] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetStuScore(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.StuScore) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.StuScore, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.StuScore] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetTeaScore(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.TeaScore) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.TeaScore, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.TeaScore] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetCreateDate(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTSysSocialRela.CreateDate);
}
objvRTSysSocialRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.CreateDate) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.CreateDate, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.CreateDate] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetShareId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTSysSocialRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTSysSocialRela.ShareId);
}
objvRTSysSocialRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.ShareId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.ShareId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.ShareId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetPdfContent(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTSysSocialRela.PdfContent);
}
objvRTSysSocialRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.PdfContent) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.PdfContent, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.PdfContent] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetClassificationId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, long? lngClassificationId, string strComparisonOp="")
	{
objvRTSysSocialRelaEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.ClassificationId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.ClassificationId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.ClassificationId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTSysSocialRelaEN SetPaperId(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convRTSysSocialRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convRTSysSocialRela.PaperId);
}
objvRTSysSocialRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTSysSocialRelaEN.dicFldComparisonOp.ContainsKey(convRTSysSocialRela.PaperId) == false)
{
objvRTSysSocialRelaEN.dicFldComparisonOp.Add(convRTSysSocialRela.PaperId, strComparisonOp);
}
else
{
objvRTSysSocialRelaEN.dicFldComparisonOp[convRTSysSocialRela.PaperId] = strComparisonOp;
}
}
return objvRTSysSocialRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaENS">源对象</param>
 /// <param name = "objvRTSysSocialRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTSysSocialRelaEN objvRTSysSocialRelaENS, clsvRTSysSocialRelaEN objvRTSysSocialRelaENT)
{
try
{
objvRTSysSocialRelaENT.SubViewpointId = objvRTSysSocialRelaENS.SubViewpointId; //子观点Id
objvRTSysSocialRelaENT.TopicId = objvRTSysSocialRelaENS.TopicId; //主题Id
objvRTSysSocialRelaENT.TopicName = objvRTSysSocialRelaENS.TopicName; //栏目主题
objvRTSysSocialRelaENT.TopicContent = objvRTSysSocialRelaENS.TopicContent; //主题内容
objvRTSysSocialRelaENT.TopicProposePeople = objvRTSysSocialRelaENS.TopicProposePeople; //主题提出人
objvRTSysSocialRelaENT.OrderNum = objvRTSysSocialRelaENS.OrderNum; //序号
objvRTSysSocialRelaENT.IdCurrEduCls = objvRTSysSocialRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSocialRelaENT.FullName = objvRTSysSocialRelaENS.FullName; //姓名
objvRTSysSocialRelaENT.Nationality = objvRTSysSocialRelaENS.Nationality; //国籍
objvRTSysSocialRelaENT.WorkUnit = objvRTSysSocialRelaENS.WorkUnit; //工作单位
objvRTSysSocialRelaENT.Major = objvRTSysSocialRelaENS.Major; //专业
objvRTSysSocialRelaENT.Achievement = objvRTSysSocialRelaENS.Achievement; //成就
objvRTSysSocialRelaENT.DetailedDescription = objvRTSysSocialRelaENS.DetailedDescription; //详细说明
objvRTSysSocialRelaENT.LevelId = objvRTSysSocialRelaENS.LevelId; //级别Id
objvRTSysSocialRelaENT.LevelName = objvRTSysSocialRelaENS.LevelName; //级别名称
objvRTSysSocialRelaENT.SocialUpdUser = objvRTSysSocialRelaENS.SocialUpdUser; //SocialUpdUser
objvRTSysSocialRelaENT.SocialUpdDate = objvRTSysSocialRelaENS.SocialUpdDate; //SocialUpdDate
objvRTSysSocialRelaENT.IsSubmit = objvRTSysSocialRelaENS.IsSubmit; //是否提交
objvRTSysSocialRelaENT.OkCount = objvRTSysSocialRelaENS.OkCount; //点赞统计
objvRTSysSocialRelaENT.UpdDate = objvRTSysSocialRelaENS.UpdDate; //修改日期
objvRTSysSocialRelaENT.UpdUser = objvRTSysSocialRelaENS.UpdUser; //修改人
objvRTSysSocialRelaENT.Memo = objvRTSysSocialRelaENS.Memo; //备注
objvRTSysSocialRelaENT.AppraiseCount = objvRTSysSocialRelaENS.AppraiseCount; //评论数
objvRTSysSocialRelaENT.Score = objvRTSysSocialRelaENS.Score; //评分
objvRTSysSocialRelaENT.StuScore = objvRTSysSocialRelaENS.StuScore; //学生平均分
objvRTSysSocialRelaENT.TeaScore = objvRTSysSocialRelaENS.TeaScore; //教师评分
objvRTSysSocialRelaENT.CreateDate = objvRTSysSocialRelaENS.CreateDate; //建立日期
objvRTSysSocialRelaENT.ShareId = objvRTSysSocialRelaENS.ShareId; //分享Id
objvRTSysSocialRelaENT.PdfContent = objvRTSysSocialRelaENS.PdfContent; //Pdf内容
objvRTSysSocialRelaENT.ClassificationId = objvRTSysSocialRelaENS.ClassificationId; //分类Id
objvRTSysSocialRelaENT.PaperId = objvRTSysSocialRelaENS.PaperId; //论文Id
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
 /// <param name = "objvRTSysSocialRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTSysSocialRelaEN:objvRTSysSocialRelaENT</returns>
 public static clsvRTSysSocialRelaEN CopyTo(this clsvRTSysSocialRelaEN objvRTSysSocialRelaENS)
{
try
{
 clsvRTSysSocialRelaEN objvRTSysSocialRelaENT = new clsvRTSysSocialRelaEN()
{
SubViewpointId = objvRTSysSocialRelaENS.SubViewpointId, //子观点Id
TopicId = objvRTSysSocialRelaENS.TopicId, //主题Id
TopicName = objvRTSysSocialRelaENS.TopicName, //栏目主题
TopicContent = objvRTSysSocialRelaENS.TopicContent, //主题内容
TopicProposePeople = objvRTSysSocialRelaENS.TopicProposePeople, //主题提出人
OrderNum = objvRTSysSocialRelaENS.OrderNum, //序号
IdCurrEduCls = objvRTSysSocialRelaENS.IdCurrEduCls, //教学班流水号
FullName = objvRTSysSocialRelaENS.FullName, //姓名
Nationality = objvRTSysSocialRelaENS.Nationality, //国籍
WorkUnit = objvRTSysSocialRelaENS.WorkUnit, //工作单位
Major = objvRTSysSocialRelaENS.Major, //专业
Achievement = objvRTSysSocialRelaENS.Achievement, //成就
DetailedDescription = objvRTSysSocialRelaENS.DetailedDescription, //详细说明
LevelId = objvRTSysSocialRelaENS.LevelId, //级别Id
LevelName = objvRTSysSocialRelaENS.LevelName, //级别名称
SocialUpdUser = objvRTSysSocialRelaENS.SocialUpdUser, //SocialUpdUser
SocialUpdDate = objvRTSysSocialRelaENS.SocialUpdDate, //SocialUpdDate
IsSubmit = objvRTSysSocialRelaENS.IsSubmit, //是否提交
OkCount = objvRTSysSocialRelaENS.OkCount, //点赞统计
UpdDate = objvRTSysSocialRelaENS.UpdDate, //修改日期
UpdUser = objvRTSysSocialRelaENS.UpdUser, //修改人
Memo = objvRTSysSocialRelaENS.Memo, //备注
AppraiseCount = objvRTSysSocialRelaENS.AppraiseCount, //评论数
Score = objvRTSysSocialRelaENS.Score, //评分
StuScore = objvRTSysSocialRelaENS.StuScore, //学生平均分
TeaScore = objvRTSysSocialRelaENS.TeaScore, //教师评分
CreateDate = objvRTSysSocialRelaENS.CreateDate, //建立日期
ShareId = objvRTSysSocialRelaENS.ShareId, //分享Id
PdfContent = objvRTSysSocialRelaENS.PdfContent, //Pdf内容
ClassificationId = objvRTSysSocialRelaENS.ClassificationId, //分类Id
PaperId = objvRTSysSocialRelaENS.PaperId, //论文Id
};
 return objvRTSysSocialRelaENT;
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
public static void CheckProperty4Condition(this clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
 clsvRTSysSocialRelaBL.vRTSysSocialRelaDA.CheckProperty4Condition(objvRTSysSocialRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTSysSocialRelaEN objvRTSysSocialRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.SubViewpointId, objvRTSysSocialRelaCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.TopicId, objvRTSysSocialRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.TopicName, objvRTSysSocialRelaCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.TopicProposePeople, objvRTSysSocialRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.OrderNum, objvRTSysSocialRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.IdCurrEduCls, objvRTSysSocialRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.FullName) == true)
{
string strComparisonOpFullName = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.FullName, objvRTSysSocialRelaCond.FullName, strComparisonOpFullName);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.Nationality) == true)
{
string strComparisonOpNationality = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.Nationality, objvRTSysSocialRelaCond.Nationality, strComparisonOpNationality);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.WorkUnit, objvRTSysSocialRelaCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.Major) == true)
{
string strComparisonOpMajor = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.Major, objvRTSysSocialRelaCond.Major, strComparisonOpMajor);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.Achievement) == true)
{
string strComparisonOpAchievement = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.Achievement, objvRTSysSocialRelaCond.Achievement, strComparisonOpAchievement);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.DetailedDescription) == true)
{
string strComparisonOpDetailedDescription = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.DetailedDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.DetailedDescription, objvRTSysSocialRelaCond.DetailedDescription, strComparisonOpDetailedDescription);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.LevelId) == true)
{
string strComparisonOpLevelId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.LevelId, objvRTSysSocialRelaCond.LevelId, strComparisonOpLevelId);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.LevelName) == true)
{
string strComparisonOpLevelName = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.LevelName, objvRTSysSocialRelaCond.LevelName, strComparisonOpLevelName);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.SocialUpdUser) == true)
{
string strComparisonOpSocialUpdUser = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.SocialUpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.SocialUpdUser, objvRTSysSocialRelaCond.SocialUpdUser, strComparisonOpSocialUpdUser);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.SocialUpdDate) == true)
{
string strComparisonOpSocialUpdDate = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.SocialUpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.SocialUpdDate, objvRTSysSocialRelaCond.SocialUpdDate, strComparisonOpSocialUpdDate);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.IsSubmit) == true)
{
if (objvRTSysSocialRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTSysSocialRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTSysSocialRela.IsSubmit);
}
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.OkCount, objvRTSysSocialRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.UpdDate, objvRTSysSocialRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.UpdUser, objvRTSysSocialRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.Memo) == true)
{
string strComparisonOpMemo = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.Memo, objvRTSysSocialRelaCond.Memo, strComparisonOpMemo);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.AppraiseCount, objvRTSysSocialRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.Score) == true)
{
string strComparisonOpScore = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.Score, objvRTSysSocialRelaCond.Score, strComparisonOpScore);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.StuScore, objvRTSysSocialRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.TeaScore, objvRTSysSocialRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.CreateDate, objvRTSysSocialRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.ShareId) == true)
{
string strComparisonOpShareId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.ShareId, objvRTSysSocialRelaCond.ShareId, strComparisonOpShareId);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.PdfContent, objvRTSysSocialRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTSysSocialRela.ClassificationId, objvRTSysSocialRelaCond.ClassificationId, strComparisonOpClassificationId);
}
if (objvRTSysSocialRelaCond.IsUpdated(convRTSysSocialRela.PaperId) == true)
{
string strComparisonOpPaperId = objvRTSysSocialRelaCond.dicFldComparisonOp[convRTSysSocialRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTSysSocialRela.PaperId, objvRTSysSocialRelaCond.PaperId, strComparisonOpPaperId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTSysSocialRela
{
public virtual bool UpdRelaTabDate(long lngSubViewpointId,string strTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTSysSocialRela(vRTSysSocialRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTSysSocialRelaBL
{
public static RelatedActions_vRTSysSocialRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTSysSocialRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTSysSocialRelaDA vRTSysSocialRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTSysSocialRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTSysSocialRelaBL()
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
if (string.IsNullOrEmpty(clsvRTSysSocialRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTSysSocialRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTSysSocialRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTSysSocialRelaDA.GetDataTable_vRTSysSocialRela(strWhereCond);
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
objDT = vRTSysSocialRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTSysSocialRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTSysSocialRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTSysSocialRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTSysSocialRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTSysSocialRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTSysSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTSysSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--vRTSysSocialRela(vRTSysSocialRela)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objvRTSysSocialRelaEN.SubViewpointId;
strResult += "|" + objvRTSysSocialRelaEN.TopicId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTSysSocialRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsvRTSysSocialRelaEN._CurrTabName);
List<clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLst_Sel =
arrvRTSysSocialRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrvRTSysSocialRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
public static List<clsvRTSysSocialRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTSysSocialRelaEN> GetSubObjLstCache(clsvRTSysSocialRelaEN objvRTSysSocialRelaCond)
{
List<clsvRTSysSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSocialRela.AttributeName)
{
if (objvRTSysSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSocialRelaCond[strFldName].ToString());
}
else
{
if (objvRTSysSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSocialRelaCond[strFldName]));
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
public static List<clsvRTSysSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
public static List<clsvRTSysSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
List<clsvRTSysSocialRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTSysSocialRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTSysSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
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
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
public static List<clsvRTSysSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTSysSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
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
public static List<clsvRTSysSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTSysSocialRelaEN> arrObjLst = new List<clsvRTSysSocialRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = new clsvRTSysSocialRelaEN();
try
{
objvRTSysSocialRelaEN.SubViewpointId = Int32.Parse(objRow[convRTSysSocialRela.SubViewpointId].ToString().Trim()); //子观点Id
objvRTSysSocialRelaEN.TopicId = objRow[convRTSysSocialRela.TopicId].ToString().Trim(); //主题Id
objvRTSysSocialRelaEN.TopicName = objRow[convRTSysSocialRela.TopicName] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicName].ToString().Trim(); //栏目主题
objvRTSysSocialRelaEN.TopicContent = objRow[convRTSysSocialRela.TopicContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicContent].ToString().Trim(); //主题内容
objvRTSysSocialRelaEN.TopicProposePeople = objRow[convRTSysSocialRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTSysSocialRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTSysSocialRelaEN.OrderNum = objRow[convRTSysSocialRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OrderNum].ToString().Trim()); //序号
objvRTSysSocialRelaEN.IdCurrEduCls = objRow[convRTSysSocialRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTSysSocialRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTSysSocialRelaEN.FullName = objRow[convRTSysSocialRela.FullName] == DBNull.Value ? null : objRow[convRTSysSocialRela.FullName].ToString().Trim(); //姓名
objvRTSysSocialRelaEN.Nationality = objRow[convRTSysSocialRela.Nationality] == DBNull.Value ? null : objRow[convRTSysSocialRela.Nationality].ToString().Trim(); //国籍
objvRTSysSocialRelaEN.WorkUnit = objRow[convRTSysSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convRTSysSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvRTSysSocialRelaEN.Major = objRow[convRTSysSocialRela.Major] == DBNull.Value ? null : objRow[convRTSysSocialRela.Major].ToString().Trim(); //专业
objvRTSysSocialRelaEN.Achievement = objRow[convRTSysSocialRela.Achievement] == DBNull.Value ? null : objRow[convRTSysSocialRela.Achievement].ToString().Trim(); //成就
objvRTSysSocialRelaEN.DetailedDescription = objRow[convRTSysSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convRTSysSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvRTSysSocialRelaEN.LevelId = objRow[convRTSysSocialRela.LevelId] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelId].ToString().Trim(); //级别Id
objvRTSysSocialRelaEN.LevelName = objRow[convRTSysSocialRela.LevelName] == DBNull.Value ? null : objRow[convRTSysSocialRela.LevelName].ToString().Trim(); //级别名称
objvRTSysSocialRelaEN.SocialUpdUser = objRow[convRTSysSocialRela.SocialUpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdUser].ToString().Trim(); //SocialUpdUser
objvRTSysSocialRelaEN.SocialUpdDate = objRow[convRTSysSocialRela.SocialUpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.SocialUpdDate].ToString().Trim(); //SocialUpdDate
objvRTSysSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTSysSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvRTSysSocialRelaEN.OkCount = objRow[convRTSysSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.OkCount].ToString().Trim()); //点赞统计
objvRTSysSocialRelaEN.UpdDate = objRow[convRTSysSocialRela.UpdDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdDate].ToString().Trim(); //修改日期
objvRTSysSocialRelaEN.UpdUser = objRow[convRTSysSocialRela.UpdUser] == DBNull.Value ? null : objRow[convRTSysSocialRela.UpdUser].ToString().Trim(); //修改人
objvRTSysSocialRelaEN.Memo = objRow[convRTSysSocialRela.Memo] == DBNull.Value ? null : objRow[convRTSysSocialRela.Memo].ToString().Trim(); //备注
objvRTSysSocialRelaEN.AppraiseCount = objRow[convRTSysSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvRTSysSocialRelaEN.Score = objRow[convRTSysSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.Score].ToString().Trim()); //评分
objvRTSysSocialRelaEN.StuScore = objRow[convRTSysSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.StuScore].ToString().Trim()); //学生平均分
objvRTSysSocialRelaEN.TeaScore = objRow[convRTSysSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTSysSocialRela.TeaScore].ToString().Trim()); //教师评分
objvRTSysSocialRelaEN.CreateDate = objRow[convRTSysSocialRela.CreateDate] == DBNull.Value ? null : objRow[convRTSysSocialRela.CreateDate].ToString().Trim(); //建立日期
objvRTSysSocialRelaEN.ShareId = objRow[convRTSysSocialRela.ShareId] == DBNull.Value ? null : objRow[convRTSysSocialRela.ShareId].ToString().Trim(); //分享Id
objvRTSysSocialRelaEN.PdfContent = objRow[convRTSysSocialRela.PdfContent] == DBNull.Value ? null : objRow[convRTSysSocialRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTSysSocialRelaEN.ClassificationId = objRow[convRTSysSocialRela.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTSysSocialRela.ClassificationId].ToString().Trim()); //分类Id
objvRTSysSocialRelaEN.PaperId = objRow[convRTSysSocialRela.PaperId] == DBNull.Value ? null : objRow[convRTSysSocialRela.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTSysSocialRelaEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTSysSocialRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTSysSocialRela(ref clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
bool bolResult = vRTSysSocialRelaDA.GetvRTSysSocialRela(ref objvRTSysSocialRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTSysSocialRelaEN GetObjByKeyLst(long lngSubViewpointId,string strTopicId)
{
if (strTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[lngSubViewpointId,strTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (lngSubViewpointId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[lngSubViewpointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = vRTSysSocialRelaDA.GetObjByKeyLst(lngSubViewpointId,strTopicId);
return objvRTSysSocialRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTSysSocialRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = vRTSysSocialRelaDA.GetFirstObj(strWhereCond);
 return objvRTSysSocialRelaEN;
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
public static clsvRTSysSocialRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = vRTSysSocialRelaDA.GetObjByDataRow(objRow);
 return objvRTSysSocialRelaEN;
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
public static clsvRTSysSocialRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTSysSocialRelaEN objvRTSysSocialRelaEN = vRTSysSocialRelaDA.GetObjByDataRow(objRow);
 return objvRTSysSocialRelaEN;
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
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lstvRTSysSocialRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSocialRelaEN GetObjByKeyLstFromList(long lngSubViewpointId,string strTopicId, List<clsvRTSysSocialRelaEN> lstvRTSysSocialRelaObjLst)
{
foreach (clsvRTSysSocialRelaEN objvRTSysSocialRelaEN in lstvRTSysSocialRelaObjLst)
{
if (objvRTSysSocialRelaEN.SubViewpointId == lngSubViewpointId 
 && objvRTSysSocialRelaEN.TopicId == strTopicId 
)
{
return objvRTSysSocialRelaEN;
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
 long lngSubViewpointId;
 try
 {
 lngSubViewpointId = new clsvRTSysSocialRelaDA().GetFirstID(strWhereCond);
 return lngSubViewpointId;
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
 arrList = vRTSysSocialRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTSysSocialRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSubViewpointId,string strTopicId)
{
//检测记录是否存在
bool bolIsExist = vRTSysSocialRelaDA.IsExist(lngSubViewpointId,strTopicId);
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
 bolIsExist = clsvRTSysSocialRelaDA.IsExistTable();
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
 bolIsExist = vRTSysSocialRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTSysSocialRelaENS">源对象</param>
 /// <param name = "objvRTSysSocialRelaENT">目标对象</param>
 public static void CopyTo(clsvRTSysSocialRelaEN objvRTSysSocialRelaENS, clsvRTSysSocialRelaEN objvRTSysSocialRelaENT)
{
try
{
objvRTSysSocialRelaENT.SubViewpointId = objvRTSysSocialRelaENS.SubViewpointId; //子观点Id
objvRTSysSocialRelaENT.TopicId = objvRTSysSocialRelaENS.TopicId; //主题Id
objvRTSysSocialRelaENT.TopicName = objvRTSysSocialRelaENS.TopicName; //栏目主题
objvRTSysSocialRelaENT.TopicContent = objvRTSysSocialRelaENS.TopicContent; //主题内容
objvRTSysSocialRelaENT.TopicProposePeople = objvRTSysSocialRelaENS.TopicProposePeople; //主题提出人
objvRTSysSocialRelaENT.OrderNum = objvRTSysSocialRelaENS.OrderNum; //序号
objvRTSysSocialRelaENT.IdCurrEduCls = objvRTSysSocialRelaENS.IdCurrEduCls; //教学班流水号
objvRTSysSocialRelaENT.FullName = objvRTSysSocialRelaENS.FullName; //姓名
objvRTSysSocialRelaENT.Nationality = objvRTSysSocialRelaENS.Nationality; //国籍
objvRTSysSocialRelaENT.WorkUnit = objvRTSysSocialRelaENS.WorkUnit; //工作单位
objvRTSysSocialRelaENT.Major = objvRTSysSocialRelaENS.Major; //专业
objvRTSysSocialRelaENT.Achievement = objvRTSysSocialRelaENS.Achievement; //成就
objvRTSysSocialRelaENT.DetailedDescription = objvRTSysSocialRelaENS.DetailedDescription; //详细说明
objvRTSysSocialRelaENT.LevelId = objvRTSysSocialRelaENS.LevelId; //级别Id
objvRTSysSocialRelaENT.LevelName = objvRTSysSocialRelaENS.LevelName; //级别名称
objvRTSysSocialRelaENT.SocialUpdUser = objvRTSysSocialRelaENS.SocialUpdUser; //SocialUpdUser
objvRTSysSocialRelaENT.SocialUpdDate = objvRTSysSocialRelaENS.SocialUpdDate; //SocialUpdDate
objvRTSysSocialRelaENT.IsSubmit = objvRTSysSocialRelaENS.IsSubmit; //是否提交
objvRTSysSocialRelaENT.OkCount = objvRTSysSocialRelaENS.OkCount; //点赞统计
objvRTSysSocialRelaENT.UpdDate = objvRTSysSocialRelaENS.UpdDate; //修改日期
objvRTSysSocialRelaENT.UpdUser = objvRTSysSocialRelaENS.UpdUser; //修改人
objvRTSysSocialRelaENT.Memo = objvRTSysSocialRelaENS.Memo; //备注
objvRTSysSocialRelaENT.AppraiseCount = objvRTSysSocialRelaENS.AppraiseCount; //评论数
objvRTSysSocialRelaENT.Score = objvRTSysSocialRelaENS.Score; //评分
objvRTSysSocialRelaENT.StuScore = objvRTSysSocialRelaENS.StuScore; //学生平均分
objvRTSysSocialRelaENT.TeaScore = objvRTSysSocialRelaENS.TeaScore; //教师评分
objvRTSysSocialRelaENT.CreateDate = objvRTSysSocialRelaENS.CreateDate; //建立日期
objvRTSysSocialRelaENT.ShareId = objvRTSysSocialRelaENS.ShareId; //分享Id
objvRTSysSocialRelaENT.PdfContent = objvRTSysSocialRelaENS.PdfContent; //Pdf内容
objvRTSysSocialRelaENT.ClassificationId = objvRTSysSocialRelaENS.ClassificationId; //分类Id
objvRTSysSocialRelaENT.PaperId = objvRTSysSocialRelaENS.PaperId; //论文Id
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
 /// <param name = "objvRTSysSocialRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
try
{
objvRTSysSocialRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTSysSocialRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTSysSocialRela.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.SubViewpointId = objvRTSysSocialRelaEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convRTSysSocialRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.TopicId = objvRTSysSocialRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTSysSocialRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.TopicName = objvRTSysSocialRelaEN.TopicName == "[null]" ? null :  objvRTSysSocialRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTSysSocialRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.TopicContent = objvRTSysSocialRelaEN.TopicContent == "[null]" ? null :  objvRTSysSocialRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTSysSocialRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.TopicProposePeople = objvRTSysSocialRelaEN.TopicProposePeople == "[null]" ? null :  objvRTSysSocialRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTSysSocialRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.OrderNum = objvRTSysSocialRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convRTSysSocialRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.IdCurrEduCls = objvRTSysSocialRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTSysSocialRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTSysSocialRela.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.FullName = objvRTSysSocialRelaEN.FullName == "[null]" ? null :  objvRTSysSocialRelaEN.FullName; //姓名
}
if (arrFldSet.Contains(convRTSysSocialRela.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.Nationality = objvRTSysSocialRelaEN.Nationality == "[null]" ? null :  objvRTSysSocialRelaEN.Nationality; //国籍
}
if (arrFldSet.Contains(convRTSysSocialRela.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.WorkUnit = objvRTSysSocialRelaEN.WorkUnit == "[null]" ? null :  objvRTSysSocialRelaEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convRTSysSocialRela.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.Major = objvRTSysSocialRelaEN.Major == "[null]" ? null :  objvRTSysSocialRelaEN.Major; //专业
}
if (arrFldSet.Contains(convRTSysSocialRela.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.Achievement = objvRTSysSocialRelaEN.Achievement == "[null]" ? null :  objvRTSysSocialRelaEN.Achievement; //成就
}
if (arrFldSet.Contains(convRTSysSocialRela.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.DetailedDescription = objvRTSysSocialRelaEN.DetailedDescription == "[null]" ? null :  objvRTSysSocialRelaEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(convRTSysSocialRela.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.LevelId = objvRTSysSocialRelaEN.LevelId == "[null]" ? null :  objvRTSysSocialRelaEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convRTSysSocialRela.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.LevelName = objvRTSysSocialRelaEN.LevelName == "[null]" ? null :  objvRTSysSocialRelaEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convRTSysSocialRela.SocialUpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.SocialUpdUser = objvRTSysSocialRelaEN.SocialUpdUser == "[null]" ? null :  objvRTSysSocialRelaEN.SocialUpdUser; //SocialUpdUser
}
if (arrFldSet.Contains(convRTSysSocialRela.SocialUpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.SocialUpdDate = objvRTSysSocialRelaEN.SocialUpdDate == "[null]" ? null :  objvRTSysSocialRelaEN.SocialUpdDate; //SocialUpdDate
}
if (arrFldSet.Contains(convRTSysSocialRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.IsSubmit = objvRTSysSocialRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTSysSocialRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.OkCount = objvRTSysSocialRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTSysSocialRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.UpdDate = objvRTSysSocialRelaEN.UpdDate == "[null]" ? null :  objvRTSysSocialRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTSysSocialRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.UpdUser = objvRTSysSocialRelaEN.UpdUser == "[null]" ? null :  objvRTSysSocialRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTSysSocialRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.Memo = objvRTSysSocialRelaEN.Memo == "[null]" ? null :  objvRTSysSocialRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convRTSysSocialRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.AppraiseCount = objvRTSysSocialRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTSysSocialRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.Score = objvRTSysSocialRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTSysSocialRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.StuScore = objvRTSysSocialRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTSysSocialRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.TeaScore = objvRTSysSocialRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTSysSocialRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.CreateDate = objvRTSysSocialRelaEN.CreateDate == "[null]" ? null :  objvRTSysSocialRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTSysSocialRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.ShareId = objvRTSysSocialRelaEN.ShareId == "[null]" ? null :  objvRTSysSocialRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTSysSocialRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.PdfContent = objvRTSysSocialRelaEN.PdfContent == "[null]" ? null :  objvRTSysSocialRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTSysSocialRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.ClassificationId = objvRTSysSocialRelaEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(convRTSysSocialRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTSysSocialRelaEN.PaperId = objvRTSysSocialRelaEN.PaperId == "[null]" ? null :  objvRTSysSocialRelaEN.PaperId; //论文Id
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
 /// <param name = "objvRTSysSocialRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
try
{
if (objvRTSysSocialRelaEN.TopicName == "[null]") objvRTSysSocialRelaEN.TopicName = null; //栏目主题
if (objvRTSysSocialRelaEN.TopicContent == "[null]") objvRTSysSocialRelaEN.TopicContent = null; //主题内容
if (objvRTSysSocialRelaEN.TopicProposePeople == "[null]") objvRTSysSocialRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTSysSocialRelaEN.IdCurrEduCls == "[null]") objvRTSysSocialRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTSysSocialRelaEN.FullName == "[null]") objvRTSysSocialRelaEN.FullName = null; //姓名
if (objvRTSysSocialRelaEN.Nationality == "[null]") objvRTSysSocialRelaEN.Nationality = null; //国籍
if (objvRTSysSocialRelaEN.WorkUnit == "[null]") objvRTSysSocialRelaEN.WorkUnit = null; //工作单位
if (objvRTSysSocialRelaEN.Major == "[null]") objvRTSysSocialRelaEN.Major = null; //专业
if (objvRTSysSocialRelaEN.Achievement == "[null]") objvRTSysSocialRelaEN.Achievement = null; //成就
if (objvRTSysSocialRelaEN.DetailedDescription == "[null]") objvRTSysSocialRelaEN.DetailedDescription = null; //详细说明
if (objvRTSysSocialRelaEN.LevelId == "[null]") objvRTSysSocialRelaEN.LevelId = null; //级别Id
if (objvRTSysSocialRelaEN.LevelName == "[null]") objvRTSysSocialRelaEN.LevelName = null; //级别名称
if (objvRTSysSocialRelaEN.SocialUpdUser == "[null]") objvRTSysSocialRelaEN.SocialUpdUser = null; //SocialUpdUser
if (objvRTSysSocialRelaEN.SocialUpdDate == "[null]") objvRTSysSocialRelaEN.SocialUpdDate = null; //SocialUpdDate
if (objvRTSysSocialRelaEN.UpdDate == "[null]") objvRTSysSocialRelaEN.UpdDate = null; //修改日期
if (objvRTSysSocialRelaEN.UpdUser == "[null]") objvRTSysSocialRelaEN.UpdUser = null; //修改人
if (objvRTSysSocialRelaEN.Memo == "[null]") objvRTSysSocialRelaEN.Memo = null; //备注
if (objvRTSysSocialRelaEN.CreateDate == "[null]") objvRTSysSocialRelaEN.CreateDate = null; //建立日期
if (objvRTSysSocialRelaEN.ShareId == "[null]") objvRTSysSocialRelaEN.ShareId = null; //分享Id
if (objvRTSysSocialRelaEN.PdfContent == "[null]") objvRTSysSocialRelaEN.PdfContent = null; //Pdf内容
if (objvRTSysSocialRelaEN.PaperId == "[null]") objvRTSysSocialRelaEN.PaperId = null; //论文Id
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
public static void CheckProperty4Condition(clsvRTSysSocialRelaEN objvRTSysSocialRelaEN)
{
 vRTSysSocialRelaDA.CheckProperty4Condition(objvRTSysSocialRelaEN);
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTSysSocialRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTSysSocialRelaBL没有刷新缓存机制(clsRTSysSocialRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by SubViewpointId");
//if (arrvRTSysSocialRelaObjLstCache == null)
//{
//arrvRTSysSocialRelaObjLstCache = vRTSysSocialRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTSysSocialRelaEN GetObjByKeyLstCache(long lngSubViewpointId,string strTopicId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTSysSocialRelaEN._CurrTabName);
List<clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLst_Sel =
arrvRTSysSocialRelaObjLstCache
.Where(x=> x.SubViewpointId == lngSubViewpointId 
 && x.TopicId == strTopicId 
);
if (arrvRTSysSocialRelaObjLst_Sel.Count() == 0)
{
   clsvRTSysSocialRelaEN obj = clsvRTSysSocialRelaBL.GetObjByKeyLst(lngSubViewpointId,strTopicId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTSysSocialRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetAllvRTSysSocialRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLstCache = GetObjLstCache(); 
return arrvRTSysSocialRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTSysSocialRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTSysSocialRelaEN._CurrTabName);
List<clsvRTSysSocialRelaEN> arrvRTSysSocialRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTSysSocialRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvRTSysSocialRelaEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngSubViewpointId,string strTopicId)
{
if (strInFldName != convRTSysSocialRela.SubViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTSysSocialRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTSysSocialRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTSysSocialRela = clsvRTSysSocialRelaBL.GetObjByKeyLstCache(lngSubViewpointId,strTopicId);
if (objvRTSysSocialRela == null) return "";
return objvRTSysSocialRela[strOutFldName].ToString();
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
int intRecCount = clsvRTSysSocialRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTSysSocialRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTSysSocialRelaDA.GetRecCount();
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
int intRecCount = clsvRTSysSocialRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTSysSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTSysSocialRelaEN objvRTSysSocialRelaCond)
{
List<clsvRTSysSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTSysSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTSysSocialRela.AttributeName)
{
if (objvRTSysSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTSysSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSocialRelaCond[strFldName].ToString());
}
else
{
if (objvRTSysSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTSysSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTSysSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTSysSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTSysSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTSysSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTSysSocialRelaCond[strFldName]));
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
 List<string> arrList = clsvRTSysSocialRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSocialRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTSysSocialRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}