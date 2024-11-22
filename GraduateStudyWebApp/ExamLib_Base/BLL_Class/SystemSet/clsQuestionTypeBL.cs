
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionTypeBL
 表名:QuestionType(01120008)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsQuestionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionTypeEN GetObj(this K_QuestionTypeId_QuestionType myKey)
{
clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.QuestionTypeDA.GetObjByQuestionTypeId(myKey.Value);
return objQuestionTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名 = [{0}]的数据已经存在!(in clsQuestionTypeBL.AddNewRecord)", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsQuestionTypeBL.QuestionTypeDA.AddNewRecordBySQL2(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目类型名(QuestionTypeName)=[{0}])已经存在,不能重复!", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQuestionTypeEN.AddNewRecord();
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名 = [{0}]的数据已经存在!(in clsQuestionTypeBL.AddNewRecordWithMaxId)", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
string strQuestionTypeId = clsQuestionTypeBL.QuestionTypeDA.AddNewRecordBySQL2WithReturnKey(objQuestionTypeEN);
     objQuestionTypeEN.QuestionTypeId = strQuestionTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
}
return strQuestionTypeId;
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!题目类型名 = [{0}]的数据已经存在!(in clsQuestionTypeBL.AddNewRecordWithReturnKey)", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
string strKey = clsQuestionTypeBL.QuestionTypeDA.AddNewRecordBySQL2WithReturnKey(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeId(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionType.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionType.QuestionTypeId);
}
objQuestionTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeName(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName, conQuestionType.QuestionTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, conQuestionType.QuestionTypeName);
}
objQuestionTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeName) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeName, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeName] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeENName(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeENName, 50, conQuestionType.QuestionTypeENName);
}
objQuestionTypeEN.QuestionTypeENName = strQuestionTypeENName; //题目类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeENName) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeENName, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeENName] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetDefaAnswerModeId(this clsQuestionTypeEN objQuestionTypeEN, string strDefaAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaAnswerModeId, 4, conQuestionType.DefaAnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDefaAnswerModeId, 4, conQuestionType.DefaAnswerModeId);
}
objQuestionTypeEN.DefaAnswerModeId = strDefaAnswerModeId; //默认答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.DefaAnswerModeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.DefaAnswerModeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.DefaAnswerModeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetDefaAnswerTypeId(this clsQuestionTypeEN objQuestionTypeEN, string strDefaAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaAnswerTypeId, 2, conQuestionType.DefaAnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDefaAnswerTypeId, 2, conQuestionType.DefaAnswerTypeId);
}
objQuestionTypeEN.DefaAnswerTypeId = strDefaAnswerTypeId; //默认答案类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.DefaAnswerTypeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.DefaAnswerTypeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.DefaAnswerTypeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetOrderNum(this clsQuestionTypeEN objQuestionTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objQuestionTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.OrderNum) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.OrderNum, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.OrderNum] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetIsUse(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objQuestionTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.IsUse) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.IsUse, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.IsUse] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetIsExercise(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsExercise, string strComparisonOp="")
	{
objQuestionTypeEN.IsExercise = bolIsExercise; //是否练习题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.IsExercise) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.IsExercise, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.IsExercise] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetUpdDate(this clsQuestionTypeEN objQuestionTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionType.UpdDate);
}
objQuestionTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.UpdDate) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.UpdDate, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.UpdDate] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetUpdUser(this clsQuestionTypeEN objQuestionTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionType.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionType.UpdUser);
}
objQuestionTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.UpdUser) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.UpdUser, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.UpdUser] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionTypeEN SetMemo(this clsQuestionTypeEN objQuestionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionType.Memo);
}
objQuestionTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.Memo) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.Memo, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.Memo] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionTypeEN objQuestionTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionTypeEN.CheckPropertyNew();
clsQuestionTypeEN objQuestionTypeCond = new clsQuestionTypeEN();
string strCondition = objQuestionTypeCond
.SetQuestionTypeId(objQuestionTypeEN.QuestionTypeId, "<>")
.SetQuestionTypeName(objQuestionTypeEN.QuestionTypeName, "=")
.GetCombineCondition();
objQuestionTypeEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionTypeEN.Update();
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
 /// <param name = "objQuestionType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionTypeEN objQuestionType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionTypeEN objQuestionTypeCond = new clsQuestionTypeEN();
string strCondition = objQuestionTypeCond
.SetQuestionTypeName(objQuestionType.QuestionTypeName, "=")
.GetCombineCondition();
objQuestionType._IsCheckProperty = true;
bool bolIsExist = clsQuestionTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionType.QuestionTypeId = clsQuestionTypeBL.GetFirstID_S(strCondition);
objQuestionType.UpdateWithCondition(strCondition);
}
else
{
objQuestionType.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
objQuestionType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionTypeEN objQuestionTypeEN)
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionTypeBL.QuestionTypeDA.UpdateBySql2(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionTypeEN objQuestionTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionTypeBL.QuestionTypeDA.UpdateBySql2(objQuestionTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionTypeEN objQuestionTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionTypeBL.QuestionTypeDA.UpdateBySqlWithCondition(objQuestionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionTypeEN objQuestionTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionTypeBL.QuestionTypeDA.UpdateBySqlWithConditionTransaction(objQuestionTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionTypeEN objQuestionTypeEN)
{
try
{
int intRecNum = clsQuestionTypeBL.QuestionTypeDA.DelRecord(objQuestionTypeEN.QuestionTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeENS">源对象</param>
 /// <param name = "objQuestionTypeENT">目标对象</param>
 public static void CopyTo(this clsQuestionTypeEN objQuestionTypeENS, clsQuestionTypeEN objQuestionTypeENT)
{
try
{
objQuestionTypeENT.QuestionTypeId = objQuestionTypeENS.QuestionTypeId; //题目类型Id
objQuestionTypeENT.QuestionTypeName = objQuestionTypeENS.QuestionTypeName; //题目类型名
objQuestionTypeENT.QuestionTypeENName = objQuestionTypeENS.QuestionTypeENName; //题目类型英文名
objQuestionTypeENT.DefaAnswerModeId = objQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objQuestionTypeENT.DefaAnswerTypeId = objQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objQuestionTypeENT.OrderNum = objQuestionTypeENS.OrderNum; //序号
objQuestionTypeENT.IsUse = objQuestionTypeENS.IsUse; //是否使用
objQuestionTypeENT.IsExercise = objQuestionTypeENS.IsExercise; //是否练习题
objQuestionTypeENT.UpdDate = objQuestionTypeENS.UpdDate; //修改日期
objQuestionTypeENT.UpdUser = objQuestionTypeENS.UpdUser; //修改人
objQuestionTypeENT.Memo = objQuestionTypeENS.Memo; //备注
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
 /// <param name = "objQuestionTypeENS">源对象</param>
 /// <returns>目标对象=>clsQuestionTypeEN:objQuestionTypeENT</returns>
 public static clsQuestionTypeEN CopyTo(this clsQuestionTypeEN objQuestionTypeENS)
{
try
{
 clsQuestionTypeEN objQuestionTypeENT = new clsQuestionTypeEN()
{
QuestionTypeId = objQuestionTypeENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objQuestionTypeENS.QuestionTypeName, //题目类型名
QuestionTypeENName = objQuestionTypeENS.QuestionTypeENName, //题目类型英文名
DefaAnswerModeId = objQuestionTypeENS.DefaAnswerModeId, //默认答案模式Id
DefaAnswerTypeId = objQuestionTypeENS.DefaAnswerTypeId, //默认答案类型Id
OrderNum = objQuestionTypeENS.OrderNum, //序号
IsUse = objQuestionTypeENS.IsUse, //是否使用
IsExercise = objQuestionTypeENS.IsExercise, //是否练习题
UpdDate = objQuestionTypeENS.UpdDate, //修改日期
UpdUser = objQuestionTypeENS.UpdUser, //修改人
Memo = objQuestionTypeENS.Memo, //备注
};
 return objQuestionTypeENT;
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
public static void CheckPropertyNew(this clsQuestionTypeEN objQuestionTypeEN)
{
 clsQuestionTypeBL.QuestionTypeDA.CheckPropertyNew(objQuestionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionTypeEN objQuestionTypeEN)
{
 clsQuestionTypeBL.QuestionTypeDA.CheckProperty4Condition(objQuestionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionTypeEN objQuestionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionTypeCond.IsUpdated(conQuestionType.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeId, objQuestionTypeCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeName, objQuestionTypeCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.QuestionTypeENName) == true)
{
string strComparisonOpQuestionTypeENName = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.QuestionTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeENName, objQuestionTypeCond.QuestionTypeENName, strComparisonOpQuestionTypeENName);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.DefaAnswerModeId) == true)
{
string strComparisonOpDefaAnswerModeId = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.DefaAnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.DefaAnswerModeId, objQuestionTypeCond.DefaAnswerModeId, strComparisonOpDefaAnswerModeId);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.DefaAnswerTypeId) == true)
{
string strComparisonOpDefaAnswerTypeId = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.DefaAnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.DefaAnswerTypeId, objQuestionTypeCond.DefaAnswerTypeId, strComparisonOpDefaAnswerTypeId);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.OrderNum) == true)
{
string strComparisonOpOrderNum = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionType.OrderNum, objQuestionTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.IsUse) == true)
{
if (objQuestionTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionType.IsUse);
}
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.IsExercise) == true)
{
if (objQuestionTypeCond.IsExercise == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionType.IsExercise);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionType.IsExercise);
}
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.UpdDate, objQuestionTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.UpdUser, objQuestionTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionTypeCond.IsUpdated(conQuestionType.Memo) == true)
{
string strComparisonOpMemo = objQuestionTypeCond.dicFldComparisonOp[conQuestionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.Memo, objQuestionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QuestionType(题目类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionTypeEN objQuestionTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionTypeEN == null) return true;
if (objQuestionTypeEN.QuestionTypeId == null || objQuestionTypeEN.QuestionTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionTypeName = '{0}'", objQuestionTypeEN.QuestionTypeName);
if (clsQuestionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionTypeId !=  '{0}'", objQuestionTypeEN.QuestionTypeId);
 sbCondition.AppendFormat(" and QuestionTypeName = '{0}'", objQuestionTypeEN.QuestionTypeName);
if (clsQuestionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QuestionType(题目类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionTypeEN objQuestionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionTypeEN == null) return "";
if (objQuestionTypeEN.QuestionTypeId == null || objQuestionTypeEN.QuestionTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionTypeName = '{0}'", objQuestionTypeEN.QuestionTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionTypeId !=  '{0}'", objQuestionTypeEN.QuestionTypeId);
 sbCondition.AppendFormat(" and QuestionTypeName = '{0}'", objQuestionTypeEN.QuestionTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionType
{
public virtual bool UpdRelaTabDate(string strQuestionTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumQuestionType
{
 /// <summary>
 /// 填空题
 /// </summary>
public const string FillInBlank_01 = "01";
 /// <summary>
 /// 单选题
 /// </summary>
public const string SingleChoice_02 = "02";
 /// <summary>
 /// 多选题
 /// </summary>
public const string MultipleChoice_03 = "03";
 /// <summary>
 /// 开放题
 /// </summary>
public const string OpenQuestion_04 = "04";
 /// <summary>
 /// 解答题
 /// </summary>
public const string AnswerQuestions_05 = "05";
 /// <summary>
 /// 标题
 /// </summary>
public const string Title_06 = "06";
 /// <summary>
 /// 说明性内容
 /// </summary>
public const string ExplanatoryContent_07 = "07";
 /// <summary>
 /// 单选题(下拉框)
 /// </summary>
public const string SingleChoice_DropDownBox_08 = "08";
 /// <summary>
 /// 操作题
 /// </summary>
public const string OperationQuestions_09 = "09";
 /// <summary>
 /// 简答题
 /// </summary>
public const string ShortAnswer_10 = "10";
 /// <summary>
 /// 判断题
 /// </summary>
public const string TrueorFalse_11 = "11";
 /// <summary>
 /// 案例分析题
 /// </summary>
public const string CaseAnysisMultiChoice_12 = "12";
 /// <summary>
 /// 录音分析题
 /// </summary>
public const string RecorderAndAnysis_13 = "13";
 /// <summary>
 /// 知识结构图
 /// </summary>
public const string KnowledgeStructureDiagram_14 = "14";
 /// <summary>
 /// 知识逻辑关系图
 /// </summary>
public const string KnowledgeLogicDiagram_15 = "15";
 /// <summary>
 /// 连连看多选题
 /// </summary>
public const string LianliankanMultipleChoiceQuestions_17 = "17";
 /// <summary>
 /// 概念题
 /// </summary>
public const string ConceptQuestion_18 = "18";
}
 /// <summary>
 /// 题目类型(QuestionType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionTypeBL
{
public static RelatedActions_QuestionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionTypeDA QuestionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionTypeDA();
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
 public clsQuestionTypeBL()
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
if (string.IsNullOrEmpty(clsQuestionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionTypeEN._ConnectString);
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
public static DataTable GetDataTable_QuestionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionTypeDA.GetDataTable_QuestionType(strWhereCond);
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
objDT = QuestionTypeDA.GetDataTable(strWhereCond);
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
objDT = QuestionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeIdLst)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionTypeIdLst, true);
 string strWhereCond = string.Format("QuestionTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionTypeEN> GetObjLstByQuestionTypeIdLstCache(List<string> arrQuestionTypeIdLst)
{
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName);
List<clsQuestionTypeEN> arrQuestionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel =
arrQuestionTypeObjLstCache
.Where(x => arrQuestionTypeIdLst.Contains(x.QuestionTypeId));
return arrQuestionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLst(string strWhereCond)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
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
public static List<clsQuestionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionTypeEN> GetSubObjLstCache(clsQuestionTypeEN objQuestionTypeCond)
{
List<clsQuestionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionType.AttributeName)
{
if (objQuestionTypeCond.IsUpdated(strFldName) == false) continue;
if (objQuestionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionTypeCond[strFldName].ToString());
}
else
{
if (objQuestionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionTypeCond[strFldName]));
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
public static List<clsQuestionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
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
public static List<clsQuestionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
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
List<clsQuestionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
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
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
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
public static List<clsQuestionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
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
public static List<clsQuestionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionTypeEN> arrObjLst = new List<clsQuestionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN();
try
{
objQuestionTypeEN.QuestionTypeId = objRow[conQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objQuestionTypeEN.QuestionTypeName = objRow[conQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objQuestionTypeEN.QuestionTypeENName = objRow[conQuestionType.QuestionTypeENName] == DBNull.Value ? null : objRow[conQuestionType.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objQuestionTypeEN.DefaAnswerModeId = objRow[conQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objQuestionTypeEN.DefaAnswerTypeId = objRow[conQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[conQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objQuestionTypeEN.OrderNum = objRow[conQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType.OrderNum].ToString().Trim()); //序号
objQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsUse].ToString().Trim()); //是否使用
objQuestionTypeEN.IsExercise = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType.IsExercise].ToString().Trim()); //是否练习题
objQuestionTypeEN.UpdDate = objRow[conQuestionType.UpdDate].ToString().Trim(); //修改日期
objQuestionTypeEN.UpdUser = objRow[conQuestionType.UpdUser].ToString().Trim(); //修改人
objQuestionTypeEN.Memo = objRow[conQuestionType.Memo] == DBNull.Value ? null : objRow[conQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionType(ref clsQuestionTypeEN objQuestionTypeEN)
{
bool bolResult = QuestionTypeDA.GetQuestionType(ref objQuestionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
if (strQuestionTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionTypeEN objQuestionTypeEN = QuestionTypeDA.GetObjByQuestionTypeId(strQuestionTypeId);
return objQuestionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionTypeEN objQuestionTypeEN = QuestionTypeDA.GetFirstObj(strWhereCond);
 return objQuestionTypeEN;
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
public static clsQuestionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionTypeEN objQuestionTypeEN = QuestionTypeDA.GetObjByDataRow(objRow);
 return objQuestionTypeEN;
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
public static clsQuestionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionTypeEN objQuestionTypeEN = QuestionTypeDA.GetObjByDataRow(objRow);
 return objQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <param name = "lstQuestionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeIdFromList(string strQuestionTypeId, List<clsQuestionTypeEN> lstQuestionTypeObjLst)
{
foreach (clsQuestionTypeEN objQuestionTypeEN in lstQuestionTypeObjLst)
{
if (objQuestionTypeEN.QuestionTypeId == strQuestionTypeId)
{
return objQuestionTypeEN;
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
 string strMaxQuestionTypeId;
 try
 {
 strMaxQuestionTypeId = clsQuestionTypeDA.GetMaxStrId();
 return strMaxQuestionTypeId;
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
 string strQuestionTypeId;
 try
 {
 strQuestionTypeId = new clsQuestionTypeDA().GetFirstID(strWhereCond);
 return strQuestionTypeId;
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
 arrList = QuestionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionTypeDA.IsExist(strQuestionTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strQuestionTypeId">题目类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strQuestionTypeId, string strOpUser)
{
clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeId(strQuestionTypeId);
objQuestionTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQuestionTypeEN.UpdUser = strOpUser;
return clsQuestionTypeBL.UpdateBySql2(objQuestionTypeEN);
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
 bolIsExist = clsQuestionTypeDA.IsExistTable();
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
 bolIsExist = QuestionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目类型名 = [{0}]的数据已经存在!(in clsQuestionTypeBL.AddNewRecordBySql2)", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
bool bolResult = QuestionTypeDA.AddNewRecordBySQL2(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionTypeEN objQuestionTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目类型名 = [{0}]的数据已经存在!(in clsQuestionTypeBL.AddNewRecordBySql2WithReturnKey)", objQuestionTypeEN.QuestionTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true || clsQuestionTypeBL.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
     objQuestionTypeEN.QuestionTypeId = clsQuestionTypeBL.GetMaxStrId_S();
 }
string strKey = QuestionTypeDA.AddNewRecordBySQL2WithReturnKey(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionTypeEN objQuestionTypeEN)
{
try
{
bool bolResult = QuestionTypeDA.Update(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionTypeEN objQuestionTypeEN)
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionTypeDA.UpdateBySql2(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeBL.ReFreshCache();

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
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
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQuestionTypeId)
{
try
{
 clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeBL.GetObjByQuestionTypeId(strQuestionTypeId);

if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(objQuestionTypeEN.QuestionTypeId, objQuestionTypeEN.UpdUser);
}
if (objQuestionTypeEN != null)
{
int intRecNum = QuestionTypeDA.DelRecord(strQuestionTypeId);
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
/// <param name="strQuestionTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strQuestionTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionTypeDA.GetSpecSQLObj();
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
//删除与表:[QuestionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionType.QuestionTypeId,
//strQuestionTypeId);
//        clsQuestionTypeBL.DelQuestionTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionTypeBL.DelRecord(strQuestionTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQuestionTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionTypeBL.relatedActions != null)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(strQuestionTypeId, "UpdRelaTabDate");
}
bool bolResult = QuestionTypeDA.DelRecord(strQuestionTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionTypes(List<string> arrQuestionTypeIdLst)
{
if (arrQuestionTypeIdLst.Count == 0) return 0;
try
{
if (clsQuestionTypeBL.relatedActions != null)
{
foreach (var strQuestionTypeId in arrQuestionTypeIdLst)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(strQuestionTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = QuestionTypeDA.DelQuestionType(arrQuestionTypeIdLst);
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
public static int DelQuestionTypesByCond(string strWhereCond)
{
try
{
if (clsQuestionTypeBL.relatedActions != null)
{
List<string> arrQuestionTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionTypeId in arrQuestionTypeId)
{
clsQuestionTypeBL.relatedActions.UpdRelaTabDate(strQuestionTypeId, "UpdRelaTabDate");
}
}
int intRecNum = QuestionTypeDA.DelQuestionType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQuestionTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQuestionTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionTypeDA.GetSpecSQLObj();
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
//删除与表:[QuestionType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionTypeBL.DelRecord(strQuestionTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionTypeENS">源对象</param>
 /// <param name = "objQuestionTypeENT">目标对象</param>
 public static void CopyTo(clsQuestionTypeEN objQuestionTypeENS, clsQuestionTypeEN objQuestionTypeENT)
{
try
{
objQuestionTypeENT.QuestionTypeId = objQuestionTypeENS.QuestionTypeId; //题目类型Id
objQuestionTypeENT.QuestionTypeName = objQuestionTypeENS.QuestionTypeName; //题目类型名
objQuestionTypeENT.QuestionTypeENName = objQuestionTypeENS.QuestionTypeENName; //题目类型英文名
objQuestionTypeENT.DefaAnswerModeId = objQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objQuestionTypeENT.DefaAnswerTypeId = objQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objQuestionTypeENT.OrderNum = objQuestionTypeENS.OrderNum; //序号
objQuestionTypeENT.IsUse = objQuestionTypeENS.IsUse; //是否使用
objQuestionTypeENT.IsExercise = objQuestionTypeENS.IsExercise; //是否练习题
objQuestionTypeENT.UpdDate = objQuestionTypeENS.UpdDate; //修改日期
objQuestionTypeENT.UpdUser = objQuestionTypeENS.UpdUser; //修改人
objQuestionTypeENT.Memo = objQuestionTypeENS.Memo; //备注
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
 /// <param name = "objQuestionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionTypeEN objQuestionTypeEN)
{
try
{
objQuestionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionType.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.QuestionTypeId = objQuestionTypeEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(conQuestionType.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.QuestionTypeName = objQuestionTypeEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(conQuestionType.QuestionTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.QuestionTypeENName = objQuestionTypeEN.QuestionTypeENName == "[null]" ? null :  objQuestionTypeEN.QuestionTypeENName; //题目类型英文名
}
if (arrFldSet.Contains(conQuestionType.DefaAnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.DefaAnswerModeId = objQuestionTypeEN.DefaAnswerModeId == "[null]" ? null :  objQuestionTypeEN.DefaAnswerModeId; //默认答案模式Id
}
if (arrFldSet.Contains(conQuestionType.DefaAnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.DefaAnswerTypeId = objQuestionTypeEN.DefaAnswerTypeId == "[null]" ? null :  objQuestionTypeEN.DefaAnswerTypeId; //默认答案类型Id
}
if (arrFldSet.Contains(conQuestionType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.OrderNum = objQuestionTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conQuestionType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.IsUse = objQuestionTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conQuestionType.IsExercise, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.IsExercise = objQuestionTypeEN.IsExercise; //是否练习题
}
if (arrFldSet.Contains(conQuestionType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.UpdDate = objQuestionTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.UpdUser = objQuestionTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionTypeEN.Memo = objQuestionTypeEN.Memo == "[null]" ? null :  objQuestionTypeEN.Memo; //备注
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
 /// <param name = "objQuestionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionTypeEN objQuestionTypeEN)
{
try
{
if (objQuestionTypeEN.QuestionTypeENName == "[null]") objQuestionTypeEN.QuestionTypeENName = null; //题目类型英文名
if (objQuestionTypeEN.DefaAnswerModeId == "[null]") objQuestionTypeEN.DefaAnswerModeId = null; //默认答案模式Id
if (objQuestionTypeEN.DefaAnswerTypeId == "[null]") objQuestionTypeEN.DefaAnswerTypeId = null; //默认答案类型Id
if (objQuestionTypeEN.Memo == "[null]") objQuestionTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionTypeEN objQuestionTypeEN)
{
 QuestionTypeDA.CheckPropertyNew(objQuestionTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionTypeEN objQuestionTypeEN)
{
 QuestionTypeDA.CheckProperty4Condition(objQuestionTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目类型]...","0");
List<clsQuestionTypeEN> arrQuestionTypeObjLst = GetAllQuestionTypeObjLstCache(); 
objDDL.DataValueField = conQuestionType.QuestionTypeId;
objDDL.DataTextField = conQuestionType.QuestionTypeName;
objDDL.DataSource = arrQuestionTypeObjLst;
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
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrQuestionTypeObjLstCache == null)
//{
//arrQuestionTypeObjLstCache = QuestionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeIdCache(string strQuestionTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName);
List<clsQuestionTypeEN> arrQuestionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel =
arrQuestionTypeObjLstCache
.Where(x=> x.QuestionTypeId == strQuestionTypeId 
);
if (arrQuestionTypeObjLst_Sel.Count() == 0)
{
   clsQuestionTypeEN obj = clsQuestionTypeBL.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQuestionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeNameByQuestionTypeIdCache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//获取缓存中的对象列表
clsQuestionTypeEN objQuestionType = GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objQuestionType == null) return "";
return objQuestionType.QuestionTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeIdCache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//获取缓存中的对象列表
clsQuestionTypeEN objQuestionType = GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objQuestionType == null) return "";
return objQuestionType.QuestionTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionTypeEN> GetAllQuestionTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsQuestionTypeEN> arrQuestionTypeObjLstCache = GetObjLstCache(); 
return arrQuestionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName);
List<clsQuestionTypeEN> arrQuestionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionTypeObjLstCache;
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
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionTypeEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionTypeEN._RefreshTimeLst[clsQuestionTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQuestionTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QuestionType(题目类型)
 /// 唯一性条件:QuestionTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionTypeEN objQuestionTypeEN)
{
//检测记录是否存在
string strResult = QuestionTypeDA.GetUniCondStr(objQuestionTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionTypeId)
{
if (strInFldName != conQuestionType.QuestionTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionType.AttributeName));
throw new Exception(strMsg);
}
var objQuestionType = clsQuestionTypeBL.GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objQuestionType == null) return "";
return objQuestionType[strOutFldName].ToString();
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
int intRecCount = clsQuestionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionTypeDA.GetRecCount();
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
int intRecCount = clsQuestionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionTypeEN objQuestionTypeCond)
{
List<clsQuestionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionType.AttributeName)
{
if (objQuestionTypeCond.IsUpdated(strFldName) == false) continue;
if (objQuestionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionTypeCond[strFldName].ToString());
}
else
{
if (objQuestionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionTypeCond[strFldName]));
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
 List<string> arrList = clsQuestionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionTypeDA.SetFldValue(clsQuestionTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) primary key, "); 
 // /**题目类型名*/ 
 strCreateTabCode.Append(" QuestionTypeName varchar(20) not Null, "); 
 // /**题目类型英文名*/ 
 strCreateTabCode.Append(" QuestionTypeENName varchar(50) Null, "); 
 // /**默认答案模式Id*/ 
 strCreateTabCode.Append(" DefaAnswerModeId char(4) Null, "); 
 // /**默认答案类型Id*/ 
 strCreateTabCode.Append(" DefaAnswerTypeId char(2) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**是否练习题*/ 
 strCreateTabCode.Append(" IsExercise bit Null, "); 
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
 /// 题目类型(QuestionType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionType : clsCommFun4BL
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
clsQuestionTypeBL.ReFreshThisCache();
}
}

}