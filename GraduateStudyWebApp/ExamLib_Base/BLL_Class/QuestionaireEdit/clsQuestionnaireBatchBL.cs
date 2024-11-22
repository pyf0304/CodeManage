
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireBatchBL
 表名:QuestionnaireBatch(01120006)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsQuestionnaireBatchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireBatchEN GetObj(this K_BatchId_QuestionnaireBatch myKey)
{
clsQuestionnaireBatchEN objQuestionnaireBatchEN = clsQuestionnaireBatchBL.QuestionnaireBatchDA.GetObjByBatchId(myKey.Value);
return objQuestionnaireBatchEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireBatchEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集ID = [{0}],批次名称 = [{1}]的数据已经存在!(in clsQuestionnaireBatchBL.AddNewRecord)", objQuestionnaireBatchEN.QuestionnaireSetId,objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
bool bolResult = clsQuestionnaireBatchBL.QuestionnaireBatchDA.AddNewRecordBySQL2(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionnaireBatchEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionnaireBatchEN.CheckUniqueness() == false)
{
strMsg = string.Format("(问卷集ID(QuestionnaireSetId)=[{0}],批次名称(BatchName)=[{1}])已经存在,不能重复!", objQuestionnaireBatchEN.QuestionnaireSetId, objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQuestionnaireBatchEN.AddNewRecord();
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireBatchEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集ID = [{0}],批次名称 = [{1}]的数据已经存在!(in clsQuestionnaireBatchBL.AddNewRecordWithMaxId)", objQuestionnaireBatchEN.QuestionnaireSetId,objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
string strBatchId = clsQuestionnaireBatchBL.QuestionnaireBatchDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireBatchEN);
     objQuestionnaireBatchEN.BatchId = strBatchId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
}
return strBatchId;
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireBatchEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集ID = [{0}],批次名称 = [{1}]的数据已经存在!(in clsQuestionnaireBatchBL.AddNewRecordWithReturnKey)", objQuestionnaireBatchEN.QuestionnaireSetId,objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
string strKey = clsQuestionnaireBatchBL.QuestionnaireBatchDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetBatchId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strBatchId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchId, 4, conQuestionnaireBatch.BatchId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, conQuestionnaireBatch.BatchId);
}
objQuestionnaireBatchEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.BatchId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.BatchId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.BatchId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetBatchName(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strBatchName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBatchName, conQuestionnaireBatch.BatchName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchName, 50, conQuestionnaireBatch.BatchName);
}
objQuestionnaireBatchEN.BatchName = strBatchName; //批次名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.BatchName) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.BatchName, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.BatchName] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetRoleId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQuestionnaireBatch.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQuestionnaireBatch.RoleId);
}
objQuestionnaireBatchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.RoleId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.RoleId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.RoleId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetQuestionnaireSetId(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireBatch.QuestionnaireSetId);
}
objQuestionnaireBatchEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.QuestionnaireSetId) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsDefault(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsDefault, string strComparisonOp="")
	{
objQuestionnaireBatchEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsDefault) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsDefault, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsDefault] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsDefaultUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, conQuestionnaireBatch.IsDefaultUser);
objQuestionnaireBatchEN.IsDefaultUser = bolIsDefaultUser; //是否默认用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsDefaultUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsDefaultUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsDefaultUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetCreateDate(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateDate, conQuestionnaireBatch.CreateDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conQuestionnaireBatch.CreateDate);
}
objQuestionnaireBatchEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.CreateDate) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.CreateDate, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.CreateDate] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetCreateUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strCreateUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUser, conQuestionnaireBatch.CreateUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conQuestionnaireBatch.CreateUser);
}
objQuestionnaireBatchEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.CreateUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.CreateUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.CreateUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetPageName(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, conQuestionnaireBatch.PageName);
}
objQuestionnaireBatchEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.PageName) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.PageName, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.PageName] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetIsRandomSelSet(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsRandomSelSet, string strComparisonOp="")
	{
objQuestionnaireBatchEN.IsRandomSelSet = bolIsRandomSelSet; //是否随机选问卷集
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.IsRandomSelSet) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.IsRandomSelSet, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.IsRandomSelSet] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetUpdDate(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireBatch.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireBatch.UpdDate);
}
objQuestionnaireBatchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.UpdDate) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetUpdUser(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireBatch.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireBatch.UpdUser);
}
objQuestionnaireBatchEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.UpdUser) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireBatchEN SetMemo(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireBatch.Memo);
}
objQuestionnaireBatchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireBatchEN.dicFldComparisonOp.ContainsKey(conQuestionnaireBatch.Memo) == false)
{
objQuestionnaireBatchEN.dicFldComparisonOp.Add(conQuestionnaireBatch.Memo, strComparisonOp);
}
else
{
objQuestionnaireBatchEN.dicFldComparisonOp[conQuestionnaireBatch.Memo] = strComparisonOp;
}
}
return objQuestionnaireBatchEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionnaireBatchEN.CheckPropertyNew();
clsQuestionnaireBatchEN objQuestionnaireBatchCond = new clsQuestionnaireBatchEN();
string strCondition = objQuestionnaireBatchCond
.SetBatchId(objQuestionnaireBatchEN.BatchId, "<>")
.SetQuestionnaireSetId(objQuestionnaireBatchEN.QuestionnaireSetId, "=")
.SetBatchName(objQuestionnaireBatchEN.BatchName, "=")
.GetCombineCondition();
objQuestionnaireBatchEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireBatchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionnaireSetId_BatchName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionnaireBatchEN.Update();
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
 /// <param name = "objQuestionnaireBatch">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionnaireBatchEN objQuestionnaireBatch)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionnaireBatchEN objQuestionnaireBatchCond = new clsQuestionnaireBatchEN();
string strCondition = objQuestionnaireBatchCond
.SetQuestionnaireSetId(objQuestionnaireBatch.QuestionnaireSetId, "=")
.SetBatchName(objQuestionnaireBatch.BatchName, "=")
.GetCombineCondition();
objQuestionnaireBatch._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireBatchBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionnaireBatch.BatchId = clsQuestionnaireBatchBL.GetFirstID_S(strCondition);
objQuestionnaireBatch.UpdateWithCondition(strCondition);
}
else
{
objQuestionnaireBatch.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
objQuestionnaireBatch.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireBatchBL.QuestionnaireBatchDA.UpdateBySql2(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireBatchBL.QuestionnaireBatchDA.UpdateBySql2(objQuestionnaireBatchEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionnaireBatchBL.QuestionnaireBatchDA.UpdateBySqlWithCondition(objQuestionnaireBatchEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireBatchEN objQuestionnaireBatchEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionnaireBatchBL.QuestionnaireBatchDA.UpdateBySqlWithConditionTransaction(objQuestionnaireBatchEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
try
{
int intRecNum = clsQuestionnaireBatchBL.QuestionnaireBatchDA.DelRecord(objQuestionnaireBatchEN.BatchId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchENS">源对象</param>
 /// <param name = "objQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(this clsQuestionnaireBatchEN objQuestionnaireBatchENS, clsQuestionnaireBatchEN objQuestionnaireBatchENT)
{
try
{
objQuestionnaireBatchENT.BatchId = objQuestionnaireBatchENS.BatchId; //批次ID
objQuestionnaireBatchENT.BatchName = objQuestionnaireBatchENS.BatchName; //批次名称
objQuestionnaireBatchENT.RoleId = objQuestionnaireBatchENS.RoleId; //角色Id
objQuestionnaireBatchENT.QuestionnaireSetId = objQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireBatchENT.IsDefault = objQuestionnaireBatchENS.IsDefault; //是否默认
objQuestionnaireBatchENT.IsDefaultUser = objQuestionnaireBatchENS.IsDefaultUser; //是否默认用户
objQuestionnaireBatchENT.CreateDate = objQuestionnaireBatchENS.CreateDate; //建立日期
objQuestionnaireBatchENT.CreateUser = objQuestionnaireBatchENS.CreateUser; //建立用户
objQuestionnaireBatchENT.PageName = objQuestionnaireBatchENS.PageName; //页面名称
objQuestionnaireBatchENT.IsRandomSelSet = objQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objQuestionnaireBatchENT.UpdDate = objQuestionnaireBatchENS.UpdDate; //修改日期
objQuestionnaireBatchENT.UpdUser = objQuestionnaireBatchENS.UpdUser; //修改人
objQuestionnaireBatchENT.Memo = objQuestionnaireBatchENS.Memo; //备注
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
 /// <param name = "objQuestionnaireBatchENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireBatchEN:objQuestionnaireBatchENT</returns>
 public static clsQuestionnaireBatchEN CopyTo(this clsQuestionnaireBatchEN objQuestionnaireBatchENS)
{
try
{
 clsQuestionnaireBatchEN objQuestionnaireBatchENT = new clsQuestionnaireBatchEN()
{
BatchId = objQuestionnaireBatchENS.BatchId, //批次ID
BatchName = objQuestionnaireBatchENS.BatchName, //批次名称
RoleId = objQuestionnaireBatchENS.RoleId, //角色Id
QuestionnaireSetId = objQuestionnaireBatchENS.QuestionnaireSetId, //问卷集ID
IsDefault = objQuestionnaireBatchENS.IsDefault, //是否默认
IsDefaultUser = objQuestionnaireBatchENS.IsDefaultUser, //是否默认用户
CreateDate = objQuestionnaireBatchENS.CreateDate, //建立日期
CreateUser = objQuestionnaireBatchENS.CreateUser, //建立用户
PageName = objQuestionnaireBatchENS.PageName, //页面名称
IsRandomSelSet = objQuestionnaireBatchENS.IsRandomSelSet, //是否随机选问卷集
UpdDate = objQuestionnaireBatchENS.UpdDate, //修改日期
UpdUser = objQuestionnaireBatchENS.UpdUser, //修改人
Memo = objQuestionnaireBatchENS.Memo, //备注
};
 return objQuestionnaireBatchENT;
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
public static void CheckPropertyNew(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 clsQuestionnaireBatchBL.QuestionnaireBatchDA.CheckPropertyNew(objQuestionnaireBatchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 clsQuestionnaireBatchBL.QuestionnaireBatchDA.CheckProperty4Condition(objQuestionnaireBatchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireBatchEN objQuestionnaireBatchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.BatchId) == true)
{
string strComparisonOpBatchId = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.BatchId, objQuestionnaireBatchCond.BatchId, strComparisonOpBatchId);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.BatchName) == true)
{
string strComparisonOpBatchName = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.BatchName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.BatchName, objQuestionnaireBatchCond.BatchName, strComparisonOpBatchName);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.RoleId) == true)
{
string strComparisonOpRoleId = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.RoleId, objQuestionnaireBatchCond.RoleId, strComparisonOpRoleId);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.QuestionnaireSetId, objQuestionnaireBatchCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.IsDefault) == true)
{
if (objQuestionnaireBatchCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsDefault);
}
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.IsDefaultUser) == true)
{
if (objQuestionnaireBatchCond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsDefaultUser);
}
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.CreateDate) == true)
{
string strComparisonOpCreateDate = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.CreateDate, objQuestionnaireBatchCond.CreateDate, strComparisonOpCreateDate);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.CreateUser) == true)
{
string strComparisonOpCreateUser = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.CreateUser, objQuestionnaireBatchCond.CreateUser, strComparisonOpCreateUser);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.PageName) == true)
{
string strComparisonOpPageName = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.PageName, objQuestionnaireBatchCond.PageName, strComparisonOpPageName);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.IsRandomSelSet) == true)
{
if (objQuestionnaireBatchCond.IsRandomSelSet == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireBatch.IsRandomSelSet);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireBatch.IsRandomSelSet);
}
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.UpdDate, objQuestionnaireBatchCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.UpdUser, objQuestionnaireBatchCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionnaireBatchCond.IsUpdated(conQuestionnaireBatch.Memo) == true)
{
string strComparisonOpMemo = objQuestionnaireBatchCond.dicFldComparisonOp[conQuestionnaireBatch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireBatch.Memo, objQuestionnaireBatchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QuestionnaireBatch(问卷批次), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionnaireSetId_BatchName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireBatchEN == null) return true;
if (objQuestionnaireBatchEN.BatchId == null || objQuestionnaireBatchEN.BatchId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQuestionnaireBatchEN.QuestionnaireSetId == null)
{
 sbCondition.AppendFormat(" and QuestionnaireSetId is null", objQuestionnaireBatchEN.QuestionnaireSetId);
}
else
{
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objQuestionnaireBatchEN.QuestionnaireSetId);
}
 sbCondition.AppendFormat(" and BatchName = '{0}'", objQuestionnaireBatchEN.BatchName);
if (clsQuestionnaireBatchBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("BatchId !=  '{0}'", objQuestionnaireBatchEN.BatchId);
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objQuestionnaireBatchEN.QuestionnaireSetId);
 sbCondition.AppendFormat(" and BatchName = '{0}'", objQuestionnaireBatchEN.BatchName);
if (clsQuestionnaireBatchBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QuestionnaireBatch(问卷批次), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionnaireSetId_BatchName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireBatchEN == null) return "";
if (objQuestionnaireBatchEN.BatchId == null || objQuestionnaireBatchEN.BatchId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objQuestionnaireBatchEN.QuestionnaireSetId == null)
{
 sbCondition.AppendFormat(" and QuestionnaireSetId is null", objQuestionnaireBatchEN.QuestionnaireSetId);
}
else
{
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objQuestionnaireBatchEN.QuestionnaireSetId);
}
 sbCondition.AppendFormat(" and BatchName = '{0}'", objQuestionnaireBatchEN.BatchName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("BatchId !=  '{0}'", objQuestionnaireBatchEN.BatchId);
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objQuestionnaireBatchEN.QuestionnaireSetId);
 sbCondition.AppendFormat(" and BatchName = '{0}'", objQuestionnaireBatchEN.BatchName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionnaireBatch
{
public virtual bool UpdRelaTabDate(string strBatchId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 问卷批次(QuestionnaireBatch)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireBatchBL
{
public static RelatedActions_QuestionnaireBatch relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionnaireBatchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionnaireBatchDA QuestionnaireBatchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionnaireBatchDA();
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
 public clsQuestionnaireBatchBL()
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
if (string.IsNullOrEmpty(clsQuestionnaireBatchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireBatchEN._ConnectString);
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
public static DataTable GetDataTable_QuestionnaireBatch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionnaireBatchDA.GetDataTable_QuestionnaireBatch(strWhereCond);
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
objDT = QuestionnaireBatchDA.GetDataTable(strWhereCond);
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
objDT = QuestionnaireBatchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionnaireBatchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionnaireBatchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionnaireBatchDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionnaireBatchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionnaireBatchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionnaireBatchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrBatchIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLstByBatchIdLst(List<string> arrBatchIdLst)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrBatchIdLst, true);
 string strWhereCond = string.Format("BatchId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrBatchIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionnaireBatchEN> GetObjLstByBatchIdLstCache(List<string> arrBatchIdLst)
{
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel =
arrQuestionnaireBatchObjLstCache
.Where(x => arrBatchIdLst.Contains(x.BatchId));
return arrQuestionnaireBatchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLst(string strWhereCond)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
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
public static List<clsQuestionnaireBatchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionnaireBatchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionnaireBatchEN> GetSubObjLstCache(clsQuestionnaireBatchEN objQuestionnaireBatchCond)
{
List<clsQuestionnaireBatchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireBatchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireBatch.AttributeName)
{
if (objQuestionnaireBatchCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireBatchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireBatchCond[strFldName].ToString());
}
else
{
if (objQuestionnaireBatchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireBatchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireBatchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireBatchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireBatchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireBatchCond[strFldName]));
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
public static List<clsQuestionnaireBatchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
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
List<clsQuestionnaireBatchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionnaireBatchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionnaireBatchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
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
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
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
public static List<clsQuestionnaireBatchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionnaireBatchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
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
public static List<clsQuestionnaireBatchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionnaireBatchEN> arrObjLst = new List<clsQuestionnaireBatchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireBatchEN objQuestionnaireBatchEN = new clsQuestionnaireBatchEN();
try
{
objQuestionnaireBatchEN.BatchId = objRow[conQuestionnaireBatch.BatchId].ToString().Trim(); //批次ID
objQuestionnaireBatchEN.BatchName = objRow[conQuestionnaireBatch.BatchName].ToString().Trim(); //批次名称
objQuestionnaireBatchEN.RoleId = objRow[conQuestionnaireBatch.RoleId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.RoleId].ToString().Trim(); //角色Id
objQuestionnaireBatchEN.QuestionnaireSetId = objRow[conQuestionnaireBatch.QuestionnaireSetId] == DBNull.Value ? null : objRow[conQuestionnaireBatch.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireBatchEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefault].ToString().Trim()); //是否默认
objQuestionnaireBatchEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsDefaultUser].ToString().Trim()); //是否默认用户
objQuestionnaireBatchEN.CreateDate = objRow[conQuestionnaireBatch.CreateDate].ToString().Trim(); //建立日期
objQuestionnaireBatchEN.CreateUser = objRow[conQuestionnaireBatch.CreateUser].ToString().Trim(); //建立用户
objQuestionnaireBatchEN.PageName = objRow[conQuestionnaireBatch.PageName] == DBNull.Value ? null : objRow[conQuestionnaireBatch.PageName].ToString().Trim(); //页面名称
objQuestionnaireBatchEN.IsRandomSelSet = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireBatch.IsRandomSelSet].ToString().Trim()); //是否随机选问卷集
objQuestionnaireBatchEN.UpdDate = objRow[conQuestionnaireBatch.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireBatchEN.UpdUser = objRow[conQuestionnaireBatch.UpdUser].ToString().Trim(); //修改人
objQuestionnaireBatchEN.Memo = objRow[conQuestionnaireBatch.Memo] == DBNull.Value ? null : objRow[conQuestionnaireBatch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireBatchEN.BatchId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireBatchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionnaireBatch(ref clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
bool bolResult = QuestionnaireBatchDA.GetQuestionnaireBatch(ref objQuestionnaireBatchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strBatchId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchId(string strBatchId)
{
if (strBatchId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strBatchId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strBatchId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strBatchId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionnaireBatchEN objQuestionnaireBatchEN = QuestionnaireBatchDA.GetObjByBatchId(strBatchId);
return objQuestionnaireBatchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionnaireBatchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionnaireBatchEN objQuestionnaireBatchEN = QuestionnaireBatchDA.GetFirstObj(strWhereCond);
 return objQuestionnaireBatchEN;
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
public static clsQuestionnaireBatchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionnaireBatchEN objQuestionnaireBatchEN = QuestionnaireBatchDA.GetObjByDataRow(objRow);
 return objQuestionnaireBatchEN;
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
public static clsQuestionnaireBatchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionnaireBatchEN objQuestionnaireBatchEN = QuestionnaireBatchDA.GetObjByDataRow(objRow);
 return objQuestionnaireBatchEN;
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
 /// <param name = "strBatchId">所给的关键字</param>
 /// <param name = "lstQuestionnaireBatchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchIdFromList(string strBatchId, List<clsQuestionnaireBatchEN> lstQuestionnaireBatchObjLst)
{
foreach (clsQuestionnaireBatchEN objQuestionnaireBatchEN in lstQuestionnaireBatchObjLst)
{
if (objQuestionnaireBatchEN.BatchId == strBatchId)
{
return objQuestionnaireBatchEN;
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
 string strMaxBatchId;
 try
 {
 strMaxBatchId = clsQuestionnaireBatchDA.GetMaxStrId();
 return strMaxBatchId;
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
 string strBatchId;
 try
 {
 strBatchId = new clsQuestionnaireBatchDA().GetFirstID(strWhereCond);
 return strBatchId;
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
 arrList = QuestionnaireBatchDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionnaireBatchDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strBatchId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionnaireBatchDA.IsExist(strBatchId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strBatchId">批次ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strBatchId, string strOpUser)
{
clsQuestionnaireBatchEN objQuestionnaireBatchEN = clsQuestionnaireBatchBL.GetObjByBatchId(strBatchId);
objQuestionnaireBatchEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQuestionnaireBatchEN.UpdUser = strOpUser;
return clsQuestionnaireBatchBL.UpdateBySql2(objQuestionnaireBatchEN);
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
 bolIsExist = clsQuestionnaireBatchDA.IsExistTable();
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
 bolIsExist = QuestionnaireBatchDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireBatchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问卷集ID = [{0}],批次名称 = [{1}]的数据已经存在!(in clsQuestionnaireBatchBL.AddNewRecordBySql2)", objQuestionnaireBatchEN.QuestionnaireSetId,objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
bool bolResult = QuestionnaireBatchDA.AddNewRecordBySQL2(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionnaireBatchEN objQuestionnaireBatchEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireBatchEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问卷集ID = [{0}],批次名称 = [{1}]的数据已经存在!(in clsQuestionnaireBatchBL.AddNewRecordBySql2WithReturnKey)", objQuestionnaireBatchEN.QuestionnaireSetId,objQuestionnaireBatchEN.BatchName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true || clsQuestionnaireBatchBL.IsExist(objQuestionnaireBatchEN.BatchId) == true)
 {
     objQuestionnaireBatchEN.BatchId = clsQuestionnaireBatchBL.GetMaxStrId_S();
 }
string strKey = QuestionnaireBatchDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
try
{
bool bolResult = QuestionnaireBatchDA.Update(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "objQuestionnaireBatchEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireBatchEN.BatchId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionnaireBatchDA.UpdateBySql2(objQuestionnaireBatchEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireBatchBL.ReFreshCache();

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
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
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strBatchId)
{
try
{
 clsQuestionnaireBatchEN objQuestionnaireBatchEN = clsQuestionnaireBatchBL.GetObjByBatchId(strBatchId);

if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(objQuestionnaireBatchEN.BatchId, objQuestionnaireBatchEN.UpdUser);
}
if (objQuestionnaireBatchEN != null)
{
int intRecNum = QuestionnaireBatchDA.DelRecord(strBatchId);
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
/// <param name="strBatchId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strBatchId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireBatch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionnaireBatch.BatchId,
//strBatchId);
//        clsQuestionnaireBatchBL.DelQuestionnaireBatchsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireBatchBL.DelRecord(strBatchId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireBatchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strBatchId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strBatchId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strBatchId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionnaireBatchBL.relatedActions != null)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(strBatchId, "UpdRelaTabDate");
}
bool bolResult = QuestionnaireBatchDA.DelRecord(strBatchId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrBatchIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionnaireBatchs(List<string> arrBatchIdLst)
{
if (arrBatchIdLst.Count == 0) return 0;
try
{
if (clsQuestionnaireBatchBL.relatedActions != null)
{
foreach (var strBatchId in arrBatchIdLst)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(strBatchId, "UpdRelaTabDate");
}
}
int intDelRecNum = QuestionnaireBatchDA.DelQuestionnaireBatch(arrBatchIdLst);
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
public static int DelQuestionnaireBatchsByCond(string strWhereCond)
{
try
{
if (clsQuestionnaireBatchBL.relatedActions != null)
{
List<string> arrBatchId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strBatchId in arrBatchId)
{
clsQuestionnaireBatchBL.relatedActions.UpdRelaTabDate(strBatchId, "UpdRelaTabDate");
}
}
int intRecNum = QuestionnaireBatchDA.DelQuestionnaireBatch(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionnaireBatch]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strBatchId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strBatchId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireBatchDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireBatch]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireBatchBL.DelRecord(strBatchId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireBatchBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strBatchId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionnaireBatchENS">源对象</param>
 /// <param name = "objQuestionnaireBatchENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireBatchEN objQuestionnaireBatchENS, clsQuestionnaireBatchEN objQuestionnaireBatchENT)
{
try
{
objQuestionnaireBatchENT.BatchId = objQuestionnaireBatchENS.BatchId; //批次ID
objQuestionnaireBatchENT.BatchName = objQuestionnaireBatchENS.BatchName; //批次名称
objQuestionnaireBatchENT.RoleId = objQuestionnaireBatchENS.RoleId; //角色Id
objQuestionnaireBatchENT.QuestionnaireSetId = objQuestionnaireBatchENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireBatchENT.IsDefault = objQuestionnaireBatchENS.IsDefault; //是否默认
objQuestionnaireBatchENT.IsDefaultUser = objQuestionnaireBatchENS.IsDefaultUser; //是否默认用户
objQuestionnaireBatchENT.CreateDate = objQuestionnaireBatchENS.CreateDate; //建立日期
objQuestionnaireBatchENT.CreateUser = objQuestionnaireBatchENS.CreateUser; //建立用户
objQuestionnaireBatchENT.PageName = objQuestionnaireBatchENS.PageName; //页面名称
objQuestionnaireBatchENT.IsRandomSelSet = objQuestionnaireBatchENS.IsRandomSelSet; //是否随机选问卷集
objQuestionnaireBatchENT.UpdDate = objQuestionnaireBatchENS.UpdDate; //修改日期
objQuestionnaireBatchENT.UpdUser = objQuestionnaireBatchENS.UpdUser; //修改人
objQuestionnaireBatchENT.Memo = objQuestionnaireBatchENS.Memo; //备注
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
 /// <param name = "objQuestionnaireBatchEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
try
{
objQuestionnaireBatchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionnaireBatchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionnaireBatch.BatchId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.BatchId = objQuestionnaireBatchEN.BatchId; //批次ID
}
if (arrFldSet.Contains(conQuestionnaireBatch.BatchName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.BatchName = objQuestionnaireBatchEN.BatchName; //批次名称
}
if (arrFldSet.Contains(conQuestionnaireBatch.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.RoleId = objQuestionnaireBatchEN.RoleId == "[null]" ? null :  objQuestionnaireBatchEN.RoleId; //角色Id
}
if (arrFldSet.Contains(conQuestionnaireBatch.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.QuestionnaireSetId = objQuestionnaireBatchEN.QuestionnaireSetId == "[null]" ? null :  objQuestionnaireBatchEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(conQuestionnaireBatch.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.IsDefault = objQuestionnaireBatchEN.IsDefault; //是否默认
}
if (arrFldSet.Contains(conQuestionnaireBatch.IsDefaultUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.IsDefaultUser = objQuestionnaireBatchEN.IsDefaultUser; //是否默认用户
}
if (arrFldSet.Contains(conQuestionnaireBatch.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.CreateDate = objQuestionnaireBatchEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conQuestionnaireBatch.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.CreateUser = objQuestionnaireBatchEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conQuestionnaireBatch.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.PageName = objQuestionnaireBatchEN.PageName == "[null]" ? null :  objQuestionnaireBatchEN.PageName; //页面名称
}
if (arrFldSet.Contains(conQuestionnaireBatch.IsRandomSelSet, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.IsRandomSelSet = objQuestionnaireBatchEN.IsRandomSelSet; //是否随机选问卷集
}
if (arrFldSet.Contains(conQuestionnaireBatch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.UpdDate = objQuestionnaireBatchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionnaireBatch.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.UpdUser = objQuestionnaireBatchEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionnaireBatch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireBatchEN.Memo = objQuestionnaireBatchEN.Memo == "[null]" ? null :  objQuestionnaireBatchEN.Memo; //备注
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
 /// <param name = "objQuestionnaireBatchEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
try
{
if (objQuestionnaireBatchEN.RoleId == "[null]") objQuestionnaireBatchEN.RoleId = null; //角色Id
if (objQuestionnaireBatchEN.QuestionnaireSetId == "[null]") objQuestionnaireBatchEN.QuestionnaireSetId = null; //问卷集ID
if (objQuestionnaireBatchEN.PageName == "[null]") objQuestionnaireBatchEN.PageName = null; //页面名称
if (objQuestionnaireBatchEN.Memo == "[null]") objQuestionnaireBatchEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 QuestionnaireBatchDA.CheckPropertyNew(objQuestionnaireBatchEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
 QuestionnaireBatchDA.CheckProperty4Condition(objQuestionnaireBatchEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_BatchIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[问卷批次]...","0");
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst = GetAllQuestionnaireBatchObjLstCache(); 
objDDL.DataValueField = conQuestionnaireBatch.BatchId;
objDDL.DataTextField = conQuestionnaireBatch.BatchName;
objDDL.DataSource = arrQuestionnaireBatchObjLst;
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
if (clsQuestionnaireBatchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBatchBL没有刷新缓存机制(clsQuestionnaireBatchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by BatchId");
//if (arrQuestionnaireBatchObjLstCache == null)
//{
//arrQuestionnaireBatchObjLstCache = QuestionnaireBatchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireBatchEN GetObjByBatchIdCache(string strBatchId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLst_Sel =
arrQuestionnaireBatchObjLstCache
.Where(x=> x.BatchId == strBatchId 
);
if (arrQuestionnaireBatchObjLst_Sel.Count() == 0)
{
   clsQuestionnaireBatchEN obj = clsQuestionnaireBatchBL.GetObjByBatchId(strBatchId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQuestionnaireBatchObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetBatchNameByBatchIdCache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//获取缓存中的对象列表
clsQuestionnaireBatchEN objQuestionnaireBatch = GetObjByBatchIdCache(strBatchId);
if (objQuestionnaireBatch == null) return "";
return objQuestionnaireBatch.BatchName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strBatchId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByBatchIdCache(string strBatchId)
{
if (string.IsNullOrEmpty(strBatchId) == true) return "";
//获取缓存中的对象列表
clsQuestionnaireBatchEN objQuestionnaireBatch = GetObjByBatchIdCache(strBatchId);
if (objQuestionnaireBatch == null) return "";
return objQuestionnaireBatch.BatchName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetAllQuestionnaireBatchObjLstCache()
{
//获取缓存中的对象列表
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLstCache = GetObjLstCache(); 
return arrQuestionnaireBatchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireBatchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName);
List<clsQuestionnaireBatchEN> arrQuestionnaireBatchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionnaireBatchObjLstCache;
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
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionnaireBatchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionnaireBatchEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionnaireBatchEN._RefreshTimeLst[clsQuestionnaireBatchEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQuestionnaireBatchBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionnaireBatchEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionnaireBatchEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionnaireBatchBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QuestionnaireBatch(问卷批次)
 /// 唯一性条件:QuestionnaireSetId_BatchName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireBatchEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionnaireBatchEN objQuestionnaireBatchEN)
{
//检测记录是否存在
string strResult = QuestionnaireBatchDA.GetUniCondStr(objQuestionnaireBatchEN);
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
public static string Func(string strInFldName, string strOutFldName, string strBatchId)
{
if (strInFldName != conQuestionnaireBatch.BatchId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionnaireBatch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionnaireBatch.AttributeName));
throw new Exception(strMsg);
}
var objQuestionnaireBatch = clsQuestionnaireBatchBL.GetObjByBatchIdCache(strBatchId);
if (objQuestionnaireBatch == null) return "";
return objQuestionnaireBatch[strOutFldName].ToString();
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
int intRecCount = clsQuestionnaireBatchDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionnaireBatchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionnaireBatchDA.GetRecCount();
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
int intRecCount = clsQuestionnaireBatchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionnaireBatchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionnaireBatchEN objQuestionnaireBatchCond)
{
List<clsQuestionnaireBatchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireBatchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireBatch.AttributeName)
{
if (objQuestionnaireBatchCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireBatchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireBatchCond[strFldName].ToString());
}
else
{
if (objQuestionnaireBatchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireBatchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireBatchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireBatchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireBatchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireBatchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireBatchCond[strFldName]));
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
 List<string> arrList = clsQuestionnaireBatchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireBatchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireBatchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionnaireBatchDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireBatchDA.SetFldValue(clsQuestionnaireBatchEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionnaireBatchDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireBatchDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireBatchDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireBatchDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionnaireBatch] "); 
 strCreateTabCode.Append(" ( "); 
 // /**批次ID*/ 
 strCreateTabCode.Append(" BatchId char(4) primary key, "); 
 // /**批次名称*/ 
 strCreateTabCode.Append(" BatchName varchar(50) not Null, "); 
 // /**角色Id*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
 // /**问卷集ID*/ 
 strCreateTabCode.Append(" QuestionnaireSetId char(4) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null, "); 
 // /**是否默认用户*/ 
 strCreateTabCode.Append(" IsDefaultUser bit not Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) not Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) not Null, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) Null, "); 
 // /**是否随机选问卷集*/ 
 strCreateTabCode.Append(" IsRandomSelSet bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 问卷批次(QuestionnaireBatch)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionnaireBatch : clsCommFun4BL
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
clsQuestionnaireBatchBL.ReFreshThisCache();
}
}

}