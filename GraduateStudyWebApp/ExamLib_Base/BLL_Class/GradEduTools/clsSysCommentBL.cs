﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCommentBL
 表名:SysComment(01120622)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:38
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
public static class  clsSysCommentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCommentEN GetObj(this K_CommentId_SysComment myKey)
{
clsSysCommentEN objSysCommentEN = clsSysCommentBL.SysCommentDA.GetObjByCommentId(myKey.Value);
return objSysCommentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCommentEN) == false)
{
var strMsg = string.Format("记录已经存在!评论Id = [{0}]的数据已经存在!(in clsSysCommentBL.AddNewRecord)", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
bool bolResult = clsSysCommentBL.SysCommentDA.AddNewRecordBySQL2(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSysCommentBL.IsExist(objSysCommentEN.CommentId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSysCommentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysCommentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(评论Id(CommentId)=[{0}])已经存在,不能重复!", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSysCommentEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCommentEN) == false)
{
var strMsg = string.Format("记录已经存在!评论Id = [{0}]的数据已经存在!(in clsSysCommentBL.AddNewRecordWithMaxId)", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
string strCommentId = clsSysCommentBL.SysCommentDA.AddNewRecordBySQL2WithReturnKey(objSysCommentEN);
     objSysCommentEN.CommentId = strCommentId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
}
return strCommentId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysCommentEN) == false)
{
var strMsg = string.Format("记录已经存在!评论Id = [{0}]的数据已经存在!(in clsSysCommentBL.AddNewRecordWithReturnKey)", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
string strKey = clsSysCommentBL.SysCommentDA.AddNewRecordBySQL2WithReturnKey(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetCommentId(this clsSysCommentEN objSysCommentEN, string strCommentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentId, 10, conSysComment.CommentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCommentId, 10, conSysComment.CommentId);
}
objSysCommentEN.CommentId = strCommentId; //评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.CommentId) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.CommentId, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.CommentId] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetComment(this clsSysCommentEN objSysCommentEN, string strComment, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strComment, 2000, conSysComment.Comment);
}
objSysCommentEN.Comment = strComment; //评论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.Comment) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.Comment, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.Comment] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetScore(this clsSysCommentEN objSysCommentEN, float? fltScore, string strComparisonOp="")
	{
objSysCommentEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.Score) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.Score, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.Score] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetCommentTypeId(this clsSysCommentEN objSysCommentEN, string strCommentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCommentTypeId, conSysComment.CommentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeId, 2, conSysComment.CommentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCommentTypeId, 2, conSysComment.CommentTypeId);
}
objSysCommentEN.CommentTypeId = strCommentTypeId; //评论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.CommentTypeId) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.CommentTypeId, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.CommentTypeId] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetScoreType(this clsSysCommentEN objSysCommentEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, conSysComment.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conSysComment.ScoreType);
}
objSysCommentEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.ScoreType) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.ScoreType, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.ScoreType] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetParentId(this clsSysCommentEN objSysCommentEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentId, conSysComment.ParentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, conSysComment.ParentId);
}
objSysCommentEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.ParentId) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.ParentId, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.ParentId] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetTableKey(this clsSysCommentEN objSysCommentEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, conSysComment.TableKey);
}
objSysCommentEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.TableKey) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.TableKey, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.TableKey] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetOkCount(this clsSysCommentEN objSysCommentEN, int? intOkCount, string strComparisonOp="")
	{
objSysCommentEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.OkCount) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.OkCount, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.OkCount] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetPubParentId(this clsSysCommentEN objSysCommentEN, string strPubParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubParentId, 20, conSysComment.PubParentId);
}
objSysCommentEN.PubParentId = strPubParentId; //公共父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.PubParentId) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.PubParentId, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.PubParentId] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetIdCurrEduCls(this clsSysCommentEN objSysCommentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysComment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysComment.IdCurrEduCls);
}
objSysCommentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.IdCurrEduCls) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.IdCurrEduCls, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.IdCurrEduCls] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetUserId(this clsSysCommentEN objSysCommentEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conSysComment.UserId);
}
objSysCommentEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.UserId) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.UserId, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.UserId] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetMonth(this clsSysCommentEN objSysCommentEN, int? intMonth, string strComparisonOp="")
	{
objSysCommentEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.Month) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.Month, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.Month] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetWeek(this clsSysCommentEN objSysCommentEN, int? intWeek, string strComparisonOp="")
	{
objSysCommentEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.Week) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.Week, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.Week] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetWeekTimeRange(this clsSysCommentEN objSysCommentEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, conSysComment.WeekTimeRange);
}
objSysCommentEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.WeekTimeRange) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.WeekTimeRange, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.WeekTimeRange] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetUpdUser(this clsSysCommentEN objSysCommentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysComment.UpdUser);
}
objSysCommentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.UpdUser) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.UpdUser, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.UpdUser] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetUpdDate(this clsSysCommentEN objSysCommentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysComment.UpdDate);
}
objSysCommentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.UpdDate) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.UpdDate, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.UpdDate] = strComparisonOp;
}
}
return objSysCommentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentEN SetMemo(this clsSysCommentEN objSysCommentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysComment.Memo);
}
objSysCommentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentEN.dicFldComparisonOp.ContainsKey(conSysComment.Memo) == false)
{
objSysCommentEN.dicFldComparisonOp.Add(conSysComment.Memo, strComparisonOp);
}
else
{
objSysCommentEN.dicFldComparisonOp[conSysComment.Memo] = strComparisonOp;
}
}
return objSysCommentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysCommentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysCommentEN objSysCommentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysCommentEN.CheckPropertyNew();
clsSysCommentEN objSysCommentCond = new clsSysCommentEN();
string strCondition = objSysCommentCond
.SetCommentId(objSysCommentEN.CommentId, "<>")
.SetCommentId(objSysCommentEN.CommentId, "=")
.GetCombineCondition();
objSysCommentEN._IsCheckProperty = true;
bool bolIsExist = clsSysCommentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CommentId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysCommentEN.Update();
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
 /// <param name = "objSysComment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysCommentEN objSysComment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysCommentEN objSysCommentCond = new clsSysCommentEN();
string strCondition = objSysCommentCond
.SetCommentId(objSysComment.CommentId, "=")
.GetCombineCondition();
objSysComment._IsCheckProperty = true;
bool bolIsExist = clsSysCommentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysComment.CommentId = clsSysCommentBL.GetFirstID_S(strCondition);
objSysComment.UpdateWithCondition(strCondition);
}
else
{
objSysComment.CommentId = clsSysCommentBL.GetMaxStrId_S();
objSysComment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCommentEN objSysCommentEN)
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCommentBL.SysCommentDA.UpdateBySql2(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCommentEN objSysCommentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCommentBL.SysCommentDA.UpdateBySql2(objSysCommentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCommentEN objSysCommentEN, string strWhereCond)
{
try
{
bool bolResult = clsSysCommentBL.SysCommentDA.UpdateBySqlWithCondition(objSysCommentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCommentEN objSysCommentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysCommentBL.SysCommentDA.UpdateBySqlWithConditionTransaction(objSysCommentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysCommentEN objSysCommentEN)
{
try
{
int intRecNum = clsSysCommentBL.SysCommentDA.DelRecord(objSysCommentEN.CommentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentENS">源对象</param>
 /// <param name = "objSysCommentENT">目标对象</param>
 public static void CopyTo(this clsSysCommentEN objSysCommentENS, clsSysCommentEN objSysCommentENT)
{
try
{
objSysCommentENT.CommentId = objSysCommentENS.CommentId; //评论Id
objSysCommentENT.Comment = objSysCommentENS.Comment; //评论
objSysCommentENT.Score = objSysCommentENS.Score; //评分
objSysCommentENT.CommentTypeId = objSysCommentENS.CommentTypeId; //评论类型Id
objSysCommentENT.ScoreType = objSysCommentENS.ScoreType; //评分类型
objSysCommentENT.ParentId = objSysCommentENS.ParentId; //父Id
objSysCommentENT.TableKey = objSysCommentENS.TableKey; //表主键
objSysCommentENT.OkCount = objSysCommentENS.OkCount; //点赞统计
objSysCommentENT.PubParentId = objSysCommentENS.PubParentId; //公共父Id
objSysCommentENT.IdCurrEduCls = objSysCommentENS.IdCurrEduCls; //教学班流水号
objSysCommentENT.UserId = objSysCommentENS.UserId; //用户ID
objSysCommentENT.Month = objSysCommentENS.Month; //月
objSysCommentENT.Week = objSysCommentENS.Week; //周
objSysCommentENT.WeekTimeRange = objSysCommentENS.WeekTimeRange; //WeekTimeRange
objSysCommentENT.UpdUser = objSysCommentENS.UpdUser; //修改人
objSysCommentENT.UpdDate = objSysCommentENS.UpdDate; //修改日期
objSysCommentENT.Memo = objSysCommentENS.Memo; //备注
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
 /// <param name = "objSysCommentENS">源对象</param>
 /// <returns>目标对象=>clsSysCommentEN:objSysCommentENT</returns>
 public static clsSysCommentEN CopyTo(this clsSysCommentEN objSysCommentENS)
{
try
{
 clsSysCommentEN objSysCommentENT = new clsSysCommentEN()
{
CommentId = objSysCommentENS.CommentId, //评论Id
Comment = objSysCommentENS.Comment, //评论
Score = objSysCommentENS.Score, //评分
CommentTypeId = objSysCommentENS.CommentTypeId, //评论类型Id
ScoreType = objSysCommentENS.ScoreType, //评分类型
ParentId = objSysCommentENS.ParentId, //父Id
TableKey = objSysCommentENS.TableKey, //表主键
OkCount = objSysCommentENS.OkCount, //点赞统计
PubParentId = objSysCommentENS.PubParentId, //公共父Id
IdCurrEduCls = objSysCommentENS.IdCurrEduCls, //教学班流水号
UserId = objSysCommentENS.UserId, //用户ID
Month = objSysCommentENS.Month, //月
Week = objSysCommentENS.Week, //周
WeekTimeRange = objSysCommentENS.WeekTimeRange, //WeekTimeRange
UpdUser = objSysCommentENS.UpdUser, //修改人
UpdDate = objSysCommentENS.UpdDate, //修改日期
Memo = objSysCommentENS.Memo, //备注
};
 return objSysCommentENT;
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
public static void CheckPropertyNew(this clsSysCommentEN objSysCommentEN)
{
 clsSysCommentBL.SysCommentDA.CheckPropertyNew(objSysCommentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysCommentEN objSysCommentEN)
{
 clsSysCommentBL.SysCommentDA.CheckProperty4Condition(objSysCommentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysCommentEN objSysCommentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysCommentCond.IsUpdated(conSysComment.CommentId) == true)
{
string strComparisonOpCommentId = objSysCommentCond.dicFldComparisonOp[conSysComment.CommentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.CommentId, objSysCommentCond.CommentId, strComparisonOpCommentId);
}
if (objSysCommentCond.IsUpdated(conSysComment.Comment) == true)
{
string strComparisonOpComment = objSysCommentCond.dicFldComparisonOp[conSysComment.Comment];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.Comment, objSysCommentCond.Comment, strComparisonOpComment);
}
if (objSysCommentCond.IsUpdated(conSysComment.Score) == true)
{
string strComparisonOpScore = objSysCommentCond.dicFldComparisonOp[conSysComment.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conSysComment.Score, objSysCommentCond.Score, strComparisonOpScore);
}
if (objSysCommentCond.IsUpdated(conSysComment.CommentTypeId) == true)
{
string strComparisonOpCommentTypeId = objSysCommentCond.dicFldComparisonOp[conSysComment.CommentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.CommentTypeId, objSysCommentCond.CommentTypeId, strComparisonOpCommentTypeId);
}
if (objSysCommentCond.IsUpdated(conSysComment.ScoreType) == true)
{
string strComparisonOpScoreType = objSysCommentCond.dicFldComparisonOp[conSysComment.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.ScoreType, objSysCommentCond.ScoreType, strComparisonOpScoreType);
}
if (objSysCommentCond.IsUpdated(conSysComment.ParentId) == true)
{
string strComparisonOpParentId = objSysCommentCond.dicFldComparisonOp[conSysComment.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.ParentId, objSysCommentCond.ParentId, strComparisonOpParentId);
}
if (objSysCommentCond.IsUpdated(conSysComment.TableKey) == true)
{
string strComparisonOpTableKey = objSysCommentCond.dicFldComparisonOp[conSysComment.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.TableKey, objSysCommentCond.TableKey, strComparisonOpTableKey);
}
if (objSysCommentCond.IsUpdated(conSysComment.OkCount) == true)
{
string strComparisonOpOkCount = objSysCommentCond.dicFldComparisonOp[conSysComment.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysComment.OkCount, objSysCommentCond.OkCount, strComparisonOpOkCount);
}
if (objSysCommentCond.IsUpdated(conSysComment.PubParentId) == true)
{
string strComparisonOpPubParentId = objSysCommentCond.dicFldComparisonOp[conSysComment.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.PubParentId, objSysCommentCond.PubParentId, strComparisonOpPubParentId);
}
if (objSysCommentCond.IsUpdated(conSysComment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysCommentCond.dicFldComparisonOp[conSysComment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.IdCurrEduCls, objSysCommentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysCommentCond.IsUpdated(conSysComment.UserId) == true)
{
string strComparisonOpUserId = objSysCommentCond.dicFldComparisonOp[conSysComment.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.UserId, objSysCommentCond.UserId, strComparisonOpUserId);
}
if (objSysCommentCond.IsUpdated(conSysComment.Month) == true)
{
string strComparisonOpMonth = objSysCommentCond.dicFldComparisonOp[conSysComment.Month];
strWhereCond += string.Format(" And {0} {2} {1}", conSysComment.Month, objSysCommentCond.Month, strComparisonOpMonth);
}
if (objSysCommentCond.IsUpdated(conSysComment.Week) == true)
{
string strComparisonOpWeek = objSysCommentCond.dicFldComparisonOp[conSysComment.Week];
strWhereCond += string.Format(" And {0} {2} {1}", conSysComment.Week, objSysCommentCond.Week, strComparisonOpWeek);
}
if (objSysCommentCond.IsUpdated(conSysComment.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objSysCommentCond.dicFldComparisonOp[conSysComment.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.WeekTimeRange, objSysCommentCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objSysCommentCond.IsUpdated(conSysComment.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysCommentCond.dicFldComparisonOp[conSysComment.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.UpdUser, objSysCommentCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysCommentCond.IsUpdated(conSysComment.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysCommentCond.dicFldComparisonOp[conSysComment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.UpdDate, objSysCommentCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysCommentCond.IsUpdated(conSysComment.Memo) == true)
{
string strComparisonOpMemo = objSysCommentCond.dicFldComparisonOp[conSysComment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysComment.Memo, objSysCommentCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysComment(系统评论表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CommentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysCommentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysCommentEN objSysCommentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysCommentEN == null) return true;
if (objSysCommentEN.CommentId == null || objSysCommentEN.CommentId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CommentId = '{0}'", objSysCommentEN.CommentId);
if (clsSysCommentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CommentId !=  '{0}'", objSysCommentEN.CommentId);
 sbCondition.AppendFormat(" and CommentId = '{0}'", objSysCommentEN.CommentId);
if (clsSysCommentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysComment(系统评论表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CommentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysCommentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysCommentEN objSysCommentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysCommentEN == null) return "";
if (objSysCommentEN.CommentId == null || objSysCommentEN.CommentId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CommentId = '{0}'", objSysCommentEN.CommentId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CommentId !=  '{0}'", objSysCommentEN.CommentId);
 sbCondition.AppendFormat(" and CommentId = '{0}'", objSysCommentEN.CommentId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysComment
{
public virtual bool UpdRelaTabDate(string strCommentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 系统评论表(SysComment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysCommentBL
{
public static RelatedActions_SysComment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysCommentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysCommentDA SysCommentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysCommentDA();
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
 public clsSysCommentBL()
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
if (string.IsNullOrEmpty(clsSysCommentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysCommentEN._ConnectString);
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
public static DataTable GetDataTable_SysComment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysCommentDA.GetDataTable_SysComment(strWhereCond);
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
objDT = SysCommentDA.GetDataTable(strWhereCond);
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
objDT = SysCommentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysCommentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysCommentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysCommentDA.GetDataTable_Top(objTopPara);
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
objDT = SysCommentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysCommentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysCommentEN> GetObjLstByCommentIdLst(List<string> arrCommentIdLst)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCommentIdLst, true);
 string strWhereCond = string.Format("CommentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCommentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysCommentEN> GetObjLstByCommentIdLstCache(List<string> arrCommentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsSysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsSysCommentEN> arrSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysCommentEN> arrSysCommentObjLst_Sel =
arrSysCommentObjLstCache
.Where(x => arrCommentIdLst.Contains(x.CommentId));
return arrSysCommentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentEN> GetObjLst(string strWhereCond)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
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
public static List<clsSysCommentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysCommentEN> GetSubObjLstCache(clsSysCommentEN objSysCommentCond)
{
 string strIdCurrEduCls = objSysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSysCommentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysComment.AttributeName)
{
if (objSysCommentCond.IsUpdated(strFldName) == false) continue;
if (objSysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentCond[strFldName].ToString());
}
else
{
if (objSysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCommentCond[strFldName]));
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
public static List<clsSysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
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
public static List<clsSysCommentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
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
List<clsSysCommentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysCommentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
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
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
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
public static List<clsSysCommentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysCommentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
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
public static List<clsSysCommentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysCommentEN> arrObjLst = new List<clsSysCommentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentEN objSysCommentEN = new clsSysCommentEN();
try
{
objSysCommentEN.CommentId = objRow[conSysComment.CommentId].ToString().Trim(); //评论Id
objSysCommentEN.Comment = objRow[conSysComment.Comment] == DBNull.Value ? null : objRow[conSysComment.Comment].ToString().Trim(); //评论
objSysCommentEN.Score = objRow[conSysComment.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysComment.Score].ToString().Trim()); //评分
objSysCommentEN.CommentTypeId = objRow[conSysComment.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentEN.ScoreType = objRow[conSysComment.ScoreType] == DBNull.Value ? null : objRow[conSysComment.ScoreType].ToString().Trim(); //评分类型
objSysCommentEN.ParentId = objRow[conSysComment.ParentId].ToString().Trim(); //父Id
objSysCommentEN.TableKey = objRow[conSysComment.TableKey] == DBNull.Value ? null : objRow[conSysComment.TableKey].ToString().Trim(); //表主键
objSysCommentEN.OkCount = objRow[conSysComment.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.OkCount].ToString().Trim()); //点赞统计
objSysCommentEN.PubParentId = objRow[conSysComment.PubParentId] == DBNull.Value ? null : objRow[conSysComment.PubParentId].ToString().Trim(); //公共父Id
objSysCommentEN.IdCurrEduCls = objRow[conSysComment.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysComment.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysCommentEN.UserId = objRow[conSysComment.UserId] == DBNull.Value ? null : objRow[conSysComment.UserId].ToString().Trim(); //用户ID
objSysCommentEN.Month = objRow[conSysComment.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Month].ToString().Trim()); //月
objSysCommentEN.Week = objRow[conSysComment.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysComment.Week].ToString().Trim()); //周
objSysCommentEN.WeekTimeRange = objRow[conSysComment.WeekTimeRange] == DBNull.Value ? null : objRow[conSysComment.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objSysCommentEN.UpdUser = objRow[conSysComment.UpdUser] == DBNull.Value ? null : objRow[conSysComment.UpdUser].ToString().Trim(); //修改人
objSysCommentEN.UpdDate = objRow[conSysComment.UpdDate] == DBNull.Value ? null : objRow[conSysComment.UpdDate].ToString().Trim(); //修改日期
objSysCommentEN.Memo = objRow[conSysComment.Memo] == DBNull.Value ? null : objRow[conSysComment.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentEN.CommentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysCommentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysComment(ref clsSysCommentEN objSysCommentEN)
{
bool bolResult = SysCommentDA.GetSysComment(ref objSysCommentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCommentEN GetObjByCommentId(string strCommentId)
{
if (strCommentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCommentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCommentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysCommentEN objSysCommentEN = SysCommentDA.GetObjByCommentId(strCommentId);
return objSysCommentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysCommentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysCommentEN objSysCommentEN = SysCommentDA.GetFirstObj(strWhereCond);
 return objSysCommentEN;
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
public static clsSysCommentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysCommentEN objSysCommentEN = SysCommentDA.GetObjByDataRow(objRow);
 return objSysCommentEN;
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
public static clsSysCommentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysCommentEN objSysCommentEN = SysCommentDA.GetObjByDataRow(objRow);
 return objSysCommentEN;
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
 /// <param name = "strCommentId">所给的关键字</param>
 /// <param name = "lstSysCommentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCommentEN GetObjByCommentIdFromList(string strCommentId, List<clsSysCommentEN> lstSysCommentObjLst)
{
foreach (clsSysCommentEN objSysCommentEN in lstSysCommentObjLst)
{
if (objSysCommentEN.CommentId == strCommentId)
{
return objSysCommentEN;
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
 string strMaxCommentId;
 try
 {
 strMaxCommentId = clsSysCommentDA.GetMaxStrId();
 return strMaxCommentId;
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
 string strCommentId;
 try
 {
 strCommentId = new clsSysCommentDA().GetFirstID(strWhereCond);
 return strCommentId;
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
 arrList = SysCommentDA.GetID(strWhereCond);
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
bool bolIsExist = SysCommentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCommentId)
{
if (string.IsNullOrEmpty(strCommentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCommentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysCommentDA.IsExist(strCommentId);
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
 bolIsExist = clsSysCommentDA.IsExistTable();
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
 bolIsExist = SysCommentDA.IsExistTable(strTabName);
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysCommentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评论Id = [{0}]的数据已经存在!(in clsSysCommentBL.AddNewRecordBySql2)", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
bool bolResult = SysCommentDA.AddNewRecordBySQL2(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysCommentEN objSysCommentEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysCommentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评论Id = [{0}]的数据已经存在!(in clsSysCommentBL.AddNewRecordBySql2WithReturnKey)", objSysCommentEN.CommentId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true || clsSysCommentBL.IsExist(objSysCommentEN.CommentId) == true)
 {
     objSysCommentEN.CommentId = clsSysCommentBL.GetMaxStrId_S();
 }
string strKey = SysCommentDA.AddNewRecordBySQL2WithReturnKey(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysCommentEN objSysCommentEN)
{
try
{
bool bolResult = SysCommentDA.Update(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "objSysCommentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysCommentEN objSysCommentEN)
{
 if (string.IsNullOrEmpty(objSysCommentEN.CommentId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysCommentDA.UpdateBySql2(objSysCommentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentBL.ReFreshCache(objSysCommentEN.IdCurrEduCls);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
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
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCommentId)
{
try
{
 clsSysCommentEN objSysCommentEN = clsSysCommentBL.GetObjByCommentId(strCommentId);

if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(objSysCommentEN.CommentId, "SetUpdDate");
}
if (objSysCommentEN != null)
{
int intRecNum = SysCommentDA.DelRecord(strCommentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysCommentEN.IdCurrEduCls);
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
/// <param name="strCommentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCommentId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCommentDA.GetSpecSQLObj();
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
//删除与表:[SysComment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysComment.CommentId,
//strCommentId);
//        clsSysCommentBL.DelSysCommentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCommentBL.DelRecord(strCommentId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCommentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCommentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCommentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCommentId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysCommentBL.relatedActions != null)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(strCommentId, "UpdRelaTabDate");
}
bool bolResult = SysCommentDA.DelRecord(strCommentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCommentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysComments(List<string> arrCommentIdLst)
{
if (arrCommentIdLst.Count == 0) return 0;
try
{
if (clsSysCommentBL.relatedActions != null)
{
foreach (var strCommentId in arrCommentIdLst)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(strCommentId, "UpdRelaTabDate");
}
}
 clsSysCommentEN objSysCommentEN = clsSysCommentBL.GetObjByCommentId(arrCommentIdLst[0]);
int intDelRecNum = SysCommentDA.DelSysComment(arrCommentIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysCommentEN.IdCurrEduCls);
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
public static int DelSysCommentsByCond(string strWhereCond)
{
try
{
if (clsSysCommentBL.relatedActions != null)
{
List<string> arrCommentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCommentId in arrCommentId)
{
clsSysCommentBL.relatedActions.UpdRelaTabDate(strCommentId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conSysComment.IdCurrEduCls, strWhereCond);
int intRecNum = SysCommentDA.DelSysComment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysComment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCommentId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCommentId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCommentDA.GetSpecSQLObj();
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
//删除与表:[SysComment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCommentBL.DelRecord(strCommentId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCommentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCommentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysCommentENS">源对象</param>
 /// <param name = "objSysCommentENT">目标对象</param>
 public static void CopyTo(clsSysCommentEN objSysCommentENS, clsSysCommentEN objSysCommentENT)
{
try
{
objSysCommentENT.CommentId = objSysCommentENS.CommentId; //评论Id
objSysCommentENT.Comment = objSysCommentENS.Comment; //评论
objSysCommentENT.Score = objSysCommentENS.Score; //评分
objSysCommentENT.CommentTypeId = objSysCommentENS.CommentTypeId; //评论类型Id
objSysCommentENT.ScoreType = objSysCommentENS.ScoreType; //评分类型
objSysCommentENT.ParentId = objSysCommentENS.ParentId; //父Id
objSysCommentENT.TableKey = objSysCommentENS.TableKey; //表主键
objSysCommentENT.OkCount = objSysCommentENS.OkCount; //点赞统计
objSysCommentENT.PubParentId = objSysCommentENS.PubParentId; //公共父Id
objSysCommentENT.IdCurrEduCls = objSysCommentENS.IdCurrEduCls; //教学班流水号
objSysCommentENT.UserId = objSysCommentENS.UserId; //用户ID
objSysCommentENT.Month = objSysCommentENS.Month; //月
objSysCommentENT.Week = objSysCommentENS.Week; //周
objSysCommentENT.WeekTimeRange = objSysCommentENS.WeekTimeRange; //WeekTimeRange
objSysCommentENT.UpdUser = objSysCommentENS.UpdUser; //修改人
objSysCommentENT.UpdDate = objSysCommentENS.UpdDate; //修改日期
objSysCommentENT.Memo = objSysCommentENS.Memo; //备注
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
 /// <param name = "objSysCommentEN">源简化对象</param>
 public static void SetUpdFlag(clsSysCommentEN objSysCommentEN)
{
try
{
objSysCommentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysCommentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysComment.CommentId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.CommentId = objSysCommentEN.CommentId; //评论Id
}
if (arrFldSet.Contains(conSysComment.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.Comment = objSysCommentEN.Comment == "[null]" ? null :  objSysCommentEN.Comment; //评论
}
if (arrFldSet.Contains(conSysComment.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.Score = objSysCommentEN.Score; //评分
}
if (arrFldSet.Contains(conSysComment.CommentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.CommentTypeId = objSysCommentEN.CommentTypeId; //评论类型Id
}
if (arrFldSet.Contains(conSysComment.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.ScoreType = objSysCommentEN.ScoreType == "[null]" ? null :  objSysCommentEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(conSysComment.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.ParentId = objSysCommentEN.ParentId; //父Id
}
if (arrFldSet.Contains(conSysComment.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.TableKey = objSysCommentEN.TableKey == "[null]" ? null :  objSysCommentEN.TableKey; //表主键
}
if (arrFldSet.Contains(conSysComment.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.OkCount = objSysCommentEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conSysComment.PubParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.PubParentId = objSysCommentEN.PubParentId == "[null]" ? null :  objSysCommentEN.PubParentId; //公共父Id
}
if (arrFldSet.Contains(conSysComment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.IdCurrEduCls = objSysCommentEN.IdCurrEduCls == "[null]" ? null :  objSysCommentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysComment.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.UserId = objSysCommentEN.UserId == "[null]" ? null :  objSysCommentEN.UserId; //用户ID
}
if (arrFldSet.Contains(conSysComment.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.Month = objSysCommentEN.Month; //月
}
if (arrFldSet.Contains(conSysComment.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.Week = objSysCommentEN.Week; //周
}
if (arrFldSet.Contains(conSysComment.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.WeekTimeRange = objSysCommentEN.WeekTimeRange == "[null]" ? null :  objSysCommentEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(conSysComment.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.UpdUser = objSysCommentEN.UpdUser == "[null]" ? null :  objSysCommentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysComment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.UpdDate = objSysCommentEN.UpdDate == "[null]" ? null :  objSysCommentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysComment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentEN.Memo = objSysCommentEN.Memo == "[null]" ? null :  objSysCommentEN.Memo; //备注
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
 /// <param name = "objSysCommentEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysCommentEN objSysCommentEN)
{
try
{
if (objSysCommentEN.Comment == "[null]") objSysCommentEN.Comment = null; //评论
if (objSysCommentEN.ScoreType == "[null]") objSysCommentEN.ScoreType = null; //评分类型
if (objSysCommentEN.TableKey == "[null]") objSysCommentEN.TableKey = null; //表主键
if (objSysCommentEN.PubParentId == "[null]") objSysCommentEN.PubParentId = null; //公共父Id
if (objSysCommentEN.IdCurrEduCls == "[null]") objSysCommentEN.IdCurrEduCls = null; //教学班流水号
if (objSysCommentEN.UserId == "[null]") objSysCommentEN.UserId = null; //用户ID
if (objSysCommentEN.WeekTimeRange == "[null]") objSysCommentEN.WeekTimeRange = null; //WeekTimeRange
if (objSysCommentEN.UpdUser == "[null]") objSysCommentEN.UpdUser = null; //修改人
if (objSysCommentEN.UpdDate == "[null]") objSysCommentEN.UpdDate = null; //修改日期
if (objSysCommentEN.Memo == "[null]") objSysCommentEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysCommentEN objSysCommentEN)
{
 SysCommentDA.CheckPropertyNew(objSysCommentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysCommentEN objSysCommentEN)
{
 SysCommentDA.CheckProperty4Condition(objSysCommentEN);
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
if (clsSysCommentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCommentBL没有刷新缓存机制(clsSysCommentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CommentId");
//if (arrSysCommentObjLstCache == null)
//{
//arrSysCommentObjLstCache = SysCommentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCommentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCommentEN GetObjByCommentIdCache(string strCommentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysCommentEN._CurrTabName, strIdCurrEduCls);
List<clsSysCommentEN> arrSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysCommentEN> arrSysCommentObjLst_Sel =
arrSysCommentObjLstCache
.Where(x=> x.CommentId == strCommentId 
);
if (arrSysCommentObjLst_Sel.Count() == 0)
{
   clsSysCommentEN obj = clsSysCommentBL.GetObjByCommentId(strCommentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCommentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSysCommentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCommentEN> GetAllSysCommentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsSysCommentEN> arrSysCommentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrSysCommentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCommentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysCommentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsSysCommentEN> arrSysCommentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSysCommentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSysCommentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysCommentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysCommentEN._RefreshTimeLst.Count == 0) return "";
return clsSysCommentEN._RefreshTimeLst[clsSysCommentEN._RefreshTimeLst.Count - 1];
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
if (clsSysCommentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSysCommentEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysCommentEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysCommentBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysComment(系统评论表)
 /// 唯一性条件:CommentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysCommentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysCommentEN objSysCommentEN)
{
//检测记录是否存在
string strResult = SysCommentDA.GetUniCondStr(objSysCommentEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strCommentId, string strIdCurrEduCls)
{
if (strInFldName != conSysComment.CommentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysComment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysComment.AttributeName));
throw new Exception(strMsg);
}
var objSysComment = clsSysCommentBL.GetObjByCommentIdCache(strCommentId, strIdCurrEduCls);
if (objSysComment == null) return "";
return objSysComment[strOutFldName].ToString();
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
int intRecCount = clsSysCommentDA.GetRecCount(strTabName);
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
int intRecCount = clsSysCommentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysCommentDA.GetRecCount();
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
int intRecCount = clsSysCommentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysCommentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysCommentEN objSysCommentCond)
{
 string strIdCurrEduCls = objSysCommentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSysCommentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSysCommentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysCommentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysComment.AttributeName)
{
if (objSysCommentCond.IsUpdated(strFldName) == false) continue;
if (objSysCommentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentCond[strFldName].ToString());
}
else
{
if (objSysCommentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCommentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCommentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCommentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCommentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCommentCond[strFldName]));
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
 List<string> arrList = clsSysCommentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysCommentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysCommentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysCommentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCommentDA.SetFldValue(clsSysCommentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysCommentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCommentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCommentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCommentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysComment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评论Id*/ 
 strCreateTabCode.Append(" CommentId char(10) primary key, "); 
 // /**评论*/ 
 strCreateTabCode.Append(" Comment varchar(2000) Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**评论类型Id*/ 
 strCreateTabCode.Append(" CommentTypeId char(2) not Null, "); 
 // /**评分类型*/ 
 strCreateTabCode.Append(" ScoreType char(1) Null, "); 
 // /**父Id*/ 
 strCreateTabCode.Append(" ParentId varchar(20) not Null, "); 
 // /**表主键*/ 
 strCreateTabCode.Append(" TableKey varchar(20) Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**公共父Id*/ 
 strCreateTabCode.Append(" PubParentId varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month int Null, "); 
 // /**周*/ 
 strCreateTabCode.Append(" Week int Null, "); 
 // /**WeekTimeRange*/ 
 strCreateTabCode.Append(" WeekTimeRange varchar(100) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 系统评论表(SysComment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysComment : clsCommFun4BLV2
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
clsSysCommentBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}