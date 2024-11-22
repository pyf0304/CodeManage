
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseSiteSenateBL
 表名:MicroteachCaseSiteSenate(01120458)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:01
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
public static class  clsMicroteachCaseSiteSenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseSiteSenateEN GetObj(this K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate myKey)
{
clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.GetObjByIdMicroteachCaseSiteSenate(myKey.Value);
return objMicroteachCaseSiteSenateEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
if (CheckUniqueness(objMicroteachCaseSiteSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],评议者 = [{1}],微格现场评价类型流水号 = [{2}]的数据已经存在!(in clsMicroteachCaseSiteSenateBL.AddNewRecord)", objMicroteachCaseSiteSenateEN.IdMicroteachCase,objMicroteachCaseSiteSenateEN.SiteSenateSenator,objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.AddNewRecordBySQL2(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
public static bool AddRecordEx(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
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
objMicroteachCaseSiteSenateEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMicroteachCaseSiteSenateEN.CheckUniqueness() == false)
{
strMsg = string.Format("(微格教学案例流水号(IdMicroteachCase)=[{0}],评议者(SiteSenateSenator)=[{1}],微格现场评价类型流水号(IdMicroteachCaseSiteSenateType)=[{2}])已经存在,不能重复!", objMicroteachCaseSiteSenateEN.IdMicroteachCase, objMicroteachCaseSiteSenateEN.SiteSenateSenator, objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objMicroteachCaseSiteSenateEN.AddNewRecord();
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
if (CheckUniqueness(objMicroteachCaseSiteSenateEN) == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],评议者 = [{1}],微格现场评价类型流水号 = [{2}]的数据已经存在!(in clsMicroteachCaseSiteSenateBL.AddNewRecordWithReturnKey)", objMicroteachCaseSiteSenateEN.IdMicroteachCase,objMicroteachCaseSiteSenateEN.SiteSenateSenator,objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
throw new Exception(strMsg);
}
try
{
string strKey = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetIdMicroteachCaseSiteSenate(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, long lngIdMicroteachCaseSiteSenate, string strComparisonOp="")
	{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = lngIdMicroteachCaseSiteSenate; //微格现场评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetFuncModuleId(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conMicroteachCaseSiteSenate.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conMicroteachCaseSiteSenate.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conMicroteachCaseSiteSenate.FuncModuleId);
}
objMicroteachCaseSiteSenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.FuncModuleId) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.FuncModuleId, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.FuncModuleId] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetIdMicroteachCase(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, conMicroteachCaseSiteSenate.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, conMicroteachCaseSiteSenate.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, conMicroteachCaseSiteSenate.IdMicroteachCase);
}
objMicroteachCaseSiteSenateEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.IdMicroteachCase) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.IdMicroteachCase, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCase] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetIdMicroteachCaseSiteSenateType(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strIdMicroteachCaseSiteSenateType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseSiteSenateType, 4, conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseSiteSenateType, 4, conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = strIdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetIdResource(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strIdResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conMicroteachCaseSiteSenate.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conMicroteachCaseSiteSenate.IdResource);
}
objMicroteachCaseSiteSenateEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.IdResource) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.IdResource, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdResource] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateSenator(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strSiteSenateSenator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateSenator, 50, conMicroteachCaseSiteSenate.SiteSenateSenator);
}
objMicroteachCaseSiteSenateEN.SiteSenateSenator = strSiteSenateSenator; //评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateSenator) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateSenator, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateSenator] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateTitle(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strSiteSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteSenateTitle, conMicroteachCaseSiteSenate.SiteSenateTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateTitle, 50, conMicroteachCaseSiteSenate.SiteSenateTitle);
}
objMicroteachCaseSiteSenateEN.SiteSenateTitle = strSiteSenateTitle; //评议名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateTitle) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateTitle, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateTitle] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateContent(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strSiteSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateContent, 2000, conMicroteachCaseSiteSenate.SiteSenateContent);
}
objMicroteachCaseSiteSenateEN.SiteSenateContent = strSiteSenateContent; //现场评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateContent) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateContent, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateContent] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateData(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strSiteSenateData, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateData, 8, conMicroteachCaseSiteSenate.SiteSenateData);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSiteSenateData, 8, conMicroteachCaseSiteSenate.SiteSenateData);
}
objMicroteachCaseSiteSenateEN.SiteSenateData = strSiteSenateData; //现场评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateData) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateData, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateData] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateTime(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strSiteSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSiteSenateTime, 6, conMicroteachCaseSiteSenate.SiteSenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSiteSenateTime, 6, conMicroteachCaseSiteSenate.SiteSenateTime);
}
objMicroteachCaseSiteSenateEN.SiteSenateTime = strSiteSenateTime; //现场评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateTime) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateTime, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateTime] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetSiteSenateReadCount(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, int? intSiteSenateReadCount, string strComparisonOp="")
	{
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = intSiteSenateReadCount; //现场评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.SiteSenateReadCount) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.SiteSenateReadCount, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateReadCount] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseSiteSenateEN SetMemo(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCaseSiteSenate.Memo);
}
objMicroteachCaseSiteSenateEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseSiteSenateEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseSiteSenate.Memo) == false)
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp.Add(conMicroteachCaseSiteSenate.Memo, strComparisonOp);
}
else
{
objMicroteachCaseSiteSenateEN.dicFldComparisonOp[conMicroteachCaseSiteSenate.Memo] = strComparisonOp;
}
}
return objMicroteachCaseSiteSenateEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachCaseSiteSenateEN.CheckPropertyNew();
clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateCond = new clsMicroteachCaseSiteSenateEN();
string strCondition = objMicroteachCaseSiteSenateCond
.SetIdMicroteachCaseSiteSenate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "<>")
.SetIdMicroteachCase(objMicroteachCaseSiteSenateEN.IdMicroteachCase, "=")
.SetSiteSenateSenator(objMicroteachCaseSiteSenateEN.SiteSenateSenator, "=")
.SetIdMicroteachCaseSiteSenateType(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType, "=")
.GetCombineCondition();
objMicroteachCaseSiteSenateEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseSiteSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_MicroteachCase_SiteSenateSenator_id_MicroteachCaseSiteSenateType)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachCaseSiteSenateEN.Update();
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
 /// <param name = "objMicroteachCaseSiteSenate">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenate)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateCond = new clsMicroteachCaseSiteSenateEN();
string strCondition = objMicroteachCaseSiteSenateCond
.SetIdMicroteachCase(objMicroteachCaseSiteSenate.IdMicroteachCase, "=")
.SetSiteSenateSenator(objMicroteachCaseSiteSenate.SiteSenateSenator, "=")
.SetIdMicroteachCaseSiteSenateType(objMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, "=")
.GetCombineCondition();
objMicroteachCaseSiteSenate._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseSiteSenateBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate = clsMicroteachCaseSiteSenateBL.GetFirstID_S(strCondition);
objMicroteachCaseSiteSenate.UpdateWithCondition(strCondition);
}
else
{
objMicroteachCaseSiteSenate.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.UpdateBySql2(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.UpdateBySql2(objMicroteachCaseSiteSenateEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.UpdateBySqlWithCondition(objMicroteachCaseSiteSenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.UpdateBySqlWithConditionTransaction(objMicroteachCaseSiteSenateEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
try
{
int intRecNum = clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.DelRecord(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objMicroteachCaseSiteSenateENT">目标对象</param>
 public static void CopyTo(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENS, clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENT)
{
try
{
objMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenate = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate; //微格现场评议流水号
objMicroteachCaseSiteSenateENT.FuncModuleId = objMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objMicroteachCaseSiteSenateENT.IdMicroteachCase = objMicroteachCaseSiteSenateENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
objMicroteachCaseSiteSenateENT.IdResource = objMicroteachCaseSiteSenateENS.IdResource; //资源流水号
objMicroteachCaseSiteSenateENT.SiteSenateSenator = objMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objMicroteachCaseSiteSenateENT.SiteSenateTitle = objMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objMicroteachCaseSiteSenateENT.SiteSenateContent = objMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objMicroteachCaseSiteSenateENT.SiteSenateData = objMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objMicroteachCaseSiteSenateENT.SiteSenateTime = objMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objMicroteachCaseSiteSenateENT.SiteSenateReadCount = objMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objMicroteachCaseSiteSenateENT.Memo = objMicroteachCaseSiteSenateENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseSiteSenateENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseSiteSenateEN:objMicroteachCaseSiteSenateENT</returns>
 public static clsMicroteachCaseSiteSenateEN CopyTo(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENS)
{
try
{
 clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENT = new clsMicroteachCaseSiteSenateEN()
{
IdMicroteachCaseSiteSenate = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate, //微格现场评议流水号
FuncModuleId = objMicroteachCaseSiteSenateENS.FuncModuleId, //功能模块Id
IdMicroteachCase = objMicroteachCaseSiteSenateENS.IdMicroteachCase, //微格教学案例流水号
IdMicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType, //微格现场评价类型流水号
IdResource = objMicroteachCaseSiteSenateENS.IdResource, //资源流水号
SiteSenateSenator = objMicroteachCaseSiteSenateENS.SiteSenateSenator, //评议者
SiteSenateTitle = objMicroteachCaseSiteSenateENS.SiteSenateTitle, //评议名称
SiteSenateContent = objMicroteachCaseSiteSenateENS.SiteSenateContent, //现场评议内容
SiteSenateData = objMicroteachCaseSiteSenateENS.SiteSenateData, //现场评议日期
SiteSenateTime = objMicroteachCaseSiteSenateENS.SiteSenateTime, //现场评议时间
SiteSenateReadCount = objMicroteachCaseSiteSenateENS.SiteSenateReadCount, //现场评议阅读次数
Memo = objMicroteachCaseSiteSenateENS.Memo, //备注
};
 return objMicroteachCaseSiteSenateENT;
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
public static void CheckPropertyNew(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.CheckPropertyNew(objMicroteachCaseSiteSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 clsMicroteachCaseSiteSenateBL.MicroteachCaseSiteSenateDA.CheckProperty4Condition(objMicroteachCaseSiteSenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate) == true)
{
string strComparisonOpIdMicroteachCaseSiteSenate = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, objMicroteachCaseSiteSenateCond.IdMicroteachCaseSiteSenate, strComparisonOpIdMicroteachCaseSiteSenate);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.FuncModuleId, objMicroteachCaseSiteSenateCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.IdMicroteachCase, objMicroteachCaseSiteSenateCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType) == true)
{
string strComparisonOpIdMicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, objMicroteachCaseSiteSenateCond.IdMicroteachCaseSiteSenateType, strComparisonOpIdMicroteachCaseSiteSenateType);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.IdResource) == true)
{
string strComparisonOpIdResource = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.IdResource, objMicroteachCaseSiteSenateCond.IdResource, strComparisonOpIdResource);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateSenator) == true)
{
string strComparisonOpSiteSenateSenator = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.SiteSenateSenator, objMicroteachCaseSiteSenateCond.SiteSenateSenator, strComparisonOpSiteSenateSenator);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateTitle) == true)
{
string strComparisonOpSiteSenateTitle = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.SiteSenateTitle, objMicroteachCaseSiteSenateCond.SiteSenateTitle, strComparisonOpSiteSenateTitle);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateContent) == true)
{
string strComparisonOpSiteSenateContent = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.SiteSenateContent, objMicroteachCaseSiteSenateCond.SiteSenateContent, strComparisonOpSiteSenateContent);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateData) == true)
{
string strComparisonOpSiteSenateData = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateData];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.SiteSenateData, objMicroteachCaseSiteSenateCond.SiteSenateData, strComparisonOpSiteSenateData);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateTime) == true)
{
string strComparisonOpSiteSenateTime = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.SiteSenateTime, objMicroteachCaseSiteSenateCond.SiteSenateTime, strComparisonOpSiteSenateTime);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.SiteSenateReadCount) == true)
{
string strComparisonOpSiteSenateReadCount = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.SiteSenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseSiteSenate.SiteSenateReadCount, objMicroteachCaseSiteSenateCond.SiteSenateReadCount, strComparisonOpSiteSenateReadCount);
}
if (objMicroteachCaseSiteSenateCond.IsUpdated(conMicroteachCaseSiteSenate.Memo) == true)
{
string strComparisonOpMemo = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[conMicroteachCaseSiteSenate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseSiteSenate.Memo, objMicroteachCaseSiteSenateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MicroteachCaseSiteSenate(微格教学现场评议), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_MicroteachCase_SiteSenateSenator_id_MicroteachCaseSiteSenateType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseSiteSenateEN == null) return true;
if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCase);
 if (objMicroteachCaseSiteSenateEN.SiteSenateSenator == null)
{
 sbCondition.AppendFormat(" and SiteSenateSenator is null", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
}
else
{
 sbCondition.AppendFormat(" and SiteSenateSenator = '{0}'", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
}
 if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType == null)
{
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType is null", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
}
else
{
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
}
if (clsMicroteachCaseSiteSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdMicroteachCaseSiteSenate !=  {0}", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and SiteSenateSenator = '{0}'", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
if (clsMicroteachCaseSiteSenateBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MicroteachCaseSiteSenate(微格教学现场评议), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_MicroteachCase_SiteSenateSenator_id_MicroteachCaseSiteSenateType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseSiteSenateEN == null) return "";
if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCase);
 if (objMicroteachCaseSiteSenateEN.SiteSenateSenator == null)
{
 sbCondition.AppendFormat(" and SiteSenateSenator is null", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
}
else
{
 sbCondition.AppendFormat(" and SiteSenateSenator = '{0}'", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
}
 if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType == null)
{
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType is null", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
}
else
{
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdMicroteachCaseSiteSenate !=  {0}", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate);
 sbCondition.AppendFormat(" and IdMicroteachCase = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCase);
 sbCondition.AppendFormat(" and SiteSenateSenator = '{0}'", objMicroteachCaseSiteSenateEN.SiteSenateSenator);
 sbCondition.AppendFormat(" and IdMicroteachCaseSiteSenateType = '{0}'", objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachCaseSiteSenate
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachCaseSiteSenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格教学现场评议(MicroteachCaseSiteSenate)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseSiteSenateBL
{
public static RelatedActions_MicroteachCaseSiteSenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachCaseSiteSenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachCaseSiteSenateDA MicroteachCaseSiteSenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachCaseSiteSenateDA();
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
 public clsMicroteachCaseSiteSenateBL()
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
if (string.IsNullOrEmpty(clsMicroteachCaseSiteSenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseSiteSenateEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachCaseSiteSenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachCaseSiteSenateDA.GetDataTable_MicroteachCaseSiteSenate(strWhereCond);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable(strWhereCond);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachCaseSiteSenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseSiteSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByIdMicroteachCaseSiteSenateLst(List<long> arrIdMicroteachCaseSiteSenateLst)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseSiteSenateLst);
 string strWhereCond = string.Format("IdMicroteachCaseSiteSenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseSiteSenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachCaseSiteSenateEN> GetObjLstByIdMicroteachCaseSiteSenateLstCache(List<long> arrIdMicroteachCaseSiteSenateLst)
{
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateEN._CurrTabName);
List<clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLst_Sel =
arrMicroteachCaseSiteSenateObjLstCache
.Where(x => arrIdMicroteachCaseSiteSenateLst.Contains(x.IdMicroteachCaseSiteSenate));
return arrMicroteachCaseSiteSenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
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
public static List<clsMicroteachCaseSiteSenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachCaseSiteSenateEN> GetSubObjLstCache(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateCond)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseSiteSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseSiteSenate.AttributeName)
{
if (objMicroteachCaseSiteSenateCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseSiteSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseSiteSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseSiteSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseSiteSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseSiteSenateCond[strFldName]));
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
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
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
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
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
List<clsMicroteachCaseSiteSenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachCaseSiteSenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachCaseSiteSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
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
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
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
public static List<clsMicroteachCaseSiteSenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
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
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLst = new List<clsMicroteachCaseSiteSenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = new clsMicroteachCaseSiteSenateEN();
try
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = Int32.Parse(objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate].ToString().Trim()); //微格现场评议流水号
objMicroteachCaseSiteSenateEN.FuncModuleId = objRow[conMicroteachCaseSiteSenate.FuncModuleId].ToString().Trim(); //功能模块Id
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objRow[conMicroteachCaseSiteSenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType].ToString().Trim(); //微格现场评价类型流水号
objMicroteachCaseSiteSenateEN.IdResource = objRow[conMicroteachCaseSiteSenate.IdResource] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.IdResource].ToString().Trim(); //资源流水号
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objRow[conMicroteachCaseSiteSenate.SiteSenateSenator] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateSenator].ToString().Trim(); //评议者
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objRow[conMicroteachCaseSiteSenate.SiteSenateTitle].ToString().Trim(); //评议名称
objMicroteachCaseSiteSenateEN.SiteSenateContent = objRow[conMicroteachCaseSiteSenate.SiteSenateContent] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateContent].ToString().Trim(); //现场评议内容
objMicroteachCaseSiteSenateEN.SiteSenateData = objRow[conMicroteachCaseSiteSenate.SiteSenateData] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateData].ToString().Trim(); //现场评议日期
objMicroteachCaseSiteSenateEN.SiteSenateTime = objRow[conMicroteachCaseSiteSenate.SiteSenateTime] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.SiteSenateTime].ToString().Trim(); //现场评议时间
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCaseSiteSenate.SiteSenateReadCount].ToString().Trim()); //现场评议阅读次数
objMicroteachCaseSiteSenateEN.Memo = objRow[conMicroteachCaseSiteSenate.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseSiteSenate.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseSiteSenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachCaseSiteSenate(ref clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
bool bolResult = MicroteachCaseSiteSenateDA.GetMicroteachCaseSiteSenate(ref objMicroteachCaseSiteSenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenate(long lngIdMicroteachCaseSiteSenate)
{
clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = MicroteachCaseSiteSenateDA.GetObjByIdMicroteachCaseSiteSenate(lngIdMicroteachCaseSiteSenate);
return objMicroteachCaseSiteSenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachCaseSiteSenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = MicroteachCaseSiteSenateDA.GetFirstObj(strWhereCond);
 return objMicroteachCaseSiteSenateEN;
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
public static clsMicroteachCaseSiteSenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = MicroteachCaseSiteSenateDA.GetObjByDataRow(objRow);
 return objMicroteachCaseSiteSenateEN;
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
public static clsMicroteachCaseSiteSenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = MicroteachCaseSiteSenateDA.GetObjByDataRow(objRow);
 return objMicroteachCaseSiteSenateEN;
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">所给的关键字</param>
 /// <param name = "lstMicroteachCaseSiteSenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenateFromList(long lngIdMicroteachCaseSiteSenate, List<clsMicroteachCaseSiteSenateEN> lstMicroteachCaseSiteSenateObjLst)
{
foreach (clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN in lstMicroteachCaseSiteSenateObjLst)
{
if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == lngIdMicroteachCaseSiteSenate)
{
return objMicroteachCaseSiteSenateEN;
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
 long lngIdMicroteachCaseSiteSenate;
 try
 {
 lngIdMicroteachCaseSiteSenate = new clsMicroteachCaseSiteSenateDA().GetFirstID(strWhereCond);
 return lngIdMicroteachCaseSiteSenate;
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
 arrList = MicroteachCaseSiteSenateDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachCaseSiteSenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachCaseSiteSenate)
{
//检测记录是否存在
bool bolIsExist = MicroteachCaseSiteSenateDA.IsExist(lngIdMicroteachCaseSiteSenate);
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
 bolIsExist = clsMicroteachCaseSiteSenateDA.IsExistTable();
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
 bolIsExist = MicroteachCaseSiteSenateDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
if (objMicroteachCaseSiteSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],评议者 = [{1}],微格现场评价类型流水号 = [{2}]的数据已经存在!(in clsMicroteachCaseSiteSenateBL.AddNewRecordBySql2)", objMicroteachCaseSiteSenateEN.IdMicroteachCase,objMicroteachCaseSiteSenateEN.SiteSenateSenator,objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
throw new Exception(strMsg);
}
try
{
bool bolResult = MicroteachCaseSiteSenateDA.AddNewRecordBySQL2(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
if (objMicroteachCaseSiteSenateEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格教学案例流水号 = [{0}],评议者 = [{1}],微格现场评价类型流水号 = [{2}]的数据已经存在!(in clsMicroteachCaseSiteSenateBL.AddNewRecordBySql2WithReturnKey)", objMicroteachCaseSiteSenateEN.IdMicroteachCase,objMicroteachCaseSiteSenateEN.SiteSenateSenator,objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType);
throw new Exception(strMsg);
}
try
{
string strKey = MicroteachCaseSiteSenateDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
try
{
bool bolResult = MicroteachCaseSiteSenateDA.Update(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseSiteSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachCaseSiteSenateDA.UpdateBySql2(objMicroteachCaseSiteSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseSiteSenateBL.ReFreshCache();

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdMicroteachCaseSiteSenate)
{
try
{
 clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN = clsMicroteachCaseSiteSenateBL.GetObjByIdMicroteachCaseSiteSenate(lngIdMicroteachCaseSiteSenate);

if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate, "SetUpdDate");
}
if (objMicroteachCaseSiteSenateEN != null)
{
int intRecNum = MicroteachCaseSiteSenateDA.DelRecord(lngIdMicroteachCaseSiteSenate);
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
/// <param name="lngIdMicroteachCaseSiteSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdMicroteachCaseSiteSenate )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseSiteSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate,
//lngIdMicroteachCaseSiteSenate);
//        clsMicroteachCaseSiteSenateBL.DelMicroteachCaseSiteSenatesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseSiteSenateBL.DelRecord(lngIdMicroteachCaseSiteSenate, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseSiteSenateBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachCaseSiteSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdMicroteachCaseSiteSenate">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdMicroteachCaseSiteSenate, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseSiteSenate, "UpdRelaTabDate");
}
bool bolResult = MicroteachCaseSiteSenateDA.DelRecord(lngIdMicroteachCaseSiteSenate,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroteachCaseSiteSenateLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachCaseSiteSenates(List<string> arrIdMicroteachCaseSiteSenateLst)
{
if (arrIdMicroteachCaseSiteSenateLst.Count == 0) return 0;
try
{
if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
foreach (var strIdMicroteachCaseSiteSenate in arrIdMicroteachCaseSiteSenateLst)
{
long lngIdMicroteachCaseSiteSenate = long.Parse(strIdMicroteachCaseSiteSenate);
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseSiteSenate, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachCaseSiteSenateDA.DelMicroteachCaseSiteSenate(arrIdMicroteachCaseSiteSenateLst);
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
public static int DelMicroteachCaseSiteSenatesByCond(string strWhereCond)
{
try
{
if (clsMicroteachCaseSiteSenateBL.relatedActions != null)
{
List<string> arrIdMicroteachCaseSiteSenate = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroteachCaseSiteSenate in arrIdMicroteachCaseSiteSenate)
{
long lngIdMicroteachCaseSiteSenate = long.Parse(strIdMicroteachCaseSiteSenate);
clsMicroteachCaseSiteSenateBL.relatedActions.UpdRelaTabDate(lngIdMicroteachCaseSiteSenate, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachCaseSiteSenateDA.DelMicroteachCaseSiteSenate(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachCaseSiteSenate]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdMicroteachCaseSiteSenate">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdMicroteachCaseSiteSenate)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseSiteSenateDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseSiteSenate]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseSiteSenateBL.DelRecord(lngIdMicroteachCaseSiteSenate, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseSiteSenateBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdMicroteachCaseSiteSenate, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachCaseSiteSenateENS">源对象</param>
 /// <param name = "objMicroteachCaseSiteSenateENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENS, clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateENT)
{
try
{
objMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenate = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenate; //微格现场评议流水号
objMicroteachCaseSiteSenateENT.FuncModuleId = objMicroteachCaseSiteSenateENS.FuncModuleId; //功能模块Id
objMicroteachCaseSiteSenateENT.IdMicroteachCase = objMicroteachCaseSiteSenateENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseSiteSenateENT.IdMicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateENS.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
objMicroteachCaseSiteSenateENT.IdResource = objMicroteachCaseSiteSenateENS.IdResource; //资源流水号
objMicroteachCaseSiteSenateENT.SiteSenateSenator = objMicroteachCaseSiteSenateENS.SiteSenateSenator; //评议者
objMicroteachCaseSiteSenateENT.SiteSenateTitle = objMicroteachCaseSiteSenateENS.SiteSenateTitle; //评议名称
objMicroteachCaseSiteSenateENT.SiteSenateContent = objMicroteachCaseSiteSenateENS.SiteSenateContent; //现场评议内容
objMicroteachCaseSiteSenateENT.SiteSenateData = objMicroteachCaseSiteSenateENS.SiteSenateData; //现场评议日期
objMicroteachCaseSiteSenateENT.SiteSenateTime = objMicroteachCaseSiteSenateENS.SiteSenateTime; //现场评议时间
objMicroteachCaseSiteSenateENT.SiteSenateReadCount = objMicroteachCaseSiteSenateENS.SiteSenateReadCount; //现场评议阅读次数
objMicroteachCaseSiteSenateENT.Memo = objMicroteachCaseSiteSenateENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseSiteSenateEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
try
{
objMicroteachCaseSiteSenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachCaseSiteSenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate = objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenate; //微格现场评议流水号
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.FuncModuleId = objMicroteachCaseSiteSenateEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.IdMicroteachCase = objMicroteachCaseSiteSenateEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType == "[null]" ? null :  objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType; //微格现场评价类型流水号
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.IdResource = objMicroteachCaseSiteSenateEN.IdResource == "[null]" ? null :  objMicroteachCaseSiteSenateEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateSenator, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateSenator = objMicroteachCaseSiteSenateEN.SiteSenateSenator == "[null]" ? null :  objMicroteachCaseSiteSenateEN.SiteSenateSenator; //评议者
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateTitle = objMicroteachCaseSiteSenateEN.SiteSenateTitle; //评议名称
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateContent = objMicroteachCaseSiteSenateEN.SiteSenateContent == "[null]" ? null :  objMicroteachCaseSiteSenateEN.SiteSenateContent; //现场评议内容
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateData, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateData = objMicroteachCaseSiteSenateEN.SiteSenateData == "[null]" ? null :  objMicroteachCaseSiteSenateEN.SiteSenateData; //现场评议日期
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateTime = objMicroteachCaseSiteSenateEN.SiteSenateTime == "[null]" ? null :  objMicroteachCaseSiteSenateEN.SiteSenateTime; //现场评议时间
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.SiteSenateReadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.SiteSenateReadCount = objMicroteachCaseSiteSenateEN.SiteSenateReadCount; //现场评议阅读次数
}
if (arrFldSet.Contains(conMicroteachCaseSiteSenate.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseSiteSenateEN.Memo = objMicroteachCaseSiteSenateEN.Memo == "[null]" ? null :  objMicroteachCaseSiteSenateEN.Memo; //备注
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
 /// <param name = "objMicroteachCaseSiteSenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
try
{
if (objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType == "[null]") objMicroteachCaseSiteSenateEN.IdMicroteachCaseSiteSenateType = null; //微格现场评价类型流水号
if (objMicroteachCaseSiteSenateEN.IdResource == "[null]") objMicroteachCaseSiteSenateEN.IdResource = null; //资源流水号
if (objMicroteachCaseSiteSenateEN.SiteSenateSenator == "[null]") objMicroteachCaseSiteSenateEN.SiteSenateSenator = null; //评议者
if (objMicroteachCaseSiteSenateEN.SiteSenateContent == "[null]") objMicroteachCaseSiteSenateEN.SiteSenateContent = null; //现场评议内容
if (objMicroteachCaseSiteSenateEN.SiteSenateData == "[null]") objMicroteachCaseSiteSenateEN.SiteSenateData = null; //现场评议日期
if (objMicroteachCaseSiteSenateEN.SiteSenateTime == "[null]") objMicroteachCaseSiteSenateEN.SiteSenateTime = null; //现场评议时间
if (objMicroteachCaseSiteSenateEN.Memo == "[null]") objMicroteachCaseSiteSenateEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 MicroteachCaseSiteSenateDA.CheckPropertyNew(objMicroteachCaseSiteSenateEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
 MicroteachCaseSiteSenateDA.CheckProperty4Condition(objMicroteachCaseSiteSenateEN);
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
if (clsMicroteachCaseSiteSenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseSiteSenateBL没有刷新缓存机制(clsMicroteachCaseSiteSenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseSiteSenate");
//if (arrMicroteachCaseSiteSenateObjLstCache == null)
//{
//arrMicroteachCaseSiteSenateObjLstCache = MicroteachCaseSiteSenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseSiteSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseSiteSenateEN GetObjByIdMicroteachCaseSiteSenateCache(long lngIdMicroteachCaseSiteSenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateEN._CurrTabName);
List<clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLst_Sel =
arrMicroteachCaseSiteSenateObjLstCache
.Where(x=> x.IdMicroteachCaseSiteSenate == lngIdMicroteachCaseSiteSenate 
);
if (arrMicroteachCaseSiteSenateObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseSiteSenateEN obj = clsMicroteachCaseSiteSenateBL.GetObjByIdMicroteachCaseSiteSenate(lngIdMicroteachCaseSiteSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachCaseSiteSenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetAllMicroteachCaseSiteSenateObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLstCache = GetObjLstCache(); 
return arrMicroteachCaseSiteSenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseSiteSenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateEN._CurrTabName);
List<clsMicroteachCaseSiteSenateEN> arrMicroteachCaseSiteSenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseSiteSenateObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateEN._CurrTabName);
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
if (clsMicroteachCaseSiteSenateBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseSiteSenateEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCaseSiteSenateBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MicroteachCaseSiteSenate(微格教学现场评议)
 /// 唯一性条件:id_MicroteachCase_SiteSenateSenator_id_MicroteachCaseSiteSenateType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateEN)
{
//检测记录是否存在
string strResult = MicroteachCaseSiteSenateDA.GetUniCondStr(objMicroteachCaseSiteSenateEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachCaseSiteSenate)
{
if (strInFldName != conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachCaseSiteSenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachCaseSiteSenate.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachCaseSiteSenate = clsMicroteachCaseSiteSenateBL.GetObjByIdMicroteachCaseSiteSenateCache(lngIdMicroteachCaseSiteSenate);
if (objMicroteachCaseSiteSenate == null) return "";
return objMicroteachCaseSiteSenate[strOutFldName].ToString();
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
int intRecCount = clsMicroteachCaseSiteSenateDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachCaseSiteSenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachCaseSiteSenateDA.GetRecCount();
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
int intRecCount = clsMicroteachCaseSiteSenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachCaseSiteSenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachCaseSiteSenateEN objMicroteachCaseSiteSenateCond)
{
List<clsMicroteachCaseSiteSenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseSiteSenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseSiteSenate.AttributeName)
{
if (objMicroteachCaseSiteSenateCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseSiteSenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseSiteSenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseSiteSenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseSiteSenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseSiteSenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseSiteSenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseSiteSenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseSiteSenateCond[strFldName]));
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
 List<string> arrList = clsMicroteachCaseSiteSenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseSiteSenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseSiteSenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachCaseSiteSenateDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseSiteSenateDA.SetFldValue(clsMicroteachCaseSiteSenateEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachCaseSiteSenateDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseSiteSenateDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseSiteSenateDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseSiteSenateDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachCaseSiteSenate] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格现场评议流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCaseSiteSenate bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**微格教学案例流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCase char(8) not Null, "); 
 // /**微格现场评价类型流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCaseSiteSenateType char(4) Null, "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) Null, "); 
 // /**评议者*/ 
 strCreateTabCode.Append(" SiteSenateSenator varchar(50) Null, "); 
 // /**评议名称*/ 
 strCreateTabCode.Append(" SiteSenateTitle varchar(50) not Null, "); 
 // /**现场评议内容*/ 
 strCreateTabCode.Append(" SiteSenateContent varchar(2000) Null, "); 
 // /**现场评议日期*/ 
 strCreateTabCode.Append(" SiteSenateData char(8) Null, "); 
 // /**现场评议时间*/ 
 strCreateTabCode.Append(" SiteSenateTime char(6) Null, "); 
 // /**现场评议阅读次数*/ 
 strCreateTabCode.Append(" SiteSenateReadCount int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格教学现场评议(MicroteachCaseSiteSenate)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachCaseSiteSenate : clsCommFun4BL
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
clsMicroteachCaseSiteSenateBL.ReFreshThisCache();
}
}

}