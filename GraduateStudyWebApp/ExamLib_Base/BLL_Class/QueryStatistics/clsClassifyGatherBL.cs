
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherBL
 表名:ClassifyGather(01120011)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
public static class  clsClassifyGatherBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClassifyGatherEN GetObj(this K_ClassifyGatherId_ClassifyGather myKey)
{
clsClassifyGatherEN objClassifyGatherEN = clsClassifyGatherBL.ClassifyGatherDA.GetObjByClassifyGatherId(myKey.Value);
return objClassifyGatherEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClassifyGatherEN objClassifyGatherEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClassifyGatherBL.IsExist(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClassifyGatherEN.ClassifyGatherId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsClassifyGatherBL.ClassifyGatherDA.AddNewRecordBySQL2(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
public static bool AddRecordEx(this clsClassifyGatherEN objClassifyGatherEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsClassifyGatherBL.IsExist(objClassifyGatherEN.ClassifyGatherId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objClassifyGatherEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objClassifyGatherEN.AddNewRecord();
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsClassifyGatherEN objClassifyGatherEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClassifyGatherBL.IsExist(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClassifyGatherEN.ClassifyGatherId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsClassifyGatherBL.ClassifyGatherDA.AddNewRecordBySQL2WithReturnKey(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetClassifyGatherId(this clsClassifyGatherEN objClassifyGatherEN, string strClassifyGatherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, conClassifyGather.ClassifyGatherId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, conClassifyGather.ClassifyGatherId);
}
objClassifyGatherEN.ClassifyGatherId = strClassifyGatherId; //分类统计Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.ClassifyGatherId) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.ClassifyGatherId, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.ClassifyGatherId] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetClassifyGatherName(this clsClassifyGatherEN objClassifyGatherEN, string strClassifyGatherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherName, conClassifyGather.ClassifyGatherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherName, 30, conClassifyGather.ClassifyGatherName);
}
objClassifyGatherEN.ClassifyGatherName = strClassifyGatherName; //分类统计名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.ClassifyGatherName) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.ClassifyGatherName, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.ClassifyGatherName] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetClassifyGatherPeriod(this clsClassifyGatherEN objClassifyGatherEN, string strClassifyGatherPeriod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherPeriod, conClassifyGather.ClassifyGatherPeriod);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherPeriod, 50, conClassifyGather.ClassifyGatherPeriod);
}
objClassifyGatherEN.ClassifyGatherPeriod = strClassifyGatherPeriod; //分类统计时期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.ClassifyGatherPeriod) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.ClassifyGatherPeriod, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.ClassifyGatherPeriod] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetQuestionnaireSetId(this clsClassifyGatherEN objClassifyGatherEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conClassifyGather.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conClassifyGather.QuestionnaireSetId);
}
objClassifyGatherEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.QuestionnaireSetId) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.QuestionnaireSetId, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.QuestionnaireSetId] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetIsDefault(this clsClassifyGatherEN objClassifyGatherEN, bool bolIsDefault, string strComparisonOp="")
	{
objClassifyGatherEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.IsDefault) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.IsDefault, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.IsDefault] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetUpdUser(this clsClassifyGatherEN objClassifyGatherEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conClassifyGather.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conClassifyGather.UpdUser);
}
objClassifyGatherEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.UpdUser) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.UpdUser, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.UpdUser] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetUpdDate(this clsClassifyGatherEN objClassifyGatherEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conClassifyGather.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClassifyGather.UpdDate);
}
objClassifyGatherEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.UpdDate) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.UpdDate, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.UpdDate] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherEN SetMemo(this clsClassifyGatherEN objClassifyGatherEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClassifyGather.Memo);
}
objClassifyGatherEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherEN.dicFldComparisonOp.ContainsKey(conClassifyGather.Memo) == false)
{
objClassifyGatherEN.dicFldComparisonOp.Add(conClassifyGather.Memo, strComparisonOp);
}
else
{
objClassifyGatherEN.dicFldComparisonOp[conClassifyGather.Memo] = strComparisonOp;
}
}
return objClassifyGatherEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsClassifyGatherEN objClassifyGatherEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objClassifyGatherEN.CheckPropertyNew();
clsClassifyGatherEN objClassifyGatherCond = new clsClassifyGatherEN();
string strCondition = objClassifyGatherCond
.SetClassifyGatherId(objClassifyGatherEN.ClassifyGatherId, "=")
.GetCombineCondition();
objClassifyGatherEN._IsCheckProperty = true;
bool bolIsExist = clsClassifyGatherBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objClassifyGatherEN.Update();
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClassifyGatherEN objClassifyGatherEN)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClassifyGatherBL.ClassifyGatherDA.UpdateBySql2(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClassifyGatherEN objClassifyGatherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClassifyGatherBL.ClassifyGatherDA.UpdateBySql2(objClassifyGatherEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClassifyGatherEN objClassifyGatherEN, string strWhereCond)
{
try
{
bool bolResult = clsClassifyGatherBL.ClassifyGatherDA.UpdateBySqlWithCondition(objClassifyGatherEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClassifyGatherEN objClassifyGatherEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsClassifyGatherBL.ClassifyGatherDA.UpdateBySqlWithConditionTransaction(objClassifyGatherEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsClassifyGatherEN objClassifyGatherEN)
{
try
{
int intRecNum = clsClassifyGatherBL.ClassifyGatherDA.DelRecord(objClassifyGatherEN.ClassifyGatherId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherENS">源对象</param>
 /// <param name = "objClassifyGatherENT">目标对象</param>
 public static void CopyTo(this clsClassifyGatherEN objClassifyGatherENS, clsClassifyGatherEN objClassifyGatherENT)
{
try
{
objClassifyGatherENT.ClassifyGatherId = objClassifyGatherENS.ClassifyGatherId; //分类统计Id
objClassifyGatherENT.ClassifyGatherName = objClassifyGatherENS.ClassifyGatherName; //分类统计名称
objClassifyGatherENT.ClassifyGatherPeriod = objClassifyGatherENS.ClassifyGatherPeriod; //分类统计时期
objClassifyGatherENT.QuestionnaireSetId = objClassifyGatherENS.QuestionnaireSetId; //问卷集ID
objClassifyGatherENT.IsDefault = objClassifyGatherENS.IsDefault; //是否默认
objClassifyGatherENT.UpdUser = objClassifyGatherENS.UpdUser; //修改人
objClassifyGatherENT.UpdDate = objClassifyGatherENS.UpdDate; //修改日期
objClassifyGatherENT.Memo = objClassifyGatherENS.Memo; //备注
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
 /// <param name = "objClassifyGatherENS">源对象</param>
 /// <returns>目标对象=>clsClassifyGatherEN:objClassifyGatherENT</returns>
 public static clsClassifyGatherEN CopyTo(this clsClassifyGatherEN objClassifyGatherENS)
{
try
{
 clsClassifyGatherEN objClassifyGatherENT = new clsClassifyGatherEN()
{
ClassifyGatherId = objClassifyGatherENS.ClassifyGatherId, //分类统计Id
ClassifyGatherName = objClassifyGatherENS.ClassifyGatherName, //分类统计名称
ClassifyGatherPeriod = objClassifyGatherENS.ClassifyGatherPeriod, //分类统计时期
QuestionnaireSetId = objClassifyGatherENS.QuestionnaireSetId, //问卷集ID
IsDefault = objClassifyGatherENS.IsDefault, //是否默认
UpdUser = objClassifyGatherENS.UpdUser, //修改人
UpdDate = objClassifyGatherENS.UpdDate, //修改日期
Memo = objClassifyGatherENS.Memo, //备注
};
 return objClassifyGatherENT;
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
public static void CheckPropertyNew(this clsClassifyGatherEN objClassifyGatherEN)
{
 clsClassifyGatherBL.ClassifyGatherDA.CheckPropertyNew(objClassifyGatherEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsClassifyGatherEN objClassifyGatherEN)
{
 clsClassifyGatherBL.ClassifyGatherDA.CheckProperty4Condition(objClassifyGatherEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClassifyGatherEN objClassifyGatherCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClassifyGatherCond.IsUpdated(conClassifyGather.ClassifyGatherId) == true)
{
string strComparisonOpClassifyGatherId = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.ClassifyGatherId, objClassifyGatherCond.ClassifyGatherId, strComparisonOpClassifyGatherId);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.ClassifyGatherName) == true)
{
string strComparisonOpClassifyGatherName = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.ClassifyGatherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.ClassifyGatherName, objClassifyGatherCond.ClassifyGatherName, strComparisonOpClassifyGatherName);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.ClassifyGatherPeriod) == true)
{
string strComparisonOpClassifyGatherPeriod = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.ClassifyGatherPeriod];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.ClassifyGatherPeriod, objClassifyGatherCond.ClassifyGatherPeriod, strComparisonOpClassifyGatherPeriod);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.QuestionnaireSetId, objClassifyGatherCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.IsDefault) == true)
{
if (objClassifyGatherCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClassifyGather.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClassifyGather.IsDefault);
}
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.UpdUser) == true)
{
string strComparisonOpUpdUser = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.UpdUser, objClassifyGatherCond.UpdUser, strComparisonOpUpdUser);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.UpdDate) == true)
{
string strComparisonOpUpdDate = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.UpdDate, objClassifyGatherCond.UpdDate, strComparisonOpUpdDate);
}
if (objClassifyGatherCond.IsUpdated(conClassifyGather.Memo) == true)
{
string strComparisonOpMemo = objClassifyGatherCond.dicFldComparisonOp[conClassifyGather.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGather.Memo, objClassifyGatherCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ClassifyGather
{
public virtual bool UpdRelaTabDate(string strClassifyGatherId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 分类统计(ClassifyGather)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsClassifyGatherBL
{
public static RelatedActions_ClassifyGather relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsClassifyGatherDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsClassifyGatherDA ClassifyGatherDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsClassifyGatherDA();
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
 public clsClassifyGatherBL()
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
if (string.IsNullOrEmpty(clsClassifyGatherEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClassifyGatherEN._ConnectString);
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
public static DataTable GetDataTable_ClassifyGather(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ClassifyGatherDA.GetDataTable_ClassifyGather(strWhereCond);
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
objDT = ClassifyGatherDA.GetDataTable(strWhereCond);
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
objDT = ClassifyGatherDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ClassifyGatherDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ClassifyGatherDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ClassifyGatherDA.GetDataTable_Top(objTopPara);
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
objDT = ClassifyGatherDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ClassifyGatherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ClassifyGatherDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrClassifyGatherIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsClassifyGatherEN> GetObjLstByClassifyGatherIdLst(List<string> arrClassifyGatherIdLst)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrClassifyGatherIdLst, true);
 string strWhereCond = string.Format("ClassifyGatherId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrClassifyGatherIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsClassifyGatherEN> GetObjLstByClassifyGatherIdLstCache(List<string> arrClassifyGatherIdLst)
{
string strKey = string.Format("{0}", clsClassifyGatherEN._CurrTabName);
List<clsClassifyGatherEN> arrClassifyGatherObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherEN> arrClassifyGatherObjLst_Sel =
arrClassifyGatherObjLstCache
.Where(x => arrClassifyGatherIdLst.Contains(x.ClassifyGatherId));
return arrClassifyGatherObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherEN> GetObjLst(string strWhereCond)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
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
public static List<clsClassifyGatherEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objClassifyGatherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsClassifyGatherEN> GetSubObjLstCache(clsClassifyGatherEN objClassifyGatherCond)
{
List<clsClassifyGatherEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClassifyGather.AttributeName)
{
if (objClassifyGatherCond.IsUpdated(strFldName) == false) continue;
if (objClassifyGatherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherCond[strFldName].ToString());
}
else
{
if (objClassifyGatherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClassifyGatherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClassifyGatherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClassifyGatherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClassifyGatherCond[strFldName]));
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
public static List<clsClassifyGatherEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
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
public static List<clsClassifyGatherEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
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
List<clsClassifyGatherEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsClassifyGatherEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsClassifyGatherEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
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
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
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
public static List<clsClassifyGatherEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsClassifyGatherEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsClassifyGatherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
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
public static List<clsClassifyGatherEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherEN.ClassifyGatherId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objClassifyGatherEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetClassifyGather(ref clsClassifyGatherEN objClassifyGatherEN)
{
bool bolResult = ClassifyGatherDA.GetClassifyGather(ref objClassifyGatherEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClassifyGatherEN GetObjByClassifyGatherId(string strClassifyGatherId)
{
if (strClassifyGatherId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strClassifyGatherId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strClassifyGatherId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strClassifyGatherId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsClassifyGatherEN objClassifyGatherEN = ClassifyGatherDA.GetObjByClassifyGatherId(strClassifyGatherId);
return objClassifyGatherEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsClassifyGatherEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsClassifyGatherEN objClassifyGatherEN = ClassifyGatherDA.GetFirstObj(strWhereCond);
 return objClassifyGatherEN;
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
public static clsClassifyGatherEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsClassifyGatherEN objClassifyGatherEN = ClassifyGatherDA.GetObjByDataRow(objRow);
 return objClassifyGatherEN;
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
public static clsClassifyGatherEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsClassifyGatherEN objClassifyGatherEN = ClassifyGatherDA.GetObjByDataRow(objRow);
 return objClassifyGatherEN;
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
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <param name = "lstClassifyGatherObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClassifyGatherEN GetObjByClassifyGatherIdFromList(string strClassifyGatherId, List<clsClassifyGatherEN> lstClassifyGatherObjLst)
{
foreach (clsClassifyGatherEN objClassifyGatherEN in lstClassifyGatherObjLst)
{
if (objClassifyGatherEN.ClassifyGatherId == strClassifyGatherId)
{
return objClassifyGatherEN;
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
 string strClassifyGatherId;
 try
 {
 strClassifyGatherId = new clsClassifyGatherDA().GetFirstID(strWhereCond);
 return strClassifyGatherId;
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
 arrList = ClassifyGatherDA.GetID(strWhereCond);
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
bool bolIsExist = ClassifyGatherDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strClassifyGatherId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ClassifyGatherDA.IsExist(strClassifyGatherId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strClassifyGatherId">分类统计Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strClassifyGatherId, string strOpUser)
{
clsClassifyGatherEN objClassifyGatherEN = clsClassifyGatherBL.GetObjByClassifyGatherId(strClassifyGatherId);
objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objClassifyGatherEN.UpdUser = strOpUser;
return clsClassifyGatherBL.UpdateBySql2(objClassifyGatherEN);
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
 bolIsExist = clsClassifyGatherDA.IsExistTable();
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
 bolIsExist = ClassifyGatherDA.IsExistTable(strTabName);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsClassifyGatherEN objClassifyGatherEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClassifyGatherBL.IsExist(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClassifyGatherEN.ClassifyGatherId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ClassifyGatherDA.AddNewRecordBySQL2(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsClassifyGatherEN objClassifyGatherEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClassifyGatherBL.IsExist(objClassifyGatherEN.ClassifyGatherId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClassifyGatherEN.ClassifyGatherId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ClassifyGatherDA.AddNewRecordBySQL2WithReturnKey(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsClassifyGatherEN objClassifyGatherEN)
{
try
{
bool bolResult = ClassifyGatherDA.Update(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsClassifyGatherEN objClassifyGatherEN)
{
 if (string.IsNullOrEmpty(objClassifyGatherEN.ClassifyGatherId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ClassifyGatherDA.UpdateBySql2(objClassifyGatherEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherBL.ReFreshCache();

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
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
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strClassifyGatherId)
{
try
{
 clsClassifyGatherEN objClassifyGatherEN = clsClassifyGatherBL.GetObjByClassifyGatherId(strClassifyGatherId);

if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(objClassifyGatherEN.ClassifyGatherId, objClassifyGatherEN.UpdUser);
}
if (objClassifyGatherEN != null)
{
int intRecNum = ClassifyGatherDA.DelRecord(strClassifyGatherId);
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
/// <param name="strClassifyGatherId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strClassifyGatherId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
//删除与表:[ClassifyGather]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conClassifyGather.ClassifyGatherId,
//strClassifyGatherId);
//        clsClassifyGatherBL.DelClassifyGathersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClassifyGatherBL.DelRecord(strClassifyGatherId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClassifyGatherBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strClassifyGatherId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strClassifyGatherId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsClassifyGatherBL.relatedActions != null)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(strClassifyGatherId, "UpdRelaTabDate");
}
bool bolResult = ClassifyGatherDA.DelRecord(strClassifyGatherId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrClassifyGatherIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelClassifyGathers(List<string> arrClassifyGatherIdLst)
{
if (arrClassifyGatherIdLst.Count == 0) return 0;
try
{
if (clsClassifyGatherBL.relatedActions != null)
{
foreach (var strClassifyGatherId in arrClassifyGatherIdLst)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(strClassifyGatherId, "UpdRelaTabDate");
}
}
int intDelRecNum = ClassifyGatherDA.DelClassifyGather(arrClassifyGatherIdLst);
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
public static int DelClassifyGathersByCond(string strWhereCond)
{
try
{
if (clsClassifyGatherBL.relatedActions != null)
{
List<string> arrClassifyGatherId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strClassifyGatherId in arrClassifyGatherId)
{
clsClassifyGatherBL.relatedActions.UpdRelaTabDate(strClassifyGatherId, "UpdRelaTabDate");
}
}
int intRecNum = ClassifyGatherDA.DelClassifyGather(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ClassifyGather]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strClassifyGatherId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strClassifyGatherId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
//删除与表:[ClassifyGather]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClassifyGatherBL.DelRecord(strClassifyGatherId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClassifyGatherBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strClassifyGatherId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objClassifyGatherENS">源对象</param>
 /// <param name = "objClassifyGatherENT">目标对象</param>
 public static void CopyTo(clsClassifyGatherEN objClassifyGatherENS, clsClassifyGatherEN objClassifyGatherENT)
{
try
{
objClassifyGatherENT.ClassifyGatherId = objClassifyGatherENS.ClassifyGatherId; //分类统计Id
objClassifyGatherENT.ClassifyGatherName = objClassifyGatherENS.ClassifyGatherName; //分类统计名称
objClassifyGatherENT.ClassifyGatherPeriod = objClassifyGatherENS.ClassifyGatherPeriod; //分类统计时期
objClassifyGatherENT.QuestionnaireSetId = objClassifyGatherENS.QuestionnaireSetId; //问卷集ID
objClassifyGatherENT.IsDefault = objClassifyGatherENS.IsDefault; //是否默认
objClassifyGatherENT.UpdUser = objClassifyGatherENS.UpdUser; //修改人
objClassifyGatherENT.UpdDate = objClassifyGatherENS.UpdDate; //修改日期
objClassifyGatherENT.Memo = objClassifyGatherENS.Memo; //备注
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
 /// <param name = "objClassifyGatherEN">源简化对象</param>
 public static void SetUpdFlag(clsClassifyGatherEN objClassifyGatherEN)
{
try
{
objClassifyGatherEN.ClearUpdateState();
   string strsfUpdFldSetStr = objClassifyGatherEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conClassifyGather.ClassifyGatherId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.ClassifyGatherId = objClassifyGatherEN.ClassifyGatherId; //分类统计Id
}
if (arrFldSet.Contains(conClassifyGather.ClassifyGatherName, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.ClassifyGatherName = objClassifyGatherEN.ClassifyGatherName; //分类统计名称
}
if (arrFldSet.Contains(conClassifyGather.ClassifyGatherPeriod, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.ClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod; //分类统计时期
}
if (arrFldSet.Contains(conClassifyGather.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.QuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId == "[null]" ? null :  objClassifyGatherEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(conClassifyGather.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.IsDefault = objClassifyGatherEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(conClassifyGather.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.UpdUser = objClassifyGatherEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conClassifyGather.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.UpdDate = objClassifyGatherEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conClassifyGather.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherEN.Memo = objClassifyGatherEN.Memo == "[null]" ? null :  objClassifyGatherEN.Memo; //备注
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
 /// <param name = "objClassifyGatherEN">源简化对象</param>
 public static void AccessFldValueNull(clsClassifyGatherEN objClassifyGatherEN)
{
try
{
if (objClassifyGatherEN.QuestionnaireSetId == "[null]") objClassifyGatherEN.QuestionnaireSetId = null; //问卷集ID
if (objClassifyGatherEN.Memo == "[null]") objClassifyGatherEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsClassifyGatherEN objClassifyGatherEN)
{
 ClassifyGatherDA.CheckPropertyNew(objClassifyGatherEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsClassifyGatherEN objClassifyGatherEN)
{
 ClassifyGatherDA.CheckProperty4Condition(objClassifyGatherEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ClassifyGatherId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conClassifyGather.ClassifyGatherId); 
List<clsClassifyGatherEN> arrObjLst = clsClassifyGatherBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN()
{
ClassifyGatherId = "0",
ClassifyGatherName = "选[分类统计]..."
};
arrObjLst.Insert(0, objClassifyGatherEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conClassifyGather.ClassifyGatherId;
objComboBox.DisplayMember = conClassifyGather.ClassifyGatherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ClassifyGatherId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[分类统计]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conClassifyGather.ClassifyGatherId); 
IEnumerable<clsClassifyGatherEN> arrObjLst = clsClassifyGatherBL.GetObjLst(strCondition);
objDDL.DataValueField = conClassifyGather.ClassifyGatherId;
objDDL.DataTextField = conClassifyGather.ClassifyGatherName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ClassifyGatherIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[分类统计]...","0");
List<clsClassifyGatherEN> arrClassifyGatherObjLst = GetAllClassifyGatherObjLstCache(); 
objDDL.DataValueField = conClassifyGather.ClassifyGatherId;
objDDL.DataTextField = conClassifyGather.ClassifyGatherName;
objDDL.DataSource = arrClassifyGatherObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsClassifyGatherBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherBL没有刷新缓存机制(clsClassifyGatherBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClassifyGatherId");
//if (arrClassifyGatherObjLstCache == null)
//{
//arrClassifyGatherObjLstCache = ClassifyGatherDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClassifyGatherEN GetObjByClassifyGatherIdCache(string strClassifyGatherId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsClassifyGatherEN._CurrTabName);
List<clsClassifyGatherEN> arrClassifyGatherObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherEN> arrClassifyGatherObjLst_Sel =
arrClassifyGatherObjLstCache
.Where(x=> x.ClassifyGatherId == strClassifyGatherId 
);
if (arrClassifyGatherObjLst_Sel.Count() == 0)
{
   clsClassifyGatherEN obj = clsClassifyGatherBL.GetObjByClassifyGatherId(strClassifyGatherId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrClassifyGatherObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClassifyGatherNameByClassifyGatherIdCache(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return "";
//获取缓存中的对象列表
clsClassifyGatherEN objClassifyGather = GetObjByClassifyGatherIdCache(strClassifyGatherId);
if (objClassifyGather == null) return "";
return objClassifyGather.ClassifyGatherName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByClassifyGatherIdCache(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return "";
//获取缓存中的对象列表
clsClassifyGatherEN objClassifyGather = GetObjByClassifyGatherIdCache(strClassifyGatherId);
if (objClassifyGather == null) return "";
return objClassifyGather.ClassifyGatherName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClassifyGatherEN> GetAllClassifyGatherObjLstCache()
{
//获取缓存中的对象列表
List<clsClassifyGatherEN> arrClassifyGatherObjLstCache = GetObjLstCache(); 
return arrClassifyGatherObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClassifyGatherEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsClassifyGatherEN._CurrTabName);
List<clsClassifyGatherEN> arrClassifyGatherObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClassifyGatherObjLstCache;
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
string strKey = string.Format("{0}", clsClassifyGatherEN._CurrTabName);
CacheHelper.Remove(strKey);
clsClassifyGatherEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsClassifyGatherEN._RefreshTimeLst.Count == 0) return "";
return clsClassifyGatherEN._RefreshTimeLst[clsClassifyGatherEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsClassifyGatherBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClassifyGatherEN._CurrTabName);
CacheHelper.Remove(strKey);
clsClassifyGatherEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsClassifyGatherBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strClassifyGatherId)
{
if (strInFldName != conClassifyGather.ClassifyGatherId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conClassifyGather.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conClassifyGather.AttributeName));
throw new Exception(strMsg);
}
var objClassifyGather = clsClassifyGatherBL.GetObjByClassifyGatherIdCache(strClassifyGatherId);
if (objClassifyGather == null) return "";
return objClassifyGather[strOutFldName].ToString();
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
int intRecCount = clsClassifyGatherDA.GetRecCount(strTabName);
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
int intRecCount = clsClassifyGatherDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsClassifyGatherDA.GetRecCount();
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
int intRecCount = clsClassifyGatherDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objClassifyGatherCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsClassifyGatherEN objClassifyGatherCond)
{
List<clsClassifyGatherEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClassifyGather.AttributeName)
{
if (objClassifyGatherCond.IsUpdated(strFldName) == false) continue;
if (objClassifyGatherCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherCond[strFldName].ToString());
}
else
{
if (objClassifyGatherCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClassifyGatherCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClassifyGatherCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClassifyGatherCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClassifyGatherCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClassifyGatherCond[strFldName]));
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
 List<string> arrList = clsClassifyGatherDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ClassifyGatherDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ClassifyGatherDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ClassifyGatherDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsClassifyGatherDA.SetFldValue(clsClassifyGatherEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ClassifyGatherDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsClassifyGatherDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsClassifyGatherDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsClassifyGatherDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ClassifyGather] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分类统计Id*/ 
 strCreateTabCode.Append(" ClassifyGatherId char(4) primary key, "); 
 // /**分类统计名称*/ 
 strCreateTabCode.Append(" ClassifyGatherName varchar(30) not Null, "); 
 // /**分类统计时期*/ 
 strCreateTabCode.Append(" ClassifyGatherPeriod varchar(50) not Null, "); 
 // /**问卷集ID*/ 
 strCreateTabCode.Append(" QuestionnaireSetId char(4) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 分类统计(ClassifyGather)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ClassifyGather : clsCommFun4BL
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
clsClassifyGatherBL.ReFreshThisCache();
}
}

}