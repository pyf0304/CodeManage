
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachAppraiseBL
 表名:MicroteachAppraise(01120264)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:36
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
public static class  clsMicroteachAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachAppraiseEN GetObj(this K_IdMicroteachAppraise_MicroteachAppraise myKey)
{
clsMicroteachAppraiseEN objMicroteachAppraiseEN = clsMicroteachAppraiseBL.MicroteachAppraiseDA.GetObjByIdMicroteachAppraise(myKey.Value);
return objMicroteachAppraiseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (CheckUniqueness(objMicroteachAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsMicroteachAppraiseBL.AddNewRecord)", objMicroteachAppraiseEN.IdMicroteachCase,objMicroteachAppraiseEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsMicroteachAppraiseBL.MicroteachAppraiseDA.AddNewRecordBySQL2(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
public static bool AddRecordEx(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
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
objMicroteachAppraiseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMicroteachAppraiseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(微格教学案例流水号(IdMicroteachCase)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objMicroteachAppraiseEN.IdMicroteachCase, objMicroteachAppraiseEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objMicroteachAppraiseEN.AddNewRecord();
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (CheckUniqueness(objMicroteachAppraiseEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsMicroteachAppraiseBL.AddNewRecordWithReturnKey)", objMicroteachAppraiseEN.IdMicroteachCase,objMicroteachAppraiseEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsMicroteachAppraiseBL.MicroteachAppraiseDA.AddNewRecordBySQL2WithReturnKey(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIdMicroteachAppraise(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, long lngIdMicroteachAppraise, string strComparisonOp="")
	{
objMicroteachAppraiseEN.IdMicroteachAppraise = lngIdMicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IdMicroteachAppraise) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IdMicroteachAppraise, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IdMicroteachAppraise] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetFuncModuleId(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroteachAppraise.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroteachAppraise.FuncModuleId);
}
objMicroteachAppraiseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.FuncModuleId) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.FuncModuleId, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.FuncModuleId] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIdMicroteachCase(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, conMicroteachAppraise.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, conMicroteachAppraise.IdMicroteachCase);
}
objMicroteachAppraiseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IdMicroteachCase) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IdMicroteachCase, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IdMicroteachCase] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIdAppraiseType(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, conMicroteachAppraise.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, conMicroteachAppraise.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, conMicroteachAppraise.IdAppraiseType);
}
objMicroteachAppraiseEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IdAppraiseType) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IdAppraiseType, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IdAppraiseType] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseTheme(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, conMicroteachAppraise.AppraiseTheme);
}
objMicroteachAppraiseEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseTheme) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseTheme, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseTheme] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseContent(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, conMicroteachAppraise.AppraiseContent);
}
objMicroteachAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseContent) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseContent, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseContent] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseDate(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, conMicroteachAppraise.AppraiseDate);
}
objMicroteachAppraiseEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseDate) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseDate, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseDate] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetAppraiseTime(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strAppraiseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, conMicroteachAppraise.AppraiseTime);
}
objMicroteachAppraiseEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.AppraiseTime) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.AppraiseTime, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.AppraiseTime] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIsVisual(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, bool bolIsVisual, string strComparisonOp="")
	{
objMicroteachAppraiseEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IsVisual) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IsVisual, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IsVisual] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetIsElite(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, bool bolIsElite, string strComparisonOp="")
	{
objMicroteachAppraiseEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.IsElite) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.IsElite, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.IsElite] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetExcellentOne(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strExcellentOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentOne, 1000, conMicroteachAppraise.ExcellentOne);
}
objMicroteachAppraiseEN.ExcellentOne = strExcellentOne; //优点1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.ExcellentOne) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.ExcellentOne, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.ExcellentOne] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetExcellentTwo(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strExcellentTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTwo, 1000, conMicroteachAppraise.ExcellentTwo);
}
objMicroteachAppraiseEN.ExcellentTwo = strExcellentTwo; //优点2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.ExcellentTwo) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.ExcellentTwo, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.ExcellentTwo] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetSuggestOne(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strSuggestOne, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestOne, 1000, conMicroteachAppraise.SuggestOne);
}
objMicroteachAppraiseEN.SuggestOne = strSuggestOne; //建议1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.SuggestOne) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.SuggestOne, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.SuggestOne] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetSuggestTwo(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strSuggestTwo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuggestTwo, 1000, conMicroteachAppraise.SuggestTwo);
}
objMicroteachAppraiseEN.SuggestTwo = strSuggestTwo; //建议2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.SuggestTwo) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.SuggestTwo, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.SuggestTwo] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetMicroteachAppriseScore(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, float? fltMicroteachAppriseScore, string strComparisonOp="")
	{
objMicroteachAppraiseEN.MicroteachAppriseScore = fltMicroteachAppriseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.MicroteachAppriseScore) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.MicroteachAppriseScore, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.MicroteachAppriseScore] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetVideoStopTime(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strVideoStopTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, conMicroteachAppraise.VideoStopTime);
}
objMicroteachAppraiseEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.VideoStopTime) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.VideoStopTime, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.VideoStopTime] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetBrowseCount(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, int? intBrowseCount, string strComparisonOp="")
	{
objMicroteachAppraiseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.BrowseCount) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.BrowseCount, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.BrowseCount] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachAppraiseEN SetUserId(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conMicroteachAppraise.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conMicroteachAppraise.UserId);
}
objMicroteachAppraiseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachAppraiseEN.dicFldComparisonOp.ContainsKey(conMicroteachAppraise.UserId) == false)
{
objMicroteachAppraiseEN.dicFldComparisonOp.Add(conMicroteachAppraise.UserId, strComparisonOp);
}
else
{
objMicroteachAppraiseEN.dicFldComparisonOp[conMicroteachAppraise.UserId] = strComparisonOp;
}
}
return objMicroteachAppraiseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachAppraiseEN.CheckPropertyNew();
clsMicroteachAppraiseEN objMicroteachAppraiseCond = new clsMicroteachAppraiseEN();
string strCondition = objMicroteachAppraiseCond
.SetIdMicroteachAppraise(objMicroteachAppraiseEN.IdMicroteachAppraise, "<>")
.SetIdMicroteachCase(objMicroteachAppraiseEN.IdMicroteachCase, "=")
.SetUserId(objMicroteachAppraiseEN.UserId, "=")
.GetCombineCondition();
objMicroteachAppraiseEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_MicroteachCase_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachAppraiseEN.Update();
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
 /// <param name = "objMicroteachAppraise">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMicroteachAppraiseEN objMicroteachAppraise)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMicroteachAppraiseEN objMicroteachAppraiseCond = new clsMicroteachAppraiseEN();
string strCondition = objMicroteachAppraiseCond
.SetIdMicroteachCase(objMicroteachAppraise.IdMicroteachCase, "=")
.SetUserId(objMicroteachAppraise.UserId, "=")
.GetCombineCondition();
objMicroteachAppraise._IsCheckProperty = true;
bool bolIsExist = clsMicroteachAppraiseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMicroteachAppraise.IdMicroteachAppraise = clsMicroteachAppraiseBL.GetFirstID_S(strCondition);
objMicroteachAppraise.UpdateWithCondition(strCondition);
}
else
{
objMicroteachAppraise.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN.IdMicroteachAppraise == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachAppraiseBL.MicroteachAppraiseDA.UpdateBySql2(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachAppraiseEN.IdMicroteachAppraise == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachAppraiseBL.MicroteachAppraiseDA.UpdateBySql2(objMicroteachAppraiseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachAppraiseBL.MicroteachAppraiseDA.UpdateBySqlWithCondition(objMicroteachAppraiseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachAppraiseEN objMicroteachAppraiseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachAppraiseBL.MicroteachAppraiseDA.UpdateBySqlWithConditionTransaction(objMicroteachAppraiseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
try
{
int intRecNum = clsMicroteachAppraiseBL.MicroteachAppraiseDA.DelRecord(objMicroteachAppraiseEN.IdMicroteachAppraise);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseENS">源对象</param>
 /// <param name = "objMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(this clsMicroteachAppraiseEN objMicroteachAppraiseENS, clsMicroteachAppraiseEN objMicroteachAppraiseENT)
{
try
{
objMicroteachAppraiseENT.IdMicroteachAppraise = objMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objMicroteachAppraiseENT.FuncModuleId = objMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objMicroteachAppraiseENT.IdMicroteachCase = objMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachAppraiseENT.IdAppraiseType = objMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objMicroteachAppraiseENT.AppraiseTheme = objMicroteachAppraiseENS.AppraiseTheme; //评议主题
objMicroteachAppraiseENT.AppraiseContent = objMicroteachAppraiseENS.AppraiseContent; //评议内容
objMicroteachAppraiseENT.AppraiseDate = objMicroteachAppraiseENS.AppraiseDate; //评议日期
objMicroteachAppraiseENT.AppraiseTime = objMicroteachAppraiseENS.AppraiseTime; //评议时间
objMicroteachAppraiseENT.IsVisual = objMicroteachAppraiseENS.IsVisual; //隐藏标志
objMicroteachAppraiseENT.IsElite = objMicroteachAppraiseENS.IsElite; //精华标志
objMicroteachAppraiseENT.ExcellentOne = objMicroteachAppraiseENS.ExcellentOne; //优点1
objMicroteachAppraiseENT.ExcellentTwo = objMicroteachAppraiseENS.ExcellentTwo; //优点2
objMicroteachAppraiseENT.SuggestOne = objMicroteachAppraiseENS.SuggestOne; //建议1
objMicroteachAppraiseENT.SuggestTwo = objMicroteachAppraiseENS.SuggestTwo; //建议2
objMicroteachAppraiseENT.MicroteachAppriseScore = objMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objMicroteachAppraiseENT.VideoStopTime = objMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objMicroteachAppraiseENT.BrowseCount = objMicroteachAppraiseENS.BrowseCount; //浏览次数
objMicroteachAppraiseENT.UserId = objMicroteachAppraiseENS.UserId; //用户ID
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
 /// <param name = "objMicroteachAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachAppraiseEN:objMicroteachAppraiseENT</returns>
 public static clsMicroteachAppraiseEN CopyTo(this clsMicroteachAppraiseEN objMicroteachAppraiseENS)
{
try
{
 clsMicroteachAppraiseEN objMicroteachAppraiseENT = new clsMicroteachAppraiseEN()
{
IdMicroteachAppraise = objMicroteachAppraiseENS.IdMicroteachAppraise, //评议流水号
FuncModuleId = objMicroteachAppraiseENS.FuncModuleId, //功能模块Id
IdMicroteachCase = objMicroteachAppraiseENS.IdMicroteachCase, //微格教学案例流水号
IdAppraiseType = objMicroteachAppraiseENS.IdAppraiseType, //评议类型流水号
AppraiseTheme = objMicroteachAppraiseENS.AppraiseTheme, //评议主题
AppraiseContent = objMicroteachAppraiseENS.AppraiseContent, //评议内容
AppraiseDate = objMicroteachAppraiseENS.AppraiseDate, //评议日期
AppraiseTime = objMicroteachAppraiseENS.AppraiseTime, //评议时间
IsVisual = objMicroteachAppraiseENS.IsVisual, //隐藏标志
IsElite = objMicroteachAppraiseENS.IsElite, //精华标志
ExcellentOne = objMicroteachAppraiseENS.ExcellentOne, //优点1
ExcellentTwo = objMicroteachAppraiseENS.ExcellentTwo, //优点2
SuggestOne = objMicroteachAppraiseENS.SuggestOne, //建议1
SuggestTwo = objMicroteachAppraiseENS.SuggestTwo, //建议2
MicroteachAppriseScore = objMicroteachAppraiseENS.MicroteachAppriseScore, //打分
VideoStopTime = objMicroteachAppraiseENS.VideoStopTime, //公开课案例视频暂停时间
BrowseCount = objMicroteachAppraiseENS.BrowseCount, //浏览次数
UserId = objMicroteachAppraiseENS.UserId, //用户ID
};
 return objMicroteachAppraiseENT;
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
public static void CheckPropertyNew(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 clsMicroteachAppraiseBL.MicroteachAppraiseDA.CheckPropertyNew(objMicroteachAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 clsMicroteachAppraiseBL.MicroteachAppraiseDA.CheckProperty4Condition(objMicroteachAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachAppraiseEN objMicroteachAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.IdMicroteachAppraise) == true)
{
string strComparisonOpIdMicroteachAppraise = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.IdMicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.IdMicroteachAppraise, objMicroteachAppraiseCond.IdMicroteachAppraise, strComparisonOpIdMicroteachAppraise);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.FuncModuleId, objMicroteachAppraiseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.IdMicroteachCase, objMicroteachAppraiseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.IdAppraiseType, objMicroteachAppraiseCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.AppraiseTheme) == true)
{
string strComparisonOpAppraiseTheme = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseTheme, objMicroteachAppraiseCond.AppraiseTheme, strComparisonOpAppraiseTheme);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseContent, objMicroteachAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.AppraiseDate) == true)
{
string strComparisonOpAppraiseDate = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseDate, objMicroteachAppraiseCond.AppraiseDate, strComparisonOpAppraiseDate);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.AppraiseTime) == true)
{
string strComparisonOpAppraiseTime = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.AppraiseTime, objMicroteachAppraiseCond.AppraiseTime, strComparisonOpAppraiseTime);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.IsVisual) == true)
{
if (objMicroteachAppraiseCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachAppraise.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachAppraise.IsVisual);
}
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.IsElite) == true)
{
if (objMicroteachAppraiseCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachAppraise.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachAppraise.IsElite);
}
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.ExcellentOne) == true)
{
string strComparisonOpExcellentOne = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.ExcellentOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.ExcellentOne, objMicroteachAppraiseCond.ExcellentOne, strComparisonOpExcellentOne);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.ExcellentTwo) == true)
{
string strComparisonOpExcellentTwo = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.ExcellentTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.ExcellentTwo, objMicroteachAppraiseCond.ExcellentTwo, strComparisonOpExcellentTwo);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.SuggestOne) == true)
{
string strComparisonOpSuggestOne = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.SuggestOne];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.SuggestOne, objMicroteachAppraiseCond.SuggestOne, strComparisonOpSuggestOne);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.SuggestTwo) == true)
{
string strComparisonOpSuggestTwo = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.SuggestTwo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.SuggestTwo, objMicroteachAppraiseCond.SuggestTwo, strComparisonOpSuggestTwo);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.MicroteachAppriseScore) == true)
{
string strComparisonOpMicroteachAppriseScore = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.MicroteachAppriseScore];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.MicroteachAppriseScore, objMicroteachAppraiseCond.MicroteachAppriseScore, strComparisonOpMicroteachAppriseScore);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.VideoStopTime) == true)
{
string strComparisonOpVideoStopTime = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.VideoStopTime, objMicroteachAppraiseCond.VideoStopTime, strComparisonOpVideoStopTime);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachAppraise.BrowseCount, objMicroteachAppraiseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objMicroteachAppraiseCond.IsUpdated(conMicroteachAppraise.UserId) == true)
{
string strComparisonOpUserId = objMicroteachAppraiseCond.dicFldComparisonOp[conMicroteachAppraise.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachAppraise.UserId, objMicroteachAppraiseCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MicroteachAppraise(微格案例定性评议), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_MicroteachCase_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachAppraiseEN == null) return true;
if (objMicroteachAppraiseEN.IdMicroteachAppraise == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachAppraiseEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
if (clsMicroteachAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdMicroteachAppraise !=  {0}", objMicroteachAppraiseEN.IdMicroteachAppraise);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachAppraiseEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
if (clsMicroteachAppraiseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MicroteachAppraise(微格案例定性评议), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_MicroteachCase_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachAppraiseEN == null) return "";
if (objMicroteachAppraiseEN.IdMicroteachAppraise == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachAppraiseEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdMicroteachAppraise !=  {0}", objMicroteachAppraiseEN.IdMicroteachAppraise);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachAppraiseEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objMicroteachAppraiseEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachAppraise
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachAppraise, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例定性评议(MicroteachAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachAppraiseBL
{
public static RelatedActions_MicroteachAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachAppraiseDA MicroteachAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachAppraiseDA();
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
 public clsMicroteachAppraiseBL()
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
if (string.IsNullOrEmpty(clsMicroteachAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachAppraiseDA.GetDataTable_MicroteachAppraise(strWhereCond);
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
objDT = MicroteachAppraiseDA.GetDataTable(strWhereCond);
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
objDT = MicroteachAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLstByIdMicroteachAppraiseLst(List<long> arrIdMicroteachAppraiseLst)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachAppraiseLst);
 string strWhereCond = string.Format("IdMicroteachAppraise in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachAppraiseEN> GetObjLstByIdMicroteachAppraiseLstCache(List<long> arrIdMicroteachAppraiseLst)
{
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Sel =
arrMicroteachAppraiseObjLstCache
.Where(x => arrIdMicroteachAppraiseLst.Contains(x.IdMicroteachAppraise));
return arrMicroteachAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
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
public static List<clsMicroteachAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachAppraiseEN> GetSubObjLstCache(clsMicroteachAppraiseEN objMicroteachAppraiseCond)
{
List<clsMicroteachAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachAppraise.AttributeName)
{
if (objMicroteachAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachAppraiseCond[strFldName].ToString());
}
else
{
if (objMicroteachAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachAppraiseCond[strFldName]));
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
public static List<clsMicroteachAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
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
public static List<clsMicroteachAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
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
List<clsMicroteachAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
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
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
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
public static List<clsMicroteachAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
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
public static List<clsMicroteachAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachAppraiseEN> arrObjLst = new List<clsMicroteachAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachAppraiseEN objMicroteachAppraiseEN = new clsMicroteachAppraiseEN();
try
{
objMicroteachAppraiseEN.IdMicroteachAppraise = Int32.Parse(objRow[conMicroteachAppraise.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objMicroteachAppraiseEN.FuncModuleId = objRow[conMicroteachAppraise.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachAppraiseEN.IdMicroteachCase = objRow[conMicroteachAppraise.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachAppraiseEN.IdAppraiseType = objRow[conMicroteachAppraise.IdAppraiseType].ToString().Trim(); //评议类型流水号
objMicroteachAppraiseEN.AppraiseTheme = objRow[conMicroteachAppraise.AppraiseTheme] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTheme].ToString().Trim(); //评议主题
objMicroteachAppraiseEN.AppraiseContent = objRow[conMicroteachAppraise.AppraiseContent] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseContent].ToString().Trim(); //评议内容
objMicroteachAppraiseEN.AppraiseDate = objRow[conMicroteachAppraise.AppraiseDate] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseDate].ToString().Trim(); //评议日期
objMicroteachAppraiseEN.AppraiseTime = objRow[conMicroteachAppraise.AppraiseTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.AppraiseTime].ToString().Trim(); //评议时间
objMicroteachAppraiseEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsVisual].ToString().Trim()); //隐藏标志
objMicroteachAppraiseEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachAppraise.IsElite].ToString().Trim()); //精华标志
objMicroteachAppraiseEN.ExcellentOne = objRow[conMicroteachAppraise.ExcellentOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentOne].ToString().Trim(); //优点1
objMicroteachAppraiseEN.ExcellentTwo = objRow[conMicroteachAppraise.ExcellentTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.ExcellentTwo].ToString().Trim(); //优点2
objMicroteachAppraiseEN.SuggestOne = objRow[conMicroteachAppraise.SuggestOne] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestOne].ToString().Trim(); //建议1
objMicroteachAppraiseEN.SuggestTwo = objRow[conMicroteachAppraise.SuggestTwo] == DBNull.Value ? null : objRow[conMicroteachAppraise.SuggestTwo].ToString().Trim(); //建议2
objMicroteachAppraiseEN.MicroteachAppriseScore = objRow[conMicroteachAppraise.MicroteachAppriseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachAppraise.MicroteachAppriseScore].ToString().Trim()); //打分
objMicroteachAppraiseEN.VideoStopTime = objRow[conMicroteachAppraise.VideoStopTime] == DBNull.Value ? null : objRow[conMicroteachAppraise.VideoStopTime].ToString().Trim(); //公开课案例视频暂停时间
objMicroteachAppraiseEN.BrowseCount = objRow[conMicroteachAppraise.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachAppraise.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachAppraiseEN.UserId = objRow[conMicroteachAppraise.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachAppraiseEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachAppraise(ref clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
bool bolResult = MicroteachAppraiseDA.GetMicroteachAppraise(ref objMicroteachAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachAppraiseEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
clsMicroteachAppraiseEN objMicroteachAppraiseEN = MicroteachAppraiseDA.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
return objMicroteachAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachAppraiseEN objMicroteachAppraiseEN = MicroteachAppraiseDA.GetFirstObj(strWhereCond);
 return objMicroteachAppraiseEN;
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
public static clsMicroteachAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachAppraiseEN objMicroteachAppraiseEN = MicroteachAppraiseDA.GetObjByDataRow(objRow);
 return objMicroteachAppraiseEN;
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
public static clsMicroteachAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachAppraiseEN objMicroteachAppraiseEN = MicroteachAppraiseDA.GetObjByDataRow(objRow);
 return objMicroteachAppraiseEN;
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
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <param name = "lstMicroteachAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachAppraiseEN GetObjByIdMicroteachAppraiseFromList(long lngIdMicroteachAppraise, List<clsMicroteachAppraiseEN> lstMicroteachAppraiseObjLst)
{
foreach (clsMicroteachAppraiseEN objMicroteachAppraiseEN in lstMicroteachAppraiseObjLst)
{
if (objMicroteachAppraiseEN.IdMicroteachAppraise == lngIdMicroteachAppraise)
{
return objMicroteachAppraiseEN;
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
 long lngIdMicroteachAppraise;
 try
 {
 lngIdMicroteachAppraise = new clsMicroteachAppraiseDA().GetFirstID(strWhereCond);
 return lngIdMicroteachAppraise;
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
 arrList = MicroteachAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachAppraise)
{
//检测记录是否存在
bool bolIsExist = MicroteachAppraiseDA.IsExist(lngIdMicroteachAppraise);
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
 bolIsExist = clsMicroteachAppraiseDA.IsExistTable();
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
 bolIsExist = MicroteachAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (objMicroteachAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsMicroteachAppraiseBL.AddNewRecordBySql2)", objMicroteachAppraiseEN.IdMicroteachCase,objMicroteachAppraiseEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = MicroteachAppraiseDA.AddNewRecordBySQL2(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
if (objMicroteachAppraiseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],用户ID = [{1}]的数据已经存在!(in clsMicroteachAppraiseBL.AddNewRecordBySql2WithReturnKey)", objMicroteachAppraiseEN.IdMicroteachCase,objMicroteachAppraiseEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = MicroteachAppraiseDA.AddNewRecordBySQL2WithReturnKey(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
try
{
bool bolResult = MicroteachAppraiseDA.Update(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "objMicroteachAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 if (objMicroteachAppraiseEN.IdMicroteachAppraise == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachAppraiseDA.UpdateBySql2(objMicroteachAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachAppraiseBL.ReFreshCache();

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdMicroteachAppraise)
{
try
{
 clsMicroteachAppraiseEN objMicroteachAppraiseEN = clsMicroteachAppraiseBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);

if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(objMicroteachAppraiseEN.IdMicroteachAppraise, "SetUpdDate");
}
if (objMicroteachAppraiseEN != null)
{
int intRecNum = MicroteachAppraiseDA.DelRecord(lngIdMicroteachAppraise);
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
/// <param name="lngIdMicroteachAppraise">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdMicroteachAppraise )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
//删除与表:[MicroteachAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachAppraise.IdMicroteachAppraise,
//lngIdMicroteachAppraise);
//        clsMicroteachAppraiseBL.DelMicroteachAppraisesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachAppraiseBL.DelRecord(lngIdMicroteachAppraise, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachAppraiseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachAppraise, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdMicroteachAppraise, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachAppraiseBL.relatedActions != null)
{
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(lngIdMicroteachAppraise, "UpdRelaTabDate");
}
bool bolResult = MicroteachAppraiseDA.DelRecord(lngIdMicroteachAppraise,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroteachAppraiseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachAppraises(List<string> arrIdMicroteachAppraiseLst)
{
if (arrIdMicroteachAppraiseLst.Count == 0) return 0;
try
{
if (clsMicroteachAppraiseBL.relatedActions != null)
{
foreach (var strIdMicroteachAppraise in arrIdMicroteachAppraiseLst)
{
long lngIdMicroteachAppraise = long.Parse(strIdMicroteachAppraise);
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(lngIdMicroteachAppraise, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachAppraiseDA.DelMicroteachAppraise(arrIdMicroteachAppraiseLst);
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
public static int DelMicroteachAppraisesByCond(string strWhereCond)
{
try
{
if (clsMicroteachAppraiseBL.relatedActions != null)
{
List<string> arrIdMicroteachAppraise = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroteachAppraise in arrIdMicroteachAppraise)
{
long lngIdMicroteachAppraise = long.Parse(strIdMicroteachAppraise);
clsMicroteachAppraiseBL.relatedActions.UpdRelaTabDate(lngIdMicroteachAppraise, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachAppraiseDA.DelMicroteachAppraise(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachAppraise]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdMicroteachAppraise">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdMicroteachAppraise)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachAppraiseDA.GetSpecSQLObj();
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
//删除与表:[MicroteachAppraise]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachAppraiseBL.DelRecord(lngIdMicroteachAppraise, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachAppraiseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachAppraise, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachAppraiseENS">源对象</param>
 /// <param name = "objMicroteachAppraiseENT">目标对象</param>
 public static void CopyTo(clsMicroteachAppraiseEN objMicroteachAppraiseENS, clsMicroteachAppraiseEN objMicroteachAppraiseENT)
{
try
{
objMicroteachAppraiseENT.IdMicroteachAppraise = objMicroteachAppraiseENS.IdMicroteachAppraise; //评议流水号
objMicroteachAppraiseENT.FuncModuleId = objMicroteachAppraiseENS.FuncModuleId; //功能模块Id
objMicroteachAppraiseENT.IdMicroteachCase = objMicroteachAppraiseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachAppraiseENT.IdAppraiseType = objMicroteachAppraiseENS.IdAppraiseType; //评议类型流水号
objMicroteachAppraiseENT.AppraiseTheme = objMicroteachAppraiseENS.AppraiseTheme; //评议主题
objMicroteachAppraiseENT.AppraiseContent = objMicroteachAppraiseENS.AppraiseContent; //评议内容
objMicroteachAppraiseENT.AppraiseDate = objMicroteachAppraiseENS.AppraiseDate; //评议日期
objMicroteachAppraiseENT.AppraiseTime = objMicroteachAppraiseENS.AppraiseTime; //评议时间
objMicroteachAppraiseENT.IsVisual = objMicroteachAppraiseENS.IsVisual; //隐藏标志
objMicroteachAppraiseENT.IsElite = objMicroteachAppraiseENS.IsElite; //精华标志
objMicroteachAppraiseENT.ExcellentOne = objMicroteachAppraiseENS.ExcellentOne; //优点1
objMicroteachAppraiseENT.ExcellentTwo = objMicroteachAppraiseENS.ExcellentTwo; //优点2
objMicroteachAppraiseENT.SuggestOne = objMicroteachAppraiseENS.SuggestOne; //建议1
objMicroteachAppraiseENT.SuggestTwo = objMicroteachAppraiseENS.SuggestTwo; //建议2
objMicroteachAppraiseENT.MicroteachAppriseScore = objMicroteachAppraiseENS.MicroteachAppriseScore; //打分
objMicroteachAppraiseENT.VideoStopTime = objMicroteachAppraiseENS.VideoStopTime; //公开课案例视频暂停时间
objMicroteachAppraiseENT.BrowseCount = objMicroteachAppraiseENS.BrowseCount; //浏览次数
objMicroteachAppraiseENT.UserId = objMicroteachAppraiseENS.UserId; //用户ID
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
 /// <param name = "objMicroteachAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
try
{
objMicroteachAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachAppraise.IdMicroteachAppraise, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.IdMicroteachAppraise = objMicroteachAppraiseEN.IdMicroteachAppraise; //评议流水号
}
if (arrFldSet.Contains(conMicroteachAppraise.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.FuncModuleId = objMicroteachAppraiseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conMicroteachAppraise.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.IdMicroteachCase = objMicroteachAppraiseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(conMicroteachAppraise.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.IdAppraiseType = objMicroteachAppraiseEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(conMicroteachAppraise.AppraiseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.AppraiseTheme = objMicroteachAppraiseEN.AppraiseTheme == "[null]" ? null :  objMicroteachAppraiseEN.AppraiseTheme; //评议主题
}
if (arrFldSet.Contains(conMicroteachAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.AppraiseContent = objMicroteachAppraiseEN.AppraiseContent == "[null]" ? null :  objMicroteachAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(conMicroteachAppraise.AppraiseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.AppraiseDate = objMicroteachAppraiseEN.AppraiseDate == "[null]" ? null :  objMicroteachAppraiseEN.AppraiseDate; //评议日期
}
if (arrFldSet.Contains(conMicroteachAppraise.AppraiseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.AppraiseTime = objMicroteachAppraiseEN.AppraiseTime == "[null]" ? null :  objMicroteachAppraiseEN.AppraiseTime; //评议时间
}
if (arrFldSet.Contains(conMicroteachAppraise.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.IsVisual = objMicroteachAppraiseEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(conMicroteachAppraise.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.IsElite = objMicroteachAppraiseEN.IsElite; //精华标志
}
if (arrFldSet.Contains(conMicroteachAppraise.ExcellentOne, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.ExcellentOne = objMicroteachAppraiseEN.ExcellentOne == "[null]" ? null :  objMicroteachAppraiseEN.ExcellentOne; //优点1
}
if (arrFldSet.Contains(conMicroteachAppraise.ExcellentTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.ExcellentTwo = objMicroteachAppraiseEN.ExcellentTwo == "[null]" ? null :  objMicroteachAppraiseEN.ExcellentTwo; //优点2
}
if (arrFldSet.Contains(conMicroteachAppraise.SuggestOne, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.SuggestOne = objMicroteachAppraiseEN.SuggestOne == "[null]" ? null :  objMicroteachAppraiseEN.SuggestOne; //建议1
}
if (arrFldSet.Contains(conMicroteachAppraise.SuggestTwo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.SuggestTwo = objMicroteachAppraiseEN.SuggestTwo == "[null]" ? null :  objMicroteachAppraiseEN.SuggestTwo; //建议2
}
if (arrFldSet.Contains(conMicroteachAppraise.MicroteachAppriseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.MicroteachAppriseScore = objMicroteachAppraiseEN.MicroteachAppriseScore; //打分
}
if (arrFldSet.Contains(conMicroteachAppraise.VideoStopTime, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.VideoStopTime = objMicroteachAppraiseEN.VideoStopTime == "[null]" ? null :  objMicroteachAppraiseEN.VideoStopTime; //公开课案例视频暂停时间
}
if (arrFldSet.Contains(conMicroteachAppraise.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.BrowseCount = objMicroteachAppraiseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conMicroteachAppraise.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachAppraiseEN.UserId = objMicroteachAppraiseEN.UserId; //用户ID
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
 /// <param name = "objMicroteachAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
try
{
if (objMicroteachAppraiseEN.AppraiseTheme == "[null]") objMicroteachAppraiseEN.AppraiseTheme = null; //评议主题
if (objMicroteachAppraiseEN.AppraiseContent == "[null]") objMicroteachAppraiseEN.AppraiseContent = null; //评议内容
if (objMicroteachAppraiseEN.AppraiseDate == "[null]") objMicroteachAppraiseEN.AppraiseDate = null; //评议日期
if (objMicroteachAppraiseEN.AppraiseTime == "[null]") objMicroteachAppraiseEN.AppraiseTime = null; //评议时间
if (objMicroteachAppraiseEN.ExcellentOne == "[null]") objMicroteachAppraiseEN.ExcellentOne = null; //优点1
if (objMicroteachAppraiseEN.ExcellentTwo == "[null]") objMicroteachAppraiseEN.ExcellentTwo = null; //优点2
if (objMicroteachAppraiseEN.SuggestOne == "[null]") objMicroteachAppraiseEN.SuggestOne = null; //建议1
if (objMicroteachAppraiseEN.SuggestTwo == "[null]") objMicroteachAppraiseEN.SuggestTwo = null; //建议2
if (objMicroteachAppraiseEN.VideoStopTime == "[null]") objMicroteachAppraiseEN.VideoStopTime = null; //公开课案例视频暂停时间
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
public static void CheckPropertyNew(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 MicroteachAppraiseDA.CheckPropertyNew(objMicroteachAppraiseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
 MicroteachAppraiseDA.CheckProperty4Condition(objMicroteachAppraiseEN);
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
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachAppraise");
//if (arrMicroteachAppraiseObjLstCache == null)
//{
//arrMicroteachAppraiseObjLstCache = MicroteachAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachAppraiseEN GetObjByIdMicroteachAppraiseCache(long lngIdMicroteachAppraise)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLst_Sel =
arrMicroteachAppraiseObjLstCache
.Where(x=> x.IdMicroteachAppraise == lngIdMicroteachAppraise 
);
if (arrMicroteachAppraiseObjLst_Sel.Count() == 0)
{
   clsMicroteachAppraiseEN obj = clsMicroteachAppraiseBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetAllMicroteachAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLstCache = GetObjLstCache(); 
return arrMicroteachAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName);
List<clsMicroteachAppraiseEN> arrMicroteachAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName);
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
if (clsMicroteachAppraiseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachAppraiseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachAppraiseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MicroteachAppraise(微格案例定性评议)
 /// 唯一性条件:id_MicroteachCase_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMicroteachAppraiseEN objMicroteachAppraiseEN)
{
//检测记录是否存在
string strResult = MicroteachAppraiseDA.GetUniCondStr(objMicroteachAppraiseEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachAppraise)
{
if (strInFldName != conMicroteachAppraise.IdMicroteachAppraise)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachAppraise.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachAppraise = clsMicroteachAppraiseBL.GetObjByIdMicroteachAppraiseCache(lngIdMicroteachAppraise);
if (objMicroteachAppraise == null) return "";
return objMicroteachAppraise[strOutFldName].ToString();
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
int intRecCount = clsMicroteachAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachAppraiseDA.GetRecCount();
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
int intRecCount = clsMicroteachAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachAppraiseEN objMicroteachAppraiseCond)
{
List<clsMicroteachAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachAppraise.AttributeName)
{
if (objMicroteachAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachAppraiseCond[strFldName].ToString());
}
else
{
if (objMicroteachAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachAppraiseCond[strFldName]));
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
 List<string> arrList = clsMicroteachAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachAppraiseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachAppraiseDA.SetFldValue(clsMicroteachAppraiseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachAppraiseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachAppraiseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachAppraiseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachAppraiseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachAppraise] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评议流水号*/ 
 strCreateTabCode.Append(" IdMicroteachAppraise bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**微格教学案例流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCase char(8) not Null, "); 
 // /**评议类型流水号*/ 
 strCreateTabCode.Append(" IdAppraiseType char(4) not Null, "); 
 // /**评议主题*/ 
 strCreateTabCode.Append(" AppraiseTheme varchar(200) Null, "); 
 // /**评议内容*/ 
 strCreateTabCode.Append(" AppraiseContent varchar(2000) Null, "); 
 // /**评议日期*/ 
 strCreateTabCode.Append(" AppraiseDate char(8) Null, "); 
 // /**评议时间*/ 
 strCreateTabCode.Append(" AppraiseTime char(6) Null, "); 
 // /**隐藏标志*/ 
 strCreateTabCode.Append(" IsVisual bit Null, "); 
 // /**精华标志*/ 
 strCreateTabCode.Append(" IsElite bit Null, "); 
 // /**优点1*/ 
 strCreateTabCode.Append(" ExcellentOne varchar(1000) Null, "); 
 // /**优点2*/ 
 strCreateTabCode.Append(" ExcellentTwo varchar(1000) Null, "); 
 // /**建议1*/ 
 strCreateTabCode.Append(" SuggestOne varchar(1000) Null, "); 
 // /**建议2*/ 
 strCreateTabCode.Append(" SuggestTwo varchar(1000) Null, "); 
 // /**打分*/ 
 strCreateTabCode.Append(" MicroteachAppriseScore float Null, "); 
 // /**公开课案例视频暂停时间*/ 
 strCreateTabCode.Append(" VideoStopTime varchar(48) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格案例定性评议(MicroteachAppraise)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachAppraise : clsCommFun4BL
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
clsMicroteachAppraiseBL.ReFreshThisCache();
}
}

}