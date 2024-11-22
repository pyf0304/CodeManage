﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KnowledgesUserMasterBL
 表名:ge_KnowledgesUserMaster(01120892)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsge_KnowledgesUserMasterBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_KnowledgesUserMasterEN GetObj(this K_mId_ge_KnowledgesUserMaster myKey)
{
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.GetObjBymId(myKey.Value);
return objge_KnowledgesUserMasterEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_KnowledgesUserMasterEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsge_KnowledgesUserMasterBL.AddNewRecord)", objge_KnowledgesUserMasterEN.CourseKnowledgeId,objge_KnowledgesUserMasterEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.AddNewRecordBySQL2(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
public static bool AddRecordEx(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, bool bolIsNeedCheckUniqueness = true)
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
objge_KnowledgesUserMasterEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_KnowledgesUserMasterEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识点Id(CourseKnowledgeId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objge_KnowledgesUserMasterEN.CourseKnowledgeId, objge_KnowledgesUserMasterEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_KnowledgesUserMasterEN.AddNewRecord();
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_KnowledgesUserMasterEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsge_KnowledgesUserMasterBL.AddNewRecordWithReturnKey)", objge_KnowledgesUserMasterEN.CourseKnowledgeId,objge_KnowledgesUserMasterEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.AddNewRecordBySQL2WithReturnKey(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetmId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, long lngmId, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.mId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.mId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.mId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetCourseId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_KnowledgesUserMaster.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_KnowledgesUserMaster.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_KnowledgesUserMaster.CourseId);
}
objge_KnowledgesUserMasterEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.CourseId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.CourseId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.CourseId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetUserId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conge_KnowledgesUserMaster.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conge_KnowledgesUserMaster.UserId);
}
objge_KnowledgesUserMasterEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.UserId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.UserId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.UserId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetCourseKnowledgeId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeId, conge_KnowledgesUserMaster.CourseKnowledgeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conge_KnowledgesUserMaster.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conge_KnowledgesUserMaster.CourseKnowledgeId);
}
objge_KnowledgesUserMasterEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.CourseKnowledgeId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.CourseKnowledgeId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.CourseKnowledgeId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetRightCount(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, int? intRightCount, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.RightCount = intRightCount; //正确次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.RightCount) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.RightCount, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.RightCount] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetMasterTypeId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strMasterTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMasterTypeId, 1, conge_KnowledgesUserMaster.MasterTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMasterTypeId, 1, conge_KnowledgesUserMaster.MasterTypeId);
}
objge_KnowledgesUserMasterEN.MasterTypeId = strMasterTypeId; //掌握类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.MasterTypeId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.MasterTypeId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.MasterTypeId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetErrorCount(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, int? intErrorCount, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.ErrorCount = intErrorCount; //错误次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.ErrorCount) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.ErrorCount, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.ErrorCount] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetMasterLevelId(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strMasterLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMasterLevelId, 4, conge_KnowledgesUserMaster.MasterLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMasterLevelId, 4, conge_KnowledgesUserMaster.MasterLevelId);
}
objge_KnowledgesUserMasterEN.MasterLevelId = strMasterLevelId; //掌握度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.MasterLevelId) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.MasterLevelId, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.MasterLevelId] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetMasteryValue(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, double? dblMasteryValue, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.MasteryValue = dblMasteryValue; //掌握度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.MasteryValue) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.MasteryValue, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.MasteryValue] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetUpdDate(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_KnowledgesUserMaster.UpdDate);
}
objge_KnowledgesUserMasterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.UpdDate) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.UpdDate, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.UpdDate] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetGoalValue(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, double? dblGoalValue, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.GoalValue = dblGoalValue; //目标值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.GoalValue) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.GoalValue, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.GoalValue] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetSelfPerceivedValue(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, double? dblSelfPerceivedValue, string strComparisonOp="")
	{
objge_KnowledgesUserMasterEN.SelfPerceivedValue = dblSelfPerceivedValue; //自我认为值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.SelfPerceivedValue) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.SelfPerceivedValue, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.SelfPerceivedValue] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetUpdUser(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_KnowledgesUserMaster.UpdUser);
}
objge_KnowledgesUserMasterEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.UpdUser) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.UpdUser, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.UpdUser] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesUserMasterEN SetMemo(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_KnowledgesUserMaster.Memo);
}
objge_KnowledgesUserMasterEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesUserMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesUserMaster.Memo) == false)
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp.Add(conge_KnowledgesUserMaster.Memo, strComparisonOp);
}
else
{
objge_KnowledgesUserMasterEN.dicFldComparisonOp[conge_KnowledgesUserMaster.Memo] = strComparisonOp;
}
}
return objge_KnowledgesUserMasterEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_KnowledgesUserMasterEN.CheckPropertyNew();
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterCond = new clsge_KnowledgesUserMasterEN();
string strCondition = objge_KnowledgesUserMasterCond
.SetmId(objge_KnowledgesUserMasterEN.mId, "<>")
.SetCourseKnowledgeId(objge_KnowledgesUserMasterEN.CourseKnowledgeId, "=")
.SetUserId(objge_KnowledgesUserMasterEN.UserId, "=")
.GetCombineCondition();
objge_KnowledgesUserMasterEN._IsCheckProperty = true;
bool bolIsExist = clsge_KnowledgesUserMasterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseKnowledgeId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_KnowledgesUserMasterEN.Update();
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
 /// <param name = "objge_KnowledgesUserMaster">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMaster)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterCond = new clsge_KnowledgesUserMasterEN();
string strCondition = objge_KnowledgesUserMasterCond
.SetCourseKnowledgeId(objge_KnowledgesUserMaster.CourseKnowledgeId, "=")
.SetUserId(objge_KnowledgesUserMaster.UserId, "=")
.GetCombineCondition();
objge_KnowledgesUserMaster._IsCheckProperty = true;
bool bolIsExist = clsge_KnowledgesUserMasterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_KnowledgesUserMaster.mId = clsge_KnowledgesUserMasterBL.GetFirstID_S(strCondition);
objge_KnowledgesUserMaster.UpdateWithCondition(strCondition);
}
else
{
objge_KnowledgesUserMaster.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 if (objge_KnowledgesUserMasterEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.UpdateBySql2(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_KnowledgesUserMasterEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.UpdateBySql2(objge_KnowledgesUserMasterEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strWhereCond)
{
try
{
bool bolResult = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.UpdateBySqlWithCondition(objge_KnowledgesUserMasterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.UpdateBySqlWithConditionTransaction(objge_KnowledgesUserMasterEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
try
{
int intRecNum = clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.DelRecord(objge_KnowledgesUserMasterEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
 /// <param name = "objge_KnowledgesUserMasterENT">目标对象</param>
 public static void CopyTo(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS, clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENT)
{
try
{
objge_KnowledgesUserMasterENT.mId = objge_KnowledgesUserMasterENS.mId; //mId
objge_KnowledgesUserMasterENT.CourseId = objge_KnowledgesUserMasterENS.CourseId; //课程Id
objge_KnowledgesUserMasterENT.UserId = objge_KnowledgesUserMasterENS.UserId; //用户ID
objge_KnowledgesUserMasterENT.CourseKnowledgeId = objge_KnowledgesUserMasterENS.CourseKnowledgeId; //知识点Id
objge_KnowledgesUserMasterENT.RightCount = objge_KnowledgesUserMasterENS.RightCount; //正确次数
objge_KnowledgesUserMasterENT.MasterTypeId = objge_KnowledgesUserMasterENS.MasterTypeId; //掌握类型Id
objge_KnowledgesUserMasterENT.ErrorCount = objge_KnowledgesUserMasterENS.ErrorCount; //错误次数
objge_KnowledgesUserMasterENT.MasterLevelId = objge_KnowledgesUserMasterENS.MasterLevelId; //掌握度Id
objge_KnowledgesUserMasterENT.MasteryValue = objge_KnowledgesUserMasterENS.MasteryValue; //掌握度
objge_KnowledgesUserMasterENT.UpdDate = objge_KnowledgesUserMasterENS.UpdDate; //修改日期
objge_KnowledgesUserMasterENT.GoalValue = objge_KnowledgesUserMasterENS.GoalValue; //目标值
objge_KnowledgesUserMasterENT.SelfPerceivedValue = objge_KnowledgesUserMasterENS.SelfPerceivedValue; //自我认为值
objge_KnowledgesUserMasterENT.UpdUser = objge_KnowledgesUserMasterENS.UpdUser; //修改人
objge_KnowledgesUserMasterENT.Memo = objge_KnowledgesUserMasterENS.Memo; //备注
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
 /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
 /// <returns>目标对象=>clsge_KnowledgesUserMasterEN:objge_KnowledgesUserMasterENT</returns>
 public static clsge_KnowledgesUserMasterEN CopyTo(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS)
{
try
{
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENT = new clsge_KnowledgesUserMasterEN()
{
mId = objge_KnowledgesUserMasterENS.mId, //mId
CourseId = objge_KnowledgesUserMasterENS.CourseId, //课程Id
UserId = objge_KnowledgesUserMasterENS.UserId, //用户ID
CourseKnowledgeId = objge_KnowledgesUserMasterENS.CourseKnowledgeId, //知识点Id
RightCount = objge_KnowledgesUserMasterENS.RightCount, //正确次数
MasterTypeId = objge_KnowledgesUserMasterENS.MasterTypeId, //掌握类型Id
ErrorCount = objge_KnowledgesUserMasterENS.ErrorCount, //错误次数
MasterLevelId = objge_KnowledgesUserMasterENS.MasterLevelId, //掌握度Id
MasteryValue = objge_KnowledgesUserMasterENS.MasteryValue, //掌握度
UpdDate = objge_KnowledgesUserMasterENS.UpdDate, //修改日期
GoalValue = objge_KnowledgesUserMasterENS.GoalValue, //目标值
SelfPerceivedValue = objge_KnowledgesUserMasterENS.SelfPerceivedValue, //自我认为值
UpdUser = objge_KnowledgesUserMasterENS.UpdUser, //修改人
Memo = objge_KnowledgesUserMasterENS.Memo, //备注
};
 return objge_KnowledgesUserMasterENT;
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
public static void CheckPropertyNew(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 clsge_KnowledgesUserMasterBL.ge_KnowledgesUserMasterDA.CheckProperty4Condition(objge_KnowledgesUserMasterEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.mId) == true)
{
string strComparisonOpmId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_KnowledgesUserMaster.mId, objge_KnowledgesUserMasterCond.mId, strComparisonOpmId);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.CourseId) == true)
{
string strComparisonOpCourseId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.CourseId, objge_KnowledgesUserMasterCond.CourseId, strComparisonOpCourseId);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.UserId) == true)
{
string strComparisonOpUserId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.UserId, objge_KnowledgesUserMasterCond.UserId, strComparisonOpUserId);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.CourseKnowledgeId, objge_KnowledgesUserMasterCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.RightCount) == true)
{
string strComparisonOpRightCount = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.RightCount];
strWhereCond += string.Format(" And {0} {2} {1}", conge_KnowledgesUserMaster.RightCount, objge_KnowledgesUserMasterCond.RightCount, strComparisonOpRightCount);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId) == true)
{
string strComparisonOpMasterTypeId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.MasterTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.MasterTypeId, objge_KnowledgesUserMasterCond.MasterTypeId, strComparisonOpMasterTypeId);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.ErrorCount) == true)
{
string strComparisonOpErrorCount = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.ErrorCount];
strWhereCond += string.Format(" And {0} {2} {1}", conge_KnowledgesUserMaster.ErrorCount, objge_KnowledgesUserMasterCond.ErrorCount, strComparisonOpErrorCount);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId) == true)
{
string strComparisonOpMasterLevelId = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.MasterLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.MasterLevelId, objge_KnowledgesUserMasterCond.MasterLevelId, strComparisonOpMasterLevelId);
}
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.UpdDate, objge_KnowledgesUserMasterCond.UpdDate, strComparisonOpUpdDate);
}
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.UpdUser, objge_KnowledgesUserMasterCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_KnowledgesUserMasterCond.IsUpdated(conge_KnowledgesUserMaster.Memo) == true)
{
string strComparisonOpMemo = objge_KnowledgesUserMasterCond.dicFldComparisonOp[conge_KnowledgesUserMaster.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesUserMaster.Memo, objge_KnowledgesUserMasterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_KnowledgesUserMaster(知识点用户掌握), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseKnowledgeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_KnowledgesUserMasterEN == null) return true;
if (objge_KnowledgesUserMasterEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objge_KnowledgesUserMasterEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_KnowledgesUserMasterEN.UserId);
if (clsge_KnowledgesUserMasterBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_KnowledgesUserMasterEN.mId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objge_KnowledgesUserMasterEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_KnowledgesUserMasterEN.UserId);
if (clsge_KnowledgesUserMasterBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_KnowledgesUserMaster(知识点用户掌握), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseKnowledgeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_KnowledgesUserMasterEN == null) return "";
if (objge_KnowledgesUserMasterEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objge_KnowledgesUserMasterEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_KnowledgesUserMasterEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_KnowledgesUserMasterEN.mId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objge_KnowledgesUserMasterEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_KnowledgesUserMasterEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_KnowledgesUserMaster
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点用户掌握(ge_KnowledgesUserMaster)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_KnowledgesUserMasterBL
{
public static RelatedActions_ge_KnowledgesUserMaster relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_KnowledgesUserMasterDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_KnowledgesUserMasterDA ge_KnowledgesUserMasterDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_KnowledgesUserMasterDA();
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
 public clsge_KnowledgesUserMasterBL()
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
if (string.IsNullOrEmpty(clsge_KnowledgesUserMasterEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_KnowledgesUserMasterEN._ConnectString);
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
public static DataTable GetDataTable_ge_KnowledgesUserMaster(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_KnowledgesUserMasterDA.GetDataTable_ge_KnowledgesUserMaster(strWhereCond);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable(strWhereCond);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable_Top(objTopPara);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_KnowledgesUserMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
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
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_KnowledgesUserMasterEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_KnowledgesUserMasterEN._CurrTabName, strCourseId);
List<clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLst_Sel =
arrge_KnowledgesUserMasterObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrge_KnowledgesUserMasterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetObjLst(string strWhereCond)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_KnowledgesUserMasterEN> GetSubObjLstCache(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterCond)
{
 string strCourseId = objge_KnowledgesUserMasterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_KnowledgesUserMasterBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_KnowledgesUserMasterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_KnowledgesUserMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_KnowledgesUserMaster.AttributeName)
{
if (objge_KnowledgesUserMasterCond.IsUpdated(strFldName) == false) continue;
if (objge_KnowledgesUserMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesUserMasterCond[strFldName].ToString());
}
else
{
if (objge_KnowledgesUserMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_KnowledgesUserMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesUserMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_KnowledgesUserMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesUserMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesUserMasterCond[strFldName]));
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
List<clsge_KnowledgesUserMasterEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_KnowledgesUserMasterEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_KnowledgesUserMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
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
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
public static List<clsge_KnowledgesUserMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
public static List<clsge_KnowledgesUserMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesUserMasterEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_KnowledgesUserMaster(ref clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
bool bolResult = ge_KnowledgesUserMasterDA.Getge_KnowledgesUserMaster(ref objge_KnowledgesUserMasterEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_KnowledgesUserMasterEN GetObjBymId(long lngmId)
{
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = ge_KnowledgesUserMasterDA.GetObjBymId(lngmId);
return objge_KnowledgesUserMasterEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_KnowledgesUserMasterEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = ge_KnowledgesUserMasterDA.GetFirstObj(strWhereCond);
 return objge_KnowledgesUserMasterEN;
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
public static clsge_KnowledgesUserMasterEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = ge_KnowledgesUserMasterDA.GetObjByDataRow(objRow);
 return objge_KnowledgesUserMasterEN;
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
public static clsge_KnowledgesUserMasterEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = ge_KnowledgesUserMasterDA.GetObjByDataRow(objRow);
 return objge_KnowledgesUserMasterEN;
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
 /// <param name = "lstge_KnowledgesUserMasterObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_KnowledgesUserMasterEN GetObjBymIdFromList(long lngmId, List<clsge_KnowledgesUserMasterEN> lstge_KnowledgesUserMasterObjLst)
{
foreach (clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN in lstge_KnowledgesUserMasterObjLst)
{
if (objge_KnowledgesUserMasterEN.mId == lngmId)
{
return objge_KnowledgesUserMasterEN;
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
 lngmId = new clsge_KnowledgesUserMasterDA().GetFirstID(strWhereCond);
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
 arrList = ge_KnowledgesUserMasterDA.GetID(strWhereCond);
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
bool bolIsExist = ge_KnowledgesUserMasterDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ge_KnowledgesUserMasterDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = clsge_KnowledgesUserMasterBL.GetObjBymId(lngmId);
objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_KnowledgesUserMasterEN.UpdUser = strOpUser;
return clsge_KnowledgesUserMasterBL.UpdateBySql2(objge_KnowledgesUserMasterEN);
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
 bolIsExist = clsge_KnowledgesUserMasterDA.IsExistTable();
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
 bolIsExist = ge_KnowledgesUserMasterDA.IsExistTable(strTabName);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_KnowledgesUserMasterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsge_KnowledgesUserMasterBL.AddNewRecordBySql2)", objge_KnowledgesUserMasterEN.CourseKnowledgeId,objge_KnowledgesUserMasterEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_KnowledgesUserMasterDA.AddNewRecordBySQL2(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_KnowledgesUserMasterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsge_KnowledgesUserMasterBL.AddNewRecordBySql2WithReturnKey)", objge_KnowledgesUserMasterEN.CourseKnowledgeId,objge_KnowledgesUserMasterEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_KnowledgesUserMasterDA.AddNewRecordBySQL2WithReturnKey(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
try
{
bool bolResult = ge_KnowledgesUserMasterDA.Update(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 if (objge_KnowledgesUserMasterEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_KnowledgesUserMasterDA.UpdateBySql2(objge_KnowledgesUserMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesUserMasterBL.ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = clsge_KnowledgesUserMasterBL.GetObjBymId(lngmId);

if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesUserMasterEN.mId, objge_KnowledgesUserMasterEN.UpdUser);
}
if (objge_KnowledgesUserMasterEN != null)
{
int intRecNum = ge_KnowledgesUserMasterDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
//删除与表:[ge_KnowledgesUserMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_KnowledgesUserMaster.mId,
//lngmId);
//        clsge_KnowledgesUserMasterBL.Delge_KnowledgesUserMastersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_KnowledgesUserMasterBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_KnowledgesUserMasterBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ge_KnowledgesUserMasterDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_KnowledgesUserMasters(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = clsge_KnowledgesUserMasterBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ge_KnowledgesUserMasterDA.Delge_KnowledgesUserMaster(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_KnowledgesUserMasterEN.CourseId);
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
public static int Delge_KnowledgesUserMastersByCond(string strWhereCond)
{
try
{
if (clsge_KnowledgesUserMasterBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsge_KnowledgesUserMasterBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_KnowledgesUserMaster.CourseId, strWhereCond);
int intRecNum = ge_KnowledgesUserMasterDA.Delge_KnowledgesUserMaster(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_KnowledgesUserMaster]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
//删除与表:[ge_KnowledgesUserMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_KnowledgesUserMasterBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_KnowledgesUserMasterBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
 /// <param name = "objge_KnowledgesUserMasterENT">目标对象</param>
 public static void CopyTo(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS, clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENT)
{
try
{
objge_KnowledgesUserMasterENT.mId = objge_KnowledgesUserMasterENS.mId; //mId
objge_KnowledgesUserMasterENT.CourseId = objge_KnowledgesUserMasterENS.CourseId; //课程Id
objge_KnowledgesUserMasterENT.UserId = objge_KnowledgesUserMasterENS.UserId; //用户ID
objge_KnowledgesUserMasterENT.CourseKnowledgeId = objge_KnowledgesUserMasterENS.CourseKnowledgeId; //知识点Id
objge_KnowledgesUserMasterENT.RightCount = objge_KnowledgesUserMasterENS.RightCount; //正确次数
objge_KnowledgesUserMasterENT.MasterTypeId = objge_KnowledgesUserMasterENS.MasterTypeId; //掌握类型Id
objge_KnowledgesUserMasterENT.ErrorCount = objge_KnowledgesUserMasterENS.ErrorCount; //错误次数
objge_KnowledgesUserMasterENT.MasterLevelId = objge_KnowledgesUserMasterENS.MasterLevelId; //掌握度Id
objge_KnowledgesUserMasterENT.MasteryValue = objge_KnowledgesUserMasterENS.MasteryValue; //掌握度
objge_KnowledgesUserMasterENT.UpdDate = objge_KnowledgesUserMasterENS.UpdDate; //修改日期
objge_KnowledgesUserMasterENT.GoalValue = objge_KnowledgesUserMasterENS.GoalValue; //目标值
objge_KnowledgesUserMasterENT.SelfPerceivedValue = objge_KnowledgesUserMasterENS.SelfPerceivedValue; //自我认为值
objge_KnowledgesUserMasterENT.UpdUser = objge_KnowledgesUserMasterENS.UpdUser; //修改人
objge_KnowledgesUserMasterENT.Memo = objge_KnowledgesUserMasterENS.Memo; //备注
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
 /// <param name = "objge_KnowledgesUserMasterEN">源简化对象</param>
 public static void SetUpdFlag(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
try
{
objge_KnowledgesUserMasterEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_KnowledgesUserMasterEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_KnowledgesUserMaster.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.mId = objge_KnowledgesUserMasterEN.mId; //mId
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.CourseId = objge_KnowledgesUserMasterEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.UserId = objge_KnowledgesUserMasterEN.UserId; //用户ID
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.RightCount, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.RightCount = objge_KnowledgesUserMasterEN.RightCount; //正确次数
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.MasterTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.MasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId == "[null]" ? null :  objge_KnowledgesUserMasterEN.MasterTypeId; //掌握类型Id
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.ErrorCount, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.ErrorCount = objge_KnowledgesUserMasterEN.ErrorCount; //错误次数
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.MasterLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.MasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId == "[null]" ? null :  objge_KnowledgesUserMasterEN.MasterLevelId; //掌握度Id
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.MasteryValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.MasteryValue = objge_KnowledgesUserMasterEN.MasteryValue; //掌握度
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.UpdDate = objge_KnowledgesUserMasterEN.UpdDate == "[null]" ? null :  objge_KnowledgesUserMasterEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.GoalValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.GoalValue = objge_KnowledgesUserMasterEN.GoalValue; //目标值
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.SelfPerceivedValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objge_KnowledgesUserMasterEN.SelfPerceivedValue; //自我认为值
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.UpdUser = objge_KnowledgesUserMasterEN.UpdUser == "[null]" ? null :  objge_KnowledgesUserMasterEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_KnowledgesUserMaster.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesUserMasterEN.Memo = objge_KnowledgesUserMasterEN.Memo == "[null]" ? null :  objge_KnowledgesUserMasterEN.Memo; //备注
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
 /// <param name = "objge_KnowledgesUserMasterEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
try
{
if (objge_KnowledgesUserMasterEN.MasterTypeId == "[null]") objge_KnowledgesUserMasterEN.MasterTypeId = null; //掌握类型Id
if (objge_KnowledgesUserMasterEN.MasterLevelId == "[null]") objge_KnowledgesUserMasterEN.MasterLevelId = null; //掌握度Id
if (objge_KnowledgesUserMasterEN.UpdDate == "[null]") objge_KnowledgesUserMasterEN.UpdDate = null; //修改日期
if (objge_KnowledgesUserMasterEN.UpdUser == "[null]") objge_KnowledgesUserMasterEN.UpdUser = null; //修改人
if (objge_KnowledgesUserMasterEN.Memo == "[null]") objge_KnowledgesUserMasterEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 ge_KnowledgesUserMasterDA.CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 ge_KnowledgesUserMasterDA.CheckProperty4Condition(objge_KnowledgesUserMasterEN);
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
if (clsge_KnowledgesUserMasterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_KnowledgesUserMasterBL没有刷新缓存机制(clsge_KnowledgesUserMasterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrge_KnowledgesUserMasterObjLstCache == null)
//{
//arrge_KnowledgesUserMasterObjLstCache = ge_KnowledgesUserMasterDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_KnowledgesUserMasterEN GetObjBymIdCache(long lngmId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_KnowledgesUserMasterEN._CurrTabName, strCourseId);
List<clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLst_Sel =
arrge_KnowledgesUserMasterObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrge_KnowledgesUserMasterObjLst_Sel.Count() == 0)
{
   clsge_KnowledgesUserMasterEN obj = clsge_KnowledgesUserMasterBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_KnowledgesUserMasterObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetAllge_KnowledgesUserMasterObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLstCache = GetObjLstCache(strCourseId); 
return arrge_KnowledgesUserMasterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_KnowledgesUserMasterEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsge_KnowledgesUserMasterEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_KnowledgesUserMasterEN> arrge_KnowledgesUserMasterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_KnowledgesUserMasterObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsge_KnowledgesUserMasterEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_KnowledgesUserMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_KnowledgesUserMasterEN._RefreshTimeLst.Count == 0) return "";
return clsge_KnowledgesUserMasterEN._RefreshTimeLst[clsge_KnowledgesUserMasterEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_KnowledgesUserMasterBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_KnowledgesUserMasterEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_KnowledgesUserMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_KnowledgesUserMasterBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_KnowledgesUserMaster(知识点用户掌握)
 /// 唯一性条件:CourseKnowledgeId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检测记录是否存在
string strResult = ge_KnowledgesUserMasterDA.GetUniCondStr(objge_KnowledgesUserMasterEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != conge_KnowledgesUserMaster.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_KnowledgesUserMaster.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_KnowledgesUserMaster.AttributeName));
throw new Exception(strMsg);
}
var objge_KnowledgesUserMaster = clsge_KnowledgesUserMasterBL.GetObjBymIdCache(lngmId, strCourseId);
if (objge_KnowledgesUserMaster == null) return "";
return objge_KnowledgesUserMaster[strOutFldName].ToString();
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
int intRecCount = clsge_KnowledgesUserMasterDA.GetRecCount(strTabName);
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
int intRecCount = clsge_KnowledgesUserMasterDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_KnowledgesUserMasterDA.GetRecCount();
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
int intRecCount = clsge_KnowledgesUserMasterDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterCond)
{
 string strCourseId = objge_KnowledgesUserMasterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_KnowledgesUserMasterBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_KnowledgesUserMasterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_KnowledgesUserMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_KnowledgesUserMaster.AttributeName)
{
if (objge_KnowledgesUserMasterCond.IsUpdated(strFldName) == false) continue;
if (objge_KnowledgesUserMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesUserMasterCond[strFldName].ToString());
}
else
{
if (objge_KnowledgesUserMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_KnowledgesUserMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesUserMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_KnowledgesUserMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_KnowledgesUserMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesUserMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesUserMasterCond[strFldName]));
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
 List<string> arrList = clsge_KnowledgesUserMasterDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_KnowledgesUserMasterDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_KnowledgesUserMasterDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_KnowledgesUserMasterDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesUserMasterDA.SetFldValue(clsge_KnowledgesUserMasterEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_KnowledgesUserMasterDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesUserMasterDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesUserMasterDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesUserMasterDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_KnowledgesUserMaster] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**知识点Id*/ 
 strCreateTabCode.Append(" CourseKnowledgeId char(8) not Null, "); 
 // /**正确次数*/ 
 strCreateTabCode.Append(" RightCount int Null, "); 
 // /**掌握类型Id*/ 
 strCreateTabCode.Append(" MasterTypeId char(1) Null, "); 
 // /**错误次数*/ 
 strCreateTabCode.Append(" ErrorCount int Null, "); 
 // /**掌握度Id*/ 
 strCreateTabCode.Append(" MasterLevelId char(4) Null, "); 
 // /**掌握度*/ 
 strCreateTabCode.Append(" MasteryValue numeric(20,2) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**目标值*/ 
 strCreateTabCode.Append(" GoalValue numeric(20,2) Null, "); 
 // /**自我认为值*/ 
 strCreateTabCode.Append(" SelfPerceivedValue numeric(20,2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**掌握类型名*/ 
 strCreateTabCode.Append(" MasterTypeName varchar(50) Null, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeName varchar(100) Null, "); 
 // /**掌握等级*/ 
 strCreateTabCode.Append(" MasterLevelName varchar(50) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点用户掌握(ge_KnowledgesUserMaster)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_KnowledgesUserMaster : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsge_KnowledgesUserMasterBL.ReFreshThisCache(strCourseId);
}
}

}