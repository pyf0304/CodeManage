﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointLikeLogBL
 表名:zx_ViewpointLikeLog(01120858)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:05:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clszx_ViewpointLikeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointLikeLogEN GetObj(this K_ViewpointLikeLogId_zx_ViewpointLikeLog myKey)
{
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.GetObjByViewpointLikeLogId(myKey.Value);
return objzx_ViewpointLikeLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
if (CheckUniqueness(objzx_ViewpointLikeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!观点点赞Id = [{0}]的数据已经存在!(in clszx_ViewpointLikeLogBL.AddNewRecord)", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.AddNewRecordBySQL2(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
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
objzx_ViewpointLikeLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ViewpointLikeLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(观点点赞Id(ViewpointLikeLogId)=[{0}])已经存在,不能重复!", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ViewpointLikeLogEN.AddNewRecord();
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
if (CheckUniqueness(objzx_ViewpointLikeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!观点点赞Id = [{0}]的数据已经存在!(in clszx_ViewpointLikeLogBL.AddNewRecordWithReturnKey)", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointLikeLogEN SetViewpointLikeLogId(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, long lngViewpointLikeLogId, string strComparisonOp="")
	{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = lngViewpointLikeLogId; //观点点赞Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointLikeLog.ViewpointLikeLogId) == false)
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp.Add(conzx_ViewpointLikeLog.ViewpointLikeLogId, strComparisonOp);
}
else
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp[conzx_ViewpointLikeLog.ViewpointLikeLogId] = strComparisonOp;
}
}
return objzx_ViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointLikeLogEN SetzxViewpointId(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strzxViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointId, 8, conzx_ViewpointLikeLog.zxViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointId, 8, conzx_ViewpointLikeLog.zxViewpointId);
}
objzx_ViewpointLikeLogEN.zxViewpointId = strzxViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointLikeLog.zxViewpointId) == false)
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp.Add(conzx_ViewpointLikeLog.zxViewpointId, strComparisonOp);
}
else
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp[conzx_ViewpointLikeLog.zxViewpointId] = strComparisonOp;
}
}
return objzx_ViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointLikeLogEN SetUpdDate(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ViewpointLikeLog.UpdDate);
}
objzx_ViewpointLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointLikeLog.UpdDate) == false)
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp.Add(conzx_ViewpointLikeLog.UpdDate, strComparisonOp);
}
else
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp[conzx_ViewpointLikeLog.UpdDate] = strComparisonOp;
}
}
return objzx_ViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointLikeLogEN SetUpdUserId(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conzx_ViewpointLikeLog.UpdUserId);
}
objzx_ViewpointLikeLogEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointLikeLog.UpdUserId) == false)
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp.Add(conzx_ViewpointLikeLog.UpdUserId, strComparisonOp);
}
else
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp[conzx_ViewpointLikeLog.UpdUserId] = strComparisonOp;
}
}
return objzx_ViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointLikeLogEN SetMemo(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ViewpointLikeLog.Memo);
}
objzx_ViewpointLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointLikeLog.Memo) == false)
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp.Add(conzx_ViewpointLikeLog.Memo, strComparisonOp);
}
else
{
objzx_ViewpointLikeLogEN.dicFldComparisonOp[conzx_ViewpointLikeLog.Memo] = strComparisonOp;
}
}
return objzx_ViewpointLikeLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ViewpointLikeLogEN.CheckPropertyNew();
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogCond = new clszx_ViewpointLikeLogEN();
string strCondition = objzx_ViewpointLikeLogCond
.SetViewpointLikeLogId(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "<>")
.SetViewpointLikeLogId(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "=")
.GetCombineCondition();
objzx_ViewpointLikeLogEN._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointLikeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewpointLikeLogId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ViewpointLikeLogEN.Update();
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
 /// <param name = "objzx_ViewpointLikeLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogCond = new clszx_ViewpointLikeLogEN();
string strCondition = objzx_ViewpointLikeLogCond
.SetViewpointLikeLogId(objzx_ViewpointLikeLog.ViewpointLikeLogId, "=")
.GetCombineCondition();
objzx_ViewpointLikeLog._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointLikeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ViewpointLikeLog.ViewpointLikeLogId = clszx_ViewpointLikeLogBL.GetFirstID_S(strCondition);
objzx_ViewpointLikeLog.UpdateWithCondition(strCondition);
}
else
{
objzx_ViewpointLikeLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.UpdateBySql2(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.UpdateBySql2(objzx_ViewpointLikeLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.UpdateBySqlWithCondition(objzx_ViewpointLikeLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.UpdateBySqlWithConditionTransaction(objzx_ViewpointLikeLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "lngViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
try
{
int intRecNum = clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.DelRecord(objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <param name = "objzx_ViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENS, clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENT)
{
try
{
objzx_ViewpointLikeLogENT.ViewpointLikeLogId = objzx_ViewpointLikeLogENS.ViewpointLikeLogId; //观点点赞Id
objzx_ViewpointLikeLogENT.zxViewpointId = objzx_ViewpointLikeLogENS.zxViewpointId; //观点Id
objzx_ViewpointLikeLogENT.UpdDate = objzx_ViewpointLikeLogENS.UpdDate; //修改日期
objzx_ViewpointLikeLogENT.UpdUserId = objzx_ViewpointLikeLogENS.UpdUserId; //修改用户Id
objzx_ViewpointLikeLogENT.Memo = objzx_ViewpointLikeLogENS.Memo; //备注
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
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointLikeLogEN:objzx_ViewpointLikeLogENT</returns>
 public static clszx_ViewpointLikeLogEN CopyTo(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENS)
{
try
{
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENT = new clszx_ViewpointLikeLogEN()
{
ViewpointLikeLogId = objzx_ViewpointLikeLogENS.ViewpointLikeLogId, //观点点赞Id
zxViewpointId = objzx_ViewpointLikeLogENS.zxViewpointId, //观点Id
UpdDate = objzx_ViewpointLikeLogENS.UpdDate, //修改日期
UpdUserId = objzx_ViewpointLikeLogENS.UpdUserId, //修改用户Id
Memo = objzx_ViewpointLikeLogENS.Memo, //备注
};
 return objzx_ViewpointLikeLogENT;
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
public static void CheckPropertyNew(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.CheckPropertyNew(objzx_ViewpointLikeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 clszx_ViewpointLikeLogBL.zx_ViewpointLikeLogDA.CheckProperty4Condition(objzx_ViewpointLikeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ViewpointLikeLogCond.IsUpdated(conzx_ViewpointLikeLog.ViewpointLikeLogId) == true)
{
string strComparisonOpViewpointLikeLogId = objzx_ViewpointLikeLogCond.dicFldComparisonOp[conzx_ViewpointLikeLog.ViewpointLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointLikeLog.ViewpointLikeLogId, objzx_ViewpointLikeLogCond.ViewpointLikeLogId, strComparisonOpViewpointLikeLogId);
}
if (objzx_ViewpointLikeLogCond.IsUpdated(conzx_ViewpointLikeLog.zxViewpointId) == true)
{
string strComparisonOpzxViewpointId = objzx_ViewpointLikeLogCond.dicFldComparisonOp[conzx_ViewpointLikeLog.zxViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointLikeLog.zxViewpointId, objzx_ViewpointLikeLogCond.zxViewpointId, strComparisonOpzxViewpointId);
}
if (objzx_ViewpointLikeLogCond.IsUpdated(conzx_ViewpointLikeLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ViewpointLikeLogCond.dicFldComparisonOp[conzx_ViewpointLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointLikeLog.UpdDate, objzx_ViewpointLikeLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ViewpointLikeLogCond.IsUpdated(conzx_ViewpointLikeLog.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objzx_ViewpointLikeLogCond.dicFldComparisonOp[conzx_ViewpointLikeLog.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointLikeLog.UpdUserId, objzx_ViewpointLikeLogCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objzx_ViewpointLikeLogCond.IsUpdated(conzx_ViewpointLikeLog.Memo) == true)
{
string strComparisonOpMemo = objzx_ViewpointLikeLogCond.dicFldComparisonOp[conzx_ViewpointLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointLikeLog.Memo, objzx_ViewpointLikeLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ViewpointLikeLog(中学观点点赞表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointLikeLogId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointLikeLogEN == null) return true;
if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
if (clszx_ViewpointLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointLikeLogId !=  {0}", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
if (clszx_ViewpointLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ViewpointLikeLog(中学观点点赞表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointLikeLogId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointLikeLogEN == null) return "";
if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointLikeLogId !=  {0}", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
 sbCondition.AppendFormat(" and ViewpointLikeLogId = '{0}'", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ViewpointLikeLog
{
public virtual bool UpdRelaTabDate(long lngViewpointLikeLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学观点点赞表(zx_ViewpointLikeLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ViewpointLikeLogBL
{
public static RelatedActions_zx_ViewpointLikeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ViewpointLikeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ViewpointLikeLogDA zx_ViewpointLikeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ViewpointLikeLogDA();
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
 public clszx_ViewpointLikeLogBL()
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
if (string.IsNullOrEmpty(clszx_ViewpointLikeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointLikeLogEN._ConnectString);
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
public static DataTable GetDataTable_zx_ViewpointLikeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ViewpointLikeLogDA.GetDataTable_zx_ViewpointLikeLog(strWhereCond);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable(strWhereCond);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ViewpointLikeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetObjLstByViewpointLikeLogIdLst(List<long> arrViewpointLikeLogIdLst)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointLikeLogIdLst);
 string strWhereCond = string.Format("ViewpointLikeLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ViewpointLikeLogEN> GetObjLstByViewpointLikeLogIdLstCache(List<long> arrViewpointLikeLogIdLst)
{
string strKey = string.Format("{0}", clszx_ViewpointLikeLogEN._CurrTabName);
List<clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLst_Sel =
arrzx_ViewpointLikeLogObjLstCache
.Where(x => arrViewpointLikeLogIdLst.Contains(x.ViewpointLikeLogId));
return arrzx_ViewpointLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetObjLst(string strWhereCond)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
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
public static List<clszx_ViewpointLikeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ViewpointLikeLogEN> GetSubObjLstCache(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogCond)
{
List<clszx_ViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointLikeLog.AttributeName)
{
if (objzx_ViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointLikeLogCond[strFldName]));
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
public static List<clszx_ViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
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
public static List<clszx_ViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
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
List<clszx_ViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
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
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
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
public static List<clszx_ViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
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
public static List<clszx_ViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ViewpointLikeLogEN> arrObjLst = new List<clszx_ViewpointLikeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = new clszx_ViewpointLikeLogEN();
try
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = Int32.Parse(objRow[conzx_ViewpointLikeLog.ViewpointLikeLogId].ToString().Trim()); //观点点赞Id
objzx_ViewpointLikeLogEN.zxViewpointId = objRow[conzx_ViewpointLikeLog.zxViewpointId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointLikeLogEN.UpdDate = objRow[conzx_ViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointLikeLogEN.UpdUserId = objRow[conzx_ViewpointLikeLog.UpdUserId] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.UpdUserId].ToString().Trim(); //修改用户Id
objzx_ViewpointLikeLogEN.Memo = objRow[conzx_ViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointLikeLogEN.ViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointLikeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ViewpointLikeLog(ref clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
bool bolResult = zx_ViewpointLikeLogDA.Getzx_ViewpointLikeLog(ref objzx_ViewpointLikeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointLikeLogEN GetObjByViewpointLikeLogId(long lngViewpointLikeLogId)
{
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = zx_ViewpointLikeLogDA.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
return objzx_ViewpointLikeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ViewpointLikeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = zx_ViewpointLikeLogDA.GetFirstObj(strWhereCond);
 return objzx_ViewpointLikeLogEN;
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
public static clszx_ViewpointLikeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = zx_ViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objzx_ViewpointLikeLogEN;
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
public static clszx_ViewpointLikeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = zx_ViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objzx_ViewpointLikeLogEN;
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
 /// <param name = "lngViewpointLikeLogId">所给的关键字</param>
 /// <param name = "lstzx_ViewpointLikeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointLikeLogEN GetObjByViewpointLikeLogIdFromList(long lngViewpointLikeLogId, List<clszx_ViewpointLikeLogEN> lstzx_ViewpointLikeLogObjLst)
{
foreach (clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN in lstzx_ViewpointLikeLogObjLst)
{
if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == lngViewpointLikeLogId)
{
return objzx_ViewpointLikeLogEN;
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
 long lngViewpointLikeLogId;
 try
 {
 lngViewpointLikeLogId = new clszx_ViewpointLikeLogDA().GetFirstID(strWhereCond);
 return lngViewpointLikeLogId;
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
 arrList = zx_ViewpointLikeLogDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ViewpointLikeLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointLikeLogId)
{
//检测记录是否存在
bool bolIsExist = zx_ViewpointLikeLogDA.IsExist(lngViewpointLikeLogId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngViewpointLikeLogId">观点点赞Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngViewpointLikeLogId, string strOpUser)
{
clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = clszx_ViewpointLikeLogBL.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
objzx_ViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_ViewpointLikeLogBL.UpdateBySql2(objzx_ViewpointLikeLogEN);
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
 bolIsExist = clszx_ViewpointLikeLogDA.IsExistTable();
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
 bolIsExist = zx_ViewpointLikeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
if (objzx_ViewpointLikeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点点赞Id = [{0}]的数据已经存在!(in clszx_ViewpointLikeLogBL.AddNewRecordBySql2)", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ViewpointLikeLogDA.AddNewRecordBySQL2(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
if (objzx_ViewpointLikeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点点赞Id = [{0}]的数据已经存在!(in clszx_ViewpointLikeLogBL.AddNewRecordBySql2WithReturnKey)", objzx_ViewpointLikeLogEN.ViewpointLikeLogId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ViewpointLikeLogDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
try
{
bool bolResult = zx_ViewpointLikeLogDA.Update(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 if (objzx_ViewpointLikeLogEN.ViewpointLikeLogId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ViewpointLikeLogDA.UpdateBySql2(objzx_ViewpointLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointLikeLogBL.ReFreshCache();

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
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
 /// <param name = "lngViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngViewpointLikeLogId)
{
try
{
 clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN = clszx_ViewpointLikeLogBL.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);

if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(objzx_ViewpointLikeLogEN.ViewpointLikeLogId, "SetUpdDate");
}
if (objzx_ViewpointLikeLogEN != null)
{
int intRecNum = zx_ViewpointLikeLogDA.DelRecord(lngViewpointLikeLogId);
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
/// <param name="lngViewpointLikeLogId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngViewpointLikeLogId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointLikeLogDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointLikeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ViewpointLikeLog.ViewpointLikeLogId,
//lngViewpointLikeLogId);
//        clszx_ViewpointLikeLogBL.Delzx_ViewpointLikeLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointLikeLogBL.DelRecord(lngViewpointLikeLogId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointLikeLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointLikeLogId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngViewpointLikeLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngViewpointLikeLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(lngViewpointLikeLogId, "UpdRelaTabDate");
}
bool bolResult = zx_ViewpointLikeLogDA.DelRecord(lngViewpointLikeLogId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewpointLikeLogIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ViewpointLikeLogs(List<string> arrViewpointLikeLogIdLst)
{
if (arrViewpointLikeLogIdLst.Count == 0) return 0;
try
{
if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
foreach (var strViewpointLikeLogId in arrViewpointLikeLogIdLst)
{
long lngViewpointLikeLogId = long.Parse(strViewpointLikeLogId);
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(lngViewpointLikeLogId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ViewpointLikeLogDA.Delzx_ViewpointLikeLog(arrViewpointLikeLogIdLst);
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
public static int Delzx_ViewpointLikeLogsByCond(string strWhereCond)
{
try
{
if (clszx_ViewpointLikeLogBL.relatedActions != null)
{
List<string> arrViewpointLikeLogId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewpointLikeLogId in arrViewpointLikeLogId)
{
long lngViewpointLikeLogId = long.Parse(strViewpointLikeLogId);
clszx_ViewpointLikeLogBL.relatedActions.UpdRelaTabDate(lngViewpointLikeLogId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ViewpointLikeLogDA.Delzx_ViewpointLikeLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ViewpointLikeLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngViewpointLikeLogId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngViewpointLikeLogId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointLikeLogDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointLikeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointLikeLogBL.DelRecord(lngViewpointLikeLogId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointLikeLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointLikeLogId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ViewpointLikeLogENS">源对象</param>
 /// <param name = "objzx_ViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENS, clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogENT)
{
try
{
objzx_ViewpointLikeLogENT.ViewpointLikeLogId = objzx_ViewpointLikeLogENS.ViewpointLikeLogId; //观点点赞Id
objzx_ViewpointLikeLogENT.zxViewpointId = objzx_ViewpointLikeLogENS.zxViewpointId; //观点Id
objzx_ViewpointLikeLogENT.UpdDate = objzx_ViewpointLikeLogENS.UpdDate; //修改日期
objzx_ViewpointLikeLogENT.UpdUserId = objzx_ViewpointLikeLogENS.UpdUserId; //修改用户Id
objzx_ViewpointLikeLogENT.Memo = objzx_ViewpointLikeLogENS.Memo; //备注
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
 /// <param name = "objzx_ViewpointLikeLogEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
try
{
objzx_ViewpointLikeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ViewpointLikeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ViewpointLikeLog.ViewpointLikeLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointLikeLogEN.ViewpointLikeLogId = objzx_ViewpointLikeLogEN.ViewpointLikeLogId; //观点点赞Id
}
if (arrFldSet.Contains(conzx_ViewpointLikeLog.zxViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointLikeLogEN.zxViewpointId = objzx_ViewpointLikeLogEN.zxViewpointId == "[null]" ? null :  objzx_ViewpointLikeLogEN.zxViewpointId; //观点Id
}
if (arrFldSet.Contains(conzx_ViewpointLikeLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointLikeLogEN.UpdDate = objzx_ViewpointLikeLogEN.UpdDate == "[null]" ? null :  objzx_ViewpointLikeLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ViewpointLikeLog.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointLikeLogEN.UpdUserId = objzx_ViewpointLikeLogEN.UpdUserId == "[null]" ? null :  objzx_ViewpointLikeLogEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conzx_ViewpointLikeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointLikeLogEN.Memo = objzx_ViewpointLikeLogEN.Memo == "[null]" ? null :  objzx_ViewpointLikeLogEN.Memo; //备注
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
 /// <param name = "objzx_ViewpointLikeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
try
{
if (objzx_ViewpointLikeLogEN.zxViewpointId == "[null]") objzx_ViewpointLikeLogEN.zxViewpointId = null; //观点Id
if (objzx_ViewpointLikeLogEN.UpdDate == "[null]") objzx_ViewpointLikeLogEN.UpdDate = null; //修改日期
if (objzx_ViewpointLikeLogEN.UpdUserId == "[null]") objzx_ViewpointLikeLogEN.UpdUserId = null; //修改用户Id
if (objzx_ViewpointLikeLogEN.Memo == "[null]") objzx_ViewpointLikeLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 zx_ViewpointLikeLogDA.CheckPropertyNew(objzx_ViewpointLikeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
 zx_ViewpointLikeLogDA.CheckProperty4Condition(objzx_ViewpointLikeLogEN);
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
if (clszx_ViewpointLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointLikeLogBL没有刷新缓存机制(clszx_ViewpointLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointLikeLogId");
//if (arrzx_ViewpointLikeLogObjLstCache == null)
//{
//arrzx_ViewpointLikeLogObjLstCache = zx_ViewpointLikeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointLikeLogEN GetObjByViewpointLikeLogIdCache(long lngViewpointLikeLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ViewpointLikeLogEN._CurrTabName);
List<clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLst_Sel =
arrzx_ViewpointLikeLogObjLstCache
.Where(x=> x.ViewpointLikeLogId == lngViewpointLikeLogId 
);
if (arrzx_ViewpointLikeLogObjLst_Sel.Count() == 0)
{
   clszx_ViewpointLikeLogEN obj = clszx_ViewpointLikeLogBL.GetObjByViewpointLikeLogId(lngViewpointLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ViewpointLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetAllzx_ViewpointLikeLogObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLstCache = GetObjLstCache(); 
return arrzx_ViewpointLikeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointLikeLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ViewpointLikeLogEN._CurrTabName);
List<clszx_ViewpointLikeLogEN> arrzx_ViewpointLikeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ViewpointLikeLogObjLstCache;
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
string strKey = string.Format("{0}", clszx_ViewpointLikeLogEN._CurrTabName);
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
if (clszx_ViewpointLikeLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ViewpointLikeLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ViewpointLikeLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ViewpointLikeLog(中学观点点赞表)
 /// 唯一性条件:ViewpointLikeLogId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogEN)
{
//检测记录是否存在
string strResult = zx_ViewpointLikeLogDA.GetUniCondStr(objzx_ViewpointLikeLogEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointLikeLogId)
{
if (strInFldName != conzx_ViewpointLikeLog.ViewpointLikeLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ViewpointLikeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ViewpointLikeLog.AttributeName));
throw new Exception(strMsg);
}
var objzx_ViewpointLikeLog = clszx_ViewpointLikeLogBL.GetObjByViewpointLikeLogIdCache(lngViewpointLikeLogId);
if (objzx_ViewpointLikeLog == null) return "";
return objzx_ViewpointLikeLog[strOutFldName].ToString();
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
int intRecCount = clszx_ViewpointLikeLogDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ViewpointLikeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ViewpointLikeLogDA.GetRecCount();
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
int intRecCount = clszx_ViewpointLikeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ViewpointLikeLogEN objzx_ViewpointLikeLogCond)
{
List<clszx_ViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointLikeLog.AttributeName)
{
if (objzx_ViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointLikeLogCond[strFldName]));
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
 List<string> arrList = clszx_ViewpointLikeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointLikeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointLikeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ViewpointLikeLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointLikeLogDA.SetFldValue(clszx_ViewpointLikeLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ViewpointLikeLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointLikeLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointLikeLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointLikeLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ViewpointLikeLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**观点点赞Id*/ 
 strCreateTabCode.Append(" ViewpointLikeLogId bigint primary key identity, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" zxViewpointId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学观点点赞表(zx_ViewpointLikeLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ViewpointLikeLog : clsCommFun4BL
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
clszx_ViewpointLikeLogBL.ReFreshThisCache();
}
}

}