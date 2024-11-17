
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeBL
 表名:CodeType(01160068)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:28
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:生成代码(GeneCode)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsCodeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeTypeEN GetObj(this K_CodeTypeId_CodeType myKey)
{
clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.CodeTypeDA.GetObjByCodeTypeId(myKey.Value);
return objCodeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeTypeEN objCodeTypeEN)
{
if (CheckUniqueness_CodeTypeName(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecord)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsCodeTypeEN objCodeTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCodeTypeEN.CheckPropertyNew();
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCodeTypeEN.AddNewRecord();
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCodeTypeEN objCodeTypeEN)
{
if (CheckUniqueness_CodeTypeName(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordWithMaxId)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strCodeTypeId = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
     objCodeTypeEN.CodeTypeId = strCodeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
}
return strCodeTypeId;
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCodeTypeEN objCodeTypeEN)
{
if (CheckUniqueness_CodeTypeName(objCodeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordWithReturnKey)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strKey = clsCodeTypeBL.CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeId(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conCodeType.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conCodeType.CodeTypeId);
}
objCodeTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, conCodeType.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, conCodeType.CodeTypeName);
}
objCodeTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeSimName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, conCodeType.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, conCodeType.CodeTypeSimName);
}
objCodeTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeSimName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeSimName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeSimName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetCodeTypeENName(this clsCodeTypeEN objCodeTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, conCodeType.CodeTypeENName);
}
objCodeTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.CodeTypeENName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.CodeTypeENName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.CodeTypeENName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetGroupName(this clsCodeTypeEN objCodeTypeEN, string strGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, conCodeType.GroupName);
}
objCodeTypeEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.GroupName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.GroupName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.GroupName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetProgLangTypeId(this clsCodeTypeEN objCodeTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conCodeType.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conCodeType.ProgLangTypeId);
}
objCodeTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ProgLangTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ProgLangTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ProgLangTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetRegionTypeId(this clsCodeTypeEN objCodeTypeEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, conCodeType.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conCodeType.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conCodeType.RegionTypeId);
}
objCodeTypeEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.RegionTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.RegionTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.RegionTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetPrefix(this clsCodeTypeEN objCodeTypeEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, conCodeType.Prefix);
}
objCodeTypeEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Prefix) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Prefix, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Prefix] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetDependsOn(this clsCodeTypeEN objCodeTypeEN, string strDependsOn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDependsOn, 50, conCodeType.DependsOn);
}
objCodeTypeEN.DependsOn = strDependsOn; //依赖于
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.DependsOn) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.DependsOn, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.DependsOn] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetFrontOrBack(this clsCodeTypeEN objCodeTypeEN, string strFrontOrBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFrontOrBack, 50, conCodeType.FrontOrBack);
}
objCodeTypeEN.FrontOrBack = strFrontOrBack; //前台Or后台
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FrontOrBack) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FrontOrBack, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FrontOrBack] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetSqlDsTypeId(this clsCodeTypeEN objCodeTypeEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, conCodeType.SqlDsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conCodeType.SqlDsTypeId);
}
objCodeTypeEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.SqlDsTypeId) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.SqlDsTypeId, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.SqlDsTypeId] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetClassNameFormat(this clsCodeTypeEN objCodeTypeEN, string strClassNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameFormat, 50, conCodeType.ClassNameFormat);
}
objCodeTypeEN.ClassNameFormat = strClassNameFormat; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetClassNameFormatEx(this clsCodeTypeEN objCodeTypeEN, string strClassNameFormatEx, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameFormatEx, 50, conCodeType.ClassNameFormatEx);
}
objCodeTypeEN.ClassNameFormatEx = strClassNameFormatEx; //类名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNameFormatEx) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNameFormatEx, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNameFormatEx] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetFileNameFormat(this clsCodeTypeEN objCodeTypeEN, string strFileNameFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNameFormat, 50, conCodeType.FileNameFormat);
}
objCodeTypeEN.FileNameFormat = strFileNameFormat; //文件名格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FileNameFormat) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FileNameFormat, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FileNameFormat] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetClassNamePattern(this clsCodeTypeEN objCodeTypeEN, string strClassNamePattern, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNamePattern, 50, conCodeType.ClassNamePattern);
}
objCodeTypeEN.ClassNamePattern = strClassNamePattern; //类名模式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.ClassNamePattern) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.ClassNamePattern, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.ClassNamePattern] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsCSharp(this clsCodeTypeEN objCodeTypeEN, bool bolIsCSharp, string strComparisonOp="")
	{
objCodeTypeEN.IsCSharp = bolIsCSharp; //是否CSharp语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsCSharp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsCSharp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsCSharp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsJava(this clsCodeTypeEN objCodeTypeEN, bool bolIsJava, string strComparisonOp="")
	{
objCodeTypeEN.IsJava = bolIsJava; //是否Java语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJava) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJava, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJava] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsJavaScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsJavaScript, string strComparisonOp="")
	{
objCodeTypeEN.IsJavaScript = bolIsJavaScript; //是否JavaScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsJavaScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsJavaScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsJavaScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsTypeScript(this clsCodeTypeEN objCodeTypeEN, bool bolIsTypeScript, string strComparisonOp="")
	{
objCodeTypeEN.IsTypeScript = bolIsTypeScript; //是否TypeScript语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTypeScript) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTypeScript, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTypeScript] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsSilverLight(this clsCodeTypeEN objCodeTypeEN, bool bolIsSilverLight, string strComparisonOp="")
	{
objCodeTypeEN.IsSilverLight = bolIsSilverLight; //是否SilverLight语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSilverLight) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSilverLight, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSilverLight] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsSwift(this clsCodeTypeEN objCodeTypeEN, bool bolIsSwift, string strComparisonOp="")
	{
objCodeTypeEN.IsSwift = bolIsSwift; //是否Swift语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsSwift) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsSwift, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsSwift] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsVB(this clsCodeTypeEN objCodeTypeEN, bool bolIsVB, string strComparisonOp="")
	{
objCodeTypeEN.IsVB = bolIsVB; //IsVB语言
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsVB) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsVB, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsVB] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsTableFldConst(this clsCodeTypeEN objCodeTypeEN, bool bolIsTableFldConst, string strComparisonOp="")
	{
objCodeTypeEN.IsTableFldConst = bolIsTableFldConst; //IsTableFldConst
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsTableFldConst) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsTableFldConst, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsTableFldConst] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsPubApp4WinWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsPubApp4WinWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsPubApp4WinWeb = bolIsPubApp4WinWeb; //IsPubApp4WinWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsPubApp4WinWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsPubApp4WinWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsPubApp4WinWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsWeb(this clsCodeTypeEN objCodeTypeEN, bool bolIsWeb, string strComparisonOp="")
	{
objCodeTypeEN.IsWeb = bolIsWeb; //是否Web应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsAspMvc(this clsCodeTypeEN objCodeTypeEN, bool bolIsAspMvc, string strComparisonOp="")
	{
objCodeTypeEN.IsAspMvc = bolIsAspMvc; //是否AspMvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAspMvc) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAspMvc, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAspMvc] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsWebSrvAccess(this clsCodeTypeEN objCodeTypeEN, bool bolIsWebSrvAccess, string strComparisonOp="")
	{
objCodeTypeEN.IsWebSrvAccess = bolIsWebSrvAccess; //IsWebSrvAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWebSrvAccess) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWebSrvAccess, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWebSrvAccess] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsWin(this clsCodeTypeEN objCodeTypeEN, bool bolIsWin, string strComparisonOp="")
	{
objCodeTypeEN.IsWin = bolIsWin; //是否Win应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsWin) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsWin, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsWin] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsMobileApp(this clsCodeTypeEN objCodeTypeEN, bool bolIsMobileApp, string strComparisonOp="")
	{
objCodeTypeEN.IsMobileApp = bolIsMobileApp; //是否移动终端应用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsMobileApp) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsMobileApp, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsMobileApp] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsExtend(this clsCodeTypeEN objCodeTypeEN, bool bolIsExtend, string strComparisonOp="")
	{
objCodeTypeEN.IsExtend = bolIsExtend; //是否扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsExtend) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsExtend, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsExtend] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetOrderNum(this clsCodeTypeEN objCodeTypeEN, int intOrderNum, string strComparisonOp="")
	{
objCodeTypeEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.OrderNum) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.OrderNum, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.OrderNum] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetWinOrWeb(this clsCodeTypeEN objCodeTypeEN, string strWinOrWeb, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWinOrWeb, 50, conCodeType.WinOrWeb);
}
objCodeTypeEN.WinOrWeb = strWinOrWeb; //WinOrWeb
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.WinOrWeb) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.WinOrWeb, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.WinOrWeb] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsDirByTabName(this clsCodeTypeEN objCodeTypeEN, bool bolIsDirByTabName, string strComparisonOp="")
	{
objCodeTypeEN.IsDirByTabName = bolIsDirByTabName; //是否用表名作为路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDirByTabName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDirByTabName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDirByTabName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsDefaultOverride(this clsCodeTypeEN objCodeTypeEN, bool bolIsDefaultOverride, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultOverride, conCodeType.IsDefaultOverride);
objCodeTypeEN.IsDefaultOverride = bolIsDefaultOverride; //是否默认覆盖
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsDefaultOverride) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsDefaultOverride, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsDefaultOverride] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetInUse(this clsCodeTypeEN objCodeTypeEN, bool bolInUse, string strComparisonOp="")
	{
objCodeTypeEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.InUse) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.InUse, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.InUse] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetIsAutoParseFile(this clsCodeTypeEN objCodeTypeEN, bool bolIsAutoParseFile, string strComparisonOp="")
	{
objCodeTypeEN.IsAutoParseFile = bolIsAutoParseFile; //是否自动分析文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.IsAutoParseFile) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.IsAutoParseFile, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.IsAutoParseFile] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetUpdDate(this clsCodeTypeEN objCodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodeType.UpdDate);
}
objCodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdDate) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdDate, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdDate] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetUpdUser(this clsCodeTypeEN objCodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodeType.UpdUser);
}
objCodeTypeEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.UpdUser) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.UpdUser, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.UpdUser] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetMemo(this clsCodeTypeEN objCodeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodeType.Memo);
}
objCodeTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.Memo) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.Memo, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.Memo] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetSqlDsTypeName(this clsCodeTypeEN objCodeTypeEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, conCodeType.SqlDsTypeName);
}
objCodeTypeEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.SqlDsTypeName) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.SqlDsTypeName, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.SqlDsTypeName] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetFuncCount(this clsCodeTypeEN objCodeTypeEN, int intFuncCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFuncCount, conCodeType.FuncCount);
objCodeTypeEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.FuncCount) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.FuncCount, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.FuncCount] = strComparisonOp;
}
}
return objCodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCodeTypeEN SetAppCount(this clsCodeTypeEN objCodeTypeEN, int intAppCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAppCount, conCodeType.AppCount);
objCodeTypeEN.AppCount = intAppCount; //应用数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeTypeEN.dicFldComparisonOp.ContainsKey(conCodeType.AppCount) == false)
{
objCodeTypeEN.dicFldComparisonOp.Add(conCodeType.AppCount, strComparisonOp);
}
else
{
objCodeTypeEN.dicFldComparisonOp[conCodeType.AppCount] = strComparisonOp;
}
}
return objCodeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCodeTypeEN objCodeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeTypeEN.CheckPropertyNew();
clsCodeTypeEN objCodeType_Cond = new clsCodeTypeEN();
string strCondition = objCodeType_Cond
.SetCodeTypeId(objCodeTypeEN.CodeTypeId, "<>")
.SetCodeTypeName(objCodeTypeEN.CodeTypeName, "=")
.GetCombineCondition();
objCodeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsCodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CodeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCodeTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objCodeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCodeTypeEN objCodeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCodeTypeEN objCodeType_Cond = new clsCodeTypeEN();
string strCondition = objCodeType_Cond
.SetCodeTypeName(objCodeType.CodeTypeName, "=")
.GetCombineCondition();
objCodeType._IsCheckProperty = true;
bool bolIsExist = clsCodeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCodeType.CodeTypeId = clsCodeTypeBL.GetFirstID_S(strCondition);
objCodeType.UpdateWithCondition(strCondition);
}
else
{
objCodeType.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
objCodeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeTypeEN objCodeTypeEN)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySql2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeTypeEN objCodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySql2(objCodeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeTypeEN objCodeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySqlWithCondition(objCodeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeTypeEN objCodeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCodeTypeBL.CodeTypeDA.UpdateBySqlWithConditionTransaction(objCodeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCodeTypeEN objCodeTypeEN)
{
try
{
int intRecNum = clsCodeTypeBL.CodeTypeDA.DelRecord(objCodeTypeEN.CodeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
 public static void CopyTo(this clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
try
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.ClassNameFormatEx = objCodeTypeENS.ClassNameFormatEx; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //排序
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改用户
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //备注
objCodeTypeENT.SqlDsTypeName = objCodeTypeENS.SqlDsTypeName; //Sql数据源名
objCodeTypeENT.FuncCount = objCodeTypeENS.FuncCount; //函数数目
objCodeTypeENT.AppCount = objCodeTypeENS.AppCount; //应用数
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <returns>目标对象=>clsCodeTypeEN:objCodeTypeENT</returns>
 public static clsCodeTypeEN CopyTo(this clsCodeTypeEN objCodeTypeENS)
{
try
{
 clsCodeTypeEN objCodeTypeENT = new clsCodeTypeEN()
{
CodeTypeId = objCodeTypeENS.CodeTypeId, //代码类型Id
CodeTypeName = objCodeTypeENS.CodeTypeName, //代码类型名
CodeTypeSimName = objCodeTypeENS.CodeTypeSimName, //简称
CodeTypeENName = objCodeTypeENS.CodeTypeENName, //代码类型英文名
GroupName = objCodeTypeENS.GroupName, //组名
ProgLangTypeId = objCodeTypeENS.ProgLangTypeId, //编程语言类型Id
RegionTypeId = objCodeTypeENS.RegionTypeId, //区域类型Id
Prefix = objCodeTypeENS.Prefix, //前缀
DependsOn = objCodeTypeENS.DependsOn, //依赖于
FrontOrBack = objCodeTypeENS.FrontOrBack, //前台Or后台
SqlDsTypeId = objCodeTypeENS.SqlDsTypeId, //数据源类型Id
ClassNameFormat = objCodeTypeENS.ClassNameFormat, //类名格式
ClassNameFormatEx = objCodeTypeENS.ClassNameFormatEx, //类名格式
FileNameFormat = objCodeTypeENS.FileNameFormat, //文件名格式
ClassNamePattern = objCodeTypeENS.ClassNamePattern, //类名模式
IsCSharp = objCodeTypeENS.IsCSharp, //是否CSharp语言
IsJava = objCodeTypeENS.IsJava, //是否Java语言
IsJavaScript = objCodeTypeENS.IsJavaScript, //是否JavaScript语言
IsTypeScript = objCodeTypeENS.IsTypeScript, //是否TypeScript语言
IsSilverLight = objCodeTypeENS.IsSilverLight, //是否SilverLight语言
IsSwift = objCodeTypeENS.IsSwift, //是否Swift语言
IsVB = objCodeTypeENS.IsVB, //IsVB语言
IsTableFldConst = objCodeTypeENS.IsTableFldConst, //IsTableFldConst
IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb, //IsPubApp4WinWeb
IsWeb = objCodeTypeENS.IsWeb, //是否Web应用
IsAspMvc = objCodeTypeENS.IsAspMvc, //是否AspMvc
IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess, //IsWebSrvAccess
IsWin = objCodeTypeENS.IsWin, //是否Win应用
IsMobileApp = objCodeTypeENS.IsMobileApp, //是否移动终端应用
IsExtend = objCodeTypeENS.IsExtend, //是否扩展类
OrderNum = objCodeTypeENS.OrderNum, //排序
WinOrWeb = objCodeTypeENS.WinOrWeb, //WinOrWeb
IsDirByTabName = objCodeTypeENS.IsDirByTabName, //是否用表名作为路径
IsDefaultOverride = objCodeTypeENS.IsDefaultOverride, //是否默认覆盖
InUse = objCodeTypeENS.InUse, //是否在用
IsAutoParseFile = objCodeTypeENS.IsAutoParseFile, //是否自动分析文件
UpdDate = objCodeTypeENS.UpdDate, //修改日期
UpdUser = objCodeTypeENS.UpdUser, //修改用户
Memo = objCodeTypeENS.Memo, //备注
SqlDsTypeName = objCodeTypeENS.SqlDsTypeName, //Sql数据源名
FuncCount = objCodeTypeENS.FuncCount, //函数数目
AppCount = objCodeTypeENS.AppCount, //应用数
};
 return objCodeTypeENT;
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
public static void CheckPropertyNew(this clsCodeTypeEN objCodeTypeEN)
{
 clsCodeTypeBL.CodeTypeDA.CheckPropertyNew(objCodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCodeTypeEN objCodeTypeEN)
{
 clsCodeTypeBL.CodeTypeDA.CheckProperty4Condition(objCodeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeTypeEN objCodeType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeType_Cond.IsUpdated(conCodeType.CodeTypeId) == true)
{
string strComparisonOp_CodeTypeId = objCodeType_Cond.dicFldComparisonOp[conCodeType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeId, objCodeType_Cond.CodeTypeId, strComparisonOp_CodeTypeId);
}
if (objCodeType_Cond.IsUpdated(conCodeType.CodeTypeName) == true)
{
string strComparisonOp_CodeTypeName = objCodeType_Cond.dicFldComparisonOp[conCodeType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeName, objCodeType_Cond.CodeTypeName, strComparisonOp_CodeTypeName);
}
if (objCodeType_Cond.IsUpdated(conCodeType.CodeTypeSimName) == true)
{
string strComparisonOp_CodeTypeSimName = objCodeType_Cond.dicFldComparisonOp[conCodeType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeSimName, objCodeType_Cond.CodeTypeSimName, strComparisonOp_CodeTypeSimName);
}
if (objCodeType_Cond.IsUpdated(conCodeType.CodeTypeENName) == true)
{
string strComparisonOp_CodeTypeENName = objCodeType_Cond.dicFldComparisonOp[conCodeType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.CodeTypeENName, objCodeType_Cond.CodeTypeENName, strComparisonOp_CodeTypeENName);
}
if (objCodeType_Cond.IsUpdated(conCodeType.GroupName) == true)
{
string strComparisonOp_GroupName = objCodeType_Cond.dicFldComparisonOp[conCodeType.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.GroupName, objCodeType_Cond.GroupName, strComparisonOp_GroupName);
}
if (objCodeType_Cond.IsUpdated(conCodeType.ProgLangTypeId) == true)
{
string strComparisonOp_ProgLangTypeId = objCodeType_Cond.dicFldComparisonOp[conCodeType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ProgLangTypeId, objCodeType_Cond.ProgLangTypeId, strComparisonOp_ProgLangTypeId);
}
if (objCodeType_Cond.IsUpdated(conCodeType.RegionTypeId) == true)
{
string strComparisonOp_RegionTypeId = objCodeType_Cond.dicFldComparisonOp[conCodeType.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.RegionTypeId, objCodeType_Cond.RegionTypeId, strComparisonOp_RegionTypeId);
}
if (objCodeType_Cond.IsUpdated(conCodeType.Prefix) == true)
{
string strComparisonOp_Prefix = objCodeType_Cond.dicFldComparisonOp[conCodeType.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Prefix, objCodeType_Cond.Prefix, strComparisonOp_Prefix);
}
if (objCodeType_Cond.IsUpdated(conCodeType.DependsOn) == true)
{
string strComparisonOp_DependsOn = objCodeType_Cond.dicFldComparisonOp[conCodeType.DependsOn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.DependsOn, objCodeType_Cond.DependsOn, strComparisonOp_DependsOn);
}
if (objCodeType_Cond.IsUpdated(conCodeType.FrontOrBack) == true)
{
string strComparisonOp_FrontOrBack = objCodeType_Cond.dicFldComparisonOp[conCodeType.FrontOrBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FrontOrBack, objCodeType_Cond.FrontOrBack, strComparisonOp_FrontOrBack);
}
if (objCodeType_Cond.IsUpdated(conCodeType.SqlDsTypeId) == true)
{
string strComparisonOp_SqlDsTypeId = objCodeType_Cond.dicFldComparisonOp[conCodeType.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.SqlDsTypeId, objCodeType_Cond.SqlDsTypeId, strComparisonOp_SqlDsTypeId);
}
if (objCodeType_Cond.IsUpdated(conCodeType.ClassNameFormat) == true)
{
string strComparisonOp_ClassNameFormat = objCodeType_Cond.dicFldComparisonOp[conCodeType.ClassNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNameFormat, objCodeType_Cond.ClassNameFormat, strComparisonOp_ClassNameFormat);
}
if (objCodeType_Cond.IsUpdated(conCodeType.ClassNameFormatEx) == true)
{
string strComparisonOp_ClassNameFormatEx = objCodeType_Cond.dicFldComparisonOp[conCodeType.ClassNameFormatEx];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNameFormatEx, objCodeType_Cond.ClassNameFormatEx, strComparisonOp_ClassNameFormatEx);
}
if (objCodeType_Cond.IsUpdated(conCodeType.FileNameFormat) == true)
{
string strComparisonOp_FileNameFormat = objCodeType_Cond.dicFldComparisonOp[conCodeType.FileNameFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.FileNameFormat, objCodeType_Cond.FileNameFormat, strComparisonOp_FileNameFormat);
}
if (objCodeType_Cond.IsUpdated(conCodeType.ClassNamePattern) == true)
{
string strComparisonOp_ClassNamePattern = objCodeType_Cond.dicFldComparisonOp[conCodeType.ClassNamePattern];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.ClassNamePattern, objCodeType_Cond.ClassNamePattern, strComparisonOp_ClassNamePattern);
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsCSharp) == true)
{
if (objCodeType_Cond.IsCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsCSharp);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsJava) == true)
{
if (objCodeType_Cond.IsJava == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJava);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJava);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsJavaScript) == true)
{
if (objCodeType_Cond.IsJavaScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsJavaScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsJavaScript);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsTypeScript) == true)
{
if (objCodeType_Cond.IsTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTypeScript);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsSilverLight) == true)
{
if (objCodeType_Cond.IsSilverLight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSilverLight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSilverLight);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsSwift) == true)
{
if (objCodeType_Cond.IsSwift == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsSwift);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsSwift);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsVB) == true)
{
if (objCodeType_Cond.IsVB == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsVB);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsVB);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsTableFldConst) == true)
{
if (objCodeType_Cond.IsTableFldConst == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsTableFldConst);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsTableFldConst);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsPubApp4WinWeb) == true)
{
if (objCodeType_Cond.IsPubApp4WinWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsPubApp4WinWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsPubApp4WinWeb);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsWeb) == true)
{
if (objCodeType_Cond.IsWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWeb);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsAspMvc) == true)
{
if (objCodeType_Cond.IsAspMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAspMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAspMvc);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsWebSrvAccess) == true)
{
if (objCodeType_Cond.IsWebSrvAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWebSrvAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWebSrvAccess);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsWin) == true)
{
if (objCodeType_Cond.IsWin == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsWin);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsWin);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsMobileApp) == true)
{
if (objCodeType_Cond.IsMobileApp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsMobileApp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsMobileApp);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsExtend) == true)
{
if (objCodeType_Cond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsExtend);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objCodeType_Cond.dicFldComparisonOp[conCodeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCodeType.OrderNum, objCodeType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objCodeType_Cond.IsUpdated(conCodeType.WinOrWeb) == true)
{
string strComparisonOp_WinOrWeb = objCodeType_Cond.dicFldComparisonOp[conCodeType.WinOrWeb];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.WinOrWeb, objCodeType_Cond.WinOrWeb, strComparisonOp_WinOrWeb);
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsDirByTabName) == true)
{
if (objCodeType_Cond.IsDirByTabName == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDirByTabName);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDirByTabName);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsDefaultOverride) == true)
{
if (objCodeType_Cond.IsDefaultOverride == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsDefaultOverride);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsDefaultOverride);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.InUse) == true)
{
if (objCodeType_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.InUse);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.IsAutoParseFile) == true)
{
if (objCodeType_Cond.IsAutoParseFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCodeType.IsAutoParseFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCodeType.IsAutoParseFile);
}
}
if (objCodeType_Cond.IsUpdated(conCodeType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCodeType_Cond.dicFldComparisonOp[conCodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdDate, objCodeType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCodeType_Cond.IsUpdated(conCodeType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objCodeType_Cond.dicFldComparisonOp[conCodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.UpdUser, objCodeType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objCodeType_Cond.IsUpdated(conCodeType.Memo) == true)
{
string strComparisonOp_Memo = objCodeType_Cond.dicFldComparisonOp[conCodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.Memo, objCodeType_Cond.Memo, strComparisonOp_Memo);
}
if (objCodeType_Cond.IsUpdated(conCodeType.SqlDsTypeName) == true)
{
string strComparisonOp_SqlDsTypeName = objCodeType_Cond.dicFldComparisonOp[conCodeType.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeType.SqlDsTypeName, objCodeType_Cond.SqlDsTypeName, strComparisonOp_SqlDsTypeName);
}
if (objCodeType_Cond.IsUpdated(conCodeType.FuncCount) == true)
{
string strComparisonOp_FuncCount = objCodeType_Cond.dicFldComparisonOp[conCodeType.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCodeType.FuncCount, objCodeType_Cond.FuncCount, strComparisonOp_FuncCount);
}
if (objCodeType_Cond.IsUpdated(conCodeType.AppCount) == true)
{
string strComparisonOp_AppCount = objCodeType_Cond.dicFldComparisonOp[conCodeType.AppCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCodeType.AppCount, objCodeType_Cond.AppCount, strComparisonOp_AppCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckCodeTypeUniqueness(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objCodeTypeEN == null) return true;
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
bolIsUniqueness = clsCodeTypeBL.CodeTypeDA.CheckCodeTypeUniqueness();
}
else
{
bolIsUniqueness = clsCodeTypeBL.CodeTypeDA.CheckCodeTypeUniqueness(objCodeTypeEN.CodeTypeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_CodeTypeName(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCodeTypeEN == null) return true;
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
if (clsCodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", objCodeTypeEN.CodeTypeId);
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
if (clsCodeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_CodeTypeName(this clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCodeTypeEN == null) return "";
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", objCodeTypeEN.CodeTypeId);
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CodeType
{
public virtual bool UpdRelaTabDate(string strCodeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumCodeType
{
}
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCodeTypeBL
{
public static RelatedActions_CodeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCodeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCodeTypeDA CodeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCodeTypeDA();
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
 public clsCodeTypeBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsCodeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeTypeEN._ConnectString);
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
public static DataTable GetDataTable_CodeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CodeTypeDA.GetDataTable_CodeType(strWhereCond);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CodeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CodeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = CodeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CodeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstByCodeTypeIdLst(List<string> arrCodeTypeIdLst)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeTypeIdLst, true);
 string strWhereCond = string.Format("CodeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrCodeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCodeTypeEN> GetObjLstByCodeTypeIdLst_Cache(List<string> arrCodeTypeIdLst)
{
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel =
arrCodeTypeObjLst_Cache
.Where(x => arrCodeTypeIdLst.Contains(x.CodeTypeId));
return arrCodeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLst(string strWhereCond)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objCodeType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCodeTypeEN> GetSubObjLst_Cache(clsCodeTypeEN objCodeType_Cond)
{
List<clsCodeTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCodeTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conCodeType.AttributeName)
{
if (objCodeType_Cond.IsUpdated(strFldName) == false) continue;
if (objCodeType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objCodeType_Cond[strFldName].ToString());
}
else
{
if (objCodeType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objCodeType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
List<clsCodeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCodeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
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
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
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
public static List<clsCodeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCodeTypeEN.CodeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCodeType(ref clsCodeTypeEN objCodeTypeEN)
{
bool bolResult = CodeTypeDA.GetCodeType(ref objCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
if (strCodeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByCodeTypeId(strCodeTypeId);
return objCodeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCodeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetFirstObj(strWhereCond);
 return objCodeTypeEN;
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
public static clsCodeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByDataRow(objRow);
 return objCodeTypeEN;
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
public static clsCodeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCodeTypeEN objCodeTypeEN = CodeTypeDA.GetObjByDataRow(objRow);
 return objCodeTypeEN;
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
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <param name = "lstCodeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeIdFromList(string strCodeTypeId, List<clsCodeTypeEN> lstCodeTypeObjLst)
{
foreach (clsCodeTypeEN objCodeTypeEN in lstCodeTypeObjLst)
{
if (objCodeTypeEN.CodeTypeId == strCodeTypeId)
{
return objCodeTypeEN;
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
 string strMaxCodeTypeId;
 try
 {
 strMaxCodeTypeId = clsCodeTypeDA.GetMaxStrId();
 return strMaxCodeTypeId;
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
 string strCodeTypeId;
 try
 {
 strCodeTypeId = new clsCodeTypeDA().GetFirstID(strWhereCond);
 return strCodeTypeId;
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
 arrList = CodeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = CodeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CodeTypeDA.IsExist(strCodeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCodeTypeId">代码类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCodeTypeId, string strOpUser)
{
clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCodeTypeEN.UpdUser = strOpUser;
return clsCodeTypeBL.UpdateBySql2(objCodeTypeEN);
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
 bolIsExist = clsCodeTypeDA.IsExistTable();
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
 bolIsExist = CodeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCodeTypeEN objCodeTypeEN)
{
if (objCodeTypeEN.CheckUniqueness_CodeTypeName() == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordBySql2)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
bool bolResult = CodeTypeDA.AddNewRecordBySQL2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCodeTypeEN objCodeTypeEN)
{
if (objCodeTypeEN.CheckUniqueness_CodeTypeName() == false)
{
var strMsg = string.Format("记录已经存在!代码类型名 = [{0}]的数据已经存在!(in clsCodeTypeBL.AddNewRecordBySql2WithReturnKey)", objCodeTypeEN.CodeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true || clsCodeTypeBL.IsExist(objCodeTypeEN.CodeTypeId) == true)
 {
     objCodeTypeEN.CodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
 }
string strKey = CodeTypeDA.AddNewRecordBySQL2WithReturnKey(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCodeTypeEN objCodeTypeEN)
{
try
{
bool bolResult = CodeTypeDA.Update(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCodeTypeEN objCodeTypeEN)
{
 if (string.IsNullOrEmpty(objCodeTypeEN.CodeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CodeTypeDA.UpdateBySql2(objCodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeTypeBL.ReFreshCache();

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCodeTypeId)
{
try
{
 clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);

if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(objCodeTypeEN.CodeTypeId, objCodeTypeEN.UpdUser);
}
if (objCodeTypeEN != null)
{
int intRecNum = CodeTypeDA.DelRecord(strCodeTypeId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strCodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCodeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
//删除与表:[CodeType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodeType.CodeTypeId,
//strCodeTypeId);
//        clsCodeTypeBL.DelCodeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeTypeBL.DelRecord(strCodeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strCodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCodeTypeBL.relatedActions != null)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
bool bolResult = CodeTypeDA.DelRecord(strCodeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCodeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCodeTypes(List<string> arrCodeTypeIdLst)
{
if (arrCodeTypeIdLst.Count == 0) return 0;
try
{
if (clsCodeTypeBL.relatedActions != null)
{
foreach (var strCodeTypeId in arrCodeTypeIdLst)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = CodeTypeDA.DelCodeType(arrCodeTypeIdLst);
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
public static int DelCodeTypesByCond(string strWhereCond)
{
try
{
if (clsCodeTypeBL.relatedActions != null)
{
List<string> arrCodeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCodeTypeId in arrCodeTypeId)
{
clsCodeTypeBL.relatedActions.UpdRelaTabDate(strCodeTypeId, "UpdRelaTabDate");
}
}
int intRecNum = CodeTypeDA.DelCodeType(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[CodeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCodeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCodeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
//删除与表:[CodeType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeTypeBL.DelRecord(strCodeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strCodeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
 public static void CopyTo(clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
try
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.ClassNameFormatEx = objCodeTypeENS.ClassNameFormatEx; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //排序
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改用户
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //备注
objCodeTypeENT.SqlDsTypeName = objCodeTypeENS.SqlDsTypeName; //Sql数据源名
objCodeTypeENT.FuncCount = objCodeTypeENS.FuncCount; //函数数目
objCodeTypeENT.AppCount = objCodeTypeENS.AppCount; //应用数
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
 /// <param name = "objCodeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsCodeTypeEN objCodeTypeEN)
{
try
{
objCodeTypeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objCodeTypeEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCodeType.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conCodeType.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(conCodeType.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(conCodeType.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName == "[null]" ? null :  objCodeTypeEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(conCodeType.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.GroupName = objCodeTypeEN.GroupName == "[null]" ? null :  objCodeTypeEN.GroupName; //组名
}
if (arrFldSet.Contains(conCodeType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conCodeType.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conCodeType.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.Prefix = objCodeTypeEN.Prefix == "[null]" ? null :  objCodeTypeEN.Prefix; //前缀
}
if (arrFldSet.Contains(conCodeType.DependsOn, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn == "[null]" ? null :  objCodeTypeEN.DependsOn; //依赖于
}
if (arrFldSet.Contains(conCodeType.FrontOrBack, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack == "[null]" ? null :  objCodeTypeEN.FrontOrBack; //前台Or后台
}
if (arrFldSet.Contains(conCodeType.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(conCodeType.ClassNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat == "[null]" ? null :  objCodeTypeEN.ClassNameFormat; //类名格式
}
if (arrFldSet.Contains(conCodeType.ClassNameFormatEx, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx == "[null]" ? null :  objCodeTypeEN.ClassNameFormatEx; //类名格式
}
if (arrFldSet.Contains(conCodeType.FileNameFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat == "[null]" ? null :  objCodeTypeEN.FileNameFormat; //文件名格式
}
if (arrFldSet.Contains(conCodeType.ClassNamePattern, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern == "[null]" ? null :  objCodeTypeEN.ClassNamePattern; //类名模式
}
if (arrFldSet.Contains(conCodeType.IsCSharp, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsCSharp = objCodeTypeEN.IsCSharp; //是否CSharp语言
}
if (arrFldSet.Contains(conCodeType.IsJava, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsJava = objCodeTypeEN.IsJava; //是否Java语言
}
if (arrFldSet.Contains(conCodeType.IsJavaScript, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsJavaScript = objCodeTypeEN.IsJavaScript; //是否JavaScript语言
}
if (arrFldSet.Contains(conCodeType.IsTypeScript, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsTypeScript = objCodeTypeEN.IsTypeScript; //是否TypeScript语言
}
if (arrFldSet.Contains(conCodeType.IsSilverLight, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsSilverLight = objCodeTypeEN.IsSilverLight; //是否SilverLight语言
}
if (arrFldSet.Contains(conCodeType.IsSwift, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsSwift = objCodeTypeEN.IsSwift; //是否Swift语言
}
if (arrFldSet.Contains(conCodeType.IsVB, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsVB = objCodeTypeEN.IsVB; //IsVB语言
}
if (arrFldSet.Contains(conCodeType.IsTableFldConst, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsTableFldConst = objCodeTypeEN.IsTableFldConst; //IsTableFldConst
}
if (arrFldSet.Contains(conCodeType.IsPubApp4WinWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsPubApp4WinWeb = objCodeTypeEN.IsPubApp4WinWeb; //IsPubApp4WinWeb
}
if (arrFldSet.Contains(conCodeType.IsWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWeb = objCodeTypeEN.IsWeb; //是否Web应用
}
if (arrFldSet.Contains(conCodeType.IsAspMvc, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsAspMvc = objCodeTypeEN.IsAspMvc; //是否AspMvc
}
if (arrFldSet.Contains(conCodeType.IsWebSrvAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWebSrvAccess = objCodeTypeEN.IsWebSrvAccess; //IsWebSrvAccess
}
if (arrFldSet.Contains(conCodeType.IsWin, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsWin = objCodeTypeEN.IsWin; //是否Win应用
}
if (arrFldSet.Contains(conCodeType.IsMobileApp, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsMobileApp = objCodeTypeEN.IsMobileApp; //是否移动终端应用
}
if (arrFldSet.Contains(conCodeType.IsExtend, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsExtend = objCodeTypeEN.IsExtend; //是否扩展类
}
if (arrFldSet.Contains(conCodeType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.OrderNum = objCodeTypeEN.OrderNum; //排序
}
if (arrFldSet.Contains(conCodeType.WinOrWeb, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb == "[null]" ? null :  objCodeTypeEN.WinOrWeb; //WinOrWeb
}
if (arrFldSet.Contains(conCodeType.IsDirByTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsDirByTabName = objCodeTypeEN.IsDirByTabName; //是否用表名作为路径
}
if (arrFldSet.Contains(conCodeType.IsDefaultOverride, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsDefaultOverride = objCodeTypeEN.IsDefaultOverride; //是否默认覆盖
}
if (arrFldSet.Contains(conCodeType.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.InUse = objCodeTypeEN.InUse; //是否在用
}
if (arrFldSet.Contains(conCodeType.IsAutoParseFile, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.IsAutoParseFile = objCodeTypeEN.IsAutoParseFile; //是否自动分析文件
}
if (arrFldSet.Contains(conCodeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate == "[null]" ? null :  objCodeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCodeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser == "[null]" ? null :  objCodeTypeEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(conCodeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.Memo = objCodeTypeEN.Memo == "[null]" ? null :  objCodeTypeEN.Memo; //备注
}
if (arrFldSet.Contains(conCodeType.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName == "[null]" ? null :  objCodeTypeEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(conCodeType.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.FuncCount = objCodeTypeEN.FuncCount; //函数数目
}
if (arrFldSet.Contains(conCodeType.AppCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCodeTypeEN.AppCount = objCodeTypeEN.AppCount; //应用数
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objCodeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsCodeTypeEN objCodeTypeEN)
{
try
{
if (objCodeTypeEN.CodeTypeENName == "[null]") objCodeTypeEN.CodeTypeENName = null; //代码类型英文名
if (objCodeTypeEN.GroupName == "[null]") objCodeTypeEN.GroupName = null; //组名
if (objCodeTypeEN.Prefix == "[null]") objCodeTypeEN.Prefix = null; //前缀
if (objCodeTypeEN.DependsOn == "[null]") objCodeTypeEN.DependsOn = null; //依赖于
if (objCodeTypeEN.FrontOrBack == "[null]") objCodeTypeEN.FrontOrBack = null; //前台Or后台
if (objCodeTypeEN.ClassNameFormat == "[null]") objCodeTypeEN.ClassNameFormat = null; //类名格式
if (objCodeTypeEN.ClassNameFormatEx == "[null]") objCodeTypeEN.ClassNameFormatEx = null; //类名格式
if (objCodeTypeEN.FileNameFormat == "[null]") objCodeTypeEN.FileNameFormat = null; //文件名格式
if (objCodeTypeEN.ClassNamePattern == "[null]") objCodeTypeEN.ClassNamePattern = null; //类名模式
if (objCodeTypeEN.WinOrWeb == "[null]") objCodeTypeEN.WinOrWeb = null; //WinOrWeb
if (objCodeTypeEN.UpdDate == "[null]") objCodeTypeEN.UpdDate = null; //修改日期
if (objCodeTypeEN.UpdUser == "[null]") objCodeTypeEN.UpdUser = null; //修改用户
if (objCodeTypeEN.Memo == "[null]") objCodeTypeEN.Memo = null; //备注
if (objCodeTypeEN.SqlDsTypeName == "[null]") objCodeTypeEN.SqlDsTypeName = null; //Sql数据源名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsCodeTypeEN objCodeTypeEN)
{
 CodeTypeDA.CheckPropertyNew(objCodeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCodeTypeEN objCodeTypeEN)
{
 CodeTypeDA.CheckProperty4Condition(objCodeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CodeTypeId_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码类型]...","0");
List<clsCodeTypeEN> arrCodeTypeObjLst = GetAllCodeTypeObjLst_Cache(); 
objDDL.DataValueField = conCodeType.CodeTypeId;
objDDL.DataTextField = conCodeType.CodeTypeName;
objDDL.DataSource = arrCodeTypeObjLst;
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTypeId");
//if (arrCodeTypeObjLst_Cache == null)
//{
//arrCodeTypeObjLst_Cache = CodeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeTypeEN GetObjByCodeTypeId_Cache(string strCodeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel =
arrCodeTypeObjLst_Cache
.Where(x=> x.CodeTypeId == strCodeTypeId 
);
if (arrCodeTypeObjLst_Sel.Count() == 0)
{
   clsCodeTypeEN obj = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCodeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeTypeNameByCodeTypeId_Cache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsCodeTypeEN objCodeType = GetObjByCodeTypeId_Cache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType.CodeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strCodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeTypeId_Cache(string strCodeTypeId)
{
if (string.IsNullOrEmpty(strCodeTypeId) == true) return "";
//获取缓存中的对象列表
clsCodeTypeEN objCodeType = GetObjByCodeTypeId_Cache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType.CodeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeTypeEN> GetAllCodeTypeObjLst_Cache()
{
//获取缓存中的对象列表
List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = GetObjLst_Cache(); 
return arrCodeTypeObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCodeTypeObjLst_Cache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集，根据:SqlDsTypeId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCodeTypeObjLst">需要排序的对象列表</param>
public static List <clsCodeTypeEN> GetSubSet4CodeTypeObjLstBySqlDsTypeId_Cache(string strSqlDsTypeId)
{
   if (string.IsNullOrEmpty(strSqlDsTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
List<clsCodeTypeEN> arrCodeTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCodeTypeEN> arrCodeTypeObjLst_Sel1 =
from objCodeTypeEN in arrCodeTypeObjLst_Cache
where objCodeTypeEN.SqlDsTypeId == strSqlDsTypeId
select objCodeTypeEN;
List <clsCodeTypeEN> arrCodeTypeObjLst_Sel = new List<clsCodeTypeEN>();
foreach (clsCodeTypeEN obj in arrCodeTypeObjLst_Sel1)
{
arrCodeTypeObjLst_Sel.Add(obj);
}
return arrCodeTypeObjLst_Sel;
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
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
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
if (clsCodeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCodeTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCodeTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckCodeTypeUniqueness(clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objCodeTypeEN == null) return true;
if (objCodeTypeEN.CodeTypeId == null || objCodeTypeEN.CodeTypeId == "")
{
bolIsUniqueness = CodeTypeDA.CheckCodeTypeUniqueness();
}
else
{
bolIsUniqueness = CodeTypeDA.CheckCodeTypeUniqueness(objCodeTypeEN.CodeTypeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CodeType(代码类型)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_CodeTypeName(clsCodeTypeEN objCodeTypeEN)
{
//检测记录是否存在
string strResult = CodeTypeDA.GetUniCondStr_CodeTypeName(objCodeTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCodeTypeId)
{
if (strInFldName != conCodeType.CodeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCodeType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCodeType.AttributeName));
throw new Exception(strMsg);
}
var objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(strCodeTypeId);
if (objCodeType == null) return "";
return objCodeType[strOutFldName].ToString();
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
int intRecCount = clsCodeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsCodeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCodeTypeDA.GetRecCount();
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
int intRecCount = clsCodeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objCodeType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsCodeTypeEN objCodeType_Cond)
{
List<clsCodeTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCodeTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conCodeType.AttributeName)
{
if (objCodeType_Cond.IsUpdated(strFldName) == false) continue;
if (objCodeType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objCodeType_Cond[strFldName].ToString());
}
else
{
if (objCodeType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCodeType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objCodeType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objCodeType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCodeType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCodeType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCodeType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsCodeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CodeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CodeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CodeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(clsCodeTypeEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
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
int intRecCount = CodeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCodeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CodeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) primary key, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) not Null, "); 
 // /**简称*/ 
 strCreateTabCode.Append(" CodeTypeSimName varchar(50) not Null, "); 
 // /**代码类型英文名*/ 
 strCreateTabCode.Append(" CodeTypeENName varchar(50) Null, "); 
 // /**组名*/ 
 strCreateTabCode.Append(" GroupName varchar(30) Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) not Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) not Null, "); 
 // /**前缀*/ 
 strCreateTabCode.Append(" Prefix varchar(10) Null, "); 
 // /**依赖于*/ 
 strCreateTabCode.Append(" DependsOn varchar(50) Null, "); 
 // /**前台Or后台*/ 
 strCreateTabCode.Append(" FrontOrBack varchar(50) Null, "); 
 // /**数据源类型Id*/ 
 strCreateTabCode.Append(" SqlDsTypeId char(2) not Null, "); 
 // /**类名格式*/ 
 strCreateTabCode.Append(" ClassNameFormat varchar(50) Null, "); 
 // /**类名格式*/ 
 strCreateTabCode.Append(" ClassNameFormatEx varchar(50) Null, "); 
 // /**文件名格式*/ 
 strCreateTabCode.Append(" FileNameFormat varchar(50) Null, "); 
 // /**类名模式*/ 
 strCreateTabCode.Append(" ClassNamePattern varchar(50) Null, "); 
 // /**是否CSharp语言*/ 
 strCreateTabCode.Append(" IsCSharp bit Null, "); 
 // /**是否Java语言*/ 
 strCreateTabCode.Append(" IsJava bit Null, "); 
 // /**是否JavaScript语言*/ 
 strCreateTabCode.Append(" IsJavaScript bit Null, "); 
 // /**是否TypeScript语言*/ 
 strCreateTabCode.Append(" IsTypeScript bit Null, "); 
 // /**是否SilverLight语言*/ 
 strCreateTabCode.Append(" IsSilverLight bit Null, "); 
 // /**是否Swift语言*/ 
 strCreateTabCode.Append(" IsSwift bit Null, "); 
 // /**IsVB语言*/ 
 strCreateTabCode.Append(" IsVB bit Null, "); 
 // /**IsTableFldConst*/ 
 strCreateTabCode.Append(" IsTableFldConst bit Null, "); 
 // /**IsPubApp4WinWeb*/ 
 strCreateTabCode.Append(" IsPubApp4WinWeb bit Null, "); 
 // /**是否Web应用*/ 
 strCreateTabCode.Append(" IsWeb bit Null, "); 
 // /**是否AspMvc*/ 
 strCreateTabCode.Append(" IsAspMvc bit Null, "); 
 // /**IsWebSrvAccess*/ 
 strCreateTabCode.Append(" IsWebSrvAccess bit Null, "); 
 // /**是否Win应用*/ 
 strCreateTabCode.Append(" IsWin bit Null, "); 
 // /**是否移动终端应用*/ 
 strCreateTabCode.Append(" IsMobileApp bit Null, "); 
 // /**是否扩展类*/ 
 strCreateTabCode.Append(" IsExtend bit Null, "); 
 // /**排序*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**WinOrWeb*/ 
 strCreateTabCode.Append(" WinOrWeb varchar(50) Null, "); 
 // /**是否用表名作为路径*/ 
 strCreateTabCode.Append(" IsDirByTabName bit Null, "); 
 // /**是否默认覆盖*/ 
 strCreateTabCode.Append(" IsDefaultOverride bit not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否自动分析文件*/ 
 strCreateTabCode.Append(" IsAutoParseFile bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**Sql数据源名*/ 
 strCreateTabCode.Append(" SqlDsTypeName varchar(20) Null, "); 
 // /**函数数目*/ 
 strCreateTabCode.Append(" FuncCount int not Null, "); 
 // /**应用数*/ 
 strCreateTabCode.Append(" AppCount int not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 代码类型(CodeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4CodeType : clsCommFun4BL
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
clsCodeTypeBL.ReFreshThisCache();
}
}

}