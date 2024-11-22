﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperAttentionBL
 表名:gs_PaperAttention(01120748)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsgs_PaperAttentionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperAttentionEN GetObj(this K_PaperAttentionId_gs_PaperAttention myKey)
{
clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionBL.gs_PaperAttentionDA.GetObjByPaperAttentionId(myKey.Value);
return objgs_PaperAttentionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperAttentionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsgs_PaperAttentionBL.AddNewRecord)", objgs_PaperAttentionEN.PaperId,objgs_PaperAttentionEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_PaperAttentionBL.gs_PaperAttentionDA.AddNewRecordBySQL2(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_PaperAttentionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_PaperAttentionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(论文Id(PaperId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objgs_PaperAttentionEN.PaperId, objgs_PaperAttentionEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_PaperAttentionEN.AddNewRecord();
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperAttentionEN) == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsgs_PaperAttentionBL.AddNewRecordWithReturnKey)", objgs_PaperAttentionEN.PaperId,objgs_PaperAttentionEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_PaperAttentionBL.gs_PaperAttentionDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperAttentionId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, long lngPaperAttentionId, string strComparisonOp="")
	{
objgs_PaperAttentionEN.PaperAttentionId = lngPaperAttentionId; //论文收藏Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperAttentionId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperAttentionId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperAttentionId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_PaperAttention.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_PaperAttention.PaperId);
}
objgs_PaperAttentionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUserId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, congs_PaperAttention.UserId);
}
objgs_PaperAttentionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UserId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UserId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UserId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperGroupId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strPaperGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, congs_PaperAttention.PaperGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, congs_PaperAttention.PaperGroupId);
}
objgs_PaperAttentionEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperGroupId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperGroupId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperGroupId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUpdUser(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, congs_PaperAttention.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperAttention.UpdUser);
}
objgs_PaperAttentionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UpdUser) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UpdUser, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UpdUser] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUpdDate(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperAttention.UpdDate);
}
objgs_PaperAttentionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UpdDate) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UpdDate, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UpdDate] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperAttentionEN SetMeno(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, congs_PaperAttention.Meno);
}
objgs_PaperAttentionEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.Meno) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.Meno, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.Meno] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_PaperAttentionEN.CheckPropertyNew();
clsgs_PaperAttentionEN objgs_PaperAttentionCond = new clsgs_PaperAttentionEN();
string strCondition = objgs_PaperAttentionCond
.SetPaperAttentionId(objgs_PaperAttentionEN.PaperAttentionId, "<>")
.SetPaperId(objgs_PaperAttentionEN.PaperId, "=")
.SetUserId(objgs_PaperAttentionEN.UserId, "=")
.GetCombineCondition();
objgs_PaperAttentionEN._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperAttentionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_PaperAttentionEN.Update();
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
 /// <param name = "objgs_PaperAttention">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_PaperAttentionEN objgs_PaperAttention)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_PaperAttentionEN objgs_PaperAttentionCond = new clsgs_PaperAttentionEN();
string strCondition = objgs_PaperAttentionCond
.SetPaperId(objgs_PaperAttention.PaperId, "=")
.SetUserId(objgs_PaperAttention.UserId, "=")
.GetCombineCondition();
objgs_PaperAttention._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperAttentionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_PaperAttention.PaperAttentionId = clsgs_PaperAttentionBL.GetFirstID_S(strCondition);
objgs_PaperAttention.UpdateWithCondition(strCondition);
}
else
{
objgs_PaperAttention.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 if (objgs_PaperAttentionEN.PaperAttentionId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperAttentionBL.gs_PaperAttentionDA.UpdateBySql2(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperAttentionEN.PaperAttentionId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperAttentionBL.gs_PaperAttentionDA.UpdateBySql2(objgs_PaperAttentionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_PaperAttentionBL.gs_PaperAttentionDA.UpdateBySqlWithCondition(objgs_PaperAttentionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_PaperAttentionBL.gs_PaperAttentionDA.UpdateBySqlWithConditionTransaction(objgs_PaperAttentionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "lngPaperAttentionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
try
{
int intRecNum = clsgs_PaperAttentionBL.gs_PaperAttentionDA.DelRecord(objgs_PaperAttentionEN.PaperAttentionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(this clsgs_PaperAttentionEN objgs_PaperAttentionENS, clsgs_PaperAttentionEN objgs_PaperAttentionENT)
{
try
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
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
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperAttentionEN:objgs_PaperAttentionENT</returns>
 public static clsgs_PaperAttentionEN CopyTo(this clsgs_PaperAttentionEN objgs_PaperAttentionENS)
{
try
{
 clsgs_PaperAttentionEN objgs_PaperAttentionENT = new clsgs_PaperAttentionEN()
{
PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId, //论文收藏Id
PaperId = objgs_PaperAttentionENS.PaperId, //论文Id
UserId = objgs_PaperAttentionENS.UserId, //用户ID
PaperGroupId = objgs_PaperAttentionENS.PaperGroupId, //组Id
UpdUser = objgs_PaperAttentionENS.UpdUser, //修改人
UpdDate = objgs_PaperAttentionENS.UpdDate, //修改日期
Meno = objgs_PaperAttentionENS.Meno, //备注
};
 return objgs_PaperAttentionENT;
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
public static void CheckPropertyNew(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 clsgs_PaperAttentionBL.gs_PaperAttentionDA.CheckPropertyNew(objgs_PaperAttentionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 clsgs_PaperAttentionBL.gs_PaperAttentionDA.CheckProperty4Condition(objgs_PaperAttentionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperAttentionEN objgs_PaperAttentionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.PaperAttentionId) == true)
{
string strComparisonOpPaperAttentionId = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.PaperAttentionId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperAttention.PaperAttentionId, objgs_PaperAttentionCond.PaperAttentionId, strComparisonOpPaperAttentionId);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.PaperId) == true)
{
string strComparisonOpPaperId = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.PaperId, objgs_PaperAttentionCond.PaperId, strComparisonOpPaperId);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.UserId) == true)
{
string strComparisonOpUserId = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UserId, objgs_PaperAttentionCond.UserId, strComparisonOpUserId);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.PaperGroupId) == true)
{
string strComparisonOpPaperGroupId = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.PaperGroupId, objgs_PaperAttentionCond.PaperGroupId, strComparisonOpPaperGroupId);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UpdUser, objgs_PaperAttentionCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UpdDate, objgs_PaperAttentionCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_PaperAttentionCond.IsUpdated(congs_PaperAttention.Meno) == true)
{
string strComparisonOpMeno = objgs_PaperAttentionCond.dicFldComparisonOp[congs_PaperAttention.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.Meno, objgs_PaperAttentionCond.Meno, strComparisonOpMeno);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_PaperAttention(论文关注), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperAttentionEN == null) return true;
if (objgs_PaperAttentionEN.PaperAttentionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperAttentionEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objgs_PaperAttentionEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
}
 if (objgs_PaperAttentionEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objgs_PaperAttentionEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
}
if (clsgs_PaperAttentionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperAttentionId !=  {0}", objgs_PaperAttentionEN.PaperAttentionId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
if (clsgs_PaperAttentionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_PaperAttention(论文关注), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperAttentionEN == null) return "";
if (objgs_PaperAttentionEN.PaperAttentionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperAttentionEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objgs_PaperAttentionEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
}
 if (objgs_PaperAttentionEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objgs_PaperAttentionEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperAttentionId !=  {0}", objgs_PaperAttentionEN.PaperAttentionId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_PaperAttention
{
public virtual bool UpdRelaTabDate(long lngPaperAttentionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperAttentionBL
{
public static RelatedActions_gs_PaperAttention relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_PaperAttentionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_PaperAttentionDA gs_PaperAttentionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_PaperAttentionDA();
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
 public clsgs_PaperAttentionBL()
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
if (string.IsNullOrEmpty(clsgs_PaperAttentionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperAttentionEN._ConnectString);
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
public static DataTable GetDataTable_gs_PaperAttention(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_PaperAttentionDA.GetDataTable_gs_PaperAttention(strWhereCond);
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
objDT = gs_PaperAttentionDA.GetDataTable(strWhereCond);
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
objDT = gs_PaperAttentionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_PaperAttentionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_PaperAttentionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_PaperAttentionDA.GetDataTable_Top(objTopPara);
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
objDT = gs_PaperAttentionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_PaperAttentionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_PaperAttentionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperAttentionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst(List<long> arrPaperAttentionIdLst)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperAttentionIdLst);
 string strWhereCond = string.Format("PaperAttentionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperAttentionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLstCache(List<long> arrPaperAttentionIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Sel =
arrgs_PaperAttentionObjLstCache
.Where(x => arrPaperAttentionIdLst.Contains(x.PaperAttentionId));
return arrgs_PaperAttentionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLst(string strWhereCond)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
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
public static List<clsgs_PaperAttentionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_PaperAttentionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_PaperAttentionEN> GetSubObjLstCache(clsgs_PaperAttentionEN objgs_PaperAttentionCond)
{
 string strUserId = objgs_PaperAttentionCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_PaperAttentionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_PaperAttentionEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperAttention.AttributeName)
{
if (objgs_PaperAttentionCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperAttentionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperAttentionCond[strFldName].ToString());
}
else
{
if (objgs_PaperAttentionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperAttentionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperAttentionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperAttentionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperAttentionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperAttentionCond[strFldName]));
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
public static List<clsgs_PaperAttentionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
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
List<clsgs_PaperAttentionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_PaperAttentionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_PaperAttentionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
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
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
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
public static List<clsgs_PaperAttentionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_PaperAttentionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_PaperAttentionEN> arrObjLst = new List<clsgs_PaperAttentionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperAttentionEN objgs_PaperAttentionEN = new clsgs_PaperAttentionEN();
try
{
objgs_PaperAttentionEN.PaperAttentionId = Int32.Parse(objRow[congs_PaperAttention.PaperAttentionId].ToString().Trim()); //论文收藏Id
objgs_PaperAttentionEN.PaperId = objRow[congs_PaperAttention.PaperId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperId].ToString().Trim(); //论文Id
objgs_PaperAttentionEN.UserId = objRow[congs_PaperAttention.UserId] == DBNull.Value ? null : objRow[congs_PaperAttention.UserId].ToString().Trim(); //用户ID
objgs_PaperAttentionEN.PaperGroupId = objRow[congs_PaperAttention.PaperGroupId] == DBNull.Value ? null : objRow[congs_PaperAttention.PaperGroupId].ToString().Trim(); //组Id
objgs_PaperAttentionEN.UpdUser = objRow[congs_PaperAttention.UpdUser].ToString().Trim(); //修改人
objgs_PaperAttentionEN.UpdDate = objRow[congs_PaperAttention.UpdDate] == DBNull.Value ? null : objRow[congs_PaperAttention.UpdDate].ToString().Trim(); //修改日期
objgs_PaperAttentionEN.Meno = objRow[congs_PaperAttention.Meno] == DBNull.Value ? null : objRow[congs_PaperAttention.Meno].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperAttentionEN.PaperAttentionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperAttentionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_PaperAttention(ref clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
bool bolResult = gs_PaperAttentionDA.Getgs_PaperAttention(ref objgs_PaperAttentionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionId(long lngPaperAttentionId)
{
clsgs_PaperAttentionEN objgs_PaperAttentionEN = gs_PaperAttentionDA.GetObjByPaperAttentionId(lngPaperAttentionId);
return objgs_PaperAttentionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_PaperAttentionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = gs_PaperAttentionDA.GetFirstObj(strWhereCond);
 return objgs_PaperAttentionEN;
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
public static clsgs_PaperAttentionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = gs_PaperAttentionDA.GetObjByDataRow(objRow);
 return objgs_PaperAttentionEN;
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
public static clsgs_PaperAttentionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = gs_PaperAttentionDA.GetObjByDataRow(objRow);
 return objgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <param name = "lstgs_PaperAttentionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionIdFromList(long lngPaperAttentionId, List<clsgs_PaperAttentionEN> lstgs_PaperAttentionObjLst)
{
foreach (clsgs_PaperAttentionEN objgs_PaperAttentionEN in lstgs_PaperAttentionObjLst)
{
if (objgs_PaperAttentionEN.PaperAttentionId == lngPaperAttentionId)
{
return objgs_PaperAttentionEN;
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
 long lngPaperAttentionId;
 try
 {
 lngPaperAttentionId = new clsgs_PaperAttentionDA().GetFirstID(strWhereCond);
 return lngPaperAttentionId;
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
 arrList = gs_PaperAttentionDA.GetID(strWhereCond);
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
bool bolIsExist = gs_PaperAttentionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperAttentionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperAttentionId)
{
//检测记录是否存在
bool bolIsExist = gs_PaperAttentionDA.IsExist(lngPaperAttentionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngPaperAttentionId">论文收藏Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngPaperAttentionId, string strOpUser)
{
clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);
objgs_PaperAttentionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_PaperAttentionEN.UpdUser = strOpUser;
return clsgs_PaperAttentionBL.UpdateBySql2(objgs_PaperAttentionEN);
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
 bolIsExist = clsgs_PaperAttentionDA.IsExistTable();
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
 bolIsExist = gs_PaperAttentionDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_PaperAttentionEN objgs_PaperAttentionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperAttentionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsgs_PaperAttentionBL.AddNewRecordBySql2)", objgs_PaperAttentionEN.PaperId,objgs_PaperAttentionEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_PaperAttentionDA.AddNewRecordBySQL2(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_PaperAttentionEN objgs_PaperAttentionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperAttentionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!论文Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsgs_PaperAttentionBL.AddNewRecordBySql2WithReturnKey)", objgs_PaperAttentionEN.PaperId,objgs_PaperAttentionEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_PaperAttentionDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
try
{
bool bolResult = gs_PaperAttentionDA.Update(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 if (objgs_PaperAttentionEN.PaperAttentionId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_PaperAttentionDA.UpdateBySql2(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionBL.ReFreshCache(objgs_PaperAttentionEN.UserId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
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
 /// <param name = "lngPaperAttentionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperAttentionId)
{
try
{
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);

if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(objgs_PaperAttentionEN.PaperAttentionId, objgs_PaperAttentionEN.UpdUser);
}
if (objgs_PaperAttentionEN != null)
{
int intRecNum = gs_PaperAttentionDA.DelRecord(lngPaperAttentionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_PaperAttentionEN.UserId);
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
/// <param name="lngPaperAttentionId">表关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperAttentionId , string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperAttentionDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperAttention]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_PaperAttention.PaperAttentionId,
//lngPaperAttentionId);
//        clsgs_PaperAttentionBL.Delgs_PaperAttentionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperAttentionBL.DelRecord(lngPaperAttentionId, strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperAttentionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperAttentionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperAttentionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperAttentionId, string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_PaperAttentionBL.relatedActions != null)
{
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(lngPaperAttentionId, "UpdRelaTabDate");
}
bool bolResult = gs_PaperAttentionDA.DelRecord(lngPaperAttentionId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strUserId);
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
 /// <param name = "arrPaperAttentionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_PaperAttentions(List<string> arrPaperAttentionIdLst)
{
if (arrPaperAttentionIdLst.Count == 0) return 0;
try
{
if (clsgs_PaperAttentionBL.relatedActions != null)
{
foreach (var strPaperAttentionId in arrPaperAttentionIdLst)
{
long lngPaperAttentionId = long.Parse(strPaperAttentionId);
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(lngPaperAttentionId, "UpdRelaTabDate");
}
}
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionBL.GetObjByPaperAttentionId(long.Parse(arrPaperAttentionIdLst[0]));
int intDelRecNum = gs_PaperAttentionDA.Delgs_PaperAttention(arrPaperAttentionIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_PaperAttentionEN.UserId);
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
public static int Delgs_PaperAttentionsByCond(string strWhereCond)
{
try
{
if (clsgs_PaperAttentionBL.relatedActions != null)
{
List<string> arrPaperAttentionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperAttentionId in arrPaperAttentionId)
{
long lngPaperAttentionId = long.Parse(strPaperAttentionId);
clsgs_PaperAttentionBL.relatedActions.UpdRelaTabDate(lngPaperAttentionId, "UpdRelaTabDate");
}
}
List<string> arrUserId = GetFldValue(congs_PaperAttention.UserId, strWhereCond);
int intRecNum = gs_PaperAttentionDA.Delgs_PaperAttention(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrUserId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_PaperAttention]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperAttentionId">表关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperAttentionId, string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperAttentionDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperAttention]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperAttentionBL.DelRecord(lngPaperAttentionId, strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperAttentionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperAttentionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(clsgs_PaperAttentionEN objgs_PaperAttentionENS, clsgs_PaperAttentionEN objgs_PaperAttentionENT)
{
try
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
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
 /// <param name = "objgs_PaperAttentionEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
try
{
objgs_PaperAttentionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_PaperAttentionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_PaperAttention.PaperAttentionId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.PaperAttentionId = objgs_PaperAttentionEN.PaperAttentionId; //论文收藏Id
}
if (arrFldSet.Contains(congs_PaperAttention.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.PaperId = objgs_PaperAttentionEN.PaperId == "[null]" ? null :  objgs_PaperAttentionEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_PaperAttention.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.UserId = objgs_PaperAttentionEN.UserId == "[null]" ? null :  objgs_PaperAttentionEN.UserId; //用户ID
}
if (arrFldSet.Contains(congs_PaperAttention.PaperGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.PaperGroupId = objgs_PaperAttentionEN.PaperGroupId == "[null]" ? null :  objgs_PaperAttentionEN.PaperGroupId; //组Id
}
if (arrFldSet.Contains(congs_PaperAttention.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.UpdUser = objgs_PaperAttentionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_PaperAttention.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.UpdDate = objgs_PaperAttentionEN.UpdDate == "[null]" ? null :  objgs_PaperAttentionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_PaperAttention.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperAttentionEN.Meno = objgs_PaperAttentionEN.Meno == "[null]" ? null :  objgs_PaperAttentionEN.Meno; //备注
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
 /// <param name = "objgs_PaperAttentionEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
try
{
if (objgs_PaperAttentionEN.PaperId == "[null]") objgs_PaperAttentionEN.PaperId = null; //论文Id
if (objgs_PaperAttentionEN.UserId == "[null]") objgs_PaperAttentionEN.UserId = null; //用户ID
if (objgs_PaperAttentionEN.PaperGroupId == "[null]") objgs_PaperAttentionEN.PaperGroupId = null; //组Id
if (objgs_PaperAttentionEN.UpdDate == "[null]") objgs_PaperAttentionEN.UpdDate = null; //修改日期
if (objgs_PaperAttentionEN.Meno == "[null]") objgs_PaperAttentionEN.Meno = null; //备注
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
public static void CheckPropertyNew(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 gs_PaperAttentionDA.CheckPropertyNew(objgs_PaperAttentionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 gs_PaperAttentionDA.CheckProperty4Condition(objgs_PaperAttentionEN);
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
if (clsgs_PaperAttentionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperAttentionBL没有刷新缓存机制(clsgs_PaperAttentionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAttentionId");
//if (arrgs_PaperAttentionObjLstCache == null)
//{
//arrgs_PaperAttentionObjLstCache = gs_PaperAttentionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionIdCache(long lngPaperAttentionId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Sel =
arrgs_PaperAttentionObjLstCache
.Where(x=> x.PaperAttentionId == lngPaperAttentionId 
);
if (arrgs_PaperAttentionObjLst_Sel.Count() == 0)
{
   clsgs_PaperAttentionEN obj = clsgs_PaperAttentionBL.GetObjByPaperAttentionId(lngPaperAttentionId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngPaperAttentionId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_PaperAttentionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetAllgs_PaperAttentionObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLstCache = GetObjLstCache(strUserId); 
return arrgs_PaperAttentionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_PaperAttentionObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsgs_PaperAttentionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_PaperAttentionEN._RefreshTimeLst.Count == 0) return "";
return clsgs_PaperAttentionEN._RefreshTimeLst[clsgs_PaperAttentionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("缓存分类字段:[UserId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperAttentionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsgs_PaperAttentionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_PaperAttentionBL.objCommFun4BL.ReFreshCache(strUserId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_PaperAttention(论文关注)
 /// 唯一性条件:PaperId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
//检测记录是否存在
string strResult = gs_PaperAttentionDA.GetUniCondStr(objgs_PaperAttentionEN);
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
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngPaperAttentionId, string strUserId)
{
if (strInFldName != congs_PaperAttention.PaperAttentionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_PaperAttention.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_PaperAttention.AttributeName));
throw new Exception(strMsg);
}
var objgs_PaperAttention = clsgs_PaperAttentionBL.GetObjByPaperAttentionIdCache(lngPaperAttentionId, strUserId);
if (objgs_PaperAttention == null) return "";
return objgs_PaperAttention[strOutFldName].ToString();
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
int intRecCount = clsgs_PaperAttentionDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_PaperAttentionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_PaperAttentionDA.GetRecCount();
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
int intRecCount = clsgs_PaperAttentionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_PaperAttentionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_PaperAttentionEN objgs_PaperAttentionCond)
{
 string strUserId = objgs_PaperAttentionCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_PaperAttentionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_PaperAttentionEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperAttention.AttributeName)
{
if (objgs_PaperAttentionCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperAttentionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperAttentionCond[strFldName].ToString());
}
else
{
if (objgs_PaperAttentionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperAttentionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperAttentionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperAttentionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperAttentionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperAttentionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperAttentionCond[strFldName]));
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
 List<string> arrList = clsgs_PaperAttentionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperAttentionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperAttentionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_PaperAttentionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperAttentionDA.SetFldValue(clsgs_PaperAttentionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_PaperAttentionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperAttentionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperAttentionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperAttentionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_PaperAttention] "); 
 strCreateTabCode.Append(" ( "); 
 // /**论文收藏Id*/ 
 strCreateTabCode.Append(" PaperAttentionId bigint primary key identity, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**组Id*/ 
 strCreateTabCode.Append(" PaperGroupId char(8) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Meno varchar(2000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_PaperAttention : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsgs_PaperAttentionBL.ReFreshThisCache(strUserId);
}
}

}