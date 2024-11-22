
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupQuestionRelaBL
 表名:vzx_GroupQuestionRela(01120736)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clsvzx_GroupQuestionRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_GroupQuestionRelaEN GetObj(this K_mId_vzx_GroupQuestionRela myKey)
{
clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = clsvzx_GroupQuestionRelaBL.vzx_GroupQuestionRelaDA.GetObjBymId(myKey.Value);
return objvzx_GroupQuestionRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetGroupTextName(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_GroupQuestionRela.GroupTextName);
}
objvzx_GroupQuestionRelaEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.GroupTextName) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.GroupTextName, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.GroupTextName] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetmId(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, long lngmId, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.mId) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.mId, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.mId] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetGroupTextId(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_GroupQuestionRela.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_GroupQuestionRela.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_GroupQuestionRela.GroupTextId);
}
objvzx_GroupQuestionRelaEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.GroupTextId) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.GroupTextId, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.GroupTextId] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetzxQuestionsId(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strzxQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsId, convzx_GroupQuestionRela.zxQuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, convzx_GroupQuestionRela.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, convzx_GroupQuestionRela.zxQuestionsId);
}
objvzx_GroupQuestionRelaEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.zxQuestionsId) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.zxQuestionsId, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.zxQuestionsId] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetUpdDate(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_GroupQuestionRela.UpdDate);
}
objvzx_GroupQuestionRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.UpdDate) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.UpdDate, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.UpdDate] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetUpdUser(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_GroupQuestionRela.UpdUser);
}
objvzx_GroupQuestionRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.UpdUser) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.UpdUser, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.UpdUser] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetMemo(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_GroupQuestionRela.Memo);
}
objvzx_GroupQuestionRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.Memo) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.Memo, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.Memo] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetQuestionsContent(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convzx_GroupQuestionRela.QuestionsContent);
}
objvzx_GroupQuestionRelaEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.QuestionsContent) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.QuestionsContent, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.QuestionsContent] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfPageNum(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfPageNum) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfPageNum, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageNum] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfContent(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_GroupQuestionRela.PdfContent);
}
objvzx_GroupQuestionRelaEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfContent) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfContent, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfContent] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetIsPublic(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.IsPublic) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.IsPublic, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.IsPublic] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetIsEnd(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, bool bolIsEnd, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.IsEnd = bolIsEnd; //是否结束
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.IsEnd) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.IsEnd, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.IsEnd] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetIsDelete(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, bool bolIsDelete, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.IsDelete) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.IsDelete, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.IsDelete] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetVoteCount(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.VoteCount) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.VoteCount, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.VoteCount] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetAnswerCount(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, int? intAnswerCount, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.AnswerCount) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.AnswerCount, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.AnswerCount] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetOrderNum(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.OrderNum) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.OrderNum, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.OrderNum] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfPageTop(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_GroupQuestionRelaEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfPageTop) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfPageTop, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageTop] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfPageNumIn(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_GroupQuestionRela.PdfPageNumIn);
}
objvzx_GroupQuestionRelaEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfPageNumIn) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfDivTop(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_GroupQuestionRela.PdfDivTop);
}
objvzx_GroupQuestionRelaEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfDivTop) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfDivTop, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfDivTop] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfDivLet(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_GroupQuestionRela.PdfDivLet);
}
objvzx_GroupQuestionRelaEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfDivLet) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfDivLet, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfDivLet] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetPdfZoom(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_GroupQuestionRela.PdfZoom);
}
objvzx_GroupQuestionRelaEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.PdfZoom) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.PdfZoom, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.PdfZoom] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetQuestionType(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strQuestionType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionType, 2, convzx_GroupQuestionRela.QuestionType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionType, 2, convzx_GroupQuestionRela.QuestionType);
}
objvzx_GroupQuestionRelaEN.QuestionType = strQuestionType; //个人01小组02
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.QuestionType) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.QuestionType, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.QuestionType] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_GroupQuestionRelaEN SetTextId(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_GroupQuestionRela.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_GroupQuestionRela.TextId);
}
objvzx_GroupQuestionRelaEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_GroupQuestionRelaEN.dicFldComparisonOp.ContainsKey(convzx_GroupQuestionRela.TextId) == false)
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp.Add(convzx_GroupQuestionRela.TextId, strComparisonOp);
}
else
{
objvzx_GroupQuestionRelaEN.dicFldComparisonOp[convzx_GroupQuestionRela.TextId] = strComparisonOp;
}
}
return objvzx_GroupQuestionRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <param name = "objvzx_GroupQuestionRelaENT">目标对象</param>
 public static void CopyTo(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENS, clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENT)
{
try
{
objvzx_GroupQuestionRelaENT.GroupTextName = objvzx_GroupQuestionRelaENS.GroupTextName; //小组名称
objvzx_GroupQuestionRelaENT.mId = objvzx_GroupQuestionRelaENS.mId; //mId
objvzx_GroupQuestionRelaENT.GroupTextId = objvzx_GroupQuestionRelaENS.GroupTextId; //小组Id
objvzx_GroupQuestionRelaENT.zxQuestionsId = objvzx_GroupQuestionRelaENS.zxQuestionsId; //提问Id
objvzx_GroupQuestionRelaENT.UpdDate = objvzx_GroupQuestionRelaENS.UpdDate; //修改日期
objvzx_GroupQuestionRelaENT.UpdUser = objvzx_GroupQuestionRelaENS.UpdUser; //修改人
objvzx_GroupQuestionRelaENT.Memo = objvzx_GroupQuestionRelaENS.Memo; //备注
objvzx_GroupQuestionRelaENT.QuestionsContent = objvzx_GroupQuestionRelaENS.QuestionsContent; //提问内容
objvzx_GroupQuestionRelaENT.PdfPageNum = objvzx_GroupQuestionRelaENS.PdfPageNum; //Pdf页码
objvzx_GroupQuestionRelaENT.PdfContent = objvzx_GroupQuestionRelaENS.PdfContent; //Pdf内容
objvzx_GroupQuestionRelaENT.IsPublic = objvzx_GroupQuestionRelaENS.IsPublic; //是否公开
objvzx_GroupQuestionRelaENT.IsEnd = objvzx_GroupQuestionRelaENS.IsEnd; //是否结束
objvzx_GroupQuestionRelaENT.IsDelete = objvzx_GroupQuestionRelaENS.IsDelete; //是否删除
objvzx_GroupQuestionRelaENT.VoteCount = objvzx_GroupQuestionRelaENS.VoteCount; //点赞计数
objvzx_GroupQuestionRelaENT.AnswerCount = objvzx_GroupQuestionRelaENS.AnswerCount; //回答计数
objvzx_GroupQuestionRelaENT.OrderNum = objvzx_GroupQuestionRelaENS.OrderNum; //序号
objvzx_GroupQuestionRelaENT.PdfPageTop = objvzx_GroupQuestionRelaENS.PdfPageTop; //pdf页面顶部位置
objvzx_GroupQuestionRelaENT.PdfPageNumIn = objvzx_GroupQuestionRelaENS.PdfPageNumIn; //PdfPageNumIn
objvzx_GroupQuestionRelaENT.PdfDivTop = objvzx_GroupQuestionRelaENS.PdfDivTop; //PdfDivTop
objvzx_GroupQuestionRelaENT.PdfDivLet = objvzx_GroupQuestionRelaENS.PdfDivLet; //PdfDivLet
objvzx_GroupQuestionRelaENT.PdfZoom = objvzx_GroupQuestionRelaENS.PdfZoom; //PdfZoom
objvzx_GroupQuestionRelaENT.QuestionType = objvzx_GroupQuestionRelaENS.QuestionType; //个人01小组02
objvzx_GroupQuestionRelaENT.TextId = objvzx_GroupQuestionRelaENS.TextId; //课件Id
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
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvzx_GroupQuestionRelaEN:objvzx_GroupQuestionRelaENT</returns>
 public static clsvzx_GroupQuestionRelaEN CopyTo(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENS)
{
try
{
 clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENT = new clsvzx_GroupQuestionRelaEN()
{
GroupTextName = objvzx_GroupQuestionRelaENS.GroupTextName, //小组名称
mId = objvzx_GroupQuestionRelaENS.mId, //mId
GroupTextId = objvzx_GroupQuestionRelaENS.GroupTextId, //小组Id
zxQuestionsId = objvzx_GroupQuestionRelaENS.zxQuestionsId, //提问Id
UpdDate = objvzx_GroupQuestionRelaENS.UpdDate, //修改日期
UpdUser = objvzx_GroupQuestionRelaENS.UpdUser, //修改人
Memo = objvzx_GroupQuestionRelaENS.Memo, //备注
QuestionsContent = objvzx_GroupQuestionRelaENS.QuestionsContent, //提问内容
PdfPageNum = objvzx_GroupQuestionRelaENS.PdfPageNum, //Pdf页码
PdfContent = objvzx_GroupQuestionRelaENS.PdfContent, //Pdf内容
IsPublic = objvzx_GroupQuestionRelaENS.IsPublic, //是否公开
IsEnd = objvzx_GroupQuestionRelaENS.IsEnd, //是否结束
IsDelete = objvzx_GroupQuestionRelaENS.IsDelete, //是否删除
VoteCount = objvzx_GroupQuestionRelaENS.VoteCount, //点赞计数
AnswerCount = objvzx_GroupQuestionRelaENS.AnswerCount, //回答计数
OrderNum = objvzx_GroupQuestionRelaENS.OrderNum, //序号
PdfPageTop = objvzx_GroupQuestionRelaENS.PdfPageTop, //pdf页面顶部位置
PdfPageNumIn = objvzx_GroupQuestionRelaENS.PdfPageNumIn, //PdfPageNumIn
PdfDivTop = objvzx_GroupQuestionRelaENS.PdfDivTop, //PdfDivTop
PdfDivLet = objvzx_GroupQuestionRelaENS.PdfDivLet, //PdfDivLet
PdfZoom = objvzx_GroupQuestionRelaENS.PdfZoom, //PdfZoom
QuestionType = objvzx_GroupQuestionRelaENS.QuestionType, //个人01小组02
TextId = objvzx_GroupQuestionRelaENS.TextId, //课件Id
};
 return objvzx_GroupQuestionRelaENT;
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
public static void CheckProperty4Condition(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
 clsvzx_GroupQuestionRelaBL.vzx_GroupQuestionRelaDA.CheckProperty4Condition(objvzx_GroupQuestionRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.GroupTextName, objvzx_GroupQuestionRelaCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.mId) == true)
{
string strComparisonOpmId = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.mId, objvzx_GroupQuestionRelaCond.mId, strComparisonOpmId);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.GroupTextId, objvzx_GroupQuestionRelaCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.zxQuestionsId, objvzx_GroupQuestionRelaCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.UpdDate, objvzx_GroupQuestionRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.UpdUser, objvzx_GroupQuestionRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.Memo) == true)
{
string strComparisonOpMemo = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.Memo, objvzx_GroupQuestionRelaCond.Memo, strComparisonOpMemo);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.QuestionsContent, objvzx_GroupQuestionRelaCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.PdfPageNum, objvzx_GroupQuestionRelaCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.PdfContent, objvzx_GroupQuestionRelaCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.IsPublic) == true)
{
if (objvzx_GroupQuestionRelaCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_GroupQuestionRela.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_GroupQuestionRela.IsPublic);
}
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.IsEnd) == true)
{
if (objvzx_GroupQuestionRelaCond.IsEnd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_GroupQuestionRela.IsEnd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_GroupQuestionRela.IsEnd);
}
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.IsDelete) == true)
{
if (objvzx_GroupQuestionRelaCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_GroupQuestionRela.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_GroupQuestionRela.IsDelete);
}
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.VoteCount, objvzx_GroupQuestionRelaCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.AnswerCount, objvzx_GroupQuestionRelaCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.OrderNum, objvzx_GroupQuestionRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_GroupQuestionRela.PdfPageTop, objvzx_GroupQuestionRelaCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.PdfPageNumIn, objvzx_GroupQuestionRelaCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.PdfDivTop, objvzx_GroupQuestionRelaCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.PdfDivLet, objvzx_GroupQuestionRelaCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.PdfZoom, objvzx_GroupQuestionRelaCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.QuestionType) == true)
{
string strComparisonOpQuestionType = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.QuestionType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.QuestionType, objvzx_GroupQuestionRelaCond.QuestionType, strComparisonOpQuestionType);
}
if (objvzx_GroupQuestionRelaCond.IsUpdated(convzx_GroupQuestionRela.TextId) == true)
{
string strComparisonOpTextId = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[convzx_GroupQuestionRela.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_GroupQuestionRela.TextId, objvzx_GroupQuestionRelaCond.TextId, strComparisonOpTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vzx_GroupQuestionRela(小组问题关系视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvzx_GroupQuestionRelaEN == null) return true;
if (objvzx_GroupQuestionRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objvzx_GroupQuestionRelaEN.GroupTextId);
if (clsvzx_GroupQuestionRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvzx_GroupQuestionRelaEN.mId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objvzx_GroupQuestionRelaEN.GroupTextId);
if (clsvzx_GroupQuestionRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vzx_GroupQuestionRela(小组问题关系视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvzx_GroupQuestionRelaEN == null) return "";
if (objvzx_GroupQuestionRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objvzx_GroupQuestionRelaEN.GroupTextId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvzx_GroupQuestionRelaEN.mId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objvzx_GroupQuestionRelaEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_GroupQuestionRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 小组问题关系视图(vzx_GroupQuestionRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_GroupQuestionRelaBL
{
public static RelatedActions_vzx_GroupQuestionRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_GroupQuestionRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_GroupQuestionRelaDA vzx_GroupQuestionRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_GroupQuestionRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_GroupQuestionRelaBL()
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
if (string.IsNullOrEmpty(clsvzx_GroupQuestionRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_GroupQuestionRelaEN._ConnectString);
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
public static DataTable GetDataTable_vzx_GroupQuestionRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_GroupQuestionRelaDA.GetDataTable_vzx_GroupQuestionRela(strWhereCond);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable(strWhereCond);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_GroupQuestionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
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
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_GroupQuestionRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvzx_GroupQuestionRelaEN._CurrTabName);
List<clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLst_Sel =
arrvzx_GroupQuestionRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvzx_GroupQuestionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetObjLst(string strWhereCond)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_GroupQuestionRelaEN> GetSubObjLstCache(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaCond)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupQuestionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_GroupQuestionRela.AttributeName)
{
if (objvzx_GroupQuestionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_GroupQuestionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupQuestionRelaCond[strFldName].ToString());
}
else
{
if (objvzx_GroupQuestionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupQuestionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_GroupQuestionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_GroupQuestionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_GroupQuestionRelaCond[strFldName]));
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
List<clsvzx_GroupQuestionRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_GroupQuestionRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_GroupQuestionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
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
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
public static List<clsvzx_GroupQuestionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
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
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLst = new List<clsvzx_GroupQuestionRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = new clsvzx_GroupQuestionRelaEN();
try
{
objvzx_GroupQuestionRelaEN.GroupTextName = objRow[convzx_GroupQuestionRela.GroupTextName] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.GroupTextName].ToString().Trim(); //小组名称
objvzx_GroupQuestionRelaEN.mId = Int32.Parse(objRow[convzx_GroupQuestionRela.mId].ToString().Trim()); //mId
objvzx_GroupQuestionRelaEN.GroupTextId = objRow[convzx_GroupQuestionRela.GroupTextId].ToString().Trim(); //小组Id
objvzx_GroupQuestionRelaEN.zxQuestionsId = objRow[convzx_GroupQuestionRela.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_GroupQuestionRelaEN.UpdDate = objRow[convzx_GroupQuestionRela.UpdDate] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdDate].ToString().Trim(); //修改日期
objvzx_GroupQuestionRelaEN.UpdUser = objRow[convzx_GroupQuestionRela.UpdUser] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.UpdUser].ToString().Trim(); //修改人
objvzx_GroupQuestionRelaEN.Memo = objRow[convzx_GroupQuestionRela.Memo] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.Memo].ToString().Trim(); //备注
objvzx_GroupQuestionRelaEN.QuestionsContent = objRow[convzx_GroupQuestionRela.QuestionsContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionsContent].ToString().Trim(); //提问内容
objvzx_GroupQuestionRelaEN.PdfPageNum = objRow[convzx_GroupQuestionRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_GroupQuestionRelaEN.PdfContent = objRow[convzx_GroupQuestionRela.PdfContent] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfContent].ToString().Trim(); //Pdf内容
objvzx_GroupQuestionRelaEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsPublic].ToString().Trim()); //是否公开
objvzx_GroupQuestionRelaEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsEnd].ToString().Trim()); //是否结束
objvzx_GroupQuestionRelaEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_GroupQuestionRela.IsDelete].ToString().Trim()); //是否删除
objvzx_GroupQuestionRelaEN.VoteCount = objRow[convzx_GroupQuestionRela.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.VoteCount].ToString().Trim()); //点赞计数
objvzx_GroupQuestionRelaEN.AnswerCount = objRow[convzx_GroupQuestionRela.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.AnswerCount].ToString().Trim()); //回答计数
objvzx_GroupQuestionRelaEN.OrderNum = objRow[convzx_GroupQuestionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.OrderNum].ToString().Trim()); //序号
objvzx_GroupQuestionRelaEN.PdfPageTop = objRow[convzx_GroupQuestionRela.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_GroupQuestionRela.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objRow[convzx_GroupQuestionRela.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_GroupQuestionRelaEN.PdfDivTop = objRow[convzx_GroupQuestionRela.PdfDivTop] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_GroupQuestionRelaEN.PdfDivLet = objRow[convzx_GroupQuestionRela.PdfDivLet] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_GroupQuestionRelaEN.PdfZoom = objRow[convzx_GroupQuestionRela.PdfZoom] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_GroupQuestionRelaEN.QuestionType = objRow[convzx_GroupQuestionRela.QuestionType] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.QuestionType].ToString().Trim(); //个人01小组02
objvzx_GroupQuestionRelaEN.TextId = objRow[convzx_GroupQuestionRela.TextId] == DBNull.Value ? null : objRow[convzx_GroupQuestionRela.TextId].ToString().Trim(); //课件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_GroupQuestionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_GroupQuestionRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_GroupQuestionRela(ref clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
bool bolResult = vzx_GroupQuestionRelaDA.Getvzx_GroupQuestionRela(ref objvzx_GroupQuestionRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_GroupQuestionRelaEN GetObjBymId(long lngmId)
{
clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = vzx_GroupQuestionRelaDA.GetObjBymId(lngmId);
return objvzx_GroupQuestionRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_GroupQuestionRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = vzx_GroupQuestionRelaDA.GetFirstObj(strWhereCond);
 return objvzx_GroupQuestionRelaEN;
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
public static clsvzx_GroupQuestionRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = vzx_GroupQuestionRelaDA.GetObjByDataRow(objRow);
 return objvzx_GroupQuestionRelaEN;
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
public static clsvzx_GroupQuestionRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN = vzx_GroupQuestionRelaDA.GetObjByDataRow(objRow);
 return objvzx_GroupQuestionRelaEN;
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
 /// <param name = "lstvzx_GroupQuestionRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_GroupQuestionRelaEN GetObjBymIdFromList(long lngmId, List<clsvzx_GroupQuestionRelaEN> lstvzx_GroupQuestionRelaObjLst)
{
foreach (clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN in lstvzx_GroupQuestionRelaObjLst)
{
if (objvzx_GroupQuestionRelaEN.mId == lngmId)
{
return objvzx_GroupQuestionRelaEN;
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
 lngmId = new clsvzx_GroupQuestionRelaDA().GetFirstID(strWhereCond);
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
 arrList = vzx_GroupQuestionRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_GroupQuestionRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_GroupQuestionRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvzx_GroupQuestionRelaDA.IsExistTable();
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
 bolIsExist = vzx_GroupQuestionRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_GroupQuestionRelaENS">源对象</param>
 /// <param name = "objvzx_GroupQuestionRelaENT">目标对象</param>
 public static void CopyTo(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENS, clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaENT)
{
try
{
objvzx_GroupQuestionRelaENT.GroupTextName = objvzx_GroupQuestionRelaENS.GroupTextName; //小组名称
objvzx_GroupQuestionRelaENT.mId = objvzx_GroupQuestionRelaENS.mId; //mId
objvzx_GroupQuestionRelaENT.GroupTextId = objvzx_GroupQuestionRelaENS.GroupTextId; //小组Id
objvzx_GroupQuestionRelaENT.zxQuestionsId = objvzx_GroupQuestionRelaENS.zxQuestionsId; //提问Id
objvzx_GroupQuestionRelaENT.UpdDate = objvzx_GroupQuestionRelaENS.UpdDate; //修改日期
objvzx_GroupQuestionRelaENT.UpdUser = objvzx_GroupQuestionRelaENS.UpdUser; //修改人
objvzx_GroupQuestionRelaENT.Memo = objvzx_GroupQuestionRelaENS.Memo; //备注
objvzx_GroupQuestionRelaENT.QuestionsContent = objvzx_GroupQuestionRelaENS.QuestionsContent; //提问内容
objvzx_GroupQuestionRelaENT.PdfPageNum = objvzx_GroupQuestionRelaENS.PdfPageNum; //Pdf页码
objvzx_GroupQuestionRelaENT.PdfContent = objvzx_GroupQuestionRelaENS.PdfContent; //Pdf内容
objvzx_GroupQuestionRelaENT.IsPublic = objvzx_GroupQuestionRelaENS.IsPublic; //是否公开
objvzx_GroupQuestionRelaENT.IsEnd = objvzx_GroupQuestionRelaENS.IsEnd; //是否结束
objvzx_GroupQuestionRelaENT.IsDelete = objvzx_GroupQuestionRelaENS.IsDelete; //是否删除
objvzx_GroupQuestionRelaENT.VoteCount = objvzx_GroupQuestionRelaENS.VoteCount; //点赞计数
objvzx_GroupQuestionRelaENT.AnswerCount = objvzx_GroupQuestionRelaENS.AnswerCount; //回答计数
objvzx_GroupQuestionRelaENT.OrderNum = objvzx_GroupQuestionRelaENS.OrderNum; //序号
objvzx_GroupQuestionRelaENT.PdfPageTop = objvzx_GroupQuestionRelaENS.PdfPageTop; //pdf页面顶部位置
objvzx_GroupQuestionRelaENT.PdfPageNumIn = objvzx_GroupQuestionRelaENS.PdfPageNumIn; //PdfPageNumIn
objvzx_GroupQuestionRelaENT.PdfDivTop = objvzx_GroupQuestionRelaENS.PdfDivTop; //PdfDivTop
objvzx_GroupQuestionRelaENT.PdfDivLet = objvzx_GroupQuestionRelaENS.PdfDivLet; //PdfDivLet
objvzx_GroupQuestionRelaENT.PdfZoom = objvzx_GroupQuestionRelaENS.PdfZoom; //PdfZoom
objvzx_GroupQuestionRelaENT.QuestionType = objvzx_GroupQuestionRelaENS.QuestionType; //个人01小组02
objvzx_GroupQuestionRelaENT.TextId = objvzx_GroupQuestionRelaENS.TextId; //课件Id
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
 /// <param name = "objvzx_GroupQuestionRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
try
{
objvzx_GroupQuestionRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_GroupQuestionRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_GroupQuestionRela.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.GroupTextName = objvzx_GroupQuestionRelaEN.GroupTextName == "[null]" ? null :  objvzx_GroupQuestionRelaEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.mId = objvzx_GroupQuestionRelaEN.mId; //mId
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.GroupTextId = objvzx_GroupQuestionRelaEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.zxQuestionsId = objvzx_GroupQuestionRelaEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.UpdDate = objvzx_GroupQuestionRelaEN.UpdDate == "[null]" ? null :  objvzx_GroupQuestionRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.UpdUser = objvzx_GroupQuestionRelaEN.UpdUser == "[null]" ? null :  objvzx_GroupQuestionRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.Memo = objvzx_GroupQuestionRelaEN.Memo == "[null]" ? null :  objvzx_GroupQuestionRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.QuestionsContent = objvzx_GroupQuestionRelaEN.QuestionsContent == "[null]" ? null :  objvzx_GroupQuestionRelaEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfPageNum = objvzx_GroupQuestionRelaEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfContent = objvzx_GroupQuestionRelaEN.PdfContent == "[null]" ? null :  objvzx_GroupQuestionRelaEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.IsPublic = objvzx_GroupQuestionRelaEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.IsEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.IsEnd = objvzx_GroupQuestionRelaEN.IsEnd; //是否结束
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.IsDelete = objvzx_GroupQuestionRelaEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.VoteCount = objvzx_GroupQuestionRelaEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.AnswerCount = objvzx_GroupQuestionRelaEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.OrderNum = objvzx_GroupQuestionRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfPageTop = objvzx_GroupQuestionRelaEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfPageNumIn = objvzx_GroupQuestionRelaEN.PdfPageNumIn == "[null]" ? null :  objvzx_GroupQuestionRelaEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfDivTop = objvzx_GroupQuestionRelaEN.PdfDivTop == "[null]" ? null :  objvzx_GroupQuestionRelaEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfDivLet = objvzx_GroupQuestionRelaEN.PdfDivLet == "[null]" ? null :  objvzx_GroupQuestionRelaEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.PdfZoom = objvzx_GroupQuestionRelaEN.PdfZoom == "[null]" ? null :  objvzx_GroupQuestionRelaEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.QuestionType, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.QuestionType = objvzx_GroupQuestionRelaEN.QuestionType == "[null]" ? null :  objvzx_GroupQuestionRelaEN.QuestionType; //个人01小组02
}
if (arrFldSet.Contains(convzx_GroupQuestionRela.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_GroupQuestionRelaEN.TextId = objvzx_GroupQuestionRelaEN.TextId == "[null]" ? null :  objvzx_GroupQuestionRelaEN.TextId; //课件Id
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
 /// <param name = "objvzx_GroupQuestionRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
try
{
if (objvzx_GroupQuestionRelaEN.GroupTextName == "[null]") objvzx_GroupQuestionRelaEN.GroupTextName = null; //小组名称
if (objvzx_GroupQuestionRelaEN.UpdDate == "[null]") objvzx_GroupQuestionRelaEN.UpdDate = null; //修改日期
if (objvzx_GroupQuestionRelaEN.UpdUser == "[null]") objvzx_GroupQuestionRelaEN.UpdUser = null; //修改人
if (objvzx_GroupQuestionRelaEN.Memo == "[null]") objvzx_GroupQuestionRelaEN.Memo = null; //备注
if (objvzx_GroupQuestionRelaEN.QuestionsContent == "[null]") objvzx_GroupQuestionRelaEN.QuestionsContent = null; //提问内容
if (objvzx_GroupQuestionRelaEN.PdfContent == "[null]") objvzx_GroupQuestionRelaEN.PdfContent = null; //Pdf内容
if (objvzx_GroupQuestionRelaEN.PdfPageNumIn == "[null]") objvzx_GroupQuestionRelaEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_GroupQuestionRelaEN.PdfDivTop == "[null]") objvzx_GroupQuestionRelaEN.PdfDivTop = null; //PdfDivTop
if (objvzx_GroupQuestionRelaEN.PdfDivLet == "[null]") objvzx_GroupQuestionRelaEN.PdfDivLet = null; //PdfDivLet
if (objvzx_GroupQuestionRelaEN.PdfZoom == "[null]") objvzx_GroupQuestionRelaEN.PdfZoom = null; //PdfZoom
if (objvzx_GroupQuestionRelaEN.QuestionType == "[null]") objvzx_GroupQuestionRelaEN.QuestionType = null; //个人01小组02
if (objvzx_GroupQuestionRelaEN.TextId == "[null]") objvzx_GroupQuestionRelaEN.TextId = null; //课件Id
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
public static void CheckProperty4Condition(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
 vzx_GroupQuestionRelaDA.CheckProperty4Condition(objvzx_GroupQuestionRelaEN);
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
if (clszx_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsBL没有刷新缓存机制(clszx_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupQuestionRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupQuestionRelaBL没有刷新缓存机制(clszx_GroupQuestionRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvzx_GroupQuestionRelaObjLstCache == null)
//{
//arrvzx_GroupQuestionRelaObjLstCache = vzx_GroupQuestionRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_GroupQuestionRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_GroupQuestionRelaEN._CurrTabName);
List<clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLst_Sel =
arrvzx_GroupQuestionRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvzx_GroupQuestionRelaObjLst_Sel.Count() == 0)
{
   clsvzx_GroupQuestionRelaEN obj = clsvzx_GroupQuestionRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_GroupQuestionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetAllvzx_GroupQuestionRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLstCache = GetObjLstCache(); 
return arrvzx_GroupQuestionRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_GroupQuestionRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_GroupQuestionRelaEN._CurrTabName);
List<clsvzx_GroupQuestionRelaEN> arrvzx_GroupQuestionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_GroupQuestionRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_GroupQuestionRelaEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vzx_GroupQuestionRela(小组问题关系视图)
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaEN)
{
//检测记录是否存在
string strResult = vzx_GroupQuestionRelaDA.GetUniCondStr(objvzx_GroupQuestionRelaEN);
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
if (strInFldName != convzx_GroupQuestionRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_GroupQuestionRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_GroupQuestionRela.AttributeName));
throw new Exception(strMsg);
}
var objvzx_GroupQuestionRela = clsvzx_GroupQuestionRelaBL.GetObjBymIdCache(lngmId);
if (objvzx_GroupQuestionRela == null) return "";
return objvzx_GroupQuestionRela[strOutFldName].ToString();
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
int intRecCount = clsvzx_GroupQuestionRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_GroupQuestionRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_GroupQuestionRelaDA.GetRecCount();
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
int intRecCount = clsvzx_GroupQuestionRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_GroupQuestionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_GroupQuestionRelaEN objvzx_GroupQuestionRelaCond)
{
List<clsvzx_GroupQuestionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_GroupQuestionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_GroupQuestionRela.AttributeName)
{
if (objvzx_GroupQuestionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvzx_GroupQuestionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupQuestionRelaCond[strFldName].ToString());
}
else
{
if (objvzx_GroupQuestionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_GroupQuestionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_GroupQuestionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_GroupQuestionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_GroupQuestionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_GroupQuestionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_GroupQuestionRelaCond[strFldName]));
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
 List<string> arrList = clsvzx_GroupQuestionRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_GroupQuestionRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_GroupQuestionRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}