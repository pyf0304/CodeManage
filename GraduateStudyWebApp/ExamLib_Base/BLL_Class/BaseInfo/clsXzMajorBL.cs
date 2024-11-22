
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorBL
 表名:XzMajor(01120065)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsXzMajorBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorEN GetObj(this K_IdXzMajor_XzMajor myKey)
{
clsXzMajorEN objXzMajorEN = clsXzMajorBL.XzMajorDA.GetObjByIdXzMajor(myKey.Value);
return objXzMajorEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecord)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
bool bolResult = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
public static bool AddRecordEx(this clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objXzMajorEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objXzMajorEN.CheckUniqueness() == false)
{
strMsg = string.Format("(专业流水号(IdXzMajor)=[{0}])已经存在,不能重复!", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objXzMajorEN.AddNewRecord();
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecordWithMaxId)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
string strIdXzMajor = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
     objXzMajorEN.IdXzMajor = strIdXzMajor;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
}
return strIdXzMajor;
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
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecord(SqlTransaction))", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2(objXzMajorEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000086)添加记录出错!(带事务处理), {1}.({0})",
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecordWithReturnKey)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
string strKey = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecordWithReturnKey)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
string strKey = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000092)带返回值的添加记录出错!(带事务处理), {1}.(from {0})",
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
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIdXzMajor(this clsXzMajorEN objXzMajorEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conXzMajor.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conXzMajor.IdXzMajor);
}
objXzMajorEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IdXzMajor) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IdXzMajor, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IdXzMajor] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorId(this clsXzMajorEN objXzMajorEN, string strMajorId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorId, conXzMajor.MajorId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorId, 4, conXzMajor.MajorId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorId, 4, conXzMajor.MajorId);
}
objXzMajorEN.MajorId = strMajorId; //专业Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorId) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorId, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorId] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorName(this clsXzMajorEN objXzMajorEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, conXzMajor.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, conXzMajor.MajorName);
}
objXzMajorEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorName) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorName, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorName] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorEnglishName(this clsXzMajorEN objXzMajorEN, string strMajorEnglishName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorEnglishName, 200, conXzMajor.MajorEnglishName);
}
objXzMajorEN.MajorEnglishName = strMajorEnglishName; //专业英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorEnglishName) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorEnglishName, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorEnglishName] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorExplain(this clsXzMajorEN objXzMajorEN, string strMajorExplain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorExplain, 2000, conXzMajor.MajorExplain);
}
objXzMajorEN.MajorExplain = strMajorExplain; //专业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorExplain) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorExplain, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorExplain] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorNationalID(this clsXzMajorEN objXzMajorEN, string strMajorNationalID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorNationalID, 10, conXzMajor.MajorNationalID);
}
objXzMajorEN.MajorNationalID = strMajorNationalID; //专业国家代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorNationalID) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorNationalID, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorNationalID] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIdXzCollege(this clsXzMajorEN objXzMajorEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, conXzMajor.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conXzMajor.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conXzMajor.IdXzCollege);
}
objXzMajorEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IdXzCollege) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IdXzCollege, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IdXzCollege] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIdMajorType(this clsXzMajorEN objXzMajorEN, string strIdMajorType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMajorType, 4, conXzMajor.IdMajorType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMajorType, 4, conXzMajor.IdMajorType);
}
objXzMajorEN.IdMajorType = strIdMajorType; //专业类型(文理工)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IdMajorType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IdMajorType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IdMajorType] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIdDegreeType(this clsXzMajorEN objXzMajorEN, string strIdDegreeType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDegreeType, 4, conXzMajor.IdDegreeType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDegreeType, 4, conXzMajor.IdDegreeType);
}
objXzMajorEN.IdDegreeType = strIdDegreeType; //学位类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IdDegreeType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IdDegreeType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IdDegreeType] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIsMainMajor(this clsXzMajorEN objXzMajorEN, bool bolIsMainMajor, string strComparisonOp="")
	{
objXzMajorEN.IsMainMajor = bolIsMainMajor; //是否重要专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsMainMajor) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsMainMajor, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsMainMajor] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMajorDirection(this clsXzMajorEN objXzMajorEN, string strMajorDirection, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirection, 30, conXzMajor.MajorDirection);
}
objXzMajorEN.MajorDirection = strMajorDirection; //专业方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorDirection) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorDirection, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorDirection] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIsVisible(this clsXzMajorEN objXzMajorEN, bool bolIsVisible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisible, conXzMajor.IsVisible);
objXzMajorEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsVisible) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsVisible, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsVisible] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIsNormal(this clsXzMajorEN objXzMajorEN, bool bolIsNormal, string strComparisonOp="")
	{
objXzMajorEN.IsNormal = bolIsNormal; //IsNormal
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsNormal) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsNormal, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsNormal] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetModifyDate(this clsXzMajorEN objXzMajorEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzMajor.ModifyDate);
}
objXzMajorEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.ModifyDate) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.ModifyDate, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.ModifyDate] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetModifyUserId(this clsXzMajorEN objXzMajorEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzMajor.ModifyUserId);
}
objXzMajorEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.ModifyUserId) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.ModifyUserId, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.ModifyUserId] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetMemo(this clsXzMajorEN objXzMajorEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzMajor.Memo);
}
objXzMajorEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.Memo) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.Memo, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.Memo] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorEN SetIdXzMajorShoolType(this clsXzMajorEN objXzMajorEN, string strIdXzMajorShoolType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajorShoolType, 4, conXzMajor.IdXzMajorShoolType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajorShoolType, 4, conXzMajor.IdXzMajorShoolType);
}
objXzMajorEN.IdXzMajorShoolType = strIdXzMajorShoolType; //专业学校类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IdXzMajorShoolType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IdXzMajorShoolType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IdXzMajorShoolType] = strComparisonOp;
}
}
return objXzMajorEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzMajorEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzMajorEN objXzMajorEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzMajorEN.CheckPropertyNew();
clsXzMajorEN objXzMajorCond = new clsXzMajorEN();
string strCondition = objXzMajorCond
.SetIdXzMajor(objXzMajorEN.IdXzMajor, "<>")
.SetIdXzMajor(objXzMajorEN.IdXzMajor, "=")
.GetCombineCondition();
objXzMajorEN._IsCheckProperty = true;
bool bolIsExist = clsXzMajorBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_XzMajor)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzMajorEN.Update();
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
 /// <param name = "objXzMajor">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsXzMajorEN objXzMajor)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsXzMajorEN objXzMajorCond = new clsXzMajorEN();
string strCondition = objXzMajorCond
.SetIdXzMajor(objXzMajor.IdXzMajor, "=")
.GetCombineCondition();
objXzMajor._IsCheckProperty = true;
bool bolIsExist = clsXzMajorBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objXzMajor.IdXzMajor = clsXzMajorBL.GetFirstID_S(strCondition);
objXzMajor.UpdateWithCondition(strCondition);
}
else
{
objXzMajor.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
objXzMajor.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorEN objXzMajorEN)
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySql2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateBySql2WithTransaction_S)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySql2(objXzMajorEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000035)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySql2(objXzMajorEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorEN objXzMajorEN, string strWhereCond)
{
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySqlWithCondition(objXzMajorEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorEN objXzMajorEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySqlWithConditionTransaction(objXzMajorEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzMajorEN objXzMajorEN)
{
try
{
int intRecNum = clsXzMajorBL.XzMajorDA.DelRecord(objXzMajorEN.IdXzMajor);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
 public static void CopyTo(this clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
try
{
objXzMajorENT.IdXzMajor = objXzMajorENS.IdXzMajor; //专业流水号
objXzMajorENT.MajorId = objXzMajorENS.MajorId; //专业Id
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.MajorEnglishName = objXzMajorENS.MajorEnglishName; //专业英文名称
objXzMajorENT.MajorExplain = objXzMajorENS.MajorExplain; //专业说明
objXzMajorENT.MajorNationalID = objXzMajorENS.MajorNationalID; //专业国家代码
objXzMajorENT.IdXzCollege = objXzMajorENS.IdXzCollege; //学院流水号
objXzMajorENT.IdMajorType = objXzMajorENS.IdMajorType; //专业类型(文理工)流水号
objXzMajorENT.IdDegreeType = objXzMajorENS.IdDegreeType; //学位类型流水号
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.MajorDirection = objXzMajorENS.MajorDirection; //专业方向
objXzMajorENT.IsVisible = objXzMajorENS.IsVisible; //是否显示
objXzMajorENT.IsNormal = objXzMajorENS.IsNormal; //IsNormal
objXzMajorENT.ModifyDate = objXzMajorENS.ModifyDate; //修改日期
objXzMajorENT.ModifyUserId = objXzMajorENS.ModifyUserId; //修改人
objXzMajorENT.Memo = objXzMajorENS.Memo; //备注
objXzMajorENT.IdXzMajorShoolType = objXzMajorENS.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <returns>目标对象=>clsXzMajorEN:objXzMajorENT</returns>
 public static clsXzMajorEN CopyTo(this clsXzMajorEN objXzMajorENS)
{
try
{
 clsXzMajorEN objXzMajorENT = new clsXzMajorEN()
{
IdXzMajor = objXzMajorENS.IdXzMajor, //专业流水号
MajorId = objXzMajorENS.MajorId, //专业Id
MajorName = objXzMajorENS.MajorName, //专业名称
MajorEnglishName = objXzMajorENS.MajorEnglishName, //专业英文名称
MajorExplain = objXzMajorENS.MajorExplain, //专业说明
MajorNationalID = objXzMajorENS.MajorNationalID, //专业国家代码
IdXzCollege = objXzMajorENS.IdXzCollege, //学院流水号
IdMajorType = objXzMajorENS.IdMajorType, //专业类型(文理工)流水号
IdDegreeType = objXzMajorENS.IdDegreeType, //学位类型流水号
IsMainMajor = objXzMajorENS.IsMainMajor, //是否重要专业
MajorDirection = objXzMajorENS.MajorDirection, //专业方向
IsVisible = objXzMajorENS.IsVisible, //是否显示
IsNormal = objXzMajorENS.IsNormal, //IsNormal
ModifyDate = objXzMajorENS.ModifyDate, //修改日期
ModifyUserId = objXzMajorENS.ModifyUserId, //修改人
Memo = objXzMajorENS.Memo, //备注
IdXzMajorShoolType = objXzMajorENS.IdXzMajorShoolType, //专业学校类型流水号
};
 return objXzMajorENT;
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
public static void CheckPropertyNew(this clsXzMajorEN objXzMajorEN)
{
 clsXzMajorBL.XzMajorDA.CheckPropertyNew(objXzMajorEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzMajorEN objXzMajorEN)
{
 clsXzMajorBL.XzMajorDA.CheckProperty4Condition(objXzMajorEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzMajorEN objXzMajorCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzMajorCond.IsUpdated(conXzMajor.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objXzMajorCond.dicFldComparisonOp[conXzMajor.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.IdXzMajor, objXzMajorCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorId) == true)
{
string strComparisonOpMajorId = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorId, objXzMajorCond.MajorId, strComparisonOpMajorId);
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorName) == true)
{
string strComparisonOpMajorName = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorName, objXzMajorCond.MajorName, strComparisonOpMajorName);
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorEnglishName) == true)
{
string strComparisonOpMajorEnglishName = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorEnglishName, objXzMajorCond.MajorEnglishName, strComparisonOpMajorEnglishName);
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorExplain) == true)
{
string strComparisonOpMajorExplain = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorExplain, objXzMajorCond.MajorExplain, strComparisonOpMajorExplain);
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorNationalID) == true)
{
string strComparisonOpMajorNationalID = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorNationalID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorNationalID, objXzMajorCond.MajorNationalID, strComparisonOpMajorNationalID);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objXzMajorCond.dicFldComparisonOp[conXzMajor.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.IdXzCollege, objXzMajorCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IdMajorType) == true)
{
string strComparisonOpIdMajorType = objXzMajorCond.dicFldComparisonOp[conXzMajor.IdMajorType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.IdMajorType, objXzMajorCond.IdMajorType, strComparisonOpIdMajorType);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IdDegreeType) == true)
{
string strComparisonOpIdDegreeType = objXzMajorCond.dicFldComparisonOp[conXzMajor.IdDegreeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.IdDegreeType, objXzMajorCond.IdDegreeType, strComparisonOpIdDegreeType);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IsMainMajor) == true)
{
if (objXzMajorCond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsMainMajor);
}
}
if (objXzMajorCond.IsUpdated(conXzMajor.MajorDirection) == true)
{
string strComparisonOpMajorDirection = objXzMajorCond.dicFldComparisonOp[conXzMajor.MajorDirection];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorDirection, objXzMajorCond.MajorDirection, strComparisonOpMajorDirection);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IsVisible) == true)
{
if (objXzMajorCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsVisible);
}
}
if (objXzMajorCond.IsUpdated(conXzMajor.IsNormal) == true)
{
if (objXzMajorCond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsNormal);
}
}
if (objXzMajorCond.IsUpdated(conXzMajor.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzMajorCond.dicFldComparisonOp[conXzMajor.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.ModifyDate, objXzMajorCond.ModifyDate, strComparisonOpModifyDate);
}
if (objXzMajorCond.IsUpdated(conXzMajor.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzMajorCond.dicFldComparisonOp[conXzMajor.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.ModifyUserId, objXzMajorCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzMajorCond.IsUpdated(conXzMajor.Memo) == true)
{
string strComparisonOpMemo = objXzMajorCond.dicFldComparisonOp[conXzMajor.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.Memo, objXzMajorCond.Memo, strComparisonOpMemo);
}
if (objXzMajorCond.IsUpdated(conXzMajor.IdXzMajorShoolType) == true)
{
string strComparisonOpIdXzMajorShoolType = objXzMajorCond.dicFldComparisonOp[conXzMajor.IdXzMajorShoolType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.IdXzMajorShoolType, objXzMajorCond.IdXzMajorShoolType, strComparisonOpIdXzMajorShoolType);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_XzMajor
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorEN == null) return true;
if (objXzMajorEN.IdXzMajor == null || objXzMajorEN.IdXzMajor == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorEN.IdXzMajor);
if (clsXzMajorBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdXzMajor !=  '{0}'", objXzMajorEN.IdXzMajor);
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorEN.IdXzMajor);
if (clsXzMajorBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--XzMajor(专业), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_XzMajor
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorEN == null) return "";
if (objXzMajorEN.IdXzMajor == null || objXzMajorEN.IdXzMajor == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorEN.IdXzMajor);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdXzMajor !=  '{0}'", objXzMajorEN.IdXzMajor);
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorEN.IdXzMajor);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzMajor
{
public virtual bool UpdRelaTabDate(string strIdXzMajor, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzMajorBL
{
public static RelatedActions_XzMajor relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzMajorDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzMajorDA XzMajorDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzMajorDA();
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
 public clsXzMajorBL()
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
if (string.IsNullOrEmpty(clsXzMajorEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzMajorEN._ConnectString);
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
public static DataTable GetDataTable_XzMajor(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzMajorDA.GetDataTable_XzMajor(strWhereCond);
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
objDT = XzMajorDA.GetDataTable(strWhereCond);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzMajorDA.GetDataTable_Top(objTopPara);
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
objDT = XzMajorDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdXzMajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzMajorEN> GetObjLstByIdXzMajorLst(List<string> arrIdXzMajorLst)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdXzMajorLst, true);
 string strWhereCond = string.Format("IdXzMajor in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdXzMajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzMajorEN> GetObjLstByIdXzMajorLstCache(List<string> arrIdXzMajorLst)
{
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName);
List<clsXzMajorEN> arrXzMajorObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
arrXzMajorObjLstCache
.Where(x => arrIdXzMajorLst.Contains(x.IdXzMajor));
return arrXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLst(string strWhereCond)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzMajorCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzMajorEN> GetSubObjLstCache(clsXzMajorEN objXzMajorCond)
{
List<clsXzMajorEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzMajor.AttributeName)
{
if (objXzMajorCond.IsUpdated(strFldName) == false) continue;
if (objXzMajorCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorCond[strFldName].ToString());
}
else
{
if (objXzMajorCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajorCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajorCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajorCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajorCond[strFldName]));
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
public static List<clsXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
List<clsXzMajorEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzMajorEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
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
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.IdXzMajor = objRow[conXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorEN.MajorId = objRow[conXzMajor.MajorId].ToString().Trim(); //专业Id
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.MajorEnglishName = objRow[conXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[conXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objXzMajorEN.MajorExplain = objRow[conXzMajor.MajorExplain] == DBNull.Value ? null : objRow[conXzMajor.MajorExplain].ToString().Trim(); //专业说明
objXzMajorEN.MajorNationalID = objRow[conXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[conXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objXzMajorEN.IdXzCollege = objRow[conXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objXzMajorEN.IdMajorType = objRow[conXzMajor.IdMajorType] == DBNull.Value ? null : objRow[conXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objXzMajorEN.IdDegreeType = objRow[conXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[conXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.MajorDirection = objRow[conXzMajor.MajorDirection] == DBNull.Value ? null : objRow[conXzMajor.MajorDirection].ToString().Trim(); //专业方向
objXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsVisible].ToString().Trim()); //是否显示
objXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsNormal].ToString().Trim()); //IsNormal
objXzMajorEN.ModifyDate = objRow[conXzMajor.ModifyDate] == DBNull.Value ? null : objRow[conXzMajor.ModifyDate].ToString().Trim(); //修改日期
objXzMajorEN.ModifyUserId = objRow[conXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[conXzMajor.ModifyUserId].ToString().Trim(); //修改人
objXzMajorEN.Memo = objRow[conXzMajor.Memo] == DBNull.Value ? null : objRow[conXzMajor.Memo].ToString().Trim(); //备注
objXzMajorEN.IdXzMajorShoolType = objRow[conXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[conXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzMajorEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzMajor(ref clsXzMajorEN objXzMajorEN)
{
bool bolResult = XzMajorDA.GetXzMajor(ref objXzMajorEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorEN GetObjByIdXzMajor(string strIdXzMajor)
{
if (strIdXzMajor.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdXzMajor]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdXzMajor) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdXzMajor]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByIdXzMajor(strIdXzMajor);
return objXzMajorEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzMajorEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetFirstObj(strWhereCond);
 return objXzMajorEN;
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
public static clsXzMajorEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByDataRow(objRow);
 return objXzMajorEN;
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
public static clsXzMajorEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByDataRow(objRow);
 return objXzMajorEN;
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
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <param name = "lstXzMajorObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorEN GetObjByIdXzMajorFromList(string strIdXzMajor, List<clsXzMajorEN> lstXzMajorObjLst)
{
foreach (clsXzMajorEN objXzMajorEN in lstXzMajorObjLst)
{
if (objXzMajorEN.IdXzMajor == strIdXzMajor)
{
return objXzMajorEN;
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
 string strMaxIdXzMajor;
 try
 {
 strMaxIdXzMajor = clsXzMajorDA.GetMaxStrId();
 return strMaxIdXzMajor;
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
 string strIdXzMajor;
 try
 {
 strIdXzMajor = new clsXzMajorDA().GetFirstID(strWhereCond);
 return strIdXzMajor;
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
 arrList = XzMajorDA.GetID(strWhereCond);
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
bool bolIsExist = XzMajorDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdXzMajor]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzMajorDA.IsExist(strIdXzMajor);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdXzMajor">专业流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdXzMajor, string strOpUser)
{
clsXzMajorEN objXzMajorEN = clsXzMajorBL.GetObjByIdXzMajor(strIdXzMajor);
objXzMajorEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
objXzMajorEN.ModifyUserId = strOpUser;
return clsXzMajorBL.UpdateBySql2(objXzMajorEN);
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
 bolIsExist = clsXzMajorDA.IsExistTable();
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
 bolIsExist = XzMajorDA.IsExistTable(strTabName);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzMajorEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecordBySql2)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
bool bolResult = XzMajorDA.AddNewRecordBySQL2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzMajorEN objXzMajorEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzMajorEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}]的数据已经存在!(in clsXzMajorBL.AddNewRecordBySql2WithReturnKey)", objXzMajorEN.IdXzMajor);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true || clsXzMajorBL.IsExist(objXzMajorEN.IdXzMajor) == true)
 {
     objXzMajorEN.IdXzMajor = clsXzMajorBL.GetMaxStrId_S();
 }
string strKey = XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzMajorEN objXzMajorEN)
{
try
{
bool bolResult = XzMajorDA.Update(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzMajorEN objXzMajorEN)
{
 if (string.IsNullOrEmpty(objXzMajorEN.IdXzMajor) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzMajorDA.UpdateBySql2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
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
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdXzMajor)
{
try
{
 clsXzMajorEN objXzMajorEN = clsXzMajorBL.GetObjByIdXzMajor(strIdXzMajor);

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.IdXzMajor, objXzMajorEN.ModifyUserId);
}
if (objXzMajorEN != null)
{
int intRecNum = XzMajorDA.DelRecord(strIdXzMajor);
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
/// <param name="strIdXzMajor">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdXzMajor )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDA.GetSpecSQLObj();
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
//删除与表:[XzMajor]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzMajor.IdXzMajor,
//strIdXzMajor);
//        clsXzMajorBL.DelXzMajorsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorBL.DelRecord(strIdXzMajor, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdXzMajor, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdXzMajor, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strIdXzMajor, "UpdRelaTabDate");
}
bool bolResult = XzMajorDA.DelRecord(strIdXzMajor,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdXzMajorLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzMajors(List<string> arrIdXzMajorLst)
{
if (arrIdXzMajorLst.Count == 0) return 0;
try
{
if (clsXzMajorBL.relatedActions != null)
{
foreach (var strIdXzMajor in arrIdXzMajorLst)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strIdXzMajor, "UpdRelaTabDate");
}
}
int intDelRecNum = XzMajorDA.DelXzMajor(arrIdXzMajorLst);
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
public static int DelXzMajorsByCond(string strWhereCond)
{
try
{
if (clsXzMajorBL.relatedActions != null)
{
List<string> arrIdXzMajor = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdXzMajor in arrIdXzMajor)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strIdXzMajor, "UpdRelaTabDate");
}
}
int intRecNum = XzMajorDA.DelXzMajor(strWhereCond);
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
 /// 功能:删除满足条件的多条记录.(带事务处理)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCondWithTransaction)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public static bool DelXzMajorsByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzMajorBL.relatedActions != null)
{
List<string> arrIdXzMajor = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdXzMajor in arrIdXzMajor)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strIdXzMajor, "UpdRelaTabDate");
}
}
bool bolResult = XzMajorDA.DelXzMajorWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000044)删除带条件表记录出错!(同时处理事务)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzMajor]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdXzMajor">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdXzMajor)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDA.GetSpecSQLObj();
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
//删除与表:[XzMajor]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorBL.DelRecord(strIdXzMajor, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdXzMajor, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
 public static void CopyTo(clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
try
{
objXzMajorENT.IdXzMajor = objXzMajorENS.IdXzMajor; //专业流水号
objXzMajorENT.MajorId = objXzMajorENS.MajorId; //专业Id
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.MajorEnglishName = objXzMajorENS.MajorEnglishName; //专业英文名称
objXzMajorENT.MajorExplain = objXzMajorENS.MajorExplain; //专业说明
objXzMajorENT.MajorNationalID = objXzMajorENS.MajorNationalID; //专业国家代码
objXzMajorENT.IdXzCollege = objXzMajorENS.IdXzCollege; //学院流水号
objXzMajorENT.IdMajorType = objXzMajorENS.IdMajorType; //专业类型(文理工)流水号
objXzMajorENT.IdDegreeType = objXzMajorENS.IdDegreeType; //学位类型流水号
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.MajorDirection = objXzMajorENS.MajorDirection; //专业方向
objXzMajorENT.IsVisible = objXzMajorENS.IsVisible; //是否显示
objXzMajorENT.IsNormal = objXzMajorENS.IsNormal; //IsNormal
objXzMajorENT.ModifyDate = objXzMajorENS.ModifyDate; //修改日期
objXzMajorENT.ModifyUserId = objXzMajorENS.ModifyUserId; //修改人
objXzMajorENT.Memo = objXzMajorENS.Memo; //备注
objXzMajorENT.IdXzMajorShoolType = objXzMajorENS.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objXzMajorEN">源简化对象</param>
 public static void SetUpdFlag(clsXzMajorEN objXzMajorEN)
{
try
{
objXzMajorEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzMajorEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzMajor.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IdXzMajor = objXzMajorEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conXzMajor.MajorId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorId = objXzMajorEN.MajorId; //专业Id
}
if (arrFldSet.Contains(conXzMajor.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorName = objXzMajorEN.MajorName; //专业名称
}
if (arrFldSet.Contains(conXzMajor.MajorEnglishName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorEnglishName = objXzMajorEN.MajorEnglishName == "[null]" ? null :  objXzMajorEN.MajorEnglishName; //专业英文名称
}
if (arrFldSet.Contains(conXzMajor.MajorExplain, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorExplain = objXzMajorEN.MajorExplain == "[null]" ? null :  objXzMajorEN.MajorExplain; //专业说明
}
if (arrFldSet.Contains(conXzMajor.MajorNationalID, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorNationalID = objXzMajorEN.MajorNationalID == "[null]" ? null :  objXzMajorEN.MajorNationalID; //专业国家代码
}
if (arrFldSet.Contains(conXzMajor.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IdXzCollege = objXzMajorEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conXzMajor.IdMajorType, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IdMajorType = objXzMajorEN.IdMajorType == "[null]" ? null :  objXzMajorEN.IdMajorType; //专业类型(文理工)流水号
}
if (arrFldSet.Contains(conXzMajor.IdDegreeType, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IdDegreeType = objXzMajorEN.IdDegreeType == "[null]" ? null :  objXzMajorEN.IdDegreeType; //学位类型流水号
}
if (arrFldSet.Contains(conXzMajor.IsMainMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IsMainMajor = objXzMajorEN.IsMainMajor; //是否重要专业
}
if (arrFldSet.Contains(conXzMajor.MajorDirection, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorDirection = objXzMajorEN.MajorDirection == "[null]" ? null :  objXzMajorEN.MajorDirection; //专业方向
}
if (arrFldSet.Contains(conXzMajor.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IsVisible = objXzMajorEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conXzMajor.IsNormal, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IsNormal = objXzMajorEN.IsNormal; //IsNormal
}
if (arrFldSet.Contains(conXzMajor.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.ModifyDate = objXzMajorEN.ModifyDate == "[null]" ? null :  objXzMajorEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conXzMajor.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.ModifyUserId = objXzMajorEN.ModifyUserId == "[null]" ? null :  objXzMajorEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzMajor.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.Memo = objXzMajorEN.Memo == "[null]" ? null :  objXzMajorEN.Memo; //备注
}
if (arrFldSet.Contains(conXzMajor.IdXzMajorShoolType, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IdXzMajorShoolType = objXzMajorEN.IdXzMajorShoolType == "[null]" ? null :  objXzMajorEN.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objXzMajorEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzMajorEN objXzMajorEN)
{
try
{
if (objXzMajorEN.MajorEnglishName == "[null]") objXzMajorEN.MajorEnglishName = null; //专业英文名称
if (objXzMajorEN.MajorExplain == "[null]") objXzMajorEN.MajorExplain = null; //专业说明
if (objXzMajorEN.MajorNationalID == "[null]") objXzMajorEN.MajorNationalID = null; //专业国家代码
if (objXzMajorEN.IdMajorType == "[null]") objXzMajorEN.IdMajorType = null; //专业类型(文理工)流水号
if (objXzMajorEN.IdDegreeType == "[null]") objXzMajorEN.IdDegreeType = null; //学位类型流水号
if (objXzMajorEN.MajorDirection == "[null]") objXzMajorEN.MajorDirection = null; //专业方向
if (objXzMajorEN.ModifyDate == "[null]") objXzMajorEN.ModifyDate = null; //修改日期
if (objXzMajorEN.ModifyUserId == "[null]") objXzMajorEN.ModifyUserId = null; //修改人
if (objXzMajorEN.Memo == "[null]") objXzMajorEN.Memo = null; //备注
if (objXzMajorEN.IdXzMajorShoolType == "[null]") objXzMajorEN.IdXzMajorShoolType = null; //专业学校类型流水号
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
public static void CheckPropertyNew(clsXzMajorEN objXzMajorEN)
{
 XzMajorDA.CheckPropertyNew(objXzMajorEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzMajorEN objXzMajorEN)
{
 XzMajorDA.CheckProperty4Condition(objXzMajorEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdXzMajorShoolType"></param>
public static void BindCbo_IdXzMajor(System.Windows.Forms.ComboBox objComboBox , string strIdXzMajorShoolType)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.IdXzMajor); 
List<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdXzMajorShoolType == strIdXzMajorShoolType).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzMajorEN objXzMajorEN = new clsXzMajorEN()
{
IdXzMajor = "0",
MajorName = "选[专业]..."
};
arrObjLstSel.Insert(0, objXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzMajor.IdXzMajor;
objComboBox.DisplayMember = conXzMajor.MajorName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}
 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdXzMajor(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.IdXzMajor); 
List<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzMajorEN objXzMajorEN = new clsXzMajorEN()
{
IdXzMajor = "0",
MajorName = "选[专业]..."
};
arrObjLst.Insert(0, objXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzMajor.IdXzMajor;
objComboBox.DisplayMember = conXzMajor.MajorName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdXzMajorShoolType"></param>
public static void BindDdl_IdXzMajor(System.Web.UI.WebControls.DropDownList objDDL , string strIdXzMajorShoolType)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.IdXzMajor); 
IEnumerable<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdXzMajorShoolType == strIdXzMajorShoolType).ToList();
objDDL.DataValueField = conXzMajor.IdXzMajor;
objDDL.DataTextField = conXzMajor.MajorName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdXzMajor(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.IdXzMajor); 
IEnumerable<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
objDDL.DataValueField = conXzMajor.IdXzMajor;
objDDL.DataTextField = conXzMajor.MajorName;
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
public static void BindDdl_IdXzMajorCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
List<clsXzMajorEN> arrXzMajorObjLst = GetAllXzMajorObjLstCache(); 
objDDL.DataValueField = conXzMajor.IdXzMajor;
objDDL.DataTextField = conXzMajor.MajorName;
objDDL.DataSource = arrXzMajorObjLst;
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
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdXzMajor");
//if (arrXzMajorObjLstCache == null)
//{
//arrXzMajorObjLstCache = XzMajorDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorEN GetObjByIdXzMajorCache(string strIdXzMajor)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName);
List<clsXzMajorEN> arrXzMajorObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
arrXzMajorObjLstCache
.Where(x=> x.IdXzMajor == strIdXzMajor 
);
if (arrXzMajorObjLst_Sel.Count() == 0)
{
   clsXzMajorEN obj = clsXzMajorBL.GetObjByIdXzMajor(strIdXzMajor);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzMajorObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorNameByIdXzMajorCache(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return "";
//获取缓存中的对象列表
clsXzMajorEN objXzMajor = GetObjByIdXzMajorCache(strIdXzMajor);
if (objXzMajor == null) return "";
return objXzMajor.MajorName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdXzMajorCache(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return "";
//获取缓存中的对象列表
clsXzMajorEN objXzMajor = GetObjByIdXzMajorCache(strIdXzMajor);
if (objXzMajor == null) return "";
return objXzMajor.MajorName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorEN> GetAllXzMajorObjLstCache()
{
//获取缓存中的对象列表
List<clsXzMajorEN> arrXzMajorObjLstCache = GetObjLstCache(); 
return arrXzMajorObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName);
List<clsXzMajorEN> arrXzMajorObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzMajorObjLstCache;
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
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzMajorEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzMajorEN._RefreshTimeLst.Count == 0) return "";
return clsXzMajorEN._RefreshTimeLst[clsXzMajorEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzMajorBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzMajorEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzMajorBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzMajor(专业)
 /// 唯一性条件:id_XzMajor
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
string strResult = XzMajorDA.GetUniCondStr(objXzMajorEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdXzMajor)
{
if (strInFldName != conXzMajor.IdXzMajor)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzMajor.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzMajor.AttributeName));
throw new Exception(strMsg);
}
var objXzMajor = clsXzMajorBL.GetObjByIdXzMajorCache(strIdXzMajor);
if (objXzMajor == null) return "";
return objXzMajor[strOutFldName].ToString();
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
int intRecCount = clsXzMajorDA.GetRecCount(strTabName);
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
int intRecCount = clsXzMajorDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzMajorDA.GetRecCount();
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
int intRecCount = clsXzMajorDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzMajorCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzMajorEN objXzMajorCond)
{
List<clsXzMajorEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzMajor.AttributeName)
{
if (objXzMajorCond.IsUpdated(strFldName) == false) continue;
if (objXzMajorCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorCond[strFldName].ToString());
}
else
{
if (objXzMajorCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajorCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajorCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajorCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajorCond[strFldName]));
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
 List<string> arrList = clsXzMajorDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzMajorDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(clsXzMajorEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzMajorDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzMajor] "); 
 strCreateTabCode.Append(" ( "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) primary key, "); 
 // /**专业Id*/ 
 strCreateTabCode.Append(" MajorId char(4) not Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) not Null, "); 
 // /**专业英文名称*/ 
 strCreateTabCode.Append(" MajorEnglishName varchar(200) Null, "); 
 // /**专业说明*/ 
 strCreateTabCode.Append(" MajorExplain varchar(2000) Null, "); 
 // /**专业国家代码*/ 
 strCreateTabCode.Append(" MajorNationalID varchar(10) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) not Null, "); 
 // /**专业类型(文理工)流水号*/ 
 strCreateTabCode.Append(" IdMajorType char(4) Null, "); 
 // /**学位类型流水号*/ 
 strCreateTabCode.Append(" IdDegreeType char(4) Null, "); 
 // /**是否重要专业*/ 
 strCreateTabCode.Append(" IsMainMajor bit Null, "); 
 // /**专业方向*/ 
 strCreateTabCode.Append(" MajorDirection varchar(30) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit not Null, "); 
 // /**IsNormal*/ 
 strCreateTabCode.Append(" IsNormal bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**专业学校类型流水号*/ 
 strCreateTabCode.Append(" IdXzMajorShoolType char(4) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**专业类型名称*/ 
 strCreateTabCode.Append(" MajorTypeName varchar(50) Null, "); 
 // /**学位类型名称*/ 
 strCreateTabCode.Append(" XwTypeDesc varchar(60) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 专业(XzMajor)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzMajor : clsCommFun4BL
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
clsXzMajorBL.ReFreshThisCache();
}
}

}