
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextReadBL
 表名:vzx_TextRead(01120732)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:51:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_TextReadBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TextReadEN GetObj(this K_TextRId_vzx_TextRead myKey)
{
clsvzx_TextReadEN objvzx_TextReadEN = clsvzx_TextReadBL.vzx_TextReadDA.GetObjByTextRId(myKey.Value);
return objvzx_TextReadEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetTextTitle(this clsvzx_TextReadEN objvzx_TextReadEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_TextRead.TextTitle);
}
objvzx_TextReadEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.TextTitle) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.TextTitle, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.TextTitle] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetTextRId(this clsvzx_TextReadEN objvzx_TextReadEN, string strTextRId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextRId, 10, convzx_TextRead.TextRId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextRId, 10, convzx_TextRead.TextRId);
}
objvzx_TextReadEN.TextRId = strTextRId; //TextRId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.TextRId) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.TextRId, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.TextRId] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetReaderUserId(this clsvzx_TextReadEN objvzx_TextReadEN, string strReaderUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReaderUserId, 20, convzx_TextRead.ReaderUserId);
}
objvzx_TextReadEN.ReaderUserId = strReaderUserId; //ReaderUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.ReaderUserId) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.ReaderUserId, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.ReaderUserId] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetTextId(this clsvzx_TextReadEN objvzx_TextReadEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_TextRead.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_TextRead.TextId);
}
objvzx_TextReadEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.TextId) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.TextId, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.TextId] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetReadTypeId(this clsvzx_TextReadEN objvzx_TextReadEN, string strReadTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReadTypeId, convzx_TextRead.ReadTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReadTypeId, 2, convzx_TextRead.ReadTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReadTypeId, 2, convzx_TextRead.ReadTypeId);
}
objvzx_TextReadEN.ReadTypeId = strReadTypeId; //阅读类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.ReadTypeId) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.ReadTypeId, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.ReadTypeId] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetIsSubmit(this clsvzx_TextReadEN objvzx_TextReadEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_TextReadEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.IsSubmit) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.IsSubmit, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.IsSubmit] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetIsPublic(this clsvzx_TextReadEN objvzx_TextReadEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_TextReadEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.IsPublic) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.IsPublic, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.IsPublic] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetSubmitter(this clsvzx_TextReadEN objvzx_TextReadEN, string strSubmitter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitter, 50, convzx_TextRead.Submitter);
}
objvzx_TextReadEN.Submitter = strSubmitter; //提交人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.Submitter) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.Submitter, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.Submitter] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetIdCurrEduCls(this clsvzx_TextReadEN objvzx_TextReadEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TextRead.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TextRead.IdCurrEduCls);
}
objvzx_TextReadEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.IdCurrEduCls) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetQuestionCount(this clsvzx_TextReadEN objvzx_TextReadEN, int? intQuestionCount, string strComparisonOp="")
	{
objvzx_TextReadEN.QuestionCount = intQuestionCount; //问题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.QuestionCount) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.QuestionCount, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.QuestionCount] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetCreateDate(this clsvzx_TextReadEN objvzx_TextReadEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_TextRead.CreateDate);
}
objvzx_TextReadEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.CreateDate) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.CreateDate, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.CreateDate] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetUpdUser(this clsvzx_TextReadEN objvzx_TextReadEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TextRead.UpdUser);
}
objvzx_TextReadEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.UpdUser) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.UpdUser, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.UpdUser] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetUpdDate(this clsvzx_TextReadEN objvzx_TextReadEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convzx_TextRead.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TextRead.UpdDate);
}
objvzx_TextReadEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.UpdDate) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.UpdDate, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.UpdDate] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TextReadEN SetMemo(this clsvzx_TextReadEN objvzx_TextReadEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_TextRead.Memo);
}
objvzx_TextReadEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TextReadEN.dicFldComparisonOp.ContainsKey(convzx_TextRead.Memo) == false)
{
objvzx_TextReadEN.dicFldComparisonOp.Add(convzx_TextRead.Memo, strComparisonOp);
}
else
{
objvzx_TextReadEN.dicFldComparisonOp[convzx_TextRead.Memo] = strComparisonOp;
}
}
return objvzx_TextReadEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <param name = "objvzx_TextReadENT">目标对象</param>
 public static void CopyTo(this clsvzx_TextReadEN objvzx_TextReadENS, clsvzx_TextReadEN objvzx_TextReadENT)
{
try
{
objvzx_TextReadENT.TextTitle = objvzx_TextReadENS.TextTitle; //TextTitle
objvzx_TextReadENT.TextRId = objvzx_TextReadENS.TextRId; //TextRId
objvzx_TextReadENT.ReaderUserId = objvzx_TextReadENS.ReaderUserId; //ReaderUserId
objvzx_TextReadENT.TextId = objvzx_TextReadENS.TextId; //课件Id
objvzx_TextReadENT.ReadTypeId = objvzx_TextReadENS.ReadTypeId; //阅读类型
objvzx_TextReadENT.IsSubmit = objvzx_TextReadENS.IsSubmit; //是否提交
objvzx_TextReadENT.IsPublic = objvzx_TextReadENS.IsPublic; //是否公开
objvzx_TextReadENT.Submitter = objvzx_TextReadENS.Submitter; //提交人
objvzx_TextReadENT.IdCurrEduCls = objvzx_TextReadENS.IdCurrEduCls; //教学班流水号
objvzx_TextReadENT.QuestionCount = objvzx_TextReadENS.QuestionCount; //问题数
objvzx_TextReadENT.CreateDate = objvzx_TextReadENS.CreateDate; //建立日期
objvzx_TextReadENT.UpdUser = objvzx_TextReadENS.UpdUser; //修改人
objvzx_TextReadENT.UpdDate = objvzx_TextReadENS.UpdDate; //修改日期
objvzx_TextReadENT.Memo = objvzx_TextReadENS.Memo; //备注
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
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TextReadEN:objvzx_TextReadENT</returns>
 public static clsvzx_TextReadEN CopyTo(this clsvzx_TextReadEN objvzx_TextReadENS)
{
try
{
 clsvzx_TextReadEN objvzx_TextReadENT = new clsvzx_TextReadEN()
{
TextTitle = objvzx_TextReadENS.TextTitle, //TextTitle
TextRId = objvzx_TextReadENS.TextRId, //TextRId
ReaderUserId = objvzx_TextReadENS.ReaderUserId, //ReaderUserId
TextId = objvzx_TextReadENS.TextId, //课件Id
ReadTypeId = objvzx_TextReadENS.ReadTypeId, //阅读类型
IsSubmit = objvzx_TextReadENS.IsSubmit, //是否提交
IsPublic = objvzx_TextReadENS.IsPublic, //是否公开
Submitter = objvzx_TextReadENS.Submitter, //提交人
IdCurrEduCls = objvzx_TextReadENS.IdCurrEduCls, //教学班流水号
QuestionCount = objvzx_TextReadENS.QuestionCount, //问题数
CreateDate = objvzx_TextReadENS.CreateDate, //建立日期
UpdUser = objvzx_TextReadENS.UpdUser, //修改人
UpdDate = objvzx_TextReadENS.UpdDate, //修改日期
Memo = objvzx_TextReadENS.Memo, //备注
};
 return objvzx_TextReadENT;
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
public static void CheckProperty4Condition(this clsvzx_TextReadEN objvzx_TextReadEN)
{
 clsvzx_TextReadBL.vzx_TextReadDA.CheckProperty4Condition(objvzx_TextReadEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TextReadEN objvzx_TextReadCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.TextTitle, objvzx_TextReadCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.TextRId) == true)
{
string strComparisonOpTextRId = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.TextRId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.TextRId, objvzx_TextReadCond.TextRId, strComparisonOpTextRId);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.ReaderUserId) == true)
{
string strComparisonOpReaderUserId = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.ReaderUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.ReaderUserId, objvzx_TextReadCond.ReaderUserId, strComparisonOpReaderUserId);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.TextId) == true)
{
string strComparisonOpTextId = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.TextId, objvzx_TextReadCond.TextId, strComparisonOpTextId);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.ReadTypeId) == true)
{
string strComparisonOpReadTypeId = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.ReadTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.ReadTypeId, objvzx_TextReadCond.ReadTypeId, strComparisonOpReadTypeId);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.IsSubmit) == true)
{
if (objvzx_TextReadCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_TextRead.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_TextRead.IsSubmit);
}
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.IsPublic) == true)
{
if (objvzx_TextReadCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_TextRead.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_TextRead.IsPublic);
}
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.Submitter) == true)
{
string strComparisonOpSubmitter = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.Submitter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.Submitter, objvzx_TextReadCond.Submitter, strComparisonOpSubmitter);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.IdCurrEduCls, objvzx_TextReadCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.QuestionCount) == true)
{
string strComparisonOpQuestionCount = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.QuestionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TextRead.QuestionCount, objvzx_TextReadCond.QuestionCount, strComparisonOpQuestionCount);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.CreateDate, objvzx_TextReadCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.UpdUser, objvzx_TextReadCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.UpdDate, objvzx_TextReadCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TextReadCond.IsUpdated(convzx_TextRead.Memo) == true)
{
string strComparisonOpMemo = objvzx_TextReadCond.dicFldComparisonOp[convzx_TextRead.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TextRead.Memo, objvzx_TextReadCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TextRead
{
public virtual bool UpdRelaTabDate(string strTextRId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TextRead(vzx_TextRead)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TextReadBL
{
public static RelatedActions_vzx_TextRead relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TextReadDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TextReadDA vzx_TextReadDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TextReadDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TextReadBL()
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
if (string.IsNullOrEmpty(clsvzx_TextReadEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TextReadEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TextRead(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TextReadDA.GetDataTable_vzx_TextRead(strWhereCond);
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
objDT = vzx_TextReadDA.GetDataTable(strWhereCond);
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
objDT = vzx_TextReadDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TextReadDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TextReadDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TextReadDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TextReadDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TextReadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TextReadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTextRIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_TextReadEN> GetObjLstByTextRIdLst(List<string> arrTextRIdLst)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTextRIdLst, true);
 string strWhereCond = string.Format("TextRId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTextRIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TextReadEN> GetObjLstByTextRIdLstCache(List<string> arrTextRIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_TextReadEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TextReadEN> arrvzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextReadEN> arrvzx_TextReadObjLst_Sel =
arrvzx_TextReadObjLstCache
.Where(x => arrTextRIdLst.Contains(x.TextRId));
return arrvzx_TextReadObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextReadEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
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
public static List<clsvzx_TextReadEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TextReadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TextReadEN> GetSubObjLstCache(clsvzx_TextReadEN objvzx_TextReadCond)
{
 string strIdCurrEduCls = objvzx_TextReadCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_TextReadBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_TextReadEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextReadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TextRead.AttributeName)
{
if (objvzx_TextReadCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TextReadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextReadCond[strFldName].ToString());
}
else
{
if (objvzx_TextReadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TextReadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextReadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TextReadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TextReadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TextReadCond[strFldName]));
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
public static List<clsvzx_TextReadEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
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
public static List<clsvzx_TextReadEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
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
List<clsvzx_TextReadEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TextReadEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextReadEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TextReadEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
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
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
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
public static List<clsvzx_TextReadEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TextReadEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TextReadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
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
public static List<clsvzx_TextReadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TextReadEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TextRead(ref clsvzx_TextReadEN objvzx_TextReadEN)
{
bool bolResult = vzx_TextReadDA.Getvzx_TextRead(ref objvzx_TextReadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TextReadEN GetObjByTextRId(string strTextRId)
{
if (strTextRId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTextRId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTextRId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTextRId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_TextReadEN objvzx_TextReadEN = vzx_TextReadDA.GetObjByTextRId(strTextRId);
return objvzx_TextReadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TextReadEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TextReadEN objvzx_TextReadEN = vzx_TextReadDA.GetFirstObj(strWhereCond);
 return objvzx_TextReadEN;
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
public static clsvzx_TextReadEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TextReadEN objvzx_TextReadEN = vzx_TextReadDA.GetObjByDataRow(objRow);
 return objvzx_TextReadEN;
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
public static clsvzx_TextReadEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TextReadEN objvzx_TextReadEN = vzx_TextReadDA.GetObjByDataRow(objRow);
 return objvzx_TextReadEN;
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
 /// <param name = "strTextRId">所给的关键字</param>
 /// <param name = "lstvzx_TextReadObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TextReadEN GetObjByTextRIdFromList(string strTextRId, List<clsvzx_TextReadEN> lstvzx_TextReadObjLst)
{
foreach (clsvzx_TextReadEN objvzx_TextReadEN in lstvzx_TextReadObjLst)
{
if (objvzx_TextReadEN.TextRId == strTextRId)
{
return objvzx_TextReadEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxTextRId;
 try
 {
 strMaxTextRId = clsvzx_TextReadDA.GetMaxStrId();
 return strMaxTextRId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strTextRId;
 try
 {
 strTextRId = new clsvzx_TextReadDA().GetFirstID(strWhereCond);
 return strTextRId;
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
 arrList = vzx_TextReadDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TextReadDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTextRId)
{
if (string.IsNullOrEmpty(strTextRId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTextRId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_TextReadDA.IsExist(strTextRId);
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
 bolIsExist = clsvzx_TextReadDA.IsExistTable();
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
 bolIsExist = vzx_TextReadDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <param name = "objvzx_TextReadENT">目标对象</param>
 public static void CopyTo(clsvzx_TextReadEN objvzx_TextReadENS, clsvzx_TextReadEN objvzx_TextReadENT)
{
try
{
objvzx_TextReadENT.TextTitle = objvzx_TextReadENS.TextTitle; //TextTitle
objvzx_TextReadENT.TextRId = objvzx_TextReadENS.TextRId; //TextRId
objvzx_TextReadENT.ReaderUserId = objvzx_TextReadENS.ReaderUserId; //ReaderUserId
objvzx_TextReadENT.TextId = objvzx_TextReadENS.TextId; //课件Id
objvzx_TextReadENT.ReadTypeId = objvzx_TextReadENS.ReadTypeId; //阅读类型
objvzx_TextReadENT.IsSubmit = objvzx_TextReadENS.IsSubmit; //是否提交
objvzx_TextReadENT.IsPublic = objvzx_TextReadENS.IsPublic; //是否公开
objvzx_TextReadENT.Submitter = objvzx_TextReadENS.Submitter; //提交人
objvzx_TextReadENT.IdCurrEduCls = objvzx_TextReadENS.IdCurrEduCls; //教学班流水号
objvzx_TextReadENT.QuestionCount = objvzx_TextReadENS.QuestionCount; //问题数
objvzx_TextReadENT.CreateDate = objvzx_TextReadENS.CreateDate; //建立日期
objvzx_TextReadENT.UpdUser = objvzx_TextReadENS.UpdUser; //修改人
objvzx_TextReadENT.UpdDate = objvzx_TextReadENS.UpdDate; //修改日期
objvzx_TextReadENT.Memo = objvzx_TextReadENS.Memo; //备注
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
 /// <param name = "objvzx_TextReadEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TextReadEN objvzx_TextReadEN)
{
try
{
objvzx_TextReadEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TextReadEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TextRead.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.TextTitle = objvzx_TextReadEN.TextTitle == "[null]" ? null :  objvzx_TextReadEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_TextRead.TextRId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.TextRId = objvzx_TextReadEN.TextRId; //TextRId
}
if (arrFldSet.Contains(convzx_TextRead.ReaderUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.ReaderUserId = objvzx_TextReadEN.ReaderUserId == "[null]" ? null :  objvzx_TextReadEN.ReaderUserId; //ReaderUserId
}
if (arrFldSet.Contains(convzx_TextRead.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.TextId = objvzx_TextReadEN.TextId == "[null]" ? null :  objvzx_TextReadEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_TextRead.ReadTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.ReadTypeId = objvzx_TextReadEN.ReadTypeId; //阅读类型
}
if (arrFldSet.Contains(convzx_TextRead.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.IsSubmit = objvzx_TextReadEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_TextRead.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.IsPublic = objvzx_TextReadEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_TextRead.Submitter, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.Submitter = objvzx_TextReadEN.Submitter == "[null]" ? null :  objvzx_TextReadEN.Submitter; //提交人
}
if (arrFldSet.Contains(convzx_TextRead.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.IdCurrEduCls = objvzx_TextReadEN.IdCurrEduCls == "[null]" ? null :  objvzx_TextReadEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_TextRead.QuestionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.QuestionCount = objvzx_TextReadEN.QuestionCount; //问题数
}
if (arrFldSet.Contains(convzx_TextRead.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.CreateDate = objvzx_TextReadEN.CreateDate == "[null]" ? null :  objvzx_TextReadEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_TextRead.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.UpdUser = objvzx_TextReadEN.UpdUser == "[null]" ? null :  objvzx_TextReadEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TextRead.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.UpdDate = objvzx_TextReadEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TextRead.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TextReadEN.Memo = objvzx_TextReadEN.Memo == "[null]" ? null :  objvzx_TextReadEN.Memo; //备注
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
 /// <param name = "objvzx_TextReadEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TextReadEN objvzx_TextReadEN)
{
try
{
if (objvzx_TextReadEN.TextTitle == "[null]") objvzx_TextReadEN.TextTitle = null; //TextTitle
if (objvzx_TextReadEN.ReaderUserId == "[null]") objvzx_TextReadEN.ReaderUserId = null; //ReaderUserId
if (objvzx_TextReadEN.TextId == "[null]") objvzx_TextReadEN.TextId = null; //课件Id
if (objvzx_TextReadEN.Submitter == "[null]") objvzx_TextReadEN.Submitter = null; //提交人
if (objvzx_TextReadEN.IdCurrEduCls == "[null]") objvzx_TextReadEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_TextReadEN.CreateDate == "[null]") objvzx_TextReadEN.CreateDate = null; //建立日期
if (objvzx_TextReadEN.UpdUser == "[null]") objvzx_TextReadEN.UpdUser = null; //修改人
if (objvzx_TextReadEN.Memo == "[null]") objvzx_TextReadEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvzx_TextReadEN objvzx_TextReadEN)
{
 vzx_TextReadDA.CheckProperty4Condition(objvzx_TextReadEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_TextRId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convzx_TextRead.TextRId); 
List<clsvzx_TextReadEN> arrObjLst = clsvzx_TextReadBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN()
{
TextRId = "0",
ReadTypeId = "选[vzx_TextRead]..."
};
arrObjLst.Insert(0, objvzx_TextReadEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convzx_TextRead.TextRId;
objComboBox.DisplayMember = convzx_TextRead.ReadTypeId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_TextRId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vzx_TextRead]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convzx_TextRead.TextRId); 
IEnumerable<clsvzx_TextReadEN> arrObjLst = clsvzx_TextReadBL.GetObjLst(strCondition);
objDDL.DataValueField = convzx_TextRead.TextRId;
objDDL.DataTextField = convzx_TextRead.ReadTypeId;
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
public static void BindDdl_TextRIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vzx_TextRead]...","0");
List<clsvzx_TextReadEN> arrvzx_TextReadObjLst = GetAllvzx_TextReadObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convzx_TextRead.TextRId;
objDDL.DataTextField = convzx_TextRead.ReadTypeId;
objDDL.DataSource = arrvzx_TextReadObjLst;
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TextReadBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextReadBL没有刷新缓存机制(clszx_TextReadBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TextRId");
//if (arrvzx_TextReadObjLstCache == null)
//{
//arrvzx_TextReadObjLstCache = vzx_TextReadDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTextRId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TextReadEN GetObjByTextRIdCache(string strTextRId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TextReadEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TextReadEN> arrvzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextReadEN> arrvzx_TextReadObjLst_Sel =
arrvzx_TextReadObjLstCache
.Where(x=> x.TextRId == strTextRId 
);
if (arrvzx_TextReadObjLst_Sel.Count() == 0)
{
   clsvzx_TextReadEN obj = clsvzx_TextReadBL.GetObjByTextRId(strTextRId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTextRId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_TextReadObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTextRId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetReadTypeIdByTextRIdCache(string strTextRId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strTextRId) == true) return "";
//获取缓存中的对象列表
clsvzx_TextReadEN objvzx_TextRead = GetObjByTextRIdCache(strTextRId, strIdCurrEduCls);
if (objvzx_TextRead == null) return "";
return objvzx_TextRead.ReadTypeId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTextRId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTextRIdCache(string strTextRId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strTextRId) == true) return "";
//获取缓存中的对象列表
clsvzx_TextReadEN objvzx_TextRead = GetObjByTextRIdCache(strTextRId, strIdCurrEduCls);
if (objvzx_TextRead == null) return "";
return objvzx_TextRead.ReadTypeId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TextReadEN> GetAllvzx_TextReadObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_TextReadEN> arrvzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_TextReadObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TextReadEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TextReadEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_TextReadEN> arrvzx_TextReadObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_TextReadObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_TextReadEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTextRId, string strIdCurrEduCls)
{
if (strInFldName != convzx_TextRead.TextRId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TextRead.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TextRead.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TextRead = clsvzx_TextReadBL.GetObjByTextRIdCache(strTextRId, strIdCurrEduCls);
if (objvzx_TextRead == null) return "";
return objvzx_TextRead[strOutFldName].ToString();
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
int intRecCount = clsvzx_TextReadDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TextReadDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TextReadDA.GetRecCount();
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
int intRecCount = clsvzx_TextReadDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TextReadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TextReadEN objvzx_TextReadCond)
{
 string strIdCurrEduCls = objvzx_TextReadCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_TextReadBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_TextReadEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TextReadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TextRead.AttributeName)
{
if (objvzx_TextReadCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TextReadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextReadCond[strFldName].ToString());
}
else
{
if (objvzx_TextReadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TextReadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TextReadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TextReadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TextReadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TextReadCond[strFldName]));
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
 List<string> arrList = clsvzx_TextReadDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TextReadDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TextReadDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}