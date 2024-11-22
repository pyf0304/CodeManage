
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingCaseResCaseBL
 表名:TeachingCaseResCase(01120377)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
public static class  clsTeachingCaseResCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingCaseResCaseEN GetObj(this K_IdTeachingCaseResCase_TeachingCaseResCase myKey)
{
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.GetObjByIdTeachingCaseResCase(myKey.Value);
return objTeachingCaseResCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (CheckUniqueness(objTeachingCaseResCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!教学案例资源案例ID = [{0}]的数据已经存在!(in clsTeachingCaseResCaseBL.AddNewRecord)", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
bool bolResult = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.AddNewRecordBySQL2(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objTeachingCaseResCaseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objTeachingCaseResCaseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学案例资源案例ID(TeachingCaseResCaseID)=[{0}])已经存在,不能重复!", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objTeachingCaseResCaseEN.AddNewRecord();
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (CheckUniqueness(objTeachingCaseResCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!教学案例资源案例ID = [{0}]的数据已经存在!(in clsTeachingCaseResCaseBL.AddNewRecordWithMaxId)", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
string strIdTeachingCaseResCase = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.AddNewRecordBySQL2WithReturnKey(objTeachingCaseResCaseEN);
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = strIdTeachingCaseResCase;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
}
return strIdTeachingCaseResCase;
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (CheckUniqueness(objTeachingCaseResCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!教学案例资源案例ID = [{0}]的数据已经存在!(in clsTeachingCaseResCaseBL.AddNewRecordWithReturnKey)", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
string strKey = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.AddNewRecordBySQL2WithReturnKey(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdTeachingCaseResCase(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdTeachingCaseResCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCase, 8, conTeachingCaseResCase.IdTeachingCaseResCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCase, 8, conTeachingCaseResCase.IdTeachingCaseResCase);
}
objTeachingCaseResCaseEN.IdTeachingCaseResCase = strIdTeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdTeachingCaseResCase) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdTeachingCaseResCase, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingCaseResCase] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseID(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseID = strTeachingCaseResCaseID; //教学案例资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseID) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseID, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseID] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseName(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, conTeachingCaseResCase.TeachingCaseResCaseName);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseName) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTheme(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTheme, 200, conTeachingCaseResCase.TeachingCaseResCaseTheme);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = strTeachingCaseResCaseTheme; //教学案例资源案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTheme) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTheme] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseText(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseText, 8000, conTeachingCaseResCase.TeachingCaseResCaseText);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseText = strTeachingCaseResCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseText) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseText, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseText] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = strTeachingCaseResCaseDate; //视频资源日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTime(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = strTeachingCaseResCaseTime; //视频资源时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTime) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTime, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTime] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseDateIn(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = strTeachingCaseResCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseDateIn) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetTeachingCaseResCaseTimeIn(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strTeachingCaseResCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
}
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = strTeachingCaseResCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.TeachingCaseResCaseTimeIn) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdCaseType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseType, conTeachingCaseResCase.IdCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, conTeachingCaseResCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, conTeachingCaseResCase.IdCaseType);
}
objTeachingCaseResCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdCaseType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdCaseType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdCaseType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdTeachingCaseResCaseType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdTeachingCaseResCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingCaseResCaseType, conTeachingCaseResCase.IdTeachingCaseResCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingCaseResCaseType, 4, conTeachingCaseResCase.IdTeachingCaseResCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingCaseResCaseType, 4, conTeachingCaseResCase.IdTeachingCaseResCaseType);
}
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = strIdTeachingCaseResCaseType; //教学案例资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdTeachingCaseResCaseType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdTeachingCaseResCaseType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingCaseResCaseType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCourseId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conTeachingCaseResCase.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conTeachingCaseResCase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conTeachingCaseResCase.CourseId);
}
objTeachingCaseResCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CourseId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CourseId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CourseId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetOwnerId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conTeachingCaseResCase.OwnerId);
}
objTeachingCaseResCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.OwnerId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.OwnerId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.OwnerId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdStudyLevel(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
}
objTeachingCaseResCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdStudyLevel) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdStudyLevel, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdStudyLevel] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdTeachingPlan(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conTeachingCaseResCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conTeachingCaseResCase.IdTeachingPlan);
}
objTeachingCaseResCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdTeachingPlan) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdTeachingPlan, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingPlan] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdDiscipline(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conTeachingCaseResCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conTeachingCaseResCase.IdDiscipline);
}
objTeachingCaseResCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdDiscipline) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdDiscipline, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdDiscipline] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetBrowseCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.BrowseCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.BrowseCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.BrowseCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdSenateGaugeVersion(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
}
objTeachingCaseResCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdSenateGaugeVersion) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdTeachSkill(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, conTeachingCaseResCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, conTeachingCaseResCase.IdTeachSkill);
}
objTeachingCaseResCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdTeachSkill) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdTeachSkill, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdTeachSkill] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCaseLevelId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
}
objTeachingCaseResCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CaseLevelId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CaseLevelId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CaseLevelId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetDocFile(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, conTeachingCaseResCase.DocFile);
}
objTeachingCaseResCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.DocFile) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.DocFile, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.DocFile] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsNeedGeneWord(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsNeedGeneWord) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetWordCreateDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conTeachingCaseResCase.WordCreateDate);
}
objTeachingCaseResCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.WordCreateDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.WordCreateDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.WordCreateDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsVisible(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsVisible) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsVisible, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsVisible] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsDualVideo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsDualVideo) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsDualVideo, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsDualVideo] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdXzCollege(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, conTeachingCaseResCase.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conTeachingCaseResCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conTeachingCaseResCase.IdXzCollege);
}
objTeachingCaseResCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdXzCollege) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdXzCollege, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdXzCollege] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIdXzMajor(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conTeachingCaseResCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conTeachingCaseResCase.IdXzMajor);
}
objTeachingCaseResCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IdXzMajor) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IdXzMajor, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IdXzMajor] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCourseChapterId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
}
objTeachingCaseResCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CourseChapterId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CourseChapterId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CourseChapterId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetViewCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int? intViewCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ViewCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ViewCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ViewCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetIsShow(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.IsShow) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.IsShow, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.IsShow] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetDownloadNumber(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.DownloadNumber) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.DownloadNumber, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.DownloadNumber] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetFileIntegration(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.FileIntegration) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.FileIntegration, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.FileIntegration] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetLikeCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.LikeCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.LikeCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.LikeCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetCollectionCount(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objTeachingCaseResCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.CollectionCount) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.CollectionCount, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.CollectionCount] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetRecommendedDegreeId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
}
objTeachingCaseResCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.RecommendedDegreeId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetftpFileType(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conTeachingCaseResCase.ftpFileType);
}
objTeachingCaseResCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ftpFileType) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ftpFileType, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ftpFileType] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetVideoUrl(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conTeachingCaseResCase.VideoUrl);
}
objTeachingCaseResCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.VideoUrl) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.VideoUrl, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.VideoUrl] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetVideoPath(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conTeachingCaseResCase.VideoPath);
}
objTeachingCaseResCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.VideoPath) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.VideoPath, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.VideoPath] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetResErrMsg(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conTeachingCaseResCase.ResErrMsg);
}
objTeachingCaseResCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.ResErrMsg) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.ResErrMsg, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.ResErrMsg] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetUpdDate(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingCaseResCase.UpdDate);
}
objTeachingCaseResCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.UpdDate) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.UpdDate, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.UpdDate] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetUpdUserId(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingCaseResCase.UpdUserId);
}
objTeachingCaseResCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.UpdUserId) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.UpdUserId, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.UpdUserId] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachingCaseResCaseEN SetMemo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingCaseResCase.Memo);
}
objTeachingCaseResCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingCaseResCaseEN.dicFldComparisonOp.ContainsKey(conTeachingCaseResCase.Memo) == false)
{
objTeachingCaseResCaseEN.dicFldComparisonOp.Add(conTeachingCaseResCase.Memo, strComparisonOp);
}
else
{
objTeachingCaseResCaseEN.dicFldComparisonOp[conTeachingCaseResCase.Memo] = strComparisonOp;
}
}
return objTeachingCaseResCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTeachingCaseResCaseEN.CheckPropertyNew();
clsTeachingCaseResCaseEN objTeachingCaseResCaseCond = new clsTeachingCaseResCaseEN();
string strCondition = objTeachingCaseResCaseCond
.SetIdTeachingCaseResCase(objTeachingCaseResCaseEN.IdTeachingCaseResCase, "<>")
.SetTeachingCaseResCaseID(objTeachingCaseResCaseEN.TeachingCaseResCaseID, "=")
.GetCombineCondition();
objTeachingCaseResCaseEN._IsCheckProperty = true;
bool bolIsExist = clsTeachingCaseResCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TeachingCaseResCaseID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTeachingCaseResCaseEN.Update();
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
 /// <param name = "objTeachingCaseResCase">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTeachingCaseResCaseEN objTeachingCaseResCase)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTeachingCaseResCaseEN objTeachingCaseResCaseCond = new clsTeachingCaseResCaseEN();
string strCondition = objTeachingCaseResCaseCond
.SetTeachingCaseResCaseID(objTeachingCaseResCase.TeachingCaseResCaseID, "=")
.GetCombineCondition();
objTeachingCaseResCase._IsCheckProperty = true;
bool bolIsExist = clsTeachingCaseResCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTeachingCaseResCase.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetFirstID_S(strCondition);
objTeachingCaseResCase.UpdateWithCondition(strCondition);
}
else
{
objTeachingCaseResCase.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
objTeachingCaseResCase.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.UpdateBySql2(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.UpdateBySql2(objTeachingCaseResCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWhereCond)
{
try
{
bool bolResult = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.UpdateBySqlWithCondition(objTeachingCaseResCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.UpdateBySqlWithConditionTransaction(objTeachingCaseResCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
int intRecNum = clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.DelRecord(objTeachingCaseResCaseEN.IdTeachingCaseResCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseENS, clsTeachingCaseResCaseEN objTeachingCaseResCaseENT)
{
try
{
objTeachingCaseResCaseENT.IdTeachingCaseResCase = objTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objTeachingCaseResCaseENT.TeachingCaseResCaseID = objTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objTeachingCaseResCaseENT.TeachingCaseResCaseName = objTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objTeachingCaseResCaseENT.TeachingCaseResCaseText = objTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objTeachingCaseResCaseENT.TeachingCaseResCaseDate = objTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTime = objTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objTeachingCaseResCaseENT.IdCaseType = objTeachingCaseResCaseENS.IdCaseType; //案例类型流水号
objTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objTeachingCaseResCaseENT.CourseId = objTeachingCaseResCaseENS.CourseId; //课程Id
objTeachingCaseResCaseENT.OwnerId = objTeachingCaseResCaseENS.OwnerId; //拥有者Id
objTeachingCaseResCaseENT.IdStudyLevel = objTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objTeachingCaseResCaseENT.IdTeachingPlan = objTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objTeachingCaseResCaseENT.IdDiscipline = objTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objTeachingCaseResCaseENT.BrowseCount = objTeachingCaseResCaseENS.BrowseCount; //浏览次数
objTeachingCaseResCaseENT.IdSenateGaugeVersion = objTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objTeachingCaseResCaseENT.IdTeachSkill = objTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objTeachingCaseResCaseENT.CaseLevelId = objTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objTeachingCaseResCaseENT.DocFile = objTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objTeachingCaseResCaseENT.IsNeedGeneWord = objTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objTeachingCaseResCaseENT.WordCreateDate = objTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objTeachingCaseResCaseENT.IsVisible = objTeachingCaseResCaseENS.IsVisible; //是否显示
objTeachingCaseResCaseENT.IsDualVideo = objTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objTeachingCaseResCaseENT.IdXzCollege = objTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objTeachingCaseResCaseENT.IdXzMajor = objTeachingCaseResCaseENS.IdXzMajor; //专业流水号
objTeachingCaseResCaseENT.CourseChapterId = objTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objTeachingCaseResCaseENT.ViewCount = objTeachingCaseResCaseENS.ViewCount; //浏览量
objTeachingCaseResCaseENT.IsShow = objTeachingCaseResCaseENS.IsShow; //是否启用
objTeachingCaseResCaseENT.DownloadNumber = objTeachingCaseResCaseENS.DownloadNumber; //下载数目
objTeachingCaseResCaseENT.FileIntegration = objTeachingCaseResCaseENS.FileIntegration; //文件积分
objTeachingCaseResCaseENT.LikeCount = objTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objTeachingCaseResCaseENT.CollectionCount = objTeachingCaseResCaseENS.CollectionCount; //收藏数量
objTeachingCaseResCaseENT.RecommendedDegreeId = objTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objTeachingCaseResCaseENT.ftpFileType = objTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objTeachingCaseResCaseENT.VideoUrl = objTeachingCaseResCaseENS.VideoUrl; //视频Url
objTeachingCaseResCaseENT.VideoPath = objTeachingCaseResCaseENS.VideoPath; //视频目录
objTeachingCaseResCaseENT.ResErrMsg = objTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objTeachingCaseResCaseENT.UpdDate = objTeachingCaseResCaseENS.UpdDate; //修改日期
objTeachingCaseResCaseENT.UpdUserId = objTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objTeachingCaseResCaseENT.Memo = objTeachingCaseResCaseENS.Memo; //备注
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
 /// <param name = "objTeachingCaseResCaseENS">源对象</param>
 /// <returns>目标对象=>clsTeachingCaseResCaseEN:objTeachingCaseResCaseENT</returns>
 public static clsTeachingCaseResCaseEN CopyTo(this clsTeachingCaseResCaseEN objTeachingCaseResCaseENS)
{
try
{
 clsTeachingCaseResCaseEN objTeachingCaseResCaseENT = new clsTeachingCaseResCaseEN()
{
IdTeachingCaseResCase = objTeachingCaseResCaseENS.IdTeachingCaseResCase, //教学案例资源案例流水号
TeachingCaseResCaseID = objTeachingCaseResCaseENS.TeachingCaseResCaseID, //教学案例资源案例ID
TeachingCaseResCaseName = objTeachingCaseResCaseENS.TeachingCaseResCaseName, //教学案例资源案例名称
TeachingCaseResCaseTheme = objTeachingCaseResCaseENS.TeachingCaseResCaseTheme, //教学案例资源案例主题词
TeachingCaseResCaseText = objTeachingCaseResCaseENS.TeachingCaseResCaseText, //案例文本内容
TeachingCaseResCaseDate = objTeachingCaseResCaseENS.TeachingCaseResCaseDate, //视频资源日期
TeachingCaseResCaseTime = objTeachingCaseResCaseENS.TeachingCaseResCaseTime, //视频资源时间
TeachingCaseResCaseDateIn = objTeachingCaseResCaseENS.TeachingCaseResCaseDateIn, //案例入库日期
TeachingCaseResCaseTimeIn = objTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn, //案例入库时间
IdCaseType = objTeachingCaseResCaseENS.IdCaseType, //案例类型流水号
IdTeachingCaseResCaseType = objTeachingCaseResCaseENS.IdTeachingCaseResCaseType, //教学案例资源类型流水号
CourseId = objTeachingCaseResCaseENS.CourseId, //课程Id
OwnerId = objTeachingCaseResCaseENS.OwnerId, //拥有者Id
IdStudyLevel = objTeachingCaseResCaseENS.IdStudyLevel, //id_StudyLevel
IdTeachingPlan = objTeachingCaseResCaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objTeachingCaseResCaseENS.IdDiscipline, //学科流水号
BrowseCount = objTeachingCaseResCaseENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objTeachingCaseResCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
IdTeachSkill = objTeachingCaseResCaseENS.IdTeachSkill, //教学技能流水号
CaseLevelId = objTeachingCaseResCaseENS.CaseLevelId, //课例等级Id
DocFile = objTeachingCaseResCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objTeachingCaseResCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objTeachingCaseResCaseENS.WordCreateDate, //Word生成日期
IsVisible = objTeachingCaseResCaseENS.IsVisible, //是否显示
IsDualVideo = objTeachingCaseResCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objTeachingCaseResCaseENS.IdXzCollege, //学院流水号
IdXzMajor = objTeachingCaseResCaseENS.IdXzMajor, //专业流水号
CourseChapterId = objTeachingCaseResCaseENS.CourseChapterId, //课程章节ID
ViewCount = objTeachingCaseResCaseENS.ViewCount, //浏览量
IsShow = objTeachingCaseResCaseENS.IsShow, //是否启用
DownloadNumber = objTeachingCaseResCaseENS.DownloadNumber, //下载数目
FileIntegration = objTeachingCaseResCaseENS.FileIntegration, //文件积分
LikeCount = objTeachingCaseResCaseENS.LikeCount, //资源喜欢数量
CollectionCount = objTeachingCaseResCaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objTeachingCaseResCaseENS.RecommendedDegreeId, //推荐度Id
ftpFileType = objTeachingCaseResCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objTeachingCaseResCaseENS.VideoUrl, //视频Url
VideoPath = objTeachingCaseResCaseENS.VideoPath, //视频目录
ResErrMsg = objTeachingCaseResCaseENS.ResErrMsg, //资源错误信息
UpdDate = objTeachingCaseResCaseENS.UpdDate, //修改日期
UpdUserId = objTeachingCaseResCaseENS.UpdUserId, //修改用户Id
Memo = objTeachingCaseResCaseENS.Memo, //备注
};
 return objTeachingCaseResCaseENT;
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
public static void CheckPropertyNew(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.CheckPropertyNew(objTeachingCaseResCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 clsTeachingCaseResCaseBL.TeachingCaseResCaseDA.CheckProperty4Condition(objTeachingCaseResCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingCaseResCaseEN objTeachingCaseResCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCase) == true)
{
string strComparisonOpIdTeachingCaseResCase = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdTeachingCaseResCase, objTeachingCaseResCaseCond.IdTeachingCaseResCase, strComparisonOpIdTeachingCaseResCase);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID) == true)
{
string strComparisonOpTeachingCaseResCaseID = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseID, objTeachingCaseResCaseCond.TeachingCaseResCaseID, strComparisonOpTeachingCaseResCaseID);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName) == true)
{
string strComparisonOpTeachingCaseResCaseName = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseName, objTeachingCaseResCaseCond.TeachingCaseResCaseName, strComparisonOpTeachingCaseResCaseName);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme) == true)
{
string strComparisonOpTeachingCaseResCaseTheme = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTheme, objTeachingCaseResCaseCond.TeachingCaseResCaseTheme, strComparisonOpTeachingCaseResCaseTheme);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText) == true)
{
string strComparisonOpTeachingCaseResCaseText = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseText, objTeachingCaseResCaseCond.TeachingCaseResCaseText, strComparisonOpTeachingCaseResCaseText);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate) == true)
{
string strComparisonOpTeachingCaseResCaseDate = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseDate, objTeachingCaseResCaseCond.TeachingCaseResCaseDate, strComparisonOpTeachingCaseResCaseDate);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime) == true)
{
string strComparisonOpTeachingCaseResCaseTime = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTime, objTeachingCaseResCaseCond.TeachingCaseResCaseTime, strComparisonOpTeachingCaseResCaseTime);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn) == true)
{
string strComparisonOpTeachingCaseResCaseDateIn = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseDateIn, objTeachingCaseResCaseCond.TeachingCaseResCaseDateIn, strComparisonOpTeachingCaseResCaseDateIn);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn) == true)
{
string strComparisonOpTeachingCaseResCaseTimeIn = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.TeachingCaseResCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.TeachingCaseResCaseTimeIn, objTeachingCaseResCaseCond.TeachingCaseResCaseTimeIn, strComparisonOpTeachingCaseResCaseTimeIn);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdCaseType, objTeachingCaseResCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType) == true)
{
string strComparisonOpIdTeachingCaseResCaseType = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingCaseResCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdTeachingCaseResCaseType, objTeachingCaseResCaseCond.IdTeachingCaseResCaseType, strComparisonOpIdTeachingCaseResCaseType);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.CourseId) == true)
{
string strComparisonOpCourseId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CourseId, objTeachingCaseResCaseCond.CourseId, strComparisonOpCourseId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.OwnerId, objTeachingCaseResCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdStudyLevel, objTeachingCaseResCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdTeachingPlan, objTeachingCaseResCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdDiscipline, objTeachingCaseResCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.BrowseCount, objTeachingCaseResCaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdSenateGaugeVersion, objTeachingCaseResCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdTeachSkill, objTeachingCaseResCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CaseLevelId, objTeachingCaseResCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.DocFile) == true)
{
string strComparisonOpDocFile = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.DocFile, objTeachingCaseResCaseCond.DocFile, strComparisonOpDocFile);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord) == true)
{
if (objTeachingCaseResCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsNeedGeneWord);
}
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.WordCreateDate, objTeachingCaseResCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IsVisible) == true)
{
if (objTeachingCaseResCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsVisible);
}
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IsDualVideo) == true)
{
if (objTeachingCaseResCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsDualVideo);
}
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdXzCollege, objTeachingCaseResCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.IdXzMajor, objTeachingCaseResCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.CourseChapterId, objTeachingCaseResCaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.ViewCount) == true)
{
string strComparisonOpViewCount = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.ViewCount, objTeachingCaseResCaseCond.ViewCount, strComparisonOpViewCount);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.IsShow) == true)
{
if (objTeachingCaseResCaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachingCaseResCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachingCaseResCase.IsShow);
}
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.DownloadNumber, objTeachingCaseResCaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.FileIntegration, objTeachingCaseResCaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.LikeCount) == true)
{
string strComparisonOpLikeCount = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.LikeCount, objTeachingCaseResCaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachingCaseResCase.CollectionCount, objTeachingCaseResCaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.RecommendedDegreeId, objTeachingCaseResCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.ftpFileType, objTeachingCaseResCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.VideoUrl, objTeachingCaseResCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.VideoPath, objTeachingCaseResCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.ResErrMsg, objTeachingCaseResCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.UpdDate, objTeachingCaseResCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.UpdUserId, objTeachingCaseResCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objTeachingCaseResCaseCond.IsUpdated(conTeachingCaseResCase.Memo) == true)
{
string strComparisonOpMemo = objTeachingCaseResCaseCond.dicFldComparisonOp[conTeachingCaseResCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingCaseResCase.Memo, objTeachingCaseResCaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TeachingCaseResCase(教学案例资源案例), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TeachingCaseResCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTeachingCaseResCaseEN == null) return true;
if (objTeachingCaseResCaseEN.IdTeachingCaseResCase == null || objTeachingCaseResCaseEN.IdTeachingCaseResCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
if (clsTeachingCaseResCaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdTeachingCaseResCase !=  '{0}'", objTeachingCaseResCaseEN.IdTeachingCaseResCase);
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
if (clsTeachingCaseResCaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TeachingCaseResCase(教学案例资源案例), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TeachingCaseResCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTeachingCaseResCaseEN == null) return "";
if (objTeachingCaseResCaseEN.IdTeachingCaseResCase == null || objTeachingCaseResCaseEN.IdTeachingCaseResCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdTeachingCaseResCase !=  '{0}'", objTeachingCaseResCaseEN.IdTeachingCaseResCase);
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TeachingCaseResCase
{
public virtual bool UpdRelaTabDate(string strIdTeachingCaseResCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 教学案例资源案例(TeachingCaseResCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTeachingCaseResCaseBL
{
public static RelatedActions_TeachingCaseResCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTeachingCaseResCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTeachingCaseResCaseDA TeachingCaseResCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTeachingCaseResCaseDA();
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
 public clsTeachingCaseResCaseBL()
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
if (string.IsNullOrEmpty(clsTeachingCaseResCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingCaseResCaseEN._ConnectString);
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
public static DataTable GetDataTable_TeachingCaseResCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TeachingCaseResCaseDA.GetDataTable_TeachingCaseResCase(strWhereCond);
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
objDT = TeachingCaseResCaseDA.GetDataTable(strWhereCond);
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
objDT = TeachingCaseResCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TeachingCaseResCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TeachingCaseResCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TeachingCaseResCaseDA.GetDataTable_Top(objTopPara);
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
objDT = TeachingCaseResCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TeachingCaseResCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TeachingCaseResCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachingCaseResCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLstByIdTeachingCaseResCaseLst(List<string> arrIdTeachingCaseResCaseLst)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachingCaseResCaseLst, true);
 string strWhereCond = string.Format("IdTeachingCaseResCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachingCaseResCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTeachingCaseResCaseEN> GetObjLstByIdTeachingCaseResCaseLstCache(List<string> arrIdTeachingCaseResCaseLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName, strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Sel =
arrTeachingCaseResCaseObjLstCache
.Where(x => arrIdTeachingCaseResCaseLst.Contains(x.IdTeachingCaseResCase));
return arrTeachingCaseResCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLst(string strWhereCond)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
public static List<clsTeachingCaseResCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTeachingCaseResCaseEN> GetSubObjLstCache(clsTeachingCaseResCaseEN objTeachingCaseResCaseCond)
{
 string strCourseId = objTeachingCaseResCaseCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsTeachingCaseResCaseBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsTeachingCaseResCaseEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachingCaseResCase.AttributeName)
{
if (objTeachingCaseResCaseCond.IsUpdated(strFldName) == false) continue;
if (objTeachingCaseResCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingCaseResCaseCond[strFldName].ToString());
}
else
{
if (objTeachingCaseResCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachingCaseResCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingCaseResCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachingCaseResCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachingCaseResCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachingCaseResCaseCond[strFldName]));
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
List<clsTeachingCaseResCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTeachingCaseResCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTeachingCaseResCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
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
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
public static List<clsTeachingCaseResCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
public static List<clsTeachingCaseResCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachingCaseResCaseEN.IdTeachingCaseResCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTeachingCaseResCase(ref clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
bool bolResult = TeachingCaseResCaseDA.GetTeachingCaseResCase(ref objTeachingCaseResCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingCaseResCaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
{
if (strIdTeachingCaseResCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachingCaseResCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachingCaseResCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = TeachingCaseResCaseDA.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
return objTeachingCaseResCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTeachingCaseResCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = TeachingCaseResCaseDA.GetFirstObj(strWhereCond);
 return objTeachingCaseResCaseEN;
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
public static clsTeachingCaseResCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = TeachingCaseResCaseDA.GetObjByDataRow(objRow);
 return objTeachingCaseResCaseEN;
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
public static clsTeachingCaseResCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = TeachingCaseResCaseDA.GetObjByDataRow(objRow);
 return objTeachingCaseResCaseEN;
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
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <param name = "lstTeachingCaseResCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingCaseResCaseEN GetObjByIdTeachingCaseResCaseFromList(string strIdTeachingCaseResCase, List<clsTeachingCaseResCaseEN> lstTeachingCaseResCaseObjLst)
{
foreach (clsTeachingCaseResCaseEN objTeachingCaseResCaseEN in lstTeachingCaseResCaseObjLst)
{
if (objTeachingCaseResCaseEN.IdTeachingCaseResCase == strIdTeachingCaseResCase)
{
return objTeachingCaseResCaseEN;
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
 string strMaxIdTeachingCaseResCase;
 try
 {
 strMaxIdTeachingCaseResCase = clsTeachingCaseResCaseDA.GetMaxStrId();
 return strMaxIdTeachingCaseResCase;
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
 string strIdTeachingCaseResCase;
 try
 {
 strIdTeachingCaseResCase = new clsTeachingCaseResCaseDA().GetFirstID(strWhereCond);
 return strIdTeachingCaseResCase;
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
 arrList = TeachingCaseResCaseDA.GetID(strWhereCond);
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
bool bolIsExist = TeachingCaseResCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachingCaseResCase)
{
if (string.IsNullOrEmpty(strIdTeachingCaseResCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachingCaseResCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TeachingCaseResCaseDA.IsExist(strIdTeachingCaseResCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdTeachingCaseResCase">教学案例资源案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdTeachingCaseResCase, string strOpUser)
{
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTeachingCaseResCaseEN.UpdUserId = strOpUser;
return clsTeachingCaseResCaseBL.UpdateBySql2(objTeachingCaseResCaseEN);
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
 bolIsExist = clsTeachingCaseResCaseDA.IsExistTable();
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
 bolIsExist = TeachingCaseResCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (objTeachingCaseResCaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学案例资源案例ID = [{0}]的数据已经存在!(in clsTeachingCaseResCaseBL.AddNewRecordBySql2)", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
bool bolResult = TeachingCaseResCaseDA.AddNewRecordBySQL2(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
if (objTeachingCaseResCaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学案例资源案例ID = [{0}]的数据已经存在!(in clsTeachingCaseResCaseBL.AddNewRecordBySql2WithReturnKey)", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true || clsTeachingCaseResCaseBL.IsExist(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
     objTeachingCaseResCaseEN.IdTeachingCaseResCase = clsTeachingCaseResCaseBL.GetMaxStrId_S();
 }
string strKey = TeachingCaseResCaseDA.AddNewRecordBySQL2WithReturnKey(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
bool bolResult = TeachingCaseResCaseDA.Update(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 if (string.IsNullOrEmpty(objTeachingCaseResCaseEN.IdTeachingCaseResCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TeachingCaseResCaseDA.UpdateBySql2(objTeachingCaseResCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingCaseResCaseBL.ReFreshCache(objTeachingCaseResCaseEN.CourseId);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
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
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdTeachingCaseResCase)
{
try
{
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);

if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(objTeachingCaseResCaseEN.IdTeachingCaseResCase, objTeachingCaseResCaseEN.UpdUserId);
}
if (objTeachingCaseResCaseEN != null)
{
int intRecNum = TeachingCaseResCaseDA.DelRecord(strIdTeachingCaseResCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
/// <param name="strIdTeachingCaseResCase">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdTeachingCaseResCase , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
//删除与表:[TeachingCaseResCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTeachingCaseResCase.IdTeachingCaseResCase,
//strIdTeachingCaseResCase);
//        clsTeachingCaseResCaseBL.DelTeachingCaseResCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachingCaseResCaseBL.DelRecord(strIdTeachingCaseResCase, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachingCaseResCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachingCaseResCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdTeachingCaseResCase, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTeachingCaseResCaseBL.relatedActions != null)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(strIdTeachingCaseResCase, "UpdRelaTabDate");
}
bool bolResult = TeachingCaseResCaseDA.DelRecord(strIdTeachingCaseResCase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdTeachingCaseResCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTeachingCaseResCases(List<string> arrIdTeachingCaseResCaseLst)
{
if (arrIdTeachingCaseResCaseLst.Count == 0) return 0;
try
{
if (clsTeachingCaseResCaseBL.relatedActions != null)
{
foreach (var strIdTeachingCaseResCase in arrIdTeachingCaseResCaseLst)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(strIdTeachingCaseResCase, "UpdRelaTabDate");
}
}
 clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = clsTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCase(arrIdTeachingCaseResCaseLst[0]);
int intDelRecNum = TeachingCaseResCaseDA.DelTeachingCaseResCase(arrIdTeachingCaseResCaseLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objTeachingCaseResCaseEN.CourseId);
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
public static int DelTeachingCaseResCasesByCond(string strWhereCond)
{
try
{
if (clsTeachingCaseResCaseBL.relatedActions != null)
{
List<string> arrIdTeachingCaseResCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeachingCaseResCase in arrIdTeachingCaseResCase)
{
clsTeachingCaseResCaseBL.relatedActions.UpdRelaTabDate(strIdTeachingCaseResCase, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conTeachingCaseResCase.CourseId, strWhereCond);
int intRecNum = TeachingCaseResCaseDA.DelTeachingCaseResCase(strWhereCond);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TeachingCaseResCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdTeachingCaseResCase">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdTeachingCaseResCase, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
//删除与表:[TeachingCaseResCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachingCaseResCaseBL.DelRecord(strIdTeachingCaseResCase, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachingCaseResCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachingCaseResCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objTeachingCaseResCaseENT">目标对象</param>
 public static void CopyTo(clsTeachingCaseResCaseEN objTeachingCaseResCaseENS, clsTeachingCaseResCaseEN objTeachingCaseResCaseENT)
{
try
{
objTeachingCaseResCaseENT.IdTeachingCaseResCase = objTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objTeachingCaseResCaseENT.TeachingCaseResCaseID = objTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objTeachingCaseResCaseENT.TeachingCaseResCaseName = objTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objTeachingCaseResCaseENT.TeachingCaseResCaseText = objTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objTeachingCaseResCaseENT.TeachingCaseResCaseDate = objTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTime = objTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objTeachingCaseResCaseENT.IdCaseType = objTeachingCaseResCaseENS.IdCaseType; //案例类型流水号
objTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objTeachingCaseResCaseENT.CourseId = objTeachingCaseResCaseENS.CourseId; //课程Id
objTeachingCaseResCaseENT.OwnerId = objTeachingCaseResCaseENS.OwnerId; //拥有者Id
objTeachingCaseResCaseENT.IdStudyLevel = objTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objTeachingCaseResCaseENT.IdTeachingPlan = objTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objTeachingCaseResCaseENT.IdDiscipline = objTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objTeachingCaseResCaseENT.BrowseCount = objTeachingCaseResCaseENS.BrowseCount; //浏览次数
objTeachingCaseResCaseENT.IdSenateGaugeVersion = objTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objTeachingCaseResCaseENT.IdTeachSkill = objTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objTeachingCaseResCaseENT.CaseLevelId = objTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objTeachingCaseResCaseENT.DocFile = objTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objTeachingCaseResCaseENT.IsNeedGeneWord = objTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objTeachingCaseResCaseENT.WordCreateDate = objTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objTeachingCaseResCaseENT.IsVisible = objTeachingCaseResCaseENS.IsVisible; //是否显示
objTeachingCaseResCaseENT.IsDualVideo = objTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objTeachingCaseResCaseENT.IdXzCollege = objTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objTeachingCaseResCaseENT.IdXzMajor = objTeachingCaseResCaseENS.IdXzMajor; //专业流水号
objTeachingCaseResCaseENT.CourseChapterId = objTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objTeachingCaseResCaseENT.ViewCount = objTeachingCaseResCaseENS.ViewCount; //浏览量
objTeachingCaseResCaseENT.IsShow = objTeachingCaseResCaseENS.IsShow; //是否启用
objTeachingCaseResCaseENT.DownloadNumber = objTeachingCaseResCaseENS.DownloadNumber; //下载数目
objTeachingCaseResCaseENT.FileIntegration = objTeachingCaseResCaseENS.FileIntegration; //文件积分
objTeachingCaseResCaseENT.LikeCount = objTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objTeachingCaseResCaseENT.CollectionCount = objTeachingCaseResCaseENS.CollectionCount; //收藏数量
objTeachingCaseResCaseENT.RecommendedDegreeId = objTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objTeachingCaseResCaseENT.ftpFileType = objTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objTeachingCaseResCaseENT.VideoUrl = objTeachingCaseResCaseENS.VideoUrl; //视频Url
objTeachingCaseResCaseENT.VideoPath = objTeachingCaseResCaseENS.VideoPath; //视频目录
objTeachingCaseResCaseENT.ResErrMsg = objTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objTeachingCaseResCaseENT.UpdDate = objTeachingCaseResCaseENS.UpdDate; //修改日期
objTeachingCaseResCaseENT.UpdUserId = objTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objTeachingCaseResCaseENT.Memo = objTeachingCaseResCaseENS.Memo; //备注
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
 /// <param name = "objTeachingCaseResCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
objTeachingCaseResCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTeachingCaseResCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTeachingCaseResCase.IdTeachingCaseResCase, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objTeachingCaseResCaseEN.IdTeachingCaseResCase; //教学案例资源案例流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID; //教学案例资源案例ID
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName; //教学案例资源案例名称
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseText; //案例文本内容
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseDate; //视频资源日期
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseTime; //视频资源时间
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conTeachingCaseResCase.TeachingCaseResCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn == "[null]" ? null :  objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdCaseType = objTeachingCaseResCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdTeachingCaseResCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.CourseId = objTeachingCaseResCaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conTeachingCaseResCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.OwnerId = objTeachingCaseResCaseEN.OwnerId == "[null]" ? null :  objTeachingCaseResCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel == "[null]" ? null :  objTeachingCaseResCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan == "[null]" ? null :  objTeachingCaseResCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdDiscipline = objTeachingCaseResCaseEN.IdDiscipline == "[null]" ? null :  objTeachingCaseResCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.BrowseCount = objTeachingCaseResCaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objTeachingCaseResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill == "[null]" ? null :  objTeachingCaseResCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.CaseLevelId = objTeachingCaseResCaseEN.CaseLevelId == "[null]" ? null :  objTeachingCaseResCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(conTeachingCaseResCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.DocFile = objTeachingCaseResCaseEN.DocFile == "[null]" ? null :  objTeachingCaseResCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(conTeachingCaseResCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IsNeedGeneWord = objTeachingCaseResCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(conTeachingCaseResCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.WordCreateDate = objTeachingCaseResCaseEN.WordCreateDate == "[null]" ? null :  objTeachingCaseResCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(conTeachingCaseResCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IsVisible = objTeachingCaseResCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conTeachingCaseResCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IsDualVideo = objTeachingCaseResCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdXzCollege = objTeachingCaseResCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IdXzMajor = objTeachingCaseResCaseEN.IdXzMajor == "[null]" ? null :  objTeachingCaseResCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conTeachingCaseResCase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.CourseChapterId = objTeachingCaseResCaseEN.CourseChapterId == "[null]" ? null :  objTeachingCaseResCaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conTeachingCaseResCase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.ViewCount = objTeachingCaseResCaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(conTeachingCaseResCase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.IsShow = objTeachingCaseResCaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conTeachingCaseResCase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.DownloadNumber = objTeachingCaseResCaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(conTeachingCaseResCase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.FileIntegration = objTeachingCaseResCaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(conTeachingCaseResCase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.LikeCount = objTeachingCaseResCaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conTeachingCaseResCase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.CollectionCount = objTeachingCaseResCaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conTeachingCaseResCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.RecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conTeachingCaseResCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.ftpFileType = objTeachingCaseResCaseEN.ftpFileType == "[null]" ? null :  objTeachingCaseResCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conTeachingCaseResCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.VideoUrl = objTeachingCaseResCaseEN.VideoUrl == "[null]" ? null :  objTeachingCaseResCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conTeachingCaseResCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.VideoPath = objTeachingCaseResCaseEN.VideoPath == "[null]" ? null :  objTeachingCaseResCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conTeachingCaseResCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.ResErrMsg = objTeachingCaseResCaseEN.ResErrMsg == "[null]" ? null :  objTeachingCaseResCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conTeachingCaseResCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.UpdDate = objTeachingCaseResCaseEN.UpdDate == "[null]" ? null :  objTeachingCaseResCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTeachingCaseResCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.UpdUserId = objTeachingCaseResCaseEN.UpdUserId == "[null]" ? null :  objTeachingCaseResCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conTeachingCaseResCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachingCaseResCaseEN.Memo = objTeachingCaseResCaseEN.Memo == "[null]" ? null :  objTeachingCaseResCaseEN.Memo; //备注
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
 /// <param name = "objTeachingCaseResCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
try
{
if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = null; //教学案例资源案例主题词
if (objTeachingCaseResCaseEN.TeachingCaseResCaseText == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseText = null; //案例文本内容
if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseDate = null; //视频资源日期
if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseTime = null; //视频资源时间
if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = null; //案例入库日期
if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn == "[null]") objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = null; //案例入库时间
if (objTeachingCaseResCaseEN.OwnerId == "[null]") objTeachingCaseResCaseEN.OwnerId = null; //拥有者Id
if (objTeachingCaseResCaseEN.IdStudyLevel == "[null]") objTeachingCaseResCaseEN.IdStudyLevel = null; //id_StudyLevel
if (objTeachingCaseResCaseEN.IdTeachingPlan == "[null]") objTeachingCaseResCaseEN.IdTeachingPlan = null; //教案流水号
if (objTeachingCaseResCaseEN.IdDiscipline == "[null]") objTeachingCaseResCaseEN.IdDiscipline = null; //学科流水号
if (objTeachingCaseResCaseEN.IdSenateGaugeVersion == "[null]") objTeachingCaseResCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objTeachingCaseResCaseEN.IdTeachSkill == "[null]") objTeachingCaseResCaseEN.IdTeachSkill = null; //教学技能流水号
if (objTeachingCaseResCaseEN.CaseLevelId == "[null]") objTeachingCaseResCaseEN.CaseLevelId = null; //课例等级Id
if (objTeachingCaseResCaseEN.DocFile == "[null]") objTeachingCaseResCaseEN.DocFile = null; //生成的Word文件名
if (objTeachingCaseResCaseEN.WordCreateDate == "[null]") objTeachingCaseResCaseEN.WordCreateDate = null; //Word生成日期
if (objTeachingCaseResCaseEN.IdXzMajor == "[null]") objTeachingCaseResCaseEN.IdXzMajor = null; //专业流水号
if (objTeachingCaseResCaseEN.CourseChapterId == "[null]") objTeachingCaseResCaseEN.CourseChapterId = null; //课程章节ID
if (objTeachingCaseResCaseEN.ftpFileType == "[null]") objTeachingCaseResCaseEN.ftpFileType = null; //ftp文件类型
if (objTeachingCaseResCaseEN.VideoUrl == "[null]") objTeachingCaseResCaseEN.VideoUrl = null; //视频Url
if (objTeachingCaseResCaseEN.VideoPath == "[null]") objTeachingCaseResCaseEN.VideoPath = null; //视频目录
if (objTeachingCaseResCaseEN.ResErrMsg == "[null]") objTeachingCaseResCaseEN.ResErrMsg = null; //资源错误信息
if (objTeachingCaseResCaseEN.UpdDate == "[null]") objTeachingCaseResCaseEN.UpdDate = null; //修改日期
if (objTeachingCaseResCaseEN.UpdUserId == "[null]") objTeachingCaseResCaseEN.UpdUserId = null; //修改用户Id
if (objTeachingCaseResCaseEN.Memo == "[null]") objTeachingCaseResCaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 TeachingCaseResCaseDA.CheckPropertyNew(objTeachingCaseResCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 TeachingCaseResCaseDA.CheckProperty4Condition(objTeachingCaseResCaseEN);
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
if (clsTeachingCaseResCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseBL没有刷新缓存机制(clsTeachingCaseResCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachingCaseResCase");
//if (arrTeachingCaseResCaseObjLstCache == null)
//{
//arrTeachingCaseResCaseObjLstCache = TeachingCaseResCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingCaseResCaseEN GetObjByIdTeachingCaseResCaseCache(string strIdTeachingCaseResCase, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName, strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLst_Sel =
arrTeachingCaseResCaseObjLstCache
.Where(x=> x.IdTeachingCaseResCase == strIdTeachingCaseResCase 
);
if (arrTeachingCaseResCaseObjLst_Sel.Count() == 0)
{
   clsTeachingCaseResCaseEN obj = clsTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCase(strIdTeachingCaseResCase);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdTeachingCaseResCase, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrTeachingCaseResCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetAllTeachingCaseResCaseObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLstCache = GetObjLstCache(strCourseId); 
return arrTeachingCaseResCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingCaseResCaseEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsTeachingCaseResCaseEN> arrTeachingCaseResCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrTeachingCaseResCaseObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTeachingCaseResCaseEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsTeachingCaseResCaseBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TeachingCaseResCase(教学案例资源案例)
 /// 唯一性条件:TeachingCaseResCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检测记录是否存在
string strResult = TeachingCaseResCaseDA.GetUniCondStr(objTeachingCaseResCaseEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdTeachingCaseResCase, string strCourseId)
{
if (strInFldName != conTeachingCaseResCase.IdTeachingCaseResCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTeachingCaseResCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTeachingCaseResCase.AttributeName));
throw new Exception(strMsg);
}
var objTeachingCaseResCase = clsTeachingCaseResCaseBL.GetObjByIdTeachingCaseResCaseCache(strIdTeachingCaseResCase, strCourseId);
if (objTeachingCaseResCase == null) return "";
return objTeachingCaseResCase[strOutFldName].ToString();
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
int intRecCount = clsTeachingCaseResCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsTeachingCaseResCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTeachingCaseResCaseDA.GetRecCount();
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
int intRecCount = clsTeachingCaseResCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTeachingCaseResCaseEN objTeachingCaseResCaseCond)
{
 string strCourseId = objTeachingCaseResCaseCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsTeachingCaseResCaseBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsTeachingCaseResCaseEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsTeachingCaseResCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachingCaseResCase.AttributeName)
{
if (objTeachingCaseResCaseCond.IsUpdated(strFldName) == false) continue;
if (objTeachingCaseResCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingCaseResCaseCond[strFldName].ToString());
}
else
{
if (objTeachingCaseResCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachingCaseResCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachingCaseResCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachingCaseResCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachingCaseResCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachingCaseResCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachingCaseResCaseCond[strFldName]));
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
 List<string> arrList = clsTeachingCaseResCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TeachingCaseResCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TeachingCaseResCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TeachingCaseResCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachingCaseResCaseDA.SetFldValue(clsTeachingCaseResCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TeachingCaseResCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachingCaseResCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachingCaseResCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachingCaseResCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TeachingCaseResCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**教学案例资源案例流水号*/ 
 strCreateTabCode.Append(" IdTeachingCaseResCase char(8) primary key, "); 
 // /**教学案例资源案例ID*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseID char(8) not Null, "); 
 // /**教学案例资源案例名称*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseName varchar(100) not Null, "); 
 // /**教学案例资源案例主题词*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseTheme varchar(200) Null, "); 
 // /**案例文本内容*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseText varchar(8000) Null, "); 
 // /**视频资源日期*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseDate char(8) Null, "); 
 // /**视频资源时间*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseTime char(6) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseDateIn char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" TeachingCaseResCaseTimeIn char(6) Null, "); 
 // /**案例类型流水号*/ 
 strCreateTabCode.Append(" IdCaseType char(4) not Null, "); 
 // /**教学案例资源类型流水号*/ 
 strCreateTabCode.Append(" IdTeachingCaseResCaseType char(4) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) Null, "); 
 // /**id_StudyLevel*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) Null, "); 
 // /**教学技能流水号*/ 
 strCreateTabCode.Append(" IdTeachSkill char(8) Null, "); 
 // /**课例等级Id*/ 
 strCreateTabCode.Append(" CaseLevelId char(2) Null, "); 
 // /**生成的Word文件名*/ 
 strCreateTabCode.Append(" DocFile varchar(200) Null, "); 
 // /**是否需要生成Word*/ 
 strCreateTabCode.Append(" IsNeedGeneWord bit Null, "); 
 // /**Word生成日期*/ 
 strCreateTabCode.Append(" WordCreateDate varchar(14) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) not Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**下载数目*/ 
 strCreateTabCode.Append(" DownloadNumber int Null, "); 
 // /**文件积分*/ 
 strCreateTabCode.Append(" FileIntegration int Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**推荐度Id*/ 
 strCreateTabCode.Append(" RecommendedDegreeId char(2) not Null, "); 
 // /**ftp文件类型*/ 
 strCreateTabCode.Append(" ftpFileType varchar(30) Null, "); 
 // /**视频Url*/ 
 strCreateTabCode.Append(" VideoUrl varchar(1000) Null, "); 
 // /**视频目录*/ 
 strCreateTabCode.Append(" VideoPath varchar(1000) Null, "); 
 // /**资源错误信息*/ 
 strCreateTabCode.Append(" ResErrMsg varchar(30) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**案例类型名称*/ 
 strCreateTabCode.Append(" CaseTypeName varchar(50) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**章名*/ 
 strCreateTabCode.Append(" ChapterName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 教学案例资源案例(TeachingCaseResCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TeachingCaseResCase : clsCommFun4BLV2
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
clsTeachingCaseResCaseBL.ReFreshThisCache(strCourseId);
}
}

}