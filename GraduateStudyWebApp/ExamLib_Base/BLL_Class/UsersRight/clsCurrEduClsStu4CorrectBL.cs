﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4CorrectBL
 表名:CurrEduClsStu4Correct(01120180)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsCurrEduClsStu4CorrectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObj(this K_IdCurrEduClsStu4Correct_CurrEduClsStu4Correct myKey)
{
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.GetObjByIdCurrEduClsStu4Correct(myKey.Value);
return objCurrEduClsStu4CorrectEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (CheckUniqueness(objCurrEduClsStu4CorrectEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStu4CorrectBL.AddNewRecord)", objCurrEduClsStu4CorrectEN.IdCurrEduCls,objCurrEduClsStu4CorrectEN.IdStu);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.AddNewRecordBySQL2(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
public static bool AddRecordEx(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
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
objCurrEduClsStu4CorrectEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objCurrEduClsStu4CorrectEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],学生流水号(IdStu)=[{1}])已经存在,不能重复!", objCurrEduClsStu4CorrectEN.IdCurrEduCls, objCurrEduClsStu4CorrectEN.IdStu);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCurrEduClsStu4CorrectEN.AddNewRecord();
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (CheckUniqueness(objCurrEduClsStu4CorrectEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStu4CorrectBL.AddNewRecordWithReturnKey)", objCurrEduClsStu4CorrectEN.IdCurrEduCls,objCurrEduClsStu4CorrectEN.IdStu);
throw new Exception(strMsg);
}
try
{
string strKey = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetIdCurrEduClsStu4Correct(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, long lngIdCurrEduClsStu4Correct, string strComparisonOp="")
	{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = lngIdCurrEduClsStu4Correct; //教学班学生_批改作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetIdCurrEduCls(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
}
objCurrEduClsStu4CorrectEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.IdCurrEduCls) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetIdStu(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strIdStu, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStu, 8, conCurrEduClsStu4Correct.IdStu);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStu, 8, conCurrEduClsStu4Correct.IdStu);
}
objCurrEduClsStu4CorrectEN.IdStu = strIdStu; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.IdStu) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.IdStu, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.IdStu] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetRightId(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, conCurrEduClsStu4Correct.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, conCurrEduClsStu4Correct.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, conCurrEduClsStu4Correct.RightId);
}
objCurrEduClsStu4CorrectEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.RightId) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.RightId, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.RightId] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetSchoolTerm(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
}
objCurrEduClsStu4CorrectEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.SchoolTerm) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetSchoolYear(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduClsStu4Correct.SchoolYear);
}
objCurrEduClsStu4CorrectEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.SchoolYear) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetModifyDate(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduClsStu4Correct.ModifyDate);
}
objCurrEduClsStu4CorrectEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.ModifyDate) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.ModifyDate, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyDate] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetModifyUserID(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strModifyUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conCurrEduClsStu4Correct.ModifyUserID);
}
objCurrEduClsStu4CorrectEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.ModifyUserID) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.ModifyUserID, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyUserID] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsStu4CorrectEN SetMemo(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduClsStu4Correct.Memo);
}
objCurrEduClsStu4CorrectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsStu4CorrectEN.dicFldComparisonOp.ContainsKey(conCurrEduClsStu4Correct.Memo) == false)
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp.Add(conCurrEduClsStu4Correct.Memo, strComparisonOp);
}
else
{
objCurrEduClsStu4CorrectEN.dicFldComparisonOp[conCurrEduClsStu4Correct.Memo] = strComparisonOp;
}
}
return objCurrEduClsStu4CorrectEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCurrEduClsStu4CorrectEN.CheckPropertyNew();
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectCond = new clsCurrEduClsStu4CorrectEN();
string strCondition = objCurrEduClsStu4CorrectCond
.SetIdCurrEduClsStu4Correct(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "<>")
.SetIdCurrEduCls(objCurrEduClsStu4CorrectEN.IdCurrEduCls, "=")
.SetIdStu(objCurrEduClsStu4CorrectEN.IdStu, "=")
.GetCombineCondition();
objCurrEduClsStu4CorrectEN._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsStu4CorrectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_id_Stu)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCurrEduClsStu4CorrectEN.Update();
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
 /// <param name = "objCurrEduClsStu4Correct">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4Correct)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectCond = new clsCurrEduClsStu4CorrectEN();
string strCondition = objCurrEduClsStu4CorrectCond
.SetIdCurrEduCls(objCurrEduClsStu4Correct.IdCurrEduCls, "=")
.SetIdStu(objCurrEduClsStu4Correct.IdStu, "=")
.GetCombineCondition();
objCurrEduClsStu4Correct._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsStu4CorrectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCurrEduClsStu4Correct.IdCurrEduClsStu4Correct = clsCurrEduClsStu4CorrectBL.GetFirstID_S(strCondition);
objCurrEduClsStu4Correct.UpdateWithCondition(strCondition);
}
else
{
objCurrEduClsStu4Correct.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.UpdateBySql2(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.UpdateBySql2(objCurrEduClsStu4CorrectEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.UpdateBySqlWithCondition(objCurrEduClsStu4CorrectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.UpdateBySqlWithConditionTransaction(objCurrEduClsStu4CorrectEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
try
{
int intRecNum = clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.DelRecord(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <param name = "objCurrEduClsStu4CorrectENT">目标对象</param>
 public static void CopyTo(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS, clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT)
{
try
{
objCurrEduClsStu4CorrectENT.IdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectENS.IdCurrEduClsStu4Correct; //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectENT.IdCurrEduCls = objCurrEduClsStu4CorrectENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStu4CorrectENT.IdStu = objCurrEduClsStu4CorrectENS.IdStu; //学生流水号
objCurrEduClsStu4CorrectENT.RightId = objCurrEduClsStu4CorrectENS.RightId; //权限编号
objCurrEduClsStu4CorrectENT.SchoolTerm = objCurrEduClsStu4CorrectENS.SchoolTerm; //学期
objCurrEduClsStu4CorrectENT.SchoolYear = objCurrEduClsStu4CorrectENS.SchoolYear; //学年
objCurrEduClsStu4CorrectENT.ModifyDate = objCurrEduClsStu4CorrectENS.ModifyDate; //修改日期
objCurrEduClsStu4CorrectENT.ModifyUserID = objCurrEduClsStu4CorrectENS.ModifyUserID; //修改人
objCurrEduClsStu4CorrectENT.Memo = objCurrEduClsStu4CorrectENS.Memo; //备注
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsStu4CorrectEN:objCurrEduClsStu4CorrectENT</returns>
 public static clsCurrEduClsStu4CorrectEN CopyTo(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS)
{
try
{
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT = new clsCurrEduClsStu4CorrectEN()
{
IdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectENS.IdCurrEduClsStu4Correct, //教学班学生_批改作业流水号
IdCurrEduCls = objCurrEduClsStu4CorrectENS.IdCurrEduCls, //教学班流水号
IdStu = objCurrEduClsStu4CorrectENS.IdStu, //学生流水号
RightId = objCurrEduClsStu4CorrectENS.RightId, //权限编号
SchoolTerm = objCurrEduClsStu4CorrectENS.SchoolTerm, //学期
SchoolYear = objCurrEduClsStu4CorrectENS.SchoolYear, //学年
ModifyDate = objCurrEduClsStu4CorrectENS.ModifyDate, //修改日期
ModifyUserID = objCurrEduClsStu4CorrectENS.ModifyUserID, //修改人
Memo = objCurrEduClsStu4CorrectENS.Memo, //备注
};
 return objCurrEduClsStu4CorrectENT;
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
public static void CheckPropertyNew(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 clsCurrEduClsStu4CorrectBL.CurrEduClsStu4CorrectDA.CheckProperty4Condition(objCurrEduClsStu4CorrectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct) == true)
{
string strComparisonOpIdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct, objCurrEduClsStu4CorrectCond.IdCurrEduClsStu4Correct, strComparisonOpIdCurrEduClsStu4Correct);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.IdCurrEduCls, objCurrEduClsStu4CorrectCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.IdStu) == true)
{
string strComparisonOpIdStu = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.IdStu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.IdStu, objCurrEduClsStu4CorrectCond.IdStu, strComparisonOpIdStu);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.RightId) == true)
{
string strComparisonOpRightId = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.RightId, objCurrEduClsStu4CorrectCond.RightId, strComparisonOpRightId);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.SchoolTerm, objCurrEduClsStu4CorrectCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.SchoolYear, objCurrEduClsStu4CorrectCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.ModifyDate) == true)
{
string strComparisonOpModifyDate = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.ModifyDate, objCurrEduClsStu4CorrectCond.ModifyDate, strComparisonOpModifyDate);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID) == true)
{
string strComparisonOpModifyUserID = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.ModifyUserID, objCurrEduClsStu4CorrectCond.ModifyUserID, strComparisonOpModifyUserID);
}
if (objCurrEduClsStu4CorrectCond.IsUpdated(conCurrEduClsStu4Correct.Memo) == true)
{
string strComparisonOpMemo = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[conCurrEduClsStu4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduClsStu4Correct.Memo, objCurrEduClsStu4CorrectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CurrEduClsStu4Correct(教学班学生_批改作业), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStu4CorrectEN == null) return true;
if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
}
 if (objCurrEduClsStu4CorrectEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null", objCurrEduClsStu4CorrectEN.IdStu);
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStu4CorrectEN.IdStu);
}
if (clsCurrEduClsStu4CorrectBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCurrEduClsStu4Correct !=  {0}", objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStu4CorrectEN.IdStu);
if (clsCurrEduClsStu4CorrectBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CurrEduClsStu4Correct(教学班学生_批改作业), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsStu4CorrectEN == null) return "";
if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
}
 if (objCurrEduClsStu4CorrectEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null", objCurrEduClsStu4CorrectEN.IdStu);
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStu4CorrectEN.IdStu);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCurrEduClsStu4Correct !=  {0}", objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStu4CorrectEN.IdStu);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduClsStu4Correct
{
public virtual bool UpdRelaTabDate(long lngIdCurrEduClsStu4Correct, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsStu4CorrectBL
{
public static RelatedActions_CurrEduClsStu4Correct relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduClsStu4CorrectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduClsStu4CorrectDA CurrEduClsStu4CorrectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduClsStu4CorrectDA();
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
 public clsCurrEduClsStu4CorrectBL()
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
if (string.IsNullOrEmpty(clsCurrEduClsStu4CorrectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsStu4CorrectEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduClsStu4Correct(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduClsStu4CorrectDA.GetDataTable_CurrEduClsStu4Correct(strWhereCond);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable(strWhereCond);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduClsStu4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsStu4CorrectLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByIdCurrEduClsStu4CorrectLst(List<long> arrIdCurrEduClsStu4CorrectLst)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsStu4CorrectLst);
 string strWhereCond = string.Format("IdCurrEduClsStu4Correct in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsStu4CorrectLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduClsStu4CorrectEN> GetObjLstByIdCurrEduClsStu4CorrectLstCache(List<long> arrIdCurrEduClsStu4CorrectLst)
{
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Sel =
arrCurrEduClsStu4CorrectObjLstCache
.Where(x => arrIdCurrEduClsStu4CorrectLst.Contains(x.IdCurrEduClsStu4Correct));
return arrCurrEduClsStu4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduClsStu4CorrectEN> GetSubObjLstCache(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectCond)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsStu4Correct.AttributeName)
{
if (objCurrEduClsStu4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsStu4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStu4CorrectCond[strFldName].ToString());
}
else
{
if (objCurrEduClsStu4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStu4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsStu4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStu4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStu4CorrectCond[strFldName]));
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
List<clsCurrEduClsStu4CorrectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduClsStu4CorrectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduClsStu4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
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
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
public static List<clsCurrEduClsStu4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduClsStu4Correct(ref clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
bool bolResult = CurrEduClsStu4CorrectDA.GetCurrEduClsStu4Correct(ref objCurrEduClsStu4CorrectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjByIdCurrEduClsStu4Correct(long lngIdCurrEduClsStu4Correct)
{
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = CurrEduClsStu4CorrectDA.GetObjByIdCurrEduClsStu4Correct(lngIdCurrEduClsStu4Correct);
return objCurrEduClsStu4CorrectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduClsStu4CorrectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = CurrEduClsStu4CorrectDA.GetFirstObj(strWhereCond);
 return objCurrEduClsStu4CorrectEN;
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
public static clsCurrEduClsStu4CorrectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = CurrEduClsStu4CorrectDA.GetObjByDataRow(objRow);
 return objCurrEduClsStu4CorrectEN;
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
public static clsCurrEduClsStu4CorrectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = CurrEduClsStu4CorrectDA.GetObjByDataRow(objRow);
 return objCurrEduClsStu4CorrectEN;
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
 /// <param name = "lngIdCurrEduClsStu4Correct">所给的关键字</param>
 /// <param name = "lstCurrEduClsStu4CorrectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjByIdCurrEduClsStu4CorrectFromList(long lngIdCurrEduClsStu4Correct, List<clsCurrEduClsStu4CorrectEN> lstCurrEduClsStu4CorrectObjLst)
{
foreach (clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN in lstCurrEduClsStu4CorrectObjLst)
{
if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == lngIdCurrEduClsStu4Correct)
{
return objCurrEduClsStu4CorrectEN;
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
 long lngIdCurrEduClsStu4Correct;
 try
 {
 lngIdCurrEduClsStu4Correct = new clsCurrEduClsStu4CorrectDA().GetFirstID(strWhereCond);
 return lngIdCurrEduClsStu4Correct;
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
 arrList = CurrEduClsStu4CorrectDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduClsStu4CorrectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCurrEduClsStu4Correct)
{
//检测记录是否存在
bool bolIsExist = CurrEduClsStu4CorrectDA.IsExist(lngIdCurrEduClsStu4Correct);
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
 bolIsExist = clsCurrEduClsStu4CorrectDA.IsExistTable();
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
 bolIsExist = CurrEduClsStu4CorrectDA.IsExistTable(strTabName);
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (objCurrEduClsStu4CorrectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStu4CorrectBL.AddNewRecordBySql2)", objCurrEduClsStu4CorrectEN.IdCurrEduCls,objCurrEduClsStu4CorrectEN.IdStu);
throw new Exception(strMsg);
}
try
{
bool bolResult = CurrEduClsStu4CorrectDA.AddNewRecordBySQL2(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
if (objCurrEduClsStu4CorrectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clsCurrEduClsStu4CorrectBL.AddNewRecordBySql2WithReturnKey)", objCurrEduClsStu4CorrectEN.IdCurrEduCls,objCurrEduClsStu4CorrectEN.IdStu);
throw new Exception(strMsg);
}
try
{
string strKey = CurrEduClsStu4CorrectDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
try
{
bool bolResult = CurrEduClsStu4CorrectDA.Update(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduClsStu4CorrectDA.UpdateBySql2(objCurrEduClsStu4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsStu4CorrectBL.ReFreshCache();

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
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
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdCurrEduClsStu4Correct)
{
try
{
 clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = clsCurrEduClsStu4CorrectBL.GetObjByIdCurrEduClsStu4Correct(lngIdCurrEduClsStu4Correct);

if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct, "SetUpdDate");
}
if (objCurrEduClsStu4CorrectEN != null)
{
int intRecNum = CurrEduClsStu4CorrectDA.DelRecord(lngIdCurrEduClsStu4Correct);
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
/// <param name="lngIdCurrEduClsStu4Correct">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdCurrEduClsStu4Correct )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
//删除与表:[CurrEduClsStu4Correct]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct,
//lngIdCurrEduClsStu4Correct);
//        clsCurrEduClsStu4CorrectBL.DelCurrEduClsStu4CorrectsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsStu4CorrectBL.DelRecord(lngIdCurrEduClsStu4Correct, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsStu4CorrectBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCurrEduClsStu4Correct, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdCurrEduClsStu4Correct, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(lngIdCurrEduClsStu4Correct, "UpdRelaTabDate");
}
bool bolResult = CurrEduClsStu4CorrectDA.DelRecord(lngIdCurrEduClsStu4Correct,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCurrEduClsStu4CorrectLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduClsStu4Corrects(List<string> arrIdCurrEduClsStu4CorrectLst)
{
if (arrIdCurrEduClsStu4CorrectLst.Count == 0) return 0;
try
{
if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
foreach (var strIdCurrEduClsStu4Correct in arrIdCurrEduClsStu4CorrectLst)
{
long lngIdCurrEduClsStu4Correct = long.Parse(strIdCurrEduClsStu4Correct);
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(lngIdCurrEduClsStu4Correct, "UpdRelaTabDate");
}
}
int intDelRecNum = CurrEduClsStu4CorrectDA.DelCurrEduClsStu4Correct(arrIdCurrEduClsStu4CorrectLst);
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
public static int DelCurrEduClsStu4CorrectsByCond(string strWhereCond)
{
try
{
if (clsCurrEduClsStu4CorrectBL.relatedActions != null)
{
List<string> arrIdCurrEduClsStu4Correct = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCurrEduClsStu4Correct in arrIdCurrEduClsStu4Correct)
{
long lngIdCurrEduClsStu4Correct = long.Parse(strIdCurrEduClsStu4Correct);
clsCurrEduClsStu4CorrectBL.relatedActions.UpdRelaTabDate(lngIdCurrEduClsStu4Correct, "UpdRelaTabDate");
}
}
int intRecNum = CurrEduClsStu4CorrectDA.DelCurrEduClsStu4Correct(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduClsStu4Correct]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdCurrEduClsStu4Correct">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdCurrEduClsStu4Correct)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
//删除与表:[CurrEduClsStu4Correct]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsStu4CorrectBL.DelRecord(lngIdCurrEduClsStu4Correct, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsStu4CorrectBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCurrEduClsStu4Correct, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <param name = "objCurrEduClsStu4CorrectENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS, clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT)
{
try
{
objCurrEduClsStu4CorrectENT.IdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectENS.IdCurrEduClsStu4Correct; //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectENT.IdCurrEduCls = objCurrEduClsStu4CorrectENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStu4CorrectENT.IdStu = objCurrEduClsStu4CorrectENS.IdStu; //学生流水号
objCurrEduClsStu4CorrectENT.RightId = objCurrEduClsStu4CorrectENS.RightId; //权限编号
objCurrEduClsStu4CorrectENT.SchoolTerm = objCurrEduClsStu4CorrectENS.SchoolTerm; //学期
objCurrEduClsStu4CorrectENT.SchoolYear = objCurrEduClsStu4CorrectENS.SchoolYear; //学年
objCurrEduClsStu4CorrectENT.ModifyDate = objCurrEduClsStu4CorrectENS.ModifyDate; //修改日期
objCurrEduClsStu4CorrectENT.ModifyUserID = objCurrEduClsStu4CorrectENS.ModifyUserID; //修改人
objCurrEduClsStu4CorrectENT.Memo = objCurrEduClsStu4CorrectENS.Memo; //备注
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
 /// <param name = "objCurrEduClsStu4CorrectEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
try
{
objCurrEduClsStu4CorrectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduClsStu4CorrectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct; //教学班学生_批改作业流水号
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls == "[null]" ? null :  objCurrEduClsStu4CorrectEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.IdStu, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.IdStu = objCurrEduClsStu4CorrectEN.IdStu == "[null]" ? null :  objCurrEduClsStu4CorrectEN.IdStu; //学生流水号
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.RightId = objCurrEduClsStu4CorrectEN.RightId; //权限编号
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.SchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm == "[null]" ? null :  objCurrEduClsStu4CorrectEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.SchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear == "[null]" ? null :  objCurrEduClsStu4CorrectEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.ModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate == "[null]" ? null :  objCurrEduClsStu4CorrectEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.ModifyUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.ModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID == "[null]" ? null :  objCurrEduClsStu4CorrectEN.ModifyUserID; //修改人
}
if (arrFldSet.Contains(conCurrEduClsStu4Correct.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsStu4CorrectEN.Memo = objCurrEduClsStu4CorrectEN.Memo == "[null]" ? null :  objCurrEduClsStu4CorrectEN.Memo; //备注
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
 /// <param name = "objCurrEduClsStu4CorrectEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
try
{
if (objCurrEduClsStu4CorrectEN.IdCurrEduCls == "[null]") objCurrEduClsStu4CorrectEN.IdCurrEduCls = null; //教学班流水号
if (objCurrEduClsStu4CorrectEN.IdStu == "[null]") objCurrEduClsStu4CorrectEN.IdStu = null; //学生流水号
if (objCurrEduClsStu4CorrectEN.SchoolTerm == "[null]") objCurrEduClsStu4CorrectEN.SchoolTerm = null; //学期
if (objCurrEduClsStu4CorrectEN.SchoolYear == "[null]") objCurrEduClsStu4CorrectEN.SchoolYear = null; //学年
if (objCurrEduClsStu4CorrectEN.ModifyDate == "[null]") objCurrEduClsStu4CorrectEN.ModifyDate = null; //修改日期
if (objCurrEduClsStu4CorrectEN.ModifyUserID == "[null]") objCurrEduClsStu4CorrectEN.ModifyUserID = null; //修改人
if (objCurrEduClsStu4CorrectEN.Memo == "[null]") objCurrEduClsStu4CorrectEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 CurrEduClsStu4CorrectDA.CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 CurrEduClsStu4CorrectDA.CheckProperty4Condition(objCurrEduClsStu4CorrectEN);
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
if (clsCurrEduClsStu4CorrectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsStu4CorrectBL没有刷新缓存机制(clsCurrEduClsStu4CorrectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduClsStu4Correct");
//if (arrCurrEduClsStu4CorrectObjLstCache == null)
//{
//arrCurrEduClsStu4CorrectObjLstCache = CurrEduClsStu4CorrectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsStu4CorrectEN GetObjByIdCurrEduClsStu4CorrectCache(long lngIdCurrEduClsStu4Correct)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLst_Sel =
arrCurrEduClsStu4CorrectObjLstCache
.Where(x=> x.IdCurrEduClsStu4Correct == lngIdCurrEduClsStu4Correct 
);
if (arrCurrEduClsStu4CorrectObjLst_Sel.Count() == 0)
{
   clsCurrEduClsStu4CorrectEN obj = clsCurrEduClsStu4CorrectBL.GetObjByIdCurrEduClsStu4Correct(lngIdCurrEduClsStu4Correct);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCurrEduClsStu4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetAllCurrEduClsStu4CorrectObjLstCache()
{
//获取缓存中的对象列表
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLstCache = GetObjLstCache(); 
return arrCurrEduClsStu4CorrectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsStu4CorrectEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName);
List<clsCurrEduClsStu4CorrectEN> arrCurrEduClsStu4CorrectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCurrEduClsStu4CorrectObjLstCache;
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
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName);
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
if (clsCurrEduClsStu4CorrectBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCurrEduClsStu4CorrectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCurrEduClsStu4CorrectBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CurrEduClsStu4Correct(教学班学生_批改作业)
 /// 唯一性条件:id_CurrEduCls_id_Stu
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检测记录是否存在
string strResult = CurrEduClsStu4CorrectDA.GetUniCondStr(objCurrEduClsStu4CorrectEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdCurrEduClsStu4Correct)
{
if (strInFldName != conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduClsStu4Correct.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduClsStu4Correct.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduClsStu4Correct = clsCurrEduClsStu4CorrectBL.GetObjByIdCurrEduClsStu4CorrectCache(lngIdCurrEduClsStu4Correct);
if (objCurrEduClsStu4Correct == null) return "";
return objCurrEduClsStu4Correct[strOutFldName].ToString();
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
int intRecCount = clsCurrEduClsStu4CorrectDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduClsStu4CorrectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduClsStu4CorrectDA.GetRecCount();
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
int intRecCount = clsCurrEduClsStu4CorrectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectCond)
{
List<clsCurrEduClsStu4CorrectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCurrEduClsStu4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduClsStu4Correct.AttributeName)
{
if (objCurrEduClsStu4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsStu4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStu4CorrectCond[strFldName].ToString());
}
else
{
if (objCurrEduClsStu4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsStu4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsStu4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsStu4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsStu4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStu4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsStu4CorrectCond[strFldName]));
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
 List<string> arrList = clsCurrEduClsStu4CorrectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsStu4CorrectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsStu4CorrectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CurrEduClsStu4CorrectDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsStu4CorrectDA.SetFldValue(clsCurrEduClsStu4CorrectEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CurrEduClsStu4CorrectDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsStu4CorrectDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsStu4CorrectDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsStu4CorrectDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduClsStu4Correct] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班学生_批改作业流水号*/ 
 strCreateTabCode.Append(" IdCurrEduClsStu4Correct bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStu char(8) Null, "); 
 // /**权限编号*/ 
 strCreateTabCode.Append(" RightId char(8) not Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserID varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduClsStu4Correct : clsCommFun4BL
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
clsCurrEduClsStu4CorrectBL.ReFreshThisCache();
}
}

}