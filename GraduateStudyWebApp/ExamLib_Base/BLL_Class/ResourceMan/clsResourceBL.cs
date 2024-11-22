
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceBL
 表名:Resource(01120320)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
public static class  clsResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceEN GetObj(this K_IdResource_Resource myKey)
{
clsResourceEN objResourceEN = clsResourceBL.ResourceDA.GetObjByIdResource(myKey.Value);
return objResourceEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResourceEN) == false)
{
var strMsg = string.Format("记录已经存在!资源ID = [{0}]的数据已经存在!(in clsResourceBL.AddNewRecord)", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
bool bolResult = clsResourceBL.ResourceDA.AddNewRecordBySQL2(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
public static bool AddRecordEx(this clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsResourceBL.IsExist(objResourceEN.IdResource))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objResourceEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objResourceEN.CheckUniqueness() == false)
{
strMsg = string.Format("(资源ID(ResourceID)=[{0}])已经存在,不能重复!", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objResourceEN.AddNewRecord();
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResourceEN) == false)
{
var strMsg = string.Format("记录已经存在!资源ID = [{0}]的数据已经存在!(in clsResourceBL.AddNewRecordWithMaxId)", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
string strIdResource = clsResourceBL.ResourceDA.AddNewRecordBySQL2WithReturnKey(objResourceEN);
     objResourceEN.IdResource = strIdResource;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
}
return strIdResource;
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResourceEN) == false)
{
var strMsg = string.Format("记录已经存在!资源ID = [{0}]的数据已经存在!(in clsResourceBL.AddNewRecordWithReturnKey)", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
string strKey = clsResourceBL.ResourceDA.AddNewRecordBySQL2WithReturnKey(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetIdResource(this clsResourceEN objResourceEN, string strIdResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, conResource.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, conResource.IdResource);
}
objResourceEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.IdResource) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.IdResource, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.IdResource] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetResourceID(this clsResourceEN objResourceEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, conResource.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, conResource.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, conResource.ResourceID);
}
objResourceEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.ResourceID) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.ResourceID, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.ResourceID] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetResourceName(this clsResourceEN objResourceEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceName, conResource.ResourceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, conResource.ResourceName);
}
objResourceEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.ResourceName) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.ResourceName, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.ResourceName] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetSaveMode(this clsResourceEN objResourceEN, bool bolSaveMode, string strComparisonOp="")
	{
objResourceEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.SaveMode) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.SaveMode, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.SaveMode] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetIdFtpResource(this clsResourceEN objResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conResource.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conResource.IdFtpResource);
}
objResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.IdFtpResource) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.IdFtpResource, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.IdFtpResource] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetIdFile(this clsResourceEN objResourceEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, conResource.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, conResource.IdFile);
}
objResourceEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.IdFile) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.IdFile, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.IdFile] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetIdResourceType(this clsResourceEN objResourceEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, conResource.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, conResource.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, conResource.IdResourceType);
}
objResourceEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.IdResourceType) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.IdResourceType, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.IdResourceType] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetUpdDate(this clsResourceEN objResourceEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conResource.UpdDate);
}
objResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.UpdDate) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.UpdDate, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.UpdDate] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetUpdTime(this clsResourceEN objResourceEN, string strUpdTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdTime, 6, conResource.UpdTime);
}
objResourceEN.UpdTime = strUpdTime; //UpdTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.UpdTime) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.UpdTime, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.UpdTime] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetMemo(this clsResourceEN objResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conResource.Memo);
}
objResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.Memo) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.Memo, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.Memo] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetFuncModuleId(this clsResourceEN objResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conResource.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conResource.FuncModuleId);
}
objResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.FuncModuleId) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.FuncModuleId, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.FuncModuleId] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetCheckDate(this clsResourceEN objResourceEN, string strCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conResource.CheckDate);
}
objResourceEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckDate) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckDate, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckDate] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetCheckUser(this clsResourceEN objResourceEN, string strCheckUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckUser, 18, conResource.CheckUser);
}
objResourceEN.CheckUser = strCheckUser; //检查用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckUser) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckUser, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckUser] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceEN SetCheckResult(this clsResourceEN objResourceEN, string strCheckResult, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, conResource.CheckResult);
}
objResourceEN.CheckResult = strCheckResult; //检查结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckResult) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckResult, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckResult] = strComparisonOp;
}
}
return objResourceEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objResourceEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsResourceEN objResourceEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objResourceEN.CheckPropertyNew();
clsResourceEN objResourceCond = new clsResourceEN();
string strCondition = objResourceCond
.SetIdResource(objResourceEN.IdResource, "<>")
.SetResourceID(objResourceEN.ResourceID, "=")
.GetCombineCondition();
objResourceEN._IsCheckProperty = true;
bool bolIsExist = clsResourceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ResourceID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objResourceEN.Update();
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
 /// <param name = "objResource">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsResourceEN objResource)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsResourceEN objResourceCond = new clsResourceEN();
string strCondition = objResourceCond
.SetResourceID(objResource.ResourceID, "=")
.GetCombineCondition();
objResource._IsCheckProperty = true;
bool bolIsExist = clsResourceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objResource.IdResource = clsResourceBL.GetFirstID_S(strCondition);
objResource.UpdateWithCondition(strCondition);
}
else
{
objResource.IdResource = clsResourceBL.GetMaxStrId_S();
objResource.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceEN objResourceEN)
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResourceBL.ResourceDA.UpdateBySql2(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceEN objResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResourceBL.ResourceDA.UpdateBySql2(objResourceEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceEN objResourceEN, string strWhereCond)
{
try
{
bool bolResult = clsResourceBL.ResourceDA.UpdateBySqlWithCondition(objResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceEN objResourceEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsResourceBL.ResourceDA.UpdateBySqlWithConditionTransaction(objResourceEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsResourceEN objResourceEN)
{
try
{
int intRecNum = clsResourceBL.ResourceDA.DelRecord(objResourceEN.IdResource);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceENS">源对象</param>
 /// <param name = "objResourceENT">目标对象</param>
 public static void CopyTo(this clsResourceEN objResourceENS, clsResourceEN objResourceENT)
{
try
{
objResourceENT.IdResource = objResourceENS.IdResource; //资源流水号
objResourceENT.ResourceID = objResourceENS.ResourceID; //资源ID
objResourceENT.ResourceName = objResourceENS.ResourceName; //资源名称
objResourceENT.SaveMode = objResourceENS.SaveMode; //文件存放方式
objResourceENT.IdFtpResource = objResourceENS.IdFtpResource; //FTP资源流水号
objResourceENT.IdFile = objResourceENS.IdFile; //文件流水号
objResourceENT.IdResourceType = objResourceENS.IdResourceType; //资源类型流水号
objResourceENT.UpdDate = objResourceENS.UpdDate; //修改日期
objResourceENT.UpdTime = objResourceENS.UpdTime; //UpdTime
objResourceENT.Memo = objResourceENS.Memo; //备注
objResourceENT.FuncModuleId = objResourceENS.FuncModuleId; //功能模块Id
objResourceENT.CheckDate = objResourceENS.CheckDate; //检查日期
objResourceENT.CheckUser = objResourceENS.CheckUser; //检查用户Id
objResourceENT.CheckResult = objResourceENS.CheckResult; //检查结果
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
 /// <param name = "objResourceENS">源对象</param>
 /// <returns>目标对象=>clsResourceEN:objResourceENT</returns>
 public static clsResourceEN CopyTo(this clsResourceEN objResourceENS)
{
try
{
 clsResourceEN objResourceENT = new clsResourceEN()
{
IdResource = objResourceENS.IdResource, //资源流水号
ResourceID = objResourceENS.ResourceID, //资源ID
ResourceName = objResourceENS.ResourceName, //资源名称
SaveMode = objResourceENS.SaveMode, //文件存放方式
IdFtpResource = objResourceENS.IdFtpResource, //FTP资源流水号
IdFile = objResourceENS.IdFile, //文件流水号
IdResourceType = objResourceENS.IdResourceType, //资源类型流水号
UpdDate = objResourceENS.UpdDate, //修改日期
UpdTime = objResourceENS.UpdTime, //UpdTime
Memo = objResourceENS.Memo, //备注
FuncModuleId = objResourceENS.FuncModuleId, //功能模块Id
CheckDate = objResourceENS.CheckDate, //检查日期
CheckUser = objResourceENS.CheckUser, //检查用户Id
CheckResult = objResourceENS.CheckResult, //检查结果
};
 return objResourceENT;
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
public static void CheckPropertyNew(this clsResourceEN objResourceEN)
{
 clsResourceBL.ResourceDA.CheckPropertyNew(objResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsResourceEN objResourceEN)
{
 clsResourceBL.ResourceDA.CheckProperty4Condition(objResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsResourceEN objResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objResourceCond.IsUpdated(conResource.IdResource) == true)
{
string strComparisonOpIdResource = objResourceCond.dicFldComparisonOp[conResource.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.IdResource, objResourceCond.IdResource, strComparisonOpIdResource);
}
if (objResourceCond.IsUpdated(conResource.ResourceID) == true)
{
string strComparisonOpResourceID = objResourceCond.dicFldComparisonOp[conResource.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.ResourceID, objResourceCond.ResourceID, strComparisonOpResourceID);
}
if (objResourceCond.IsUpdated(conResource.ResourceName) == true)
{
string strComparisonOpResourceName = objResourceCond.dicFldComparisonOp[conResource.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.ResourceName, objResourceCond.ResourceName, strComparisonOpResourceName);
}
if (objResourceCond.IsUpdated(conResource.SaveMode) == true)
{
if (objResourceCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conResource.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conResource.SaveMode);
}
}
if (objResourceCond.IsUpdated(conResource.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objResourceCond.dicFldComparisonOp[conResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.IdFtpResource, objResourceCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objResourceCond.IsUpdated(conResource.IdFile) == true)
{
string strComparisonOpIdFile = objResourceCond.dicFldComparisonOp[conResource.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.IdFile, objResourceCond.IdFile, strComparisonOpIdFile);
}
if (objResourceCond.IsUpdated(conResource.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objResourceCond.dicFldComparisonOp[conResource.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.IdResourceType, objResourceCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objResourceCond.IsUpdated(conResource.UpdDate) == true)
{
string strComparisonOpUpdDate = objResourceCond.dicFldComparisonOp[conResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.UpdDate, objResourceCond.UpdDate, strComparisonOpUpdDate);
}
if (objResourceCond.IsUpdated(conResource.UpdTime) == true)
{
string strComparisonOpUpdTime = objResourceCond.dicFldComparisonOp[conResource.UpdTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.UpdTime, objResourceCond.UpdTime, strComparisonOpUpdTime);
}
if (objResourceCond.IsUpdated(conResource.Memo) == true)
{
string strComparisonOpMemo = objResourceCond.dicFldComparisonOp[conResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.Memo, objResourceCond.Memo, strComparisonOpMemo);
}
if (objResourceCond.IsUpdated(conResource.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objResourceCond.dicFldComparisonOp[conResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.FuncModuleId, objResourceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objResourceCond.IsUpdated(conResource.CheckDate) == true)
{
string strComparisonOpCheckDate = objResourceCond.dicFldComparisonOp[conResource.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckDate, objResourceCond.CheckDate, strComparisonOpCheckDate);
}
if (objResourceCond.IsUpdated(conResource.CheckUser) == true)
{
string strComparisonOpCheckUser = objResourceCond.dicFldComparisonOp[conResource.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckUser, objResourceCond.CheckUser, strComparisonOpCheckUser);
}
if (objResourceCond.IsUpdated(conResource.CheckResult) == true)
{
string strComparisonOpCheckResult = objResourceCond.dicFldComparisonOp[conResource.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckResult, objResourceCond.CheckResult, strComparisonOpCheckResult);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Resource(资源), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ResourceID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsResourceEN objResourceEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objResourceEN == null) return true;
if (objResourceEN.IdResource == null || objResourceEN.IdResource == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
if (clsResourceBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdResource !=  '{0}'", objResourceEN.IdResource);
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
if (clsResourceBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Resource(资源), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ResourceID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsResourceEN objResourceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objResourceEN == null) return "";
if (objResourceEN.IdResource == null || objResourceEN.IdResource == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdResource !=  '{0}'", objResourceEN.IdResource);
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Resource
{
public virtual bool UpdRelaTabDate(string strIdResource, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 资源(Resource)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsResourceBL
{
public static RelatedActions_Resource relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsResourceDA ResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsResourceDA();
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
 public clsResourceBL()
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
if (string.IsNullOrEmpty(clsResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResourceEN._ConnectString);
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
public static DataTable GetDataTable_Resource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ResourceDA.GetDataTable_Resource(strWhereCond);
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
objDT = ResourceDA.GetDataTable(strWhereCond);
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
objDT = ResourceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ResourceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ResourceDA.GetDataTable_Top(objTopPara);
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
objDT = ResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsResourceEN> GetObjLstByIdResourceLst(List<string> arrIdResourceLst)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdResourceLst, true);
 string strWhereCond = string.Format("IdResource in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdResourceLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsResourceEN> GetObjLstByIdResourceLstCache(List<string> arrIdResourceLst)
{
string strKey = string.Format("{0}", clsResourceEN._CurrTabName);
List<clsResourceEN> arrResourceObjLstCache = GetObjLstCache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel =
arrResourceObjLstCache
.Where(x => arrIdResourceLst.Contains(x.IdResource));
return arrResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceEN> GetObjLst(string strWhereCond)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
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
public static List<clsResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsResourceEN> GetSubObjLstCache(clsResourceEN objResourceCond)
{
List<clsResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResource.AttributeName)
{
if (objResourceCond.IsUpdated(strFldName) == false) continue;
if (objResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceCond[strFldName].ToString());
}
else
{
if (objResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResourceCond[strFldName]));
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
public static List<clsResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
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
public static List<clsResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
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
List<clsResourceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
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
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
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
public static List<clsResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
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
public static List<clsResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceEN.IdResource, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetResource(ref clsResourceEN objResourceEN)
{
bool bolResult = ResourceDA.GetResource(ref objResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceEN GetObjByIdResource(string strIdResource)
{
if (strIdResource.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdResource]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdResource) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdResource]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsResourceEN objResourceEN = ResourceDA.GetObjByIdResource(strIdResource);
return objResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsResourceEN objResourceEN = ResourceDA.GetFirstObj(strWhereCond);
 return objResourceEN;
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
public static clsResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsResourceEN objResourceEN = ResourceDA.GetObjByDataRow(objRow);
 return objResourceEN;
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
public static clsResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsResourceEN objResourceEN = ResourceDA.GetObjByDataRow(objRow);
 return objResourceEN;
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
 /// <param name = "strIdResource">所给的关键字</param>
 /// <param name = "lstResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceEN GetObjByIdResourceFromList(string strIdResource, List<clsResourceEN> lstResourceObjLst)
{
foreach (clsResourceEN objResourceEN in lstResourceObjLst)
{
if (objResourceEN.IdResource == strIdResource)
{
return objResourceEN;
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
 string strMaxIdResource;
 try
 {
 strMaxIdResource = clsResourceDA.GetMaxStrId();
 return strMaxIdResource;
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
 string strIdResource;
 try
 {
 strIdResource = new clsResourceDA().GetFirstID(strWhereCond);
 return strIdResource;
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
 arrList = ResourceDA.GetID(strWhereCond);
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
bool bolIsExist = ResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdResource]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ResourceDA.IsExist(strIdResource);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdResource">资源流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdResource, string strOpUser)
{
clsResourceEN objResourceEN = clsResourceBL.GetObjByIdResource(strIdResource);
objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsResourceBL.UpdateBySql2(objResourceEN);
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
 bolIsExist = clsResourceDA.IsExistTable();
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
 bolIsExist = ResourceDA.IsExistTable(strTabName);
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objResourceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!资源ID = [{0}]的数据已经存在!(in clsResourceBL.AddNewRecordBySql2)", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
bool bolResult = ResourceDA.AddNewRecordBySQL2(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsResourceEN objResourceEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objResourceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!资源ID = [{0}]的数据已经存在!(in clsResourceBL.AddNewRecordBySql2WithReturnKey)", objResourceEN.ResourceID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true || clsResourceBL.IsExist(objResourceEN.IdResource) == true)
 {
     objResourceEN.IdResource = clsResourceBL.GetMaxStrId_S();
 }
string strKey = ResourceDA.AddNewRecordBySQL2WithReturnKey(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsResourceEN objResourceEN)
{
try
{
bool bolResult = ResourceDA.Update(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsResourceEN objResourceEN)
{
 if (string.IsNullOrEmpty(objResourceEN.IdResource) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ResourceDA.UpdateBySql2(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceBL.ReFreshCache();

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdResource)
{
try
{
 clsResourceEN objResourceEN = clsResourceBL.GetObjByIdResource(strIdResource);

if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(objResourceEN.IdResource, "SetUpdDate");
}
if (objResourceEN != null)
{
int intRecNum = ResourceDA.DelRecord(strIdResource);
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
/// <param name="strIdResource">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdResource )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResourceDA.GetSpecSQLObj();
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
//删除与表:[Resource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conResource.IdResource,
//strIdResource);
//        clsResourceBL.DelResourcesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResourceBL.DelRecord(strIdResource, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResourceBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdResource, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdResource, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsResourceBL.relatedActions != null)
{
clsResourceBL.relatedActions.UpdRelaTabDate(strIdResource, "UpdRelaTabDate");
}
bool bolResult = ResourceDA.DelRecord(strIdResource,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdResourceLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelResources(List<string> arrIdResourceLst)
{
if (arrIdResourceLst.Count == 0) return 0;
try
{
if (clsResourceBL.relatedActions != null)
{
foreach (var strIdResource in arrIdResourceLst)
{
clsResourceBL.relatedActions.UpdRelaTabDate(strIdResource, "UpdRelaTabDate");
}
}
int intDelRecNum = ResourceDA.DelResource(arrIdResourceLst);
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
public static int DelResourcesByCond(string strWhereCond)
{
try
{
if (clsResourceBL.relatedActions != null)
{
List<string> arrIdResource = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdResource in arrIdResource)
{
clsResourceBL.relatedActions.UpdRelaTabDate(strIdResource, "UpdRelaTabDate");
}
}
int intRecNum = ResourceDA.DelResource(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Resource]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdResource">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdResource)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResourceDA.GetSpecSQLObj();
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
//删除与表:[Resource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResourceBL.DelRecord(strIdResource, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResourceBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdResource, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objResourceENS">源对象</param>
 /// <param name = "objResourceENT">目标对象</param>
 public static void CopyTo(clsResourceEN objResourceENS, clsResourceEN objResourceENT)
{
try
{
objResourceENT.IdResource = objResourceENS.IdResource; //资源流水号
objResourceENT.ResourceID = objResourceENS.ResourceID; //资源ID
objResourceENT.ResourceName = objResourceENS.ResourceName; //资源名称
objResourceENT.SaveMode = objResourceENS.SaveMode; //文件存放方式
objResourceENT.IdFtpResource = objResourceENS.IdFtpResource; //FTP资源流水号
objResourceENT.IdFile = objResourceENS.IdFile; //文件流水号
objResourceENT.IdResourceType = objResourceENS.IdResourceType; //资源类型流水号
objResourceENT.UpdDate = objResourceENS.UpdDate; //修改日期
objResourceENT.UpdTime = objResourceENS.UpdTime; //UpdTime
objResourceENT.Memo = objResourceENS.Memo; //备注
objResourceENT.FuncModuleId = objResourceENS.FuncModuleId; //功能模块Id
objResourceENT.CheckDate = objResourceENS.CheckDate; //检查日期
objResourceENT.CheckUser = objResourceENS.CheckUser; //检查用户Id
objResourceENT.CheckResult = objResourceENS.CheckResult; //检查结果
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
 /// <param name = "objResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsResourceEN objResourceEN)
{
try
{
objResourceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conResource.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.IdResource = objResourceEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(conResource.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.ResourceID = objResourceEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(conResource.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.ResourceName = objResourceEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(conResource.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.SaveMode = objResourceEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(conResource.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.IdFtpResource = objResourceEN.IdFtpResource == "[null]" ? null :  objResourceEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(conResource.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.IdFile = objResourceEN.IdFile == "[null]" ? null :  objResourceEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(conResource.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.IdResourceType = objResourceEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(conResource.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.UpdDate = objResourceEN.UpdDate == "[null]" ? null :  objResourceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conResource.UpdTime, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.UpdTime = objResourceEN.UpdTime == "[null]" ? null :  objResourceEN.UpdTime; //UpdTime
}
if (arrFldSet.Contains(conResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.Memo = objResourceEN.Memo == "[null]" ? null :  objResourceEN.Memo; //备注
}
if (arrFldSet.Contains(conResource.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.FuncModuleId = objResourceEN.FuncModuleId == "[null]" ? null :  objResourceEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conResource.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.CheckDate = objResourceEN.CheckDate == "[null]" ? null :  objResourceEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conResource.CheckUser, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.CheckUser = objResourceEN.CheckUser == "[null]" ? null :  objResourceEN.CheckUser; //检查用户Id
}
if (arrFldSet.Contains(conResource.CheckResult, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceEN.CheckResult = objResourceEN.CheckResult == "[null]" ? null :  objResourceEN.CheckResult; //检查结果
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
 /// <param name = "objResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsResourceEN objResourceEN)
{
try
{
if (objResourceEN.IdFtpResource == "[null]") objResourceEN.IdFtpResource = null; //FTP资源流水号
if (objResourceEN.IdFile == "[null]") objResourceEN.IdFile = null; //文件流水号
if (objResourceEN.UpdDate == "[null]") objResourceEN.UpdDate = null; //修改日期
if (objResourceEN.UpdTime == "[null]") objResourceEN.UpdTime = null; //UpdTime
if (objResourceEN.Memo == "[null]") objResourceEN.Memo = null; //备注
if (objResourceEN.FuncModuleId == "[null]") objResourceEN.FuncModuleId = null; //功能模块Id
if (objResourceEN.CheckDate == "[null]") objResourceEN.CheckDate = null; //检查日期
if (objResourceEN.CheckUser == "[null]") objResourceEN.CheckUser = null; //检查用户Id
if (objResourceEN.CheckResult == "[null]") objResourceEN.CheckResult = null; //检查结果
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
public static void CheckPropertyNew(clsResourceEN objResourceEN)
{
 ResourceDA.CheckPropertyNew(objResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsResourceEN objResourceEN)
{
 ResourceDA.CheckProperty4Condition(objResourceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdResourceCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[资源]...","0");
List<clsResourceEN> arrResourceObjLst = GetAllResourceObjLstCache(); 
objDDL.DataValueField = conResource.IdResource;
objDDL.DataTextField = conResource.ResourceName;
objDDL.DataSource = arrResourceObjLst;
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
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdResource");
//if (arrResourceObjLstCache == null)
//{
//arrResourceObjLstCache = ResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceEN GetObjByIdResourceCache(string strIdResource)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsResourceEN._CurrTabName);
List<clsResourceEN> arrResourceObjLstCache = GetObjLstCache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel =
arrResourceObjLstCache
.Where(x=> x.IdResource == strIdResource 
);
if (arrResourceObjLst_Sel.Count() == 0)
{
   clsResourceEN obj = clsResourceBL.GetObjByIdResource(strIdResource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceNameByIdResourceCache(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return "";
//获取缓存中的对象列表
clsResourceEN objResource = GetObjByIdResourceCache(strIdResource);
if (objResource == null) return "";
return objResource.ResourceName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdResourceCache(string strIdResource)
{
if (string.IsNullOrEmpty(strIdResource) == true) return "";
//获取缓存中的对象列表
clsResourceEN objResource = GetObjByIdResourceCache(strIdResource);
if (objResource == null) return "";
return objResource.ResourceName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceEN> GetAllResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsResourceEN> arrResourceObjLstCache = GetObjLstCache(); 
return arrResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsResourceEN._CurrTabName);
List<clsResourceEN> arrResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrResourceObjLstCache;
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
string strKey = string.Format("{0}", clsResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsResourceEN._RefreshTimeLst.Count == 0) return "";
return clsResourceEN._RefreshTimeLst[clsResourceEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsResourceBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsResourceBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Resource(资源)
 /// 唯一性条件:ResourceID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsResourceEN objResourceEN)
{
//检测记录是否存在
string strResult = ResourceDA.GetUniCondStr(objResourceEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdResource)
{
if (strInFldName != conResource.IdResource)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conResource.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conResource.AttributeName));
throw new Exception(strMsg);
}
var objResource = clsResourceBL.GetObjByIdResourceCache(strIdResource);
if (objResource == null) return "";
return objResource[strOutFldName].ToString();
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
int intRecCount = clsResourceDA.GetRecCount(strTabName);
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
int intRecCount = clsResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsResourceDA.GetRecCount();
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
int intRecCount = clsResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsResourceEN objResourceCond)
{
List<clsResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResource.AttributeName)
{
if (objResourceCond.IsUpdated(strFldName) == false) continue;
if (objResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceCond[strFldName].ToString());
}
else
{
if (objResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResourceCond[strFldName]));
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
 List<string> arrList = clsResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ResourceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ResourceDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsResourceDA.SetFldValue(clsResourceEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ResourceDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsResourceDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsResourceDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsResourceDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Resource] "); 
 strCreateTabCode.Append(" ( "); 
 // /**资源流水号*/ 
 strCreateTabCode.Append(" IdResource char(8) primary key, "); 
 // /**资源ID*/ 
 strCreateTabCode.Append(" ResourceID char(8) not Null, "); 
 // /**资源名称*/ 
 strCreateTabCode.Append(" ResourceName varchar(100) not Null, "); 
 // /**文件存放方式*/ 
 strCreateTabCode.Append(" SaveMode bit Null, "); 
 // /**FTP资源流水号*/ 
 strCreateTabCode.Append(" IdFtpResource char(8) Null, "); 
 // /**文件流水号*/ 
 strCreateTabCode.Append(" IdFile char(8) Null, "); 
 // /**资源类型流水号*/ 
 strCreateTabCode.Append(" IdResourceType char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**UpdTime*/ 
 strCreateTabCode.Append(" UpdTime varchar(6) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) Null, "); 
 // /**检查日期*/ 
 strCreateTabCode.Append(" CheckDate varchar(20) Null, "); 
 // /**检查用户Id*/ 
 strCreateTabCode.Append(" CheckUser varchar(18) Null, "); 
 // /**检查结果*/ 
 strCreateTabCode.Append(" CheckResult varchar(1000) Null, "); 
 // /**文件新名*/ 
 strCreateTabCode.Append(" FileRename varchar(200) Null, "); 
 // /**文件名称*/ 
 strCreateTabCode.Append(" FileName varchar(500) Null, "); 
 // /**资源类型名称*/ 
 strCreateTabCode.Append(" ResourceTypeName varchar(50) Null, "); 
 // /**功能模块名称*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 资源(Resource)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Resource : clsCommFun4BL
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
clsResourceBL.ReFreshThisCache();
}
}

}