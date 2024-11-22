
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTConceptRelaBL
 表名:vRTConceptRela(01120607)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:30
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
public static class  clsvRTConceptRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTConceptRelaEN GetObj(this K_mId_vRTConceptRela myKey)
{
clsvRTConceptRelaEN objvRTConceptRelaEN = clsvRTConceptRelaBL.vRTConceptRelaDA.GetObjBymId(myKey.Value);
return objvRTConceptRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetmId(this clsvRTConceptRelaEN objvRTConceptRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTConceptRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.mId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.mId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.mId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetTopicId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTConceptRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTConceptRela.TopicId);
}
objvRTConceptRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.TopicId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.TopicId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.TopicId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetConceptId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConceptId, convRTConceptRela.ConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, convRTConceptRela.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, convRTConceptRela.ConceptId);
}
objvRTConceptRelaEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ConceptId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ConceptId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ConceptId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetUpdDate(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTConceptRela.UpdDate);
}
objvRTConceptRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.UpdDate) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.UpdDate, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.UpdDate] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetMemo(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTConceptRela.Memo);
}
objvRTConceptRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.Memo) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.Memo, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.Memo] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetTopicName(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTConceptRela.TopicName);
}
objvRTConceptRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.TopicName) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.TopicName, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.TopicName] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetTopicContent(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTConceptRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.TopicContent) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.TopicContent, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.TopicContent] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetOrderNum(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvRTConceptRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.OrderNum) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.OrderNum, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.OrderNum] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetTopicProposePeople(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTConceptRela.TopicProposePeople);
}
objvRTConceptRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.TopicProposePeople) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetConceptContent(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strConceptContent, string strComparisonOp="")
	{
objvRTConceptRelaEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ConceptContent) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ConceptContent, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ConceptContent] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetConceptName(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convRTConceptRela.ConceptName);
}
objvRTConceptRelaEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ConceptName) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ConceptName, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ConceptName] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetAppraiseCount(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTConceptRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.AppraiseCount) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetCitationCount(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvRTConceptRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.CitationCount) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.CitationCount, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.CitationCount] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetCitationId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convRTConceptRela.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convRTConceptRela.CitationId);
}
objvRTConceptRelaEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.CitationId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.CitationId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.CitationId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetIsSubmit(this clsvRTConceptRelaEN objvRTConceptRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTConceptRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.IsSubmit) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.IsSubmit, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.IsSubmit] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetScore(this clsvRTConceptRelaEN objvRTConceptRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTConceptRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.Score) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.Score, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.Score] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetStuScore(this clsvRTConceptRelaEN objvRTConceptRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTConceptRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.StuScore) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.StuScore, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.StuScore] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetTeaScore(this clsvRTConceptRelaEN objvRTConceptRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTConceptRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.TeaScore) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.TeaScore, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.TeaScore] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetConcepDate(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strConcepDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConcepDate, 20, convRTConceptRela.ConcepDate);
}
objvRTConceptRelaEN.ConcepDate = strConcepDate; //ConcepDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ConcepDate) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ConcepDate, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ConcepDate] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetConcepUserId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strConcepUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConcepUserId, 50, convRTConceptRela.ConcepUserId);
}
objvRTConceptRelaEN.ConcepUserId = strConcepUserId; //ConcepUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ConcepUserId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ConcepUserId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ConcepUserId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetIdCurrEduCls(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTConceptRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTConceptRela.IdCurrEduCls);
}
objvRTConceptRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.IdCurrEduCls) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetPdfContent(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convRTConceptRela.PdfContent);
}
objvRTConceptRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.PdfContent) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.PdfContent, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.PdfContent] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetPdfPageNum(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvRTConceptRelaEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.PdfPageNum) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.PdfPageNum, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.PdfPageNum] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetOkCount(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTConceptRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.OkCount) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.OkCount, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.OkCount] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetVersionCount(this clsvRTConceptRelaEN objvRTConceptRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvRTConceptRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.VersionCount) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.VersionCount, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.VersionCount] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetCreateDate(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convRTConceptRela.CreateDate);
}
objvRTConceptRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.CreateDate) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.CreateDate, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.CreateDate] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetShareId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convRTConceptRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convRTConceptRela.ShareId);
}
objvRTConceptRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ShareId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ShareId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ShareId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetUpdUser(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTConceptRela.UpdUser);
}
objvRTConceptRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.UpdUser) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.UpdUser, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.UpdUser] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTConceptRelaEN SetClassificationId(this clsvRTConceptRelaEN objvRTConceptRelaEN, string strClassificationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassificationId, 10, convRTConceptRela.ClassificationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassificationId, 10, convRTConceptRela.ClassificationId);
}
objvRTConceptRelaEN.ClassificationId = strClassificationId; //分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTConceptRelaEN.dicFldComparisonOp.ContainsKey(convRTConceptRela.ClassificationId) == false)
{
objvRTConceptRelaEN.dicFldComparisonOp.Add(convRTConceptRela.ClassificationId, strComparisonOp);
}
else
{
objvRTConceptRelaEN.dicFldComparisonOp[convRTConceptRela.ClassificationId] = strComparisonOp;
}
}
return objvRTConceptRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTConceptRelaENS">源对象</param>
 /// <param name = "objvRTConceptRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTConceptRelaEN objvRTConceptRelaENS, clsvRTConceptRelaEN objvRTConceptRelaENT)
{
try
{
objvRTConceptRelaENT.mId = objvRTConceptRelaENS.mId; //mId
objvRTConceptRelaENT.TopicId = objvRTConceptRelaENS.TopicId; //主题Id
objvRTConceptRelaENT.ConceptId = objvRTConceptRelaENS.ConceptId; //概念Id
objvRTConceptRelaENT.UpdDate = objvRTConceptRelaENS.UpdDate; //修改日期
objvRTConceptRelaENT.Memo = objvRTConceptRelaENS.Memo; //备注
objvRTConceptRelaENT.TopicName = objvRTConceptRelaENS.TopicName; //栏目主题
objvRTConceptRelaENT.TopicContent = objvRTConceptRelaENS.TopicContent; //主题内容
objvRTConceptRelaENT.OrderNum = objvRTConceptRelaENS.OrderNum; //序号
objvRTConceptRelaENT.TopicProposePeople = objvRTConceptRelaENS.TopicProposePeople; //主题提出人
objvRTConceptRelaENT.ConceptContent = objvRTConceptRelaENS.ConceptContent; //概念内容
objvRTConceptRelaENT.ConceptName = objvRTConceptRelaENS.ConceptName; //概念名称
objvRTConceptRelaENT.AppraiseCount = objvRTConceptRelaENS.AppraiseCount; //评论数
objvRTConceptRelaENT.CitationCount = objvRTConceptRelaENS.CitationCount; //引用统计
objvRTConceptRelaENT.CitationId = objvRTConceptRelaENS.CitationId; //引用Id
objvRTConceptRelaENT.IsSubmit = objvRTConceptRelaENS.IsSubmit; //是否提交
objvRTConceptRelaENT.Score = objvRTConceptRelaENS.Score; //评分
objvRTConceptRelaENT.StuScore = objvRTConceptRelaENS.StuScore; //学生平均分
objvRTConceptRelaENT.TeaScore = objvRTConceptRelaENS.TeaScore; //教师评分
objvRTConceptRelaENT.ConcepDate = objvRTConceptRelaENS.ConcepDate; //ConcepDate
objvRTConceptRelaENT.ConcepUserId = objvRTConceptRelaENS.ConcepUserId; //ConcepUserId
objvRTConceptRelaENT.IdCurrEduCls = objvRTConceptRelaENS.IdCurrEduCls; //教学班流水号
objvRTConceptRelaENT.PdfContent = objvRTConceptRelaENS.PdfContent; //Pdf内容
objvRTConceptRelaENT.PdfPageNum = objvRTConceptRelaENS.PdfPageNum; //Pdf页码
objvRTConceptRelaENT.OkCount = objvRTConceptRelaENS.OkCount; //点赞统计
objvRTConceptRelaENT.VersionCount = objvRTConceptRelaENS.VersionCount; //版本统计
objvRTConceptRelaENT.CreateDate = objvRTConceptRelaENS.CreateDate; //建立日期
objvRTConceptRelaENT.ShareId = objvRTConceptRelaENS.ShareId; //分享Id
objvRTConceptRelaENT.UpdUser = objvRTConceptRelaENS.UpdUser; //修改人
objvRTConceptRelaENT.ClassificationId = objvRTConceptRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTConceptRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTConceptRelaEN:objvRTConceptRelaENT</returns>
 public static clsvRTConceptRelaEN CopyTo(this clsvRTConceptRelaEN objvRTConceptRelaENS)
{
try
{
 clsvRTConceptRelaEN objvRTConceptRelaENT = new clsvRTConceptRelaEN()
{
mId = objvRTConceptRelaENS.mId, //mId
TopicId = objvRTConceptRelaENS.TopicId, //主题Id
ConceptId = objvRTConceptRelaENS.ConceptId, //概念Id
UpdDate = objvRTConceptRelaENS.UpdDate, //修改日期
Memo = objvRTConceptRelaENS.Memo, //备注
TopicName = objvRTConceptRelaENS.TopicName, //栏目主题
TopicContent = objvRTConceptRelaENS.TopicContent, //主题内容
OrderNum = objvRTConceptRelaENS.OrderNum, //序号
TopicProposePeople = objvRTConceptRelaENS.TopicProposePeople, //主题提出人
ConceptContent = objvRTConceptRelaENS.ConceptContent, //概念内容
ConceptName = objvRTConceptRelaENS.ConceptName, //概念名称
AppraiseCount = objvRTConceptRelaENS.AppraiseCount, //评论数
CitationCount = objvRTConceptRelaENS.CitationCount, //引用统计
CitationId = objvRTConceptRelaENS.CitationId, //引用Id
IsSubmit = objvRTConceptRelaENS.IsSubmit, //是否提交
Score = objvRTConceptRelaENS.Score, //评分
StuScore = objvRTConceptRelaENS.StuScore, //学生平均分
TeaScore = objvRTConceptRelaENS.TeaScore, //教师评分
ConcepDate = objvRTConceptRelaENS.ConcepDate, //ConcepDate
ConcepUserId = objvRTConceptRelaENS.ConcepUserId, //ConcepUserId
IdCurrEduCls = objvRTConceptRelaENS.IdCurrEduCls, //教学班流水号
PdfContent = objvRTConceptRelaENS.PdfContent, //Pdf内容
PdfPageNum = objvRTConceptRelaENS.PdfPageNum, //Pdf页码
OkCount = objvRTConceptRelaENS.OkCount, //点赞统计
VersionCount = objvRTConceptRelaENS.VersionCount, //版本统计
CreateDate = objvRTConceptRelaENS.CreateDate, //建立日期
ShareId = objvRTConceptRelaENS.ShareId, //分享Id
UpdUser = objvRTConceptRelaENS.UpdUser, //修改人
ClassificationId = objvRTConceptRelaENS.ClassificationId, //分类Id
};
 return objvRTConceptRelaENT;
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
public static void CheckProperty4Condition(this clsvRTConceptRelaEN objvRTConceptRelaEN)
{
 clsvRTConceptRelaBL.vRTConceptRelaDA.CheckProperty4Condition(objvRTConceptRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTConceptRelaEN objvRTConceptRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.mId) == true)
{
string strComparisonOpmId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.mId, objvRTConceptRelaCond.mId, strComparisonOpmId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.TopicId, objvRTConceptRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ConceptId) == true)
{
string strComparisonOpConceptId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ConceptId, objvRTConceptRelaCond.ConceptId, strComparisonOpConceptId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.UpdDate, objvRTConceptRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.Memo) == true)
{
string strComparisonOpMemo = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.Memo, objvRTConceptRelaCond.Memo, strComparisonOpMemo);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.TopicName, objvRTConceptRelaCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.OrderNum, objvRTConceptRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.TopicProposePeople, objvRTConceptRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ConceptName) == true)
{
string strComparisonOpConceptName = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ConceptName, objvRTConceptRelaCond.ConceptName, strComparisonOpConceptName);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.AppraiseCount, objvRTConceptRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.CitationCount, objvRTConceptRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.CitationId) == true)
{
string strComparisonOpCitationId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.CitationId, objvRTConceptRelaCond.CitationId, strComparisonOpCitationId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.IsSubmit) == true)
{
if (objvRTConceptRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTConceptRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTConceptRela.IsSubmit);
}
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.Score) == true)
{
string strComparisonOpScore = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.Score, objvRTConceptRelaCond.Score, strComparisonOpScore);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.StuScore, objvRTConceptRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.TeaScore, objvRTConceptRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ConcepDate) == true)
{
string strComparisonOpConcepDate = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ConcepDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ConcepDate, objvRTConceptRelaCond.ConcepDate, strComparisonOpConcepDate);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ConcepUserId) == true)
{
string strComparisonOpConcepUserId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ConcepUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ConcepUserId, objvRTConceptRelaCond.ConcepUserId, strComparisonOpConcepUserId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.IdCurrEduCls, objvRTConceptRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.PdfContent, objvRTConceptRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.PdfPageNum, objvRTConceptRelaCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.OkCount, objvRTConceptRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTConceptRela.VersionCount, objvRTConceptRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.CreateDate, objvRTConceptRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ShareId) == true)
{
string strComparisonOpShareId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ShareId, objvRTConceptRelaCond.ShareId, strComparisonOpShareId);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.UpdUser, objvRTConceptRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTConceptRelaCond.IsUpdated(convRTConceptRela.ClassificationId) == true)
{
string strComparisonOpClassificationId = objvRTConceptRelaCond.dicFldComparisonOp[convRTConceptRela.ClassificationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTConceptRela.ClassificationId, objvRTConceptRelaCond.ClassificationId, strComparisonOpClassificationId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vRTConceptRela(vRTConceptRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvRTConceptRelaEN objvRTConceptRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvRTConceptRelaEN == null) return true;
if (objvRTConceptRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 if (objvRTConceptRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objvRTConceptRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objvRTConceptRelaEN.TopicId);
}
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvRTConceptRelaEN.ConceptId);
if (clsvRTConceptRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objvRTConceptRelaEN.TopicId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvRTConceptRelaEN.ConceptId);
if (clsvRTConceptRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vRTConceptRela(vRTConceptRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvRTConceptRelaEN objvRTConceptRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvRTConceptRelaEN == null) return "";
if (objvRTConceptRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 if (objvRTConceptRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objvRTConceptRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objvRTConceptRelaEN.TopicId);
}
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvRTConceptRelaEN.ConceptId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objvRTConceptRelaEN.TopicId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvRTConceptRelaEN.ConceptId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTConceptRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vRTConceptRela(vRTConceptRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTConceptRelaBL
{
public static RelatedActions_vRTConceptRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTConceptRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTConceptRelaDA vRTConceptRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTConceptRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTConceptRelaBL()
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
if (string.IsNullOrEmpty(clsvRTConceptRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTConceptRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTConceptRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTConceptRelaDA.GetDataTable_vRTConceptRela(strWhereCond);
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
objDT = vRTConceptRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTConceptRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTConceptRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTConceptRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTConceptRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTConceptRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvRTConceptRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
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
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTConceptRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvRTConceptRelaEN._CurrTabName);
List<clsvRTConceptRelaEN> arrvRTConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTConceptRelaEN> arrvRTConceptRelaObjLst_Sel =
arrvRTConceptRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTConceptRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTConceptRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
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
public static List<clsvRTConceptRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTConceptRelaEN> GetSubObjLstCache(clsvRTConceptRelaEN objvRTConceptRelaCond)
{
List<clsvRTConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTConceptRela.AttributeName)
{
if (objvRTConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTConceptRelaCond[strFldName].ToString());
}
else
{
if (objvRTConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTConceptRelaCond[strFldName]));
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
public static List<clsvRTConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
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
public static List<clsvRTConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
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
List<clsvRTConceptRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTConceptRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTConceptRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
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
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
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
public static List<clsvRTConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTConceptRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
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
public static List<clsvRTConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTConceptRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTConceptRela(ref clsvRTConceptRelaEN objvRTConceptRelaEN)
{
bool bolResult = vRTConceptRelaDA.GetvRTConceptRela(ref objvRTConceptRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTConceptRelaEN GetObjBymId(long lngmId)
{
clsvRTConceptRelaEN objvRTConceptRelaEN = vRTConceptRelaDA.GetObjBymId(lngmId);
return objvRTConceptRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTConceptRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTConceptRelaEN objvRTConceptRelaEN = vRTConceptRelaDA.GetFirstObj(strWhereCond);
 return objvRTConceptRelaEN;
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
public static clsvRTConceptRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTConceptRelaEN objvRTConceptRelaEN = vRTConceptRelaDA.GetObjByDataRow(objRow);
 return objvRTConceptRelaEN;
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
public static clsvRTConceptRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTConceptRelaEN objvRTConceptRelaEN = vRTConceptRelaDA.GetObjByDataRow(objRow);
 return objvRTConceptRelaEN;
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
 /// <param name = "lstvRTConceptRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTConceptRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTConceptRelaEN> lstvRTConceptRelaObjLst)
{
foreach (clsvRTConceptRelaEN objvRTConceptRelaEN in lstvRTConceptRelaObjLst)
{
if (objvRTConceptRelaEN.mId == lngmId)
{
return objvRTConceptRelaEN;
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
 lngmId = new clsvRTConceptRelaDA().GetFirstID(strWhereCond);
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
 arrList = vRTConceptRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTConceptRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vRTConceptRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTConceptRelaDA.IsExistTable();
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
 bolIsExist = vRTConceptRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTConceptRelaENS">源对象</param>
 /// <param name = "objvRTConceptRelaENT">目标对象</param>
 public static void CopyTo(clsvRTConceptRelaEN objvRTConceptRelaENS, clsvRTConceptRelaEN objvRTConceptRelaENT)
{
try
{
objvRTConceptRelaENT.mId = objvRTConceptRelaENS.mId; //mId
objvRTConceptRelaENT.TopicId = objvRTConceptRelaENS.TopicId; //主题Id
objvRTConceptRelaENT.ConceptId = objvRTConceptRelaENS.ConceptId; //概念Id
objvRTConceptRelaENT.UpdDate = objvRTConceptRelaENS.UpdDate; //修改日期
objvRTConceptRelaENT.Memo = objvRTConceptRelaENS.Memo; //备注
objvRTConceptRelaENT.TopicName = objvRTConceptRelaENS.TopicName; //栏目主题
objvRTConceptRelaENT.TopicContent = objvRTConceptRelaENS.TopicContent; //主题内容
objvRTConceptRelaENT.OrderNum = objvRTConceptRelaENS.OrderNum; //序号
objvRTConceptRelaENT.TopicProposePeople = objvRTConceptRelaENS.TopicProposePeople; //主题提出人
objvRTConceptRelaENT.ConceptContent = objvRTConceptRelaENS.ConceptContent; //概念内容
objvRTConceptRelaENT.ConceptName = objvRTConceptRelaENS.ConceptName; //概念名称
objvRTConceptRelaENT.AppraiseCount = objvRTConceptRelaENS.AppraiseCount; //评论数
objvRTConceptRelaENT.CitationCount = objvRTConceptRelaENS.CitationCount; //引用统计
objvRTConceptRelaENT.CitationId = objvRTConceptRelaENS.CitationId; //引用Id
objvRTConceptRelaENT.IsSubmit = objvRTConceptRelaENS.IsSubmit; //是否提交
objvRTConceptRelaENT.Score = objvRTConceptRelaENS.Score; //评分
objvRTConceptRelaENT.StuScore = objvRTConceptRelaENS.StuScore; //学生平均分
objvRTConceptRelaENT.TeaScore = objvRTConceptRelaENS.TeaScore; //教师评分
objvRTConceptRelaENT.ConcepDate = objvRTConceptRelaENS.ConcepDate; //ConcepDate
objvRTConceptRelaENT.ConcepUserId = objvRTConceptRelaENS.ConcepUserId; //ConcepUserId
objvRTConceptRelaENT.IdCurrEduCls = objvRTConceptRelaENS.IdCurrEduCls; //教学班流水号
objvRTConceptRelaENT.PdfContent = objvRTConceptRelaENS.PdfContent; //Pdf内容
objvRTConceptRelaENT.PdfPageNum = objvRTConceptRelaENS.PdfPageNum; //Pdf页码
objvRTConceptRelaENT.OkCount = objvRTConceptRelaENS.OkCount; //点赞统计
objvRTConceptRelaENT.VersionCount = objvRTConceptRelaENS.VersionCount; //版本统计
objvRTConceptRelaENT.CreateDate = objvRTConceptRelaENS.CreateDate; //建立日期
objvRTConceptRelaENT.ShareId = objvRTConceptRelaENS.ShareId; //分享Id
objvRTConceptRelaENT.UpdUser = objvRTConceptRelaENS.UpdUser; //修改人
objvRTConceptRelaENT.ClassificationId = objvRTConceptRelaENS.ClassificationId; //分类Id
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
 /// <param name = "objvRTConceptRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
try
{
objvRTConceptRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTConceptRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTConceptRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.mId = objvRTConceptRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTConceptRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.TopicId = objvRTConceptRelaEN.TopicId == "[null]" ? null :  objvRTConceptRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTConceptRela.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ConceptId = objvRTConceptRelaEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(convRTConceptRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.UpdDate = objvRTConceptRelaEN.UpdDate == "[null]" ? null :  objvRTConceptRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTConceptRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.Memo = objvRTConceptRelaEN.Memo == "[null]" ? null :  objvRTConceptRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convRTConceptRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.TopicName = objvRTConceptRelaEN.TopicName == "[null]" ? null :  objvRTConceptRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTConceptRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.TopicContent = objvRTConceptRelaEN.TopicContent == "[null]" ? null :  objvRTConceptRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTConceptRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.OrderNum = objvRTConceptRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convRTConceptRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.TopicProposePeople = objvRTConceptRelaEN.TopicProposePeople == "[null]" ? null :  objvRTConceptRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTConceptRela.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ConceptContent = objvRTConceptRelaEN.ConceptContent == "[null]" ? null :  objvRTConceptRelaEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convRTConceptRela.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ConceptName = objvRTConceptRelaEN.ConceptName == "[null]" ? null :  objvRTConceptRelaEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convRTConceptRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.AppraiseCount = objvRTConceptRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTConceptRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.CitationCount = objvRTConceptRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convRTConceptRela.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.CitationId = objvRTConceptRelaEN.CitationId == "[null]" ? null :  objvRTConceptRelaEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convRTConceptRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.IsSubmit = objvRTConceptRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTConceptRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.Score = objvRTConceptRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTConceptRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.StuScore = objvRTConceptRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTConceptRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.TeaScore = objvRTConceptRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTConceptRela.ConcepDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ConcepDate = objvRTConceptRelaEN.ConcepDate == "[null]" ? null :  objvRTConceptRelaEN.ConcepDate; //ConcepDate
}
if (arrFldSet.Contains(convRTConceptRela.ConcepUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ConcepUserId = objvRTConceptRelaEN.ConcepUserId == "[null]" ? null :  objvRTConceptRelaEN.ConcepUserId; //ConcepUserId
}
if (arrFldSet.Contains(convRTConceptRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.IdCurrEduCls = objvRTConceptRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTConceptRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTConceptRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.PdfContent = objvRTConceptRelaEN.PdfContent == "[null]" ? null :  objvRTConceptRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convRTConceptRela.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.PdfPageNum = objvRTConceptRelaEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convRTConceptRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.OkCount = objvRTConceptRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTConceptRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.VersionCount = objvRTConceptRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convRTConceptRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.CreateDate = objvRTConceptRelaEN.CreateDate == "[null]" ? null :  objvRTConceptRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convRTConceptRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ShareId = objvRTConceptRelaEN.ShareId == "[null]" ? null :  objvRTConceptRelaEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convRTConceptRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.UpdUser = objvRTConceptRelaEN.UpdUser == "[null]" ? null :  objvRTConceptRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTConceptRela.ClassificationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTConceptRelaEN.ClassificationId = objvRTConceptRelaEN.ClassificationId == "[null]" ? null :  objvRTConceptRelaEN.ClassificationId; //分类Id
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
 /// <param name = "objvRTConceptRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
try
{
if (objvRTConceptRelaEN.TopicId == "[null]") objvRTConceptRelaEN.TopicId = null; //主题Id
if (objvRTConceptRelaEN.UpdDate == "[null]") objvRTConceptRelaEN.UpdDate = null; //修改日期
if (objvRTConceptRelaEN.Memo == "[null]") objvRTConceptRelaEN.Memo = null; //备注
if (objvRTConceptRelaEN.TopicName == "[null]") objvRTConceptRelaEN.TopicName = null; //栏目主题
if (objvRTConceptRelaEN.TopicContent == "[null]") objvRTConceptRelaEN.TopicContent = null; //主题内容
if (objvRTConceptRelaEN.TopicProposePeople == "[null]") objvRTConceptRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTConceptRelaEN.ConceptContent == "[null]") objvRTConceptRelaEN.ConceptContent = null; //概念内容
if (objvRTConceptRelaEN.ConceptName == "[null]") objvRTConceptRelaEN.ConceptName = null; //概念名称
if (objvRTConceptRelaEN.CitationId == "[null]") objvRTConceptRelaEN.CitationId = null; //引用Id
if (objvRTConceptRelaEN.ConcepDate == "[null]") objvRTConceptRelaEN.ConcepDate = null; //ConcepDate
if (objvRTConceptRelaEN.ConcepUserId == "[null]") objvRTConceptRelaEN.ConcepUserId = null; //ConcepUserId
if (objvRTConceptRelaEN.IdCurrEduCls == "[null]") objvRTConceptRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTConceptRelaEN.PdfContent == "[null]") objvRTConceptRelaEN.PdfContent = null; //Pdf内容
if (objvRTConceptRelaEN.CreateDate == "[null]") objvRTConceptRelaEN.CreateDate = null; //建立日期
if (objvRTConceptRelaEN.ShareId == "[null]") objvRTConceptRelaEN.ShareId = null; //分享Id
if (objvRTConceptRelaEN.UpdUser == "[null]") objvRTConceptRelaEN.UpdUser = null; //修改人
if (objvRTConceptRelaEN.ClassificationId == "[null]") objvRTConceptRelaEN.ClassificationId = null; //分类Id
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
public static void CheckProperty4Condition(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
 vRTConceptRelaDA.CheckProperty4Condition(objvRTConceptRelaEN);
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
if (clsRTConceptRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTConceptRelaBL没有刷新缓存机制(clsRTConceptRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTConceptRelaObjLstCache == null)
//{
//arrvRTConceptRelaObjLstCache = vRTConceptRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTConceptRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvRTConceptRelaEN._CurrTabName);
List<clsvRTConceptRelaEN> arrvRTConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvRTConceptRelaEN> arrvRTConceptRelaObjLst_Sel =
arrvRTConceptRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTConceptRelaObjLst_Sel.Count() == 0)
{
   clsvRTConceptRelaEN obj = clsvRTConceptRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvRTConceptRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTConceptRelaEN> GetAllvRTConceptRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvRTConceptRelaEN> arrvRTConceptRelaObjLstCache = GetObjLstCache(); 
return arrvRTConceptRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTConceptRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvRTConceptRelaEN._CurrTabName);
List<clsvRTConceptRelaEN> arrvRTConceptRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvRTConceptRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvRTConceptRelaEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela)
 /// 唯一性条件:mId_TopicId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
//检测记录是否存在
string strResult = vRTConceptRelaDA.GetUniCondStr(objvRTConceptRelaEN);
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
if (strInFldName != convRTConceptRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTConceptRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTConceptRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTConceptRela = clsvRTConceptRelaBL.GetObjBymIdCache(lngmId);
if (objvRTConceptRela == null) return "";
return objvRTConceptRela[strOutFldName].ToString();
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
int intRecCount = clsvRTConceptRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTConceptRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTConceptRelaDA.GetRecCount();
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
int intRecCount = clsvRTConceptRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTConceptRelaEN objvRTConceptRelaCond)
{
List<clsvRTConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvRTConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTConceptRela.AttributeName)
{
if (objvRTConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTConceptRelaCond[strFldName].ToString());
}
else
{
if (objvRTConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTConceptRelaCond[strFldName]));
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
 List<string> arrList = clsvRTConceptRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTConceptRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTConceptRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}