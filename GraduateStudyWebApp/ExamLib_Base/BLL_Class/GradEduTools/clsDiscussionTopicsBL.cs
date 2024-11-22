﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDiscussionTopicsBL
 表名:DiscussionTopics(01120588)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsDiscussionTopicsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscussionTopicsEN GetObj(this K_TopicsId_DiscussionTopics myKey)
{
clsDiscussionTopicsEN objDiscussionTopicsEN = clsDiscussionTopicsBL.DiscussionTopicsDA.GetObjByTopicsId(myKey.Value);
return objDiscussionTopicsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscussionTopicsBL.IsExist(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscussionTopicsEN.TopicsId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsDiscussionTopicsBL.DiscussionTopicsDA.AddNewRecordBySQL2(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsDiscussionTopicsBL.IsExist(objDiscussionTopicsEN.TopicsId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objDiscussionTopicsEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objDiscussionTopicsEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscussionTopicsBL.IsExist(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscussionTopicsEN.TopicsId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsDiscussionTopicsBL.DiscussionTopicsDA.AddNewRecordBySQL2WithReturnKey(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetTopicsId(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strTopicsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsId, 8, conDiscussionTopics.TopicsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicsId, 8, conDiscussionTopics.TopicsId);
}
objDiscussionTopicsEN.TopicsId = strTopicsId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.TopicsId) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.TopicsId, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.TopicsId] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetDiscussionTypeId(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strDiscussionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDiscussionTypeId, conDiscussionTopics.DiscussionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDiscussionTypeId, 8, conDiscussionTopics.DiscussionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDiscussionTypeId, 8, conDiscussionTopics.DiscussionTypeId);
}
objDiscussionTopicsEN.DiscussionTypeId = strDiscussionTypeId; //讨论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.DiscussionTypeId) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.DiscussionTypeId, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.DiscussionTypeId] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetTopicsTitle(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strTopicsTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsTitle, 200, conDiscussionTopics.TopicsTitle);
}
objDiscussionTopicsEN.TopicsTitle = strTopicsTitle; //主题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.TopicsTitle) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.TopicsTitle, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.TopicsTitle] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetTopicsContent(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strTopicsContent, string strComparisonOp="")
	{
objDiscussionTopicsEN.TopicsContent = strTopicsContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.TopicsContent) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.TopicsContent, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.TopicsContent] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetIsAudit(this clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsAudit, string strComparisonOp="")
	{
objDiscussionTopicsEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.IsAudit) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.IsAudit, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.IsAudit] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetIsTop(this clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsTop, string strComparisonOp="")
	{
objDiscussionTopicsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.IsTop) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.IsTop, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.IsTop] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetBrowseNumber(this clsDiscussionTopicsEN objDiscussionTopicsEN, int? intBrowseNumber, string strComparisonOp="")
	{
objDiscussionTopicsEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.BrowseNumber) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.BrowseNumber, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.BrowseNumber] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetUpdDate(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDiscussionTopics.UpdDate);
}
objDiscussionTopicsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.UpdDate) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.UpdDate, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.UpdDate] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetUpdUser(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDiscussionTopics.UpdUser);
}
objDiscussionTopicsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.UpdUser) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.UpdUser, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.UpdUser] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetMemo(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDiscussionTopics.Memo);
}
objDiscussionTopicsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.Memo) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.Memo, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.Memo] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetIdCurrEduCls(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conDiscussionTopics.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conDiscussionTopics.IdCurrEduCls);
}
objDiscussionTopicsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.IdCurrEduCls) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.IdCurrEduCls, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.IdCurrEduCls] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDiscussionTopicsEN SetSubCount(this clsDiscussionTopicsEN objDiscussionTopicsEN, int? intSubCount, string strComparisonOp="")
	{
objDiscussionTopicsEN.SubCount = intSubCount; //SubCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(conDiscussionTopics.SubCount) == false)
{
objDiscussionTopicsEN.dicFldComparisonOp.Add(conDiscussionTopics.SubCount, strComparisonOp);
}
else
{
objDiscussionTopicsEN.dicFldComparisonOp[conDiscussionTopics.SubCount] = strComparisonOp;
}
}
return objDiscussionTopicsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDiscussionTopicsEN objDiscussionTopicsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDiscussionTopicsEN.CheckPropertyNew();
clsDiscussionTopicsEN objDiscussionTopicsCond = new clsDiscussionTopicsEN();
string strCondition = objDiscussionTopicsCond
.SetTopicsId(objDiscussionTopicsEN.TopicsId, "=")
.GetCombineCondition();
objDiscussionTopicsEN._IsCheckProperty = true;
bool bolIsExist = clsDiscussionTopicsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDiscussionTopicsEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscussionTopicsBL.DiscussionTopicsDA.UpdateBySql2(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDiscussionTopicsEN objDiscussionTopicsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDiscussionTopicsBL.DiscussionTopicsDA.UpdateBySql2(objDiscussionTopicsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strWhereCond)
{
try
{
bool bolResult = clsDiscussionTopicsBL.DiscussionTopicsDA.UpdateBySqlWithCondition(objDiscussionTopicsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDiscussionTopicsEN objDiscussionTopicsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDiscussionTopicsBL.DiscussionTopicsDA.UpdateBySqlWithConditionTransaction(objDiscussionTopicsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDiscussionTopicsEN objDiscussionTopicsEN)
{
try
{
int intRecNum = clsDiscussionTopicsBL.DiscussionTopicsDA.DelRecord(objDiscussionTopicsEN.TopicsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objDiscussionTopicsENS">源对象</param>
 /// <param name = "objDiscussionTopicsENT">目标对象</param>
 public static void CopyTo(this clsDiscussionTopicsEN objDiscussionTopicsENS, clsDiscussionTopicsEN objDiscussionTopicsENT)
{
try
{
objDiscussionTopicsENT.TopicsId = objDiscussionTopicsENS.TopicsId; //主题Id
objDiscussionTopicsENT.DiscussionTypeId = objDiscussionTopicsENS.DiscussionTypeId; //讨论类型Id
objDiscussionTopicsENT.TopicsTitle = objDiscussionTopicsENS.TopicsTitle; //主题标题
objDiscussionTopicsENT.TopicsContent = objDiscussionTopicsENS.TopicsContent; //主题内容
objDiscussionTopicsENT.IsAudit = objDiscussionTopicsENS.IsAudit; //是否审核
objDiscussionTopicsENT.IsTop = objDiscussionTopicsENS.IsTop; //是否置顶
objDiscussionTopicsENT.BrowseNumber = objDiscussionTopicsENS.BrowseNumber; //浏览量
objDiscussionTopicsENT.UpdDate = objDiscussionTopicsENS.UpdDate; //修改日期
objDiscussionTopicsENT.UpdUser = objDiscussionTopicsENS.UpdUser; //修改人
objDiscussionTopicsENT.Memo = objDiscussionTopicsENS.Memo; //备注
objDiscussionTopicsENT.IdCurrEduCls = objDiscussionTopicsENS.IdCurrEduCls; //教学班流水号
objDiscussionTopicsENT.SubCount = objDiscussionTopicsENS.SubCount; //SubCount
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
 /// <param name = "objDiscussionTopicsENS">源对象</param>
 /// <returns>目标对象=>clsDiscussionTopicsEN:objDiscussionTopicsENT</returns>
 public static clsDiscussionTopicsEN CopyTo(this clsDiscussionTopicsEN objDiscussionTopicsENS)
{
try
{
 clsDiscussionTopicsEN objDiscussionTopicsENT = new clsDiscussionTopicsEN()
{
TopicsId = objDiscussionTopicsENS.TopicsId, //主题Id
DiscussionTypeId = objDiscussionTopicsENS.DiscussionTypeId, //讨论类型Id
TopicsTitle = objDiscussionTopicsENS.TopicsTitle, //主题标题
TopicsContent = objDiscussionTopicsENS.TopicsContent, //主题内容
IsAudit = objDiscussionTopicsENS.IsAudit, //是否审核
IsTop = objDiscussionTopicsENS.IsTop, //是否置顶
BrowseNumber = objDiscussionTopicsENS.BrowseNumber, //浏览量
UpdDate = objDiscussionTopicsENS.UpdDate, //修改日期
UpdUser = objDiscussionTopicsENS.UpdUser, //修改人
Memo = objDiscussionTopicsENS.Memo, //备注
IdCurrEduCls = objDiscussionTopicsENS.IdCurrEduCls, //教学班流水号
SubCount = objDiscussionTopicsENS.SubCount, //SubCount
};
 return objDiscussionTopicsENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 clsDiscussionTopicsBL.DiscussionTopicsDA.CheckPropertyNew(objDiscussionTopicsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 clsDiscussionTopicsBL.DiscussionTopicsDA.CheckProperty4Condition(objDiscussionTopicsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDiscussionTopicsEN objDiscussionTopicsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.TopicsId) == true)
{
string strComparisonOpTopicsId = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.TopicsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.TopicsId, objDiscussionTopicsCond.TopicsId, strComparisonOpTopicsId);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.DiscussionTypeId) == true)
{
string strComparisonOpDiscussionTypeId = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.DiscussionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.DiscussionTypeId, objDiscussionTopicsCond.DiscussionTypeId, strComparisonOpDiscussionTypeId);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.TopicsTitle) == true)
{
string strComparisonOpTopicsTitle = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.TopicsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.TopicsTitle, objDiscussionTopicsCond.TopicsTitle, strComparisonOpTopicsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.IsAudit) == true)
{
if (objDiscussionTopicsCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDiscussionTopics.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDiscussionTopics.IsAudit);
}
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.IsTop) == true)
{
if (objDiscussionTopicsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDiscussionTopics.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDiscussionTopics.IsTop);
}
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conDiscussionTopics.BrowseNumber, objDiscussionTopicsCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.UpdDate) == true)
{
string strComparisonOpUpdDate = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.UpdDate, objDiscussionTopicsCond.UpdDate, strComparisonOpUpdDate);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.UpdUser) == true)
{
string strComparisonOpUpdUser = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.UpdUser, objDiscussionTopicsCond.UpdUser, strComparisonOpUpdUser);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.Memo) == true)
{
string strComparisonOpMemo = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.Memo, objDiscussionTopicsCond.Memo, strComparisonOpMemo);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDiscussionTopics.IdCurrEduCls, objDiscussionTopicsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objDiscussionTopicsCond.IsUpdated(conDiscussionTopics.SubCount) == true)
{
string strComparisonOpSubCount = objDiscussionTopicsCond.dicFldComparisonOp[conDiscussionTopics.SubCount];
strWhereCond += string.Format(" And {0} {2} {1}", conDiscussionTopics.SubCount, objDiscussionTopicsCond.SubCount, strComparisonOpSubCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DiscussionTopics
{
public virtual bool UpdRelaTabDate(string strTopicsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 讨论主题(DiscussionTopics)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDiscussionTopicsBL
{
public static RelatedActions_DiscussionTopics relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDiscussionTopicsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDiscussionTopicsDA DiscussionTopicsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDiscussionTopicsDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsDiscussionTopicsBL()
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
if (string.IsNullOrEmpty(clsDiscussionTopicsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDiscussionTopicsEN._ConnectString);
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
public static DataTable GetDataTable_DiscussionTopics(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DiscussionTopicsDA.GetDataTable_DiscussionTopics(strWhereCond);
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
objDT = DiscussionTopicsDA.GetDataTable(strWhereCond);
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
objDT = DiscussionTopicsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DiscussionTopicsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DiscussionTopicsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DiscussionTopicsDA.GetDataTable_Top(objTopPara);
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
objDT = DiscussionTopicsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DiscussionTopicsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DiscussionTopicsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDiscussionTopicsEN> GetObjLstByTopicsIdLst(List<string> arrTopicsIdLst)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicsIdLst, true);
 string strWhereCond = string.Format("TopicsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDiscussionTopicsEN> GetObjLstByTopicsIdLstCache(List<string> arrTopicsIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
List<clsDiscussionTopicsEN> arrDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsDiscussionTopicsEN> arrDiscussionTopicsObjLst_Sel =
arrDiscussionTopicsObjLstCache
.Where(x => arrTopicsIdLst.Contains(x.TopicsId));
return arrDiscussionTopicsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionTopicsEN> GetObjLst(string strWhereCond)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
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
public static List<clsDiscussionTopicsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDiscussionTopicsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDiscussionTopicsEN> GetSubObjLstCache(clsDiscussionTopicsEN objDiscussionTopicsCond)
{
 string strIdCurrEduCls = objDiscussionTopicsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsDiscussionTopicsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsDiscussionTopicsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsDiscussionTopicsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscussionTopics.AttributeName)
{
if (objDiscussionTopicsCond.IsUpdated(strFldName) == false) continue;
if (objDiscussionTopicsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionTopicsCond[strFldName].ToString());
}
else
{
if (objDiscussionTopicsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscussionTopicsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionTopicsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscussionTopicsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscussionTopicsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscussionTopicsCond[strFldName]));
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
public static List<clsDiscussionTopicsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
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
public static List<clsDiscussionTopicsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
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
List<clsDiscussionTopicsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDiscussionTopicsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionTopicsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDiscussionTopicsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
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
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
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
public static List<clsDiscussionTopicsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDiscussionTopicsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDiscussionTopicsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
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
public static List<clsDiscussionTopicsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDiscussionTopicsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDiscussionTopicsEN> arrObjLst = new List<clsDiscussionTopicsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDiscussionTopicsEN objDiscussionTopicsEN = new clsDiscussionTopicsEN();
try
{
objDiscussionTopicsEN.TopicsId = objRow[conDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objDiscussionTopicsEN.DiscussionTypeId = objRow[conDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objDiscussionTopicsEN.TopicsTitle = objRow[conDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objDiscussionTopicsEN.TopicsContent = objRow[conDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[conDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[conDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objDiscussionTopicsEN.BrowseNumber = objRow[conDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objDiscussionTopicsEN.UpdDate = objRow[conDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objDiscussionTopicsEN.UpdUser = objRow[conDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[conDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objDiscussionTopicsEN.Memo = objRow[conDiscussionTopics.Memo] == DBNull.Value ? null : objRow[conDiscussionTopics.Memo].ToString().Trim(); //备注
objDiscussionTopicsEN.IdCurrEduCls = objRow[conDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[conDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
objDiscussionTopicsEN.SubCount = objRow[conDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDiscussionTopics.SubCount].ToString().Trim()); //SubCount
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDiscussionTopicsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDiscussionTopics(ref clsDiscussionTopicsEN objDiscussionTopicsEN)
{
bool bolResult = DiscussionTopicsDA.GetDiscussionTopics(ref objDiscussionTopicsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDiscussionTopicsEN GetObjByTopicsId(string strTopicsId)
{
if (strTopicsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsDiscussionTopicsEN objDiscussionTopicsEN = DiscussionTopicsDA.GetObjByTopicsId(strTopicsId);
return objDiscussionTopicsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDiscussionTopicsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDiscussionTopicsEN objDiscussionTopicsEN = DiscussionTopicsDA.GetFirstObj(strWhereCond);
 return objDiscussionTopicsEN;
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
public static clsDiscussionTopicsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDiscussionTopicsEN objDiscussionTopicsEN = DiscussionTopicsDA.GetObjByDataRow(objRow);
 return objDiscussionTopicsEN;
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
public static clsDiscussionTopicsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDiscussionTopicsEN objDiscussionTopicsEN = DiscussionTopicsDA.GetObjByDataRow(objRow);
 return objDiscussionTopicsEN;
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
 /// <param name = "strTopicsId">所给的关键字</param>
 /// <param name = "lstDiscussionTopicsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscussionTopicsEN GetObjByTopicsIdFromList(string strTopicsId, List<clsDiscussionTopicsEN> lstDiscussionTopicsObjLst)
{
foreach (clsDiscussionTopicsEN objDiscussionTopicsEN in lstDiscussionTopicsObjLst)
{
if (objDiscussionTopicsEN.TopicsId == strTopicsId)
{
return objDiscussionTopicsEN;
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
 string strTopicsId;
 try
 {
 strTopicsId = new clsDiscussionTopicsDA().GetFirstID(strWhereCond);
 return strTopicsId;
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
 arrList = DiscussionTopicsDA.GetID(strWhereCond);
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
bool bolIsExist = DiscussionTopicsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicsId)
{
if (string.IsNullOrEmpty(strTopicsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = DiscussionTopicsDA.IsExist(strTopicsId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTopicsId">主题Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTopicsId, string strOpUser)
{
clsDiscussionTopicsEN objDiscussionTopicsEN = clsDiscussionTopicsBL.GetObjByTopicsId(strTopicsId);
objDiscussionTopicsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDiscussionTopicsEN.UpdUser = strOpUser;
return clsDiscussionTopicsBL.UpdateBySql2(objDiscussionTopicsEN);
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
 bolIsExist = clsDiscussionTopicsDA.IsExistTable();
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
 bolIsExist = DiscussionTopicsDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscussionTopicsBL.IsExist(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscussionTopicsEN.TopicsId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = DiscussionTopicsDA.AddNewRecordBySQL2(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDiscussionTopicsEN objDiscussionTopicsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsDiscussionTopicsBL.IsExist(objDiscussionTopicsEN.TopicsId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objDiscussionTopicsEN.TopicsId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = DiscussionTopicsDA.AddNewRecordBySQL2WithReturnKey(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
try
{
bool bolResult = DiscussionTopicsDA.Update(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objDiscussionTopicsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 if (string.IsNullOrEmpty(objDiscussionTopicsEN.TopicsId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DiscussionTopicsDA.UpdateBySql2(objDiscussionTopicsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTopicsId)
{
try
{
 clsDiscussionTopicsEN objDiscussionTopicsEN = clsDiscussionTopicsBL.GetObjByTopicsId(strTopicsId);

if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(objDiscussionTopicsEN.TopicsId, objDiscussionTopicsEN.UpdUser);
}
if (objDiscussionTopicsEN != null)
{
int intRecNum = DiscussionTopicsDA.DelRecord(strTopicsId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strTopicsId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTopicsId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscussionTopicsDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[DiscussionTopics]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDiscussionTopics.TopicsId,
//strTopicsId);
//        clsDiscussionTopicsBL.DelDiscussionTopicssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscussionTopicsBL.DelRecord(strTopicsId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscussionTopicsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicsId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTopicsId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDiscussionTopicsBL.relatedActions != null)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(strTopicsId, "UpdRelaTabDate");
}
bool bolResult = DiscussionTopicsDA.DelRecord(strTopicsId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrTopicsIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDiscussionTopicss(List<string> arrTopicsIdLst)
{
if (arrTopicsIdLst.Count == 0) return 0;
try
{
if (clsDiscussionTopicsBL.relatedActions != null)
{
foreach (var strTopicsId in arrTopicsIdLst)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(strTopicsId, "UpdRelaTabDate");
}
}
 clsDiscussionTopicsEN objDiscussionTopicsEN = clsDiscussionTopicsBL.GetObjByTopicsId(arrTopicsIdLst[0]);
int intDelRecNum = DiscussionTopicsDA.DelDiscussionTopics(arrTopicsIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objDiscussionTopicsEN.IdCurrEduCls);
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelDiscussionTopicssByCond(string strWhereCond)
{
try
{
if (clsDiscussionTopicsBL.relatedActions != null)
{
List<string> arrTopicsId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTopicsId in arrTopicsId)
{
clsDiscussionTopicsBL.relatedActions.UpdRelaTabDate(strTopicsId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conDiscussionTopics.IdCurrEduCls, strWhereCond);
int intRecNum = DiscussionTopicsDA.DelDiscussionTopics(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DiscussionTopics]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTopicsId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTopicsId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDiscussionTopicsDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[DiscussionTopics]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDiscussionTopicsBL.DelRecord(strTopicsId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDiscussionTopicsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicsId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objDiscussionTopicsENS">源对象</param>
 /// <param name = "objDiscussionTopicsENT">目标对象</param>
 public static void CopyTo(clsDiscussionTopicsEN objDiscussionTopicsENS, clsDiscussionTopicsEN objDiscussionTopicsENT)
{
try
{
objDiscussionTopicsENT.TopicsId = objDiscussionTopicsENS.TopicsId; //主题Id
objDiscussionTopicsENT.DiscussionTypeId = objDiscussionTopicsENS.DiscussionTypeId; //讨论类型Id
objDiscussionTopicsENT.TopicsTitle = objDiscussionTopicsENS.TopicsTitle; //主题标题
objDiscussionTopicsENT.TopicsContent = objDiscussionTopicsENS.TopicsContent; //主题内容
objDiscussionTopicsENT.IsAudit = objDiscussionTopicsENS.IsAudit; //是否审核
objDiscussionTopicsENT.IsTop = objDiscussionTopicsENS.IsTop; //是否置顶
objDiscussionTopicsENT.BrowseNumber = objDiscussionTopicsENS.BrowseNumber; //浏览量
objDiscussionTopicsENT.UpdDate = objDiscussionTopicsENS.UpdDate; //修改日期
objDiscussionTopicsENT.UpdUser = objDiscussionTopicsENS.UpdUser; //修改人
objDiscussionTopicsENT.Memo = objDiscussionTopicsENS.Memo; //备注
objDiscussionTopicsENT.IdCurrEduCls = objDiscussionTopicsENS.IdCurrEduCls; //教学班流水号
objDiscussionTopicsENT.SubCount = objDiscussionTopicsENS.SubCount; //SubCount
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
 /// <param name = "objDiscussionTopicsEN">源简化对象</param>
 public static void SetUpdFlag(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
try
{
objDiscussionTopicsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDiscussionTopicsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDiscussionTopics.TopicsId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.TopicsId = objDiscussionTopicsEN.TopicsId; //主题Id
}
if (arrFldSet.Contains(conDiscussionTopics.DiscussionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.DiscussionTypeId = objDiscussionTopicsEN.DiscussionTypeId; //讨论类型Id
}
if (arrFldSet.Contains(conDiscussionTopics.TopicsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.TopicsTitle = objDiscussionTopicsEN.TopicsTitle == "[null]" ? null :  objDiscussionTopicsEN.TopicsTitle; //主题标题
}
if (arrFldSet.Contains(conDiscussionTopics.TopicsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.TopicsContent = objDiscussionTopicsEN.TopicsContent == "[null]" ? null :  objDiscussionTopicsEN.TopicsContent; //主题内容
}
if (arrFldSet.Contains(conDiscussionTopics.IsAudit, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.IsAudit = objDiscussionTopicsEN.IsAudit; //是否审核
}
if (arrFldSet.Contains(conDiscussionTopics.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.IsTop = objDiscussionTopicsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(conDiscussionTopics.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.BrowseNumber = objDiscussionTopicsEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(conDiscussionTopics.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.UpdDate = objDiscussionTopicsEN.UpdDate == "[null]" ? null :  objDiscussionTopicsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDiscussionTopics.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.UpdUser = objDiscussionTopicsEN.UpdUser == "[null]" ? null :  objDiscussionTopicsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conDiscussionTopics.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.Memo = objDiscussionTopicsEN.Memo == "[null]" ? null :  objDiscussionTopicsEN.Memo; //备注
}
if (arrFldSet.Contains(conDiscussionTopics.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.IdCurrEduCls = objDiscussionTopicsEN.IdCurrEduCls == "[null]" ? null :  objDiscussionTopicsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conDiscussionTopics.SubCount, new clsStrCompareIgnoreCase())  ==  true)
{
objDiscussionTopicsEN.SubCount = objDiscussionTopicsEN.SubCount; //SubCount
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
 /// <param name = "objDiscussionTopicsEN">源简化对象</param>
 public static void AccessFldValueNull(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
try
{
if (objDiscussionTopicsEN.TopicsTitle == "[null]") objDiscussionTopicsEN.TopicsTitle = null; //主题标题
if (objDiscussionTopicsEN.TopicsContent == "[null]") objDiscussionTopicsEN.TopicsContent = null; //主题内容
if (objDiscussionTopicsEN.UpdDate == "[null]") objDiscussionTopicsEN.UpdDate = null; //修改日期
if (objDiscussionTopicsEN.UpdUser == "[null]") objDiscussionTopicsEN.UpdUser = null; //修改人
if (objDiscussionTopicsEN.Memo == "[null]") objDiscussionTopicsEN.Memo = null; //备注
if (objDiscussionTopicsEN.IdCurrEduCls == "[null]") objDiscussionTopicsEN.IdCurrEduCls = null; //教学班流水号
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 DiscussionTopicsDA.CheckPropertyNew(objDiscussionTopicsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDiscussionTopicsEN objDiscussionTopicsEN)
{
 DiscussionTopicsDA.CheckProperty4Condition(objDiscussionTopicsEN);
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
if (clsDiscussionTopicsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionTopicsBL没有刷新缓存机制(clsDiscussionTopicsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicsId");
//if (arrDiscussionTopicsObjLstCache == null)
//{
//arrDiscussionTopicsObjLstCache = DiscussionTopicsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicsId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDiscussionTopicsEN GetObjByTopicsIdCache(string strTopicsId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
List<clsDiscussionTopicsEN> arrDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsDiscussionTopicsEN> arrDiscussionTopicsObjLst_Sel =
arrDiscussionTopicsObjLstCache
.Where(x=> x.TopicsId == strTopicsId 
);
if (arrDiscussionTopicsObjLst_Sel.Count() == 0)
{
   clsDiscussionTopicsEN obj = clsDiscussionTopicsBL.GetObjByTopicsId(strTopicsId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTopicsId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrDiscussionTopicsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscussionTopicsEN> GetAllDiscussionTopicsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsDiscussionTopicsEN> arrDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrDiscussionTopicsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDiscussionTopicsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsDiscussionTopicsEN> arrDiscussionTopicsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrDiscussionTopicsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsDiscussionTopicsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsDiscussionTopicsEN._RefreshTimeLst.Count == 0) return "";
return clsDiscussionTopicsEN._RefreshTimeLst[clsDiscussionTopicsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscussionTopicsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsDiscussionTopicsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsDiscussionTopicsBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicsId, string strIdCurrEduCls)
{
if (strInFldName != conDiscussionTopics.TopicsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDiscussionTopics.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDiscussionTopics.AttributeName));
throw new Exception(strMsg);
}
var objDiscussionTopics = clsDiscussionTopicsBL.GetObjByTopicsIdCache(strTopicsId, strIdCurrEduCls);
if (objDiscussionTopics == null) return "";
return objDiscussionTopics[strOutFldName].ToString();
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
int intRecCount = clsDiscussionTopicsDA.GetRecCount(strTabName);
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
int intRecCount = clsDiscussionTopicsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDiscussionTopicsDA.GetRecCount();
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
int intRecCount = clsDiscussionTopicsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDiscussionTopicsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDiscussionTopicsEN objDiscussionTopicsCond)
{
 string strIdCurrEduCls = objDiscussionTopicsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsDiscussionTopicsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsDiscussionTopicsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsDiscussionTopicsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDiscussionTopics.AttributeName)
{
if (objDiscussionTopicsCond.IsUpdated(strFldName) == false) continue;
if (objDiscussionTopicsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionTopicsCond[strFldName].ToString());
}
else
{
if (objDiscussionTopicsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDiscussionTopicsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDiscussionTopicsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDiscussionTopicsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDiscussionTopicsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDiscussionTopicsCond[strFldName]));
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
 List<string> arrList = clsDiscussionTopicsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DiscussionTopicsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DiscussionTopicsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = DiscussionTopicsDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsDiscussionTopicsDA.SetFldValue(clsDiscussionTopicsEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = DiscussionTopicsDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsDiscussionTopicsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsDiscussionTopicsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsDiscussionTopicsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[DiscussionTopics] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicsId char(8) primary key, "); 
 // /**讨论类型Id*/ 
 strCreateTabCode.Append(" DiscussionTypeId char(8) not Null, "); 
 // /**主题标题*/ 
 strCreateTabCode.Append(" TopicsTitle varchar(200) Null, "); 
 // /**主题内容*/ 
 strCreateTabCode.Append(" TopicsContent text Null, "); 
 // /**是否审核*/ 
 strCreateTabCode.Append(" IsAudit bit Null, "); 
 // /**是否置顶*/ 
 strCreateTabCode.Append(" IsTop bit Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" BrowseNumber int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**SubCount*/ 
 strCreateTabCode.Append(" SubCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 讨论主题(DiscussionTopics)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DiscussionTopics : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDiscussionTopicsBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}