﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSubmitResultsBL
 表名:ge_StructureSubmitResults(01120903)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:35
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
public static class  clsge_StructureSubmitResultsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSubmitResultsEN GetObj(this K_mId_ge_StructureSubmitResults myKey)
{
clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.GetObjBymId(myKey.Value);
return objge_StructureSubmitResultsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSubmitResultsEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsge_StructureSubmitResultsBL.AddNewRecord)", objge_StructureSubmitResultsEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.AddNewRecordBySQL2(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
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
objge_StructureSubmitResultsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StructureSubmitResultsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objge_StructureSubmitResultsEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_StructureSubmitResultsEN.AddNewRecord();
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureSubmitResultsEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsge_StructureSubmitResultsBL.AddNewRecordWithReturnKey)", objge_StructureSubmitResultsEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetmId(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, long lngmId, string strComparisonOp="")
	{
objge_StructureSubmitResultsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.mId) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.mId, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.mId] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetStructureGraphId(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strStructureGraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStructureGraphId, conge_StructureSubmitResults.StructureGraphId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureGraphId, 10, conge_StructureSubmitResults.StructureGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureGraphId, 10, conge_StructureSubmitResults.StructureGraphId);
}
objge_StructureSubmitResultsEN.StructureGraphId = strStructureGraphId; //知识图谱Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.StructureGraphId) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.StructureGraphId, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.StructureGraphId] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetCreateUser(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conge_StructureSubmitResults.CreateUser);
}
objge_StructureSubmitResultsEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.CreateUser) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.CreateUser, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.CreateUser] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetTakeUpTime(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strTakeUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTakeUpTime, 50, conge_StructureSubmitResults.TakeUpTime);
}
objge_StructureSubmitResultsEN.TakeUpTime = strTakeUpTime; //耗时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.TakeUpTime) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.TakeUpTime, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.TakeUpTime] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetCorrectNum(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, int? intCorrectNum, string strComparisonOp="")
	{
objge_StructureSubmitResultsEN.CorrectNum = intCorrectNum; //正确数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.CorrectNum) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.CorrectNum, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.CorrectNum] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetErrorNum(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, int? intErrorNum, string strComparisonOp="")
	{
objge_StructureSubmitResultsEN.ErrorNum = intErrorNum; //错误数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.ErrorNum) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.ErrorNum, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.ErrorNum] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetFraction(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, int? intFraction, string strComparisonOp="")
	{
objge_StructureSubmitResultsEN.Fraction = intFraction; //分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.Fraction) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.Fraction, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.Fraction] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetUpdDate(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StructureSubmitResults.UpdDate);
}
objge_StructureSubmitResultsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.UpdDate) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.UpdDate, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.UpdDate] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetUpdUser(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StructureSubmitResults.UpdUser);
}
objge_StructureSubmitResultsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.UpdUser) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.UpdUser, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.UpdUser] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetMemo(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StructureSubmitResults.Memo);
}
objge_StructureSubmitResultsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.Memo) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.Memo, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.Memo] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureSubmitResultsEN SetCourseId(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StructureSubmitResults.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StructureSubmitResults.CourseId);
}
objge_StructureSubmitResultsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_StructureSubmitResults.CourseId) == false)
{
objge_StructureSubmitResultsEN.dicFldComparisonOp.Add(conge_StructureSubmitResults.CourseId, strComparisonOp);
}
else
{
objge_StructureSubmitResultsEN.dicFldComparisonOp[conge_StructureSubmitResults.CourseId] = strComparisonOp;
}
}
return objge_StructureSubmitResultsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StructureSubmitResultsEN.CheckPropertyNew();
clsge_StructureSubmitResultsEN objge_StructureSubmitResultsCond = new clsge_StructureSubmitResultsEN();
string strCondition = objge_StructureSubmitResultsCond
.SetmId(objge_StructureSubmitResultsEN.mId, "<>")
.SetmId(objge_StructureSubmitResultsEN.mId, "=")
.GetCombineCondition();
objge_StructureSubmitResultsEN._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSubmitResultsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StructureSubmitResultsEN.Update();
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
 /// <param name = "objge_StructureSubmitResults">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StructureSubmitResultsEN objge_StructureSubmitResults)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StructureSubmitResultsEN objge_StructureSubmitResultsCond = new clsge_StructureSubmitResultsEN();
string strCondition = objge_StructureSubmitResultsCond
.SetmId(objge_StructureSubmitResults.mId, "=")
.GetCombineCondition();
objge_StructureSubmitResults._IsCheckProperty = true;
bool bolIsExist = clsge_StructureSubmitResultsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StructureSubmitResults.mId = clsge_StructureSubmitResultsBL.GetFirstID_S(strCondition);
objge_StructureSubmitResults.UpdateWithCondition(strCondition);
}
else
{
objge_StructureSubmitResults.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 if (objge_StructureSubmitResultsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.UpdateBySql2(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_StructureSubmitResultsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.UpdateBySql2(objge_StructureSubmitResultsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.UpdateBySqlWithCondition(objge_StructureSubmitResultsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.UpdateBySqlWithConditionTransaction(objge_StructureSubmitResultsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
public static int Delete(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
try
{
int intRecNum = clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.DelRecord(objge_StructureSubmitResultsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsENS">源对象</param>
 /// <param name = "objge_StructureSubmitResultsENT">目标对象</param>
 public static void CopyTo(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENS, clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENT)
{
try
{
objge_StructureSubmitResultsENT.mId = objge_StructureSubmitResultsENS.mId; //mId
objge_StructureSubmitResultsENT.StructureGraphId = objge_StructureSubmitResultsENS.StructureGraphId; //知识图谱Id
objge_StructureSubmitResultsENT.CreateUser = objge_StructureSubmitResultsENS.CreateUser; //建立用户
objge_StructureSubmitResultsENT.TakeUpTime = objge_StructureSubmitResultsENS.TakeUpTime; //耗时
objge_StructureSubmitResultsENT.CorrectNum = objge_StructureSubmitResultsENS.CorrectNum; //正确数
objge_StructureSubmitResultsENT.ErrorNum = objge_StructureSubmitResultsENS.ErrorNum; //错误数
objge_StructureSubmitResultsENT.Fraction = objge_StructureSubmitResultsENS.Fraction; //分数
objge_StructureSubmitResultsENT.UpdDate = objge_StructureSubmitResultsENS.UpdDate; //修改日期
objge_StructureSubmitResultsENT.UpdUser = objge_StructureSubmitResultsENS.UpdUser; //修改人
objge_StructureSubmitResultsENT.Memo = objge_StructureSubmitResultsENS.Memo; //备注
objge_StructureSubmitResultsENT.CourseId = objge_StructureSubmitResultsENS.CourseId; //课程Id
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
 /// <param name = "objge_StructureSubmitResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureSubmitResultsEN:objge_StructureSubmitResultsENT</returns>
 public static clsge_StructureSubmitResultsEN CopyTo(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENS)
{
try
{
 clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENT = new clsge_StructureSubmitResultsEN()
{
mId = objge_StructureSubmitResultsENS.mId, //mId
StructureGraphId = objge_StructureSubmitResultsENS.StructureGraphId, //知识图谱Id
CreateUser = objge_StructureSubmitResultsENS.CreateUser, //建立用户
TakeUpTime = objge_StructureSubmitResultsENS.TakeUpTime, //耗时
CorrectNum = objge_StructureSubmitResultsENS.CorrectNum, //正确数
ErrorNum = objge_StructureSubmitResultsENS.ErrorNum, //错误数
Fraction = objge_StructureSubmitResultsENS.Fraction, //分数
UpdDate = objge_StructureSubmitResultsENS.UpdDate, //修改日期
UpdUser = objge_StructureSubmitResultsENS.UpdUser, //修改人
Memo = objge_StructureSubmitResultsENS.Memo, //备注
CourseId = objge_StructureSubmitResultsENS.CourseId, //课程Id
};
 return objge_StructureSubmitResultsENT;
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
public static void CheckPropertyNew(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.CheckPropertyNew(objge_StructureSubmitResultsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 clsge_StructureSubmitResultsBL.ge_StructureSubmitResultsDA.CheckProperty4Condition(objge_StructureSubmitResultsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.mId) == true)
{
string strComparisonOpmId = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureSubmitResults.mId, objge_StructureSubmitResultsCond.mId, strComparisonOpmId);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.StructureGraphId) == true)
{
string strComparisonOpStructureGraphId = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.StructureGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.StructureGraphId, objge_StructureSubmitResultsCond.StructureGraphId, strComparisonOpStructureGraphId);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.CreateUser) == true)
{
string strComparisonOpCreateUser = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.CreateUser, objge_StructureSubmitResultsCond.CreateUser, strComparisonOpCreateUser);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.TakeUpTime) == true)
{
string strComparisonOpTakeUpTime = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.TakeUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.TakeUpTime, objge_StructureSubmitResultsCond.TakeUpTime, strComparisonOpTakeUpTime);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.CorrectNum) == true)
{
string strComparisonOpCorrectNum = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.CorrectNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureSubmitResults.CorrectNum, objge_StructureSubmitResultsCond.CorrectNum, strComparisonOpCorrectNum);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.ErrorNum) == true)
{
string strComparisonOpErrorNum = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.ErrorNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureSubmitResults.ErrorNum, objge_StructureSubmitResultsCond.ErrorNum, strComparisonOpErrorNum);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.Fraction) == true)
{
string strComparisonOpFraction = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.Fraction];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureSubmitResults.Fraction, objge_StructureSubmitResultsCond.Fraction, strComparisonOpFraction);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.UpdDate, objge_StructureSubmitResultsCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.UpdUser, objge_StructureSubmitResultsCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.Memo) == true)
{
string strComparisonOpMemo = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.Memo, objge_StructureSubmitResultsCond.Memo, strComparisonOpMemo);
}
if (objge_StructureSubmitResultsCond.IsUpdated(conge_StructureSubmitResults.CourseId) == true)
{
string strComparisonOpCourseId = objge_StructureSubmitResultsCond.dicFldComparisonOp[conge_StructureSubmitResults.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureSubmitResults.CourseId, objge_StructureSubmitResultsCond.CourseId, strComparisonOpCourseId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StructureSubmitResults(结构提交结果表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSubmitResultsEN == null) return true;
if (objge_StructureSubmitResultsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objge_StructureSubmitResultsEN.mId);
if (clsge_StructureSubmitResultsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_StructureSubmitResultsEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objge_StructureSubmitResultsEN.mId);
if (clsge_StructureSubmitResultsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StructureSubmitResults(结构提交结果表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureSubmitResultsEN == null) return "";
if (objge_StructureSubmitResultsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objge_StructureSubmitResultsEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_StructureSubmitResultsEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objge_StructureSubmitResultsEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StructureSubmitResults
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 结构提交结果表(ge_StructureSubmitResults)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StructureSubmitResultsBL
{
public static RelatedActions_ge_StructureSubmitResults relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StructureSubmitResultsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StructureSubmitResultsDA ge_StructureSubmitResultsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StructureSubmitResultsDA();
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
 public clsge_StructureSubmitResultsBL()
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
if (string.IsNullOrEmpty(clsge_StructureSubmitResultsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureSubmitResultsEN._ConnectString);
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
public static DataTable GetDataTable_ge_StructureSubmitResults(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StructureSubmitResultsDA.GetDataTable_ge_StructureSubmitResults(strWhereCond);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable(strWhereCond);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StructureSubmitResultsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StructureSubmitResultsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StructureSubmitResultsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsge_StructureSubmitResultsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
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
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StructureSubmitResultsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsge_StructureSubmitResultsEN._CurrTabName);
List<clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLstCache = GetObjLstCache();
IEnumerable <clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLst_Sel =
arrge_StructureSubmitResultsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrge_StructureSubmitResultsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetObjLst(string strWhereCond)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
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
public static List<clsge_StructureSubmitResultsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StructureSubmitResultsEN> GetSubObjLstCache(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsCond)
{
List<clsge_StructureSubmitResultsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_StructureSubmitResultsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSubmitResults.AttributeName)
{
if (objge_StructureSubmitResultsCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSubmitResultsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSubmitResultsCond[strFldName].ToString());
}
else
{
if (objge_StructureSubmitResultsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSubmitResultsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSubmitResultsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSubmitResultsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSubmitResultsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSubmitResultsCond[strFldName]));
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
public static List<clsge_StructureSubmitResultsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
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
public static List<clsge_StructureSubmitResultsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
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
List<clsge_StructureSubmitResultsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StructureSubmitResultsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StructureSubmitResultsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
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
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
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
public static List<clsge_StructureSubmitResultsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StructureSubmitResultsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
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
public static List<clsge_StructureSubmitResultsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StructureSubmitResultsEN> arrObjLst = new List<clsge_StructureSubmitResultsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = new clsge_StructureSubmitResultsEN();
try
{
objge_StructureSubmitResultsEN.mId = Int32.Parse(objRow[conge_StructureSubmitResults.mId].ToString().Trim()); //mId
objge_StructureSubmitResultsEN.StructureGraphId = objRow[conge_StructureSubmitResults.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureSubmitResultsEN.CreateUser = objRow[conge_StructureSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_StructureSubmitResultsEN.TakeUpTime = objRow[conge_StructureSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_StructureSubmitResultsEN.CorrectNum = objRow[conge_StructureSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_StructureSubmitResultsEN.ErrorNum = objRow[conge_StructureSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_StructureSubmitResultsEN.Fraction = objRow[conge_StructureSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureSubmitResults.Fraction].ToString().Trim()); //分数
objge_StructureSubmitResultsEN.UpdDate = objRow[conge_StructureSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_StructureSubmitResultsEN.UpdUser = objRow[conge_StructureSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_StructureSubmitResultsEN.Memo = objRow[conge_StructureSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.Memo].ToString().Trim(); //备注
objge_StructureSubmitResultsEN.CourseId = objRow[conge_StructureSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_StructureSubmitResults.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureSubmitResultsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StructureSubmitResults(ref clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
bool bolResult = ge_StructureSubmitResultsDA.Getge_StructureSubmitResults(ref objge_StructureSubmitResultsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureSubmitResultsEN GetObjBymId(long lngmId)
{
clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = ge_StructureSubmitResultsDA.GetObjBymId(lngmId);
return objge_StructureSubmitResultsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StructureSubmitResultsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = ge_StructureSubmitResultsDA.GetFirstObj(strWhereCond);
 return objge_StructureSubmitResultsEN;
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
public static clsge_StructureSubmitResultsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = ge_StructureSubmitResultsDA.GetObjByDataRow(objRow);
 return objge_StructureSubmitResultsEN;
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
public static clsge_StructureSubmitResultsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = ge_StructureSubmitResultsDA.GetObjByDataRow(objRow);
 return objge_StructureSubmitResultsEN;
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
 /// <param name = "lstge_StructureSubmitResultsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSubmitResultsEN GetObjBymIdFromList(long lngmId, List<clsge_StructureSubmitResultsEN> lstge_StructureSubmitResultsObjLst)
{
foreach (clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN in lstge_StructureSubmitResultsObjLst)
{
if (objge_StructureSubmitResultsEN.mId == lngmId)
{
return objge_StructureSubmitResultsEN;
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
 lngmId = new clsge_StructureSubmitResultsDA().GetFirstID(strWhereCond);
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
 arrList = ge_StructureSubmitResultsDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StructureSubmitResultsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ge_StructureSubmitResultsDA.IsExist(lngmId);
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
 bolIsExist = clsge_StructureSubmitResultsDA.IsExistTable();
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
 bolIsExist = ge_StructureSubmitResultsDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSubmitResultsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsge_StructureSubmitResultsBL.AddNewRecordBySql2)", objge_StructureSubmitResultsEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_StructureSubmitResultsDA.AddNewRecordBySQL2(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureSubmitResultsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsge_StructureSubmitResultsBL.AddNewRecordBySql2WithReturnKey)", objge_StructureSubmitResultsEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_StructureSubmitResultsDA.AddNewRecordBySQL2WithReturnKey(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
try
{
bool bolResult = ge_StructureSubmitResultsDA.Update(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_StructureSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 if (objge_StructureSubmitResultsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StructureSubmitResultsDA.UpdateBySql2(objge_StructureSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureSubmitResultsBL.ReFreshCache();

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
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
 clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN = clsge_StructureSubmitResultsBL.GetObjBymId(lngmId);

if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_StructureSubmitResultsEN.mId, "SetUpdDate");
}
if (objge_StructureSubmitResultsEN != null)
{
int intRecNum = ge_StructureSubmitResultsDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSubmitResultsDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSubmitResults]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StructureSubmitResults.mId,
//lngmId);
//        clsge_StructureSubmitResultsBL.Delge_StructureSubmitResultssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSubmitResultsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSubmitResultsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ge_StructureSubmitResultsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StructureSubmitResultss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_StructureSubmitResultsDA.Delge_StructureSubmitResults(arrmIdLst);
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
public static int Delge_StructureSubmitResultssByCond(string strWhereCond)
{
try
{
if (clsge_StructureSubmitResultsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsge_StructureSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = ge_StructureSubmitResultsDA.Delge_StructureSubmitResults(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StructureSubmitResults]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureSubmitResultsDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureSubmitResults]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureSubmitResultsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureSubmitResultsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objge_StructureSubmitResultsENS">源对象</param>
 /// <param name = "objge_StructureSubmitResultsENT">目标对象</param>
 public static void CopyTo(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENS, clsge_StructureSubmitResultsEN objge_StructureSubmitResultsENT)
{
try
{
objge_StructureSubmitResultsENT.mId = objge_StructureSubmitResultsENS.mId; //mId
objge_StructureSubmitResultsENT.StructureGraphId = objge_StructureSubmitResultsENS.StructureGraphId; //知识图谱Id
objge_StructureSubmitResultsENT.CreateUser = objge_StructureSubmitResultsENS.CreateUser; //建立用户
objge_StructureSubmitResultsENT.TakeUpTime = objge_StructureSubmitResultsENS.TakeUpTime; //耗时
objge_StructureSubmitResultsENT.CorrectNum = objge_StructureSubmitResultsENS.CorrectNum; //正确数
objge_StructureSubmitResultsENT.ErrorNum = objge_StructureSubmitResultsENS.ErrorNum; //错误数
objge_StructureSubmitResultsENT.Fraction = objge_StructureSubmitResultsENS.Fraction; //分数
objge_StructureSubmitResultsENT.UpdDate = objge_StructureSubmitResultsENS.UpdDate; //修改日期
objge_StructureSubmitResultsENT.UpdUser = objge_StructureSubmitResultsENS.UpdUser; //修改人
objge_StructureSubmitResultsENT.Memo = objge_StructureSubmitResultsENS.Memo; //备注
objge_StructureSubmitResultsENT.CourseId = objge_StructureSubmitResultsENS.CourseId; //课程Id
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
 /// <param name = "objge_StructureSubmitResultsEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
try
{
objge_StructureSubmitResultsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StructureSubmitResultsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StructureSubmitResults.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.mId = objge_StructureSubmitResultsEN.mId; //mId
}
if (arrFldSet.Contains(conge_StructureSubmitResults.StructureGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.StructureGraphId = objge_StructureSubmitResultsEN.StructureGraphId; //知识图谱Id
}
if (arrFldSet.Contains(conge_StructureSubmitResults.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.CreateUser = objge_StructureSubmitResultsEN.CreateUser == "[null]" ? null :  objge_StructureSubmitResultsEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conge_StructureSubmitResults.TakeUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.TakeUpTime = objge_StructureSubmitResultsEN.TakeUpTime == "[null]" ? null :  objge_StructureSubmitResultsEN.TakeUpTime; //耗时
}
if (arrFldSet.Contains(conge_StructureSubmitResults.CorrectNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.CorrectNum = objge_StructureSubmitResultsEN.CorrectNum; //正确数
}
if (arrFldSet.Contains(conge_StructureSubmitResults.ErrorNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.ErrorNum = objge_StructureSubmitResultsEN.ErrorNum; //错误数
}
if (arrFldSet.Contains(conge_StructureSubmitResults.Fraction, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.Fraction = objge_StructureSubmitResultsEN.Fraction; //分数
}
if (arrFldSet.Contains(conge_StructureSubmitResults.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.UpdDate = objge_StructureSubmitResultsEN.UpdDate == "[null]" ? null :  objge_StructureSubmitResultsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StructureSubmitResults.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.UpdUser = objge_StructureSubmitResultsEN.UpdUser == "[null]" ? null :  objge_StructureSubmitResultsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StructureSubmitResults.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.Memo = objge_StructureSubmitResultsEN.Memo == "[null]" ? null :  objge_StructureSubmitResultsEN.Memo; //备注
}
if (arrFldSet.Contains(conge_StructureSubmitResults.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureSubmitResultsEN.CourseId = objge_StructureSubmitResultsEN.CourseId == "[null]" ? null :  objge_StructureSubmitResultsEN.CourseId; //课程Id
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
 /// <param name = "objge_StructureSubmitResultsEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
try
{
if (objge_StructureSubmitResultsEN.CreateUser == "[null]") objge_StructureSubmitResultsEN.CreateUser = null; //建立用户
if (objge_StructureSubmitResultsEN.TakeUpTime == "[null]") objge_StructureSubmitResultsEN.TakeUpTime = null; //耗时
if (objge_StructureSubmitResultsEN.UpdDate == "[null]") objge_StructureSubmitResultsEN.UpdDate = null; //修改日期
if (objge_StructureSubmitResultsEN.UpdUser == "[null]") objge_StructureSubmitResultsEN.UpdUser = null; //修改人
if (objge_StructureSubmitResultsEN.Memo == "[null]") objge_StructureSubmitResultsEN.Memo = null; //备注
if (objge_StructureSubmitResultsEN.CourseId == "[null]") objge_StructureSubmitResultsEN.CourseId = null; //课程Id
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
public static void CheckPropertyNew(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 ge_StructureSubmitResultsDA.CheckPropertyNew(objge_StructureSubmitResultsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
 ge_StructureSubmitResultsDA.CheckProperty4Condition(objge_StructureSubmitResultsEN);
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
if (clsge_StructureSubmitResultsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StructureSubmitResultsBL没有刷新缓存机制(clsge_StructureSubmitResultsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrge_StructureSubmitResultsObjLstCache == null)
//{
//arrge_StructureSubmitResultsObjLstCache = ge_StructureSubmitResultsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureSubmitResultsEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_StructureSubmitResultsEN._CurrTabName);
List<clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLstCache = GetObjLstCache();
IEnumerable <clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLst_Sel =
arrge_StructureSubmitResultsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrge_StructureSubmitResultsObjLst_Sel.Count() == 0)
{
   clsge_StructureSubmitResultsEN obj = clsge_StructureSubmitResultsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_StructureSubmitResultsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetAllge_StructureSubmitResultsObjLstCache()
{
//获取缓存中的对象列表
List<clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLstCache = GetObjLstCache(); 
return arrge_StructureSubmitResultsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureSubmitResultsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_StructureSubmitResultsEN._CurrTabName);
List<clsge_StructureSubmitResultsEN> arrge_StructureSubmitResultsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_StructureSubmitResultsObjLstCache;
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
string strKey = string.Format("{0}", clsge_StructureSubmitResultsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_StructureSubmitResultsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StructureSubmitResultsEN._RefreshTimeLst.Count == 0) return "";
return clsge_StructureSubmitResultsEN._RefreshTimeLst[clsge_StructureSubmitResultsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_StructureSubmitResultsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_StructureSubmitResultsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_StructureSubmitResultsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StructureSubmitResultsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StructureSubmitResults(结构提交结果表)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsEN)
{
//检测记录是否存在
string strResult = ge_StructureSubmitResultsDA.GetUniCondStr(objge_StructureSubmitResultsEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conge_StructureSubmitResults.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StructureSubmitResults.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StructureSubmitResults.AttributeName));
throw new Exception(strMsg);
}
var objge_StructureSubmitResults = clsge_StructureSubmitResultsBL.GetObjBymIdCache(lngmId);
if (objge_StructureSubmitResults == null) return "";
return objge_StructureSubmitResults[strOutFldName].ToString();
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
int intRecCount = clsge_StructureSubmitResultsDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StructureSubmitResultsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StructureSubmitResultsDA.GetRecCount();
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
int intRecCount = clsge_StructureSubmitResultsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StructureSubmitResultsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StructureSubmitResultsEN objge_StructureSubmitResultsCond)
{
List<clsge_StructureSubmitResultsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_StructureSubmitResultsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureSubmitResults.AttributeName)
{
if (objge_StructureSubmitResultsCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureSubmitResultsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSubmitResultsCond[strFldName].ToString());
}
else
{
if (objge_StructureSubmitResultsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureSubmitResultsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureSubmitResultsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureSubmitResultsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureSubmitResultsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureSubmitResultsCond[strFldName]));
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
 List<string> arrList = clsge_StructureSubmitResultsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSubmitResultsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureSubmitResultsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StructureSubmitResultsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSubmitResultsDA.SetFldValue(clsge_StructureSubmitResultsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StructureSubmitResultsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSubmitResultsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureSubmitResultsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureSubmitResultsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StructureSubmitResults] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**知识图谱Id*/ 
 strCreateTabCode.Append(" StructureGraphId char(10) not Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**耗时*/ 
 strCreateTabCode.Append(" TakeUpTime varchar(50) Null, "); 
 // /**正确数*/ 
 strCreateTabCode.Append(" CorrectNum int Null, "); 
 // /**错误数*/ 
 strCreateTabCode.Append(" ErrorNum int Null, "); 
 // /**分数*/ 
 strCreateTabCode.Append(" Fraction int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 结构提交结果表(ge_StructureSubmitResults)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StructureSubmitResults : clsCommFun4BL
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
clsge_StructureSubmitResultsBL.ReFreshThisCache();
}
}

}