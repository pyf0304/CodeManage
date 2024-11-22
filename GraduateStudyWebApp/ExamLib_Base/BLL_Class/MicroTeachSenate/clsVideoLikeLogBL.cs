﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLikeLogBL
 表名:VideoLikeLog(01120291)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsVideoLikeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoLikeLogEN GetObj(this K_IdVideoLikeLog_VideoLikeLog myKey)
{
clsVideoLikeLogEN objVideoLikeLogEN = clsVideoLikeLogBL.VideoLikeLogDA.GetObjByIdVideoLikeLog(myKey.Value);
return objVideoLikeLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsVideoLikeLogEN objVideoLikeLogEN)
{
if (CheckUniqueness(objVideoLikeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsVideoLikeLogBL.AddNewRecord)", objVideoLikeLogEN.IdCase,objVideoLikeLogEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsVideoLikeLogBL.VideoLikeLogDA.AddNewRecordBySQL2(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
public static bool AddRecordEx(this clsVideoLikeLogEN objVideoLikeLogEN)
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
objVideoLikeLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objVideoLikeLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例流水号(IdCase)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objVideoLikeLogEN.IdCase, objVideoLikeLogEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objVideoLikeLogEN.AddNewRecord();
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsVideoLikeLogEN objVideoLikeLogEN)
{
if (CheckUniqueness(objVideoLikeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsVideoLikeLogBL.AddNewRecordWithReturnKey)", objVideoLikeLogEN.IdCase,objVideoLikeLogEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsVideoLikeLogBL.VideoLikeLogDA.AddNewRecordBySQL2WithReturnKey(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetIdVideoLikeLog(this clsVideoLikeLogEN objVideoLikeLogEN, long lngIdVideoLikeLog, string strComparisonOp="")
	{
objVideoLikeLogEN.IdVideoLikeLog = lngIdVideoLikeLog; //视频点赞日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.IdVideoLikeLog) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.IdVideoLikeLog, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.IdVideoLikeLog] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetFuncModuleId(this clsVideoLikeLogEN objVideoLikeLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conVideoLikeLog.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conVideoLikeLog.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conVideoLikeLog.FuncModuleId);
}
objVideoLikeLogEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.FuncModuleId) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.FuncModuleId, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.FuncModuleId] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetUserId(this clsVideoLikeLogEN objVideoLikeLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conVideoLikeLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conVideoLikeLog.UserId);
}
objVideoLikeLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.UserId) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.UserId, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.UserId] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetIdCase(this clsVideoLikeLogEN objVideoLikeLogEN, string strIdCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCase, conVideoLikeLog.IdCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, conVideoLikeLog.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, conVideoLikeLog.IdCase);
}
objVideoLikeLogEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.IdCase) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.IdCase, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.IdCase] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetLikeDate(this clsVideoLikeLogEN objVideoLikeLogEN, string strLikeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLikeDate, conVideoLikeLog.LikeDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLikeDate, 20, conVideoLikeLog.LikeDate);
}
objVideoLikeLogEN.LikeDate = strLikeDate; //点赞日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.LikeDate) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.LikeDate, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.LikeDate] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetLikeDegree(this clsVideoLikeLogEN objVideoLikeLogEN, int? intLikeDegree, string strComparisonOp="")
	{
objVideoLikeLogEN.LikeDegree = intLikeDegree; //点赞度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.LikeDegree) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.LikeDegree, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.LikeDegree] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsVideoLikeLogEN SetMemo(this clsVideoLikeLogEN objVideoLikeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conVideoLikeLog.Memo);
}
objVideoLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objVideoLikeLogEN.dicFldComparisonOp.ContainsKey(conVideoLikeLog.Memo) == false)
{
objVideoLikeLogEN.dicFldComparisonOp.Add(conVideoLikeLog.Memo, strComparisonOp);
}
else
{
objVideoLikeLogEN.dicFldComparisonOp[conVideoLikeLog.Memo] = strComparisonOp;
}
}
return objVideoLikeLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsVideoLikeLogEN objVideoLikeLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objVideoLikeLogEN.CheckPropertyNew();
clsVideoLikeLogEN objVideoLikeLogCond = new clsVideoLikeLogEN();
string strCondition = objVideoLikeLogCond
.SetIdVideoLikeLog(objVideoLikeLogEN.IdVideoLikeLog, "<>")
.SetIdCase(objVideoLikeLogEN.IdCase, "=")
.SetUserId(objVideoLikeLogEN.UserId, "=")
.GetCombineCondition();
objVideoLikeLogEN._IsCheckProperty = true;
bool bolIsExist = clsVideoLikeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(Id_Case_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objVideoLikeLogEN.Update();
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
 /// <param name = "objVideoLikeLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsVideoLikeLogEN objVideoLikeLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsVideoLikeLogEN objVideoLikeLogCond = new clsVideoLikeLogEN();
string strCondition = objVideoLikeLogCond
.SetIdCase(objVideoLikeLog.IdCase, "=")
.SetUserId(objVideoLikeLog.UserId, "=")
.GetCombineCondition();
objVideoLikeLog._IsCheckProperty = true;
bool bolIsExist = clsVideoLikeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objVideoLikeLog.IdVideoLikeLog = clsVideoLikeLogBL.GetFirstID_S(strCondition);
objVideoLikeLog.UpdateWithCondition(strCondition);
}
else
{
objVideoLikeLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN.IdVideoLikeLog == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVideoLikeLogBL.VideoLikeLogDA.UpdateBySql2(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsVideoLikeLogEN objVideoLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objVideoLikeLogEN.IdVideoLikeLog == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsVideoLikeLogBL.VideoLikeLogDA.UpdateBySql2(objVideoLikeLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoLikeLogEN objVideoLikeLogEN, string strWhereCond)
{
try
{
bool bolResult = clsVideoLikeLogBL.VideoLikeLogDA.UpdateBySqlWithCondition(objVideoLikeLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsVideoLikeLogEN objVideoLikeLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsVideoLikeLogBL.VideoLikeLogDA.UpdateBySqlWithConditionTransaction(objVideoLikeLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsVideoLikeLogEN objVideoLikeLogEN)
{
try
{
int intRecNum = clsVideoLikeLogBL.VideoLikeLogDA.DelRecord(objVideoLikeLogEN.IdVideoLikeLog);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogENS">源对象</param>
 /// <param name = "objVideoLikeLogENT">目标对象</param>
 public static void CopyTo(this clsVideoLikeLogEN objVideoLikeLogENS, clsVideoLikeLogEN objVideoLikeLogENT)
{
try
{
objVideoLikeLogENT.IdVideoLikeLog = objVideoLikeLogENS.IdVideoLikeLog; //视频点赞日志流水号
objVideoLikeLogENT.FuncModuleId = objVideoLikeLogENS.FuncModuleId; //功能模块Id
objVideoLikeLogENT.UserId = objVideoLikeLogENS.UserId; //用户ID
objVideoLikeLogENT.IdCase = objVideoLikeLogENS.IdCase; //案例流水号
objVideoLikeLogENT.LikeDate = objVideoLikeLogENS.LikeDate; //点赞日期
objVideoLikeLogENT.LikeDegree = objVideoLikeLogENS.LikeDegree; //点赞度
objVideoLikeLogENT.Memo = objVideoLikeLogENS.Memo; //备注
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
 /// <param name = "objVideoLikeLogENS">源对象</param>
 /// <returns>目标对象=>clsVideoLikeLogEN:objVideoLikeLogENT</returns>
 public static clsVideoLikeLogEN CopyTo(this clsVideoLikeLogEN objVideoLikeLogENS)
{
try
{
 clsVideoLikeLogEN objVideoLikeLogENT = new clsVideoLikeLogEN()
{
IdVideoLikeLog = objVideoLikeLogENS.IdVideoLikeLog, //视频点赞日志流水号
FuncModuleId = objVideoLikeLogENS.FuncModuleId, //功能模块Id
UserId = objVideoLikeLogENS.UserId, //用户ID
IdCase = objVideoLikeLogENS.IdCase, //案例流水号
LikeDate = objVideoLikeLogENS.LikeDate, //点赞日期
LikeDegree = objVideoLikeLogENS.LikeDegree, //点赞度
Memo = objVideoLikeLogENS.Memo, //备注
};
 return objVideoLikeLogENT;
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
public static void CheckPropertyNew(this clsVideoLikeLogEN objVideoLikeLogEN)
{
 clsVideoLikeLogBL.VideoLikeLogDA.CheckPropertyNew(objVideoLikeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsVideoLikeLogEN objVideoLikeLogEN)
{
 clsVideoLikeLogBL.VideoLikeLogDA.CheckProperty4Condition(objVideoLikeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsVideoLikeLogEN objVideoLikeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.IdVideoLikeLog) == true)
{
string strComparisonOpIdVideoLikeLog = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.IdVideoLikeLog];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLikeLog.IdVideoLikeLog, objVideoLikeLogCond.IdVideoLikeLog, strComparisonOpIdVideoLikeLog);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLikeLog.FuncModuleId, objVideoLikeLogCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.UserId) == true)
{
string strComparisonOpUserId = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLikeLog.UserId, objVideoLikeLogCond.UserId, strComparisonOpUserId);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.IdCase) == true)
{
string strComparisonOpIdCase = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLikeLog.IdCase, objVideoLikeLogCond.IdCase, strComparisonOpIdCase);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.LikeDate) == true)
{
string strComparisonOpLikeDate = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.LikeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLikeLog.LikeDate, objVideoLikeLogCond.LikeDate, strComparisonOpLikeDate);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.LikeDegree) == true)
{
string strComparisonOpLikeDegree = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.LikeDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conVideoLikeLog.LikeDegree, objVideoLikeLogCond.LikeDegree, strComparisonOpLikeDegree);
}
if (objVideoLikeLogCond.IsUpdated(conVideoLikeLog.Memo) == true)
{
string strComparisonOpMemo = objVideoLikeLogCond.dicFldComparisonOp[conVideoLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conVideoLikeLog.Memo, objVideoLikeLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--VideoLikeLog(视频点赞日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:Id_Case_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsVideoLikeLogEN objVideoLikeLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objVideoLikeLogEN == null) return true;
if (objVideoLikeLogEN.IdVideoLikeLog == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCase = '{0}'", objVideoLikeLogEN.IdCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objVideoLikeLogEN.UserId);
if (clsVideoLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdVideoLikeLog !=  {0}", objVideoLikeLogEN.IdVideoLikeLog);
 sbCondition.AppendFormat(" and IdCase = '{0}'", objVideoLikeLogEN.IdCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objVideoLikeLogEN.UserId);
if (clsVideoLikeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--VideoLikeLog(视频点赞日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Id_Case_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsVideoLikeLogEN objVideoLikeLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objVideoLikeLogEN == null) return "";
if (objVideoLikeLogEN.IdVideoLikeLog == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCase = '{0}'", objVideoLikeLogEN.IdCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objVideoLikeLogEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdVideoLikeLog !=  {0}", objVideoLikeLogEN.IdVideoLikeLog);
 sbCondition.AppendFormat(" and IdCase = '{0}'", objVideoLikeLogEN.IdCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objVideoLikeLogEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_VideoLikeLog
{
public virtual bool UpdRelaTabDate(long lngIdVideoLikeLog, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 视频点赞日志(VideoLikeLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsVideoLikeLogBL
{
public static RelatedActions_VideoLikeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsVideoLikeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsVideoLikeLogDA VideoLikeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsVideoLikeLogDA();
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
 public clsVideoLikeLogBL()
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
if (string.IsNullOrEmpty(clsVideoLikeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsVideoLikeLogEN._ConnectString);
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
public static DataTable GetDataTable_VideoLikeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = VideoLikeLogDA.GetDataTable_VideoLikeLog(strWhereCond);
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
objDT = VideoLikeLogDA.GetDataTable(strWhereCond);
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
objDT = VideoLikeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = VideoLikeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = VideoLikeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = VideoLikeLogDA.GetDataTable_Top(objTopPara);
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
objDT = VideoLikeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = VideoLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = VideoLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdVideoLikeLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsVideoLikeLogEN> GetObjLstByIdVideoLikeLogLst(List<long> arrIdVideoLikeLogLst)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdVideoLikeLogLst);
 string strWhereCond = string.Format("IdVideoLikeLog in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdVideoLikeLogLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsVideoLikeLogEN> GetObjLstByIdVideoLikeLogLstCache(List<long> arrIdVideoLikeLogLst)
{
string strKey = string.Format("{0}", clsVideoLikeLogEN._CurrTabName);
List<clsVideoLikeLogEN> arrVideoLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLikeLogEN> arrVideoLikeLogObjLst_Sel =
arrVideoLikeLogObjLstCache
.Where(x => arrIdVideoLikeLogLst.Contains(x.IdVideoLikeLog));
return arrVideoLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLikeLogEN> GetObjLst(string strWhereCond)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
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
public static List<clsVideoLikeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objVideoLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsVideoLikeLogEN> GetSubObjLstCache(clsVideoLikeLogEN objVideoLikeLogCond)
{
List<clsVideoLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVideoLikeLog.AttributeName)
{
if (objVideoLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objVideoLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLikeLogCond[strFldName].ToString());
}
else
{
if (objVideoLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVideoLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVideoLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVideoLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVideoLikeLogCond[strFldName]));
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
public static List<clsVideoLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
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
public static List<clsVideoLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
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
List<clsVideoLikeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsVideoLikeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsVideoLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
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
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
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
public static List<clsVideoLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsVideoLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsVideoLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
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
public static List<clsVideoLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsVideoLikeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsVideoLikeLogEN> arrObjLst = new List<clsVideoLikeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsVideoLikeLogEN objVideoLikeLogEN = new clsVideoLikeLogEN();
try
{
objVideoLikeLogEN.IdVideoLikeLog = Int32.Parse(objRow[conVideoLikeLog.IdVideoLikeLog].ToString().Trim()); //视频点赞日志流水号
objVideoLikeLogEN.FuncModuleId = objRow[conVideoLikeLog.FuncModuleId].ToString().Trim(); //功能模块Id
objVideoLikeLogEN.UserId = objRow[conVideoLikeLog.UserId].ToString().Trim(); //用户ID
objVideoLikeLogEN.IdCase = objRow[conVideoLikeLog.IdCase].ToString().Trim(); //案例流水号
objVideoLikeLogEN.LikeDate = objRow[conVideoLikeLog.LikeDate].ToString().Trim(); //点赞日期
objVideoLikeLogEN.LikeDegree = objRow[conVideoLikeLog.LikeDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conVideoLikeLog.LikeDegree].ToString().Trim()); //点赞度
objVideoLikeLogEN.Memo = objRow[conVideoLikeLog.Memo] == DBNull.Value ? null : objRow[conVideoLikeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objVideoLikeLogEN.IdVideoLikeLog, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objVideoLikeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetVideoLikeLog(ref clsVideoLikeLogEN objVideoLikeLogEN)
{
bool bolResult = VideoLikeLogDA.GetVideoLikeLog(ref objVideoLikeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsVideoLikeLogEN GetObjByIdVideoLikeLog(long lngIdVideoLikeLog)
{
clsVideoLikeLogEN objVideoLikeLogEN = VideoLikeLogDA.GetObjByIdVideoLikeLog(lngIdVideoLikeLog);
return objVideoLikeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsVideoLikeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsVideoLikeLogEN objVideoLikeLogEN = VideoLikeLogDA.GetFirstObj(strWhereCond);
 return objVideoLikeLogEN;
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
public static clsVideoLikeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsVideoLikeLogEN objVideoLikeLogEN = VideoLikeLogDA.GetObjByDataRow(objRow);
 return objVideoLikeLogEN;
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
public static clsVideoLikeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsVideoLikeLogEN objVideoLikeLogEN = VideoLikeLogDA.GetObjByDataRow(objRow);
 return objVideoLikeLogEN;
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
 /// <param name = "lngIdVideoLikeLog">所给的关键字</param>
 /// <param name = "lstVideoLikeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVideoLikeLogEN GetObjByIdVideoLikeLogFromList(long lngIdVideoLikeLog, List<clsVideoLikeLogEN> lstVideoLikeLogObjLst)
{
foreach (clsVideoLikeLogEN objVideoLikeLogEN in lstVideoLikeLogObjLst)
{
if (objVideoLikeLogEN.IdVideoLikeLog == lngIdVideoLikeLog)
{
return objVideoLikeLogEN;
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
 long lngIdVideoLikeLog;
 try
 {
 lngIdVideoLikeLog = new clsVideoLikeLogDA().GetFirstID(strWhereCond);
 return lngIdVideoLikeLog;
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
 arrList = VideoLikeLogDA.GetID(strWhereCond);
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
bool bolIsExist = VideoLikeLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdVideoLikeLog)
{
//检测记录是否存在
bool bolIsExist = VideoLikeLogDA.IsExist(lngIdVideoLikeLog);
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
 bolIsExist = clsVideoLikeLogDA.IsExistTable();
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
 bolIsExist = VideoLikeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsVideoLikeLogEN objVideoLikeLogEN)
{
if (objVideoLikeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsVideoLikeLogBL.AddNewRecordBySql2)", objVideoLikeLogEN.IdCase,objVideoLikeLogEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = VideoLikeLogDA.AddNewRecordBySQL2(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsVideoLikeLogEN objVideoLikeLogEN)
{
if (objVideoLikeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsVideoLikeLogBL.AddNewRecordBySql2WithReturnKey)", objVideoLikeLogEN.IdCase,objVideoLikeLogEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = VideoLikeLogDA.AddNewRecordBySQL2WithReturnKey(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsVideoLikeLogEN objVideoLikeLogEN)
{
try
{
bool bolResult = VideoLikeLogDA.Update(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "objVideoLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsVideoLikeLogEN objVideoLikeLogEN)
{
 if (objVideoLikeLogEN.IdVideoLikeLog == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = VideoLikeLogDA.UpdateBySql2(objVideoLikeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsVideoLikeLogBL.ReFreshCache();

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
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
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdVideoLikeLog)
{
try
{
 clsVideoLikeLogEN objVideoLikeLogEN = clsVideoLikeLogBL.GetObjByIdVideoLikeLog(lngIdVideoLikeLog);

if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(objVideoLikeLogEN.IdVideoLikeLog, "SetUpdDate");
}
if (objVideoLikeLogEN != null)
{
int intRecNum = VideoLikeLogDA.DelRecord(lngIdVideoLikeLog);
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
/// <param name="lngIdVideoLikeLog">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdVideoLikeLog )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
//删除与表:[VideoLikeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conVideoLikeLog.IdVideoLikeLog,
//lngIdVideoLikeLog);
//        clsVideoLikeLogBL.DelVideoLikeLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVideoLikeLogBL.DelRecord(lngIdVideoLikeLog, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVideoLikeLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdVideoLikeLog, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdVideoLikeLog">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdVideoLikeLog, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsVideoLikeLogBL.relatedActions != null)
{
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(lngIdVideoLikeLog, "UpdRelaTabDate");
}
bool bolResult = VideoLikeLogDA.DelRecord(lngIdVideoLikeLog,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdVideoLikeLogLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelVideoLikeLogs(List<string> arrIdVideoLikeLogLst)
{
if (arrIdVideoLikeLogLst.Count == 0) return 0;
try
{
if (clsVideoLikeLogBL.relatedActions != null)
{
foreach (var strIdVideoLikeLog in arrIdVideoLikeLogLst)
{
long lngIdVideoLikeLog = long.Parse(strIdVideoLikeLog);
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(lngIdVideoLikeLog, "UpdRelaTabDate");
}
}
int intDelRecNum = VideoLikeLogDA.DelVideoLikeLog(arrIdVideoLikeLogLst);
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
public static int DelVideoLikeLogsByCond(string strWhereCond)
{
try
{
if (clsVideoLikeLogBL.relatedActions != null)
{
List<string> arrIdVideoLikeLog = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdVideoLikeLog in arrIdVideoLikeLog)
{
long lngIdVideoLikeLog = long.Parse(strIdVideoLikeLog);
clsVideoLikeLogBL.relatedActions.UpdRelaTabDate(lngIdVideoLikeLog, "UpdRelaTabDate");
}
}
int intRecNum = VideoLikeLogDA.DelVideoLikeLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[VideoLikeLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdVideoLikeLog">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdVideoLikeLog)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsVideoLikeLogDA.GetSpecSQLObj();
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
//删除与表:[VideoLikeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsVideoLikeLogBL.DelRecord(lngIdVideoLikeLog, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsVideoLikeLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdVideoLikeLog, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objVideoLikeLogENS">源对象</param>
 /// <param name = "objVideoLikeLogENT">目标对象</param>
 public static void CopyTo(clsVideoLikeLogEN objVideoLikeLogENS, clsVideoLikeLogEN objVideoLikeLogENT)
{
try
{
objVideoLikeLogENT.IdVideoLikeLog = objVideoLikeLogENS.IdVideoLikeLog; //视频点赞日志流水号
objVideoLikeLogENT.FuncModuleId = objVideoLikeLogENS.FuncModuleId; //功能模块Id
objVideoLikeLogENT.UserId = objVideoLikeLogENS.UserId; //用户ID
objVideoLikeLogENT.IdCase = objVideoLikeLogENS.IdCase; //案例流水号
objVideoLikeLogENT.LikeDate = objVideoLikeLogENS.LikeDate; //点赞日期
objVideoLikeLogENT.LikeDegree = objVideoLikeLogENS.LikeDegree; //点赞度
objVideoLikeLogENT.Memo = objVideoLikeLogENS.Memo; //备注
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
 /// <param name = "objVideoLikeLogEN">源简化对象</param>
 public static void SetUpdFlag(clsVideoLikeLogEN objVideoLikeLogEN)
{
try
{
objVideoLikeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objVideoLikeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conVideoLikeLog.IdVideoLikeLog, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.IdVideoLikeLog = objVideoLikeLogEN.IdVideoLikeLog; //视频点赞日志流水号
}
if (arrFldSet.Contains(conVideoLikeLog.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.FuncModuleId = objVideoLikeLogEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conVideoLikeLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.UserId = objVideoLikeLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(conVideoLikeLog.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.IdCase = objVideoLikeLogEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(conVideoLikeLog.LikeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.LikeDate = objVideoLikeLogEN.LikeDate; //点赞日期
}
if (arrFldSet.Contains(conVideoLikeLog.LikeDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.LikeDegree = objVideoLikeLogEN.LikeDegree; //点赞度
}
if (arrFldSet.Contains(conVideoLikeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objVideoLikeLogEN.Memo = objVideoLikeLogEN.Memo == "[null]" ? null :  objVideoLikeLogEN.Memo; //备注
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
 /// <param name = "objVideoLikeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsVideoLikeLogEN objVideoLikeLogEN)
{
try
{
if (objVideoLikeLogEN.Memo == "[null]") objVideoLikeLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsVideoLikeLogEN objVideoLikeLogEN)
{
 VideoLikeLogDA.CheckPropertyNew(objVideoLikeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsVideoLikeLogEN objVideoLikeLogEN)
{
 VideoLikeLogDA.CheckProperty4Condition(objVideoLikeLogEN);
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
if (clsVideoLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogBL没有刷新缓存机制(clsVideoLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdVideoLikeLog");
//if (arrVideoLikeLogObjLstCache == null)
//{
//arrVideoLikeLogObjLstCache = VideoLikeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdVideoLikeLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsVideoLikeLogEN GetObjByIdVideoLikeLogCache(long lngIdVideoLikeLog)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsVideoLikeLogEN._CurrTabName);
List<clsVideoLikeLogEN> arrVideoLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLikeLogEN> arrVideoLikeLogObjLst_Sel =
arrVideoLikeLogObjLstCache
.Where(x=> x.IdVideoLikeLog == lngIdVideoLikeLog 
);
if (arrVideoLikeLogObjLst_Sel.Count() == 0)
{
   clsVideoLikeLogEN obj = clsVideoLikeLogBL.GetObjByIdVideoLikeLog(lngIdVideoLikeLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrVideoLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoLikeLogEN> GetAllVideoLikeLogObjLstCache()
{
//获取缓存中的对象列表
List<clsVideoLikeLogEN> arrVideoLikeLogObjLstCache = GetObjLstCache(); 
return arrVideoLikeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsVideoLikeLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsVideoLikeLogEN._CurrTabName);
List<clsVideoLikeLogEN> arrVideoLikeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrVideoLikeLogObjLstCache;
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
string strKey = string.Format("{0}", clsVideoLikeLogEN._CurrTabName);
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
if (clsVideoLikeLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsVideoLikeLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsVideoLikeLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--VideoLikeLog(视频点赞日志)
 /// 唯一性条件:Id_Case_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objVideoLikeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsVideoLikeLogEN objVideoLikeLogEN)
{
//检测记录是否存在
string strResult = VideoLikeLogDA.GetUniCondStr(objVideoLikeLogEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdVideoLikeLog)
{
if (strInFldName != conVideoLikeLog.IdVideoLikeLog)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conVideoLikeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conVideoLikeLog.AttributeName));
throw new Exception(strMsg);
}
var objVideoLikeLog = clsVideoLikeLogBL.GetObjByIdVideoLikeLogCache(lngIdVideoLikeLog);
if (objVideoLikeLog == null) return "";
return objVideoLikeLog[strOutFldName].ToString();
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
int intRecCount = clsVideoLikeLogDA.GetRecCount(strTabName);
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
int intRecCount = clsVideoLikeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsVideoLikeLogDA.GetRecCount();
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
int intRecCount = clsVideoLikeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objVideoLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsVideoLikeLogEN objVideoLikeLogCond)
{
List<clsVideoLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsVideoLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conVideoLikeLog.AttributeName)
{
if (objVideoLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objVideoLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLikeLogCond[strFldName].ToString());
}
else
{
if (objVideoLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objVideoLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objVideoLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objVideoLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objVideoLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objVideoLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objVideoLikeLogCond[strFldName]));
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
 List<string> arrList = clsVideoLikeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = VideoLikeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = VideoLikeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = VideoLikeLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsVideoLikeLogDA.SetFldValue(clsVideoLikeLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = VideoLikeLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsVideoLikeLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsVideoLikeLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsVideoLikeLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[VideoLikeLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**视频点赞日志流水号*/ 
 strCreateTabCode.Append(" IdVideoLikeLog bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdCase char(8) not Null, "); 
 // /**点赞日期*/ 
 strCreateTabCode.Append(" LikeDate varchar(20) not Null, "); 
 // /**点赞度*/ 
 strCreateTabCode.Append(" LikeDegree int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 视频点赞日志(VideoLikeLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4VideoLikeLog : clsCommFun4BL
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
clsVideoLikeLogBL.ReFreshThisCache();
}
}

}