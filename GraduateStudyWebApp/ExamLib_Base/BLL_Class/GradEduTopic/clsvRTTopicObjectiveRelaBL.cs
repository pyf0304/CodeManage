
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTTopicObjectiveRelaBL
 表名:vRTTopicObjectiveRela(01120616)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:39
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
public static class  clsvRTTopicObjectiveRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTTopicObjectiveRelaEN GetObj(this K_mId_vRTTopicObjectiveRela myKey)
{
clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = clsvRTTopicObjectiveRelaBL.vRTTopicObjectiveRelaDA.GetObjBymId(myKey.Value);
return objvRTTopicObjectiveRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetmId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.mId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.mId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.mId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetTopicId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTTopicObjectiveRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTTopicObjectiveRela.TopicId);
}
objvRTTopicObjectiveRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.TopicId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.TopicId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.TopicId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetTopicObjectiveId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strTopicObjectiveId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicObjectiveId, convRTTopicObjectiveRela.TopicObjectiveId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicObjectiveId, 8, convRTTopicObjectiveRela.TopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicObjectiveId, 8, convRTTopicObjectiveRela.TopicObjectiveId);
}
objvRTTopicObjectiveRelaEN.TopicObjectiveId = strTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.TopicObjectiveId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.TopicObjectiveId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.TopicObjectiveId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetUpdDate(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTTopicObjectiveRela.UpdDate);
}
objvRTTopicObjectiveRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.UpdDate) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.UpdDate, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.UpdDate] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetUpdUser(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convRTTopicObjectiveRela.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTTopicObjectiveRela.UpdUser);
}
objvRTTopicObjectiveRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.UpdUser) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.UpdUser, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.UpdUser] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjectiveTypeName(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjectiveTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveTypeName, 8, convRTTopicObjectiveRela.ObjectiveTypeName);
}
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = strObjectiveTypeName; //ObjectiveTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjectiveTypeName) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjectiveTypeName, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveTypeName] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjectiveType(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, convRTTopicObjectiveRela.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, convRTTopicObjectiveRela.ObjectiveType);
}
objvRTTopicObjectiveRelaEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjectiveType) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjectiveType, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveType] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetSourceId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strSourceId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceId, 10, convRTTopicObjectiveRela.SourceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceId, 10, convRTTopicObjectiveRela.SourceId);
}
objvRTTopicObjectiveRelaEN.SourceId = strSourceId; //来源Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.SourceId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.SourceId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.SourceId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetIsSubmit(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.IsSubmit) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.IsSubmit, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.IsSubmit] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjectiveName(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, convRTTopicObjectiveRela.ObjectiveName);
}
objvRTTopicObjectiveRelaEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjectiveName) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjectiveName, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveName] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjectiveContent(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjectiveContent, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjectiveContent) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjectiveContent, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveContent] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetConclusion(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strConclusion, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.Conclusion) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.Conclusion, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.Conclusion] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetTopicContent(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.TopicContent) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.TopicContent, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.TopicContent] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetTopicName(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTTopicObjectiveRela.TopicName);
}
objvRTTopicObjectiveRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.TopicName) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.TopicName, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.TopicName] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetAppraiseCount(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.AppraiseCount) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetCitationCount(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.CitationCount) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.CitationCount, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.CitationCount] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetScore(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.Score) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.Score, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.Score] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetStuScore(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.StuScore) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.StuScore, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.StuScore] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetTeaScore(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.TeaScore) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.TeaScore, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.TeaScore] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjDate(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjDate, 20, convRTTopicObjectiveRela.ObjDate);
}
objvRTTopicObjectiveRelaEN.ObjDate = strObjDate; //ObjDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjDate) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjDate, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjDate] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetObjUserId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strObjUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjUserId, 50, convRTTopicObjectiveRela.ObjUserId);
}
objvRTTopicObjectiveRelaEN.ObjUserId = strObjUserId; //ObjUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ObjUserId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ObjUserId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ObjUserId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetIdCurrEduCls(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTTopicObjectiveRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTTopicObjectiveRela.IdCurrEduCls);
}
objvRTTopicObjectiveRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.IdCurrEduCls) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetPdfContent(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTTopicObjectiveRela.PdfContent);
}
objvRTTopicObjectiveRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.PdfContent) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.PdfContent, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.PdfContent] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetPdfPageNum(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.PdfPageNum) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.PdfPageNum, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.PdfPageNum] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetOkCount(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.OkCount) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.OkCount, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.OkCount] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetVersionCount(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTTopicObjectiveRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.VersionCount) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.VersionCount, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.VersionCount] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetCreateDate(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTTopicObjectiveRela.CreateDate);
}
objvRTTopicObjectiveRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.CreateDate) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.CreateDate, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.CreateDate] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetShareId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTTopicObjectiveRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTTopicObjectiveRela.ShareId);
}
objvRTTopicObjectiveRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ShareId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ShareId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ShareId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTTopicObjectiveRelaEN SetClassificationId(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN, string strClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationId, 10, convRTTopicObjectiveRela.ClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassificationId, 10, convRTTopicObjectiveRela.ClassificationId);
}
objvRTTopicObjectiveRelaEN.ClassificationId = strClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convRTTopicObjectiveRela.ClassificationId) == false)
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp.Add(convRTTopicObjectiveRela.ClassificationId, strComparisonOp);
}
else
{
objvRTTopicObjectiveRelaEN.dicFldComparisonOp[convRTTopicObjectiveRela.ClassificationId] = strComparisonOp;
}
}
return objvRTTopicObjectiveRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvRTTopicObjectiveRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENS, clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENT)
{
try
{
objvRTTopicObjectiveRelaENT.mId = objvRTTopicObjectiveRelaENS.mId; //mId
objvRTTopicObjectiveRelaENT.TopicId = objvRTTopicObjectiveRelaENS.TopicId; //主题Id
objvRTTopicObjectiveRelaENT.TopicObjectiveId = objvRTTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvRTTopicObjectiveRelaENT.UpdDate = objvRTTopicObjectiveRelaENS.UpdDate; //修改日期
objvRTTopicObjectiveRelaENT.UpdUser = objvRTTopicObjectiveRelaENS.UpdUser; //修改人
objvRTTopicObjectiveRelaENT.ObjectiveTypeName = objvRTTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvRTTopicObjectiveRelaENT.ObjectiveType = objvRTTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvRTTopicObjectiveRelaENT.SourceId = objvRTTopicObjectiveRelaENS.SourceId; //来源Id
objvRTTopicObjectiveRelaENT.IsSubmit = objvRTTopicObjectiveRelaENS.IsSubmit; //是否提交
objvRTTopicObjectiveRelaENT.ObjectiveName = objvRTTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvRTTopicObjectiveRelaENT.ObjectiveContent = objvRTTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvRTTopicObjectiveRelaENT.Conclusion = objvRTTopicObjectiveRelaENS.Conclusion; //结论
objvRTTopicObjectiveRelaENT.TopicContent = objvRTTopicObjectiveRelaENS.TopicContent; //主题内容
objvRTTopicObjectiveRelaENT.TopicName = objvRTTopicObjectiveRelaENS.TopicName; //栏目主题
objvRTTopicObjectiveRelaENT.AppraiseCount = objvRTTopicObjectiveRelaENS.AppraiseCount; //评论数
objvRTTopicObjectiveRelaENT.CitationCount = objvRTTopicObjectiveRelaENS.CitationCount; //引用统计
objvRTTopicObjectiveRelaENT.Score = objvRTTopicObjectiveRelaENS.Score; //评分
objvRTTopicObjectiveRelaENT.StuScore = objvRTTopicObjectiveRelaENS.StuScore; //学生平均分
objvRTTopicObjectiveRelaENT.TeaScore = objvRTTopicObjectiveRelaENS.TeaScore; //教师评分
objvRTTopicObjectiveRelaENT.ObjDate = objvRTTopicObjectiveRelaENS.ObjDate; //ObjDate
objvRTTopicObjectiveRelaENT.ObjUserId = objvRTTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvRTTopicObjectiveRelaENT.IdCurrEduCls = objvRTTopicObjectiveRelaENS.IdCurrEduCls; //教学班流水号
objvRTTopicObjectiveRelaENT.PdfContent = objvRTTopicObjectiveRelaENS.PdfContent; //Pdf内容
objvRTTopicObjectiveRelaENT.PdfPageNum = objvRTTopicObjectiveRelaENS.PdfPageNum; //Pdf页码
objvRTTopicObjectiveRelaENT.OkCount = objvRTTopicObjectiveRelaENS.OkCount; //点赞统计
objvRTTopicObjectiveRelaENT.VersionCount = objvRTTopicObjectiveRelaENS.VersionCount; //版本统计
objvRTTopicObjectiveRelaENT.CreateDate = objvRTTopicObjectiveRelaENS.CreateDate; //建立日期
objvRTTopicObjectiveRelaENT.ShareId = objvRTTopicObjectiveRelaENS.ShareId; //分享Id
objvRTTopicObjectiveRelaENT.ClassificationId = objvRTTopicObjectiveRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTTopicObjectiveRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTTopicObjectiveRelaEN:objvRTTopicObjectiveRelaENT</returns>
 public static clsvRTTopicObjectiveRelaEN CopyTo(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENS)
{
try
{
 clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENT = new clsvRTTopicObjectiveRelaEN()
{
mId = objvRTTopicObjectiveRelaENS.mId, //mId
TopicId = objvRTTopicObjectiveRelaENS.TopicId, //主题Id
TopicObjectiveId = objvRTTopicObjectiveRelaENS.TopicObjectiveId, //客观Id
UpdDate = objvRTTopicObjectiveRelaENS.UpdDate, //修改日期
UpdUser = objvRTTopicObjectiveRelaENS.UpdUser, //修改人
ObjectiveTypeName = objvRTTopicObjectiveRelaENS.ObjectiveTypeName, //ObjectiveTypeName
ObjectiveType = objvRTTopicObjectiveRelaENS.ObjectiveType, //客观类型
SourceId = objvRTTopicObjectiveRelaENS.SourceId, //来源Id
IsSubmit = objvRTTopicObjectiveRelaENS.IsSubmit, //是否提交
ObjectiveName = objvRTTopicObjectiveRelaENS.ObjectiveName, //客观名称
ObjectiveContent = objvRTTopicObjectiveRelaENS.ObjectiveContent, //客观内容
Conclusion = objvRTTopicObjectiveRelaENS.Conclusion, //结论
TopicContent = objvRTTopicObjectiveRelaENS.TopicContent, //主题内容
TopicName = objvRTTopicObjectiveRelaENS.TopicName, //栏目主题
AppraiseCount = objvRTTopicObjectiveRelaENS.AppraiseCount, //评论数
CitationCount = objvRTTopicObjectiveRelaENS.CitationCount, //引用统计
Score = objvRTTopicObjectiveRelaENS.Score, //评分
StuScore = objvRTTopicObjectiveRelaENS.StuScore, //学生平均分
TeaScore = objvRTTopicObjectiveRelaENS.TeaScore, //教师评分
ObjDate = objvRTTopicObjectiveRelaENS.ObjDate, //ObjDate
ObjUserId = objvRTTopicObjectiveRelaENS.ObjUserId, //ObjUserId
IdCurrEduCls = objvRTTopicObjectiveRelaENS.IdCurrEduCls, //教学班流水号
PdfContent = objvRTTopicObjectiveRelaENS.PdfContent, //Pdf内容
PdfPageNum = objvRTTopicObjectiveRelaENS.PdfPageNum, //Pdf页码
OkCount = objvRTTopicObjectiveRelaENS.OkCount, //点赞统计
VersionCount = objvRTTopicObjectiveRelaENS.VersionCount, //版本统计
CreateDate = objvRTTopicObjectiveRelaENS.CreateDate, //建立日期
ShareId = objvRTTopicObjectiveRelaENS.ShareId, //分享Id
ClassificationId = objvRTTopicObjectiveRelaENS.ClassificationId, //分类Id
};
 return objvRTTopicObjectiveRelaENT;
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
public static void CheckProperty4Condition(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
 clsvRTTopicObjectiveRelaBL.vRTTopicObjectiveRelaDA.CheckProperty4Condition(objvRTTopicObjectiveRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.mId) == true)
{
string strComparisonOpmId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.mId, objvRTTopicObjectiveRelaCond.mId, strComparisonOpmId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.TopicId, objvRTTopicObjectiveRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.TopicObjectiveId) == true)
{
string strComparisonOpTopicObjectiveId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.TopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.TopicObjectiveId, objvRTTopicObjectiveRelaCond.TopicObjectiveId, strComparisonOpTopicObjectiveId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.UpdDate, objvRTTopicObjectiveRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.UpdUser, objvRTTopicObjectiveRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ObjectiveTypeName) == true)
{
string strComparisonOpObjectiveTypeName = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ObjectiveTypeName, objvRTTopicObjectiveRelaCond.ObjectiveTypeName, strComparisonOpObjectiveTypeName);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ObjectiveType, objvRTTopicObjectiveRelaCond.ObjectiveType, strComparisonOpObjectiveType);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.SourceId) == true)
{
string strComparisonOpSourceId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.SourceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.SourceId, objvRTTopicObjectiveRelaCond.SourceId, strComparisonOpSourceId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.IsSubmit) == true)
{
if (objvRTTopicObjectiveRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTTopicObjectiveRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTTopicObjectiveRela.IsSubmit);
}
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ObjectiveName, objvRTTopicObjectiveRelaCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.TopicName, objvRTTopicObjectiveRelaCond.TopicName, strComparisonOpTopicName);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.AppraiseCount, objvRTTopicObjectiveRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.CitationCount, objvRTTopicObjectiveRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.Score) == true)
{
string strComparisonOpScore = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.Score, objvRTTopicObjectiveRelaCond.Score, strComparisonOpScore);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.StuScore, objvRTTopicObjectiveRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.TeaScore, objvRTTopicObjectiveRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ObjDate) == true)
{
string strComparisonOpObjDate = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ObjDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ObjDate, objvRTTopicObjectiveRelaCond.ObjDate, strComparisonOpObjDate);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ObjUserId) == true)
{
string strComparisonOpObjUserId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ObjUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ObjUserId, objvRTTopicObjectiveRelaCond.ObjUserId, strComparisonOpObjUserId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.IdCurrEduCls, objvRTTopicObjectiveRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.PdfContent, objvRTTopicObjectiveRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.PdfPageNum, objvRTTopicObjectiveRelaCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.OkCount, objvRTTopicObjectiveRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTTopicObjectiveRela.VersionCount, objvRTTopicObjectiveRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.CreateDate, objvRTTopicObjectiveRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ShareId) == true)
{
string strComparisonOpShareId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ShareId, objvRTTopicObjectiveRelaCond.ShareId, strComparisonOpShareId);
}
if (objvRTTopicObjectiveRelaCond.IsUpdated(convRTTopicObjectiveRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[convRTTopicObjectiveRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTTopicObjectiveRela.ClassificationId, objvRTTopicObjectiveRelaCond.ClassificationId, strComparisonOpClassificationId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTTopicObjectiveRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTTopicObjectiveRela(vRTTopicObjectiveRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTTopicObjectiveRelaBL
{
public static RelatedActions_vRTTopicObjectiveRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTTopicObjectiveRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTTopicObjectiveRelaDA vRTTopicObjectiveRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTTopicObjectiveRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTTopicObjectiveRelaBL()
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
if (string.IsNullOrEmpty(clsvRTTopicObjectiveRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTTopicObjectiveRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTTopicObjectiveRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTTopicObjectiveRelaDA.GetDataTable_vRTTopicObjectiveRela(strWhereCond);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTTopicObjectiveRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
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
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTTopicObjectiveRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTTopicObjectiveRelaEN._CurrTabName);
List<clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLst_Sel =
arrvRTTopicObjectiveRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTTopicObjectiveRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTTopicObjectiveRelaEN> GetSubObjLstCache(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaCond)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTTopicObjectiveRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTTopicObjectiveRela.AttributeName)
{
if (objvRTTopicObjectiveRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTTopicObjectiveRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTTopicObjectiveRelaCond[strFldName].ToString());
}
else
{
if (objvRTTopicObjectiveRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTTopicObjectiveRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTTopicObjectiveRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTTopicObjectiveRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTTopicObjectiveRelaCond[strFldName]));
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
List<clsvRTTopicObjectiveRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTTopicObjectiveRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTTopicObjectiveRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
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
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
public static List<clsvRTTopicObjectiveRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTTopicObjectiveRela(ref clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
bool bolResult = vRTTopicObjectiveRelaDA.GetvRTTopicObjectiveRela(ref objvRTTopicObjectiveRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTTopicObjectiveRelaEN GetObjBymId(long lngmId)
{
clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = vRTTopicObjectiveRelaDA.GetObjBymId(lngmId);
return objvRTTopicObjectiveRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTTopicObjectiveRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = vRTTopicObjectiveRelaDA.GetFirstObj(strWhereCond);
 return objvRTTopicObjectiveRelaEN;
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
public static clsvRTTopicObjectiveRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = vRTTopicObjectiveRelaDA.GetObjByDataRow(objRow);
 return objvRTTopicObjectiveRelaEN;
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
public static clsvRTTopicObjectiveRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = vRTTopicObjectiveRelaDA.GetObjByDataRow(objRow);
 return objvRTTopicObjectiveRelaEN;
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
 /// <param name = "lstvRTTopicObjectiveRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTTopicObjectiveRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTTopicObjectiveRelaEN> lstvRTTopicObjectiveRelaObjLst)
{
foreach (clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN in lstvRTTopicObjectiveRelaObjLst)
{
if (objvRTTopicObjectiveRelaEN.mId == lngmId)
{
return objvRTTopicObjectiveRelaEN;
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
 lngmId = new clsvRTTopicObjectiveRelaDA().GetFirstID(strWhereCond);
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
 arrList = vRTTopicObjectiveRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTTopicObjectiveRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vRTTopicObjectiveRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTTopicObjectiveRelaDA.IsExistTable();
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
 bolIsExist = vRTTopicObjectiveRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvRTTopicObjectiveRelaENT">目标对象</param>
 public static void CopyTo(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENS, clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENT)
{
try
{
objvRTTopicObjectiveRelaENT.mId = objvRTTopicObjectiveRelaENS.mId; //mId
objvRTTopicObjectiveRelaENT.TopicId = objvRTTopicObjectiveRelaENS.TopicId; //主题Id
objvRTTopicObjectiveRelaENT.TopicObjectiveId = objvRTTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvRTTopicObjectiveRelaENT.UpdDate = objvRTTopicObjectiveRelaENS.UpdDate; //修改日期
objvRTTopicObjectiveRelaENT.UpdUser = objvRTTopicObjectiveRelaENS.UpdUser; //修改人
objvRTTopicObjectiveRelaENT.ObjectiveTypeName = objvRTTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvRTTopicObjectiveRelaENT.ObjectiveType = objvRTTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvRTTopicObjectiveRelaENT.SourceId = objvRTTopicObjectiveRelaENS.SourceId; //来源Id
objvRTTopicObjectiveRelaENT.IsSubmit = objvRTTopicObjectiveRelaENS.IsSubmit; //是否提交
objvRTTopicObjectiveRelaENT.ObjectiveName = objvRTTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvRTTopicObjectiveRelaENT.ObjectiveContent = objvRTTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvRTTopicObjectiveRelaENT.Conclusion = objvRTTopicObjectiveRelaENS.Conclusion; //结论
objvRTTopicObjectiveRelaENT.TopicContent = objvRTTopicObjectiveRelaENS.TopicContent; //主题内容
objvRTTopicObjectiveRelaENT.TopicName = objvRTTopicObjectiveRelaENS.TopicName; //栏目主题
objvRTTopicObjectiveRelaENT.AppraiseCount = objvRTTopicObjectiveRelaENS.AppraiseCount; //评论数
objvRTTopicObjectiveRelaENT.CitationCount = objvRTTopicObjectiveRelaENS.CitationCount; //引用统计
objvRTTopicObjectiveRelaENT.Score = objvRTTopicObjectiveRelaENS.Score; //评分
objvRTTopicObjectiveRelaENT.StuScore = objvRTTopicObjectiveRelaENS.StuScore; //学生平均分
objvRTTopicObjectiveRelaENT.TeaScore = objvRTTopicObjectiveRelaENS.TeaScore; //教师评分
objvRTTopicObjectiveRelaENT.ObjDate = objvRTTopicObjectiveRelaENS.ObjDate; //ObjDate
objvRTTopicObjectiveRelaENT.ObjUserId = objvRTTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvRTTopicObjectiveRelaENT.IdCurrEduCls = objvRTTopicObjectiveRelaENS.IdCurrEduCls; //教学班流水号
objvRTTopicObjectiveRelaENT.PdfContent = objvRTTopicObjectiveRelaENS.PdfContent; //Pdf内容
objvRTTopicObjectiveRelaENT.PdfPageNum = objvRTTopicObjectiveRelaENS.PdfPageNum; //Pdf页码
objvRTTopicObjectiveRelaENT.OkCount = objvRTTopicObjectiveRelaENS.OkCount; //点赞统计
objvRTTopicObjectiveRelaENT.VersionCount = objvRTTopicObjectiveRelaENS.VersionCount; //版本统计
objvRTTopicObjectiveRelaENT.CreateDate = objvRTTopicObjectiveRelaENS.CreateDate; //建立日期
objvRTTopicObjectiveRelaENT.ShareId = objvRTTopicObjectiveRelaENS.ShareId; //分享Id
objvRTTopicObjectiveRelaENT.ClassificationId = objvRTTopicObjectiveRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTTopicObjectiveRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
try
{
objvRTTopicObjectiveRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTTopicObjectiveRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTTopicObjectiveRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.mId = objvRTTopicObjectiveRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.TopicId = objvRTTopicObjectiveRelaEN.TopicId == "[null]" ? null :  objvRTTopicObjectiveRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.TopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objvRTTopicObjectiveRelaEN.TopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.UpdDate = objvRTTopicObjectiveRelaEN.UpdDate == "[null]" ? null :  objvRTTopicObjectiveRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.UpdUser = objvRTTopicObjectiveRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjectiveTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objvRTTopicObjectiveRelaEN.ObjectiveTypeName == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjectiveTypeName; //ObjectiveTypeName
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjectiveType = objvRTTopicObjectiveRelaEN.ObjectiveType == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.SourceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.SourceId = objvRTTopicObjectiveRelaEN.SourceId == "[null]" ? null :  objvRTTopicObjectiveRelaEN.SourceId; //来源Id
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.IsSubmit = objvRTTopicObjectiveRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjectiveName = objvRTTopicObjectiveRelaEN.ObjectiveName == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjectiveContent = objvRTTopicObjectiveRelaEN.ObjectiveContent == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.Conclusion = objvRTTopicObjectiveRelaEN.Conclusion == "[null]" ? null :  objvRTTopicObjectiveRelaEN.Conclusion; //结论
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.TopicContent = objvRTTopicObjectiveRelaEN.TopicContent == "[null]" ? null :  objvRTTopicObjectiveRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.TopicName = objvRTTopicObjectiveRelaEN.TopicName == "[null]" ? null :  objvRTTopicObjectiveRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.AppraiseCount = objvRTTopicObjectiveRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.CitationCount = objvRTTopicObjectiveRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.Score = objvRTTopicObjectiveRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.StuScore = objvRTTopicObjectiveRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.TeaScore = objvRTTopicObjectiveRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjDate = objvRTTopicObjectiveRelaEN.ObjDate == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjDate; //ObjDate
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ObjUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ObjUserId = objvRTTopicObjectiveRelaEN.ObjUserId == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ObjUserId; //ObjUserId
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objvRTTopicObjectiveRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTTopicObjectiveRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.PdfContent = objvRTTopicObjectiveRelaEN.PdfContent == "[null]" ? null :  objvRTTopicObjectiveRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.PdfPageNum = objvRTTopicObjectiveRelaEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.OkCount = objvRTTopicObjectiveRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.VersionCount = objvRTTopicObjectiveRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.CreateDate = objvRTTopicObjectiveRelaEN.CreateDate == "[null]" ? null :  objvRTTopicObjectiveRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ShareId = objvRTTopicObjectiveRelaEN.ShareId == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTTopicObjectiveRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTTopicObjectiveRelaEN.ClassificationId = objvRTTopicObjectiveRelaEN.ClassificationId == "[null]" ? null :  objvRTTopicObjectiveRelaEN.ClassificationId; //分类Id
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
 /// <param name = "objvRTTopicObjectiveRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
try
{
if (objvRTTopicObjectiveRelaEN.TopicId == "[null]") objvRTTopicObjectiveRelaEN.TopicId = null; //主题Id
if (objvRTTopicObjectiveRelaEN.UpdDate == "[null]") objvRTTopicObjectiveRelaEN.UpdDate = null; //修改日期
if (objvRTTopicObjectiveRelaEN.ObjectiveTypeName == "[null]") objvRTTopicObjectiveRelaEN.ObjectiveTypeName = null; //ObjectiveTypeName
if (objvRTTopicObjectiveRelaEN.ObjectiveType == "[null]") objvRTTopicObjectiveRelaEN.ObjectiveType = null; //客观类型
if (objvRTTopicObjectiveRelaEN.SourceId == "[null]") objvRTTopicObjectiveRelaEN.SourceId = null; //来源Id
if (objvRTTopicObjectiveRelaEN.ObjectiveName == "[null]") objvRTTopicObjectiveRelaEN.ObjectiveName = null; //客观名称
if (objvRTTopicObjectiveRelaEN.ObjectiveContent == "[null]") objvRTTopicObjectiveRelaEN.ObjectiveContent = null; //客观内容
if (objvRTTopicObjectiveRelaEN.Conclusion == "[null]") objvRTTopicObjectiveRelaEN.Conclusion = null; //结论
if (objvRTTopicObjectiveRelaEN.TopicContent == "[null]") objvRTTopicObjectiveRelaEN.TopicContent = null; //主题内容
if (objvRTTopicObjectiveRelaEN.TopicName == "[null]") objvRTTopicObjectiveRelaEN.TopicName = null; //栏目主题
if (objvRTTopicObjectiveRelaEN.ObjDate == "[null]") objvRTTopicObjectiveRelaEN.ObjDate = null; //ObjDate
if (objvRTTopicObjectiveRelaEN.ObjUserId == "[null]") objvRTTopicObjectiveRelaEN.ObjUserId = null; //ObjUserId
if (objvRTTopicObjectiveRelaEN.IdCurrEduCls == "[null]") objvRTTopicObjectiveRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTTopicObjectiveRelaEN.PdfContent == "[null]") objvRTTopicObjectiveRelaEN.PdfContent = null; //Pdf内容
if (objvRTTopicObjectiveRelaEN.CreateDate == "[null]") objvRTTopicObjectiveRelaEN.CreateDate = null; //建立日期
if (objvRTTopicObjectiveRelaEN.ShareId == "[null]") objvRTTopicObjectiveRelaEN.ShareId = null; //分享Id
if (objvRTTopicObjectiveRelaEN.ClassificationId == "[null]") objvRTTopicObjectiveRelaEN.ClassificationId = null; //分类Id
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
public static void CheckProperty4Condition(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
 vRTTopicObjectiveRelaDA.CheckProperty4Condition(objvRTTopicObjectiveRelaEN);
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
if (clsRTTopicObjectiveRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTTopicObjectiveRelaBL没有刷新缓存机制(clsRTTopicObjectiveRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicObjectiveBL没有刷新缓存机制(clsTopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTTopicObjectiveRelaObjLstCache == null)
//{
//arrvRTTopicObjectiveRelaObjLstCache = vRTTopicObjectiveRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTTopicObjectiveRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTTopicObjectiveRelaEN._CurrTabName);
List<clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLst_Sel =
arrvRTTopicObjectiveRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTTopicObjectiveRelaObjLst_Sel.Count() == 0)
{
   clsvRTTopicObjectiveRelaEN obj = clsvRTTopicObjectiveRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTTopicObjectiveRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetAllvRTTopicObjectiveRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLstCache = GetObjLstCache(); 
return arrvRTTopicObjectiveRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTTopicObjectiveRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTTopicObjectiveRelaEN._CurrTabName);
List<clsvRTTopicObjectiveRelaEN> arrvRTTopicObjectiveRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTTopicObjectiveRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvRTTopicObjectiveRelaEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convRTTopicObjectiveRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTTopicObjectiveRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTTopicObjectiveRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTTopicObjectiveRela = clsvRTTopicObjectiveRelaBL.GetObjBymIdCache(lngmId);
if (objvRTTopicObjectiveRela == null) return "";
return objvRTTopicObjectiveRela[strOutFldName].ToString();
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
int intRecCount = clsvRTTopicObjectiveRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTTopicObjectiveRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTTopicObjectiveRelaDA.GetRecCount();
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
int intRecCount = clsvRTTopicObjectiveRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaCond)
{
List<clsvRTTopicObjectiveRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTTopicObjectiveRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTTopicObjectiveRela.AttributeName)
{
if (objvRTTopicObjectiveRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTTopicObjectiveRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTTopicObjectiveRelaCond[strFldName].ToString());
}
else
{
if (objvRTTopicObjectiveRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTTopicObjectiveRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTTopicObjectiveRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTTopicObjectiveRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTTopicObjectiveRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTTopicObjectiveRelaCond[strFldName]));
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
 List<string> arrList = clsvRTTopicObjectiveRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTTopicObjectiveRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTTopicObjectiveRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}