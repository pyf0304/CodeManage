
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireBatchBL
 表名:vQuestionnaireBatch(01120021)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsvQuestionnaireBatchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireBatchEN GetObj(this K_BatchId_vQuestionnaireBatch myKey)
{
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = clsvQuestionnaireBatchBL.vQuestionnaireBatchDA.GetObjByBatchId(myKey.Value);
return objvQuestionnaireBatchEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetBatchId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strBatchId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchId, 4, convQuestionnaireBatch.BatchId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, convQuestionnaireBatch.BatchId);
}
objvQuestionnaireBatchEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.BatchId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.BatchId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.BatchId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetBatchName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strBatchName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBatchName, convQuestionnaireBatch.BatchName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchName, 50, convQuestionnaireBatch.BatchName);
}
objvQuestionnaireBatchEN.BatchName = strBatchName; //批次名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.BatchName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.BatchName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.BatchName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetIsDefault(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, bool bolIsDefault, string strComparisonOp="")
	{
objvQuestionnaireBatchEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.IsDefault) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.IsDefault, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.IsDefault] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetCreateDate(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convQuestionnaireBatch.CreateDate);
}
objvQuestionnaireBatchEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.CreateDate) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.CreateDate, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.CreateDate] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetCreateUser(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, convQuestionnaireBatch.CreateUser);
}
objvQuestionnaireBatchEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.CreateUser) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.CreateUser, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.CreateUser] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetPageName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, convQuestionnaireBatch.PageName);
}
objvQuestionnaireBatchEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.PageName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.PageName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.PageName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetIsRandomSelSet(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, bool bolIsRandomSelSet, string strComparisonOp="")
	{
objvQuestionnaireBatchEN.IsRandomSelSet = bolIsRandomSelSet; //是否随机选问卷集
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.IsRandomSelSet) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.IsRandomSelSet, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.IsRandomSelSet] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetQuestionnaireSetName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convQuestionnaireBatch.QuestionnaireSetName);
}
objvQuestionnaireBatchEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.QuestionnaireSetName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.QuestionnaireSetName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetRoleName(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 100, convQuestionnaireBatch.RoleName);
}
objvQuestionnaireBatchEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.RoleName) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.RoleName, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.RoleName] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetRoleId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQuestionnaireBatch.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQuestionnaireBatch.RoleId);
}
objvQuestionnaireBatchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.RoleId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.RoleId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.RoleId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetQuestionnaireSetId(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convQuestionnaireBatch.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convQuestionnaireBatch.QuestionnaireSetId);
}
objvQuestionnaireBatchEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.QuestionnaireSetId) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.QuestionnaireSetId, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetId] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaireBatchEN SetMemo(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionnaireBatch.Memo);
}
objvQuestionnaireBatchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(convQuestionnaireBatch.Memo) == false)
{
objvQuestionnaireBatchEN.dicFldComparisonOp.Add(convQuestionnaireBatch.Memo, strComparisonOp);
}
else
{
objvQuestionnaireBatchEN.dicFldComparisonOp[convQuestionnaireBatch.Memo] = strComparisonOp;
}
}
return objvQuestionnaireBatchEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchENS">源对象</param>
 /// <param name = "objvQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaireBatchEN objvQuestionnaireBatchENS, clsvQuestionnaireBatchEN objvQuestionnaireBatchENT)
{
try
{
objvQuestionnaireBatchENT.BatchId = objvQuestionnaireBatchENS.BatchId; //批次ID
objvQuestionnaireBatchENT.BatchName = objvQuestionnaireBatchENS.BatchName; //批次名称
objvQuestionnaireBatchENT.IsDefault = objvQuestionnaireBatchENS.IsDefault; //是否默认
objvQuestionnaireBatchENT.CreateDate = objvQuestionnaireBatchENS.CreateDate; //建立日期
objvQuestionnaireBatchENT.CreateUser = objvQuestionnaireBatchENS.CreateUser; //建立用户
objvQuestionnaireBatchENT.PageName = objvQuestionnaireBatchENS.PageName; //页面名称
objvQuestionnaireBatchENT.IsRandomSelSet = objvQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objvQuestionnaireBatchENT.QuestionnaireSetName = objvQuestionnaireBatchENS.QuestionnaireSetName; //问卷集名
objvQuestionnaireBatchENT.RoleName = objvQuestionnaireBatchENS.RoleName; //角色名
objvQuestionnaireBatchENT.RoleId = objvQuestionnaireBatchENS.RoleId; //角色Id
objvQuestionnaireBatchENT.QuestionnaireSetId = objvQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaireBatchENT.Memo = objvQuestionnaireBatchENS.Memo; //备注
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
 /// <param name = "objvQuestionnaireBatchENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaireBatchEN:objvQuestionnaireBatchENT</returns>
 public static clsvQuestionnaireBatchEN CopyTo(this clsvQuestionnaireBatchEN objvQuestionnaireBatchENS)
{
try
{
 clsvQuestionnaireBatchEN objvQuestionnaireBatchENT = new clsvQuestionnaireBatchEN()
{
BatchId = objvQuestionnaireBatchENS.BatchId, //批次ID
BatchName = objvQuestionnaireBatchENS.BatchName, //批次名称
IsDefault = objvQuestionnaireBatchENS.IsDefault, //是否默认
CreateDate = objvQuestionnaireBatchENS.CreateDate, //建立日期
CreateUser = objvQuestionnaireBatchENS.CreateUser, //建立用户
PageName = objvQuestionnaireBatchENS.PageName, //页面名称
IsRandomSelSet = objvQuestionnaireBatchENS.IsRandomSelSet, //是否随机选问卷集
QuestionnaireSetName = objvQuestionnaireBatchENS.QuestionnaireSetName, //问卷集名
RoleName = objvQuestionnaireBatchENS.RoleName, //角色名
RoleId = objvQuestionnaireBatchENS.RoleId, //角色Id
QuestionnaireSetId = objvQuestionnaireBatchENS.QuestionnaireSetId, //问卷集ID
Memo = objvQuestionnaireBatchENS.Memo, //备注
};
 return objvQuestionnaireBatchENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaireBatchEN objvQuestionnaireBatchEN)
{
 clsvQuestionnaireBatchBL.vQuestionnaireBatchDA.CheckProperty4Condition(objvQuestionnaireBatchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireBatchEN objvQuestionnaireBatchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.BatchId) == true)
{
string strComparisonOpBatchId = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.BatchId, objvQuestionnaireBatchCond.BatchId, strComparisonOpBatchId);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.BatchName) == true)
{
string strComparisonOpBatchName = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.BatchName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.BatchName, objvQuestionnaireBatchCond.BatchName, strComparisonOpBatchName);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.IsDefault) == true)
{
if (objvQuestionnaireBatchCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaireBatch.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaireBatch.IsDefault);
}
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.CreateDate) == true)
{
string strComparisonOpCreateDate = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.CreateDate, objvQuestionnaireBatchCond.CreateDate, strComparisonOpCreateDate);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.CreateUser) == true)
{
string strComparisonOpCreateUser = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.CreateUser, objvQuestionnaireBatchCond.CreateUser, strComparisonOpCreateUser);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.PageName) == true)
{
string strComparisonOpPageName = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.PageName, objvQuestionnaireBatchCond.PageName, strComparisonOpPageName);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.IsRandomSelSet) == true)
{
if (objvQuestionnaireBatchCond.IsRandomSelSet == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaireBatch.IsRandomSelSet);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaireBatch.IsRandomSelSet);
}
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.QuestionnaireSetName) == true)
{
string strComparisonOpQuestionnaireSetName = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.QuestionnaireSetName, objvQuestionnaireBatchCond.QuestionnaireSetName, strComparisonOpQuestionnaireSetName);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.RoleName) == true)
{
string strComparisonOpRoleName = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.RoleName, objvQuestionnaireBatchCond.RoleName, strComparisonOpRoleName);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.RoleId) == true)
{
string strComparisonOpRoleId = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.RoleId, objvQuestionnaireBatchCond.RoleId, strComparisonOpRoleId);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.QuestionnaireSetId, objvQuestionnaireBatchCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objvQuestionnaireBatchCond.IsUpdated(convQuestionnaireBatch.Memo) == true)
{
string strComparisonOpMemo = objvQuestionnaireBatchCond.dicFldComparisonOp[convQuestionnaireBatch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireBatch.Memo, objvQuestionnaireBatchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaireBatch
{
public virtual bool UpdRelaTabDate(string strBatchId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v问卷批次(vQuestionnaireBatch)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireBatchBL
{
public static RelatedActions_vQuestionnaireBatch relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaireBatchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaireBatchDA vQuestionnaireBatchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaireBatchDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaireBatchBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaireBatchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaireBatchEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaireBatch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaireBatchDA.GetDataTable_vQuestionnaireBatch(strWhereCond);
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
objDT = vQuestionnaireBatchDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaireBatchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaireBatchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaireBatchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaireBatchDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaireBatchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaireBatchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaireBatchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrBatchIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLstByBatchIdLst(List<string> arrBatchIdLst)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrBatchIdLst, true);
 string strWhereCond = string.Format("BatchId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrBatchIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaireBatchEN> GetObjLstByBatchIdLstCache(List<string> arrBatchIdLst)
{
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel =
arrvQuestionnaireBatchObjLstCache
.Where(x => arrBatchIdLst.Contains(x.BatchId));
return arrvQuestionnaireBatchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
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
public static List<clsvQuestionnaireBatchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaireBatchEN> GetSubObjLstCache(clsvQuestionnaireBatchEN objvQuestionnaireBatchCond)
{
List<clsvQuestionnaireBatchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireBatchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaireBatch.AttributeName)
{
if (objvQuestionnaireBatchCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireBatchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireBatchCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireBatchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireBatchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireBatchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireBatchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireBatchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireBatchCond[strFldName]));
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
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
List<clsvQuestionnaireBatchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaireBatchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaireBatchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
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
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
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
public static List<clsvQuestionnaireBatchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
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
public static List<clsvQuestionnaireBatchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaireBatchEN> arrObjLst = new List<clsvQuestionnaireBatchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN();
try
{
objvQuestionnaireBatchEN.BatchId = objRow[convQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objvQuestionnaireBatchEN.BatchName = objRow[convQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objvQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objvQuestionnaireBatchEN.CreateDate = objRow[convQuestionnaireBatch.CreateDate] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objvQuestionnaireBatchEN.CreateUser = objRow[convQuestionnaireBatch.CreateUser] == DBNull.Value ? null : objRow[convQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objvQuestionnaireBatchEN.PageName = objRow[convQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objvQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objvQuestionnaireBatchEN.QuestionnaireSetName = objRow[convQuestionnaireBatch.QuestionnaireSetName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvQuestionnaireBatchEN.RoleName = objRow[convQuestionnaireBatch.RoleName] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleName].ToString().Trim(); //角色名
objvQuestionnaireBatchEN.RoleId = objRow[convQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objvQuestionnaireBatchEN.QuestionnaireSetId = objRow[convQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[convQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvQuestionnaireBatchEN.Memo = objRow[convQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[convQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaireBatchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaireBatch(ref clsvQuestionnaireBatchEN objvQuestionnaireBatchEN)
{
bool bolResult = vQuestionnaireBatchDA.GetvQuestionnaireBatch(ref objvQuestionnaireBatchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireBatchEN GetObjByBatchId(string strBatchId)
{
if (strBatchId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strBatchId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strBatchId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strBatchId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = vQuestionnaireBatchDA.GetObjByBatchId(strBatchId);
return objvQuestionnaireBatchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaireBatchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = vQuestionnaireBatchDA.GetFirstObj(strWhereCond);
 return objvQuestionnaireBatchEN;
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
public static clsvQuestionnaireBatchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = vQuestionnaireBatchDA.GetObjByDataRow(objRow);
 return objvQuestionnaireBatchEN;
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
public static clsvQuestionnaireBatchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = vQuestionnaireBatchDA.GetObjByDataRow(objRow);
 return objvQuestionnaireBatchEN;
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
 /// <param name = "strBatchId">所给的关键字</param>
 /// <param name = "lstvQuestionnaireBatchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireBatchEN GetObjByBatchIdFromList(string strBatchId, List<clsvQuestionnaireBatchEN> lstvQuestionnaireBatchObjLst)
{
foreach (clsvQuestionnaireBatchEN objvQuestionnaireBatchEN in lstvQuestionnaireBatchObjLst)
{
if (objvQuestionnaireBatchEN.BatchId == strBatchId)
{
return objvQuestionnaireBatchEN;
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
 string strMaxBatchId;
 try
 {
 strMaxBatchId = clsvQuestionnaireBatchDA.GetMaxStrId();
 return strMaxBatchId;
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
 string strBatchId;
 try
 {
 strBatchId = new clsvQuestionnaireBatchDA().GetFirstID(strWhereCond);
 return strBatchId;
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
 arrList = vQuestionnaireBatchDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaireBatchDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strBatchId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionnaireBatchDA.IsExist(strBatchId);
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
 bolIsExist = clsvQuestionnaireBatchDA.IsExistTable();
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
 bolIsExist = vQuestionnaireBatchDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaireBatchENS">源对象</param>
 /// <param name = "objvQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireBatchEN objvQuestionnaireBatchENS, clsvQuestionnaireBatchEN objvQuestionnaireBatchENT)
{
try
{
objvQuestionnaireBatchENT.BatchId = objvQuestionnaireBatchENS.BatchId; //批次ID
objvQuestionnaireBatchENT.BatchName = objvQuestionnaireBatchENS.BatchName; //批次名称
objvQuestionnaireBatchENT.IsDefault = objvQuestionnaireBatchENS.IsDefault; //是否默认
objvQuestionnaireBatchENT.CreateDate = objvQuestionnaireBatchENS.CreateDate; //建立日期
objvQuestionnaireBatchENT.CreateUser = objvQuestionnaireBatchENS.CreateUser; //建立用户
objvQuestionnaireBatchENT.PageName = objvQuestionnaireBatchENS.PageName; //页面名称
objvQuestionnaireBatchENT.IsRandomSelSet = objvQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objvQuestionnaireBatchENT.QuestionnaireSetName = objvQuestionnaireBatchENS.QuestionnaireSetName; //问卷集名
objvQuestionnaireBatchENT.RoleName = objvQuestionnaireBatchENS.RoleName; //角色名
objvQuestionnaireBatchENT.RoleId = objvQuestionnaireBatchENS.RoleId; //角色Id
objvQuestionnaireBatchENT.QuestionnaireSetId = objvQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaireBatchENT.Memo = objvQuestionnaireBatchENS.Memo; //备注
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
 /// <param name = "objvQuestionnaireBatchEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaireBatchEN objvQuestionnaireBatchEN)
{
try
{
objvQuestionnaireBatchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaireBatchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaireBatch.BatchId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.BatchId = objvQuestionnaireBatchEN.BatchId; //批次ID
}
if (arrFldSet.Contains(convQuestionnaireBatch.BatchName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.BatchName = objvQuestionnaireBatchEN.BatchName; //批次名称
}
if (arrFldSet.Contains(convQuestionnaireBatch.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.IsDefault = objvQuestionnaireBatchEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(convQuestionnaireBatch.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.CreateDate = objvQuestionnaireBatchEN.CreateDate == "[null]" ? null :  objvQuestionnaireBatchEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convQuestionnaireBatch.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.CreateUser = objvQuestionnaireBatchEN.CreateUser == "[null]" ? null :  objvQuestionnaireBatchEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(convQuestionnaireBatch.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.PageName = objvQuestionnaireBatchEN.PageName == "[null]" ? null :  objvQuestionnaireBatchEN.PageName; //页面名称
}
if (arrFldSet.Contains(convQuestionnaireBatch.IsRandomSelSet, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.IsRandomSelSet = objvQuestionnaireBatchEN.IsRandomSelSet; //是否随机选问卷集
}
if (arrFldSet.Contains(convQuestionnaireBatch.QuestionnaireSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.QuestionnaireSetName = objvQuestionnaireBatchEN.QuestionnaireSetName == "[null]" ? null :  objvQuestionnaireBatchEN.QuestionnaireSetName; //问卷集名
}
if (arrFldSet.Contains(convQuestionnaireBatch.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.RoleName = objvQuestionnaireBatchEN.RoleName == "[null]" ? null :  objvQuestionnaireBatchEN.RoleName; //角色名
}
if (arrFldSet.Contains(convQuestionnaireBatch.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.RoleId = objvQuestionnaireBatchEN.RoleId == "[null]" ? null :  objvQuestionnaireBatchEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQuestionnaireBatch.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.QuestionnaireSetId = objvQuestionnaireBatchEN.QuestionnaireSetId == "[null]" ? null :  objvQuestionnaireBatchEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(convQuestionnaireBatch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaireBatchEN.Memo = objvQuestionnaireBatchEN.Memo == "[null]" ? null :  objvQuestionnaireBatchEN.Memo; //备注
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
 /// <param name = "objvQuestionnaireBatchEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaireBatchEN objvQuestionnaireBatchEN)
{
try
{
if (objvQuestionnaireBatchEN.CreateDate == "[null]") objvQuestionnaireBatchEN.CreateDate = null; //建立日期
if (objvQuestionnaireBatchEN.CreateUser == "[null]") objvQuestionnaireBatchEN.CreateUser = null; //建立用户
if (objvQuestionnaireBatchEN.PageName == "[null]") objvQuestionnaireBatchEN.PageName = null; //页面名称
if (objvQuestionnaireBatchEN.QuestionnaireSetName == "[null]") objvQuestionnaireBatchEN.QuestionnaireSetName = null; //问卷集名
if (objvQuestionnaireBatchEN.RoleName == "[null]") objvQuestionnaireBatchEN.RoleName = null; //角色名
if (objvQuestionnaireBatchEN.RoleId == "[null]") objvQuestionnaireBatchEN.RoleId = null; //角色Id
if (objvQuestionnaireBatchEN.QuestionnaireSetId == "[null]") objvQuestionnaireBatchEN.QuestionnaireSetId = null; //问卷集ID
if (objvQuestionnaireBatchEN.Memo == "[null]") objvQuestionnaireBatchEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionnaireBatchEN objvQuestionnaireBatchEN)
{
 vQuestionnaireBatchDA.CheckProperty4Condition(objvQuestionnaireBatchEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_BatchId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaireBatch.BatchId); 
List<clsvQuestionnaireBatchEN> arrObjLst = clsvQuestionnaireBatchBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaireBatchEN objvQuestionnaireBatchEN = new clsvQuestionnaireBatchEN()
{
BatchId = "0",
BatchName = "选[v问卷批次]..."
};
arrObjLst.Insert(0, objvQuestionnaireBatchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaireBatch.BatchId;
objComboBox.DisplayMember = convQuestionnaireBatch.BatchName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_BatchId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v问卷批次]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaireBatch.BatchId); 
IEnumerable<clsvQuestionnaireBatchEN> arrObjLst = clsvQuestionnaireBatchBL.GetObjLst(strCondition);
objDDL.DataValueField = convQuestionnaireBatch.BatchId;
objDDL.DataTextField = convQuestionnaireBatch.BatchName;
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
public static void BindDdl_BatchIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v问卷批次]...","0");
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst = GetAllvQuestionnaireBatchObjLstCache(); 
objDDL.DataValueField = convQuestionnaireBatch.BatchId;
objDDL.DataTextField = convQuestionnaireBatch.BatchName;
objDDL.DataSource = arrvQuestionnaireBatchObjLst;
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
if (clsQuestionnaireBatchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBatchBL没有刷新缓存机制(clsQuestionnaireBatchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetBL没有刷新缓存机制(clsQuestionnaireSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserRolesBL没有刷新缓存机制(clsUserRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by BatchId");
//if (arrvQuestionnaireBatchObjLstCache == null)
//{
//arrvQuestionnaireBatchObjLstCache = vQuestionnaireBatchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireBatchEN GetObjByBatchIdCache(string strBatchId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLst_Sel =
arrvQuestionnaireBatchObjLstCache
.Where(x=> x.BatchId == strBatchId 
);
if (arrvQuestionnaireBatchObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireBatchEN obj = clsvQuestionnaireBatchBL.GetObjByBatchId(strBatchId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionnaireBatchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetBatchNameByBatchIdCache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//获取缓存中的对象列表
clsvQuestionnaireBatchEN objvQuestionnaireBatch = GetObjByBatchIdCache(strBatchId);
if (objvQuestionnaireBatch == null) return "";
return objvQuestionnaireBatch.BatchName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByBatchIdCache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//获取缓存中的对象列表
clsvQuestionnaireBatchEN objvQuestionnaireBatch = GetObjByBatchIdCache(strBatchId);
if (objvQuestionnaireBatch == null) return "";
return objvQuestionnaireBatch.BatchName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetAllvQuestionnaireBatchObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLstCache = GetObjLstCache(); 
return arrvQuestionnaireBatchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaireBatchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName);
List<clsvQuestionnaireBatchEN> arrvQuestionnaireBatchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaireBatchObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionnaireBatchEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strBatchId)
{
if (strInFldName != convQuestionnaireBatch.BatchId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaireBatch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaireBatch.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaireBatch = clsvQuestionnaireBatchBL.GetObjByBatchIdCache(strBatchId);
if (objvQuestionnaireBatch == null) return "";
return objvQuestionnaireBatch[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaireBatchDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaireBatchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaireBatchDA.GetRecCount();
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
int intRecCount = clsvQuestionnaireBatchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaireBatchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaireBatchEN objvQuestionnaireBatchCond)
{
List<clsvQuestionnaireBatchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaireBatchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaireBatch.AttributeName)
{
if (objvQuestionnaireBatchCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaireBatchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireBatchCond[strFldName].ToString());
}
else
{
if (objvQuestionnaireBatchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaireBatchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaireBatchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaireBatchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireBatchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaireBatchCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaireBatchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireBatchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaireBatchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}