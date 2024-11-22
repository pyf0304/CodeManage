
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTPaperRelaBL
 表名:vRTPaperRela(01120583)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:14
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
public static class  clsvRTPaperRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTPaperRelaEN GetObj(this K_mId_vRTPaperRela myKey)
{
clsvRTPaperRelaEN objvRTPaperRelaEN = clsvRTPaperRelaBL.vRTPaperRelaDA.GetObjBymId(myKey.Value);
return objvRTPaperRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetmId(this clsvRTPaperRelaEN objvRTPaperRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTPaperRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.mId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.mId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.mId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetTopicId(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTPaperRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTPaperRela.TopicId);
}
objvRTPaperRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.TopicId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.TopicId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.TopicId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperId(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convRTPaperRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convRTPaperRela.PaperId);
}
objvRTPaperRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetTopicName(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTPaperRela.TopicName);
}
objvRTPaperRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.TopicName) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.TopicName, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.TopicName] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetTopicContent(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTPaperRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.TopicContent) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.TopicContent, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.TopicContent] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetTopicProposePeople(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTPaperRela.TopicProposePeople);
}
objvRTPaperRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.TopicProposePeople) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperTitle(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convRTPaperRela.PaperTitle);
}
objvRTPaperRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperTitle) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperTitle, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperTitle] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperContent(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperContent, string strComparisonOp="")
	{
objvRTPaperRelaEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperContent) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperContent, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperContent] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetAuthor(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convRTPaperRela.Author);
}
objvRTPaperRelaEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.Author) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.Author, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.Author] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPeriodical(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convRTPaperRela.Periodical);
}
objvRTPaperRelaEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.Periodical) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.Periodical, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.Periodical] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetIsSubmit(this clsvRTPaperRelaEN objvRTPaperRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTPaperRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.IsSubmit) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.IsSubmit, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.IsSubmit] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetIdCurrEduCls(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTPaperRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTPaperRela.IdCurrEduCls);
}
objvRTPaperRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.IdCurrEduCls) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperDate(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperDate, 20, convRTPaperRela.PaperDate);
}
objvRTPaperRelaEN.PaperDate = strPaperDate; //PaperDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperDate) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperDate, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperDate] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperStatusId(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperStatusId, 2, convRTPaperRela.PaperStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperStatusId, 2, convRTPaperRela.PaperStatusId);
}
objvRTPaperRelaEN.PaperStatusId = strPaperStatusId; //论文状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperStatusId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperStatusId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperStatusId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperTypeId(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convRTPaperRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convRTPaperRela.PaperTypeId);
}
objvRTPaperRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperTypeId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperTypeId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperTypeId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperUserId(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperUserId, 20, convRTPaperRela.PaperUserId);
}
objvRTPaperRelaEN.PaperUserId = strPaperUserId; //PaperUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperUserId) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperUserId, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperUserId] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetVersionCount(this clsvRTPaperRelaEN objvRTPaperRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTPaperRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.VersionCount) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.VersionCount, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.VersionCount] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetPaperTypeName(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strPaperTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeName, 50, convRTPaperRela.PaperTypeName);
}
objvRTPaperRelaEN.PaperTypeName = strPaperTypeName; //论文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.PaperTypeName) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.PaperTypeName, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.PaperTypeName] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetUpdDate(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTPaperRela.UpdDate);
}
objvRTPaperRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.UpdDate) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.UpdDate, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.UpdDate] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetUpdUser(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTPaperRela.UpdUser);
}
objvRTPaperRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.UpdUser) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.UpdUser, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.UpdUser] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTPaperRelaEN SetMemo(this clsvRTPaperRelaEN objvRTPaperRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTPaperRela.Memo);
}
objvRTPaperRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTPaperRelaEN.dicFldComparisonOp.ContainsKey(convRTPaperRela.Memo) == false)
{
objvRTPaperRelaEN.dicFldComparisonOp.Add(convRTPaperRela.Memo, strComparisonOp);
}
else
{
objvRTPaperRelaEN.dicFldComparisonOp[convRTPaperRela.Memo] = strComparisonOp;
}
}
return objvRTPaperRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTPaperRelaENS">源对象</param>
 /// <param name = "objvRTPaperRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTPaperRelaEN objvRTPaperRelaENS, clsvRTPaperRelaEN objvRTPaperRelaENT)
{
try
{
objvRTPaperRelaENT.mId = objvRTPaperRelaENS.mId; //mId
objvRTPaperRelaENT.TopicId = objvRTPaperRelaENS.TopicId; //主题Id
objvRTPaperRelaENT.PaperId = objvRTPaperRelaENS.PaperId; //论文Id
objvRTPaperRelaENT.TopicName = objvRTPaperRelaENS.TopicName; //栏目主题
objvRTPaperRelaENT.TopicContent = objvRTPaperRelaENS.TopicContent; //主题内容
objvRTPaperRelaENT.TopicProposePeople = objvRTPaperRelaENS.TopicProposePeople; //主题提出人
objvRTPaperRelaENT.PaperTitle = objvRTPaperRelaENS.PaperTitle; //论文标题
objvRTPaperRelaENT.PaperContent = objvRTPaperRelaENS.PaperContent; //主题内容
objvRTPaperRelaENT.Author = objvRTPaperRelaENS.Author; //作者
objvRTPaperRelaENT.Periodical = objvRTPaperRelaENS.Periodical; //期刊
objvRTPaperRelaENT.IsSubmit = objvRTPaperRelaENS.IsSubmit; //是否提交
objvRTPaperRelaENT.IdCurrEduCls = objvRTPaperRelaENS.IdCurrEduCls; //教学班流水号
objvRTPaperRelaENT.PaperDate = objvRTPaperRelaENS.PaperDate; //PaperDate
objvRTPaperRelaENT.PaperStatusId = objvRTPaperRelaENS.PaperStatusId; //论文状态Id
objvRTPaperRelaENT.PaperTypeId = objvRTPaperRelaENS.PaperTypeId; //论文类型Id
objvRTPaperRelaENT.PaperUserId = objvRTPaperRelaENS.PaperUserId; //PaperUserId
objvRTPaperRelaENT.VersionCount = objvRTPaperRelaENS.VersionCount; //版本统计
objvRTPaperRelaENT.PaperTypeName = objvRTPaperRelaENS.PaperTypeName; //论文类型名
objvRTPaperRelaENT.UpdDate = objvRTPaperRelaENS.UpdDate; //修改日期
objvRTPaperRelaENT.UpdUser = objvRTPaperRelaENS.UpdUser; //修改人
objvRTPaperRelaENT.Memo = objvRTPaperRelaENS.Memo; //备注
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
 /// <param name = "objvRTPaperRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTPaperRelaEN:objvRTPaperRelaENT</returns>
 public static clsvRTPaperRelaEN CopyTo(this clsvRTPaperRelaEN objvRTPaperRelaENS)
{
try
{
 clsvRTPaperRelaEN objvRTPaperRelaENT = new clsvRTPaperRelaEN()
{
mId = objvRTPaperRelaENS.mId, //mId
TopicId = objvRTPaperRelaENS.TopicId, //主题Id
PaperId = objvRTPaperRelaENS.PaperId, //论文Id
TopicName = objvRTPaperRelaENS.TopicName, //栏目主题
TopicContent = objvRTPaperRelaENS.TopicContent, //主题内容
TopicProposePeople = objvRTPaperRelaENS.TopicProposePeople, //主题提出人
PaperTitle = objvRTPaperRelaENS.PaperTitle, //论文标题
PaperContent = objvRTPaperRelaENS.PaperContent, //主题内容
Author = objvRTPaperRelaENS.Author, //作者
Periodical = objvRTPaperRelaENS.Periodical, //期刊
IsSubmit = objvRTPaperRelaENS.IsSubmit, //是否提交
IdCurrEduCls = objvRTPaperRelaENS.IdCurrEduCls, //教学班流水号
PaperDate = objvRTPaperRelaENS.PaperDate, //PaperDate
PaperStatusId = objvRTPaperRelaENS.PaperStatusId, //论文状态Id
PaperTypeId = objvRTPaperRelaENS.PaperTypeId, //论文类型Id
PaperUserId = objvRTPaperRelaENS.PaperUserId, //PaperUserId
VersionCount = objvRTPaperRelaENS.VersionCount, //版本统计
PaperTypeName = objvRTPaperRelaENS.PaperTypeName, //论文类型名
UpdDate = objvRTPaperRelaENS.UpdDate, //修改日期
UpdUser = objvRTPaperRelaENS.UpdUser, //修改人
Memo = objvRTPaperRelaENS.Memo, //备注
};
 return objvRTPaperRelaENT;
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
public static void CheckProperty4Condition(this clsvRTPaperRelaEN objvRTPaperRelaEN)
{
 clsvRTPaperRelaBL.vRTPaperRelaDA.CheckProperty4Condition(objvRTPaperRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTPaperRelaEN objvRTPaperRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.mId) == true)
{
string strComparisonOpmId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTPaperRela.mId, objvRTPaperRelaCond.mId, strComparisonOpmId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.TopicId, objvRTPaperRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperId) == true)
{
string strComparisonOpPaperId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperId, objvRTPaperRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.TopicName, objvRTPaperRelaCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.TopicProposePeople, objvRTPaperRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperTitle, objvRTPaperRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.Author) == true)
{
string strComparisonOpAuthor = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.Author, objvRTPaperRelaCond.Author, strComparisonOpAuthor);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.Periodical) == true)
{
string strComparisonOpPeriodical = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.Periodical, objvRTPaperRelaCond.Periodical, strComparisonOpPeriodical);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.IsSubmit) == true)
{
if (objvRTPaperRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTPaperRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTPaperRela.IsSubmit);
}
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.IdCurrEduCls, objvRTPaperRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperDate) == true)
{
string strComparisonOpPaperDate = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperDate, objvRTPaperRelaCond.PaperDate, strComparisonOpPaperDate);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperStatusId) == true)
{
string strComparisonOpPaperStatusId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperStatusId, objvRTPaperRelaCond.PaperStatusId, strComparisonOpPaperStatusId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperTypeId, objvRTPaperRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperUserId) == true)
{
string strComparisonOpPaperUserId = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperUserId, objvRTPaperRelaCond.PaperUserId, strComparisonOpPaperUserId);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTPaperRela.VersionCount, objvRTPaperRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.PaperTypeName) == true)
{
string strComparisonOpPaperTypeName = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.PaperTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.PaperTypeName, objvRTPaperRelaCond.PaperTypeName, strComparisonOpPaperTypeName);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.UpdDate, objvRTPaperRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.UpdUser, objvRTPaperRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTPaperRelaCond.IsUpdated(convRTPaperRela.Memo) == true)
{
string strComparisonOpMemo = objvRTPaperRelaCond.dicFldComparisonOp[convRTPaperRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTPaperRela.Memo, objvRTPaperRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTPaperRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTPaperRela(vRTPaperRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTPaperRelaBL
{
public static RelatedActions_vRTPaperRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTPaperRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTPaperRelaDA vRTPaperRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTPaperRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTPaperRelaBL()
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
if (string.IsNullOrEmpty(clsvRTPaperRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTPaperRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTPaperRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTPaperRelaDA.GetDataTable_vRTPaperRela(strWhereCond);
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
objDT = vRTPaperRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTPaperRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTPaperRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTPaperRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTPaperRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTPaperRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTPaperRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvRTPaperRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
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
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTPaperRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTPaperRelaEN._CurrTabName);
List<clsvRTPaperRelaEN> arrvRTPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTPaperRelaEN> arrvRTPaperRelaObjLst_Sel =
arrvRTPaperRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTPaperRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTPaperRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
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
public static List<clsvRTPaperRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTPaperRelaEN> GetSubObjLstCache(clsvRTPaperRelaEN objvRTPaperRelaCond)
{
List<clsvRTPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTPaperRela.AttributeName)
{
if (objvRTPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTPaperRelaCond[strFldName].ToString());
}
else
{
if (objvRTPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTPaperRelaCond[strFldName]));
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
public static List<clsvRTPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
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
public static List<clsvRTPaperRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
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
List<clsvRTPaperRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTPaperRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTPaperRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
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
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
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
public static List<clsvRTPaperRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTPaperRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
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
public static List<clsvRTPaperRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTPaperRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTPaperRelaEN> arrObjLst = new List<clsvRTPaperRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTPaperRelaEN objvRTPaperRelaEN = new clsvRTPaperRelaEN();
try
{
objvRTPaperRelaEN.mId = Int32.Parse(objRow[convRTPaperRela.mId].ToString().Trim()); //mId
objvRTPaperRelaEN.TopicId = objRow[convRTPaperRela.TopicId] == DBNull.Value ? null : objRow[convRTPaperRela.TopicId].ToString().Trim(); //主题Id
objvRTPaperRelaEN.PaperId = objRow[convRTPaperRela.PaperId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperId].ToString().Trim(); //论文Id
objvRTPaperRelaEN.TopicName = objRow[convRTPaperRela.TopicName] == DBNull.Value ? null : objRow[convRTPaperRela.TopicName].ToString().Trim(); //栏目主题
objvRTPaperRelaEN.TopicContent = objRow[convRTPaperRela.TopicContent] == DBNull.Value ? null : objRow[convRTPaperRela.TopicContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.TopicProposePeople = objRow[convRTPaperRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTPaperRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTPaperRelaEN.PaperTitle = objRow[convRTPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvRTPaperRelaEN.PaperContent = objRow[convRTPaperRela.PaperContent] == DBNull.Value ? null : objRow[convRTPaperRela.PaperContent].ToString().Trim(); //主题内容
objvRTPaperRelaEN.Author = objRow[convRTPaperRela.Author] == DBNull.Value ? null : objRow[convRTPaperRela.Author].ToString().Trim(); //作者
objvRTPaperRelaEN.Periodical = objRow[convRTPaperRela.Periodical] == DBNull.Value ? null : objRow[convRTPaperRela.Periodical].ToString().Trim(); //期刊
objvRTPaperRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTPaperRela.IsSubmit].ToString().Trim()); //是否提交
objvRTPaperRelaEN.IdCurrEduCls = objRow[convRTPaperRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTPaperRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTPaperRelaEN.PaperDate = objRow[convRTPaperRela.PaperDate] == DBNull.Value ? null : objRow[convRTPaperRela.PaperDate].ToString().Trim(); //PaperDate
objvRTPaperRelaEN.PaperStatusId = objRow[convRTPaperRela.PaperStatusId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperStatusId].ToString().Trim(); //论文状态Id
objvRTPaperRelaEN.PaperTypeId = objRow[convRTPaperRela.PaperTypeId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvRTPaperRelaEN.PaperUserId = objRow[convRTPaperRela.PaperUserId] == DBNull.Value ? null : objRow[convRTPaperRela.PaperUserId].ToString().Trim(); //PaperUserId
objvRTPaperRelaEN.VersionCount = objRow[convRTPaperRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTPaperRela.VersionCount].ToString().Trim()); //版本统计
objvRTPaperRelaEN.PaperTypeName = objRow[convRTPaperRela.PaperTypeName] == DBNull.Value ? null : objRow[convRTPaperRela.PaperTypeName].ToString().Trim(); //论文类型名
objvRTPaperRelaEN.UpdDate = objRow[convRTPaperRela.UpdDate] == DBNull.Value ? null : objRow[convRTPaperRela.UpdDate].ToString().Trim(); //修改日期
objvRTPaperRelaEN.UpdUser = objRow[convRTPaperRela.UpdUser] == DBNull.Value ? null : objRow[convRTPaperRela.UpdUser].ToString().Trim(); //修改人
objvRTPaperRelaEN.Memo = objRow[convRTPaperRela.Memo] == DBNull.Value ? null : objRow[convRTPaperRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTPaperRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTPaperRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTPaperRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTPaperRela(ref clsvRTPaperRelaEN objvRTPaperRelaEN)
{
bool bolResult = vRTPaperRelaDA.GetvRTPaperRela(ref objvRTPaperRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTPaperRelaEN GetObjBymId(long lngmId)
{
clsvRTPaperRelaEN objvRTPaperRelaEN = vRTPaperRelaDA.GetObjBymId(lngmId);
return objvRTPaperRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTPaperRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTPaperRelaEN objvRTPaperRelaEN = vRTPaperRelaDA.GetFirstObj(strWhereCond);
 return objvRTPaperRelaEN;
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
public static clsvRTPaperRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTPaperRelaEN objvRTPaperRelaEN = vRTPaperRelaDA.GetObjByDataRow(objRow);
 return objvRTPaperRelaEN;
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
public static clsvRTPaperRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTPaperRelaEN objvRTPaperRelaEN = vRTPaperRelaDA.GetObjByDataRow(objRow);
 return objvRTPaperRelaEN;
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
 /// <param name = "lstvRTPaperRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTPaperRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTPaperRelaEN> lstvRTPaperRelaObjLst)
{
foreach (clsvRTPaperRelaEN objvRTPaperRelaEN in lstvRTPaperRelaObjLst)
{
if (objvRTPaperRelaEN.mId == lngmId)
{
return objvRTPaperRelaEN;
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
 lngmId = new clsvRTPaperRelaDA().GetFirstID(strWhereCond);
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
 arrList = vRTPaperRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTPaperRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vRTPaperRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTPaperRelaDA.IsExistTable();
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
 bolIsExist = vRTPaperRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTPaperRelaENS">源对象</param>
 /// <param name = "objvRTPaperRelaENT">目标对象</param>
 public static void CopyTo(clsvRTPaperRelaEN objvRTPaperRelaENS, clsvRTPaperRelaEN objvRTPaperRelaENT)
{
try
{
objvRTPaperRelaENT.mId = objvRTPaperRelaENS.mId; //mId
objvRTPaperRelaENT.TopicId = objvRTPaperRelaENS.TopicId; //主题Id
objvRTPaperRelaENT.PaperId = objvRTPaperRelaENS.PaperId; //论文Id
objvRTPaperRelaENT.TopicName = objvRTPaperRelaENS.TopicName; //栏目主题
objvRTPaperRelaENT.TopicContent = objvRTPaperRelaENS.TopicContent; //主题内容
objvRTPaperRelaENT.TopicProposePeople = objvRTPaperRelaENS.TopicProposePeople; //主题提出人
objvRTPaperRelaENT.PaperTitle = objvRTPaperRelaENS.PaperTitle; //论文标题
objvRTPaperRelaENT.PaperContent = objvRTPaperRelaENS.PaperContent; //主题内容
objvRTPaperRelaENT.Author = objvRTPaperRelaENS.Author; //作者
objvRTPaperRelaENT.Periodical = objvRTPaperRelaENS.Periodical; //期刊
objvRTPaperRelaENT.IsSubmit = objvRTPaperRelaENS.IsSubmit; //是否提交
objvRTPaperRelaENT.IdCurrEduCls = objvRTPaperRelaENS.IdCurrEduCls; //教学班流水号
objvRTPaperRelaENT.PaperDate = objvRTPaperRelaENS.PaperDate; //PaperDate
objvRTPaperRelaENT.PaperStatusId = objvRTPaperRelaENS.PaperStatusId; //论文状态Id
objvRTPaperRelaENT.PaperTypeId = objvRTPaperRelaENS.PaperTypeId; //论文类型Id
objvRTPaperRelaENT.PaperUserId = objvRTPaperRelaENS.PaperUserId; //PaperUserId
objvRTPaperRelaENT.VersionCount = objvRTPaperRelaENS.VersionCount; //版本统计
objvRTPaperRelaENT.PaperTypeName = objvRTPaperRelaENS.PaperTypeName; //论文类型名
objvRTPaperRelaENT.UpdDate = objvRTPaperRelaENS.UpdDate; //修改日期
objvRTPaperRelaENT.UpdUser = objvRTPaperRelaENS.UpdUser; //修改人
objvRTPaperRelaENT.Memo = objvRTPaperRelaENS.Memo; //备注
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
 /// <param name = "objvRTPaperRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTPaperRelaEN objvRTPaperRelaEN)
{
try
{
objvRTPaperRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTPaperRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTPaperRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.mId = objvRTPaperRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTPaperRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.TopicId = objvRTPaperRelaEN.TopicId == "[null]" ? null :  objvRTPaperRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTPaperRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperId = objvRTPaperRelaEN.PaperId == "[null]" ? null :  objvRTPaperRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convRTPaperRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.TopicName = objvRTPaperRelaEN.TopicName == "[null]" ? null :  objvRTPaperRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTPaperRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.TopicContent = objvRTPaperRelaEN.TopicContent == "[null]" ? null :  objvRTPaperRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTPaperRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.TopicProposePeople = objvRTPaperRelaEN.TopicProposePeople == "[null]" ? null :  objvRTPaperRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTPaperRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperTitle = objvRTPaperRelaEN.PaperTitle == "[null]" ? null :  objvRTPaperRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convRTPaperRela.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperContent = objvRTPaperRelaEN.PaperContent == "[null]" ? null :  objvRTPaperRelaEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convRTPaperRela.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.Author = objvRTPaperRelaEN.Author == "[null]" ? null :  objvRTPaperRelaEN.Author; //作者
}
if (arrFldSet.Contains(convRTPaperRela.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.Periodical = objvRTPaperRelaEN.Periodical == "[null]" ? null :  objvRTPaperRelaEN.Periodical; //期刊
}
if (arrFldSet.Contains(convRTPaperRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.IsSubmit = objvRTPaperRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTPaperRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.IdCurrEduCls = objvRTPaperRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTPaperRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTPaperRela.PaperDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperDate = objvRTPaperRelaEN.PaperDate == "[null]" ? null :  objvRTPaperRelaEN.PaperDate; //PaperDate
}
if (arrFldSet.Contains(convRTPaperRela.PaperStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperStatusId = objvRTPaperRelaEN.PaperStatusId == "[null]" ? null :  objvRTPaperRelaEN.PaperStatusId; //论文状态Id
}
if (arrFldSet.Contains(convRTPaperRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperTypeId = objvRTPaperRelaEN.PaperTypeId == "[null]" ? null :  objvRTPaperRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convRTPaperRela.PaperUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperUserId = objvRTPaperRelaEN.PaperUserId == "[null]" ? null :  objvRTPaperRelaEN.PaperUserId; //PaperUserId
}
if (arrFldSet.Contains(convRTPaperRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.VersionCount = objvRTPaperRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTPaperRela.PaperTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.PaperTypeName = objvRTPaperRelaEN.PaperTypeName == "[null]" ? null :  objvRTPaperRelaEN.PaperTypeName; //论文类型名
}
if (arrFldSet.Contains(convRTPaperRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.UpdDate = objvRTPaperRelaEN.UpdDate == "[null]" ? null :  objvRTPaperRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTPaperRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.UpdUser = objvRTPaperRelaEN.UpdUser == "[null]" ? null :  objvRTPaperRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTPaperRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTPaperRelaEN.Memo = objvRTPaperRelaEN.Memo == "[null]" ? null :  objvRTPaperRelaEN.Memo; //备注
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
 /// <param name = "objvRTPaperRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTPaperRelaEN objvRTPaperRelaEN)
{
try
{
if (objvRTPaperRelaEN.TopicId == "[null]") objvRTPaperRelaEN.TopicId = null; //主题Id
if (objvRTPaperRelaEN.PaperId == "[null]") objvRTPaperRelaEN.PaperId = null; //论文Id
if (objvRTPaperRelaEN.TopicName == "[null]") objvRTPaperRelaEN.TopicName = null; //栏目主题
if (objvRTPaperRelaEN.TopicContent == "[null]") objvRTPaperRelaEN.TopicContent = null; //主题内容
if (objvRTPaperRelaEN.TopicProposePeople == "[null]") objvRTPaperRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTPaperRelaEN.PaperTitle == "[null]") objvRTPaperRelaEN.PaperTitle = null; //论文标题
if (objvRTPaperRelaEN.PaperContent == "[null]") objvRTPaperRelaEN.PaperContent = null; //主题内容
if (objvRTPaperRelaEN.Author == "[null]") objvRTPaperRelaEN.Author = null; //作者
if (objvRTPaperRelaEN.Periodical == "[null]") objvRTPaperRelaEN.Periodical = null; //期刊
if (objvRTPaperRelaEN.IdCurrEduCls == "[null]") objvRTPaperRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTPaperRelaEN.PaperDate == "[null]") objvRTPaperRelaEN.PaperDate = null; //PaperDate
if (objvRTPaperRelaEN.PaperStatusId == "[null]") objvRTPaperRelaEN.PaperStatusId = null; //论文状态Id
if (objvRTPaperRelaEN.PaperTypeId == "[null]") objvRTPaperRelaEN.PaperTypeId = null; //论文类型Id
if (objvRTPaperRelaEN.PaperUserId == "[null]") objvRTPaperRelaEN.PaperUserId = null; //PaperUserId
if (objvRTPaperRelaEN.PaperTypeName == "[null]") objvRTPaperRelaEN.PaperTypeName = null; //论文类型名
if (objvRTPaperRelaEN.UpdDate == "[null]") objvRTPaperRelaEN.UpdDate = null; //修改日期
if (objvRTPaperRelaEN.UpdUser == "[null]") objvRTPaperRelaEN.UpdUser = null; //修改人
if (objvRTPaperRelaEN.Memo == "[null]") objvRTPaperRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvRTPaperRelaEN objvRTPaperRelaEN)
{
 vRTPaperRelaDA.CheckProperty4Condition(objvRTPaperRelaEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTPaperRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTPaperRelaBL没有刷新缓存机制(clsRTPaperRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTPaperRelaObjLstCache == null)
//{
//arrvRTPaperRelaObjLstCache = vRTPaperRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTPaperRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTPaperRelaEN._CurrTabName);
List<clsvRTPaperRelaEN> arrvRTPaperRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTPaperRelaEN> arrvRTPaperRelaObjLst_Sel =
arrvRTPaperRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTPaperRelaObjLst_Sel.Count() == 0)
{
   clsvRTPaperRelaEN obj = clsvRTPaperRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTPaperRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTPaperRelaEN> GetAllvRTPaperRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTPaperRelaEN> arrvRTPaperRelaObjLstCache = GetObjLstCache(); 
return arrvRTPaperRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTPaperRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTPaperRelaEN._CurrTabName);
List<clsvRTPaperRelaEN> arrvRTPaperRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTPaperRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvRTPaperRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convRTPaperRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTPaperRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTPaperRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTPaperRela = clsvRTPaperRelaBL.GetObjBymIdCache(lngmId);
if (objvRTPaperRela == null) return "";
return objvRTPaperRela[strOutFldName].ToString();
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
int intRecCount = clsvRTPaperRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTPaperRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTPaperRelaDA.GetRecCount();
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
int intRecCount = clsvRTPaperRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTPaperRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTPaperRelaEN objvRTPaperRelaCond)
{
List<clsvRTPaperRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTPaperRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTPaperRela.AttributeName)
{
if (objvRTPaperRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTPaperRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTPaperRelaCond[strFldName].ToString());
}
else
{
if (objvRTPaperRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTPaperRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTPaperRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTPaperRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTPaperRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTPaperRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTPaperRelaCond[strFldName]));
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
 List<string> arrList = clsvRTPaperRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTPaperRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTPaperRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}