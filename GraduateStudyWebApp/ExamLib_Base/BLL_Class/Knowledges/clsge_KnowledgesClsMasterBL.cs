﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KnowledgesClsMasterBL
 表名:ge_KnowledgesClsMaster(01120962)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:13
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
public static class  clsge_KnowledgesClsMasterBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_KnowledgesClsMasterBL.IsExist(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_KnowledgesClsMasterEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.AddNewRecordBySQL2(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
public static bool AddRecordEx(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsge_KnowledgesClsMasterBL.IsExist(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objge_KnowledgesClsMasterEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objge_KnowledgesClsMasterEN.AddNewRecord();
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_KnowledgesClsMasterBL.IsExist(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_KnowledgesClsMasterEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.AddNewRecordBySQL2WithReturnKey(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetIdCurrEduCls(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conge_KnowledgesClsMaster.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conge_KnowledgesClsMaster.IdCurrEduCls);
}
objge_KnowledgesClsMasterEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.IdCurrEduCls) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.IdCurrEduCls, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.IdCurrEduCls] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetCourseKnowledgeId(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conge_KnowledgesClsMaster.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conge_KnowledgesClsMaster.CourseKnowledgeId);
}
objge_KnowledgesClsMasterEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.CourseKnowledgeId) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.CourseKnowledgeId, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.CourseKnowledgeId] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetCourseId(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_KnowledgesClsMaster.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_KnowledgesClsMaster.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_KnowledgesClsMaster.CourseId);
}
objge_KnowledgesClsMasterEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.CourseId) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.CourseId, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.CourseId] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetMasterLevelId(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strMasterLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMasterLevelId, 4, conge_KnowledgesClsMaster.MasterLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMasterLevelId, 4, conge_KnowledgesClsMaster.MasterLevelId);
}
objge_KnowledgesClsMasterEN.MasterLevelId = strMasterLevelId; //掌握度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.MasterLevelId) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.MasterLevelId, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.MasterLevelId] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetMasteryValue(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, double? dblMasteryValue, string strComparisonOp="")
	{
objge_KnowledgesClsMasterEN.MasteryValue = dblMasteryValue; //掌握度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.MasteryValue) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.MasteryValue, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.MasteryValue] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetGoalValue(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, double? dblGoalValue, string strComparisonOp="")
	{
objge_KnowledgesClsMasterEN.GoalValue = dblGoalValue; //目标值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.GoalValue) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.GoalValue, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.GoalValue] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetSelfPerceivedValue(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, double? dblSelfPerceivedValue, string strComparisonOp="")
	{
objge_KnowledgesClsMasterEN.SelfPerceivedValue = dblSelfPerceivedValue; //自我认为值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.SelfPerceivedValue) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.SelfPerceivedValue, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.SelfPerceivedValue] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetUpdDate(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_KnowledgesClsMaster.UpdDate);
}
objge_KnowledgesClsMasterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.UpdDate) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.UpdDate, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.UpdDate] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetUpdUser(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_KnowledgesClsMaster.UpdUser);
}
objge_KnowledgesClsMasterEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.UpdUser) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.UpdUser, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.UpdUser] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_KnowledgesClsMasterEN SetMemo(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_KnowledgesClsMaster.Memo);
}
objge_KnowledgesClsMasterEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_KnowledgesClsMasterEN.dicFldComparisonOp.ContainsKey(conge_KnowledgesClsMaster.Memo) == false)
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp.Add(conge_KnowledgesClsMaster.Memo, strComparisonOp);
}
else
{
objge_KnowledgesClsMasterEN.dicFldComparisonOp[conge_KnowledgesClsMaster.Memo] = strComparisonOp;
}
}
return objge_KnowledgesClsMasterEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_KnowledgesClsMasterEN.CheckPropertyNew();
clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterCond = new clsge_KnowledgesClsMasterEN();
string strCondition = objge_KnowledgesClsMasterCond
.SetIdCurrEduCls(objge_KnowledgesClsMasterEN.IdCurrEduCls, "=")
.GetCombineCondition();
objge_KnowledgesClsMasterEN._IsCheckProperty = true;
bool bolIsExist = clsge_KnowledgesClsMasterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_KnowledgesClsMasterEN.Update();
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.UpdateBySql2(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.UpdateBySql2(objge_KnowledgesClsMasterEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strWhereCond)
{
try
{
bool bolResult = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.UpdateBySqlWithCondition(objge_KnowledgesClsMasterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.UpdateBySqlWithConditionTransaction(objge_KnowledgesClsMasterEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
try
{
int intRecNum = clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.DelRecord(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
 /// <param name = "objge_KnowledgesClsMasterENT">目标对象</param>
 public static void CopyTo(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENS, clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENT)
{
try
{
objge_KnowledgesClsMasterENT.IdCurrEduCls = objge_KnowledgesClsMasterENS.IdCurrEduCls; //教学班流水号
objge_KnowledgesClsMasterENT.CourseKnowledgeId = objge_KnowledgesClsMasterENS.CourseKnowledgeId; //知识点Id
objge_KnowledgesClsMasterENT.CourseId = objge_KnowledgesClsMasterENS.CourseId; //课程Id
objge_KnowledgesClsMasterENT.MasterLevelId = objge_KnowledgesClsMasterENS.MasterLevelId; //掌握度Id
objge_KnowledgesClsMasterENT.MasteryValue = objge_KnowledgesClsMasterENS.MasteryValue; //掌握度
objge_KnowledgesClsMasterENT.GoalValue = objge_KnowledgesClsMasterENS.GoalValue; //目标值
objge_KnowledgesClsMasterENT.SelfPerceivedValue = objge_KnowledgesClsMasterENS.SelfPerceivedValue; //自我认为值
objge_KnowledgesClsMasterENT.UpdDate = objge_KnowledgesClsMasterENS.UpdDate; //修改日期
objge_KnowledgesClsMasterENT.UpdUser = objge_KnowledgesClsMasterENS.UpdUser; //修改人
objge_KnowledgesClsMasterENT.Memo = objge_KnowledgesClsMasterENS.Memo; //备注
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
 /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
 /// <returns>目标对象=>clsge_KnowledgesClsMasterEN:objge_KnowledgesClsMasterENT</returns>
 public static clsge_KnowledgesClsMasterEN CopyTo(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENS)
{
try
{
 clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENT = new clsge_KnowledgesClsMasterEN()
{
IdCurrEduCls = objge_KnowledgesClsMasterENS.IdCurrEduCls, //教学班流水号
CourseKnowledgeId = objge_KnowledgesClsMasterENS.CourseKnowledgeId, //知识点Id
CourseId = objge_KnowledgesClsMasterENS.CourseId, //课程Id
MasterLevelId = objge_KnowledgesClsMasterENS.MasterLevelId, //掌握度Id
MasteryValue = objge_KnowledgesClsMasterENS.MasteryValue, //掌握度
GoalValue = objge_KnowledgesClsMasterENS.GoalValue, //目标值
SelfPerceivedValue = objge_KnowledgesClsMasterENS.SelfPerceivedValue, //自我认为值
UpdDate = objge_KnowledgesClsMasterENS.UpdDate, //修改日期
UpdUser = objge_KnowledgesClsMasterENS.UpdUser, //修改人
Memo = objge_KnowledgesClsMasterENS.Memo, //备注
};
 return objge_KnowledgesClsMasterENT;
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
public static void CheckPropertyNew(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.CheckPropertyNew(objge_KnowledgesClsMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 clsge_KnowledgesClsMasterBL.ge_KnowledgesClsMasterDA.CheckProperty4Condition(objge_KnowledgesClsMasterEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.IdCurrEduCls, objge_KnowledgesClsMasterCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.CourseKnowledgeId, objge_KnowledgesClsMasterCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.CourseId) == true)
{
string strComparisonOpCourseId = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.CourseId, objge_KnowledgesClsMasterCond.CourseId, strComparisonOpCourseId);
}
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.MasterLevelId) == true)
{
string strComparisonOpMasterLevelId = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.MasterLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.MasterLevelId, objge_KnowledgesClsMasterCond.MasterLevelId, strComparisonOpMasterLevelId);
}
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.UpdDate, objge_KnowledgesClsMasterCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.UpdUser, objge_KnowledgesClsMasterCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_KnowledgesClsMasterCond.IsUpdated(conge_KnowledgesClsMaster.Memo) == true)
{
string strComparisonOpMemo = objge_KnowledgesClsMasterCond.dicFldComparisonOp[conge_KnowledgesClsMaster.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_KnowledgesClsMaster.Memo, objge_KnowledgesClsMasterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_KnowledgesClsMaster
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls,string strCourseKnowledgeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点教学班掌握度(ge_KnowledgesClsMaster)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_KnowledgesClsMasterBL
{
public static RelatedActions_ge_KnowledgesClsMaster relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_KnowledgesClsMasterDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_KnowledgesClsMasterDA ge_KnowledgesClsMasterDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_KnowledgesClsMasterDA();
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
 public clsge_KnowledgesClsMasterBL()
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
if (string.IsNullOrEmpty(clsge_KnowledgesClsMasterEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_KnowledgesClsMasterEN._ConnectString);
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
public static DataTable GetDataTable_ge_KnowledgesClsMaster(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_KnowledgesClsMasterDA.GetDataTable_ge_KnowledgesClsMaster(strWhereCond);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable(strWhereCond);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable_Top(objTopPara);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_KnowledgesClsMasterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--ge_KnowledgesClsMaster(知识点教学班掌握度)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
//检测记录是否存在
string strResult = "";
strResult += objge_KnowledgesClsMasterEN.IdCurrEduCls;
strResult += "|" + objge_KnowledgesClsMasterEN.CourseKnowledgeId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_KnowledgesClsMasterEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clsge_KnowledgesClsMasterEN._CurrTabName);
List<clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLstCache = GetObjLstCache();
IEnumerable <clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLst_Sel =
arrge_KnowledgesClsMasterObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrge_KnowledgesClsMasterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetObjLst(string strWhereCond)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
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
public static List<clsge_KnowledgesClsMasterEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_KnowledgesClsMasterEN> GetSubObjLstCache(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterCond)
{
List<clsge_KnowledgesClsMasterEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_KnowledgesClsMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_KnowledgesClsMaster.AttributeName)
{
if (objge_KnowledgesClsMasterCond.IsUpdated(strFldName) == false) continue;
if (objge_KnowledgesClsMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesClsMasterCond[strFldName].ToString());
}
else
{
if (objge_KnowledgesClsMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_KnowledgesClsMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesClsMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_KnowledgesClsMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesClsMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesClsMasterCond[strFldName]));
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
public static List<clsge_KnowledgesClsMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
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
public static List<clsge_KnowledgesClsMasterEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
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
List<clsge_KnowledgesClsMasterEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_KnowledgesClsMasterEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_KnowledgesClsMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
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
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
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
public static List<clsge_KnowledgesClsMasterEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_KnowledgesClsMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
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
public static List<clsge_KnowledgesClsMasterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_KnowledgesClsMasterEN> arrObjLst = new List<clsge_KnowledgesClsMasterEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = new clsge_KnowledgesClsMasterEN();
try
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objRow[conge_KnowledgesClsMaster.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesClsMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesClsMasterEN.CourseId = objRow[conge_KnowledgesClsMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesClsMasterEN.MasterLevelId = objRow[conge_KnowledgesClsMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesClsMasterEN.MasteryValue = objRow[conge_KnowledgesClsMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesClsMasterEN.GoalValue = objRow[conge_KnowledgesClsMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesClsMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesClsMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesClsMasterEN.UpdDate = objRow[conge_KnowledgesClsMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesClsMasterEN.UpdUser = objRow[conge_KnowledgesClsMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesClsMasterEN.Memo = objRow[conge_KnowledgesClsMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesClsMaster.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_KnowledgesClsMasterEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_KnowledgesClsMasterEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_KnowledgesClsMaster(ref clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
bool bolResult = ge_KnowledgesClsMasterDA.Getge_KnowledgesClsMaster(ref objge_KnowledgesClsMasterEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_KnowledgesClsMasterEN GetObjByKeyLst(string strIdCurrEduCls,string strCourseKnowledgeId)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strIdCurrEduCls,strCourseKnowledgeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strCourseKnowledgeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strIdCurrEduCls,strCourseKnowledgeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strCourseKnowledgeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = ge_KnowledgesClsMasterDA.GetObjByKeyLst(strIdCurrEduCls,strCourseKnowledgeId);
return objge_KnowledgesClsMasterEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_KnowledgesClsMasterEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = ge_KnowledgesClsMasterDA.GetFirstObj(strWhereCond);
 return objge_KnowledgesClsMasterEN;
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
public static clsge_KnowledgesClsMasterEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = ge_KnowledgesClsMasterDA.GetObjByDataRow(objRow);
 return objge_KnowledgesClsMasterEN;
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
public static clsge_KnowledgesClsMasterEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = ge_KnowledgesClsMasterDA.GetObjByDataRow(objRow);
 return objge_KnowledgesClsMasterEN;
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
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <param name = "lstge_KnowledgesClsMasterObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_KnowledgesClsMasterEN GetObjByKeyLstFromList(string strIdCurrEduCls,string strCourseKnowledgeId, List<clsge_KnowledgesClsMasterEN> lstge_KnowledgesClsMasterObjLst)
{
foreach (clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN in lstge_KnowledgesClsMasterObjLst)
{
if (objge_KnowledgesClsMasterEN.IdCurrEduCls == strIdCurrEduCls 
 && objge_KnowledgesClsMasterEN.CourseKnowledgeId == strCourseKnowledgeId 
)
{
return objge_KnowledgesClsMasterEN;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsge_KnowledgesClsMasterDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = ge_KnowledgesClsMasterDA.GetID(strWhereCond);
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
bool bolIsExist = ge_KnowledgesClsMasterDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls,string strCourseKnowledgeId)
{
//检测记录是否存在
bool bolIsExist = ge_KnowledgesClsMasterDA.IsExist(strIdCurrEduCls,strCourseKnowledgeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCurrEduCls">教学班流水号</param>
/// <param name = "strCourseKnowledgeId">知识点Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCurrEduCls , string strCourseKnowledgeId, string strOpUser)
{
clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = clsge_KnowledgesClsMasterBL.GetObjByKeyLst(strIdCurrEduCls,strCourseKnowledgeId);
objge_KnowledgesClsMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_KnowledgesClsMasterEN.UpdUser = strOpUser;
return clsge_KnowledgesClsMasterBL.UpdateBySql2(objge_KnowledgesClsMasterEN);
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
 bolIsExist = clsge_KnowledgesClsMasterDA.IsExistTable();
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
 bolIsExist = ge_KnowledgesClsMasterDA.IsExistTable(strTabName);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_KnowledgesClsMasterBL.IsExist(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_KnowledgesClsMasterEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ge_KnowledgesClsMasterDA.AddNewRecordBySQL2(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_KnowledgesClsMasterBL.IsExist(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_KnowledgesClsMasterEN.IdCurrEduCls, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ge_KnowledgesClsMasterDA.AddNewRecordBySQL2WithReturnKey(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
try
{
bool bolResult = ge_KnowledgesClsMasterDA.Update(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "objge_KnowledgesClsMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 if (string.IsNullOrEmpty(objge_KnowledgesClsMasterEN.IdCurrEduCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_KnowledgesClsMasterDA.UpdateBySql2(objge_KnowledgesClsMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_KnowledgesClsMasterBL.ReFreshCache();

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCurrEduCls,string strCourseKnowledgeId)
{
try
{
 clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN = clsge_KnowledgesClsMasterBL.GetObjByKeyLst(strIdCurrEduCls,strCourseKnowledgeId);

if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(objge_KnowledgesClsMasterEN.IdCurrEduCls,objge_KnowledgesClsMasterEN.CourseKnowledgeId, objge_KnowledgesClsMasterEN.UpdUser);
}
if (objge_KnowledgesClsMasterEN != null)
{
int intRecNum = ge_KnowledgesClsMasterDA.DelRecord(strIdCurrEduCls,strCourseKnowledgeId);
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
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCurrEduCls,string strCourseKnowledgeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_KnowledgesClsMasterDA.GetSpecSQLObj();
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
//删除与表:[ge_KnowledgesClsMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_KnowledgesClsMaster.IdCurrEduCls,
//strIdCurrEduCls);
//        clsge_KnowledgesClsMasterBL.Delge_KnowledgesClsMastersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_KnowledgesClsMasterBL.DelRecord(strIdCurrEduCls,strCourseKnowledgeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_KnowledgesClsMasterBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCurrEduCls,string strCourseKnowledgeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls,strCourseKnowledgeId, "UpdRelaTabDate");
}
bool bolResult = ge_KnowledgesClsMasterDA.DelRecord(strIdCurrEduCls,strCourseKnowledgeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCurrEduClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strIdCurrEduCls;
string strCourseKnowledgeId;
if (clsge_KnowledgesClsMasterBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strIdCurrEduCls = sstrKey[0];
strCourseKnowledgeId = sstrKey[1];
clsge_KnowledgesClsMasterBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls,strCourseKnowledgeId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strIdCurrEduCls = sstrKey[0];
strCourseKnowledgeId = sstrKey[1];
int intDelRecNum = ge_KnowledgesClsMasterDA.DelRecKeyLsts(arrKeyLsts);
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
public static int Delge_KnowledgesClsMastersByCond(string strWhereCond)
{
try
{
int intRecNum = ge_KnowledgesClsMasterDA.Delge_KnowledgesClsMaster(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_KnowledgesClsMaster]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCurrEduCls,string strCourseKnowledgeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_KnowledgesClsMasterDA.GetSpecSQLObj();
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
//删除与表:[ge_KnowledgesClsMaster]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_KnowledgesClsMasterBL.DelRecord(strIdCurrEduCls,strCourseKnowledgeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_KnowledgesClsMasterBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_KnowledgesClsMasterENS">源对象</param>
 /// <param name = "objge_KnowledgesClsMasterENT">目标对象</param>
 public static void CopyTo(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENS, clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterENT)
{
try
{
objge_KnowledgesClsMasterENT.IdCurrEduCls = objge_KnowledgesClsMasterENS.IdCurrEduCls; //教学班流水号
objge_KnowledgesClsMasterENT.CourseKnowledgeId = objge_KnowledgesClsMasterENS.CourseKnowledgeId; //知识点Id
objge_KnowledgesClsMasterENT.CourseId = objge_KnowledgesClsMasterENS.CourseId; //课程Id
objge_KnowledgesClsMasterENT.MasterLevelId = objge_KnowledgesClsMasterENS.MasterLevelId; //掌握度Id
objge_KnowledgesClsMasterENT.MasteryValue = objge_KnowledgesClsMasterENS.MasteryValue; //掌握度
objge_KnowledgesClsMasterENT.GoalValue = objge_KnowledgesClsMasterENS.GoalValue; //目标值
objge_KnowledgesClsMasterENT.SelfPerceivedValue = objge_KnowledgesClsMasterENS.SelfPerceivedValue; //自我认为值
objge_KnowledgesClsMasterENT.UpdDate = objge_KnowledgesClsMasterENS.UpdDate; //修改日期
objge_KnowledgesClsMasterENT.UpdUser = objge_KnowledgesClsMasterENS.UpdUser; //修改人
objge_KnowledgesClsMasterENT.Memo = objge_KnowledgesClsMasterENS.Memo; //备注
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
 /// <param name = "objge_KnowledgesClsMasterEN">源简化对象</param>
 public static void SetUpdFlag(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
try
{
objge_KnowledgesClsMasterEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_KnowledgesClsMasterEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_KnowledgesClsMaster.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.IdCurrEduCls = objge_KnowledgesClsMasterEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.CourseKnowledgeId = objge_KnowledgesClsMasterEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.CourseId = objge_KnowledgesClsMasterEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.MasterLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.MasterLevelId = objge_KnowledgesClsMasterEN.MasterLevelId == "[null]" ? null :  objge_KnowledgesClsMasterEN.MasterLevelId; //掌握度Id
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.MasteryValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.MasteryValue = objge_KnowledgesClsMasterEN.MasteryValue; //掌握度
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.GoalValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.GoalValue = objge_KnowledgesClsMasterEN.GoalValue; //目标值
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.SelfPerceivedValue, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.SelfPerceivedValue = objge_KnowledgesClsMasterEN.SelfPerceivedValue; //自我认为值
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.UpdDate = objge_KnowledgesClsMasterEN.UpdDate == "[null]" ? null :  objge_KnowledgesClsMasterEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.UpdUser = objge_KnowledgesClsMasterEN.UpdUser == "[null]" ? null :  objge_KnowledgesClsMasterEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_KnowledgesClsMaster.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_KnowledgesClsMasterEN.Memo = objge_KnowledgesClsMasterEN.Memo == "[null]" ? null :  objge_KnowledgesClsMasterEN.Memo; //备注
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
 /// <param name = "objge_KnowledgesClsMasterEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
try
{
if (objge_KnowledgesClsMasterEN.MasterLevelId == "[null]") objge_KnowledgesClsMasterEN.MasterLevelId = null; //掌握度Id
if (objge_KnowledgesClsMasterEN.UpdDate == "[null]") objge_KnowledgesClsMasterEN.UpdDate = null; //修改日期
if (objge_KnowledgesClsMasterEN.UpdUser == "[null]") objge_KnowledgesClsMasterEN.UpdUser = null; //修改人
if (objge_KnowledgesClsMasterEN.Memo == "[null]") objge_KnowledgesClsMasterEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 ge_KnowledgesClsMasterDA.CheckPropertyNew(objge_KnowledgesClsMasterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterEN)
{
 ge_KnowledgesClsMasterDA.CheckProperty4Condition(objge_KnowledgesClsMasterEN);
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
if (clsge_KnowledgesClsMasterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_KnowledgesClsMasterBL没有刷新缓存机制(clsge_KnowledgesClsMasterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrge_KnowledgesClsMasterObjLstCache == null)
//{
//arrge_KnowledgesClsMasterObjLstCache = ge_KnowledgesClsMasterDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_KnowledgesClsMasterEN GetObjByKeyLstCache(string strIdCurrEduCls,string strCourseKnowledgeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_KnowledgesClsMasterEN._CurrTabName);
List<clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLstCache = GetObjLstCache();
IEnumerable <clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLst_Sel =
arrge_KnowledgesClsMasterObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
 && x.CourseKnowledgeId == strCourseKnowledgeId 
);
if (arrge_KnowledgesClsMasterObjLst_Sel.Count() == 0)
{
   clsge_KnowledgesClsMasterEN obj = clsge_KnowledgesClsMasterBL.GetObjByKeyLst(strIdCurrEduCls,strCourseKnowledgeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_KnowledgesClsMasterObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetAllge_KnowledgesClsMasterObjLstCache()
{
//获取缓存中的对象列表
List<clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLstCache = GetObjLstCache(); 
return arrge_KnowledgesClsMasterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_KnowledgesClsMasterEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_KnowledgesClsMasterEN._CurrTabName);
List<clsge_KnowledgesClsMasterEN> arrge_KnowledgesClsMasterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_KnowledgesClsMasterObjLstCache;
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
string strKey = string.Format("{0}", clsge_KnowledgesClsMasterEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_KnowledgesClsMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_KnowledgesClsMasterEN._RefreshTimeLst.Count == 0) return "";
return clsge_KnowledgesClsMasterEN._RefreshTimeLst[clsge_KnowledgesClsMasterEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_KnowledgesClsMasterBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_KnowledgesClsMasterEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_KnowledgesClsMasterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_KnowledgesClsMasterBL.objCommFun4BL.ReFreshCache();
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls,string strCourseKnowledgeId)
{
if (strInFldName != conge_KnowledgesClsMaster.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_KnowledgesClsMaster.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_KnowledgesClsMaster.AttributeName));
throw new Exception(strMsg);
}
var objge_KnowledgesClsMaster = clsge_KnowledgesClsMasterBL.GetObjByKeyLstCache(strIdCurrEduCls,strCourseKnowledgeId);
if (objge_KnowledgesClsMaster == null) return "";
return objge_KnowledgesClsMaster[strOutFldName].ToString();
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
int intRecCount = clsge_KnowledgesClsMasterDA.GetRecCount(strTabName);
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
int intRecCount = clsge_KnowledgesClsMasterDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_KnowledgesClsMasterDA.GetRecCount();
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
int intRecCount = clsge_KnowledgesClsMasterDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_KnowledgesClsMasterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_KnowledgesClsMasterEN objge_KnowledgesClsMasterCond)
{
List<clsge_KnowledgesClsMasterEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_KnowledgesClsMasterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_KnowledgesClsMaster.AttributeName)
{
if (objge_KnowledgesClsMasterCond.IsUpdated(strFldName) == false) continue;
if (objge_KnowledgesClsMasterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesClsMasterCond[strFldName].ToString());
}
else
{
if (objge_KnowledgesClsMasterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_KnowledgesClsMasterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_KnowledgesClsMasterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_KnowledgesClsMasterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_KnowledgesClsMasterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesClsMasterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_KnowledgesClsMasterCond[strFldName]));
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
 List<string> arrList = clsge_KnowledgesClsMasterDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_KnowledgesClsMasterDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_KnowledgesClsMasterDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_KnowledgesClsMasterDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesClsMasterDA.SetFldValue(clsge_KnowledgesClsMasterEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_KnowledgesClsMasterDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesClsMasterDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesClsMasterDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_KnowledgesClsMasterDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_KnowledgesClsMaster] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) primary key, "); 
 // /**知识点Id*/ 
 strCreateTabCode.Append(" CourseKnowledgeId char(8) primary key, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**掌握度Id*/ 
 strCreateTabCode.Append(" MasterLevelId char(4) Null, "); 
 // /**掌握度*/ 
 strCreateTabCode.Append(" MasteryValue numeric(20,2) Null, "); 
 // /**目标值*/ 
 strCreateTabCode.Append(" GoalValue numeric(20,2) Null, "); 
 // /**自我认为值*/ 
 strCreateTabCode.Append(" SelfPerceivedValue numeric(20,2) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
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
 /// 知识点教学班掌握度(ge_KnowledgesClsMaster)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_KnowledgesClsMaster : clsCommFun4BL
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
clsge_KnowledgesClsMasterBL.ReFreshThisCache();
}
}

}