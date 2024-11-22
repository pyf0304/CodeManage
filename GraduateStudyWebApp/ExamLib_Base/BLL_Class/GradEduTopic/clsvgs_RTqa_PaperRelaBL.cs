
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_RTqa_PaperRelaBL
 表名:vgs_RTqa_PaperRela(01120695)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:26
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
public static class  clsvgs_RTqa_PaperRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_RTqa_PaperRelaEN GetObj(this K_mId_vgs_RTqa_PaperRela myKey)
{
clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = clsvgs_RTqa_PaperRelaBL.vgs_RTqa_PaperRelaDA.GetObjBymId(myKey.Value);
return objvgs_RTqa_PaperRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetmId(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.mId) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.mId, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.mId] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetTopicId(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicId, convgs_RTqa_PaperRela.TopicId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_RTqa_PaperRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_RTqa_PaperRela.TopicId);
}
objvgs_RTqa_PaperRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.TopicId) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.TopicId, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.TopicId] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetTopicName(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_RTqa_PaperRela.TopicName);
}
objvgs_RTqa_PaperRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.TopicName) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.TopicName, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.TopicName] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetIdCurrEduCls(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_RTqa_PaperRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_RTqa_PaperRela.IdCurrEduCls);
}
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.IdCurrEduCls) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetQaPaperId(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strQaPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQaPaperId, convgs_RTqa_PaperRela.QaPaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convgs_RTqa_PaperRela.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convgs_RTqa_PaperRela.QaPaperId);
}
objvgs_RTqa_PaperRelaEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.QaPaperId) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.QaPaperId, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.QaPaperId] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetPaperId(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_RTqa_PaperRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_RTqa_PaperRela.PaperId);
}
objvgs_RTqa_PaperRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.PaperId) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.PaperId, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.PaperId] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetQuestionsCount(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, int? intQuestionsCount, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.QuestionsCount) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.QuestionsCount, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.QuestionsCount] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetIsPublic(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, bool bolIsPublic, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.IsPublic) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.IsPublic, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.IsPublic] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetIsSubmit(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.IsSubmit) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetPaperTitle(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_RTqa_PaperRela.PaperTitle);
}
objvgs_RTqa_PaperRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.PaperTitle) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetAttachmentCount(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.AttachmentCount) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.AttachmentCount, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.AttachmentCount] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetAnswerCount(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, int? intAnswerCount, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.AnswerCount) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.AnswerCount, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.AnswerCount] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetShareId(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_RTqa_PaperRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_RTqa_PaperRela.ShareId);
}
objvgs_RTqa_PaperRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.ShareId) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.ShareId, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.ShareId] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetTagsCount(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, int? intTagsCount, string strComparisonOp="")
	{
objvgs_RTqa_PaperRelaEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.TagsCount) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.TagsCount, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.TagsCount] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetUpdDate(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_RTqa_PaperRela.UpdDate);
}
objvgs_RTqa_PaperRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.UpdDate) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.UpdDate, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.UpdDate] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetUpdUser(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_RTqa_PaperRela.UpdUser);
}
objvgs_RTqa_PaperRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.UpdUser) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.UpdUser, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.UpdUser] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetMemo(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_RTqa_PaperRela.Memo);
}
objvgs_RTqa_PaperRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.Memo) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.Memo, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.Memo] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetqaUser(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strqaUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqaUser, 20, convgs_RTqa_PaperRela.qaUser);
}
objvgs_RTqa_PaperRelaEN.qaUser = strqaUser; //qaUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.qaUser) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.qaUser, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.qaUser] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetqaDate(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strqaDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqaDate, 20, convgs_RTqa_PaperRela.qaDate);
}
objvgs_RTqa_PaperRelaEN.qaDate = strqaDate; //qaDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.qaDate) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.qaDate, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.qaDate] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_RTqa_PaperRelaEN SetqaUserName(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN, string strqaUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strqaUserName, 30, convgs_RTqa_PaperRela.qaUserName);
}
objvgs_RTqa_PaperRelaEN.qaUserName = strqaUserName; //qaUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.ContainsKey(convgs_RTqa_PaperRela.qaUserName) == false)
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp.Add(convgs_RTqa_PaperRela.qaUserName, strComparisonOp);
}
else
{
objvgs_RTqa_PaperRelaEN.dicFldComparisonOp[convgs_RTqa_PaperRela.qaUserName] = strComparisonOp;
}
}
return objvgs_RTqa_PaperRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaENS">源对象</param>
 /// <param name = "objvgs_RTqa_PaperRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENS, clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENT)
{
try
{
objvgs_RTqa_PaperRelaENT.mId = objvgs_RTqa_PaperRelaENS.mId; //mId
objvgs_RTqa_PaperRelaENT.TopicId = objvgs_RTqa_PaperRelaENS.TopicId; //主题Id
objvgs_RTqa_PaperRelaENT.TopicName = objvgs_RTqa_PaperRelaENS.TopicName; //栏目主题
objvgs_RTqa_PaperRelaENT.IdCurrEduCls = objvgs_RTqa_PaperRelaENS.IdCurrEduCls; //教学班流水号
objvgs_RTqa_PaperRelaENT.QaPaperId = objvgs_RTqa_PaperRelaENS.QaPaperId; //论文答疑Id
objvgs_RTqa_PaperRelaENT.PaperId = objvgs_RTqa_PaperRelaENS.PaperId; //论文Id
objvgs_RTqa_PaperRelaENT.QuestionsCount = objvgs_RTqa_PaperRelaENS.QuestionsCount; //提问计数
objvgs_RTqa_PaperRelaENT.IsPublic = objvgs_RTqa_PaperRelaENS.IsPublic; //是否公开
objvgs_RTqa_PaperRelaENT.IsSubmit = objvgs_RTqa_PaperRelaENS.IsSubmit; //是否提交
objvgs_RTqa_PaperRelaENT.PaperTitle = objvgs_RTqa_PaperRelaENS.PaperTitle; //论文标题
objvgs_RTqa_PaperRelaENT.AttachmentCount = objvgs_RTqa_PaperRelaENS.AttachmentCount; //附件计数
objvgs_RTqa_PaperRelaENT.AnswerCount = objvgs_RTqa_PaperRelaENS.AnswerCount; //回答计数
objvgs_RTqa_PaperRelaENT.ShareId = objvgs_RTqa_PaperRelaENS.ShareId; //分享Id
objvgs_RTqa_PaperRelaENT.TagsCount = objvgs_RTqa_PaperRelaENS.TagsCount; //论文标注数
objvgs_RTqa_PaperRelaENT.UpdDate = objvgs_RTqa_PaperRelaENS.UpdDate; //修改日期
objvgs_RTqa_PaperRelaENT.UpdUser = objvgs_RTqa_PaperRelaENS.UpdUser; //修改人
objvgs_RTqa_PaperRelaENT.Memo = objvgs_RTqa_PaperRelaENS.Memo; //备注
objvgs_RTqa_PaperRelaENT.qaUser = objvgs_RTqa_PaperRelaENS.qaUser; //qaUser
objvgs_RTqa_PaperRelaENT.qaDate = objvgs_RTqa_PaperRelaENS.qaDate; //qaDate
objvgs_RTqa_PaperRelaENT.qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName; //qaUserName
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
 /// <param name = "objvgs_RTqa_PaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_RTqa_PaperRelaEN:objvgs_RTqa_PaperRelaENT</returns>
 public static clsvgs_RTqa_PaperRelaEN CopyTo(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENS)
{
try
{
 clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENT = new clsvgs_RTqa_PaperRelaEN()
{
mId = objvgs_RTqa_PaperRelaENS.mId, //mId
TopicId = objvgs_RTqa_PaperRelaENS.TopicId, //主题Id
TopicName = objvgs_RTqa_PaperRelaENS.TopicName, //栏目主题
IdCurrEduCls = objvgs_RTqa_PaperRelaENS.IdCurrEduCls, //教学班流水号
QaPaperId = objvgs_RTqa_PaperRelaENS.QaPaperId, //论文答疑Id
PaperId = objvgs_RTqa_PaperRelaENS.PaperId, //论文Id
QuestionsCount = objvgs_RTqa_PaperRelaENS.QuestionsCount, //提问计数
IsPublic = objvgs_RTqa_PaperRelaENS.IsPublic, //是否公开
IsSubmit = objvgs_RTqa_PaperRelaENS.IsSubmit, //是否提交
PaperTitle = objvgs_RTqa_PaperRelaENS.PaperTitle, //论文标题
AttachmentCount = objvgs_RTqa_PaperRelaENS.AttachmentCount, //附件计数
AnswerCount = objvgs_RTqa_PaperRelaENS.AnswerCount, //回答计数
ShareId = objvgs_RTqa_PaperRelaENS.ShareId, //分享Id
TagsCount = objvgs_RTqa_PaperRelaENS.TagsCount, //论文标注数
UpdDate = objvgs_RTqa_PaperRelaENS.UpdDate, //修改日期
UpdUser = objvgs_RTqa_PaperRelaENS.UpdUser, //修改人
Memo = objvgs_RTqa_PaperRelaENS.Memo, //备注
qaUser = objvgs_RTqa_PaperRelaENS.qaUser, //qaUser
qaDate = objvgs_RTqa_PaperRelaENS.qaDate, //qaDate
qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName, //qaUserName
};
 return objvgs_RTqa_PaperRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
 clsvgs_RTqa_PaperRelaBL.vgs_RTqa_PaperRelaDA.CheckProperty4Condition(objvgs_RTqa_PaperRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.mId) == true)
{
string strComparisonOpmId = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_RTqa_PaperRela.mId, objvgs_RTqa_PaperRelaCond.mId, strComparisonOpmId);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.TopicId, objvgs_RTqa_PaperRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.TopicName, objvgs_RTqa_PaperRelaCond.TopicName, strComparisonOpTopicName);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.IdCurrEduCls, objvgs_RTqa_PaperRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.QaPaperId, objvgs_RTqa_PaperRelaCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.PaperId, objvgs_RTqa_PaperRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_RTqa_PaperRela.QuestionsCount, objvgs_RTqa_PaperRelaCond.QuestionsCount, strComparisonOpQuestionsCount);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.IsPublic) == true)
{
if (objvgs_RTqa_PaperRelaCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_RTqa_PaperRela.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_RTqa_PaperRela.IsPublic);
}
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.IsSubmit) == true)
{
if (objvgs_RTqa_PaperRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_RTqa_PaperRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_RTqa_PaperRela.IsSubmit);
}
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.PaperTitle, objvgs_RTqa_PaperRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_RTqa_PaperRela.AttachmentCount, objvgs_RTqa_PaperRelaCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_RTqa_PaperRela.AnswerCount, objvgs_RTqa_PaperRelaCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.ShareId, objvgs_RTqa_PaperRelaCond.ShareId, strComparisonOpShareId);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.TagsCount) == true)
{
string strComparisonOpTagsCount = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_RTqa_PaperRela.TagsCount, objvgs_RTqa_PaperRelaCond.TagsCount, strComparisonOpTagsCount);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.UpdDate, objvgs_RTqa_PaperRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.UpdUser, objvgs_RTqa_PaperRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.Memo, objvgs_RTqa_PaperRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.qaUser) == true)
{
string strComparisonOpqaUser = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.qaUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.qaUser, objvgs_RTqa_PaperRelaCond.qaUser, strComparisonOpqaUser);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.qaDate) == true)
{
string strComparisonOpqaDate = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.qaDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.qaDate, objvgs_RTqa_PaperRelaCond.qaDate, strComparisonOpqaDate);
}
if (objvgs_RTqa_PaperRelaCond.IsUpdated(convgs_RTqa_PaperRela.qaUserName) == true)
{
string strComparisonOpqaUserName = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[convgs_RTqa_PaperRela.qaUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_RTqa_PaperRela.qaUserName, objvgs_RTqa_PaperRelaCond.qaUserName, strComparisonOpqaUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_RTqa_PaperRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题答疑关系视图(vgs_RTqa_PaperRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_RTqa_PaperRelaBL
{
public static RelatedActions_vgs_RTqa_PaperRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_RTqa_PaperRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_RTqa_PaperRelaDA vgs_RTqa_PaperRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_RTqa_PaperRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_RTqa_PaperRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_RTqa_PaperRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_RTqa_PaperRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_RTqa_PaperRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_RTqa_PaperRelaDA.GetDataTable_vgs_RTqa_PaperRela(strWhereCond);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_RTqa_PaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
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
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_RTqa_PaperRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strTopicId)
{
string strKey = string.Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
List<clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLst_Sel =
arrvgs_RTqa_PaperRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_RTqa_PaperRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_RTqa_PaperRelaEN> GetSubObjLstCache(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaCond)
{
 string strTopicId = objvgs_RTqa_PaperRelaCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvgs_RTqa_PaperRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvgs_RTqa_PaperRelaEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvgs_RTqa_PaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_RTqa_PaperRela.AttributeName)
{
if (objvgs_RTqa_PaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_RTqa_PaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_RTqa_PaperRelaCond[strFldName].ToString());
}
else
{
if (objvgs_RTqa_PaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_RTqa_PaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_RTqa_PaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_RTqa_PaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_RTqa_PaperRelaCond[strFldName]));
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_RTqa_PaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
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
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
public static List<clsvgs_RTqa_PaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
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
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_RTqa_PaperRelaEN> arrObjLst = new List<clsvgs_RTqa_PaperRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = new clsvgs_RTqa_PaperRelaEN();
try
{
objvgs_RTqa_PaperRelaEN.mId = Int32.Parse(objRow[convgs_RTqa_PaperRela.mId].ToString().Trim()); //mId
objvgs_RTqa_PaperRelaEN.TopicId = objRow[convgs_RTqa_PaperRela.TopicId].ToString().Trim(); //主题Id
objvgs_RTqa_PaperRelaEN.TopicName = objRow[convgs_RTqa_PaperRela.TopicName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.TopicName].ToString().Trim(); //栏目主题
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objRow[convgs_RTqa_PaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_RTqa_PaperRelaEN.QaPaperId = objRow[convgs_RTqa_PaperRela.QaPaperId].ToString().Trim(); //论文答疑Id
objvgs_RTqa_PaperRelaEN.PaperId = objRow[convgs_RTqa_PaperRela.PaperId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperId].ToString().Trim(); //论文Id
objvgs_RTqa_PaperRelaEN.QuestionsCount = objRow[convgs_RTqa_PaperRela.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.QuestionsCount].ToString().Trim()); //提问计数
objvgs_RTqa_PaperRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsPublic].ToString().Trim()); //是否公开
objvgs_RTqa_PaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_RTqa_PaperRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_RTqa_PaperRelaEN.PaperTitle = objRow[convgs_RTqa_PaperRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_RTqa_PaperRelaEN.AttachmentCount = objRow[convgs_RTqa_PaperRela.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AttachmentCount].ToString().Trim()); //附件计数
objvgs_RTqa_PaperRelaEN.AnswerCount = objRow[convgs_RTqa_PaperRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.AnswerCount].ToString().Trim()); //回答计数
objvgs_RTqa_PaperRelaEN.ShareId = objRow[convgs_RTqa_PaperRela.ShareId] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.ShareId].ToString().Trim(); //分享Id
objvgs_RTqa_PaperRelaEN.TagsCount = objRow[convgs_RTqa_PaperRela.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_RTqa_PaperRela.TagsCount].ToString().Trim()); //论文标注数
objvgs_RTqa_PaperRelaEN.UpdDate = objRow[convgs_RTqa_PaperRela.UpdDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdDate].ToString().Trim(); //修改日期
objvgs_RTqa_PaperRelaEN.UpdUser = objRow[convgs_RTqa_PaperRela.UpdUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.UpdUser].ToString().Trim(); //修改人
objvgs_RTqa_PaperRelaEN.Memo = objRow[convgs_RTqa_PaperRela.Memo] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.Memo].ToString().Trim(); //备注
objvgs_RTqa_PaperRelaEN.qaUser = objRow[convgs_RTqa_PaperRela.qaUser] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUser].ToString().Trim(); //qaUser
objvgs_RTqa_PaperRelaEN.qaDate = objRow[convgs_RTqa_PaperRela.qaDate] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaDate].ToString().Trim(); //qaDate
objvgs_RTqa_PaperRelaEN.qaUserName = objRow[convgs_RTqa_PaperRela.qaUserName] == DBNull.Value ? null : objRow[convgs_RTqa_PaperRela.qaUserName].ToString().Trim(); //qaUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_RTqa_PaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_RTqa_PaperRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_RTqa_PaperRela(ref clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
bool bolResult = vgs_RTqa_PaperRelaDA.Getvgs_RTqa_PaperRela(ref objvgs_RTqa_PaperRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_RTqa_PaperRelaEN GetObjBymId(long lngmId)
{
clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = vgs_RTqa_PaperRelaDA.GetObjBymId(lngmId);
return objvgs_RTqa_PaperRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_RTqa_PaperRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = vgs_RTqa_PaperRelaDA.GetFirstObj(strWhereCond);
 return objvgs_RTqa_PaperRelaEN;
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
public static clsvgs_RTqa_PaperRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = vgs_RTqa_PaperRelaDA.GetObjByDataRow(objRow);
 return objvgs_RTqa_PaperRelaEN;
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
public static clsvgs_RTqa_PaperRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN = vgs_RTqa_PaperRelaDA.GetObjByDataRow(objRow);
 return objvgs_RTqa_PaperRelaEN;
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
 /// <param name = "lstvgs_RTqa_PaperRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_RTqa_PaperRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_RTqa_PaperRelaEN> lstvgs_RTqa_PaperRelaObjLst)
{
foreach (clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN in lstvgs_RTqa_PaperRelaObjLst)
{
if (objvgs_RTqa_PaperRelaEN.mId == lngmId)
{
return objvgs_RTqa_PaperRelaEN;
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
 lngmId = new clsvgs_RTqa_PaperRelaDA().GetFirstID(strWhereCond);
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
 arrList = vgs_RTqa_PaperRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_RTqa_PaperRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_RTqa_PaperRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_RTqa_PaperRelaDA.IsExistTable();
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
 bolIsExist = vgs_RTqa_PaperRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_RTqa_PaperRelaENS">源对象</param>
 /// <param name = "objvgs_RTqa_PaperRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENS, clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaENT)
{
try
{
objvgs_RTqa_PaperRelaENT.mId = objvgs_RTqa_PaperRelaENS.mId; //mId
objvgs_RTqa_PaperRelaENT.TopicId = objvgs_RTqa_PaperRelaENS.TopicId; //主题Id
objvgs_RTqa_PaperRelaENT.TopicName = objvgs_RTqa_PaperRelaENS.TopicName; //栏目主题
objvgs_RTqa_PaperRelaENT.IdCurrEduCls = objvgs_RTqa_PaperRelaENS.IdCurrEduCls; //教学班流水号
objvgs_RTqa_PaperRelaENT.QaPaperId = objvgs_RTqa_PaperRelaENS.QaPaperId; //论文答疑Id
objvgs_RTqa_PaperRelaENT.PaperId = objvgs_RTqa_PaperRelaENS.PaperId; //论文Id
objvgs_RTqa_PaperRelaENT.QuestionsCount = objvgs_RTqa_PaperRelaENS.QuestionsCount; //提问计数
objvgs_RTqa_PaperRelaENT.IsPublic = objvgs_RTqa_PaperRelaENS.IsPublic; //是否公开
objvgs_RTqa_PaperRelaENT.IsSubmit = objvgs_RTqa_PaperRelaENS.IsSubmit; //是否提交
objvgs_RTqa_PaperRelaENT.PaperTitle = objvgs_RTqa_PaperRelaENS.PaperTitle; //论文标题
objvgs_RTqa_PaperRelaENT.AttachmentCount = objvgs_RTqa_PaperRelaENS.AttachmentCount; //附件计数
objvgs_RTqa_PaperRelaENT.AnswerCount = objvgs_RTqa_PaperRelaENS.AnswerCount; //回答计数
objvgs_RTqa_PaperRelaENT.ShareId = objvgs_RTqa_PaperRelaENS.ShareId; //分享Id
objvgs_RTqa_PaperRelaENT.TagsCount = objvgs_RTqa_PaperRelaENS.TagsCount; //论文标注数
objvgs_RTqa_PaperRelaENT.UpdDate = objvgs_RTqa_PaperRelaENS.UpdDate; //修改日期
objvgs_RTqa_PaperRelaENT.UpdUser = objvgs_RTqa_PaperRelaENS.UpdUser; //修改人
objvgs_RTqa_PaperRelaENT.Memo = objvgs_RTqa_PaperRelaENS.Memo; //备注
objvgs_RTqa_PaperRelaENT.qaUser = objvgs_RTqa_PaperRelaENS.qaUser; //qaUser
objvgs_RTqa_PaperRelaENT.qaDate = objvgs_RTqa_PaperRelaENS.qaDate; //qaDate
objvgs_RTqa_PaperRelaENT.qaUserName = objvgs_RTqa_PaperRelaENS.qaUserName; //qaUserName
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
 /// <param name = "objvgs_RTqa_PaperRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
try
{
objvgs_RTqa_PaperRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_RTqa_PaperRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_RTqa_PaperRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.mId = objvgs_RTqa_PaperRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.TopicId = objvgs_RTqa_PaperRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.TopicName = objvgs_RTqa_PaperRelaEN.TopicName == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.IdCurrEduCls = objvgs_RTqa_PaperRelaEN.IdCurrEduCls == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.QaPaperId = objvgs_RTqa_PaperRelaEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.PaperId = objvgs_RTqa_PaperRelaEN.PaperId == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.QuestionsCount = objvgs_RTqa_PaperRelaEN.QuestionsCount; //提问计数
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.IsPublic = objvgs_RTqa_PaperRelaEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.IsSubmit = objvgs_RTqa_PaperRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.PaperTitle = objvgs_RTqa_PaperRelaEN.PaperTitle == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.AttachmentCount = objvgs_RTqa_PaperRelaEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.AnswerCount = objvgs_RTqa_PaperRelaEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.ShareId = objvgs_RTqa_PaperRelaEN.ShareId == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.TagsCount = objvgs_RTqa_PaperRelaEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.UpdDate = objvgs_RTqa_PaperRelaEN.UpdDate == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.UpdUser = objvgs_RTqa_PaperRelaEN.UpdUser == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.Memo = objvgs_RTqa_PaperRelaEN.Memo == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.qaUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.qaUser = objvgs_RTqa_PaperRelaEN.qaUser == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.qaUser; //qaUser
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.qaDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.qaDate = objvgs_RTqa_PaperRelaEN.qaDate == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.qaDate; //qaDate
}
if (arrFldSet.Contains(convgs_RTqa_PaperRela.qaUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_RTqa_PaperRelaEN.qaUserName = objvgs_RTqa_PaperRelaEN.qaUserName == "[null]" ? null :  objvgs_RTqa_PaperRelaEN.qaUserName; //qaUserName
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
 /// <param name = "objvgs_RTqa_PaperRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
try
{
if (objvgs_RTqa_PaperRelaEN.TopicName == "[null]") objvgs_RTqa_PaperRelaEN.TopicName = null; //栏目主题
if (objvgs_RTqa_PaperRelaEN.IdCurrEduCls == "[null]") objvgs_RTqa_PaperRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_RTqa_PaperRelaEN.PaperId == "[null]") objvgs_RTqa_PaperRelaEN.PaperId = null; //论文Id
if (objvgs_RTqa_PaperRelaEN.PaperTitle == "[null]") objvgs_RTqa_PaperRelaEN.PaperTitle = null; //论文标题
if (objvgs_RTqa_PaperRelaEN.ShareId == "[null]") objvgs_RTqa_PaperRelaEN.ShareId = null; //分享Id
if (objvgs_RTqa_PaperRelaEN.UpdDate == "[null]") objvgs_RTqa_PaperRelaEN.UpdDate = null; //修改日期
if (objvgs_RTqa_PaperRelaEN.UpdUser == "[null]") objvgs_RTqa_PaperRelaEN.UpdUser = null; //修改人
if (objvgs_RTqa_PaperRelaEN.Memo == "[null]") objvgs_RTqa_PaperRelaEN.Memo = null; //备注
if (objvgs_RTqa_PaperRelaEN.qaUser == "[null]") objvgs_RTqa_PaperRelaEN.qaUser = null; //qaUser
if (objvgs_RTqa_PaperRelaEN.qaDate == "[null]") objvgs_RTqa_PaperRelaEN.qaDate = null; //qaDate
if (objvgs_RTqa_PaperRelaEN.qaUserName == "[null]") objvgs_RTqa_PaperRelaEN.qaUserName = null; //qaUserName
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
public static void CheckProperty4Condition(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaEN)
{
 vgs_RTqa_PaperRelaDA.CheckProperty4Condition(objvgs_RTqa_PaperRelaEN);
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
if (clsgs_RTqa_PaperRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_RTqa_PaperRelaBL没有刷新缓存机制(clsgs_RTqa_PaperRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PaperBL没有刷新缓存机制(clsqa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_RTqa_PaperRelaObjLstCache == null)
//{
//arrvgs_RTqa_PaperRelaObjLstCache = vgs_RTqa_PaperRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_RTqa_PaperRelaEN GetObjBymIdCache(long lngmId, string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
List<clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLst_Sel =
arrvgs_RTqa_PaperRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_RTqa_PaperRelaObjLst_Sel.Count() == 0)
{
   clsvgs_RTqa_PaperRelaEN obj = clsvgs_RTqa_PaperRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.TopicId == strTopicId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strTopicId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvgs_RTqa_PaperRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetAllvgs_RTqa_PaperRelaObjLstCache(string strTopicId)
{
//获取缓存中的对象列表
List<clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLstCache = GetObjLstCache(strTopicId); 
return arrvgs_RTqa_PaperRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_RTqa_PaperRelaEN> GetObjLstCache(string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
string strCondition = string.Format("TopicId='{0}'", strTopicId);
List<clsvgs_RTqa_PaperRelaEN> arrvgs_RTqa_PaperRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvgs_RTqa_PaperRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTopicId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
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
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strTopicId)
{
if (strInFldName != convgs_RTqa_PaperRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_RTqa_PaperRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_RTqa_PaperRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_RTqa_PaperRela = clsvgs_RTqa_PaperRelaBL.GetObjBymIdCache(lngmId, strTopicId);
if (objvgs_RTqa_PaperRela == null) return "";
return objvgs_RTqa_PaperRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_RTqa_PaperRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_RTqa_PaperRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_RTqa_PaperRelaDA.GetRecCount();
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
int intRecCount = clsvgs_RTqa_PaperRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_RTqa_PaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_RTqa_PaperRelaEN objvgs_RTqa_PaperRelaCond)
{
 string strTopicId = objvgs_RTqa_PaperRelaCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvgs_RTqa_PaperRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvgs_RTqa_PaperRelaEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvgs_RTqa_PaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_RTqa_PaperRela.AttributeName)
{
if (objvgs_RTqa_PaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_RTqa_PaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_RTqa_PaperRelaCond[strFldName].ToString());
}
else
{
if (objvgs_RTqa_PaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_RTqa_PaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_RTqa_PaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_RTqa_PaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_RTqa_PaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_RTqa_PaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_RTqa_PaperRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_RTqa_PaperRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_RTqa_PaperRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_RTqa_PaperRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}