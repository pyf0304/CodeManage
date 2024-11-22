
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateBL
 表名:PubClassCaseSenate(01120411)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsPubClassCaseSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateEN GetObj(this K_IdPubClassCaseSenate_PubClassCaseSenate myKey)
{
clsPubClassCaseSenateEN objPubClassCaseSenateEN = clsPubClassCaseSenateBL.PubClassCaseSenateDA.GetObjByIdPubClassCaseSenate(myKey.Value);
return objPubClassCaseSenateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (CheckUniqueness(objPubClassCaseSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],公开课案例评议者 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsPubClassCaseSenateBL.AddNewRecord)", objPubClassCaseSenateEN.IdPubClassCase,objPubClassCaseSenateEN.PubClassCaseSenator,objPubClassCaseSenateEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPubClassCaseSenateBL.PubClassCaseSenateDA.AddNewRecordBySQL2(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
public static bool AddRecordEx(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
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
objPubClassCaseSenateEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objPubClassCaseSenateEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例流水号(IdPubClassCase)=[{0}],公开课案例评议者(PubClassCaseSenator)=[{1}],资源流水号(IdResource)=[{2}])已经存在,不能重复!", objPubClassCaseSenateEN.IdPubClassCase, objPubClassCaseSenateEN.PubClassCaseSenator, objPubClassCaseSenateEN.IdResource);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPubClassCaseSenateEN.AddNewRecord();
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (CheckUniqueness(objPubClassCaseSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],公开课案例评议者 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsPubClassCaseSenateBL.AddNewRecordWithReturnKey)", objPubClassCaseSenateEN.IdPubClassCase,objPubClassCaseSenateEN.PubClassCaseSenator,objPubClassCaseSenateEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = clsPubClassCaseSenateBL.PubClassCaseSenateDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIdPubClassCaseSenate(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, long lngIdPubClassCaseSenate, string strComparisonOp="")
	{
objPubClassCaseSenateEN.IdPubClassCaseSenate = lngIdPubClassCaseSenate; //公开课案例评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IdPubClassCaseSenate) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IdPubClassCaseSenate, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCaseSenate] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIdPubClassCase(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, conPubClassCaseSenate.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, conPubClassCaseSenate.IdPubClassCase);
}
objPubClassCaseSenateEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IdPubClassCase) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IdPubClassCase, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCase] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIdPubClassCaseSenateClass(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strIdPubClassCaseSenateClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateClass, conPubClassCaseSenate.IdPubClassCaseSenateClass);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateClass, 4, conPubClassCaseSenate.IdPubClassCaseSenateClass);
}
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = strIdPubClassCaseSenateClass; //公开课案例评议类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IdPubClassCaseSenateClass) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IdPubClassCaseSenateClass, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCaseSenateClass] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenator(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenator, 50, conPubClassCaseSenate.PubClassCaseSenator);
}
objPubClassCaseSenateEN.PubClassCaseSenator = strPubClassCaseSenator; //公开课案例评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenator) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenator, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenator] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateTitle(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTitle, 200, conPubClassCaseSenate.PubClassCaseSenateTitle);
}
objPubClassCaseSenateEN.PubClassCaseSenateTitle = strPubClassCaseSenateTitle; //公开课案例评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateTitle) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateTitle, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTitle] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateContent(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateContent, 8000, conPubClassCaseSenate.PubClassCaseSenateContent);
}
objPubClassCaseSenateEN.PubClassCaseSenateContent = strPubClassCaseSenateContent; //公开课案例评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateContent) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateContent, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateContent] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateDate(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
}
objPubClassCaseSenateEN.PubClassCaseSenateDate = strPubClassCaseSenateDate; //公开课案例评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateDate) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateDate, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateDate] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateTime(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
}
objPubClassCaseSenateEN.PubClassCaseSenateTime = strPubClassCaseSenateTime; //公开课案例评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateTime) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateTime, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTime] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetSenateReadCount(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, int? intSenateReadCount, string strComparisonOp="")
	{
objPubClassCaseSenateEN.SenateReadCount = intSenateReadCount; //评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.SenateReadCount) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.SenateReadCount, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.SenateReadCount] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIsVisual(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, bool bolIsVisual, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisual, conPubClassCaseSenate.IsVisual);
objPubClassCaseSenateEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IsVisual) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IsVisual, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IsVisual] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIsElite(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, bool bolIsElite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsElite, conPubClassCaseSenate.IsElite);
objPubClassCaseSenateEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IsElite) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IsElite, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IsElite] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIdResource(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, conPubClassCaseSenate.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conPubClassCaseSenate.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conPubClassCaseSenate.IdResource);
}
objPubClassCaseSenateEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IdResource) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IdResource, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IdResource] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIdMediaType(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strIdMediaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMediaType, 4, conPubClassCaseSenate.IdMediaType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMediaType, 4, conPubClassCaseSenate.IdMediaType);
}
objPubClassCaseSenateEN.IdMediaType = strIdMediaType; //媒体格式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IdMediaType) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IdMediaType, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IdMediaType] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPubClassCaseSenateEN.CheckPropertyNew();
clsPubClassCaseSenateEN objPubClassCaseSenateCond = new clsPubClassCaseSenateEN();
string strCondition = objPubClassCaseSenateCond
.SetIdPubClassCaseSenate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "<>")
.SetIdPubClassCase(objPubClassCaseSenateEN.IdPubClassCase, "=")
.SetPubClassCaseSenator(objPubClassCaseSenateEN.PubClassCaseSenator, "=")
.SetIdResource(objPubClassCaseSenateEN.IdResource, "=")
.GetCombineCondition();
objPubClassCaseSenateEN._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_PubClassCase_PubClassCaseSenator_id_Resource)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPubClassCaseSenateEN.Update();
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
 /// <param name = "objPubClassCaseSenate">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPubClassCaseSenateEN objPubClassCaseSenate)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPubClassCaseSenateEN objPubClassCaseSenateCond = new clsPubClassCaseSenateEN();
string strCondition = objPubClassCaseSenateCond
.SetIdPubClassCase(objPubClassCaseSenate.IdPubClassCase, "=")
.SetPubClassCaseSenator(objPubClassCaseSenate.PubClassCaseSenator, "=")
.SetIdResource(objPubClassCaseSenate.IdResource, "=")
.GetCombineCondition();
objPubClassCaseSenate._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPubClassCaseSenate.IdPubClassCaseSenate = clsPubClassCaseSenateBL.GetFirstID_S(strCondition);
objPubClassCaseSenate.UpdateWithCondition(strCondition);
}
else
{
objPubClassCaseSenate.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN.IdPubClassCaseSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseSenateBL.PubClassCaseSenateDA.UpdateBySql2(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPubClassCaseSenateEN.IdPubClassCaseSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseSenateBL.PubClassCaseSenateDA.UpdateBySql2(objPubClassCaseSenateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strWhereCond)
{
try
{
bool bolResult = clsPubClassCaseSenateBL.PubClassCaseSenateDA.UpdateBySqlWithCondition(objPubClassCaseSenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPubClassCaseSenateBL.PubClassCaseSenateDA.UpdateBySqlWithConditionTransaction(objPubClassCaseSenateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
try
{
int intRecNum = clsPubClassCaseSenateBL.PubClassCaseSenateDA.DelRecord(objPubClassCaseSenateEN.IdPubClassCaseSenate);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateENS">源对象</param>
 /// <param name = "objPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(this clsPubClassCaseSenateEN objPubClassCaseSenateENS, clsPubClassCaseSenateEN objPubClassCaseSenateENT)
{
try
{
objPubClassCaseSenateENT.IdPubClassCaseSenate = objPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objPubClassCaseSenateENT.IdPubClassCase = objPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseSenateENT.IdPubClassCaseSenateClass = objPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
objPubClassCaseSenateENT.PubClassCaseSenator = objPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objPubClassCaseSenateENT.PubClassCaseSenateTitle = objPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objPubClassCaseSenateENT.PubClassCaseSenateContent = objPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objPubClassCaseSenateENT.PubClassCaseSenateDate = objPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objPubClassCaseSenateENT.PubClassCaseSenateTime = objPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objPubClassCaseSenateENT.SenateReadCount = objPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objPubClassCaseSenateENT.IsVisual = objPubClassCaseSenateENS.IsVisual; //隐藏标志
objPubClassCaseSenateENT.IsElite = objPubClassCaseSenateENS.IsElite; //精华标志
objPubClassCaseSenateENT.IdResource = objPubClassCaseSenateENS.IdResource; //资源流水号
objPubClassCaseSenateENT.IdMediaType = objPubClassCaseSenateENS.IdMediaType; //媒体格式流水号
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
 /// <param name = "objPubClassCaseSenateENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCaseSenateEN:objPubClassCaseSenateENT</returns>
 public static clsPubClassCaseSenateEN CopyTo(this clsPubClassCaseSenateEN objPubClassCaseSenateENS)
{
try
{
 clsPubClassCaseSenateEN objPubClassCaseSenateENT = new clsPubClassCaseSenateEN()
{
IdPubClassCaseSenate = objPubClassCaseSenateENS.IdPubClassCaseSenate, //公开课案例评议流水号
IdPubClassCase = objPubClassCaseSenateENS.IdPubClassCase, //案例流水号
IdPubClassCaseSenateClass = objPubClassCaseSenateENS.IdPubClassCaseSenateClass, //公开课案例评议类别流水号
PubClassCaseSenator = objPubClassCaseSenateENS.PubClassCaseSenator, //公开课案例评议者
PubClassCaseSenateTitle = objPubClassCaseSenateENS.PubClassCaseSenateTitle, //公开课案例评议标题
PubClassCaseSenateContent = objPubClassCaseSenateENS.PubClassCaseSenateContent, //公开课案例评议内容
PubClassCaseSenateDate = objPubClassCaseSenateENS.PubClassCaseSenateDate, //公开课案例评议日期
PubClassCaseSenateTime = objPubClassCaseSenateENS.PubClassCaseSenateTime, //公开课案例评议时间
SenateReadCount = objPubClassCaseSenateENS.SenateReadCount, //评议阅读次数
IsVisual = objPubClassCaseSenateENS.IsVisual, //隐藏标志
IsElite = objPubClassCaseSenateENS.IsElite, //精华标志
IdResource = objPubClassCaseSenateENS.IdResource, //资源流水号
IdMediaType = objPubClassCaseSenateENS.IdMediaType, //媒体格式流水号
};
 return objPubClassCaseSenateENT;
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
public static void CheckPropertyNew(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 clsPubClassCaseSenateBL.PubClassCaseSenateDA.CheckPropertyNew(objPubClassCaseSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 clsPubClassCaseSenateBL.PubClassCaseSenateDA.CheckProperty4Condition(objPubClassCaseSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseSenateEN objPubClassCaseSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenate) == true)
{
string strComparisonOpIdPubClassCaseSenate = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCaseSenate];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenate.IdPubClassCaseSenate, objPubClassCaseSenateCond.IdPubClassCaseSenate, strComparisonOpIdPubClassCaseSenate);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.IdPubClassCase, objPubClassCaseSenateCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IdPubClassCaseSenateClass) == true)
{
string strComparisonOpIdPubClassCaseSenateClass = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.IdPubClassCaseSenateClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.IdPubClassCaseSenateClass, objPubClassCaseSenateCond.IdPubClassCaseSenateClass, strComparisonOpIdPubClassCaseSenateClass);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator) == true)
{
string strComparisonOpPubClassCaseSenator = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenator, objPubClassCaseSenateCond.PubClassCaseSenator, strComparisonOpPubClassCaseSenator);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle) == true)
{
string strComparisonOpPubClassCaseSenateTitle = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateTitle, objPubClassCaseSenateCond.PubClassCaseSenateTitle, strComparisonOpPubClassCaseSenateTitle);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent) == true)
{
string strComparisonOpPubClassCaseSenateContent = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateContent, objPubClassCaseSenateCond.PubClassCaseSenateContent, strComparisonOpPubClassCaseSenateContent);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate) == true)
{
string strComparisonOpPubClassCaseSenateDate = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateDate, objPubClassCaseSenateCond.PubClassCaseSenateDate, strComparisonOpPubClassCaseSenateDate);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime) == true)
{
string strComparisonOpPubClassCaseSenateTime = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateTime, objPubClassCaseSenateCond.PubClassCaseSenateTime, strComparisonOpPubClassCaseSenateTime);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.SenateReadCount) == true)
{
string strComparisonOpSenateReadCount = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.SenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenate.SenateReadCount, objPubClassCaseSenateCond.SenateReadCount, strComparisonOpSenateReadCount);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IsVisual) == true)
{
if (objPubClassCaseSenateCond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCaseSenate.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCaseSenate.IsVisual);
}
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IsElite) == true)
{
if (objPubClassCaseSenateCond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCaseSenate.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCaseSenate.IsElite);
}
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IdResource) == true)
{
string strComparisonOpIdResource = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.IdResource, objPubClassCaseSenateCond.IdResource, strComparisonOpIdResource);
}
if (objPubClassCaseSenateCond.IsUpdated(conPubClassCaseSenate.IdMediaType) == true)
{
string strComparisonOpIdMediaType = objPubClassCaseSenateCond.dicFldComparisonOp[conPubClassCaseSenate.IdMediaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.IdMediaType, objPubClassCaseSenateCond.IdMediaType, strComparisonOpIdMediaType);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PubClassCaseSenate(公开课案例评议), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_PubClassCase_PubClassCaseSenator_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseSenateEN == null) return true;
if (objPubClassCaseSenateEN.IdPubClassCaseSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseSenateEN.IdPubClassCase);
 if (objPubClassCaseSenateEN.PubClassCaseSenator == null)
{
 sbCondition.AppendFormat(" and PubClassCaseSenator is null", objPubClassCaseSenateEN.PubClassCaseSenator);
}
else
{
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
}
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCaseSenateEN.IdResource);
if (clsPubClassCaseSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPubClassCaseSenate !=  {0}", objPubClassCaseSenateEN.IdPubClassCaseSenate);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCaseSenateEN.IdResource);
if (clsPubClassCaseSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PubClassCaseSenate(公开课案例评议), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_PubClassCase_PubClassCaseSenator_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseSenateEN == null) return "";
if (objPubClassCaseSenateEN.IdPubClassCaseSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseSenateEN.IdPubClassCase);
 if (objPubClassCaseSenateEN.PubClassCaseSenator == null)
{
 sbCondition.AppendFormat(" and PubClassCaseSenator is null", objPubClassCaseSenateEN.PubClassCaseSenator);
}
else
{
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
}
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCaseSenateEN.IdResource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPubClassCaseSenate !=  {0}", objPubClassCaseSenateEN.IdPubClassCaseSenate);
 sbCondition.AppendFormat(" and IdPubClassCase = '{0}'", objPubClassCaseSenateEN.IdPubClassCase);
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
 sbCondition.AppendFormat(" and IdResource = '{0}'", objPubClassCaseSenateEN.IdResource);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PubClassCaseSenate
{
public virtual bool UpdRelaTabDate(long lngIdPubClassCaseSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 公开课案例评议(PubClassCaseSenate)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseSenateBL
{
public static RelatedActions_PubClassCaseSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPubClassCaseSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPubClassCaseSenateDA PubClassCaseSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPubClassCaseSenateDA();
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
 public clsPubClassCaseSenateBL()
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
if (string.IsNullOrEmpty(clsPubClassCaseSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateEN._ConnectString);
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
public static DataTable GetDataTable_PubClassCaseSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PubClassCaseSenateDA.GetDataTable_PubClassCaseSenate(strWhereCond);
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
objDT = PubClassCaseSenateDA.GetDataTable(strWhereCond);
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
objDT = PubClassCaseSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PubClassCaseSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PubClassCaseSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PubClassCaseSenateDA.GetDataTable_Top(objTopPara);
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
objDT = PubClassCaseSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PubClassCaseSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PubClassCaseSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLstByIdPubClassCaseSenateLst(List<long> arrIdPubClassCaseSenateLst)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseSenateLst);
 string strWhereCond = string.Format("IdPubClassCaseSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPubClassCaseSenateEN> GetObjLstByIdPubClassCaseSenateLstCache(List<long> arrIdPubClassCaseSenateLst)
{
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Sel =
arrPubClassCaseSenateObjLstCache
.Where(x => arrIdPubClassCaseSenateLst.Contains(x.IdPubClassCaseSenate));
return arrPubClassCaseSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLst(string strWhereCond)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
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
public static List<clsPubClassCaseSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPubClassCaseSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPubClassCaseSenateEN> GetSubObjLstCache(clsPubClassCaseSenateEN objPubClassCaseSenateCond)
{
List<clsPubClassCaseSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseSenate.AttributeName)
{
if (objPubClassCaseSenateCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateCond[strFldName].ToString());
}
else
{
if (objPubClassCaseSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateCond[strFldName]));
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
public static List<clsPubClassCaseSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
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
public static List<clsPubClassCaseSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
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
List<clsPubClassCaseSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPubClassCaseSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPubClassCaseSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
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
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
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
public static List<clsPubClassCaseSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPubClassCaseSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
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
public static List<clsPubClassCaseSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPubClassCaseSenateEN> arrObjLst = new List<clsPubClassCaseSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateEN objPubClassCaseSenateEN = new clsPubClassCaseSenateEN();
try
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = Int32.Parse(objRow[conPubClassCaseSenate.IdPubClassCaseSenate].ToString().Trim()); //公开课案例评议流水号
objPubClassCaseSenateEN.IdPubClassCase = objRow[conPubClassCaseSenate.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objRow[conPubClassCaseSenate.IdPubClassCaseSenateClass].ToString().Trim(); //公开课案例评议类别流水号
objPubClassCaseSenateEN.PubClassCaseSenator = objRow[conPubClassCaseSenate.PubClassCaseSenator] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenator].ToString().Trim(); //公开课案例评议者
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objRow[conPubClassCaseSenate.PubClassCaseSenateTitle] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTitle].ToString().Trim(); //公开课案例评议标题
objPubClassCaseSenateEN.PubClassCaseSenateContent = objRow[conPubClassCaseSenate.PubClassCaseSenateContent] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateContent].ToString().Trim(); //公开课案例评议内容
objPubClassCaseSenateEN.PubClassCaseSenateDate = objRow[conPubClassCaseSenate.PubClassCaseSenateDate] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateDate].ToString().Trim(); //公开课案例评议日期
objPubClassCaseSenateEN.PubClassCaseSenateTime = objRow[conPubClassCaseSenate.PubClassCaseSenateTime] == DBNull.Value ? null : objRow[conPubClassCaseSenate.PubClassCaseSenateTime].ToString().Trim(); //公开课案例评议时间
objPubClassCaseSenateEN.SenateReadCount = objRow[conPubClassCaseSenate.SenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenate.SenateReadCount].ToString().Trim()); //评议阅读次数
objPubClassCaseSenateEN.IsVisual = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsVisual].ToString().Trim()); //隐藏标志
objPubClassCaseSenateEN.IsElite = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenate.IsElite].ToString().Trim()); //精华标志
objPubClassCaseSenateEN.IdResource = objRow[conPubClassCaseSenate.IdResource].ToString().Trim(); //资源流水号
objPubClassCaseSenateEN.IdMediaType = objRow[conPubClassCaseSenate.IdMediaType] == DBNull.Value ? null : objRow[conPubClassCaseSenate.IdMediaType].ToString().Trim(); //媒体格式流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateEN.IdPubClassCaseSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPubClassCaseSenate(ref clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
bool bolResult = PubClassCaseSenateDA.GetPubClassCaseSenate(ref objPubClassCaseSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateEN GetObjByIdPubClassCaseSenate(long lngIdPubClassCaseSenate)
{
clsPubClassCaseSenateEN objPubClassCaseSenateEN = PubClassCaseSenateDA.GetObjByIdPubClassCaseSenate(lngIdPubClassCaseSenate);
return objPubClassCaseSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPubClassCaseSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPubClassCaseSenateEN objPubClassCaseSenateEN = PubClassCaseSenateDA.GetFirstObj(strWhereCond);
 return objPubClassCaseSenateEN;
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
public static clsPubClassCaseSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPubClassCaseSenateEN objPubClassCaseSenateEN = PubClassCaseSenateDA.GetObjByDataRow(objRow);
 return objPubClassCaseSenateEN;
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
public static clsPubClassCaseSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPubClassCaseSenateEN objPubClassCaseSenateEN = PubClassCaseSenateDA.GetObjByDataRow(objRow);
 return objPubClassCaseSenateEN;
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
 /// <param name = "lngIdPubClassCaseSenate">所给的关键字</param>
 /// <param name = "lstPubClassCaseSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseSenateEN GetObjByIdPubClassCaseSenateFromList(long lngIdPubClassCaseSenate, List<clsPubClassCaseSenateEN> lstPubClassCaseSenateObjLst)
{
foreach (clsPubClassCaseSenateEN objPubClassCaseSenateEN in lstPubClassCaseSenateObjLst)
{
if (objPubClassCaseSenateEN.IdPubClassCaseSenate == lngIdPubClassCaseSenate)
{
return objPubClassCaseSenateEN;
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
 long lngIdPubClassCaseSenate;
 try
 {
 lngIdPubClassCaseSenate = new clsPubClassCaseSenateDA().GetFirstID(strWhereCond);
 return lngIdPubClassCaseSenate;
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
 arrList = PubClassCaseSenateDA.GetID(strWhereCond);
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
bool bolIsExist = PubClassCaseSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPubClassCaseSenate)
{
//检测记录是否存在
bool bolIsExist = PubClassCaseSenateDA.IsExist(lngIdPubClassCaseSenate);
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
 bolIsExist = clsPubClassCaseSenateDA.IsExistTable();
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
 bolIsExist = PubClassCaseSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (objPubClassCaseSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],公开课案例评议者 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsPubClassCaseSenateBL.AddNewRecordBySql2)", objPubClassCaseSenateEN.IdPubClassCase,objPubClassCaseSenateEN.PubClassCaseSenator,objPubClassCaseSenateEN.IdResource);
throw new Exception(strMsg);
}
try
{
bool bolResult = PubClassCaseSenateDA.AddNewRecordBySQL2(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (objPubClassCaseSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例流水号 = [{0}],公开课案例评议者 = [{1}],资源流水号 = [{2}]的数据已经存在!(in clsPubClassCaseSenateBL.AddNewRecordBySql2WithReturnKey)", objPubClassCaseSenateEN.IdPubClassCase,objPubClassCaseSenateEN.PubClassCaseSenator,objPubClassCaseSenateEN.IdResource);
throw new Exception(strMsg);
}
try
{
string strKey = PubClassCaseSenateDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
try
{
bool bolResult = PubClassCaseSenateDA.Update(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN.IdPubClassCaseSenate == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PubClassCaseSenateDA.UpdateBySql2(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateBL.ReFreshCache();

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
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
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdPubClassCaseSenate)
{
try
{
 clsPubClassCaseSenateEN objPubClassCaseSenateEN = clsPubClassCaseSenateBL.GetObjByIdPubClassCaseSenate(lngIdPubClassCaseSenate);

if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateEN.IdPubClassCaseSenate, "SetUpdDate");
}
if (objPubClassCaseSenateEN != null)
{
int intRecNum = PubClassCaseSenateDA.DelRecord(lngIdPubClassCaseSenate);
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
/// <param name="lngIdPubClassCaseSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdPubClassCaseSenate )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPubClassCaseSenate.IdPubClassCaseSenate,
//lngIdPubClassCaseSenate);
//        clsPubClassCaseSenateBL.DelPubClassCaseSenatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseSenateBL.DelRecord(lngIdPubClassCaseSenate, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseSenateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdPubClassCaseSenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdPubClassCaseSenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPubClassCaseSenateBL.relatedActions != null)
{
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseSenate, "UpdRelaTabDate");
}
bool bolResult = PubClassCaseSenateDA.DelRecord(lngIdPubClassCaseSenate,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPubClassCaseSenateLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPubClassCaseSenates(List<string> arrIdPubClassCaseSenateLst)
{
if (arrIdPubClassCaseSenateLst.Count == 0) return 0;
try
{
if (clsPubClassCaseSenateBL.relatedActions != null)
{
foreach (var strIdPubClassCaseSenate in arrIdPubClassCaseSenateLst)
{
long lngIdPubClassCaseSenate = long.Parse(strIdPubClassCaseSenate);
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseSenate, "UpdRelaTabDate");
}
}
int intDelRecNum = PubClassCaseSenateDA.DelPubClassCaseSenate(arrIdPubClassCaseSenateLst);
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
public static int DelPubClassCaseSenatesByCond(string strWhereCond)
{
try
{
if (clsPubClassCaseSenateBL.relatedActions != null)
{
List<string> arrIdPubClassCaseSenate = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPubClassCaseSenate in arrIdPubClassCaseSenate)
{
long lngIdPubClassCaseSenate = long.Parse(strIdPubClassCaseSenate);
clsPubClassCaseSenateBL.relatedActions.UpdRelaTabDate(lngIdPubClassCaseSenate, "UpdRelaTabDate");
}
}
int intRecNum = PubClassCaseSenateDA.DelPubClassCaseSenate(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PubClassCaseSenate]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdPubClassCaseSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdPubClassCaseSenate)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseSenateDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseSenateBL.DelRecord(lngIdPubClassCaseSenate, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseSenateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPubClassCaseSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPubClassCaseSenateENS">源对象</param>
 /// <param name = "objPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseSenateEN objPubClassCaseSenateENS, clsPubClassCaseSenateEN objPubClassCaseSenateENT)
{
try
{
objPubClassCaseSenateENT.IdPubClassCaseSenate = objPubClassCaseSenateENS.IdPubClassCaseSenate; //公开课案例评议流水号
objPubClassCaseSenateENT.IdPubClassCase = objPubClassCaseSenateENS.IdPubClassCase; //案例流水号
objPubClassCaseSenateENT.IdPubClassCaseSenateClass = objPubClassCaseSenateENS.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
objPubClassCaseSenateENT.PubClassCaseSenator = objPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objPubClassCaseSenateENT.PubClassCaseSenateTitle = objPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objPubClassCaseSenateENT.PubClassCaseSenateContent = objPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objPubClassCaseSenateENT.PubClassCaseSenateDate = objPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objPubClassCaseSenateENT.PubClassCaseSenateTime = objPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objPubClassCaseSenateENT.SenateReadCount = objPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objPubClassCaseSenateENT.IsVisual = objPubClassCaseSenateENS.IsVisual; //隐藏标志
objPubClassCaseSenateENT.IsElite = objPubClassCaseSenateENS.IsElite; //精华标志
objPubClassCaseSenateENT.IdResource = objPubClassCaseSenateENS.IdResource; //资源流水号
objPubClassCaseSenateENT.IdMediaType = objPubClassCaseSenateENS.IdMediaType; //媒体格式流水号
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
 /// <param name = "objPubClassCaseSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
try
{
objPubClassCaseSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPubClassCaseSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPubClassCaseSenate.IdPubClassCaseSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IdPubClassCaseSenate = objPubClassCaseSenateEN.IdPubClassCaseSenate; //公开课案例评议流水号
}
if (arrFldSet.Contains(conPubClassCaseSenate.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IdPubClassCase = objPubClassCaseSenateEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(conPubClassCaseSenate.IdPubClassCaseSenateClass, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IdPubClassCaseSenateClass = objPubClassCaseSenateEN.IdPubClassCaseSenateClass; //公开课案例评议类别流水号
}
if (arrFldSet.Contains(conPubClassCaseSenate.PubClassCaseSenator, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.PubClassCaseSenator = objPubClassCaseSenateEN.PubClassCaseSenator == "[null]" ? null :  objPubClassCaseSenateEN.PubClassCaseSenator; //公开课案例评议者
}
if (arrFldSet.Contains(conPubClassCaseSenate.PubClassCaseSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.PubClassCaseSenateTitle = objPubClassCaseSenateEN.PubClassCaseSenateTitle == "[null]" ? null :  objPubClassCaseSenateEN.PubClassCaseSenateTitle; //公开课案例评议标题
}
if (arrFldSet.Contains(conPubClassCaseSenate.PubClassCaseSenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.PubClassCaseSenateContent = objPubClassCaseSenateEN.PubClassCaseSenateContent == "[null]" ? null :  objPubClassCaseSenateEN.PubClassCaseSenateContent; //公开课案例评议内容
}
if (arrFldSet.Contains(conPubClassCaseSenate.PubClassCaseSenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.PubClassCaseSenateDate = objPubClassCaseSenateEN.PubClassCaseSenateDate == "[null]" ? null :  objPubClassCaseSenateEN.PubClassCaseSenateDate; //公开课案例评议日期
}
if (arrFldSet.Contains(conPubClassCaseSenate.PubClassCaseSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.PubClassCaseSenateTime = objPubClassCaseSenateEN.PubClassCaseSenateTime == "[null]" ? null :  objPubClassCaseSenateEN.PubClassCaseSenateTime; //公开课案例评议时间
}
if (arrFldSet.Contains(conPubClassCaseSenate.SenateReadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.SenateReadCount = objPubClassCaseSenateEN.SenateReadCount; //评议阅读次数
}
if (arrFldSet.Contains(conPubClassCaseSenate.IsVisual, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IsVisual = objPubClassCaseSenateEN.IsVisual; //隐藏标志
}
if (arrFldSet.Contains(conPubClassCaseSenate.IsElite, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IsElite = objPubClassCaseSenateEN.IsElite; //精华标志
}
if (arrFldSet.Contains(conPubClassCaseSenate.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IdResource = objPubClassCaseSenateEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conPubClassCaseSenate.IdMediaType, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateEN.IdMediaType = objPubClassCaseSenateEN.IdMediaType == "[null]" ? null :  objPubClassCaseSenateEN.IdMediaType; //媒体格式流水号
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
 /// <param name = "objPubClassCaseSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
try
{
if (objPubClassCaseSenateEN.PubClassCaseSenator == "[null]") objPubClassCaseSenateEN.PubClassCaseSenator = null; //公开课案例评议者
if (objPubClassCaseSenateEN.PubClassCaseSenateTitle == "[null]") objPubClassCaseSenateEN.PubClassCaseSenateTitle = null; //公开课案例评议标题
if (objPubClassCaseSenateEN.PubClassCaseSenateContent == "[null]") objPubClassCaseSenateEN.PubClassCaseSenateContent = null; //公开课案例评议内容
if (objPubClassCaseSenateEN.PubClassCaseSenateDate == "[null]") objPubClassCaseSenateEN.PubClassCaseSenateDate = null; //公开课案例评议日期
if (objPubClassCaseSenateEN.PubClassCaseSenateTime == "[null]") objPubClassCaseSenateEN.PubClassCaseSenateTime = null; //公开课案例评议时间
if (objPubClassCaseSenateEN.IdMediaType == "[null]") objPubClassCaseSenateEN.IdMediaType = null; //媒体格式流水号
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
public static void CheckPropertyNew(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 PubClassCaseSenateDA.CheckPropertyNew(objPubClassCaseSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 PubClassCaseSenateDA.CheckProperty4Condition(objPubClassCaseSenateEN);
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
if (clsPubClassCaseSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateBL没有刷新缓存机制(clsPubClassCaseSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseSenate");
//if (arrPubClassCaseSenateObjLstCache == null)
//{
//arrPubClassCaseSenateObjLstCache = PubClassCaseSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseSenateEN GetObjByIdPubClassCaseSenateCache(long lngIdPubClassCaseSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Sel =
arrPubClassCaseSenateObjLstCache
.Where(x=> x.IdPubClassCaseSenate == lngIdPubClassCaseSenate 
);
if (arrPubClassCaseSenateObjLst_Sel.Count() == 0)
{
   clsPubClassCaseSenateEN obj = clsPubClassCaseSenateBL.GetObjByIdPubClassCaseSenate(lngIdPubClassCaseSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPubClassCaseSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetAllPubClassCaseSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLstCache = GetObjLstCache(); 
return arrPubClassCaseSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseSenateObjLstCache;
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
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName);
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
if (clsPubClassCaseSenateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseSenateBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PubClassCaseSenate(公开课案例评议)
 /// 唯一性条件:id_PubClassCase_PubClassCaseSenator_id_Resource
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检测记录是否存在
string strResult = PubClassCaseSenateDA.GetUniCondStr(objPubClassCaseSenateEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPubClassCaseSenate)
{
if (strInFldName != conPubClassCaseSenate.IdPubClassCaseSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPubClassCaseSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPubClassCaseSenate.AttributeName));
throw new Exception(strMsg);
}
var objPubClassCaseSenate = clsPubClassCaseSenateBL.GetObjByIdPubClassCaseSenateCache(lngIdPubClassCaseSenate);
if (objPubClassCaseSenate == null) return "";
return objPubClassCaseSenate[strOutFldName].ToString();
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
int intRecCount = clsPubClassCaseSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsPubClassCaseSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPubClassCaseSenateDA.GetRecCount();
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
int intRecCount = clsPubClassCaseSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPubClassCaseSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPubClassCaseSenateEN objPubClassCaseSenateCond)
{
List<clsPubClassCaseSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseSenate.AttributeName)
{
if (objPubClassCaseSenateCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateCond[strFldName].ToString());
}
else
{
if (objPubClassCaseSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateCond[strFldName]));
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
 List<string> arrList = clsPubClassCaseSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PubClassCaseSenateDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateDA.SetFldValue(clsPubClassCaseSenateEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PubClassCaseSenateDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PubClassCaseSenate] "); 
 strCreateTabCode.Append(" ( "); 
 // /**公开课案例评议流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseSenate bigint primary key identity, "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdPubClassCase char(8) not Null, "); 
 // /**公开课案例评议类别流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseSenateClass char(4) not Null, "); 
 // /**公开课案例评议者*/ 
 strCreateTabCode.Append(" PubClassCaseSenator varchar(50) Null, "); 
 // /**公开课案例评议标题*/ 
 strCreateTabCode.Append(" PubClassCaseSenateTitle varchar(200) Null, "); 
 // /**公开课案例评议内容*/ 
 strCreateTabCode.Append(" PubClassCaseSenateContent varchar(8000) Null, "); 
 // /**公开课案例评议日期*/ 
 strCreateTabCode.Append(" PubClassCaseSenateDate char(8) Null, "); 
 // /**公开课案例评议时间*/ 
 strCreateTabCode.Append(" PubClassCaseSenateTime char(6) Null, "); 
 // /**评议阅读次数*/ 
 strCreateTabCode.Append(" SenateReadCount int Null, "); 
 // /**隐藏标志*/ 
 strCreateTabCode.Append(" IsVisual bit not Null, "); 
 // /**精华标志*/ 
 strCreateTabCode.Append(" IsElite bit not Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) not Null, "); 
 // /**媒体格式流水号*/ 
 strCreateTabCode.Append(" IdMediaType char(4) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 公开课案例评议(PubClassCaseSenate)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PubClassCaseSenate : clsCommFun4BL
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
clsPubClassCaseSenateBL.ReFreshThisCache();
}
}

}