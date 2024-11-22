
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDirectionBL
 表名:XzMajorDirection(01120552)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:10
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
public static class  clsXzMajorDirectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorDirectionEN GetObj(this K_MajorDirectionId_XzMajorDirection myKey)
{
clsXzMajorDirectionEN objXzMajorDirectionEN = clsXzMajorDirectionBL.XzMajorDirectionDA.GetObjByMajorDirectionId(myKey.Value);
return objXzMajorDirectionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorDirectionEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}],研究方向名 = [{1}]的数据已经存在!(in clsXzMajorDirectionBL.AddNewRecord)", objXzMajorDirectionEN.IdXzMajor,objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
bool bolResult = clsXzMajorDirectionBL.XzMajorDirectionDA.AddNewRecordBySQL2(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
public static bool AddRecordEx(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objXzMajorDirectionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objXzMajorDirectionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(专业流水号(IdXzMajor)=[{0}],研究方向名(MajorDirectionName)=[{1}])已经存在,不能重复!", objXzMajorDirectionEN.IdXzMajor, objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objXzMajorDirectionEN.AddNewRecord();
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorDirectionEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}],研究方向名 = [{1}]的数据已经存在!(in clsXzMajorDirectionBL.AddNewRecordWithMaxId)", objXzMajorDirectionEN.IdXzMajor,objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
string strMajorDirectionId = clsXzMajorDirectionBL.XzMajorDirectionDA.AddNewRecordBySQL2WithReturnKey(objXzMajorDirectionEN);
     objXzMajorDirectionEN.MajorDirectionId = strMajorDirectionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
}
return strMajorDirectionId;
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzMajorDirectionEN) == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}],研究方向名 = [{1}]的数据已经存在!(in clsXzMajorDirectionBL.AddNewRecordWithReturnKey)", objXzMajorDirectionEN.IdXzMajor,objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
string strKey = clsXzMajorDirectionBL.XzMajorDirectionDA.AddNewRecordBySQL2WithReturnKey(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionId(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
}
objXzMajorDirectionEN.MajorDirectionId = strMajorDirectionId; //研究方向Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionId) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionId, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionId] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetIdXzMajor(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, conXzMajorDirection.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conXzMajorDirection.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conXzMajorDirection.IdXzMajor);
}
objXzMajorDirectionEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.IdXzMajor) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.IdXzMajor, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.IdXzMajor] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionName(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorDirectionName, conXzMajorDirection.MajorDirectionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionName, 100, conXzMajorDirection.MajorDirectionName);
}
objXzMajorDirectionEN.MajorDirectionName = strMajorDirectionName; //研究方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionName) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionName, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionName] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionENName(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionENName, 200, conXzMajorDirection.MajorDirectionENName);
}
objXzMajorDirectionEN.MajorDirectionENName = strMajorDirectionENName; //研究方向英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionENName) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionENName, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionENName] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionExplain(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionExplain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirectionExplain, 2000, conXzMajorDirection.MajorDirectionExplain);
}
objXzMajorDirectionEN.MajorDirectionExplain = strMajorDirectionExplain; //专业方向说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionExplain) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionExplain, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionExplain] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetIsVisible(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsVisible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisible, conXzMajorDirection.IsVisible);
objXzMajorDirectionEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.IsVisible) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.IsVisible, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.IsVisible] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetUpdDate(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzMajorDirection.UpdDate);
}
objXzMajorDirectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.UpdDate) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.UpdDate, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.UpdDate] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetUpdUser(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conXzMajorDirection.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conXzMajorDirection.UpdUser);
}
objXzMajorDirectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.UpdUser) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.UpdUser, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.UpdUser] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzMajorDirectionEN SetMemo(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzMajorDirection.Memo);
}
objXzMajorDirectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.Memo) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.Memo, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.Memo] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzMajorDirectionEN.CheckPropertyNew();
clsXzMajorDirectionEN objXzMajorDirectionCond = new clsXzMajorDirectionEN();
string strCondition = objXzMajorDirectionCond
.SetMajorDirectionId(objXzMajorDirectionEN.MajorDirectionId, "<>")
.SetIdXzMajor(objXzMajorDirectionEN.IdXzMajor, "=")
.SetMajorDirectionName(objXzMajorDirectionEN.MajorDirectionName, "=")
.GetCombineCondition();
objXzMajorDirectionEN._IsCheckProperty = true;
bool bolIsExist = clsXzMajorDirectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_XzMajor_MajorDirectionName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzMajorDirectionEN.Update();
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
 /// <param name = "objXzMajorDirection">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsXzMajorDirectionEN objXzMajorDirection)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsXzMajorDirectionEN objXzMajorDirectionCond = new clsXzMajorDirectionEN();
string strCondition = objXzMajorDirectionCond
.SetIdXzMajor(objXzMajorDirection.IdXzMajor, "=")
.SetMajorDirectionName(objXzMajorDirection.MajorDirectionName, "=")
.GetCombineCondition();
objXzMajorDirection._IsCheckProperty = true;
bool bolIsExist = clsXzMajorDirectionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objXzMajorDirection.MajorDirectionId = clsXzMajorDirectionBL.GetFirstID_S(strCondition);
objXzMajorDirection.UpdateWithCondition(strCondition);
}
else
{
objXzMajorDirection.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
objXzMajorDirection.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorDirectionBL.XzMajorDirectionDA.UpdateBySql2(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorDirectionEN objXzMajorDirectionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorDirectionBL.XzMajorDirectionDA.UpdateBySql2(objXzMajorDirectionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strWhereCond)
{
try
{
bool bolResult = clsXzMajorDirectionBL.XzMajorDirectionDA.UpdateBySqlWithCondition(objXzMajorDirectionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzMajorDirectionBL.XzMajorDirectionDA.UpdateBySqlWithConditionTransaction(objXzMajorDirectionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
int intRecNum = clsXzMajorDirectionBL.XzMajorDirectionDA.DelRecord(objXzMajorDirectionEN.MajorDirectionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <param name = "objXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(this clsXzMajorDirectionEN objXzMajorDirectionENS, clsXzMajorDirectionEN objXzMajorDirectionENT)
{
try
{
objXzMajorDirectionENT.MajorDirectionId = objXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objXzMajorDirectionENT.IdXzMajor = objXzMajorDirectionENS.IdXzMajor; //专业流水号
objXzMajorDirectionENT.MajorDirectionName = objXzMajorDirectionENS.MajorDirectionName; //研究方向名
objXzMajorDirectionENT.MajorDirectionENName = objXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objXzMajorDirectionENT.MajorDirectionExplain = objXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objXzMajorDirectionENT.IsVisible = objXzMajorDirectionENS.IsVisible; //是否显示
objXzMajorDirectionENT.UpdDate = objXzMajorDirectionENS.UpdDate; //修改日期
objXzMajorDirectionENT.UpdUser = objXzMajorDirectionENS.UpdUser; //修改人
objXzMajorDirectionENT.Memo = objXzMajorDirectionENS.Memo; //备注
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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <returns>目标对象=>clsXzMajorDirectionEN:objXzMajorDirectionENT</returns>
 public static clsXzMajorDirectionEN CopyTo(this clsXzMajorDirectionEN objXzMajorDirectionENS)
{
try
{
 clsXzMajorDirectionEN objXzMajorDirectionENT = new clsXzMajorDirectionEN()
{
MajorDirectionId = objXzMajorDirectionENS.MajorDirectionId, //研究方向Id
IdXzMajor = objXzMajorDirectionENS.IdXzMajor, //专业流水号
MajorDirectionName = objXzMajorDirectionENS.MajorDirectionName, //研究方向名
MajorDirectionENName = objXzMajorDirectionENS.MajorDirectionENName, //研究方向英文名
MajorDirectionExplain = objXzMajorDirectionENS.MajorDirectionExplain, //专业方向说明
IsVisible = objXzMajorDirectionENS.IsVisible, //是否显示
UpdDate = objXzMajorDirectionENS.UpdDate, //修改日期
UpdUser = objXzMajorDirectionENS.UpdUser, //修改人
Memo = objXzMajorDirectionENS.Memo, //备注
};
 return objXzMajorDirectionENT;
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
public static void CheckPropertyNew(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 clsXzMajorDirectionBL.XzMajorDirectionDA.CheckPropertyNew(objXzMajorDirectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 clsXzMajorDirectionBL.XzMajorDirectionDA.CheckProperty4Condition(objXzMajorDirectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzMajorDirectionEN objXzMajorDirectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.MajorDirectionId) == true)
{
string strComparisonOpMajorDirectionId = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionId, objXzMajorDirectionCond.MajorDirectionId, strComparisonOpMajorDirectionId);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.IdXzMajor, objXzMajorDirectionCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.MajorDirectionName) == true)
{
string strComparisonOpMajorDirectionName = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionName, objXzMajorDirectionCond.MajorDirectionName, strComparisonOpMajorDirectionName);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.MajorDirectionENName) == true)
{
string strComparisonOpMajorDirectionENName = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionENName, objXzMajorDirectionCond.MajorDirectionENName, strComparisonOpMajorDirectionENName);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.MajorDirectionExplain) == true)
{
string strComparisonOpMajorDirectionExplain = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionExplain, objXzMajorDirectionCond.MajorDirectionExplain, strComparisonOpMajorDirectionExplain);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.IsVisible) == true)
{
if (objXzMajorDirectionCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajorDirection.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajorDirection.IsVisible);
}
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.UpdDate) == true)
{
string strComparisonOpUpdDate = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.UpdDate, objXzMajorDirectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.UpdUser) == true)
{
string strComparisonOpUpdUser = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.UpdUser, objXzMajorDirectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objXzMajorDirectionCond.IsUpdated(conXzMajorDirection.Memo) == true)
{
string strComparisonOpMemo = objXzMajorDirectionCond.dicFldComparisonOp[conXzMajorDirection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.Memo, objXzMajorDirectionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajorDirection(专业方向), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_XzMajor_MajorDirectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorDirectionEN == null) return true;
if (objXzMajorDirectionEN.MajorDirectionId == null || objXzMajorDirectionEN.MajorDirectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorDirectionEN.IdXzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
if (clsXzMajorDirectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MajorDirectionId !=  '{0}'", objXzMajorDirectionEN.MajorDirectionId);
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorDirectionEN.IdXzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
if (clsXzMajorDirectionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--XzMajorDirection(专业方向), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_XzMajor_MajorDirectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorDirectionEN == null) return "";
if (objXzMajorDirectionEN.MajorDirectionId == null || objXzMajorDirectionEN.MajorDirectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorDirectionEN.IdXzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MajorDirectionId !=  '{0}'", objXzMajorDirectionEN.MajorDirectionId);
 sbCondition.AppendFormat(" and IdXzMajor = '{0}'", objXzMajorDirectionEN.IdXzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzMajorDirection
{
public virtual bool UpdRelaTabDate(string strMajorDirectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumXzMajorDirection
{
 /// <summary>
 /// testlyl
 /// </summary>
public const string testlyl_00000001 = "00000001";
 /// <summary>
 /// test0118
 /// </summary>
public const string test_00000003 = "00000003";
 /// <summary>
 /// 杨雪姣
 /// </summary>
public const string Lucy_00000004 = "00000004";
 /// <summary>
 /// 信息化教育
 /// </summary>
public const string InformationTechnology_00000005 = "00000005";
 /// <summary>
 /// 绩效培训
 /// </summary>
public const string PerformanceTraining_00000006 = "00000006";
 /// <summary>
 /// 网络方向
 /// </summary>
public const string NetworkingDirection_00000007 = "00000007";
 /// <summary>
 /// 数字媒体
 /// </summary>
public const string DigitalMedia_00000008 = "00000008";
 /// <summary>
 /// 自适应学习与个性化学习
 /// </summary>
public const string AdaptiveLearningAndPersonalizedLearning_00000009 = "00000009";
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzMajorDirectionBL
{
public static RelatedActions_XzMajorDirection relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzMajorDirectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzMajorDirectionDA XzMajorDirectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzMajorDirectionDA();
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
 public clsXzMajorDirectionBL()
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
if (string.IsNullOrEmpty(clsXzMajorDirectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzMajorDirectionEN._ConnectString);
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
public static DataTable GetDataTable_XzMajorDirection(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzMajorDirectionDA.GetDataTable_XzMajorDirection(strWhereCond);
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
objDT = XzMajorDirectionDA.GetDataTable(strWhereCond);
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
objDT = XzMajorDirectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzMajorDirectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzMajorDirectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzMajorDirectionDA.GetDataTable_Top(objTopPara);
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
objDT = XzMajorDirectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzMajorDirectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzMajorDirectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMajorDirectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst(List<string> arrMajorDirectionIdLst)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMajorDirectionIdLst, true);
 string strWhereCond = string.Format("MajorDirectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMajorDirectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzMajorDirectionEN> GetObjLstByMajorDirectionIdLstCache(List<string> arrMajorDirectionIdLst)
{
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel =
arrXzMajorDirectionObjLstCache
.Where(x => arrMajorDirectionIdLst.Contains(x.MajorDirectionId));
return arrXzMajorDirectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLst(string strWhereCond)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
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
public static List<clsXzMajorDirectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzMajorDirectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzMajorDirectionEN> GetSubObjLstCache(clsXzMajorDirectionEN objXzMajorDirectionCond)
{
List<clsXzMajorDirectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorDirectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzMajorDirection.AttributeName)
{
if (objXzMajorDirectionCond.IsUpdated(strFldName) == false) continue;
if (objXzMajorDirectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorDirectionCond[strFldName].ToString());
}
else
{
if (objXzMajorDirectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajorDirectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorDirectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajorDirectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajorDirectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajorDirectionCond[strFldName]));
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
public static List<clsXzMajorDirectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
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
public static List<clsXzMajorDirectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
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
List<clsXzMajorDirectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzMajorDirectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorDirectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzMajorDirectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
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
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
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
public static List<clsXzMajorDirectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzMajorDirectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
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
public static List<clsXzMajorDirectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzMajorDirectionEN> arrObjLst = new List<clsXzMajorDirectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN();
try
{
objXzMajorDirectionEN.MajorDirectionId = objRow[conXzMajorDirection.MajorDirectionId].ToString().Trim(); //研究方向Id
objXzMajorDirectionEN.IdXzMajor = objRow[conXzMajorDirection.IdXzMajor].ToString().Trim(); //专业流水号
objXzMajorDirectionEN.MajorDirectionName = objRow[conXzMajorDirection.MajorDirectionName].ToString().Trim(); //研究方向名
objXzMajorDirectionEN.MajorDirectionENName = objRow[conXzMajorDirection.MajorDirectionENName] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objXzMajorDirectionEN.MajorDirectionExplain = objRow[conXzMajorDirection.MajorDirectionExplain] == DBNull.Value ? null : objRow[conXzMajorDirection.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objXzMajorDirectionEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzMajorDirection.IsVisible].ToString().Trim()); //是否显示
objXzMajorDirectionEN.UpdDate = objRow[conXzMajorDirection.UpdDate] == DBNull.Value ? null : objRow[conXzMajorDirection.UpdDate].ToString().Trim(); //修改日期
objXzMajorDirectionEN.UpdUser = objRow[conXzMajorDirection.UpdUser].ToString().Trim(); //修改人
objXzMajorDirectionEN.Memo = objRow[conXzMajorDirection.Memo] == DBNull.Value ? null : objRow[conXzMajorDirection.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorDirectionEN.MajorDirectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorDirectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzMajorDirection(ref clsXzMajorDirectionEN objXzMajorDirectionEN)
{
bool bolResult = XzMajorDirectionDA.GetXzMajorDirection(ref objXzMajorDirectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
if (strMajorDirectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMajorDirectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMajorDirectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMajorDirectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzMajorDirectionEN objXzMajorDirectionEN = XzMajorDirectionDA.GetObjByMajorDirectionId(strMajorDirectionId);
return objXzMajorDirectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzMajorDirectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzMajorDirectionEN objXzMajorDirectionEN = XzMajorDirectionDA.GetFirstObj(strWhereCond);
 return objXzMajorDirectionEN;
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
public static clsXzMajorDirectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzMajorDirectionEN objXzMajorDirectionEN = XzMajorDirectionDA.GetObjByDataRow(objRow);
 return objXzMajorDirectionEN;
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
public static clsXzMajorDirectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzMajorDirectionEN objXzMajorDirectionEN = XzMajorDirectionDA.GetObjByDataRow(objRow);
 return objXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <param name = "lstXzMajorDirectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionIdFromList(string strMajorDirectionId, List<clsXzMajorDirectionEN> lstXzMajorDirectionObjLst)
{
foreach (clsXzMajorDirectionEN objXzMajorDirectionEN in lstXzMajorDirectionObjLst)
{
if (objXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId)
{
return objXzMajorDirectionEN;
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
 string strMaxMajorDirectionId;
 try
 {
 strMaxMajorDirectionId = clsXzMajorDirectionDA.GetMaxStrId();
 return strMaxMajorDirectionId;
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
 string strMajorDirectionId;
 try
 {
 strMajorDirectionId = new clsXzMajorDirectionDA().GetFirstID(strWhereCond);
 return strMajorDirectionId;
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
 arrList = XzMajorDirectionDA.GetID(strWhereCond);
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
bool bolIsExist = XzMajorDirectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMajorDirectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzMajorDirectionDA.IsExist(strMajorDirectionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strMajorDirectionId">研究方向Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strMajorDirectionId, string strOpUser)
{
clsXzMajorDirectionEN objXzMajorDirectionEN = clsXzMajorDirectionBL.GetObjByMajorDirectionId(strMajorDirectionId);
objXzMajorDirectionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objXzMajorDirectionEN.UpdUser = strOpUser;
return clsXzMajorDirectionBL.UpdateBySql2(objXzMajorDirectionEN);
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
 bolIsExist = clsXzMajorDirectionDA.IsExistTable();
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
 bolIsExist = XzMajorDirectionDA.IsExistTable(strTabName);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzMajorDirectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}],研究方向名 = [{1}]的数据已经存在!(in clsXzMajorDirectionBL.AddNewRecordBySql2)", objXzMajorDirectionEN.IdXzMajor,objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
bool bolResult = XzMajorDirectionDA.AddNewRecordBySQL2(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzMajorDirectionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!专业流水号 = [{0}],研究方向名 = [{1}]的数据已经存在!(in clsXzMajorDirectionBL.AddNewRecordBySql2WithReturnKey)", objXzMajorDirectionEN.IdXzMajor,objXzMajorDirectionEN.MajorDirectionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionBL.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionBL.GetMaxStrId_S();
 }
string strKey = XzMajorDirectionDA.AddNewRecordBySQL2WithReturnKey(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
bool bolResult = XzMajorDirectionDA.Update(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzMajorDirectionDA.UpdateBySql2(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionBL.ReFreshCache();

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
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
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strMajorDirectionId)
{
try
{
 clsXzMajorDirectionEN objXzMajorDirectionEN = clsXzMajorDirectionBL.GetObjByMajorDirectionId(strMajorDirectionId);

if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(objXzMajorDirectionEN.MajorDirectionId, objXzMajorDirectionEN.UpdUser);
}
if (objXzMajorDirectionEN != null)
{
int intRecNum = XzMajorDirectionDA.DelRecord(strMajorDirectionId);
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
/// <param name="strMajorDirectionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strMajorDirectionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
//删除与表:[XzMajorDirection]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzMajorDirection.MajorDirectionId,
//strMajorDirectionId);
//        clsXzMajorDirectionBL.DelXzMajorDirectionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorDirectionBL.DelRecord(strMajorDirectionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorDirectionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMajorDirectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strMajorDirectionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strMajorDirectionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzMajorDirectionBL.relatedActions != null)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(strMajorDirectionId, "UpdRelaTabDate");
}
bool bolResult = XzMajorDirectionDA.DelRecord(strMajorDirectionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrMajorDirectionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzMajorDirections(List<string> arrMajorDirectionIdLst)
{
if (arrMajorDirectionIdLst.Count == 0) return 0;
try
{
if (clsXzMajorDirectionBL.relatedActions != null)
{
foreach (var strMajorDirectionId in arrMajorDirectionIdLst)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(strMajorDirectionId, "UpdRelaTabDate");
}
}
int intDelRecNum = XzMajorDirectionDA.DelXzMajorDirection(arrMajorDirectionIdLst);
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
public static int DelXzMajorDirectionsByCond(string strWhereCond)
{
try
{
if (clsXzMajorDirectionBL.relatedActions != null)
{
List<string> arrMajorDirectionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMajorDirectionId in arrMajorDirectionId)
{
clsXzMajorDirectionBL.relatedActions.UpdRelaTabDate(strMajorDirectionId, "UpdRelaTabDate");
}
}
int intRecNum = XzMajorDirectionDA.DelXzMajorDirection(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzMajorDirection]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strMajorDirectionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strMajorDirectionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDirectionDA.GetSpecSQLObj();
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
//删除与表:[XzMajorDirection]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorDirectionBL.DelRecord(strMajorDirectionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorDirectionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strMajorDirectionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <param name = "objXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(clsXzMajorDirectionEN objXzMajorDirectionENS, clsXzMajorDirectionEN objXzMajorDirectionENT)
{
try
{
objXzMajorDirectionENT.MajorDirectionId = objXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objXzMajorDirectionENT.IdXzMajor = objXzMajorDirectionENS.IdXzMajor; //专业流水号
objXzMajorDirectionENT.MajorDirectionName = objXzMajorDirectionENS.MajorDirectionName; //研究方向名
objXzMajorDirectionENT.MajorDirectionENName = objXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objXzMajorDirectionENT.MajorDirectionExplain = objXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objXzMajorDirectionENT.IsVisible = objXzMajorDirectionENS.IsVisible; //是否显示
objXzMajorDirectionENT.UpdDate = objXzMajorDirectionENS.UpdDate; //修改日期
objXzMajorDirectionENT.UpdUser = objXzMajorDirectionENS.UpdUser; //修改人
objXzMajorDirectionENT.Memo = objXzMajorDirectionENS.Memo; //备注
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
 /// <param name = "objXzMajorDirectionEN">源简化对象</param>
 public static void SetUpdFlag(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
objXzMajorDirectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzMajorDirectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzMajorDirection.MajorDirectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.MajorDirectionId = objXzMajorDirectionEN.MajorDirectionId; //研究方向Id
}
if (arrFldSet.Contains(conXzMajorDirection.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.IdXzMajor = objXzMajorDirectionEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conXzMajorDirection.MajorDirectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.MajorDirectionName = objXzMajorDirectionEN.MajorDirectionName; //研究方向名
}
if (arrFldSet.Contains(conXzMajorDirection.MajorDirectionENName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.MajorDirectionENName = objXzMajorDirectionEN.MajorDirectionENName == "[null]" ? null :  objXzMajorDirectionEN.MajorDirectionENName; //研究方向英文名
}
if (arrFldSet.Contains(conXzMajorDirection.MajorDirectionExplain, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.MajorDirectionExplain = objXzMajorDirectionEN.MajorDirectionExplain == "[null]" ? null :  objXzMajorDirectionEN.MajorDirectionExplain; //专业方向说明
}
if (arrFldSet.Contains(conXzMajorDirection.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.IsVisible = objXzMajorDirectionEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conXzMajorDirection.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.UpdDate = objXzMajorDirectionEN.UpdDate == "[null]" ? null :  objXzMajorDirectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conXzMajorDirection.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.UpdUser = objXzMajorDirectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conXzMajorDirection.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorDirectionEN.Memo = objXzMajorDirectionEN.Memo == "[null]" ? null :  objXzMajorDirectionEN.Memo; //备注
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
 /// <param name = "objXzMajorDirectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
if (objXzMajorDirectionEN.MajorDirectionENName == "[null]") objXzMajorDirectionEN.MajorDirectionENName = null; //研究方向英文名
if (objXzMajorDirectionEN.MajorDirectionExplain == "[null]") objXzMajorDirectionEN.MajorDirectionExplain = null; //专业方向说明
if (objXzMajorDirectionEN.UpdDate == "[null]") objXzMajorDirectionEN.UpdDate = null; //修改日期
if (objXzMajorDirectionEN.Memo == "[null]") objXzMajorDirectionEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 XzMajorDirectionDA.CheckPropertyNew(objXzMajorDirectionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 XzMajorDirectionDA.CheckProperty4Condition(objXzMajorDirectionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MajorDirectionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业方向]...","0");
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst = GetAllXzMajorDirectionObjLstCache(); 
objDDL.DataValueField = conXzMajorDirection.MajorDirectionId;
objDDL.DataTextField = conXzMajorDirection.MajorDirectionName;
objDDL.DataSource = arrXzMajorDirectionObjLst;
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
if (clsXzMajorDirectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorDirectionBL没有刷新缓存机制(clsXzMajorDirectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MajorDirectionId");
//if (arrXzMajorDirectionObjLstCache == null)
//{
//arrXzMajorDirectionObjLstCache = XzMajorDirectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionIdCache(string strMajorDirectionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel =
arrXzMajorDirectionObjLstCache
.Where(x=> x.MajorDirectionId == strMajorDirectionId 
);
if (arrXzMajorDirectionObjLst_Sel.Count() == 0)
{
   clsXzMajorDirectionEN obj = clsXzMajorDirectionBL.GetObjByMajorDirectionId(strMajorDirectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzMajorDirectionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorDirectionNameByMajorDirectionIdCache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return "";
//获取缓存中的对象列表
clsXzMajorDirectionEN objXzMajorDirection = GetObjByMajorDirectionIdCache(strMajorDirectionId);
if (objXzMajorDirection == null) return "";
return objXzMajorDirection.MajorDirectionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMajorDirectionIdCache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return "";
//获取缓存中的对象列表
clsXzMajorDirectionEN objXzMajorDirection = GetObjByMajorDirectionIdCache(strMajorDirectionId);
if (objXzMajorDirection == null) return "";
return objXzMajorDirection.MajorDirectionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorDirectionEN> GetAllXzMajorDirectionObjLstCache()
{
//获取缓存中的对象列表
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLstCache = GetObjLstCache(); 
return arrXzMajorDirectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzMajorDirectionObjLstCache;
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
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzMajorDirectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzMajorDirectionEN._RefreshTimeLst.Count == 0) return "";
return clsXzMajorDirectionEN._RefreshTimeLst[clsXzMajorDirectionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzMajorDirectionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzMajorDirectionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzMajorDirectionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzMajorDirection(专业方向)
 /// 唯一性条件:id_XzMajor_MajorDirectionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检测记录是否存在
string strResult = XzMajorDirectionDA.GetUniCondStr(objXzMajorDirectionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strMajorDirectionId)
{
if (strInFldName != conXzMajorDirection.MajorDirectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzMajorDirection.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzMajorDirection.AttributeName));
throw new Exception(strMsg);
}
var objXzMajorDirection = clsXzMajorDirectionBL.GetObjByMajorDirectionIdCache(strMajorDirectionId);
if (objXzMajorDirection == null) return "";
return objXzMajorDirection[strOutFldName].ToString();
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
int intRecCount = clsXzMajorDirectionDA.GetRecCount(strTabName);
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
int intRecCount = clsXzMajorDirectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzMajorDirectionDA.GetRecCount();
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
int intRecCount = clsXzMajorDirectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzMajorDirectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzMajorDirectionEN objXzMajorDirectionCond)
{
List<clsXzMajorDirectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzMajorDirectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzMajorDirection.AttributeName)
{
if (objXzMajorDirectionCond.IsUpdated(strFldName) == false) continue;
if (objXzMajorDirectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorDirectionCond[strFldName].ToString());
}
else
{
if (objXzMajorDirectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajorDirectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzMajorDirectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajorDirectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajorDirectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajorDirectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajorDirectionCond[strFldName]));
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
 List<string> arrList = clsXzMajorDirectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDirectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDirectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzMajorDirectionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDirectionDA.SetFldValue(clsXzMajorDirectionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzMajorDirectionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDirectionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDirectionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDirectionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzMajorDirection] "); 
 strCreateTabCode.Append(" ( "); 
 // /**研究方向Id*/ 
 strCreateTabCode.Append(" MajorDirectionId char(8) primary key, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) not Null, "); 
 // /**研究方向名*/ 
 strCreateTabCode.Append(" MajorDirectionName varchar(100) not Null, "); 
 // /**研究方向英文名*/ 
 strCreateTabCode.Append(" MajorDirectionENName varchar(200) Null, "); 
 // /**专业方向说明*/ 
 strCreateTabCode.Append(" MajorDirectionExplain varchar(2000) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzMajorDirection : clsCommFun4BL
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
clsXzMajorDirectionBL.ReFreshThisCache();
}
}

}