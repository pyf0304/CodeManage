
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveVerBL
 表名:zx_TopicObjectiveVer(01120741)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
public static class  clszx_TopicObjectiveVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicObjectiveVerEN GetObj(this K_TopicObjectiveVId_zx_TopicObjectiveVer myKey)
{
clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.GetObjByTopicObjectiveVId(myKey.Value);
return objzx_TopicObjectiveVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
if (CheckUniqueness(objzx_TopicObjectiveVerEN) == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}],客观Id = [{1}]的数据已经存在!(in clszx_TopicObjectiveVerBL.AddNewRecord)", objzx_TopicObjectiveVerEN.TopicObjectiveVId,objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.AddNewRecordBySQL2(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objzx_TopicObjectiveVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TopicObjectiveVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题客观版本Id(TopicObjectiveVId)=[{0}],客观Id(zxTopicObjectiveId)=[{1}])已经存在,不能重复!", objzx_TopicObjectiveVerEN.TopicObjectiveVId, objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_TopicObjectiveVerEN.AddNewRecord();
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
if (CheckUniqueness(objzx_TopicObjectiveVerEN) == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}],客观Id = [{1}]的数据已经存在!(in clszx_TopicObjectiveVerBL.AddNewRecordWithReturnKey)", objzx_TopicObjectiveVerEN.TopicObjectiveVId,objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetTopicObjectiveVId(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, long lngTopicObjectiveVId, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = lngTopicObjectiveVId; //主题客观版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.TopicObjectiveVId) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.TopicObjectiveVId, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.TopicObjectiveVId] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetzxTopicObjectiveId(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strzxTopicObjectiveId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxTopicObjectiveId, conzx_TopicObjectiveVer.zxTopicObjectiveId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicObjectiveId, 8, conzx_TopicObjectiveVer.zxTopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicObjectiveId, 8, conzx_TopicObjectiveVer.zxTopicObjectiveId);
}
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = strzxTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.zxTopicObjectiveId) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.zxTopicObjectiveId, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.zxTopicObjectiveId] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetObjectiveName(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, conzx_TopicObjectiveVer.ObjectiveName);
}
objzx_TopicObjectiveVerEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.ObjectiveName) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.ObjectiveName, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.ObjectiveName] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetObjectiveContent(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strObjectiveContent, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.ObjectiveContent) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.ObjectiveContent, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.ObjectiveContent] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetObjectiveType(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, conzx_TopicObjectiveVer.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, conzx_TopicObjectiveVer.ObjectiveType);
}
objzx_TopicObjectiveVerEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.ObjectiveType) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.ObjectiveType, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.ObjectiveType] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetConclusion(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strConclusion, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.Conclusion) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.Conclusion, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.Conclusion] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetTextId(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_TopicObjectiveVer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_TopicObjectiveVer.TextId);
}
objzx_TopicObjectiveVerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.TextId) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.TextId, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.TextId] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetIsSubmit(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.IsSubmit) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.IsSubmit, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.IsSubmit] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetVoteCount(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.VoteCount) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.VoteCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.VoteCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetAppraiseCount(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.AppraiseCount) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.AppraiseCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.AppraiseCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetScore(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, float? fltScore, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.Score) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.Score, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.Score] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetStuScore(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.StuScore) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.StuScore, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.StuScore] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetTeaScore(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.TeaScore) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.TeaScore, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.TeaScore] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetCreateDate(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_TopicObjectiveVer.CreateDate);
}
objzx_TopicObjectiveVerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.CreateDate) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.CreateDate, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.CreateDate] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetUpdDate(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TopicObjectiveVer.UpdDate);
}
objzx_TopicObjectiveVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.UpdDate) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.UpdDate, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.UpdDate] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetUpdUser(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TopicObjectiveVer.UpdUser);
}
objzx_TopicObjectiveVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.UpdUser) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.UpdUser, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.UpdUser] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetIdCurrEduCls(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_TopicObjectiveVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_TopicObjectiveVer.IdCurrEduCls);
}
objzx_TopicObjectiveVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.IdCurrEduCls) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfContent(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_TopicObjectiveVer.PdfContent);
}
objzx_TopicObjectiveVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfContent) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfContent, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfContent] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfPageNum(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfPageNum) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfPageNum, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageNum] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetCitationCount(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.CitationCount) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.CitationCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.CitationCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetVersionCount(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.VersionCount) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.VersionCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.VersionCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetzxShareId(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_TopicObjectiveVer.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_TopicObjectiveVer.zxShareId);
}
objzx_TopicObjectiveVerEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.zxShareId) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.zxShareId, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.zxShareId] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetMemo(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TopicObjectiveVer.Memo);
}
objzx_TopicObjectiveVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.Memo) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.Memo, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.Memo] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfDivLet(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_TopicObjectiveVer.PdfDivLet);
}
objzx_TopicObjectiveVerEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfDivLet) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfDivLet, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfDivLet] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfDivTop(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_TopicObjectiveVer.PdfDivTop);
}
objzx_TopicObjectiveVerEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfDivTop) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfDivTop, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfDivTop] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfPageNumIn(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_TopicObjectiveVer.PdfPageNumIn);
}
objzx_TopicObjectiveVerEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfPageNumIn) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfPageTop(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_TopicObjectiveVerEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfPageTop) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfPageTop, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageTop] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetPdfZoom(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_TopicObjectiveVer.PdfZoom);
}
objzx_TopicObjectiveVerEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.PdfZoom) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.PdfZoom, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfZoom] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveVerEN SetGroupTextId(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_TopicObjectiveVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_TopicObjectiveVer.GroupTextId);
}
objzx_TopicObjectiveVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjectiveVer.GroupTextId) == false)
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp.Add(conzx_TopicObjectiveVer.GroupTextId, strComparisonOp);
}
else
{
objzx_TopicObjectiveVerEN.dicFldComparisonOp[conzx_TopicObjectiveVer.GroupTextId] = strComparisonOp;
}
}
return objzx_TopicObjectiveVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TopicObjectiveVerEN.CheckPropertyNew();
clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerCond = new clszx_TopicObjectiveVerEN();
string strCondition = objzx_TopicObjectiveVerCond
.SetTopicObjectiveVId(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "<>")
.SetTopicObjectiveVId(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "=")
.SetzxTopicObjectiveId(objzx_TopicObjectiveVerEN.zxTopicObjectiveId, "=")
.GetCombineCondition();
objzx_TopicObjectiveVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_TopicObjectiveVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicObjectiveVId_TopicObjectiveId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TopicObjectiveVerEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerCond = new clszx_TopicObjectiveVerEN();
string strCondition = objzx_TopicObjectiveVerCond
.SetTopicObjectiveVId(objzx_TopicObjectiveVer.TopicObjectiveVId, "=")
.SetzxTopicObjectiveId(objzx_TopicObjectiveVer.zxTopicObjectiveId, "=")
.GetCombineCondition();
objzx_TopicObjectiveVer._IsCheckProperty = true;
bool bolIsExist = clszx_TopicObjectiveVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TopicObjectiveVer.TopicObjectiveVId = clszx_TopicObjectiveVerBL.GetFirstID_S(strCondition);
objzx_TopicObjectiveVer.UpdateWithCondition(strCondition);
}
else
{
objzx_TopicObjectiveVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.UpdateBySql2(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.UpdateBySql2(objzx_TopicObjectiveVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.UpdateBySqlWithCondition(objzx_TopicObjectiveVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.UpdateBySqlWithConditionTransaction(objzx_TopicObjectiveVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
try
{
int intRecNum = clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.DelRecord(objzx_TopicObjectiveVerEN.TopicObjectiveVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveVerENT">目标对象</param>
 public static void CopyTo(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENS, clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENT)
{
try
{
objzx_TopicObjectiveVerENT.TopicObjectiveVId = objzx_TopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objzx_TopicObjectiveVerENT.zxTopicObjectiveId = objzx_TopicObjectiveVerENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveVerENT.ObjectiveName = objzx_TopicObjectiveVerENS.ObjectiveName; //客观名称
objzx_TopicObjectiveVerENT.ObjectiveContent = objzx_TopicObjectiveVerENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveVerENT.ObjectiveType = objzx_TopicObjectiveVerENS.ObjectiveType; //客观类型
objzx_TopicObjectiveVerENT.Conclusion = objzx_TopicObjectiveVerENS.Conclusion; //结论
objzx_TopicObjectiveVerENT.TextId = objzx_TopicObjectiveVerENS.TextId; //课件Id
objzx_TopicObjectiveVerENT.IsSubmit = objzx_TopicObjectiveVerENS.IsSubmit; //是否提交
objzx_TopicObjectiveVerENT.VoteCount = objzx_TopicObjectiveVerENS.VoteCount; //点赞计数
objzx_TopicObjectiveVerENT.AppraiseCount = objzx_TopicObjectiveVerENS.AppraiseCount; //评论数
objzx_TopicObjectiveVerENT.Score = objzx_TopicObjectiveVerENS.Score; //评分
objzx_TopicObjectiveVerENT.StuScore = objzx_TopicObjectiveVerENS.StuScore; //学生平均分
objzx_TopicObjectiveVerENT.TeaScore = objzx_TopicObjectiveVerENS.TeaScore; //教师评分
objzx_TopicObjectiveVerENT.CreateDate = objzx_TopicObjectiveVerENS.CreateDate; //建立日期
objzx_TopicObjectiveVerENT.UpdDate = objzx_TopicObjectiveVerENS.UpdDate; //修改日期
objzx_TopicObjectiveVerENT.UpdUser = objzx_TopicObjectiveVerENS.UpdUser; //修改人
objzx_TopicObjectiveVerENT.IdCurrEduCls = objzx_TopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveVerENT.PdfContent = objzx_TopicObjectiveVerENS.PdfContent; //Pdf内容
objzx_TopicObjectiveVerENT.PdfPageNum = objzx_TopicObjectiveVerENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveVerENT.CitationCount = objzx_TopicObjectiveVerENS.CitationCount; //引用统计
objzx_TopicObjectiveVerENT.VersionCount = objzx_TopicObjectiveVerENS.VersionCount; //版本统计
objzx_TopicObjectiveVerENT.zxShareId = objzx_TopicObjectiveVerENS.zxShareId; //分享Id
objzx_TopicObjectiveVerENT.Memo = objzx_TopicObjectiveVerENS.Memo; //备注
objzx_TopicObjectiveVerENT.PdfDivLet = objzx_TopicObjectiveVerENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveVerENT.PdfDivTop = objzx_TopicObjectiveVerENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveVerENT.PdfPageNumIn = objzx_TopicObjectiveVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveVerENT.PdfPageTop = objzx_TopicObjectiveVerENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveVerENT.PdfZoom = objzx_TopicObjectiveVerENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveVerENT.GroupTextId = objzx_TopicObjectiveVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveVerENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicObjectiveVerEN:objzx_TopicObjectiveVerENT</returns>
 public static clszx_TopicObjectiveVerEN CopyTo(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENS)
{
try
{
 clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENT = new clszx_TopicObjectiveVerEN()
{
TopicObjectiveVId = objzx_TopicObjectiveVerENS.TopicObjectiveVId, //主题客观版本Id
zxTopicObjectiveId = objzx_TopicObjectiveVerENS.zxTopicObjectiveId, //客观Id
ObjectiveName = objzx_TopicObjectiveVerENS.ObjectiveName, //客观名称
ObjectiveContent = objzx_TopicObjectiveVerENS.ObjectiveContent, //客观内容
ObjectiveType = objzx_TopicObjectiveVerENS.ObjectiveType, //客观类型
Conclusion = objzx_TopicObjectiveVerENS.Conclusion, //结论
TextId = objzx_TopicObjectiveVerENS.TextId, //课件Id
IsSubmit = objzx_TopicObjectiveVerENS.IsSubmit, //是否提交
VoteCount = objzx_TopicObjectiveVerENS.VoteCount, //点赞计数
AppraiseCount = objzx_TopicObjectiveVerENS.AppraiseCount, //评论数
Score = objzx_TopicObjectiveVerENS.Score, //评分
StuScore = objzx_TopicObjectiveVerENS.StuScore, //学生平均分
TeaScore = objzx_TopicObjectiveVerENS.TeaScore, //教师评分
CreateDate = objzx_TopicObjectiveVerENS.CreateDate, //建立日期
UpdDate = objzx_TopicObjectiveVerENS.UpdDate, //修改日期
UpdUser = objzx_TopicObjectiveVerENS.UpdUser, //修改人
IdCurrEduCls = objzx_TopicObjectiveVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_TopicObjectiveVerENS.PdfContent, //Pdf内容
PdfPageNum = objzx_TopicObjectiveVerENS.PdfPageNum, //Pdf页码
CitationCount = objzx_TopicObjectiveVerENS.CitationCount, //引用统计
VersionCount = objzx_TopicObjectiveVerENS.VersionCount, //版本统计
zxShareId = objzx_TopicObjectiveVerENS.zxShareId, //分享Id
Memo = objzx_TopicObjectiveVerENS.Memo, //备注
PdfDivLet = objzx_TopicObjectiveVerENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_TopicObjectiveVerENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_TopicObjectiveVerENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_TopicObjectiveVerENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_TopicObjectiveVerENS.PdfZoom, //PdfZoom
GroupTextId = objzx_TopicObjectiveVerENS.GroupTextId, //小组Id
};
 return objzx_TopicObjectiveVerENT;
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
public static void CheckPropertyNew(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 clszx_TopicObjectiveVerBL.zx_TopicObjectiveVerDA.CheckProperty4Condition(objzx_TopicObjectiveVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.TopicObjectiveVId) == true)
{
string strComparisonOpTopicObjectiveVId = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.TopicObjectiveVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.TopicObjectiveVId, objzx_TopicObjectiveVerCond.TopicObjectiveVId, strComparisonOpTopicObjectiveVId);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.zxTopicObjectiveId) == true)
{
string strComparisonOpzxTopicObjectiveId = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.zxTopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.zxTopicObjectiveId, objzx_TopicObjectiveVerCond.zxTopicObjectiveId, strComparisonOpzxTopicObjectiveId);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.ObjectiveName, objzx_TopicObjectiveVerCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.ObjectiveType, objzx_TopicObjectiveVerCond.ObjectiveType, strComparisonOpObjectiveType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.TextId) == true)
{
string strComparisonOpTextId = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.TextId, objzx_TopicObjectiveVerCond.TextId, strComparisonOpTextId);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.IsSubmit) == true)
{
if (objzx_TopicObjectiveVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TopicObjectiveVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TopicObjectiveVer.IsSubmit);
}
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.VoteCount, objzx_TopicObjectiveVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.AppraiseCount, objzx_TopicObjectiveVerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.Score) == true)
{
string strComparisonOpScore = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.Score, objzx_TopicObjectiveVerCond.Score, strComparisonOpScore);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.StuScore, objzx_TopicObjectiveVerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.TeaScore, objzx_TopicObjectiveVerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.CreateDate, objzx_TopicObjectiveVerCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.UpdDate, objzx_TopicObjectiveVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.UpdUser, objzx_TopicObjectiveVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.IdCurrEduCls, objzx_TopicObjectiveVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.PdfContent, objzx_TopicObjectiveVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.PdfPageNum, objzx_TopicObjectiveVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.CitationCount, objzx_TopicObjectiveVerCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.VersionCount, objzx_TopicObjectiveVerCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.zxShareId, objzx_TopicObjectiveVerCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.Memo) == true)
{
string strComparisonOpMemo = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.Memo, objzx_TopicObjectiveVerCond.Memo, strComparisonOpMemo);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.PdfDivLet, objzx_TopicObjectiveVerCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.PdfDivTop, objzx_TopicObjectiveVerCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.PdfPageNumIn, objzx_TopicObjectiveVerCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjectiveVer.PdfPageTop, objzx_TopicObjectiveVerCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.PdfZoom, objzx_TopicObjectiveVerCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_TopicObjectiveVerCond.IsUpdated(conzx_TopicObjectiveVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_TopicObjectiveVerCond.dicFldComparisonOp[conzx_TopicObjectiveVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjectiveVer.GroupTextId, objzx_TopicObjectiveVerCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TopicObjectiveVer(客观数据历史), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicObjectiveVId_TopicObjectiveId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicObjectiveVerEN == null) return true;
if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
if (clszx_TopicObjectiveVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TopicObjectiveVId !=  {0}", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
if (clszx_TopicObjectiveVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TopicObjectiveVer(客观数据历史), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicObjectiveVId_TopicObjectiveId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicObjectiveVerEN == null) return "";
if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TopicObjectiveVId !=  {0}", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objzx_TopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and zxTopicObjectiveId = '{0}'", objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TopicObjectiveVer
{
public virtual bool UpdRelaTabDate(long lngTopicObjectiveVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 客观数据历史(zx_TopicObjectiveVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TopicObjectiveVerBL
{
public static RelatedActions_zx_TopicObjectiveVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TopicObjectiveVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TopicObjectiveVerDA zx_TopicObjectiveVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TopicObjectiveVerDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clszx_TopicObjectiveVerBL()
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
if (string.IsNullOrEmpty(clszx_TopicObjectiveVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_TopicObjectiveVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TopicObjectiveVerDA.GetDataTable_zx_TopicObjectiveVer(strWhereCond);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable(strWhereCond);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TopicObjectiveVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TopicObjectiveVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TopicObjectiveVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicObjectiveVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetObjLstByTopicObjectiveVIdLst(List<long> arrTopicObjectiveVIdLst)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicObjectiveVIdLst);
 string strWhereCond = string.Format("TopicObjectiveVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicObjectiveVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TopicObjectiveVerEN> GetObjLstByTopicObjectiveVIdLstCache(List<long> arrTopicObjectiveVIdLst)
{
string strKey = string.Format("{0}", clszx_TopicObjectiveVerEN._CurrTabName);
List<clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLst_Sel =
arrzx_TopicObjectiveVerObjLstCache
.Where(x => arrTopicObjectiveVIdLst.Contains(x.TopicObjectiveVId));
return arrzx_TopicObjectiveVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetObjLst(string strWhereCond)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
public static List<clszx_TopicObjectiveVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TopicObjectiveVerEN> GetSubObjLstCache(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerCond)
{
List<clszx_TopicObjectiveVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicObjectiveVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicObjectiveVer.AttributeName)
{
if (objzx_TopicObjectiveVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicObjectiveVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveVerCond[strFldName].ToString());
}
else
{
if (objzx_TopicObjectiveVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicObjectiveVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicObjectiveVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveVerCond[strFldName]));
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
public static List<clszx_TopicObjectiveVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
public static List<clszx_TopicObjectiveVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
List<clszx_TopicObjectiveVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TopicObjectiveVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TopicObjectiveVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
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
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
public static List<clszx_TopicObjectiveVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TopicObjectiveVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
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
public static List<clszx_TopicObjectiveVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TopicObjectiveVerEN> arrObjLst = new List<clszx_TopicObjectiveVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = new clszx_TopicObjectiveVerEN();
try
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conzx_TopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objRow[conzx_TopicObjectiveVer.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveVerEN.ObjectiveName = objRow[conzx_TopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveVerEN.ObjectiveContent = objRow[conzx_TopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveVerEN.ObjectiveType = objRow[conzx_TopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveVerEN.Conclusion = objRow[conzx_TopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveVerEN.TextId = objRow[conzx_TopicObjectiveVer.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjectiveVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveVerEN.VoteCount = objRow[conzx_TopicObjectiveVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveVerEN.AppraiseCount = objRow[conzx_TopicObjectiveVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveVerEN.Score = objRow[conzx_TopicObjectiveVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.Score].ToString().Trim()); //评分
objzx_TopicObjectiveVerEN.StuScore = objRow[conzx_TopicObjectiveVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveVerEN.TeaScore = objRow[conzx_TopicObjectiveVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjectiveVer.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveVerEN.CreateDate = objRow[conzx_TopicObjectiveVer.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveVerEN.UpdDate = objRow[conzx_TopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveVerEN.UpdUser = objRow[conzx_TopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveVerEN.IdCurrEduCls = objRow[conzx_TopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveVerEN.PdfContent = objRow[conzx_TopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveVerEN.PdfPageNum = objRow[conzx_TopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveVerEN.CitationCount = objRow[conzx_TopicObjectiveVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveVerEN.VersionCount = objRow[conzx_TopicObjectiveVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveVerEN.zxShareId = objRow[conzx_TopicObjectiveVer.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveVerEN.Memo = objRow[conzx_TopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveVerEN.PdfDivLet = objRow[conzx_TopicObjectiveVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveVerEN.PdfDivTop = objRow[conzx_TopicObjectiveVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveVerEN.PdfPageNumIn = objRow[conzx_TopicObjectiveVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveVerEN.PdfPageTop = objRow[conzx_TopicObjectiveVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjectiveVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveVerEN.PdfZoom = objRow[conzx_TopicObjectiveVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveVerEN.GroupTextId = objRow[conzx_TopicObjectiveVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjectiveVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TopicObjectiveVer(ref clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
bool bolResult = zx_TopicObjectiveVerDA.Getzx_TopicObjectiveVer(ref objzx_TopicObjectiveVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicObjectiveVerEN GetObjByTopicObjectiveVId(long lngTopicObjectiveVId)
{
clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = zx_TopicObjectiveVerDA.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);
return objzx_TopicObjectiveVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TopicObjectiveVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = zx_TopicObjectiveVerDA.GetFirstObj(strWhereCond);
 return objzx_TopicObjectiveVerEN;
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
public static clszx_TopicObjectiveVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = zx_TopicObjectiveVerDA.GetObjByDataRow(objRow);
 return objzx_TopicObjectiveVerEN;
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
public static clszx_TopicObjectiveVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = zx_TopicObjectiveVerDA.GetObjByDataRow(objRow);
 return objzx_TopicObjectiveVerEN;
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
 /// <param name = "lngTopicObjectiveVId">所给的关键字</param>
 /// <param name = "lstzx_TopicObjectiveVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicObjectiveVerEN GetObjByTopicObjectiveVIdFromList(long lngTopicObjectiveVId, List<clszx_TopicObjectiveVerEN> lstzx_TopicObjectiveVerObjLst)
{
foreach (clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN in lstzx_TopicObjectiveVerObjLst)
{
if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == lngTopicObjectiveVId)
{
return objzx_TopicObjectiveVerEN;
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
 long lngTopicObjectiveVId;
 try
 {
 lngTopicObjectiveVId = new clszx_TopicObjectiveVerDA().GetFirstID(strWhereCond);
 return lngTopicObjectiveVId;
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
 arrList = zx_TopicObjectiveVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TopicObjectiveVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngTopicObjectiveVId)
{
//检测记录是否存在
bool bolIsExist = zx_TopicObjectiveVerDA.IsExist(lngTopicObjectiveVId);
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
 bolIsExist = clszx_TopicObjectiveVerDA.IsExistTable();
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
 bolIsExist = zx_TopicObjectiveVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
if (objzx_TopicObjectiveVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}],客观Id = [{1}]的数据已经存在!(in clszx_TopicObjectiveVerBL.AddNewRecordBySql2)", objzx_TopicObjectiveVerEN.TopicObjectiveVId,objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_TopicObjectiveVerDA.AddNewRecordBySQL2(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
if (objzx_TopicObjectiveVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}],客观Id = [{1}]的数据已经存在!(in clszx_TopicObjectiveVerBL.AddNewRecordBySql2WithReturnKey)", objzx_TopicObjectiveVerEN.TopicObjectiveVId,objzx_TopicObjectiveVerEN.zxTopicObjectiveId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_TopicObjectiveVerDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
try
{
bool bolResult = zx_TopicObjectiveVerDA.Update(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 if (objzx_TopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TopicObjectiveVerDA.UpdateBySql2(objzx_TopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveVerBL.ReFreshCache();

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngTopicObjectiveVId)
{
try
{
 clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN = clszx_TopicObjectiveVerBL.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);

if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
}
if (objzx_TopicObjectiveVerEN != null)
{
int intRecNum = zx_TopicObjectiveVerDA.DelRecord(lngTopicObjectiveVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// <param name="lngTopicObjectiveVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngTopicObjectiveVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicObjectiveVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TopicObjectiveVer.TopicObjectiveVId,
//lngTopicObjectiveVId);
//        clszx_TopicObjectiveVerBL.Delzx_TopicObjectiveVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicObjectiveVerBL.DelRecord(lngTopicObjectiveVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicObjectiveVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTopicObjectiveVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngTopicObjectiveVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
bool bolResult = zx_TopicObjectiveVerDA.DelRecord(lngTopicObjectiveVId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
 /// <param name = "arrTopicObjectiveVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TopicObjectiveVers(List<string> arrTopicObjectiveVIdLst)
{
if (arrTopicObjectiveVIdLst.Count == 0) return 0;
try
{
if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
foreach (var strTopicObjectiveVId in arrTopicObjectiveVIdLst)
{
long lngTopicObjectiveVId = long.Parse(strTopicObjectiveVId);
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TopicObjectiveVerDA.Delzx_TopicObjectiveVer(arrTopicObjectiveVIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
public static int Delzx_TopicObjectiveVersByCond(string strWhereCond)
{
try
{
if (clszx_TopicObjectiveVerBL.relatedActions != null)
{
List<string> arrTopicObjectiveVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTopicObjectiveVId in arrTopicObjectiveVId)
{
long lngTopicObjectiveVId = long.Parse(strTopicObjectiveVId);
clszx_TopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TopicObjectiveVerDA.Delzx_TopicObjectiveVer(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TopicObjectiveVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngTopicObjectiveVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngTopicObjectiveVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicObjectiveVerDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicObjectiveVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicObjectiveVerBL.DelRecord(lngTopicObjectiveVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicObjectiveVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTopicObjectiveVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TopicObjectiveVerENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveVerENT">目标对象</param>
 public static void CopyTo(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENS, clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerENT)
{
try
{
objzx_TopicObjectiveVerENT.TopicObjectiveVId = objzx_TopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objzx_TopicObjectiveVerENT.zxTopicObjectiveId = objzx_TopicObjectiveVerENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveVerENT.ObjectiveName = objzx_TopicObjectiveVerENS.ObjectiveName; //客观名称
objzx_TopicObjectiveVerENT.ObjectiveContent = objzx_TopicObjectiveVerENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveVerENT.ObjectiveType = objzx_TopicObjectiveVerENS.ObjectiveType; //客观类型
objzx_TopicObjectiveVerENT.Conclusion = objzx_TopicObjectiveVerENS.Conclusion; //结论
objzx_TopicObjectiveVerENT.TextId = objzx_TopicObjectiveVerENS.TextId; //课件Id
objzx_TopicObjectiveVerENT.IsSubmit = objzx_TopicObjectiveVerENS.IsSubmit; //是否提交
objzx_TopicObjectiveVerENT.VoteCount = objzx_TopicObjectiveVerENS.VoteCount; //点赞计数
objzx_TopicObjectiveVerENT.AppraiseCount = objzx_TopicObjectiveVerENS.AppraiseCount; //评论数
objzx_TopicObjectiveVerENT.Score = objzx_TopicObjectiveVerENS.Score; //评分
objzx_TopicObjectiveVerENT.StuScore = objzx_TopicObjectiveVerENS.StuScore; //学生平均分
objzx_TopicObjectiveVerENT.TeaScore = objzx_TopicObjectiveVerENS.TeaScore; //教师评分
objzx_TopicObjectiveVerENT.CreateDate = objzx_TopicObjectiveVerENS.CreateDate; //建立日期
objzx_TopicObjectiveVerENT.UpdDate = objzx_TopicObjectiveVerENS.UpdDate; //修改日期
objzx_TopicObjectiveVerENT.UpdUser = objzx_TopicObjectiveVerENS.UpdUser; //修改人
objzx_TopicObjectiveVerENT.IdCurrEduCls = objzx_TopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveVerENT.PdfContent = objzx_TopicObjectiveVerENS.PdfContent; //Pdf内容
objzx_TopicObjectiveVerENT.PdfPageNum = objzx_TopicObjectiveVerENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveVerENT.CitationCount = objzx_TopicObjectiveVerENS.CitationCount; //引用统计
objzx_TopicObjectiveVerENT.VersionCount = objzx_TopicObjectiveVerENS.VersionCount; //版本统计
objzx_TopicObjectiveVerENT.zxShareId = objzx_TopicObjectiveVerENS.zxShareId; //分享Id
objzx_TopicObjectiveVerENT.Memo = objzx_TopicObjectiveVerENS.Memo; //备注
objzx_TopicObjectiveVerENT.PdfDivLet = objzx_TopicObjectiveVerENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveVerENT.PdfDivTop = objzx_TopicObjectiveVerENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveVerENT.PdfPageNumIn = objzx_TopicObjectiveVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveVerENT.PdfPageTop = objzx_TopicObjectiveVerENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveVerENT.PdfZoom = objzx_TopicObjectiveVerENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveVerENT.GroupTextId = objzx_TopicObjectiveVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
try
{
objzx_TopicObjectiveVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TopicObjectiveVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TopicObjectiveVer.TopicObjectiveVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.TopicObjectiveVId = objzx_TopicObjectiveVerEN.TopicObjectiveVId; //主题客观版本Id
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.zxTopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.zxTopicObjectiveId = objzx_TopicObjectiveVerEN.zxTopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.ObjectiveName = objzx_TopicObjectiveVerEN.ObjectiveName == "[null]" ? null :  objzx_TopicObjectiveVerEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.ObjectiveContent = objzx_TopicObjectiveVerEN.ObjectiveContent == "[null]" ? null :  objzx_TopicObjectiveVerEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.ObjectiveType = objzx_TopicObjectiveVerEN.ObjectiveType == "[null]" ? null :  objzx_TopicObjectiveVerEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.Conclusion = objzx_TopicObjectiveVerEN.Conclusion == "[null]" ? null :  objzx_TopicObjectiveVerEN.Conclusion; //结论
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.TextId = objzx_TopicObjectiveVerEN.TextId == "[null]" ? null :  objzx_TopicObjectiveVerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.IsSubmit = objzx_TopicObjectiveVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.VoteCount = objzx_TopicObjectiveVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.AppraiseCount = objzx_TopicObjectiveVerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.Score = objzx_TopicObjectiveVerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.StuScore = objzx_TopicObjectiveVerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.TeaScore = objzx_TopicObjectiveVerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.CreateDate = objzx_TopicObjectiveVerEN.CreateDate == "[null]" ? null :  objzx_TopicObjectiveVerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.UpdDate = objzx_TopicObjectiveVerEN.UpdDate == "[null]" ? null :  objzx_TopicObjectiveVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.UpdUser = objzx_TopicObjectiveVerEN.UpdUser == "[null]" ? null :  objzx_TopicObjectiveVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.IdCurrEduCls = objzx_TopicObjectiveVerEN.IdCurrEduCls == "[null]" ? null :  objzx_TopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfContent = objzx_TopicObjectiveVerEN.PdfContent == "[null]" ? null :  objzx_TopicObjectiveVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfPageNum = objzx_TopicObjectiveVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.CitationCount = objzx_TopicObjectiveVerEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.VersionCount = objzx_TopicObjectiveVerEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.zxShareId = objzx_TopicObjectiveVerEN.zxShareId == "[null]" ? null :  objzx_TopicObjectiveVerEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.Memo = objzx_TopicObjectiveVerEN.Memo == "[null]" ? null :  objzx_TopicObjectiveVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfDivLet = objzx_TopicObjectiveVerEN.PdfDivLet == "[null]" ? null :  objzx_TopicObjectiveVerEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfDivTop = objzx_TopicObjectiveVerEN.PdfDivTop == "[null]" ? null :  objzx_TopicObjectiveVerEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfPageNumIn = objzx_TopicObjectiveVerEN.PdfPageNumIn == "[null]" ? null :  objzx_TopicObjectiveVerEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfPageTop = objzx_TopicObjectiveVerEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.PdfZoom = objzx_TopicObjectiveVerEN.PdfZoom == "[null]" ? null :  objzx_TopicObjectiveVerEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_TopicObjectiveVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveVerEN.GroupTextId = objzx_TopicObjectiveVerEN.GroupTextId == "[null]" ? null :  objzx_TopicObjectiveVerEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
try
{
if (objzx_TopicObjectiveVerEN.ObjectiveName == "[null]") objzx_TopicObjectiveVerEN.ObjectiveName = null; //客观名称
if (objzx_TopicObjectiveVerEN.ObjectiveContent == "[null]") objzx_TopicObjectiveVerEN.ObjectiveContent = null; //客观内容
if (objzx_TopicObjectiveVerEN.ObjectiveType == "[null]") objzx_TopicObjectiveVerEN.ObjectiveType = null; //客观类型
if (objzx_TopicObjectiveVerEN.Conclusion == "[null]") objzx_TopicObjectiveVerEN.Conclusion = null; //结论
if (objzx_TopicObjectiveVerEN.TextId == "[null]") objzx_TopicObjectiveVerEN.TextId = null; //课件Id
if (objzx_TopicObjectiveVerEN.CreateDate == "[null]") objzx_TopicObjectiveVerEN.CreateDate = null; //建立日期
if (objzx_TopicObjectiveVerEN.UpdDate == "[null]") objzx_TopicObjectiveVerEN.UpdDate = null; //修改日期
if (objzx_TopicObjectiveVerEN.UpdUser == "[null]") objzx_TopicObjectiveVerEN.UpdUser = null; //修改人
if (objzx_TopicObjectiveVerEN.IdCurrEduCls == "[null]") objzx_TopicObjectiveVerEN.IdCurrEduCls = null; //教学班流水号
if (objzx_TopicObjectiveVerEN.PdfContent == "[null]") objzx_TopicObjectiveVerEN.PdfContent = null; //Pdf内容
if (objzx_TopicObjectiveVerEN.zxShareId == "[null]") objzx_TopicObjectiveVerEN.zxShareId = null; //分享Id
if (objzx_TopicObjectiveVerEN.Memo == "[null]") objzx_TopicObjectiveVerEN.Memo = null; //备注
if (objzx_TopicObjectiveVerEN.PdfDivLet == "[null]") objzx_TopicObjectiveVerEN.PdfDivLet = null; //PdfDivLet
if (objzx_TopicObjectiveVerEN.PdfDivTop == "[null]") objzx_TopicObjectiveVerEN.PdfDivTop = null; //PdfDivTop
if (objzx_TopicObjectiveVerEN.PdfPageNumIn == "[null]") objzx_TopicObjectiveVerEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_TopicObjectiveVerEN.PdfZoom == "[null]") objzx_TopicObjectiveVerEN.PdfZoom = null; //PdfZoom
if (objzx_TopicObjectiveVerEN.GroupTextId == "[null]") objzx_TopicObjectiveVerEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 zx_TopicObjectiveVerDA.CheckPropertyNew(objzx_TopicObjectiveVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
 zx_TopicObjectiveVerDA.CheckProperty4Condition(objzx_TopicObjectiveVerEN);
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
if (clszx_TopicObjectiveVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicObjectiveVerBL没有刷新缓存机制(clszx_TopicObjectiveVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicObjectiveVId");
//if (arrzx_TopicObjectiveVerObjLstCache == null)
//{
//arrzx_TopicObjectiveVerObjLstCache = zx_TopicObjectiveVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicObjectiveVerEN GetObjByTopicObjectiveVIdCache(long lngTopicObjectiveVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TopicObjectiveVerEN._CurrTabName);
List<clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLst_Sel =
arrzx_TopicObjectiveVerObjLstCache
.Where(x=> x.TopicObjectiveVId == lngTopicObjectiveVId 
);
if (arrzx_TopicObjectiveVerObjLst_Sel.Count() == 0)
{
   clszx_TopicObjectiveVerEN obj = clszx_TopicObjectiveVerBL.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TopicObjectiveVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetAllzx_TopicObjectiveVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLstCache = GetObjLstCache(); 
return arrzx_TopicObjectiveVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicObjectiveVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TopicObjectiveVerEN._CurrTabName);
List<clszx_TopicObjectiveVerEN> arrzx_TopicObjectiveVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TopicObjectiveVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_TopicObjectiveVerEN._CurrTabName);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clszx_TopicObjectiveVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TopicObjectiveVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TopicObjectiveVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TopicObjectiveVer(客观数据历史)
 /// 唯一性条件:TopicObjectiveVId_TopicObjectiveId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerEN)
{
//检测记录是否存在
string strResult = zx_TopicObjectiveVerDA.GetUniCondStr(objzx_TopicObjectiveVerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngTopicObjectiveVId)
{
if (strInFldName != conzx_TopicObjectiveVer.TopicObjectiveVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TopicObjectiveVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TopicObjectiveVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_TopicObjectiveVer = clszx_TopicObjectiveVerBL.GetObjByTopicObjectiveVIdCache(lngTopicObjectiveVId);
if (objzx_TopicObjectiveVer == null) return "";
return objzx_TopicObjectiveVer[strOutFldName].ToString();
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
int intRecCount = clszx_TopicObjectiveVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TopicObjectiveVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TopicObjectiveVerDA.GetRecCount();
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
int intRecCount = clszx_TopicObjectiveVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TopicObjectiveVerEN objzx_TopicObjectiveVerCond)
{
List<clszx_TopicObjectiveVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicObjectiveVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicObjectiveVer.AttributeName)
{
if (objzx_TopicObjectiveVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicObjectiveVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveVerCond[strFldName].ToString());
}
else
{
if (objzx_TopicObjectiveVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicObjectiveVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicObjectiveVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveVerCond[strFldName]));
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
 List<string> arrList = clszx_TopicObjectiveVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicObjectiveVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicObjectiveVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TopicObjectiveVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveVerDA.SetFldValue(clszx_TopicObjectiveVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TopicObjectiveVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TopicObjectiveVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题客观版本Id*/ 
 strCreateTabCode.Append(" TopicObjectiveVId bigint primary key identity, "); 
 // /**客观Id*/ 
 strCreateTabCode.Append(" zxTopicObjectiveId char(8) not Null, "); 
 // /**客观名称*/ 
 strCreateTabCode.Append(" ObjectiveName varchar(500) Null, "); 
 // /**客观内容*/ 
 strCreateTabCode.Append(" ObjectiveContent text Null, "); 
 // /**客观类型*/ 
 strCreateTabCode.Append(" ObjectiveType char(2) Null, "); 
 // /**结论*/ 
 strCreateTabCode.Append(" Conclusion text Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 客观数据历史(zx_TopicObjectiveVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TopicObjectiveVer : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clszx_TopicObjectiveVerBL.ReFreshThisCache();
}
}

}