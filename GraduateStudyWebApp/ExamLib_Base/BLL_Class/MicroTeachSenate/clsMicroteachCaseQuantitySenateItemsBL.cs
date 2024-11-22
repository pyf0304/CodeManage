
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseQuantitySenateItemsBL
 表名:MicroteachCaseQuantitySenateItems(01120492)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:51
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
public static class  clsMicroteachCaseQuantitySenateItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetObj(this K_IdmicroteachCaseQuantitySenateItem_MicroteachCaseQuantitySenateItems myKey)
{
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.GetObjByIdmicroteachCaseQuantitySenateItem(myKey.Value);
return objMicroteachCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (CheckUniqueness(objMicroteachCaseQuantitySenateItemsEN) == false)
{
var strMsg = string.Format("记录已经存在!微格量化评价流水号 = [{0}],量表指标流水号 = [{1}]的数据已经存在!(in clsMicroteachCaseQuantitySenateItemsBL.AddNewRecord)", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate,objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.AddNewRecordBySQL2(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
public static bool AddRecordEx(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
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
objMicroteachCaseQuantitySenateItemsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objMicroteachCaseQuantitySenateItemsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(微格量化评价流水号(IdmicroteachCaseQuantitySenate)=[{0}],量表指标流水号(IdSenateGaugeItem)=[{1}])已经存在,不能重复!", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate, objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objMicroteachCaseQuantitySenateItemsEN.AddNewRecord();
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (CheckUniqueness(objMicroteachCaseQuantitySenateItemsEN) == false)
{
var strMsg = string.Format("记录已经存在!微格量化评价流水号 = [{0}],量表指标流水号 = [{1}]的数据已经存在!(in clsMicroteachCaseQuantitySenateItemsBL.AddNewRecordWithReturnKey)", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate,objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
throw new Exception(strMsg);
}
try
{
string strKey = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIdmicroteachCaseQuantitySenateItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, long lngIdmicroteachCaseQuantitySenateItem, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = lngIdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIdmicroteachCaseQuantitySenate(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngIdmicroteachCaseQuantitySenate, conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetSenateScore(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, float? fltSenateScore, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.SenateScore = fltSenateScore; //指标得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.SenateScore) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.SenateScore, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.SenateScore] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIdSenateGaugeItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIdSenateGaugeSubItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strIdSenateGaugeSubItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeSubItem, 4, conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeSubItem, 4, conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = strIdSenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIsAccess(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, bool bolIsAccess, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IsAccess) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IsAccess, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IsAccess] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIsAccessC(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, bool bolIsAccessC, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IsAccessC) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IsAccessC, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IsAccessC] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetUpdDate(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroteachCaseQuantitySenateItems.UpdDate);
}
objMicroteachCaseQuantitySenateItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.UpdDate) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.UpdDate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdDate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetUpdUser(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conMicroteachCaseQuantitySenateItems.UpdUser);
}
objMicroteachCaseQuantitySenateItemsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.UpdUser) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.UpdUser, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdUser] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachCaseQuantitySenateItemsEN.CheckPropertyNew();
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsCond = new clsMicroteachCaseQuantitySenateItemsEN();
string strCondition = objMicroteachCaseQuantitySenateItemsCond
.SetIdmicroteachCaseQuantitySenateItem(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, "<>")
.SetIdmicroteachCaseQuantitySenate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate, "=")
.SetIdSenateGaugeItem(objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem, "=")
.GetCombineCondition();
objMicroteachCaseQuantitySenateItemsEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseQuantitySenateItemsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_microteachCaseQuantitySenate_id_SenateGaugeItem)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachCaseQuantitySenateItemsEN.Update();
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
 /// <param name = "objMicroteachCaseQuantitySenateItems">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItems)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsCond = new clsMicroteachCaseQuantitySenateItemsEN();
string strCondition = objMicroteachCaseQuantitySenateItemsCond
.SetIdmicroteachCaseQuantitySenate(objMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, "=")
.SetIdSenateGaugeItem(objMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, "=")
.GetCombineCondition();
objMicroteachCaseQuantitySenateItems._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseQuantitySenateItemsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem = clsMicroteachCaseQuantitySenateItemsBL.GetFirstID_S(strCondition);
objMicroteachCaseQuantitySenateItems.UpdateWithCondition(strCondition);
}
else
{
objMicroteachCaseQuantitySenateItems.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.UpdateBySql2(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.UpdateBySql2(objMicroteachCaseQuantitySenateItemsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.UpdateBySqlWithCondition(objMicroteachCaseQuantitySenateItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.UpdateBySqlWithConditionTransaction(objMicroteachCaseQuantitySenateItemsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
try
{
int intRecNum = clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.DelRecord(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENS, clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENT)
{
try
{
objMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsENT.SenateScore = objMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsENT.IsAccess = objMicroteachCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objMicroteachCaseQuantitySenateItemsENT.IsAccessC = objMicroteachCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objMicroteachCaseQuantitySenateItemsENT.UpdDate = objMicroteachCaseQuantitySenateItemsENS.UpdDate; //修改日期
objMicroteachCaseQuantitySenateItemsENT.UpdUser = objMicroteachCaseQuantitySenateItemsENS.UpdUser; //修改人
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseQuantitySenateItemsEN:objMicroteachCaseQuantitySenateItemsENT</returns>
 public static clsMicroteachCaseQuantitySenateItemsEN CopyTo(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENS)
{
try
{
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENT = new clsMicroteachCaseQuantitySenateItemsEN()
{
IdmicroteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem, //微格量化评价指标流水号
IdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
SenateScore = objMicroteachCaseQuantitySenateItemsENS.SenateScore, //指标得分
IdSenateGaugeItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem, //量表指标流水号
IdSenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem, //量表指标子项流水号
IsAccess = objMicroteachCaseQuantitySenateItemsENS.IsAccess, //IsAccess
IsAccessC = objMicroteachCaseQuantitySenateItemsENS.IsAccessC, //IsAccessC
UpdDate = objMicroteachCaseQuantitySenateItemsENS.UpdDate, //修改日期
UpdUser = objMicroteachCaseQuantitySenateItemsENS.UpdUser, //修改人
};
 return objMicroteachCaseQuantitySenateItemsENT;
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
public static void CheckPropertyNew(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.CheckPropertyNew(objMicroteachCaseQuantitySenateItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 clsMicroteachCaseQuantitySenateItemsBL.MicroteachCaseQuantitySenateItemsDA.CheckProperty4Condition(objMicroteachCaseQuantitySenateItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsCond.IdmicroteachCaseQuantitySenateItem, strComparisonOpIdmicroteachCaseQuantitySenateItem);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, objMicroteachCaseQuantitySenateItemsCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.SenateScore) == true)
{
string strComparisonOpSenateScore = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.SenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.SenateScore, objMicroteachCaseQuantitySenateItemsCond.SenateScore, strComparisonOpSenateScore);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, objMicroteachCaseQuantitySenateItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem) == true)
{
string strComparisonOpIdSenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, objMicroteachCaseQuantitySenateItemsCond.IdSenateGaugeSubItem, strComparisonOpIdSenateGaugeSubItem);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IsAccess) == true)
{
if (objMicroteachCaseQuantitySenateItemsCond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCaseQuantitySenateItems.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCaseQuantitySenateItems.IsAccess);
}
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.IsAccessC) == true)
{
if (objMicroteachCaseQuantitySenateItemsCond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCaseQuantitySenateItems.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCaseQuantitySenateItems.IsAccessC);
}
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.UpdDate, objMicroteachCaseQuantitySenateItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(conMicroteachCaseQuantitySenateItems.UpdUser) == true)
{
string strComparisonOpUpdUser = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.UpdUser, objMicroteachCaseQuantitySenateItemsCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--MicroteachCaseQuantitySenateItems(微格量化评价详细指标), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_microteachCaseQuantitySenate_id_SenateGaugeItem
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseQuantitySenateItemsEN == null) return true;
if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdmicroteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate);
 if (objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem == null)
{
 sbCondition.AppendFormat(" and IdSenateGaugeItem is null", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
}
else
{
 sbCondition.AppendFormat(" and IdSenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
}
if (clsMicroteachCaseQuantitySenateItemsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdmicroteachCaseQuantitySenateItem !=  {0}", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem);
 sbCondition.AppendFormat(" and IdmicroteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate);
 sbCondition.AppendFormat(" and IdSenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
if (clsMicroteachCaseQuantitySenateItemsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--MicroteachCaseQuantitySenateItems(微格量化评价详细指标), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_microteachCaseQuantitySenate_id_SenateGaugeItem
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseQuantitySenateItemsEN == null) return "";
if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdmicroteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate);
 if (objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem == null)
{
 sbCondition.AppendFormat(" and IdSenateGaugeItem is null", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
}
else
{
 sbCondition.AppendFormat(" and IdSenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdmicroteachCaseQuantitySenateItem !=  {0}", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem);
 sbCondition.AppendFormat(" and IdmicroteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate);
 sbCondition.AppendFormat(" and IdSenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachCaseQuantitySenateItems
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenateItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseQuantitySenateItemsBL
{
public static RelatedActions_MicroteachCaseQuantitySenateItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachCaseQuantitySenateItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachCaseQuantitySenateItemsDA MicroteachCaseQuantitySenateItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachCaseQuantitySenateItemsDA();
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
 public clsMicroteachCaseQuantitySenateItemsBL()
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
if (string.IsNullOrEmpty(clsMicroteachCaseQuantitySenateItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseQuantitySenateItemsEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachCaseQuantitySenateItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable_MicroteachCaseQuantitySenateItems(strWhereCond);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachCaseQuantitySenateItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByIdmicroteachCaseQuantitySenateItemLst(List<long> arrIdmicroteachCaseQuantitySenateItemLst)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateItemLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenateItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByIdmicroteachCaseQuantitySenateItemLstCache(List<long> arrIdmicroteachCaseQuantitySenateItemLst)
{
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Sel =
arrMicroteachCaseQuantitySenateItemsObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateItemLst.Contains(x.IdmicroteachCaseQuantitySenateItem));
return arrMicroteachCaseQuantitySenateItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachCaseQuantitySenateItemsEN> GetSubObjLstCache(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsCond)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseQuantitySenateItems.AttributeName)
{
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseQuantitySenateItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseQuantitySenateItemsCond[strFldName]));
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
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
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
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
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsMicroteachCaseQuantitySenateItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = new clsMicroteachCaseQuantitySenateItemsEN();
try
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[conMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[conMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[conMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[conMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachCaseQuantitySenateItems(ref clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
bool bolResult = MicroteachCaseQuantitySenateItemsDA.GetMicroteachCaseQuantitySenateItems(ref objMicroteachCaseQuantitySenateItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItem(long lngIdmicroteachCaseQuantitySenateItem)
{
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = MicroteachCaseQuantitySenateItemsDA.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);
return objMicroteachCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = MicroteachCaseQuantitySenateItemsDA.GetFirstObj(strWhereCond);
 return objMicroteachCaseQuantitySenateItemsEN;
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
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = MicroteachCaseQuantitySenateItemsDA.GetObjByDataRow(objRow);
 return objMicroteachCaseQuantitySenateItemsEN;
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
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = MicroteachCaseQuantitySenateItemsDA.GetObjByDataRow(objRow);
 return objMicroteachCaseQuantitySenateItemsEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">所给的关键字</param>
 /// <param name = "lstMicroteachCaseQuantitySenateItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItemFromList(long lngIdmicroteachCaseQuantitySenateItem, List<clsMicroteachCaseQuantitySenateItemsEN> lstMicroteachCaseQuantitySenateItemsObjLst)
{
foreach (clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN in lstMicroteachCaseQuantitySenateItemsObjLst)
{
if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == lngIdmicroteachCaseQuantitySenateItem)
{
return objMicroteachCaseQuantitySenateItemsEN;
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
 long lngIdmicroteachCaseQuantitySenateItem;
 try
 {
 lngIdmicroteachCaseQuantitySenateItem = new clsMicroteachCaseQuantitySenateItemsDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenateItem;
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
 arrList = MicroteachCaseQuantitySenateItemsDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachCaseQuantitySenateItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenateItem)
{
//检测记录是否存在
bool bolIsExist = MicroteachCaseQuantitySenateItemsDA.IsExist(lngIdmicroteachCaseQuantitySenateItem);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdmicroteachCaseQuantitySenateItem">微格量化评价指标流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdmicroteachCaseQuantitySenateItem, string strOpUser)
{
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = clsMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);
objMicroteachCaseQuantitySenateItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objMicroteachCaseQuantitySenateItemsEN.UpdUser = strOpUser;
return clsMicroteachCaseQuantitySenateItemsBL.UpdateBySql2(objMicroteachCaseQuantitySenateItemsEN);
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
 bolIsExist = clsMicroteachCaseQuantitySenateItemsDA.IsExistTable();
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
 bolIsExist = MicroteachCaseQuantitySenateItemsDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (objMicroteachCaseQuantitySenateItemsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格量化评价流水号 = [{0}],量表指标流水号 = [{1}]的数据已经存在!(in clsMicroteachCaseQuantitySenateItemsBL.AddNewRecordBySql2)", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate,objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
throw new Exception(strMsg);
}
try
{
bool bolResult = MicroteachCaseQuantitySenateItemsDA.AddNewRecordBySQL2(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (objMicroteachCaseQuantitySenateItemsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!微格量化评价流水号 = [{0}],量表指标流水号 = [{1}]的数据已经存在!(in clsMicroteachCaseQuantitySenateItemsBL.AddNewRecordBySql2WithReturnKey)", objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate,objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem);
throw new Exception(strMsg);
}
try
{
string strKey = MicroteachCaseQuantitySenateItemsDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
try
{
bool bolResult = MicroteachCaseQuantitySenateItemsDA.Update(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 if (objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachCaseQuantitySenateItemsDA.UpdateBySql2(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsBL.ReFreshCache();

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdmicroteachCaseQuantitySenateItem)
{
try
{
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = clsMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);

if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItemsEN.UpdUser);
}
if (objMicroteachCaseQuantitySenateItemsEN != null)
{
int intRecNum = MicroteachCaseQuantitySenateItemsDA.DelRecord(lngIdmicroteachCaseQuantitySenateItem);
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
/// <param name="lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdmicroteachCaseQuantitySenateItem )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseQuantitySenateItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem,
//lngIdmicroteachCaseQuantitySenateItem);
//        clsMicroteachCaseQuantitySenateItemsBL.DelMicroteachCaseQuantitySenateItemssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseQuantitySenateItemsBL.DelRecord(lngIdmicroteachCaseQuantitySenateItem, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseQuantitySenateItemsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdmicroteachCaseQuantitySenateItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdmicroteachCaseQuantitySenateItem, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(lngIdmicroteachCaseQuantitySenateItem, "UpdRelaTabDate");
}
bool bolResult = MicroteachCaseQuantitySenateItemsDA.DelRecord(lngIdmicroteachCaseQuantitySenateItem,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateItemLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachCaseQuantitySenateItemss(List<string> arrIdmicroteachCaseQuantitySenateItemLst)
{
if (arrIdmicroteachCaseQuantitySenateItemLst.Count == 0) return 0;
try
{
if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
foreach (var strIdmicroteachCaseQuantitySenateItem in arrIdmicroteachCaseQuantitySenateItemLst)
{
long lngIdmicroteachCaseQuantitySenateItem = long.Parse(strIdmicroteachCaseQuantitySenateItem);
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(lngIdmicroteachCaseQuantitySenateItem, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachCaseQuantitySenateItemsDA.DelMicroteachCaseQuantitySenateItems(arrIdmicroteachCaseQuantitySenateItemLst);
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
public static int DelMicroteachCaseQuantitySenateItemssByCond(string strWhereCond)
{
try
{
if (clsMicroteachCaseQuantitySenateItemsBL.relatedActions != null)
{
List<string> arrIdmicroteachCaseQuantitySenateItem = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdmicroteachCaseQuantitySenateItem in arrIdmicroteachCaseQuantitySenateItem)
{
long lngIdmicroteachCaseQuantitySenateItem = long.Parse(strIdmicroteachCaseQuantitySenateItem);
clsMicroteachCaseQuantitySenateItemsBL.relatedActions.UpdRelaTabDate(lngIdmicroteachCaseQuantitySenateItem, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachCaseQuantitySenateItemsDA.DelMicroteachCaseQuantitySenateItems(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachCaseQuantitySenateItems]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdmicroteachCaseQuantitySenateItem)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseQuantitySenateItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseQuantitySenateItemsBL.DelRecord(lngIdmicroteachCaseQuantitySenateItem, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseQuantitySenateItemsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdmicroteachCaseQuantitySenateItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENS, clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENT)
{
try
{
objMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsENT.SenateScore = objMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsENT.IsAccess = objMicroteachCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objMicroteachCaseQuantitySenateItemsENT.IsAccessC = objMicroteachCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objMicroteachCaseQuantitySenateItemsENT.UpdDate = objMicroteachCaseQuantitySenateItemsENS.UpdDate; //修改日期
objMicroteachCaseQuantitySenateItemsENT.UpdUser = objMicroteachCaseQuantitySenateItemsENS.UpdUser; //修改人
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
try
{
objMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachCaseQuantitySenateItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.SenateScore, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.SenateScore = objMicroteachCaseQuantitySenateItemsEN.SenateScore; //指标得分
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem == "[null]" ? null :  objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem == "[null]" ? null :  objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IsAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IsAccess = objMicroteachCaseQuantitySenateItemsEN.IsAccess; //IsAccess
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.IsAccessC, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = objMicroteachCaseQuantitySenateItemsEN.IsAccessC; //IsAccessC
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.UpdDate = objMicroteachCaseQuantitySenateItemsEN.UpdDate == "[null]" ? null :  objMicroteachCaseQuantitySenateItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conMicroteachCaseQuantitySenateItems.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseQuantitySenateItemsEN.UpdUser = objMicroteachCaseQuantitySenateItemsEN.UpdUser == "[null]" ? null :  objMicroteachCaseQuantitySenateItemsEN.UpdUser; //修改人
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
try
{
if (objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem == "[null]") objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = null; //量表指标流水号
if (objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem == "[null]") objMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = null; //量表指标子项流水号
if (objMicroteachCaseQuantitySenateItemsEN.UpdDate == "[null]") objMicroteachCaseQuantitySenateItemsEN.UpdDate = null; //修改日期
if (objMicroteachCaseQuantitySenateItemsEN.UpdUser == "[null]") objMicroteachCaseQuantitySenateItemsEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 MicroteachCaseQuantitySenateItemsDA.CheckPropertyNew(objMicroteachCaseQuantitySenateItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 MicroteachCaseQuantitySenateItemsDA.CheckProperty4Condition(objMicroteachCaseQuantitySenateItemsEN);
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
if (clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenateItem");
//if (arrMicroteachCaseQuantitySenateItemsObjLstCache == null)
//{
//arrMicroteachCaseQuantitySenateItemsObjLstCache = MicroteachCaseQuantitySenateItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItemCache(long lngIdmicroteachCaseQuantitySenateItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Sel =
arrMicroteachCaseQuantitySenateItemsObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenateItem == lngIdmicroteachCaseQuantitySenateItem 
);
if (arrMicroteachCaseQuantitySenateItemsObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseQuantitySenateItemsEN obj = clsMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachCaseQuantitySenateItemsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetAllMicroteachCaseQuantitySenateItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache(); 
return arrMicroteachCaseQuantitySenateItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseQuantitySenateItemsObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName);
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
if (clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--MicroteachCaseQuantitySenateItems(微格量化评价详细指标)
 /// 唯一性条件:id_microteachCaseQuantitySenate_id_SenateGaugeItem
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
//检测记录是否存在
string strResult = MicroteachCaseQuantitySenateItemsDA.GetUniCondStr(objMicroteachCaseQuantitySenateItemsEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenateItem)
{
if (strInFldName != conMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachCaseQuantitySenateItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachCaseQuantitySenateItems.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachCaseQuantitySenateItems = clsMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItemCache(lngIdmicroteachCaseQuantitySenateItem);
if (objMicroteachCaseQuantitySenateItems == null) return "";
return objMicroteachCaseQuantitySenateItems[strOutFldName].ToString();
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.GetRecCount();
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsCond)
{
List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseQuantitySenateItems.AttributeName)
{
if (objMicroteachCaseQuantitySenateItemsCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseQuantitySenateItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseQuantitySenateItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseQuantitySenateItemsCond[strFldName]));
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
 List<string> arrList = clsMicroteachCaseQuantitySenateItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseQuantitySenateItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseQuantitySenateItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachCaseQuantitySenateItemsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.SetFldValue(clsMicroteachCaseQuantitySenateItemsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachCaseQuantitySenateItemsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseQuantitySenateItemsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachCaseQuantitySenateItems] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格量化评价指标流水号*/ 
 strCreateTabCode.Append(" IdmicroteachCaseQuantitySenateItem bigint primary key identity, "); 
 // /**微格量化评价流水号*/ 
 strCreateTabCode.Append(" IdmicroteachCaseQuantitySenate bigint not Null, "); 
 // /**指标得分*/ 
 strCreateTabCode.Append(" SenateScore float Null, "); 
 // /**量表指标流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeItem char(4) Null, "); 
 // /**量表指标子项流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeSubItem char(4) Null, "); 
 // /**IsAccess*/ 
 strCreateTabCode.Append(" IsAccess bit Null, "); 
 // /**IsAccessC*/ 
 strCreateTabCode.Append(" IsAccessC bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachCaseQuantitySenateItems : clsCommFun4BL
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
clsMicroteachCaseQuantitySenateItemsBL.ReFreshThisCache();
}
}

}