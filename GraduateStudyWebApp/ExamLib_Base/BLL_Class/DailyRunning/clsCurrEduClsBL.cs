
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsBL
 表名:CurrEduCls(01120123)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
public static class  clsCurrEduClsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsEN GetObj(this K_IdCurrEduCls_CurrEduCls myKey)
{
clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.CurrEduClsDA.GetObjByIdCurrEduCls(myKey.Value);
return objCurrEduClsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecord)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.AddNewRecordBySQL2(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
public static bool AddRecordEx(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCurrEduClsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCurrEduClsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班名(EduClsName)=[{0}])已经存在,不能重复!", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCurrEduClsEN.AddNewRecord();
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecordWithMaxId)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
string strIdCurrEduCls = clsCurrEduClsBL.CurrEduClsDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsEN);
     objCurrEduClsEN.IdCurrEduCls = strIdCurrEduCls;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
}
return strIdCurrEduCls;
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecord(SqlTransaction))", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.AddNewRecordBySQL2(objCurrEduClsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecordWithReturnKey)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
string strKey = clsCurrEduClsBL.CurrEduClsDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCurrEduClsEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecordWithReturnKey)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
string strKey = clsCurrEduClsBL.CurrEduClsDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdCurrEduCls(this clsCurrEduClsEN objCurrEduClsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conCurrEduCls.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conCurrEduCls.IdCurrEduCls);
}
objCurrEduClsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdCurrEduCls) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdCurrEduCls, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdCurrEduCls] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetCurrEduClsId(this clsCurrEduClsEN objCurrEduClsEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrEduClsId, conCurrEduCls.CurrEduClsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, conCurrEduCls.CurrEduClsId);
}
objCurrEduClsEN.CurrEduClsId = strCurrEduClsId; //教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.CurrEduClsId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.CurrEduClsId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.CurrEduClsId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetEduClsName(this clsCurrEduClsEN objCurrEduClsEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, conCurrEduCls.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, conCurrEduCls.EduClsName);
}
objCurrEduClsEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.EduClsName) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.EduClsName, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.EduClsName] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetEduClsTypeId(this clsCurrEduClsEN objCurrEduClsEN, string strEduClsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, conCurrEduCls.EduClsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, conCurrEduCls.EduClsTypeId);
}
objCurrEduClsEN.EduClsTypeId = strEduClsTypeId; //教学班类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.EduClsTypeId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.EduClsTypeId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.EduClsTypeId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetCourseId(this clsCurrEduClsEN objCurrEduClsEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCurrEduCls.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCurrEduCls.CourseId);
}
objCurrEduClsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.CourseId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.CourseId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.CourseId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetTeachingSolutionId(this clsCurrEduClsEN objCurrEduClsEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCurrEduCls.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCurrEduCls.TeachingSolutionId);
}
objCurrEduClsEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.TeachingSolutionId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.TeachingSolutionId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.TeachingSolutionId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdXzCollege(this clsCurrEduClsEN objCurrEduClsEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conCurrEduCls.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conCurrEduCls.IdXzCollege);
}
objCurrEduClsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdXzCollege) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdXzCollege, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdXzCollege] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdXzMajor(this clsCurrEduClsEN objCurrEduClsEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conCurrEduCls.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conCurrEduCls.IdXzMajor);
}
objCurrEduClsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdXzMajor) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdXzMajor, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdXzMajor] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdEduWay(this clsCurrEduClsEN objCurrEduClsEN, string strIdEduWay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEduWay, 4, conCurrEduCls.IdEduWay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEduWay, 4, conCurrEduCls.IdEduWay);
}
objCurrEduClsEN.IdEduWay = strIdEduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdEduWay) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdEduWay, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdEduWay] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdClassRoomType(this clsCurrEduClsEN objCurrEduClsEN, string strIdClassRoomType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdClassRoomType, 4, conCurrEduCls.IdClassRoomType);
}
objCurrEduClsEN.IdClassRoomType = strIdClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdClassRoomType) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdClassRoomType, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdClassRoomType] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetTotalLessonQty(this clsCurrEduClsEN objCurrEduClsEN, int? intTotalLessonQty, string strComparisonOp="")
	{
objCurrEduClsEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.TotalLessonQty) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.TotalLessonQty, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.TotalLessonQty] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetMaxStuQty(this clsCurrEduClsEN objCurrEduClsEN, int? intMaxStuQty, string strComparisonOp="")
	{
objCurrEduClsEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.MaxStuQty) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.MaxStuQty, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.MaxStuQty] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetWeekQty(this clsCurrEduClsEN objCurrEduClsEN, int? intWeekQty, string strComparisonOp="")
	{
objCurrEduClsEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.WeekQty) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.WeekQty, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.WeekQty] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetScheUnitPW(this clsCurrEduClsEN objCurrEduClsEN, short? shtScheUnitPW, string strComparisonOp="")
	{
objCurrEduClsEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.ScheUnitPW) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.ScheUnitPW, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.ScheUnitPW] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetWeekStatusId(this clsCurrEduClsEN objCurrEduClsEN, string strWeekStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekStatusId, 2, conCurrEduCls.WeekStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWeekStatusId, 2, conCurrEduCls.WeekStatusId);
}
objCurrEduClsEN.WeekStatusId = strWeekStatusId; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.WeekStatusId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.WeekStatusId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.WeekStatusId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetCustomerWeek(this clsCurrEduClsEN objCurrEduClsEN, string strCustomerWeek, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, conCurrEduCls.CustomerWeek);
}
objCurrEduClsEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.CustomerWeek) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.CustomerWeek, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.CustomerWeek] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetLessonQtyPerWeek(this clsCurrEduClsEN objCurrEduClsEN, short? shtLessonQtyPerWeek, string strComparisonOp="")
	{
objCurrEduClsEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.LessonQtyPerWeek) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.LessonQtyPerWeek, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.LessonQtyPerWeek] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetMark(this clsCurrEduClsEN objCurrEduClsEN, double? dblMark, string strComparisonOp="")
	{
objCurrEduClsEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.Mark) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.Mark, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.Mark] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdUniZone(this clsCurrEduClsEN objCurrEduClsEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conCurrEduCls.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conCurrEduCls.IdUniZone);
}
objCurrEduClsEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdUniZone) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdUniZone, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdUniZone] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdGradeBase(this clsCurrEduClsEN objCurrEduClsEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conCurrEduCls.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conCurrEduCls.IdGradeBase);
}
objCurrEduClsEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdGradeBase) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdGradeBase, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdGradeBase] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIsEffective(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsEffective, string strComparisonOp="")
	{
objCurrEduClsEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IsEffective) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IsEffective, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IsEffective] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIsForPaperReading(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsForPaperReading, string strComparisonOp="")
	{
objCurrEduClsEN.IsForPaperReading = bolIsForPaperReading; //是否参与论文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IsForPaperReading) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IsForPaperReading, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IsForPaperReading] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetSchoolYear(this clsCurrEduClsEN objCurrEduClsEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conCurrEduCls.SchoolYear);
}
objCurrEduClsEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.SchoolYear) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.SchoolYear, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.SchoolYear] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetSchoolTerm(this clsCurrEduClsEN objCurrEduClsEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conCurrEduCls.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conCurrEduCls.SchoolTerm);
}
objCurrEduClsEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.SchoolTerm) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.SchoolTerm, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.SchoolTerm] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdCourseType(this clsCurrEduClsEN objCurrEduClsEN, string strIdCourseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseType, 4, conCurrEduCls.IdCourseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseType, 4, conCurrEduCls.IdCourseType);
}
objCurrEduClsEN.IdCourseType = strIdCourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdCourseType) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdCourseType, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdCourseType] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIsDegree(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsDegree, string strComparisonOp="")
	{
objCurrEduClsEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IsDegree) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IsDegree, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IsDegree] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdScoreType(this clsCurrEduClsEN objCurrEduClsEN, string strIdScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdScoreType, 4, conCurrEduCls.IdScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdScoreType, 4, conCurrEduCls.IdScoreType);
}
objCurrEduClsEN.IdScoreType = strIdScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdScoreType) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdScoreType, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdScoreType] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetGetScoreWayId(this clsCurrEduClsEN objCurrEduClsEN, string strGetScoreWayId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, conCurrEduCls.GetScoreWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, conCurrEduCls.GetScoreWayId);
}
objCurrEduClsEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.GetScoreWayId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.GetScoreWayId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.GetScoreWayId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIsProportionalCtrl(this clsCurrEduClsEN objCurrEduClsEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objCurrEduClsEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IsProportionalCtrl) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IsProportionalCtrl, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IsProportionalCtrl] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetIdExamType(this clsCurrEduClsEN objCurrEduClsEN, string strIdExamType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdExamType, 4, conCurrEduCls.IdExamType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdExamType, 4, conCurrEduCls.IdExamType);
}
objCurrEduClsEN.IdExamType = strIdExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.IdExamType) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.IdExamType, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.IdExamType] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetExamTime(this clsCurrEduClsEN objCurrEduClsEN, string strExamTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamTime, 8, conCurrEduCls.ExamTime);
}
objCurrEduClsEN.ExamTime = strExamTime; //考试时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.ExamTime) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.ExamTime, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.ExamTime] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetBeginWeek(this clsCurrEduClsEN objCurrEduClsEN, short? shtBeginWeek, string strComparisonOp="")
	{
objCurrEduClsEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.BeginWeek) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.BeginWeek, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.BeginWeek] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetUserType(this clsCurrEduClsEN objCurrEduClsEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, conCurrEduCls.UserType);
}
objCurrEduClsEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.UserType) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.UserType, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.UserType] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetModifyDate(this clsCurrEduClsEN objCurrEduClsEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conCurrEduCls.ModifyDate);
}
objCurrEduClsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.ModifyDate) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.ModifyDate, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.ModifyDate] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetModifyUserId(this clsCurrEduClsEN objCurrEduClsEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conCurrEduCls.ModifyUserId);
}
objCurrEduClsEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.ModifyUserId) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.ModifyUserId, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.ModifyUserId] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCurrEduClsEN SetMemo(this clsCurrEduClsEN objCurrEduClsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCurrEduCls.Memo);
}
objCurrEduClsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCurrEduClsEN.dicFldComparisonOp.ContainsKey(conCurrEduCls.Memo) == false)
{
objCurrEduClsEN.dicFldComparisonOp.Add(conCurrEduCls.Memo, strComparisonOp);
}
else
{
objCurrEduClsEN.dicFldComparisonOp[conCurrEduCls.Memo] = strComparisonOp;
}
}
return objCurrEduClsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCurrEduClsEN objCurrEduClsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCurrEduClsEN.CheckPropertyNew();
clsCurrEduClsEN objCurrEduClsCond = new clsCurrEduClsEN();
string strCondition = objCurrEduClsCond
.SetIdCurrEduCls(objCurrEduClsEN.IdCurrEduCls, "<>")
.SetEduClsName(objCurrEduClsEN.EduClsName, "=")
.GetCombineCondition();
objCurrEduClsEN._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(EduClsName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCurrEduClsEN.Update();
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
 /// <param name = "objCurrEduCls">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCurrEduClsEN objCurrEduCls)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCurrEduClsEN objCurrEduClsCond = new clsCurrEduClsEN();
string strCondition = objCurrEduClsCond
.SetEduClsName(objCurrEduCls.EduClsName, "=")
.GetCombineCondition();
objCurrEduCls._IsCheckProperty = true;
bool bolIsExist = clsCurrEduClsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCurrEduCls.IdCurrEduCls = clsCurrEduClsBL.GetFirstID_S(strCondition);
objCurrEduCls.UpdateWithCondition(strCondition);
}
else
{
objCurrEduCls.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
objCurrEduCls.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsEN objCurrEduClsEN)
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.UpdateBySql2(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.UpdateBySql2(objCurrEduClsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCurrEduClsEN objCurrEduClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.UpdateBySql2(objCurrEduClsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsEN objCurrEduClsEN, string strWhereCond)
{
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.UpdateBySqlWithCondition(objCurrEduClsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCurrEduClsEN objCurrEduClsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCurrEduClsBL.CurrEduClsDA.UpdateBySqlWithConditionTransaction(objCurrEduClsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCurrEduClsEN objCurrEduClsEN)
{
try
{
int intRecNum = clsCurrEduClsBL.CurrEduClsDA.DelRecord(objCurrEduClsEN.IdCurrEduCls);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsENS">源对象</param>
 /// <param name = "objCurrEduClsENT">目标对象</param>
 public static void CopyTo(this clsCurrEduClsEN objCurrEduClsENS, clsCurrEduClsEN objCurrEduClsENT)
{
try
{
objCurrEduClsENT.IdCurrEduCls = objCurrEduClsENS.IdCurrEduCls; //教学班流水号
objCurrEduClsENT.CurrEduClsId = objCurrEduClsENS.CurrEduClsId; //教学班Id
objCurrEduClsENT.EduClsName = objCurrEduClsENS.EduClsName; //教学班名
objCurrEduClsENT.EduClsTypeId = objCurrEduClsENS.EduClsTypeId; //教学班类型Id
objCurrEduClsENT.CourseId = objCurrEduClsENS.CourseId; //课程Id
objCurrEduClsENT.TeachingSolutionId = objCurrEduClsENS.TeachingSolutionId; //教学方案Id
objCurrEduClsENT.IdXzCollege = objCurrEduClsENS.IdXzCollege; //学院流水号
objCurrEduClsENT.IdXzMajor = objCurrEduClsENS.IdXzMajor; //专业流水号
objCurrEduClsENT.IdEduWay = objCurrEduClsENS.IdEduWay; //教学方式流水号
objCurrEduClsENT.IdClassRoomType = objCurrEduClsENS.IdClassRoomType; //教室类型流水号
objCurrEduClsENT.TotalLessonQty = objCurrEduClsENS.TotalLessonQty; //总课时数
objCurrEduClsENT.MaxStuQty = objCurrEduClsENS.MaxStuQty; //最大学生数
objCurrEduClsENT.WeekQty = objCurrEduClsENS.WeekQty; //总周数
objCurrEduClsENT.ScheUnitPW = objCurrEduClsENS.ScheUnitPW; //周排课次数
objCurrEduClsENT.WeekStatusId = objCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduClsENT.CustomerWeek = objCurrEduClsENS.CustomerWeek; //自定义上课周
objCurrEduClsENT.LessonQtyPerWeek = objCurrEduClsENS.LessonQtyPerWeek; //周课时数
objCurrEduClsENT.Mark = objCurrEduClsENS.Mark; //获得学分
objCurrEduClsENT.IdUniZone = objCurrEduClsENS.IdUniZone; //校区流水号
objCurrEduClsENT.IdGradeBase = objCurrEduClsENS.IdGradeBase; //年级流水号
objCurrEduClsENT.IsEffective = objCurrEduClsENS.IsEffective; //是否有效
objCurrEduClsENT.IsForPaperReading = objCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objCurrEduClsENT.SchoolYear = objCurrEduClsENS.SchoolYear; //学年
objCurrEduClsENT.SchoolTerm = objCurrEduClsENS.SchoolTerm; //学期
objCurrEduClsENT.IdCourseType = objCurrEduClsENS.IdCourseType; //课程类型流水号
objCurrEduClsENT.IsDegree = objCurrEduClsENS.IsDegree; //是否学位课
objCurrEduClsENT.IdScoreType = objCurrEduClsENS.IdScoreType; //成绩类型流水号
objCurrEduClsENT.GetScoreWayId = objCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objCurrEduClsENT.IsProportionalCtrl = objCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objCurrEduClsENT.IdExamType = objCurrEduClsENS.IdExamType; //考试方式流水号
objCurrEduClsENT.ExamTime = objCurrEduClsENS.ExamTime; //考试时间
objCurrEduClsENT.BeginWeek = objCurrEduClsENS.BeginWeek; //开始周
objCurrEduClsENT.UserType = objCurrEduClsENS.UserType; //用户类型
objCurrEduClsENT.ModifyDate = objCurrEduClsENS.ModifyDate; //修改日期
objCurrEduClsENT.ModifyUserId = objCurrEduClsENS.ModifyUserId; //修改人
objCurrEduClsENT.Memo = objCurrEduClsENS.Memo; //备注
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
 /// <param name = "objCurrEduClsENS">源对象</param>
 /// <returns>目标对象=>clsCurrEduClsEN:objCurrEduClsENT</returns>
 public static clsCurrEduClsEN CopyTo(this clsCurrEduClsEN objCurrEduClsENS)
{
try
{
 clsCurrEduClsEN objCurrEduClsENT = new clsCurrEduClsEN()
{
IdCurrEduCls = objCurrEduClsENS.IdCurrEduCls, //教学班流水号
CurrEduClsId = objCurrEduClsENS.CurrEduClsId, //教学班Id
EduClsName = objCurrEduClsENS.EduClsName, //教学班名
EduClsTypeId = objCurrEduClsENS.EduClsTypeId, //教学班类型Id
CourseId = objCurrEduClsENS.CourseId, //课程Id
TeachingSolutionId = objCurrEduClsENS.TeachingSolutionId, //教学方案Id
IdXzCollege = objCurrEduClsENS.IdXzCollege, //学院流水号
IdXzMajor = objCurrEduClsENS.IdXzMajor, //专业流水号
IdEduWay = objCurrEduClsENS.IdEduWay, //教学方式流水号
IdClassRoomType = objCurrEduClsENS.IdClassRoomType, //教室类型流水号
TotalLessonQty = objCurrEduClsENS.TotalLessonQty, //总课时数
MaxStuQty = objCurrEduClsENS.MaxStuQty, //最大学生数
WeekQty = objCurrEduClsENS.WeekQty, //总周数
ScheUnitPW = objCurrEduClsENS.ScheUnitPW, //周排课次数
WeekStatusId = objCurrEduClsENS.WeekStatusId, //周状态编号(单,双,全周)
CustomerWeek = objCurrEduClsENS.CustomerWeek, //自定义上课周
LessonQtyPerWeek = objCurrEduClsENS.LessonQtyPerWeek, //周课时数
Mark = objCurrEduClsENS.Mark, //获得学分
IdUniZone = objCurrEduClsENS.IdUniZone, //校区流水号
IdGradeBase = objCurrEduClsENS.IdGradeBase, //年级流水号
IsEffective = objCurrEduClsENS.IsEffective, //是否有效
IsForPaperReading = objCurrEduClsENS.IsForPaperReading, //是否参与论文阅读
SchoolYear = objCurrEduClsENS.SchoolYear, //学年
SchoolTerm = objCurrEduClsENS.SchoolTerm, //学期
IdCourseType = objCurrEduClsENS.IdCourseType, //课程类型流水号
IsDegree = objCurrEduClsENS.IsDegree, //是否学位课
IdScoreType = objCurrEduClsENS.IdScoreType, //成绩类型流水号
GetScoreWayId = objCurrEduClsENS.GetScoreWayId, //获得成绩方式Id
IsProportionalCtrl = objCurrEduClsENS.IsProportionalCtrl, //是否比例控制
IdExamType = objCurrEduClsENS.IdExamType, //考试方式流水号
ExamTime = objCurrEduClsENS.ExamTime, //考试时间
BeginWeek = objCurrEduClsENS.BeginWeek, //开始周
UserType = objCurrEduClsENS.UserType, //用户类型
ModifyDate = objCurrEduClsENS.ModifyDate, //修改日期
ModifyUserId = objCurrEduClsENS.ModifyUserId, //修改人
Memo = objCurrEduClsENS.Memo, //备注
};
 return objCurrEduClsENT;
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
public static void CheckPropertyNew(this clsCurrEduClsEN objCurrEduClsEN)
{
 clsCurrEduClsBL.CurrEduClsDA.CheckPropertyNew(objCurrEduClsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCurrEduClsEN objCurrEduClsEN)
{
 clsCurrEduClsBL.CurrEduClsDA.CheckProperty4Condition(objCurrEduClsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCurrEduClsEN objCurrEduClsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdCurrEduCls, objCurrEduClsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.CurrEduClsId) == true)
{
string strComparisonOpCurrEduClsId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.CurrEduClsId, objCurrEduClsCond.CurrEduClsId, strComparisonOpCurrEduClsId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.EduClsName) == true)
{
string strComparisonOpEduClsName = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.EduClsName, objCurrEduClsCond.EduClsName, strComparisonOpEduClsName);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.EduClsTypeId) == true)
{
string strComparisonOpEduClsTypeId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.EduClsTypeId, objCurrEduClsCond.EduClsTypeId, strComparisonOpEduClsTypeId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.CourseId) == true)
{
string strComparisonOpCourseId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.CourseId, objCurrEduClsCond.CourseId, strComparisonOpCourseId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.TeachingSolutionId, objCurrEduClsCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdXzCollege, objCurrEduClsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdXzMajor, objCurrEduClsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdEduWay) == true)
{
string strComparisonOpIdEduWay = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdEduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdEduWay, objCurrEduClsCond.IdEduWay, strComparisonOpIdEduWay);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdClassRoomType) == true)
{
string strComparisonOpIdClassRoomType = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdClassRoomType, objCurrEduClsCond.IdClassRoomType, strComparisonOpIdClassRoomType);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.TotalLessonQty) == true)
{
string strComparisonOpTotalLessonQty = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls.TotalLessonQty, objCurrEduClsCond.TotalLessonQty, strComparisonOpTotalLessonQty);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.MaxStuQty) == true)
{
string strComparisonOpMaxStuQty = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls.MaxStuQty, objCurrEduClsCond.MaxStuQty, strComparisonOpMaxStuQty);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.WeekQty) == true)
{
string strComparisonOpWeekQty = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls.WeekQty, objCurrEduClsCond.WeekQty, strComparisonOpWeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.WeekStatusId) == true)
{
string strComparisonOpWeekStatusId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.WeekStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.WeekStatusId, objCurrEduClsCond.WeekStatusId, strComparisonOpWeekStatusId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.CustomerWeek) == true)
{
string strComparisonOpCustomerWeek = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.CustomerWeek, objCurrEduClsCond.CustomerWeek, strComparisonOpCustomerWeek);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.Mark) == true)
{
string strComparisonOpMark = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", conCurrEduCls.Mark, objCurrEduClsCond.Mark, strComparisonOpMark);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdUniZone, objCurrEduClsCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdGradeBase, objCurrEduClsCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IsEffective) == true)
{
if (objCurrEduClsCond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls.IsEffective);
}
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IsForPaperReading) == true)
{
if (objCurrEduClsCond.IsForPaperReading == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls.IsForPaperReading);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls.IsForPaperReading);
}
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.SchoolYear, objCurrEduClsCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.SchoolTerm, objCurrEduClsCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdCourseType) == true)
{
string strComparisonOpIdCourseType = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdCourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdCourseType, objCurrEduClsCond.IdCourseType, strComparisonOpIdCourseType);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IsDegree) == true)
{
if (objCurrEduClsCond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls.IsDegree);
}
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdScoreType) == true)
{
string strComparisonOpIdScoreType = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdScoreType, objCurrEduClsCond.IdScoreType, strComparisonOpIdScoreType);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.GetScoreWayId) == true)
{
string strComparisonOpGetScoreWayId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.GetScoreWayId, objCurrEduClsCond.GetScoreWayId, strComparisonOpGetScoreWayId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IsProportionalCtrl) == true)
{
if (objCurrEduClsCond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCurrEduCls.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCurrEduCls.IsProportionalCtrl);
}
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.IdExamType) == true)
{
string strComparisonOpIdExamType = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.IdExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.IdExamType, objCurrEduClsCond.IdExamType, strComparisonOpIdExamType);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.ExamTime) == true)
{
string strComparisonOpExamTime = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.ExamTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.ExamTime, objCurrEduClsCond.ExamTime, strComparisonOpExamTime);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.UserType) == true)
{
string strComparisonOpUserType = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.UserType, objCurrEduClsCond.UserType, strComparisonOpUserType);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.ModifyDate) == true)
{
string strComparisonOpModifyDate = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.ModifyDate, objCurrEduClsCond.ModifyDate, strComparisonOpModifyDate);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.ModifyUserId, objCurrEduClsCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objCurrEduClsCond.IsUpdated(conCurrEduCls.Memo) == true)
{
string strComparisonOpMemo = objCurrEduClsCond.dicFldComparisonOp[conCurrEduCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCurrEduCls.Memo, objCurrEduClsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CurrEduCls(当前教学班), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:EduClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCurrEduClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCurrEduClsEN objCurrEduClsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsEN == null) return true;
if (objCurrEduClsEN.IdCurrEduCls == null || objCurrEduClsEN.IdCurrEduCls == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and EduClsName = '{0}'", objCurrEduClsEN.EduClsName);
if (clsCurrEduClsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCurrEduCls !=  '{0}'", objCurrEduClsEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and EduClsName = '{0}'", objCurrEduClsEN.EduClsName);
if (clsCurrEduClsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CurrEduCls(当前教学班), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:EduClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCurrEduClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCurrEduClsEN objCurrEduClsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCurrEduClsEN == null) return "";
if (objCurrEduClsEN.IdCurrEduCls == null || objCurrEduClsEN.IdCurrEduCls == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and EduClsName = '{0}'", objCurrEduClsEN.EduClsName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCurrEduCls !=  '{0}'", objCurrEduClsEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and EduClsName = '{0}'", objCurrEduClsEN.EduClsName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CurrEduCls
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 当前教学班(CurrEduCls)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCurrEduClsBL
{
public static RelatedActions_CurrEduCls relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCurrEduClsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCurrEduClsDA CurrEduClsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCurrEduClsDA();
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
 public clsCurrEduClsBL()
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
if (string.IsNullOrEmpty(clsCurrEduClsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsEN._ConnectString);
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
public static DataTable GetDataTable_CurrEduCls(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CurrEduClsDA.GetDataTable_CurrEduCls(strWhereCond);
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
objDT = CurrEduClsDA.GetDataTable(strWhereCond);
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
objDT = CurrEduClsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CurrEduClsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CurrEduClsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CurrEduClsDA.GetDataTable_Top(objTopPara);
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
objDT = CurrEduClsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CurrEduClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CurrEduClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCurrEduClsEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCurrEduClsEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
List<clsCurrEduClsEN> arrCurrEduClsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCurrEduClsEN> arrCurrEduClsObjLst_Sel =
arrCurrEduClsObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrCurrEduClsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsEN> GetObjLst(string strWhereCond)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
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
public static List<clsCurrEduClsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCurrEduClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCurrEduClsEN> GetSubObjLstCache(clsCurrEduClsEN objCurrEduClsCond)
{
 string strCourseId = objCurrEduClsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCurrEduClsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCurrEduClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls.AttributeName)
{
if (objCurrEduClsCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsCond[strFldName].ToString());
}
else
{
if (objCurrEduClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsCond[strFldName]));
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
public static List<clsCurrEduClsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
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
public static List<clsCurrEduClsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
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
List<clsCurrEduClsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCurrEduClsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCurrEduClsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
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
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
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
public static List<clsCurrEduClsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCurrEduClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCurrEduClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
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
public static List<clsCurrEduClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCurrEduClsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCurrEduClsEN> arrObjLst = new List<clsCurrEduClsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsEN objCurrEduClsEN = new clsCurrEduClsEN();
try
{
objCurrEduClsEN.IdCurrEduCls = objRow[conCurrEduCls.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsEN.CurrEduClsId = objRow[conCurrEduCls.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduClsEN.EduClsName = objRow[conCurrEduCls.EduClsName].ToString().Trim(); //教学班名
objCurrEduClsEN.EduClsTypeId = objRow[conCurrEduCls.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduClsEN.CourseId = objRow[conCurrEduCls.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls.CourseId].ToString().Trim(); //课程Id
objCurrEduClsEN.TeachingSolutionId = objRow[conCurrEduCls.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduClsEN.IdXzCollege = objRow[conCurrEduCls.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduClsEN.IdXzMajor = objRow[conCurrEduCls.IdXzMajor] == DBNull.Value ? null : objRow[conCurrEduCls.IdXzMajor].ToString().Trim(); //专业流水号
objCurrEduClsEN.IdEduWay = objRow[conCurrEduCls.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduClsEN.IdClassRoomType = objRow[conCurrEduCls.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduClsEN.TotalLessonQty = objRow[conCurrEduCls.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduClsEN.MaxStuQty = objRow[conCurrEduCls.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduClsEN.WeekQty = objRow[conCurrEduCls.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls.WeekQty].ToString().Trim()); //总周数
objCurrEduClsEN.ScheUnitPW = objRow[conCurrEduCls.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduClsEN.WeekStatusId = objRow[conCurrEduCls.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduClsEN.CustomerWeek = objRow[conCurrEduCls.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduClsEN.LessonQtyPerWeek = objRow[conCurrEduCls.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduClsEN.Mark = objRow[conCurrEduCls.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls.Mark].ToString().Trim()); //获得学分
objCurrEduClsEN.IdUniZone = objRow[conCurrEduCls.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduClsEN.IdGradeBase = objRow[conCurrEduCls.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduClsEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsEffective].ToString().Trim()); //是否有效
objCurrEduClsEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduClsEN.SchoolYear = objRow[conCurrEduCls.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolYear].ToString().Trim(); //学年
objCurrEduClsEN.SchoolTerm = objRow[conCurrEduCls.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsEN.IdCourseType = objRow[conCurrEduCls.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduClsEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsDegree].ToString().Trim()); //是否学位课
objCurrEduClsEN.IdScoreType = objRow[conCurrEduCls.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduClsEN.GetScoreWayId = objRow[conCurrEduCls.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduClsEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduClsEN.IdExamType = objRow[conCurrEduCls.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduClsEN.ExamTime = objRow[conCurrEduCls.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls.ExamTime].ToString().Trim(); //考试时间
objCurrEduClsEN.BeginWeek = objRow[conCurrEduCls.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls.BeginWeek].ToString().Trim()); //开始周
objCurrEduClsEN.UserType = objRow[conCurrEduCls.UserType] == DBNull.Value ? null : objRow[conCurrEduCls.UserType].ToString().Trim(); //用户类型
objCurrEduClsEN.ModifyDate = objRow[conCurrEduCls.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsEN.ModifyUserId = objRow[conCurrEduCls.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls.ModifyUserId].ToString().Trim(); //修改人
objCurrEduClsEN.Memo = objRow[conCurrEduCls.Memo] == DBNull.Value ? null : objRow[conCurrEduCls.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCurrEduClsEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCurrEduClsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCurrEduClsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCurrEduCls(ref clsCurrEduClsEN objCurrEduClsEN)
{
bool bolResult = CurrEduClsDA.GetCurrEduCls(ref objCurrEduClsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsCurrEduClsEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCurrEduClsEN objCurrEduClsEN = CurrEduClsDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objCurrEduClsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCurrEduClsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCurrEduClsEN objCurrEduClsEN = CurrEduClsDA.GetFirstObj(strWhereCond);
 return objCurrEduClsEN;
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
public static clsCurrEduClsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCurrEduClsEN objCurrEduClsEN = CurrEduClsDA.GetObjByDataRow(objRow);
 return objCurrEduClsEN;
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
public static clsCurrEduClsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCurrEduClsEN objCurrEduClsEN = CurrEduClsDA.GetObjByDataRow(objRow);
 return objCurrEduClsEN;
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
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstCurrEduClsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsCurrEduClsEN> lstCurrEduClsObjLst)
{
foreach (clsCurrEduClsEN objCurrEduClsEN in lstCurrEduClsObjLst)
{
if (objCurrEduClsEN.IdCurrEduCls == strIdCurrEduCls)
{
return objCurrEduClsEN;
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
 string strMaxIdCurrEduCls;
 try
 {
 strMaxIdCurrEduCls = clsCurrEduClsDA.GetMaxStrId();
 return strMaxIdCurrEduCls;
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
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsCurrEduClsDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
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
 arrList = CurrEduClsDA.GetID(strWhereCond);
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
bool bolIsExist = CurrEduClsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CurrEduClsDA.IsExist(strIdCurrEduCls);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCurrEduCls">教学班流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCurrEduCls, string strOpUser)
{
clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
objCurrEduClsEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
objCurrEduClsEN.ModifyUserId = strOpUser;
return clsCurrEduClsBL.UpdateBySql2(objCurrEduClsEN);
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
 bolIsExist = clsCurrEduClsDA.IsExistTable();
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
 bolIsExist = CurrEduClsDA.IsExistTable(strTabName);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecordBySql2)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
bool bolResult = CurrEduClsDA.AddNewRecordBySQL2(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCurrEduClsEN objCurrEduClsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCurrEduClsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班名 = [{0}]的数据已经存在!(in clsCurrEduClsBL.AddNewRecordBySql2WithReturnKey)", objCurrEduClsEN.EduClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true || clsCurrEduClsBL.IsExist(objCurrEduClsEN.IdCurrEduCls) == true)
 {
     objCurrEduClsEN.IdCurrEduCls = clsCurrEduClsBL.GetMaxStrId_S();
 }
string strKey = CurrEduClsDA.AddNewRecordBySQL2WithReturnKey(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCurrEduClsEN objCurrEduClsEN)
{
try
{
bool bolResult = CurrEduClsDA.Update(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "objCurrEduClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCurrEduClsEN objCurrEduClsEN)
{
 if (string.IsNullOrEmpty(objCurrEduClsEN.IdCurrEduCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CurrEduClsDA.UpdateBySql2(objCurrEduClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCurrEduClsBL.ReFreshCache(objCurrEduClsEN.CourseId);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCurrEduCls)
{
try
{
 clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);

if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(objCurrEduClsEN.IdCurrEduCls, objCurrEduClsEN.ModifyUserId);
}
if (objCurrEduClsEN != null)
{
int intRecNum = CurrEduClsDA.DelRecord(strIdCurrEduCls);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsEN.CourseId);
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
/// <param name="strIdCurrEduCls">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCurrEduCls , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCurrEduCls.IdCurrEduCls,
//strIdCurrEduCls);
//        clsCurrEduClsBL.DelCurrEduClssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsBL.DelRecord(strIdCurrEduCls, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCurrEduCls, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduClsBL.relatedActions != null)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
bool bolResult = CurrEduClsDA.DelRecord(strIdCurrEduCls,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrIdCurrEduClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCurrEduClss(List<string> arrIdCurrEduClsLst)
{
if (arrIdCurrEduClsLst.Count == 0) return 0;
try
{
if (clsCurrEduClsBL.relatedActions != null)
{
foreach (var strIdCurrEduCls in arrIdCurrEduClsLst)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
 clsCurrEduClsEN objCurrEduClsEN = clsCurrEduClsBL.GetObjByIdCurrEduCls(arrIdCurrEduClsLst[0]);
int intDelRecNum = CurrEduClsDA.DelCurrEduCls(arrIdCurrEduClsLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCurrEduClsEN.CourseId);
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
public static int DelCurrEduClssByCond(string strWhereCond)
{
try
{
if (clsCurrEduClsBL.relatedActions != null)
{
List<string> arrIdCurrEduCls = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCurrEduCls in arrIdCurrEduCls)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conCurrEduCls.CourseId, strWhereCond);
int intRecNum = CurrEduClsDA.DelCurrEduCls(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
public static bool DelCurrEduClssByCondWithTransaction_S(string strWhereCond, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCurrEduClsBL.relatedActions != null)
{
List<string> arrIdCurrEduCls = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCurrEduCls in arrIdCurrEduCls)
{
clsCurrEduClsBL.relatedActions.UpdRelaTabDate(strIdCurrEduCls, "UpdRelaTabDate");
}
}
bool bolResult = CurrEduClsDA.DelCurrEduClsWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CurrEduCls]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCurrEduCls">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCurrEduCls, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCurrEduClsDA.GetSpecSQLObj();
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
//删除与表:[CurrEduCls]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCurrEduClsBL.DelRecord(strIdCurrEduCls, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCurrEduClsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCurrEduClsENS">源对象</param>
 /// <param name = "objCurrEduClsENT">目标对象</param>
 public static void CopyTo(clsCurrEduClsEN objCurrEduClsENS, clsCurrEduClsEN objCurrEduClsENT)
{
try
{
objCurrEduClsENT.IdCurrEduCls = objCurrEduClsENS.IdCurrEduCls; //教学班流水号
objCurrEduClsENT.CurrEduClsId = objCurrEduClsENS.CurrEduClsId; //教学班Id
objCurrEduClsENT.EduClsName = objCurrEduClsENS.EduClsName; //教学班名
objCurrEduClsENT.EduClsTypeId = objCurrEduClsENS.EduClsTypeId; //教学班类型Id
objCurrEduClsENT.CourseId = objCurrEduClsENS.CourseId; //课程Id
objCurrEduClsENT.TeachingSolutionId = objCurrEduClsENS.TeachingSolutionId; //教学方案Id
objCurrEduClsENT.IdXzCollege = objCurrEduClsENS.IdXzCollege; //学院流水号
objCurrEduClsENT.IdXzMajor = objCurrEduClsENS.IdXzMajor; //专业流水号
objCurrEduClsENT.IdEduWay = objCurrEduClsENS.IdEduWay; //教学方式流水号
objCurrEduClsENT.IdClassRoomType = objCurrEduClsENS.IdClassRoomType; //教室类型流水号
objCurrEduClsENT.TotalLessonQty = objCurrEduClsENS.TotalLessonQty; //总课时数
objCurrEduClsENT.MaxStuQty = objCurrEduClsENS.MaxStuQty; //最大学生数
objCurrEduClsENT.WeekQty = objCurrEduClsENS.WeekQty; //总周数
objCurrEduClsENT.ScheUnitPW = objCurrEduClsENS.ScheUnitPW; //周排课次数
objCurrEduClsENT.WeekStatusId = objCurrEduClsENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduClsENT.CustomerWeek = objCurrEduClsENS.CustomerWeek; //自定义上课周
objCurrEduClsENT.LessonQtyPerWeek = objCurrEduClsENS.LessonQtyPerWeek; //周课时数
objCurrEduClsENT.Mark = objCurrEduClsENS.Mark; //获得学分
objCurrEduClsENT.IdUniZone = objCurrEduClsENS.IdUniZone; //校区流水号
objCurrEduClsENT.IdGradeBase = objCurrEduClsENS.IdGradeBase; //年级流水号
objCurrEduClsENT.IsEffective = objCurrEduClsENS.IsEffective; //是否有效
objCurrEduClsENT.IsForPaperReading = objCurrEduClsENS.IsForPaperReading; //是否参与论文阅读
objCurrEduClsENT.SchoolYear = objCurrEduClsENS.SchoolYear; //学年
objCurrEduClsENT.SchoolTerm = objCurrEduClsENS.SchoolTerm; //学期
objCurrEduClsENT.IdCourseType = objCurrEduClsENS.IdCourseType; //课程类型流水号
objCurrEduClsENT.IsDegree = objCurrEduClsENS.IsDegree; //是否学位课
objCurrEduClsENT.IdScoreType = objCurrEduClsENS.IdScoreType; //成绩类型流水号
objCurrEduClsENT.GetScoreWayId = objCurrEduClsENS.GetScoreWayId; //获得成绩方式Id
objCurrEduClsENT.IsProportionalCtrl = objCurrEduClsENS.IsProportionalCtrl; //是否比例控制
objCurrEduClsENT.IdExamType = objCurrEduClsENS.IdExamType; //考试方式流水号
objCurrEduClsENT.ExamTime = objCurrEduClsENS.ExamTime; //考试时间
objCurrEduClsENT.BeginWeek = objCurrEduClsENS.BeginWeek; //开始周
objCurrEduClsENT.UserType = objCurrEduClsENS.UserType; //用户类型
objCurrEduClsENT.ModifyDate = objCurrEduClsENS.ModifyDate; //修改日期
objCurrEduClsENT.ModifyUserId = objCurrEduClsENS.ModifyUserId; //修改人
objCurrEduClsENT.Memo = objCurrEduClsENS.Memo; //备注
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
 /// <param name = "objCurrEduClsEN">源简化对象</param>
 public static void SetUpdFlag(clsCurrEduClsEN objCurrEduClsEN)
{
try
{
objCurrEduClsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCurrEduClsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCurrEduCls.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdCurrEduCls = objCurrEduClsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conCurrEduCls.CurrEduClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.CurrEduClsId = objCurrEduClsEN.CurrEduClsId; //教学班Id
}
if (arrFldSet.Contains(conCurrEduCls.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.EduClsName = objCurrEduClsEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(conCurrEduCls.EduClsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.EduClsTypeId = objCurrEduClsEN.EduClsTypeId == "[null]" ? null :  objCurrEduClsEN.EduClsTypeId; //教学班类型Id
}
if (arrFldSet.Contains(conCurrEduCls.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.CourseId = objCurrEduClsEN.CourseId == "[null]" ? null :  objCurrEduClsEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCurrEduCls.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.TeachingSolutionId = objCurrEduClsEN.TeachingSolutionId == "[null]" ? null :  objCurrEduClsEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(conCurrEduCls.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdXzCollege = objCurrEduClsEN.IdXzCollege == "[null]" ? null :  objCurrEduClsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conCurrEduCls.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdXzMajor = objCurrEduClsEN.IdXzMajor == "[null]" ? null :  objCurrEduClsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conCurrEduCls.IdEduWay, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdEduWay = objCurrEduClsEN.IdEduWay == "[null]" ? null :  objCurrEduClsEN.IdEduWay; //教学方式流水号
}
if (arrFldSet.Contains(conCurrEduCls.IdClassRoomType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdClassRoomType = objCurrEduClsEN.IdClassRoomType == "[null]" ? null :  objCurrEduClsEN.IdClassRoomType; //教室类型流水号
}
if (arrFldSet.Contains(conCurrEduCls.TotalLessonQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.TotalLessonQty = objCurrEduClsEN.TotalLessonQty; //总课时数
}
if (arrFldSet.Contains(conCurrEduCls.MaxStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.MaxStuQty = objCurrEduClsEN.MaxStuQty; //最大学生数
}
if (arrFldSet.Contains(conCurrEduCls.WeekQty, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.WeekQty = objCurrEduClsEN.WeekQty; //总周数
}
if (arrFldSet.Contains(conCurrEduCls.ScheUnitPW, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.ScheUnitPW = objCurrEduClsEN.ScheUnitPW; //周排课次数
}
if (arrFldSet.Contains(conCurrEduCls.WeekStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.WeekStatusId = objCurrEduClsEN.WeekStatusId == "[null]" ? null :  objCurrEduClsEN.WeekStatusId; //周状态编号(单,双,全周)
}
if (arrFldSet.Contains(conCurrEduCls.CustomerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.CustomerWeek = objCurrEduClsEN.CustomerWeek == "[null]" ? null :  objCurrEduClsEN.CustomerWeek; //自定义上课周
}
if (arrFldSet.Contains(conCurrEduCls.LessonQtyPerWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.LessonQtyPerWeek = objCurrEduClsEN.LessonQtyPerWeek; //周课时数
}
if (arrFldSet.Contains(conCurrEduCls.Mark, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.Mark = objCurrEduClsEN.Mark; //获得学分
}
if (arrFldSet.Contains(conCurrEduCls.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdUniZone = objCurrEduClsEN.IdUniZone == "[null]" ? null :  objCurrEduClsEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conCurrEduCls.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdGradeBase = objCurrEduClsEN.IdGradeBase == "[null]" ? null :  objCurrEduClsEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conCurrEduCls.IsEffective, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IsEffective = objCurrEduClsEN.IsEffective; //是否有效
}
if (arrFldSet.Contains(conCurrEduCls.IsForPaperReading, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IsForPaperReading = objCurrEduClsEN.IsForPaperReading; //是否参与论文阅读
}
if (arrFldSet.Contains(conCurrEduCls.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.SchoolYear = objCurrEduClsEN.SchoolYear == "[null]" ? null :  objCurrEduClsEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conCurrEduCls.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.SchoolTerm = objCurrEduClsEN.SchoolTerm == "[null]" ? null :  objCurrEduClsEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conCurrEduCls.IdCourseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdCourseType = objCurrEduClsEN.IdCourseType == "[null]" ? null :  objCurrEduClsEN.IdCourseType; //课程类型流水号
}
if (arrFldSet.Contains(conCurrEduCls.IsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IsDegree = objCurrEduClsEN.IsDegree; //是否学位课
}
if (arrFldSet.Contains(conCurrEduCls.IdScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdScoreType = objCurrEduClsEN.IdScoreType == "[null]" ? null :  objCurrEduClsEN.IdScoreType; //成绩类型流水号
}
if (arrFldSet.Contains(conCurrEduCls.GetScoreWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.GetScoreWayId = objCurrEduClsEN.GetScoreWayId == "[null]" ? null :  objCurrEduClsEN.GetScoreWayId; //获得成绩方式Id
}
if (arrFldSet.Contains(conCurrEduCls.IsProportionalCtrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IsProportionalCtrl = objCurrEduClsEN.IsProportionalCtrl; //是否比例控制
}
if (arrFldSet.Contains(conCurrEduCls.IdExamType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.IdExamType = objCurrEduClsEN.IdExamType == "[null]" ? null :  objCurrEduClsEN.IdExamType; //考试方式流水号
}
if (arrFldSet.Contains(conCurrEduCls.ExamTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.ExamTime = objCurrEduClsEN.ExamTime == "[null]" ? null :  objCurrEduClsEN.ExamTime; //考试时间
}
if (arrFldSet.Contains(conCurrEduCls.BeginWeek, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.BeginWeek = objCurrEduClsEN.BeginWeek; //开始周
}
if (arrFldSet.Contains(conCurrEduCls.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.UserType = objCurrEduClsEN.UserType == "[null]" ? null :  objCurrEduClsEN.UserType; //用户类型
}
if (arrFldSet.Contains(conCurrEduCls.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.ModifyDate = objCurrEduClsEN.ModifyDate == "[null]" ? null :  objCurrEduClsEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conCurrEduCls.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.ModifyUserId = objCurrEduClsEN.ModifyUserId == "[null]" ? null :  objCurrEduClsEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conCurrEduCls.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCurrEduClsEN.Memo = objCurrEduClsEN.Memo == "[null]" ? null :  objCurrEduClsEN.Memo; //备注
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
 /// <param name = "objCurrEduClsEN">源简化对象</param>
 public static void AccessFldValueNull(clsCurrEduClsEN objCurrEduClsEN)
{
try
{
if (objCurrEduClsEN.EduClsTypeId == "[null]") objCurrEduClsEN.EduClsTypeId = null; //教学班类型Id
if (objCurrEduClsEN.CourseId == "[null]") objCurrEduClsEN.CourseId = null; //课程Id
if (objCurrEduClsEN.TeachingSolutionId == "[null]") objCurrEduClsEN.TeachingSolutionId = null; //教学方案Id
if (objCurrEduClsEN.IdXzCollege == "[null]") objCurrEduClsEN.IdXzCollege = null; //学院流水号
if (objCurrEduClsEN.IdXzMajor == "[null]") objCurrEduClsEN.IdXzMajor = null; //专业流水号
if (objCurrEduClsEN.IdEduWay == "[null]") objCurrEduClsEN.IdEduWay = null; //教学方式流水号
if (objCurrEduClsEN.IdClassRoomType == "[null]") objCurrEduClsEN.IdClassRoomType = null; //教室类型流水号
if (objCurrEduClsEN.WeekStatusId == "[null]") objCurrEduClsEN.WeekStatusId = null; //周状态编号(单,双,全周)
if (objCurrEduClsEN.CustomerWeek == "[null]") objCurrEduClsEN.CustomerWeek = null; //自定义上课周
if (objCurrEduClsEN.IdUniZone == "[null]") objCurrEduClsEN.IdUniZone = null; //校区流水号
if (objCurrEduClsEN.IdGradeBase == "[null]") objCurrEduClsEN.IdGradeBase = null; //年级流水号
if (objCurrEduClsEN.SchoolYear == "[null]") objCurrEduClsEN.SchoolYear = null; //学年
if (objCurrEduClsEN.SchoolTerm == "[null]") objCurrEduClsEN.SchoolTerm = null; //学期
if (objCurrEduClsEN.IdCourseType == "[null]") objCurrEduClsEN.IdCourseType = null; //课程类型流水号
if (objCurrEduClsEN.IdScoreType == "[null]") objCurrEduClsEN.IdScoreType = null; //成绩类型流水号
if (objCurrEduClsEN.GetScoreWayId == "[null]") objCurrEduClsEN.GetScoreWayId = null; //获得成绩方式Id
if (objCurrEduClsEN.IdExamType == "[null]") objCurrEduClsEN.IdExamType = null; //考试方式流水号
if (objCurrEduClsEN.ExamTime == "[null]") objCurrEduClsEN.ExamTime = null; //考试时间
if (objCurrEduClsEN.UserType == "[null]") objCurrEduClsEN.UserType = null; //用户类型
if (objCurrEduClsEN.ModifyDate == "[null]") objCurrEduClsEN.ModifyDate = null; //修改日期
if (objCurrEduClsEN.ModifyUserId == "[null]") objCurrEduClsEN.ModifyUserId = null; //修改人
if (objCurrEduClsEN.Memo == "[null]") objCurrEduClsEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCurrEduClsEN objCurrEduClsEN)
{
 CurrEduClsDA.CheckPropertyNew(objCurrEduClsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCurrEduClsEN objCurrEduClsEN)
{
 CurrEduClsDA.CheckProperty4Condition(objCurrEduClsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCurrEduClsCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[当前教学班]...","0");
List<clsCurrEduClsEN> arrCurrEduClsObjLst = GetAllCurrEduClsObjLstCache(strCourseId); 
objDDL.DataValueField = conCurrEduCls.IdCurrEduCls;
objDDL.DataTextField = conCurrEduCls.EduClsName;
objDDL.DataSource = arrCurrEduClsObjLst;
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrCurrEduClsObjLstCache == null)
//{
//arrCurrEduClsObjLstCache = CurrEduClsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCurrEduClsEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
List<clsCurrEduClsEN> arrCurrEduClsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCurrEduClsEN> arrCurrEduClsObjLst_Sel =
arrCurrEduClsObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrCurrEduClsObjLst_Sel.Count() == 0)
{
   clsCurrEduClsEN obj = clsCurrEduClsBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdCurrEduCls, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCurrEduClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetEduClsNameByIdCurrEduClsCache(string strIdCurrEduCls, string strCourseId)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsCurrEduClsEN objCurrEduCls = GetObjByIdCurrEduClsCache(strIdCurrEduCls, strCourseId);
if (objCurrEduCls == null) return "";
return objCurrEduCls.EduClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCurrEduClsCache(string strIdCurrEduCls, string strCourseId)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return "";
//获取缓存中的对象列表
clsCurrEduClsEN objCurrEduCls = GetObjByIdCurrEduClsCache(strIdCurrEduCls, strCourseId);
if (objCurrEduCls == null) return "";
return objCurrEduCls.EduClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsEN> GetAllCurrEduClsObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsCurrEduClsEN> arrCurrEduClsObjLstCache = GetObjLstCache(strCourseId); 
return arrCurrEduClsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCurrEduClsEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsCurrEduClsEN> arrCurrEduClsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCurrEduClsObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:CourseId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCurrEduClsObjLst">需要排序的对象列表</param>
public static List <clsCurrEduClsEN> GetSubSet4CurrEduClsObjLstByCourseIdCache(string strCourseId)
{
   if (string.IsNullOrEmpty(strCourseId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
List<clsCurrEduClsEN> arrCurrEduClsObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCurrEduClsEN> arrCurrEduClsObjLst_Sel1 =
from objCurrEduClsEN in arrCurrEduClsObjLstCache
where objCurrEduClsEN.CourseId == strCourseId
select objCurrEduClsEN;
List <clsCurrEduClsEN> arrCurrEduClsObjLst_Sel = new List<clsCurrEduClsEN>();
foreach (clsCurrEduClsEN obj in arrCurrEduClsObjLst_Sel1)
{
arrCurrEduClsObjLst_Sel.Add(obj);
}
return arrCurrEduClsObjLst_Sel;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsCurrEduClsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCurrEduClsEN._RefreshTimeLst.Count == 0) return "";
return clsCurrEduClsEN._RefreshTimeLst[clsCurrEduClsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCurrEduClsEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsCurrEduClsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCurrEduClsBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CurrEduCls(当前教学班)
 /// 唯一性条件:EduClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCurrEduClsEN objCurrEduClsEN)
{
//检测记录是否存在
string strResult = CurrEduClsDA.GetUniCondStr(objCurrEduClsEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls, string strCourseId)
{
if (strInFldName != conCurrEduCls.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCurrEduCls.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCurrEduCls.AttributeName));
throw new Exception(strMsg);
}
var objCurrEduCls = clsCurrEduClsBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls, strCourseId);
if (objCurrEduCls == null) return "";
return objCurrEduCls[strOutFldName].ToString();
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
int intRecCount = clsCurrEduClsDA.GetRecCount(strTabName);
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
int intRecCount = clsCurrEduClsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCurrEduClsDA.GetRecCount();
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
int intRecCount = clsCurrEduClsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCurrEduClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCurrEduClsEN objCurrEduClsCond)
{
 string strCourseId = objCurrEduClsCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCurrEduClsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCurrEduClsEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCurrEduClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCurrEduCls.AttributeName)
{
if (objCurrEduClsCond.IsUpdated(strFldName) == false) continue;
if (objCurrEduClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsCond[strFldName].ToString());
}
else
{
if (objCurrEduClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCurrEduClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCurrEduClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCurrEduClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCurrEduClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCurrEduClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCurrEduClsCond[strFldName]));
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
 List<string> arrList = clsCurrEduClsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CurrEduClsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CurrEduClsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsDA.SetFldValue(clsCurrEduClsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CurrEduClsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCurrEduClsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCurrEduClsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CurrEduCls] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) primary key, "); 
 // /**教学班Id*/ 
 strCreateTabCode.Append(" CurrEduClsId varchar(15) not Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) not Null, "); 
 // /**教学班类型Id*/ 
 strCreateTabCode.Append(" EduClsTypeId char(4) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**教学方案Id*/ 
 strCreateTabCode.Append(" TeachingSolutionId char(8) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**教学方式流水号*/ 
 strCreateTabCode.Append(" IdEduWay char(4) Null, "); 
 // /**教室类型流水号*/ 
 strCreateTabCode.Append(" IdClassRoomType char(4) Null, "); 
 // /**总课时数*/ 
 strCreateTabCode.Append(" TotalLessonQty int Null, "); 
 // /**最大学生数*/ 
 strCreateTabCode.Append(" MaxStuQty int Null, "); 
 // /**总周数*/ 
 strCreateTabCode.Append(" WeekQty int Null, "); 
 // /**周排课次数*/ 
 strCreateTabCode.Append(" ScheUnitPW smallint Null, "); 
 // /**周状态编号(单,双,全周)*/ 
 strCreateTabCode.Append(" WeekStatusId char(2) Null, "); 
 // /**自定义上课周*/ 
 strCreateTabCode.Append(" CustomerWeek varchar(50) Null, "); 
 // /**周课时数*/ 
 strCreateTabCode.Append(" LessonQtyPerWeek smallint Null, "); 
 // /**获得学分*/ 
 strCreateTabCode.Append(" Mark decimal(7,2) Null, "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) Null, "); 
 // /**是否有效*/ 
 strCreateTabCode.Append(" IsEffective bit Null, "); 
 // /**是否参与论文阅读*/ 
 strCreateTabCode.Append(" IsForPaperReading bit Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**课程类型流水号*/ 
 strCreateTabCode.Append(" IdCourseType char(4) Null, "); 
 // /**是否学位课*/ 
 strCreateTabCode.Append(" IsDegree bit Null, "); 
 // /**成绩类型流水号*/ 
 strCreateTabCode.Append(" IdScoreType char(4) Null, "); 
 // /**获得成绩方式Id*/ 
 strCreateTabCode.Append(" GetScoreWayId char(2) Null, "); 
 // /**是否比例控制*/ 
 strCreateTabCode.Append(" IsProportionalCtrl bit Null, "); 
 // /**考试方式流水号*/ 
 strCreateTabCode.Append(" IdExamType char(4) Null, "); 
 // /**考试时间*/ 
 strCreateTabCode.Append(" ExamTime varchar(8) Null, "); 
 // /**开始周*/ 
 strCreateTabCode.Append(" BeginWeek smallint Null, "); 
 // /**用户类型*/ 
 strCreateTabCode.Append(" UserType varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**年级名称*/ 
 strCreateTabCode.Append(" GradeBaseName varchar(50) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) not Null, "); 
 // /**课程代码*/ 
 strCreateTabCode.Append(" CourseCode varchar(20) Null, "); 
 // /**教室类型描述*/ 
 strCreateTabCode.Append(" ClassRoomTypeDesc varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(20) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 当前教学班(CurrEduCls)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CurrEduCls : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsCurrEduClsBL.ReFreshThisCache(strCourseId);
}
}

}