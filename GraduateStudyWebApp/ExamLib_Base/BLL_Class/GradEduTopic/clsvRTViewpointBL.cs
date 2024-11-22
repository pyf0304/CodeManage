
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointBL
 表名:vRTViewpoint(01120956)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/19 02:42:21
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
public static class  clsvRTViewpointBL_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetTopicId(this clsvRTViewpointEN objvRTViewpointEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTViewpoint.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTViewpoint.TopicId);
}
objvRTViewpointEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.TopicId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.TopicId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.TopicId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSubViewpointId(this clsvRTViewpointEN objvRTViewpointEN, long? lngSubViewpointId, string strComparisonOp="")
	{
objvRTViewpointEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SubViewpointId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SubViewpointId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SubViewpointId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetTopicName(this clsvRTViewpointEN objvRTViewpointEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTViewpoint.TopicName);
}
objvRTViewpointEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.TopicName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.TopicName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.TopicName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetVersionCount(this clsvRTViewpointEN objvRTViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.VersionCount) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.VersionCount, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.VersionCount] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetCitationCount(this clsvRTViewpointEN objvRTViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.CitationCount) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.CitationCount, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.CitationCount] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetTopicContent(this clsvRTViewpointEN objvRTViewpointEN, string strTopicContent, string strComparisonOp="")
	{
objvRTViewpointEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.TopicContent) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.TopicContent, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.TopicContent] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetTopicProposePeople(this clsvRTViewpointEN objvRTViewpointEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTViewpoint.TopicProposePeople);
}
objvRTViewpointEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.TopicProposePeople) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.TopicProposePeople, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.TopicProposePeople] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetgsKnowledgeTypeName(this clsvRTViewpointEN objvRTViewpointEN, string strgsKnowledgeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strgsKnowledgeTypeName, convRTViewpoint.gsKnowledgeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeName, 50, convRTViewpoint.gsKnowledgeTypeName);
}
objvRTViewpointEN.gsKnowledgeTypeName = strgsKnowledgeTypeName; //知识类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.gsKnowledgeTypeName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.gsKnowledgeTypeName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.gsKnowledgeTypeName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetLevelName(this clsvRTViewpointEN objvRTViewpointEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convRTViewpoint.LevelName);
}
objvRTViewpointEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.LevelName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.LevelName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.LevelName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetOperationTypeName(this clsvRTViewpointEN objvRTViewpointEN, string strOperationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeName, convRTViewpoint.OperationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convRTViewpoint.OperationTypeName);
}
objvRTViewpointEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.OperationTypeName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.OperationTypeName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.OperationTypeName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSubViewpointContent(this clsvRTViewpointEN objvRTViewpointEN, string strSubViewpointContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointContent, 500, convRTViewpoint.SubViewpointContent);
}
objvRTViewpointEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SubViewpointContent) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SubViewpointContent, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SubViewpointContent] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetPaperId(this clsvRTViewpointEN objvRTViewpointEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convRTViewpoint.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convRTViewpoint.PaperId);
}
objvRTViewpointEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.PaperId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.PaperId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.PaperId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetPaperTitle(this clsvRTViewpointEN objvRTViewpointEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convRTViewpoint.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convRTViewpoint.PaperTitle);
}
objvRTViewpointEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.PaperTitle) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.PaperTitle, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.PaperTitle] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetIsSubmit(this clsvRTViewpointEN objvRTViewpointEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTViewpointEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.IsSubmit) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.IsSubmit, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.IsSubmit] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSectionId(this clsvRTViewpointEN objvRTViewpointEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convRTViewpoint.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convRTViewpoint.SectionId);
}
objvRTViewpointEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SectionId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SectionId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SectionId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSectionName(this clsvRTViewpointEN objvRTViewpointEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convRTViewpoint.SectionName);
}
objvRTViewpointEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SectionName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SectionName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SectionName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSubViewpointTypeId(this clsvRTViewpointEN objvRTViewpointEN, string strSubViewpointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubViewpointTypeId, convRTViewpoint.SubViewpointTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeId, 8, convRTViewpoint.SubViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubViewpointTypeId, 8, convRTViewpoint.SubViewpointTypeId);
}
objvRTViewpointEN.SubViewpointTypeId = strSubViewpointTypeId; //类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SubViewpointTypeId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SubViewpointTypeId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSubViewpointTypeName(this clsvRTViewpointEN objvRTViewpointEN, string strSubViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeName, 50, convRTViewpoint.SubViewpointTypeName);
}
objvRTViewpointEN.SubViewpointTypeName = strSubViewpointTypeName; //类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SubViewpointTypeName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SubViewpointTypeName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetExplainTypeId(this clsvRTViewpointEN objvRTViewpointEN, string strExplainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeId, 2, convRTViewpoint.ExplainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExplainTypeId, 2, convRTViewpoint.ExplainTypeId);
}
objvRTViewpointEN.ExplainTypeId = strExplainTypeId; //说明类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ExplainTypeId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ExplainTypeId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ExplainTypeId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetExplainTypeName(this clsvRTViewpointEN objvRTViewpointEN, string strExplainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeName, 50, convRTViewpoint.ExplainTypeName);
}
objvRTViewpointEN.ExplainTypeName = strExplainTypeName; //说明类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ExplainTypeName) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ExplainTypeName, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ExplainTypeName] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetExplainContent(this clsvRTViewpointEN objvRTViewpointEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convRTViewpoint.ExplainContent);
}
objvRTViewpointEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ExplainContent) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ExplainContent, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ExplainContent] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetIsPublic(this clsvRTViewpointEN objvRTViewpointEN, bool bolIsPublic, string strComparisonOp="")
	{
objvRTViewpointEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.IsPublic) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.IsPublic, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.IsPublic] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetLiteratureSourcesId(this clsvRTViewpointEN objvRTViewpointEN, string strLiteratureSourcesId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSourcesId, 8, convRTViewpoint.LiteratureSourcesId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureSourcesId, 8, convRTViewpoint.LiteratureSourcesId);
}
objvRTViewpointEN.LiteratureSourcesId = strLiteratureSourcesId; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.LiteratureSourcesId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.LiteratureSourcesId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.LiteratureSourcesId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetOperationTypeId(this clsvRTViewpointEN objvRTViewpointEN, string strOperationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeId, convRTViewpoint.OperationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convRTViewpoint.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convRTViewpoint.OperationTypeId);
}
objvRTViewpointEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.OperationTypeId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.OperationTypeId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.OperationTypeId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetLevelId(this clsvRTViewpointEN objvRTViewpointEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convRTViewpoint.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convRTViewpoint.LevelId);
}
objvRTViewpointEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.LevelId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.LevelId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.LevelId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetConclusion(this clsvRTViewpointEN objvRTViewpointEN, string strConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConclusion, 5000, convRTViewpoint.Conclusion);
}
objvRTViewpointEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Conclusion) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Conclusion, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Conclusion] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetNationality(this clsvRTViewpointEN objvRTViewpointEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convRTViewpoint.Nationality);
}
objvRTViewpointEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Nationality) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Nationality, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Nationality] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetAchievement(this clsvRTViewpointEN objvRTViewpointEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convRTViewpoint.Achievement);
}
objvRTViewpointEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Achievement) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Achievement, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Achievement] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetMajor(this clsvRTViewpointEN objvRTViewpointEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convRTViewpoint.Major);
}
objvRTViewpointEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Major) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Major, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Major] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetWorkUnit(this clsvRTViewpointEN objvRTViewpointEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convRTViewpoint.WorkUnit);
}
objvRTViewpointEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.WorkUnit) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.WorkUnit, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.WorkUnit] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetPageNumber(this clsvRTViewpointEN objvRTViewpointEN, int? intPageNumber, string strComparisonOp="")
	{
objvRTViewpointEN.PageNumber = intPageNumber; //页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.PageNumber) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.PageNumber, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.PageNumber] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetPdfContent(this clsvRTViewpointEN objvRTViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTViewpoint.PdfContent);
}
objvRTViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.PdfContent) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.PdfContent, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.PdfContent] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetAppraiseCount(this clsvRTViewpointEN objvRTViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.AppraiseCount) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.AppraiseCount, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.AppraiseCount] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetOkCount(this clsvRTViewpointEN objvRTViewpointEN, int? intOkCount, string strComparisonOp="")
	{
objvRTViewpointEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.OkCount) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.OkCount, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.OkCount] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetScore(this clsvRTViewpointEN objvRTViewpointEN, float? fltScore, string strComparisonOp="")
	{
objvRTViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Score) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Score, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Score] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetStuScore(this clsvRTViewpointEN objvRTViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.StuScore) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.StuScore, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.StuScore] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetTeaScore(this clsvRTViewpointEN objvRTViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.TeaScore) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.TeaScore, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.TeaScore] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetCreateDate(this clsvRTViewpointEN objvRTViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTViewpoint.CreateDate);
}
objvRTViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.CreateDate) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.CreateDate, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.CreateDate] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetShareId(this clsvRTViewpointEN objvRTViewpointEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convRTViewpoint.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTViewpoint.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTViewpoint.ShareId);
}
objvRTViewpointEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ShareId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ShareId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ShareId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetSubViewpointTypeOrderNum(this clsvRTViewpointEN objvRTViewpointEN, int? intSubViewpointTypeOrderNum, string strComparisonOp="")
	{
objvRTViewpointEN.SubViewpointTypeOrderNum = intSubViewpointTypeOrderNum; //子观点类型序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.SubViewpointTypeOrderNum) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.SubViewpointTypeOrderNum, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeOrderNum] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetProposePeople(this clsvRTViewpointEN objvRTViewpointEN, string strProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProposePeople, 50, convRTViewpoint.ProposePeople);
}
objvRTViewpointEN.ProposePeople = strProposePeople; //提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ProposePeople) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ProposePeople, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ProposePeople] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetgsKnowledgeTypeId(this clsvRTViewpointEN objvRTViewpointEN, string strgsKnowledgeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeId, 2, convRTViewpoint.gsKnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strgsKnowledgeTypeId, 2, convRTViewpoint.gsKnowledgeTypeId);
}
objvRTViewpointEN.gsKnowledgeTypeId = strgsKnowledgeTypeId; //知识类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.gsKnowledgeTypeId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.gsKnowledgeTypeId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.gsKnowledgeTypeId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetClassificationId(this clsvRTViewpointEN objvRTViewpointEN, long? lngClassificationId, string strComparisonOp="")
	{
objvRTViewpointEN.ClassificationId = lngClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ClassificationId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ClassificationId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ClassificationId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetIdCurrEduCls(this clsvRTViewpointEN objvRTViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convRTViewpoint.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTViewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTViewpoint.IdCurrEduCls);
}
objvRTViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.IdCurrEduCls) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetUpdDate(this clsvRTViewpointEN objvRTViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTViewpoint.UpdDate);
}
objvRTViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.UpdDate) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.UpdDate, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.UpdDate] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetUpdUser(this clsvRTViewpointEN objvRTViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTViewpoint.UpdUser);
}
objvRTViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.UpdUser) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.UpdUser, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.UpdUser] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetMemo(this clsvRTViewpointEN objvRTViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTViewpoint.Memo);
}
objvRTViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.Memo) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.Memo, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.Memo] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetViewPointUserId(this clsvRTViewpointEN objvRTViewpointEN, string strViewPointUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewPointUserId, 50, convRTViewpoint.ViewPointUserId);
}
objvRTViewpointEN.ViewPointUserId = strViewPointUserId; //观点用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ViewPointUserId) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ViewPointUserId, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ViewPointUserId] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetViewPointDate(this clsvRTViewpointEN objvRTViewpointEN, string strViewPointDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewPointDate, 20, convRTViewpoint.ViewPointDate);
}
objvRTViewpointEN.ViewPointDate = strViewPointDate; //观点日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.ViewPointDate) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.ViewPointDate, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.ViewPointDate] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTViewpointEN SetIsRecommend(this clsvRTViewpointEN objvRTViewpointEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvRTViewpointEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTViewpointEN.dicFldComparisonOp.ContainsKey(convRTViewpoint.IsRecommend) == false)
{
objvRTViewpointEN.dicFldComparisonOp.Add(convRTViewpoint.IsRecommend, strComparisonOp);
}
else
{
objvRTViewpointEN.dicFldComparisonOp[convRTViewpoint.IsRecommend] = strComparisonOp;
}
}
return objvRTViewpointEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTViewpointENS">源对象</param>
 /// <param name = "objvRTViewpointENT">目标对象</param>
 public static void CopyTo(this clsvRTViewpointEN objvRTViewpointENS, clsvRTViewpointEN objvRTViewpointENT)
{
try
{
objvRTViewpointENT.TopicId = objvRTViewpointENS.TopicId; //主题Id
objvRTViewpointENT.SubViewpointId = objvRTViewpointENS.SubViewpointId; //子观点Id
objvRTViewpointENT.TopicName = objvRTViewpointENS.TopicName; //栏目主题
objvRTViewpointENT.VersionCount = objvRTViewpointENS.VersionCount; //版本统计
objvRTViewpointENT.CitationCount = objvRTViewpointENS.CitationCount; //引用统计
objvRTViewpointENT.TopicContent = objvRTViewpointENS.TopicContent; //主题内容
objvRTViewpointENT.TopicProposePeople = objvRTViewpointENS.TopicProposePeople; //主题提出人
objvRTViewpointENT.gsKnowledgeTypeName = objvRTViewpointENS.gsKnowledgeTypeName; //知识类型名
objvRTViewpointENT.LevelName = objvRTViewpointENS.LevelName; //级别名称
objvRTViewpointENT.OperationTypeName = objvRTViewpointENS.OperationTypeName; //操作类型名
objvRTViewpointENT.SubViewpointContent = objvRTViewpointENS.SubViewpointContent; //详情内容
objvRTViewpointENT.PaperId = objvRTViewpointENS.PaperId; //论文Id
objvRTViewpointENT.PaperTitle = objvRTViewpointENS.PaperTitle; //论文标题
objvRTViewpointENT.IsSubmit = objvRTViewpointENS.IsSubmit; //是否提交
objvRTViewpointENT.SectionId = objvRTViewpointENS.SectionId; //节Id
objvRTViewpointENT.SectionName = objvRTViewpointENS.SectionName; //节名
objvRTViewpointENT.SubViewpointTypeId = objvRTViewpointENS.SubViewpointTypeId; //类型Id
objvRTViewpointENT.SubViewpointTypeName = objvRTViewpointENS.SubViewpointTypeName; //类型名称
objvRTViewpointENT.ExplainTypeId = objvRTViewpointENS.ExplainTypeId; //说明类型Id
objvRTViewpointENT.ExplainTypeName = objvRTViewpointENS.ExplainTypeName; //说明类型名
objvRTViewpointENT.ExplainContent = objvRTViewpointENS.ExplainContent; //说明内容
objvRTViewpointENT.IsPublic = objvRTViewpointENS.IsPublic; //是否公开
objvRTViewpointENT.LiteratureSourcesId = objvRTViewpointENS.LiteratureSourcesId; //文献来源
objvRTViewpointENT.OperationTypeId = objvRTViewpointENS.OperationTypeId; //操作类型ID
objvRTViewpointENT.LevelId = objvRTViewpointENS.LevelId; //级别Id
objvRTViewpointENT.Conclusion = objvRTViewpointENS.Conclusion; //结论
objvRTViewpointENT.Nationality = objvRTViewpointENS.Nationality; //国籍
objvRTViewpointENT.Achievement = objvRTViewpointENS.Achievement; //成就
objvRTViewpointENT.Major = objvRTViewpointENS.Major; //专业
objvRTViewpointENT.WorkUnit = objvRTViewpointENS.WorkUnit; //工作单位
objvRTViewpointENT.PageNumber = objvRTViewpointENS.PageNumber; //页码
objvRTViewpointENT.PdfContent = objvRTViewpointENS.PdfContent; //Pdf内容
objvRTViewpointENT.AppraiseCount = objvRTViewpointENS.AppraiseCount; //评论数
objvRTViewpointENT.OkCount = objvRTViewpointENS.OkCount; //点赞统计
objvRTViewpointENT.Score = objvRTViewpointENS.Score; //评分
objvRTViewpointENT.StuScore = objvRTViewpointENS.StuScore; //学生平均分
objvRTViewpointENT.TeaScore = objvRTViewpointENS.TeaScore; //教师评分
objvRTViewpointENT.CreateDate = objvRTViewpointENS.CreateDate; //建立日期
objvRTViewpointENT.ShareId = objvRTViewpointENS.ShareId; //分享Id
objvRTViewpointENT.SubViewpointTypeOrderNum = objvRTViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvRTViewpointENT.ProposePeople = objvRTViewpointENS.ProposePeople; //提出人
objvRTViewpointENT.gsKnowledgeTypeId = objvRTViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvRTViewpointENT.ClassificationId = objvRTViewpointENS.ClassificationId; //分类Id
objvRTViewpointENT.IdCurrEduCls = objvRTViewpointENS.IdCurrEduCls; //教学班流水号
objvRTViewpointENT.UpdDate = objvRTViewpointENS.UpdDate; //修改日期
objvRTViewpointENT.UpdUser = objvRTViewpointENS.UpdUser; //修改人
objvRTViewpointENT.Memo = objvRTViewpointENS.Memo; //备注
objvRTViewpointENT.ViewPointUserId = objvRTViewpointENS.ViewPointUserId; //观点用户Id
objvRTViewpointENT.ViewPointDate = objvRTViewpointENS.ViewPointDate; //观点日期
objvRTViewpointENT.IsRecommend = objvRTViewpointENS.IsRecommend; //是否推荐
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
 /// <param name = "objvRTViewpointENS">源对象</param>
 /// <returns>目标对象=>clsvRTViewpointEN:objvRTViewpointENT</returns>
 public static clsvRTViewpointEN CopyTo(this clsvRTViewpointEN objvRTViewpointENS)
{
try
{
 clsvRTViewpointEN objvRTViewpointENT = new clsvRTViewpointEN()
{
TopicId = objvRTViewpointENS.TopicId, //主题Id
SubViewpointId = objvRTViewpointENS.SubViewpointId, //子观点Id
TopicName = objvRTViewpointENS.TopicName, //栏目主题
VersionCount = objvRTViewpointENS.VersionCount, //版本统计
CitationCount = objvRTViewpointENS.CitationCount, //引用统计
TopicContent = objvRTViewpointENS.TopicContent, //主题内容
TopicProposePeople = objvRTViewpointENS.TopicProposePeople, //主题提出人
gsKnowledgeTypeName = objvRTViewpointENS.gsKnowledgeTypeName, //知识类型名
LevelName = objvRTViewpointENS.LevelName, //级别名称
OperationTypeName = objvRTViewpointENS.OperationTypeName, //操作类型名
SubViewpointContent = objvRTViewpointENS.SubViewpointContent, //详情内容
PaperId = objvRTViewpointENS.PaperId, //论文Id
PaperTitle = objvRTViewpointENS.PaperTitle, //论文标题
IsSubmit = objvRTViewpointENS.IsSubmit, //是否提交
SectionId = objvRTViewpointENS.SectionId, //节Id
SectionName = objvRTViewpointENS.SectionName, //节名
SubViewpointTypeId = objvRTViewpointENS.SubViewpointTypeId, //类型Id
SubViewpointTypeName = objvRTViewpointENS.SubViewpointTypeName, //类型名称
ExplainTypeId = objvRTViewpointENS.ExplainTypeId, //说明类型Id
ExplainTypeName = objvRTViewpointENS.ExplainTypeName, //说明类型名
ExplainContent = objvRTViewpointENS.ExplainContent, //说明内容
IsPublic = objvRTViewpointENS.IsPublic, //是否公开
LiteratureSourcesId = objvRTViewpointENS.LiteratureSourcesId, //文献来源
OperationTypeId = objvRTViewpointENS.OperationTypeId, //操作类型ID
LevelId = objvRTViewpointENS.LevelId, //级别Id
Conclusion = objvRTViewpointENS.Conclusion, //结论
Nationality = objvRTViewpointENS.Nationality, //国籍
Achievement = objvRTViewpointENS.Achievement, //成就
Major = objvRTViewpointENS.Major, //专业
WorkUnit = objvRTViewpointENS.WorkUnit, //工作单位
PageNumber = objvRTViewpointENS.PageNumber, //页码
PdfContent = objvRTViewpointENS.PdfContent, //Pdf内容
AppraiseCount = objvRTViewpointENS.AppraiseCount, //评论数
OkCount = objvRTViewpointENS.OkCount, //点赞统计
Score = objvRTViewpointENS.Score, //评分
StuScore = objvRTViewpointENS.StuScore, //学生平均分
TeaScore = objvRTViewpointENS.TeaScore, //教师评分
CreateDate = objvRTViewpointENS.CreateDate, //建立日期
ShareId = objvRTViewpointENS.ShareId, //分享Id
SubViewpointTypeOrderNum = objvRTViewpointENS.SubViewpointTypeOrderNum, //子观点类型序号
ProposePeople = objvRTViewpointENS.ProposePeople, //提出人
gsKnowledgeTypeId = objvRTViewpointENS.gsKnowledgeTypeId, //知识类型Id
ClassificationId = objvRTViewpointENS.ClassificationId, //分类Id
IdCurrEduCls = objvRTViewpointENS.IdCurrEduCls, //教学班流水号
UpdDate = objvRTViewpointENS.UpdDate, //修改日期
UpdUser = objvRTViewpointENS.UpdUser, //修改人
Memo = objvRTViewpointENS.Memo, //备注
ViewPointUserId = objvRTViewpointENS.ViewPointUserId, //观点用户Id
ViewPointDate = objvRTViewpointENS.ViewPointDate, //观点日期
IsRecommend = objvRTViewpointENS.IsRecommend, //是否推荐
};
 return objvRTViewpointENT;
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
public static void CheckProperty4Condition(this clsvRTViewpointEN objvRTViewpointEN)
{
 clsvRTViewpointBL.vRTViewpointDA.CheckProperty4Condition(objvRTViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTViewpointEN objvRTViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.TopicId) == true)
{
string strComparisonOpTopicId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.TopicId, objvRTViewpointCond.TopicId, strComparisonOpTopicId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.SubViewpointId, objvRTViewpointCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.TopicName) == true)
{
string strComparisonOpTopicName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.TopicName, objvRTViewpointCond.TopicName, strComparisonOpTopicName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.VersionCount, objvRTViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.CitationCount, objvRTViewpointCond.CitationCount, strComparisonOpCitationCount);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.TopicProposePeople, objvRTViewpointCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.gsKnowledgeTypeName) == true)
{
string strComparisonOpgsKnowledgeTypeName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.gsKnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.gsKnowledgeTypeName, objvRTViewpointCond.gsKnowledgeTypeName, strComparisonOpgsKnowledgeTypeName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.LevelName) == true)
{
string strComparisonOpLevelName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.LevelName, objvRTViewpointCond.LevelName, strComparisonOpLevelName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.OperationTypeName, objvRTViewpointCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SubViewpointContent) == true)
{
string strComparisonOpSubViewpointContent = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SubViewpointContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.SubViewpointContent, objvRTViewpointCond.SubViewpointContent, strComparisonOpSubViewpointContent);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.PaperId) == true)
{
string strComparisonOpPaperId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.PaperId, objvRTViewpointCond.PaperId, strComparisonOpPaperId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.PaperTitle, objvRTViewpointCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.IsSubmit) == true)
{
if (objvRTViewpointCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTViewpoint.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTViewpoint.IsSubmit);
}
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SectionId) == true)
{
string strComparisonOpSectionId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.SectionId, objvRTViewpointCond.SectionId, strComparisonOpSectionId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SectionName) == true)
{
string strComparisonOpSectionName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.SectionName, objvRTViewpointCond.SectionName, strComparisonOpSectionName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SubViewpointTypeId) == true)
{
string strComparisonOpSubViewpointTypeId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.SubViewpointTypeId, objvRTViewpointCond.SubViewpointTypeId, strComparisonOpSubViewpointTypeId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SubViewpointTypeName) == true)
{
string strComparisonOpSubViewpointTypeName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.SubViewpointTypeName, objvRTViewpointCond.SubViewpointTypeName, strComparisonOpSubViewpointTypeName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ExplainTypeId) == true)
{
string strComparisonOpExplainTypeId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ExplainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ExplainTypeId, objvRTViewpointCond.ExplainTypeId, strComparisonOpExplainTypeId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ExplainTypeName) == true)
{
string strComparisonOpExplainTypeName = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ExplainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ExplainTypeName, objvRTViewpointCond.ExplainTypeName, strComparisonOpExplainTypeName);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ExplainContent) == true)
{
string strComparisonOpExplainContent = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ExplainContent, objvRTViewpointCond.ExplainContent, strComparisonOpExplainContent);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.IsPublic) == true)
{
if (objvRTViewpointCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTViewpoint.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTViewpoint.IsPublic);
}
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.LiteratureSourcesId) == true)
{
string strComparisonOpLiteratureSourcesId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.LiteratureSourcesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.LiteratureSourcesId, objvRTViewpointCond.LiteratureSourcesId, strComparisonOpLiteratureSourcesId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.OperationTypeId, objvRTViewpointCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.LevelId) == true)
{
string strComparisonOpLevelId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.LevelId, objvRTViewpointCond.LevelId, strComparisonOpLevelId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Conclusion) == true)
{
string strComparisonOpConclusion = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Conclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.Conclusion, objvRTViewpointCond.Conclusion, strComparisonOpConclusion);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Nationality) == true)
{
string strComparisonOpNationality = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.Nationality, objvRTViewpointCond.Nationality, strComparisonOpNationality);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Achievement) == true)
{
string strComparisonOpAchievement = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.Achievement, objvRTViewpointCond.Achievement, strComparisonOpAchievement);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Major) == true)
{
string strComparisonOpMajor = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.Major, objvRTViewpointCond.Major, strComparisonOpMajor);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.WorkUnit, objvRTViewpointCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.PageNumber) == true)
{
string strComparisonOpPageNumber = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.PageNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.PageNumber, objvRTViewpointCond.PageNumber, strComparisonOpPageNumber);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.PdfContent, objvRTViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.AppraiseCount, objvRTViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.OkCount) == true)
{
string strComparisonOpOkCount = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.OkCount, objvRTViewpointCond.OkCount, strComparisonOpOkCount);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Score) == true)
{
string strComparisonOpScore = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.Score, objvRTViewpointCond.Score, strComparisonOpScore);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.StuScore, objvRTViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.TeaScore, objvRTViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.CreateDate, objvRTViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ShareId) == true)
{
string strComparisonOpShareId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ShareId, objvRTViewpointCond.ShareId, strComparisonOpShareId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.SubViewpointTypeOrderNum) == true)
{
string strComparisonOpSubViewpointTypeOrderNum = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.SubViewpointTypeOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.SubViewpointTypeOrderNum, objvRTViewpointCond.SubViewpointTypeOrderNum, strComparisonOpSubViewpointTypeOrderNum);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ProposePeople) == true)
{
string strComparisonOpProposePeople = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ProposePeople, objvRTViewpointCond.ProposePeople, strComparisonOpProposePeople);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.gsKnowledgeTypeId) == true)
{
string strComparisonOpgsKnowledgeTypeId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.gsKnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.gsKnowledgeTypeId, objvRTViewpointCond.gsKnowledgeTypeId, strComparisonOpgsKnowledgeTypeId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ClassificationId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTViewpoint.ClassificationId, objvRTViewpointCond.ClassificationId, strComparisonOpClassificationId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.IdCurrEduCls, objvRTViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.UpdDate, objvRTViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.UpdUser, objvRTViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.Memo) == true)
{
string strComparisonOpMemo = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.Memo, objvRTViewpointCond.Memo, strComparisonOpMemo);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ViewPointUserId) == true)
{
string strComparisonOpViewPointUserId = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ViewPointUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ViewPointUserId, objvRTViewpointCond.ViewPointUserId, strComparisonOpViewPointUserId);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.ViewPointDate) == true)
{
string strComparisonOpViewPointDate = objvRTViewpointCond.dicFldComparisonOp[convRTViewpoint.ViewPointDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTViewpoint.ViewPointDate, objvRTViewpointCond.ViewPointDate, strComparisonOpViewPointDate);
}
if (objvRTViewpointCond.IsUpdated(convRTViewpoint.IsRecommend) == true)
{
if (objvRTViewpointCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTViewpoint.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTViewpoint.IsRecommend);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTViewpoint
{
public virtual bool UpdRelaTabDate(string strTopicId,long lngSubViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTViewpoint(vRTViewpoint)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTViewpointBL
{
public static RelatedActions_vRTViewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTViewpointDA vRTViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTViewpointDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTViewpointBL()
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
if (string.IsNullOrEmpty(clsvRTViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTViewpointEN._ConnectString);
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
public static DataTable GetDataTable_vRTViewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTViewpointDA.GetDataTable_vRTViewpoint(strWhereCond);
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
objDT = vRTViewpointDA.GetDataTable(strWhereCond);
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
objDT = vRTViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = vRTViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--vRTViewpoint(vRTViewpoint)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsvRTViewpointEN objvRTViewpointEN)
{
//检测记录是否存在
string strResult = "";
strResult += objvRTViewpointEN.TopicId;
strResult += "|" + objvRTViewpointEN.SubViewpointId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTViewpointEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsvRTViewpointEN._CurrTabName);
List<clsvRTViewpointEN> arrvRTViewpointObjLstCache = GetObjLstCache();
IEnumerable <clsvRTViewpointEN> arrvRTViewpointObjLst_Sel =
arrvRTViewpointObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrvRTViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointEN> GetObjLst(string strWhereCond)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
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
public static List<clsvRTViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTViewpointEN> GetSubObjLstCache(clsvRTViewpointEN objvRTViewpointCond)
{
List<clsvRTViewpointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTViewpoint.AttributeName)
{
if (objvRTViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvRTViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointCond[strFldName].ToString());
}
else
{
if (objvRTViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTViewpointCond[strFldName]));
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
public static List<clsvRTViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
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
public static List<clsvRTViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
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
List<clsvRTViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
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
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
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
public static List<clsvRTViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
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
public static List<clsvRTViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTViewpointEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTViewpoint(ref clsvRTViewpointEN objvRTViewpointEN)
{
bool bolResult = vRTViewpointDA.GetvRTViewpoint(ref objvRTViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTViewpointEN GetObjByKeyLst(string strTopicId,long lngSubViewpointId)
{
if (strTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strTopicId,lngSubViewpointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (lngSubViewpointId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[lngSubViewpointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvRTViewpointEN objvRTViewpointEN = vRTViewpointDA.GetObjByKeyLst(strTopicId,lngSubViewpointId);
return objvRTViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTViewpointEN objvRTViewpointEN = vRTViewpointDA.GetFirstObj(strWhereCond);
 return objvRTViewpointEN;
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
public static clsvRTViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTViewpointEN objvRTViewpointEN = vRTViewpointDA.GetObjByDataRow(objRow);
 return objvRTViewpointEN;
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
public static clsvRTViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTViewpointEN objvRTViewpointEN = vRTViewpointDA.GetObjByDataRow(objRow);
 return objvRTViewpointEN;
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
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <param name = "lstvRTViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTViewpointEN GetObjByKeyLstFromList(string strTopicId,long lngSubViewpointId, List<clsvRTViewpointEN> lstvRTViewpointObjLst)
{
foreach (clsvRTViewpointEN objvRTViewpointEN in lstvRTViewpointObjLst)
{
if (objvRTViewpointEN.TopicId == strTopicId 
 && objvRTViewpointEN.SubViewpointId == lngSubViewpointId 
)
{
return objvRTViewpointEN;
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
 string strTopicId;
 try
 {
 strTopicId = new clsvRTViewpointDA().GetFirstID(strWhereCond);
 return strTopicId;
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
 arrList = vRTViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = vRTViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicId,long lngSubViewpointId)
{
//检测记录是否存在
bool bolIsExist = vRTViewpointDA.IsExist(strTopicId,lngSubViewpointId);
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
 bolIsExist = clsvRTViewpointDA.IsExistTable();
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
 bolIsExist = vRTViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTViewpointENS">源对象</param>
 /// <param name = "objvRTViewpointENT">目标对象</param>
 public static void CopyTo(clsvRTViewpointEN objvRTViewpointENS, clsvRTViewpointEN objvRTViewpointENT)
{
try
{
objvRTViewpointENT.TopicId = objvRTViewpointENS.TopicId; //主题Id
objvRTViewpointENT.SubViewpointId = objvRTViewpointENS.SubViewpointId; //子观点Id
objvRTViewpointENT.TopicName = objvRTViewpointENS.TopicName; //栏目主题
objvRTViewpointENT.VersionCount = objvRTViewpointENS.VersionCount; //版本统计
objvRTViewpointENT.CitationCount = objvRTViewpointENS.CitationCount; //引用统计
objvRTViewpointENT.TopicContent = objvRTViewpointENS.TopicContent; //主题内容
objvRTViewpointENT.TopicProposePeople = objvRTViewpointENS.TopicProposePeople; //主题提出人
objvRTViewpointENT.gsKnowledgeTypeName = objvRTViewpointENS.gsKnowledgeTypeName; //知识类型名
objvRTViewpointENT.LevelName = objvRTViewpointENS.LevelName; //级别名称
objvRTViewpointENT.OperationTypeName = objvRTViewpointENS.OperationTypeName; //操作类型名
objvRTViewpointENT.SubViewpointContent = objvRTViewpointENS.SubViewpointContent; //详情内容
objvRTViewpointENT.PaperId = objvRTViewpointENS.PaperId; //论文Id
objvRTViewpointENT.PaperTitle = objvRTViewpointENS.PaperTitle; //论文标题
objvRTViewpointENT.IsSubmit = objvRTViewpointENS.IsSubmit; //是否提交
objvRTViewpointENT.SectionId = objvRTViewpointENS.SectionId; //节Id
objvRTViewpointENT.SectionName = objvRTViewpointENS.SectionName; //节名
objvRTViewpointENT.SubViewpointTypeId = objvRTViewpointENS.SubViewpointTypeId; //类型Id
objvRTViewpointENT.SubViewpointTypeName = objvRTViewpointENS.SubViewpointTypeName; //类型名称
objvRTViewpointENT.ExplainTypeId = objvRTViewpointENS.ExplainTypeId; //说明类型Id
objvRTViewpointENT.ExplainTypeName = objvRTViewpointENS.ExplainTypeName; //说明类型名
objvRTViewpointENT.ExplainContent = objvRTViewpointENS.ExplainContent; //说明内容
objvRTViewpointENT.IsPublic = objvRTViewpointENS.IsPublic; //是否公开
objvRTViewpointENT.LiteratureSourcesId = objvRTViewpointENS.LiteratureSourcesId; //文献来源
objvRTViewpointENT.OperationTypeId = objvRTViewpointENS.OperationTypeId; //操作类型ID
objvRTViewpointENT.LevelId = objvRTViewpointENS.LevelId; //级别Id
objvRTViewpointENT.Conclusion = objvRTViewpointENS.Conclusion; //结论
objvRTViewpointENT.Nationality = objvRTViewpointENS.Nationality; //国籍
objvRTViewpointENT.Achievement = objvRTViewpointENS.Achievement; //成就
objvRTViewpointENT.Major = objvRTViewpointENS.Major; //专业
objvRTViewpointENT.WorkUnit = objvRTViewpointENS.WorkUnit; //工作单位
objvRTViewpointENT.PageNumber = objvRTViewpointENS.PageNumber; //页码
objvRTViewpointENT.PdfContent = objvRTViewpointENS.PdfContent; //Pdf内容
objvRTViewpointENT.AppraiseCount = objvRTViewpointENS.AppraiseCount; //评论数
objvRTViewpointENT.OkCount = objvRTViewpointENS.OkCount; //点赞统计
objvRTViewpointENT.Score = objvRTViewpointENS.Score; //评分
objvRTViewpointENT.StuScore = objvRTViewpointENS.StuScore; //学生平均分
objvRTViewpointENT.TeaScore = objvRTViewpointENS.TeaScore; //教师评分
objvRTViewpointENT.CreateDate = objvRTViewpointENS.CreateDate; //建立日期
objvRTViewpointENT.ShareId = objvRTViewpointENS.ShareId; //分享Id
objvRTViewpointENT.SubViewpointTypeOrderNum = objvRTViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvRTViewpointENT.ProposePeople = objvRTViewpointENS.ProposePeople; //提出人
objvRTViewpointENT.gsKnowledgeTypeId = objvRTViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvRTViewpointENT.ClassificationId = objvRTViewpointENS.ClassificationId; //分类Id
objvRTViewpointENT.IdCurrEduCls = objvRTViewpointENS.IdCurrEduCls; //教学班流水号
objvRTViewpointENT.UpdDate = objvRTViewpointENS.UpdDate; //修改日期
objvRTViewpointENT.UpdUser = objvRTViewpointENS.UpdUser; //修改人
objvRTViewpointENT.Memo = objvRTViewpointENS.Memo; //备注
objvRTViewpointENT.ViewPointUserId = objvRTViewpointENS.ViewPointUserId; //观点用户Id
objvRTViewpointENT.ViewPointDate = objvRTViewpointENS.ViewPointDate; //观点日期
objvRTViewpointENT.IsRecommend = objvRTViewpointENS.IsRecommend; //是否推荐
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
 /// <param name = "objvRTViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTViewpointEN objvRTViewpointEN)
{
try
{
objvRTViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTViewpoint.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.TopicId = objvRTViewpointEN.TopicId == "[null]" ? null :  objvRTViewpointEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTViewpoint.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SubViewpointId = objvRTViewpointEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convRTViewpoint.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.TopicName = objvRTViewpointEN.TopicName == "[null]" ? null :  objvRTViewpointEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTViewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.VersionCount = objvRTViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTViewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.CitationCount = objvRTViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTViewpoint.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.TopicContent = objvRTViewpointEN.TopicContent == "[null]" ? null :  objvRTViewpointEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTViewpoint.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.TopicProposePeople = objvRTViewpointEN.TopicProposePeople == "[null]" ? null :  objvRTViewpointEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTViewpoint.gsKnowledgeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.gsKnowledgeTypeName = objvRTViewpointEN.gsKnowledgeTypeName; //知识类型名
}
if (arrFldSet.Contains(convRTViewpoint.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.LevelName = objvRTViewpointEN.LevelName == "[null]" ? null :  objvRTViewpointEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convRTViewpoint.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.OperationTypeName = objvRTViewpointEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convRTViewpoint.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SubViewpointContent = objvRTViewpointEN.SubViewpointContent == "[null]" ? null :  objvRTViewpointEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(convRTViewpoint.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.PaperId = objvRTViewpointEN.PaperId == "[null]" ? null :  objvRTViewpointEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convRTViewpoint.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.PaperTitle = objvRTViewpointEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convRTViewpoint.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.IsSubmit = objvRTViewpointEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTViewpoint.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SectionId = objvRTViewpointEN.SectionId == "[null]" ? null :  objvRTViewpointEN.SectionId; //节Id
}
if (arrFldSet.Contains(convRTViewpoint.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SectionName = objvRTViewpointEN.SectionName == "[null]" ? null :  objvRTViewpointEN.SectionName; //节名
}
if (arrFldSet.Contains(convRTViewpoint.SubViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SubViewpointTypeId = objvRTViewpointEN.SubViewpointTypeId; //类型Id
}
if (arrFldSet.Contains(convRTViewpoint.SubViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SubViewpointTypeName = objvRTViewpointEN.SubViewpointTypeName == "[null]" ? null :  objvRTViewpointEN.SubViewpointTypeName; //类型名称
}
if (arrFldSet.Contains(convRTViewpoint.ExplainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ExplainTypeId = objvRTViewpointEN.ExplainTypeId == "[null]" ? null :  objvRTViewpointEN.ExplainTypeId; //说明类型Id
}
if (arrFldSet.Contains(convRTViewpoint.ExplainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ExplainTypeName = objvRTViewpointEN.ExplainTypeName == "[null]" ? null :  objvRTViewpointEN.ExplainTypeName; //说明类型名
}
if (arrFldSet.Contains(convRTViewpoint.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ExplainContent = objvRTViewpointEN.ExplainContent == "[null]" ? null :  objvRTViewpointEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(convRTViewpoint.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.IsPublic = objvRTViewpointEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convRTViewpoint.LiteratureSourcesId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.LiteratureSourcesId = objvRTViewpointEN.LiteratureSourcesId == "[null]" ? null :  objvRTViewpointEN.LiteratureSourcesId; //文献来源
}
if (arrFldSet.Contains(convRTViewpoint.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.OperationTypeId = objvRTViewpointEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convRTViewpoint.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.LevelId = objvRTViewpointEN.LevelId == "[null]" ? null :  objvRTViewpointEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convRTViewpoint.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Conclusion = objvRTViewpointEN.Conclusion == "[null]" ? null :  objvRTViewpointEN.Conclusion; //结论
}
if (arrFldSet.Contains(convRTViewpoint.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Nationality = objvRTViewpointEN.Nationality == "[null]" ? null :  objvRTViewpointEN.Nationality; //国籍
}
if (arrFldSet.Contains(convRTViewpoint.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Achievement = objvRTViewpointEN.Achievement == "[null]" ? null :  objvRTViewpointEN.Achievement; //成就
}
if (arrFldSet.Contains(convRTViewpoint.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Major = objvRTViewpointEN.Major == "[null]" ? null :  objvRTViewpointEN.Major; //专业
}
if (arrFldSet.Contains(convRTViewpoint.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.WorkUnit = objvRTViewpointEN.WorkUnit == "[null]" ? null :  objvRTViewpointEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convRTViewpoint.PageNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.PageNumber = objvRTViewpointEN.PageNumber; //页码
}
if (arrFldSet.Contains(convRTViewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.PdfContent = objvRTViewpointEN.PdfContent == "[null]" ? null :  objvRTViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTViewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.AppraiseCount = objvRTViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTViewpoint.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.OkCount = objvRTViewpointEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTViewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Score = objvRTViewpointEN.Score; //评分
}
if (arrFldSet.Contains(convRTViewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.StuScore = objvRTViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTViewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.TeaScore = objvRTViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTViewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.CreateDate = objvRTViewpointEN.CreateDate == "[null]" ? null :  objvRTViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTViewpoint.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ShareId = objvRTViewpointEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTViewpoint.SubViewpointTypeOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.SubViewpointTypeOrderNum = objvRTViewpointEN.SubViewpointTypeOrderNum; //子观点类型序号
}
if (arrFldSet.Contains(convRTViewpoint.ProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ProposePeople = objvRTViewpointEN.ProposePeople == "[null]" ? null :  objvRTViewpointEN.ProposePeople; //提出人
}
if (arrFldSet.Contains(convRTViewpoint.gsKnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.gsKnowledgeTypeId = objvRTViewpointEN.gsKnowledgeTypeId == "[null]" ? null :  objvRTViewpointEN.gsKnowledgeTypeId; //知识类型Id
}
if (arrFldSet.Contains(convRTViewpoint.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ClassificationId = objvRTViewpointEN.ClassificationId; //分类Id
}
if (arrFldSet.Contains(convRTViewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.IdCurrEduCls = objvRTViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTViewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.UpdDate = objvRTViewpointEN.UpdDate == "[null]" ? null :  objvRTViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTViewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.UpdUser = objvRTViewpointEN.UpdUser == "[null]" ? null :  objvRTViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTViewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.Memo = objvRTViewpointEN.Memo == "[null]" ? null :  objvRTViewpointEN.Memo; //备注
}
if (arrFldSet.Contains(convRTViewpoint.ViewPointUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ViewPointUserId = objvRTViewpointEN.ViewPointUserId == "[null]" ? null :  objvRTViewpointEN.ViewPointUserId; //观点用户Id
}
if (arrFldSet.Contains(convRTViewpoint.ViewPointDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.ViewPointDate = objvRTViewpointEN.ViewPointDate == "[null]" ? null :  objvRTViewpointEN.ViewPointDate; //观点日期
}
if (arrFldSet.Contains(convRTViewpoint.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTViewpointEN.IsRecommend = objvRTViewpointEN.IsRecommend; //是否推荐
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
 /// <param name = "objvRTViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTViewpointEN objvRTViewpointEN)
{
try
{
if (objvRTViewpointEN.TopicId == "[null]") objvRTViewpointEN.TopicId = null; //主题Id
if (objvRTViewpointEN.TopicName == "[null]") objvRTViewpointEN.TopicName = null; //栏目主题
if (objvRTViewpointEN.TopicContent == "[null]") objvRTViewpointEN.TopicContent = null; //主题内容
if (objvRTViewpointEN.TopicProposePeople == "[null]") objvRTViewpointEN.TopicProposePeople = null; //主题提出人
if (objvRTViewpointEN.LevelName == "[null]") objvRTViewpointEN.LevelName = null; //级别名称
if (objvRTViewpointEN.SubViewpointContent == "[null]") objvRTViewpointEN.SubViewpointContent = null; //详情内容
if (objvRTViewpointEN.PaperId == "[null]") objvRTViewpointEN.PaperId = null; //论文Id
if (objvRTViewpointEN.SectionId == "[null]") objvRTViewpointEN.SectionId = null; //节Id
if (objvRTViewpointEN.SectionName == "[null]") objvRTViewpointEN.SectionName = null; //节名
if (objvRTViewpointEN.SubViewpointTypeName == "[null]") objvRTViewpointEN.SubViewpointTypeName = null; //类型名称
if (objvRTViewpointEN.ExplainTypeId == "[null]") objvRTViewpointEN.ExplainTypeId = null; //说明类型Id
if (objvRTViewpointEN.ExplainTypeName == "[null]") objvRTViewpointEN.ExplainTypeName = null; //说明类型名
if (objvRTViewpointEN.ExplainContent == "[null]") objvRTViewpointEN.ExplainContent = null; //说明内容
if (objvRTViewpointEN.LiteratureSourcesId == "[null]") objvRTViewpointEN.LiteratureSourcesId = null; //文献来源
if (objvRTViewpointEN.LevelId == "[null]") objvRTViewpointEN.LevelId = null; //级别Id
if (objvRTViewpointEN.Conclusion == "[null]") objvRTViewpointEN.Conclusion = null; //结论
if (objvRTViewpointEN.Nationality == "[null]") objvRTViewpointEN.Nationality = null; //国籍
if (objvRTViewpointEN.Achievement == "[null]") objvRTViewpointEN.Achievement = null; //成就
if (objvRTViewpointEN.Major == "[null]") objvRTViewpointEN.Major = null; //专业
if (objvRTViewpointEN.WorkUnit == "[null]") objvRTViewpointEN.WorkUnit = null; //工作单位
if (objvRTViewpointEN.PdfContent == "[null]") objvRTViewpointEN.PdfContent = null; //Pdf内容
if (objvRTViewpointEN.CreateDate == "[null]") objvRTViewpointEN.CreateDate = null; //建立日期
if (objvRTViewpointEN.ProposePeople == "[null]") objvRTViewpointEN.ProposePeople = null; //提出人
if (objvRTViewpointEN.gsKnowledgeTypeId == "[null]") objvRTViewpointEN.gsKnowledgeTypeId = null; //知识类型Id
if (objvRTViewpointEN.UpdDate == "[null]") objvRTViewpointEN.UpdDate = null; //修改日期
if (objvRTViewpointEN.UpdUser == "[null]") objvRTViewpointEN.UpdUser = null; //修改人
if (objvRTViewpointEN.Memo == "[null]") objvRTViewpointEN.Memo = null; //备注
if (objvRTViewpointEN.ViewPointUserId == "[null]") objvRTViewpointEN.ViewPointUserId = null; //观点用户Id
if (objvRTViewpointEN.ViewPointDate == "[null]") objvRTViewpointEN.ViewPointDate = null; //观点日期
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
public static void CheckProperty4Condition(clsvRTViewpointEN objvRTViewpointEN)
{
 vRTViewpointDA.CheckProperty4Condition(objvRTViewpointEN);
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
if (clsRTViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTViewpointBL没有刷新缓存机制(clsRTViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSubViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSubViewpointTypeBL没有刷新缓存机制(clsSubViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperSubViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointBL没有刷新缓存机制(clsPaperSubViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExplainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExplainTypeBL没有刷新缓存机制(clsExplainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSectionBL没有刷新缓存机制(clsSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperSubViewsAttitudesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperSubViewsAttitudesBL没有刷新缓存机制(clsgs_PaperSubViewsAttitudesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicId");
//if (arrvRTViewpointObjLstCache == null)
//{
//arrvRTViewpointObjLstCache = vRTViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTViewpointEN GetObjByKeyLstCache(string strTopicId,long lngSubViewpointId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTViewpointEN._CurrTabName);
List<clsvRTViewpointEN> arrvRTViewpointObjLstCache = GetObjLstCache();
IEnumerable <clsvRTViewpointEN> arrvRTViewpointObjLst_Sel =
arrvRTViewpointObjLstCache
.Where(x=> x.TopicId == strTopicId 
 && x.SubViewpointId == lngSubViewpointId 
);
if (arrvRTViewpointObjLst_Sel.Count() == 0)
{
   clsvRTViewpointEN obj = clsvRTViewpointBL.GetObjByKeyLst(strTopicId,lngSubViewpointId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTViewpointEN> GetAllvRTViewpointObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTViewpointEN> arrvRTViewpointObjLstCache = GetObjLstCache(); 
return arrvRTViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTViewpointEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTViewpointEN._CurrTabName);
List<clsvRTViewpointEN> arrvRTViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTViewpointObjLstCache;
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
string strKey = string.Format("{0}", clsvRTViewpointEN._CurrTabName);
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
 /// 日期:2024-03-19
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicId,long lngSubViewpointId)
{
if (strInFldName != convRTViewpoint.TopicId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTViewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTViewpoint.AttributeName));
throw new Exception(strMsg);
}
var objvRTViewpoint = clsvRTViewpointBL.GetObjByKeyLstCache(strTopicId,lngSubViewpointId);
if (objvRTViewpoint == null) return "";
return objvRTViewpoint[strOutFldName].ToString();
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
int intRecCount = clsvRTViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTViewpointDA.GetRecCount();
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
int intRecCount = clsvRTViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTViewpointEN objvRTViewpointCond)
{
List<clsvRTViewpointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTViewpoint.AttributeName)
{
if (objvRTViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvRTViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointCond[strFldName].ToString());
}
else
{
if (objvRTViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTViewpointCond[strFldName]));
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
 List<string> arrList = clsvRTViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}