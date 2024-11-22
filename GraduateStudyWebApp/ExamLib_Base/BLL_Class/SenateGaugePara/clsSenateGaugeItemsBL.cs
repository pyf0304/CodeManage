
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeItemsBL
 表名:SenateGaugeItems(01120476)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
public static class  clsSenateGaugeItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeItemsEN GetObj(this K_IdSenateGaugeItem_SenateGaugeItems myKey)
{
clsSenateGaugeItemsEN objSenateGaugeItemsEN = clsSenateGaugeItemsBL.SenateGaugeItemsDA.GetObjByIdSenateGaugeItem(myKey.Value);
return objSenateGaugeItemsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeItemsBL.IsExist(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeItemsEN.IdSenateGaugeItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSenateGaugeItemsBL.SenateGaugeItemsDA.AddNewRecordBySQL2(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
public static bool AddRecordEx(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSenateGaugeItemsBL.IsExist(objSenateGaugeItemsEN.IdSenateGaugeItem))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSenateGaugeItemsEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSenateGaugeItemsEN.AddNewRecord();
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeItemsBL.IsExist(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeItemsEN.IdSenateGaugeItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSenateGaugeItemsBL.SenateGaugeItemsDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetIdSenateGaugeItem(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, conSenateGaugeItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, conSenateGaugeItems.IdSenateGaugeItem);
}
objSenateGaugeItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.IdSenateGaugeItem) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetIdSenateGaugeVersion(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, conSenateGaugeItems.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conSenateGaugeItems.IdSenateGaugeVersion);
}
objSenateGaugeItemsEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.IdSenateGaugeVersion) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemID(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeItemID, conSenateGaugeItems.senateGaugeItemID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
}
objSenateGaugeItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemID) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemID, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemID] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemName(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeItemName, conSenateGaugeItems.senateGaugeItemName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, conSenateGaugeItems.senateGaugeItemName);
}
objSenateGaugeItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemName) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemName, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemName] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemDesc(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, conSenateGaugeItems.senateGaugeItemDesc);
}
objSenateGaugeItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemDesc) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemWeight(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, float? fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objSenateGaugeItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemWeight) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetAnswerModeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerModeId, conSenateGaugeItems.AnswerModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
}
objSenateGaugeItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.AnswerModeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.AnswerModeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.AnswerModeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetAnswerTypeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerTypeId, conSenateGaugeItems.AnswerTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
}
objSenateGaugeItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.AnswerTypeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.AnswerTypeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.AnswerTypeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetGridTitle(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGridTitle, conSenateGaugeItems.GridTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, conSenateGaugeItems.GridTitle);
}
objSenateGaugeItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.GridTitle) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.GridTitle, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.GridTitle] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionIndex(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, int intQuestionIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intQuestionIndex, conSenateGaugeItems.QuestionIndex);
objSenateGaugeItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionIndex) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionIndex, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionIndex] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionNo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionNo, conSenateGaugeItems.QuestionNo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conSenateGaugeItems.QuestionNo);
}
objSenateGaugeItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionNo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionNo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionNo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionTypeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, conSenateGaugeItems.QuestionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
}
objSenateGaugeItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionTypeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionTypeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionTypeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetIsHaveAdditionalMemo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objSenateGaugeItemsEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.IsHaveAdditionalMemo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetUpdDate(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeItems.UpdDate);
}
objSenateGaugeItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.UpdDate) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetUpdUserId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeItems.UpdUserId);
}
objSenateGaugeItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.UpdUserId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemMemo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, conSenateGaugeItems.senateGaugeItemMemo);
}
objSenateGaugeItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemMemo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSenateGaugeItemsEN.CheckPropertyNew();
clsSenateGaugeItemsEN objSenateGaugeItemsCond = new clsSenateGaugeItemsEN();
string strCondition = objSenateGaugeItemsCond
.SetIdSenateGaugeItem(objSenateGaugeItemsEN.IdSenateGaugeItem, "=")
.GetCombineCondition();
objSenateGaugeItemsEN._IsCheckProperty = true;
bool bolIsExist = clsSenateGaugeItemsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSenateGaugeItemsEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeItemsBL.SenateGaugeItemsDA.UpdateBySql2(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeItemsBL.SenateGaugeItemsDA.UpdateBySql2(objSenateGaugeItemsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strWhereCond)
{
try
{
bool bolResult = clsSenateGaugeItemsBL.SenateGaugeItemsDA.UpdateBySqlWithCondition(objSenateGaugeItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSenateGaugeItemsBL.SenateGaugeItemsDA.UpdateBySqlWithConditionTransaction(objSenateGaugeItemsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
try
{
int intRecNum = clsSenateGaugeItemsBL.SenateGaugeItemsDA.DelRecord(objSenateGaugeItemsEN.IdSenateGaugeItem);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsENS">源对象</param>
 /// <param name = "objSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(this clsSenateGaugeItemsEN objSenateGaugeItemsENS, clsSenateGaugeItemsEN objSenateGaugeItemsENT)
{
try
{
objSenateGaugeItemsENT.IdSenateGaugeItem = objSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeItemsENT.IdSenateGaugeVersion = objSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeItemsENT.senateGaugeItemID = objSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objSenateGaugeItemsENT.senateGaugeItemName = objSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objSenateGaugeItemsENT.senateGaugeItemDesc = objSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objSenateGaugeItemsENT.senateGaugeItemWeight = objSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objSenateGaugeItemsENT.AnswerModeId = objSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objSenateGaugeItemsENT.AnswerTypeId = objSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objSenateGaugeItemsENT.GridTitle = objSenateGaugeItemsENS.GridTitle; //表格标题
objSenateGaugeItemsENT.QuestionIndex = objSenateGaugeItemsENS.QuestionIndex; //题目序号
objSenateGaugeItemsENT.QuestionNo = objSenateGaugeItemsENS.QuestionNo; //题目编号
objSenateGaugeItemsENT.QuestionTypeId = objSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objSenateGaugeItemsENT.IsHaveAdditionalMemo = objSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objSenateGaugeItemsENT.UpdDate = objSenateGaugeItemsENS.UpdDate; //修改日期
objSenateGaugeItemsENT.UpdUserId = objSenateGaugeItemsENS.UpdUserId; //修改用户Id
objSenateGaugeItemsENT.senateGaugeItemMemo = objSenateGaugeItemsENS.senateGaugeItemMemo; //备注
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
 /// <param name = "objSenateGaugeItemsENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeItemsEN:objSenateGaugeItemsENT</returns>
 public static clsSenateGaugeItemsEN CopyTo(this clsSenateGaugeItemsEN objSenateGaugeItemsENS)
{
try
{
 clsSenateGaugeItemsEN objSenateGaugeItemsENT = new clsSenateGaugeItemsEN()
{
IdSenateGaugeItem = objSenateGaugeItemsENS.IdSenateGaugeItem, //量表指标流水号
IdSenateGaugeVersion = objSenateGaugeItemsENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeItemID = objSenateGaugeItemsENS.senateGaugeItemID, //量表指标ID
senateGaugeItemName = objSenateGaugeItemsENS.senateGaugeItemName, //量表指标名称
senateGaugeItemDesc = objSenateGaugeItemsENS.senateGaugeItemDesc, //量表指标说明
senateGaugeItemWeight = objSenateGaugeItemsENS.senateGaugeItemWeight, //量表指标权重
AnswerModeId = objSenateGaugeItemsENS.AnswerModeId, //答案模式Id
AnswerTypeId = objSenateGaugeItemsENS.AnswerTypeId, //答案类型ID
GridTitle = objSenateGaugeItemsENS.GridTitle, //表格标题
QuestionIndex = objSenateGaugeItemsENS.QuestionIndex, //题目序号
QuestionNo = objSenateGaugeItemsENS.QuestionNo, //题目编号
QuestionTypeId = objSenateGaugeItemsENS.QuestionTypeId, //题目类型Id
IsHaveAdditionalMemo = objSenateGaugeItemsENS.IsHaveAdditionalMemo, //是否有附加说明
UpdDate = objSenateGaugeItemsENS.UpdDate, //修改日期
UpdUserId = objSenateGaugeItemsENS.UpdUserId, //修改用户Id
senateGaugeItemMemo = objSenateGaugeItemsENS.senateGaugeItemMemo, //备注
};
 return objSenateGaugeItemsENT;
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
public static void CheckPropertyNew(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 clsSenateGaugeItemsBL.SenateGaugeItemsDA.CheckPropertyNew(objSenateGaugeItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 clsSenateGaugeItemsBL.SenateGaugeItemsDA.CheckProperty4Condition(objSenateGaugeItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeItemsEN objSenateGaugeItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.IdSenateGaugeItem, objSenateGaugeItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.IdSenateGaugeVersion, objSenateGaugeItemsCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.senateGaugeItemID) == true)
{
string strComparisonOpsenateGaugeItemID = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemID, objSenateGaugeItemsCond.senateGaugeItemID, strComparisonOpsenateGaugeItemID);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.senateGaugeItemName) == true)
{
string strComparisonOpsenateGaugeItemName = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemName, objSenateGaugeItemsCond.senateGaugeItemName, strComparisonOpsenateGaugeItemName);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc) == true)
{
string strComparisonOpsenateGaugeItemDesc = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemDesc, objSenateGaugeItemsCond.senateGaugeItemDesc, strComparisonOpsenateGaugeItemDesc);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight) == true)
{
string strComparisonOpsenateGaugeItemWeight = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeItems.senateGaugeItemWeight, objSenateGaugeItemsCond.senateGaugeItemWeight, strComparisonOpsenateGaugeItemWeight);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.AnswerModeId, objSenateGaugeItemsCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.AnswerTypeId, objSenateGaugeItemsCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.GridTitle) == true)
{
string strComparisonOpGridTitle = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.GridTitle, objSenateGaugeItemsCond.GridTitle, strComparisonOpGridTitle);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeItems.QuestionIndex, objSenateGaugeItemsCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.QuestionNo, objSenateGaugeItemsCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.QuestionTypeId, objSenateGaugeItemsCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo) == true)
{
if (objSenateGaugeItemsCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSenateGaugeItems.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSenateGaugeItems.IsHaveAdditionalMemo);
}
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.UpdDate, objSenateGaugeItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.UpdUserId, objSenateGaugeItemsCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSenateGaugeItemsCond.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo) == true)
{
string strComparisonOpsenateGaugeItemMemo = objSenateGaugeItemsCond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemMemo, objSenateGaugeItemsCond.senateGaugeItemMemo, strComparisonOpsenateGaugeItemMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SenateGaugeItems
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeItemsBL
{
public static RelatedActions_SenateGaugeItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSenateGaugeItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSenateGaugeItemsDA SenateGaugeItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSenateGaugeItemsDA();
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
 public clsSenateGaugeItemsBL()
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
if (string.IsNullOrEmpty(clsSenateGaugeItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeItemsEN._ConnectString);
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
public static DataTable GetDataTable_SenateGaugeItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SenateGaugeItemsDA.GetDataTable_SenateGaugeItems(strWhereCond);
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
objDT = SenateGaugeItemsDA.GetDataTable(strWhereCond);
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
objDT = SenateGaugeItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SenateGaugeItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SenateGaugeItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SenateGaugeItemsDA.GetDataTable_Top(objTopPara);
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
objDT = SenateGaugeItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SenateGaugeItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SenateGaugeItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLstByIdSenateGaugeItemLst(List<string> arrIdSenateGaugeItemLst)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeItemLst, true);
 string strWhereCond = string.Format("IdSenateGaugeItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSenateGaugeItemsEN> GetObjLstByIdSenateGaugeItemLstCache(List<string> arrIdSenateGaugeItemLst)
{
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel =
arrSenateGaugeItemsObjLstCache
.Where(x => arrIdSenateGaugeItemLst.Contains(x.IdSenateGaugeItem));
return arrSenateGaugeItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLst(string strWhereCond)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
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
public static List<clsSenateGaugeItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSenateGaugeItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSenateGaugeItemsEN> GetSubObjLstCache(clsSenateGaugeItemsEN objSenateGaugeItemsCond)
{
List<clsSenateGaugeItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeItems.AttributeName)
{
if (objSenateGaugeItemsCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeItemsCond[strFldName].ToString());
}
else
{
if (objSenateGaugeItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeItemsCond[strFldName]));
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
public static List<clsSenateGaugeItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
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
public static List<clsSenateGaugeItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
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
List<clsSenateGaugeItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSenateGaugeItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSenateGaugeItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
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
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
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
public static List<clsSenateGaugeItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSenateGaugeItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
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
public static List<clsSenateGaugeItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSenateGaugeItemsEN> arrObjLst = new List<clsSenateGaugeItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN();
try
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[conSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeItemsEN.senateGaugeItemID = objRow[conSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objSenateGaugeItemsEN.senateGaugeItemName = objRow[conSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objSenateGaugeItemsEN.senateGaugeItemDesc = objRow[conSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objSenateGaugeItemsEN.senateGaugeItemWeight = objRow[conSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objSenateGaugeItemsEN.AnswerModeId = objRow[conSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objSenateGaugeItemsEN.AnswerTypeId = objRow[conSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objSenateGaugeItemsEN.GridTitle = objRow[conSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objSenateGaugeItemsEN.QuestionIndex = Int32.Parse(objRow[conSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objSenateGaugeItemsEN.QuestionNo = objRow[conSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objSenateGaugeItemsEN.QuestionTypeId = objRow[conSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objSenateGaugeItemsEN.UpdDate = objRow[conSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeItemsEN.UpdUserId = objRow[conSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeItemsEN.senateGaugeItemMemo = objRow[conSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSenateGaugeItems(ref clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
bool bolResult = SenateGaugeItemsDA.GetSenateGaugeItems(ref objSenateGaugeItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeItemsEN GetObjByIdSenateGaugeItem(string strIdSenateGaugeItem)
{
if (strIdSenateGaugeItem.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeItem]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeItem]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSenateGaugeItemsEN objSenateGaugeItemsEN = SenateGaugeItemsDA.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);
return objSenateGaugeItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSenateGaugeItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSenateGaugeItemsEN objSenateGaugeItemsEN = SenateGaugeItemsDA.GetFirstObj(strWhereCond);
 return objSenateGaugeItemsEN;
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
public static clsSenateGaugeItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSenateGaugeItemsEN objSenateGaugeItemsEN = SenateGaugeItemsDA.GetObjByDataRow(objRow);
 return objSenateGaugeItemsEN;
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
public static clsSenateGaugeItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSenateGaugeItemsEN objSenateGaugeItemsEN = SenateGaugeItemsDA.GetObjByDataRow(objRow);
 return objSenateGaugeItemsEN;
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
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <param name = "lstSenateGaugeItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeItemsEN GetObjByIdSenateGaugeItemFromList(string strIdSenateGaugeItem, List<clsSenateGaugeItemsEN> lstSenateGaugeItemsObjLst)
{
foreach (clsSenateGaugeItemsEN objSenateGaugeItemsEN in lstSenateGaugeItemsObjLst)
{
if (objSenateGaugeItemsEN.IdSenateGaugeItem == strIdSenateGaugeItem)
{
return objSenateGaugeItemsEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdSenateGaugeItem;
 try
 {
 strIdSenateGaugeItem = new clsSenateGaugeItemsDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeItem;
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
 arrList = SenateGaugeItemsDA.GetID(strWhereCond);
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
bool bolIsExist = SenateGaugeItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeItem]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SenateGaugeItemsDA.IsExist(strIdSenateGaugeItem);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdSenateGaugeItem">量表指标流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdSenateGaugeItem, string strOpUser)
{
clsSenateGaugeItemsEN objSenateGaugeItemsEN = clsSenateGaugeItemsBL.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);
objSenateGaugeItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSenateGaugeItemsEN.UpdUserId = strOpUser;
return clsSenateGaugeItemsBL.UpdateBySql2(objSenateGaugeItemsEN);
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
 bolIsExist = clsSenateGaugeItemsDA.IsExistTable();
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
 bolIsExist = SenateGaugeItemsDA.IsExistTable(strTabName);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeItemsBL.IsExist(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeItemsEN.IdSenateGaugeItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SenateGaugeItemsDA.AddNewRecordBySQL2(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeItemsBL.IsExist(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeItemsEN.IdSenateGaugeItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SenateGaugeItemsDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
try
{
bool bolResult = SenateGaugeItemsDA.Update(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.IdSenateGaugeItem) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SenateGaugeItemsDA.UpdateBySql2(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsBL.ReFreshCache();

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdSenateGaugeItem)
{
try
{
 clsSenateGaugeItemsEN objSenateGaugeItemsEN = clsSenateGaugeItemsBL.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);

if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeItemsEN.IdSenateGaugeItem, objSenateGaugeItemsEN.UpdUserId);
}
if (objSenateGaugeItemsEN != null)
{
int intRecNum = SenateGaugeItemsDA.DelRecord(strIdSenateGaugeItem);
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
/// <param name="strIdSenateGaugeItem">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdSenateGaugeItem )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSenateGaugeItems.IdSenateGaugeItem,
//strIdSenateGaugeItem);
//        clsSenateGaugeItemsBL.DelSenateGaugeItemssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeItemsBL.DelRecord(strIdSenateGaugeItem, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeItemsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdSenateGaugeItem, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSenateGaugeItemsBL.relatedActions != null)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeItem, "UpdRelaTabDate");
}
bool bolResult = SenateGaugeItemsDA.DelRecord(strIdSenateGaugeItem,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdSenateGaugeItemLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSenateGaugeItemss(List<string> arrIdSenateGaugeItemLst)
{
if (arrIdSenateGaugeItemLst.Count == 0) return 0;
try
{
if (clsSenateGaugeItemsBL.relatedActions != null)
{
foreach (var strIdSenateGaugeItem in arrIdSenateGaugeItemLst)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeItem, "UpdRelaTabDate");
}
}
int intDelRecNum = SenateGaugeItemsDA.DelSenateGaugeItems(arrIdSenateGaugeItemLst);
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
public static int DelSenateGaugeItemssByCond(string strWhereCond)
{
try
{
if (clsSenateGaugeItemsBL.relatedActions != null)
{
List<string> arrIdSenateGaugeItem = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdSenateGaugeItem in arrIdSenateGaugeItem)
{
clsSenateGaugeItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeItem, "UpdRelaTabDate");
}
}
int intRecNum = SenateGaugeItemsDA.DelSenateGaugeItems(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SenateGaugeItems]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdSenateGaugeItem">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdSenateGaugeItem)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeItemsDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeItemsBL.DelRecord(strIdSenateGaugeItem, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeItemsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeItemsENS">源对象</param>
 /// <param name = "objSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeItemsEN objSenateGaugeItemsENS, clsSenateGaugeItemsEN objSenateGaugeItemsENT)
{
try
{
objSenateGaugeItemsENT.IdSenateGaugeItem = objSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeItemsENT.IdSenateGaugeVersion = objSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeItemsENT.senateGaugeItemID = objSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objSenateGaugeItemsENT.senateGaugeItemName = objSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objSenateGaugeItemsENT.senateGaugeItemDesc = objSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objSenateGaugeItemsENT.senateGaugeItemWeight = objSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objSenateGaugeItemsENT.AnswerModeId = objSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objSenateGaugeItemsENT.AnswerTypeId = objSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objSenateGaugeItemsENT.GridTitle = objSenateGaugeItemsENS.GridTitle; //表格标题
objSenateGaugeItemsENT.QuestionIndex = objSenateGaugeItemsENS.QuestionIndex; //题目序号
objSenateGaugeItemsENT.QuestionNo = objSenateGaugeItemsENS.QuestionNo; //题目编号
objSenateGaugeItemsENT.QuestionTypeId = objSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objSenateGaugeItemsENT.IsHaveAdditionalMemo = objSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objSenateGaugeItemsENT.UpdDate = objSenateGaugeItemsENS.UpdDate; //修改日期
objSenateGaugeItemsENT.UpdUserId = objSenateGaugeItemsENS.UpdUserId; //修改用户Id
objSenateGaugeItemsENT.senateGaugeItemMemo = objSenateGaugeItemsENS.senateGaugeItemMemo; //备注
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
 /// <param name = "objSenateGaugeItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
try
{
objSenateGaugeItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSenateGaugeItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSenateGaugeItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.IdSenateGaugeItem = objSenateGaugeItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(conSenateGaugeItems.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.IdSenateGaugeVersion = objSenateGaugeItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conSenateGaugeItems.senateGaugeItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.senateGaugeItemID = objSenateGaugeItemsEN.senateGaugeItemID; //量表指标ID
}
if (arrFldSet.Contains(conSenateGaugeItems.senateGaugeItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.senateGaugeItemName = objSenateGaugeItemsEN.senateGaugeItemName; //量表指标名称
}
if (arrFldSet.Contains(conSenateGaugeItems.senateGaugeItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.senateGaugeItemDesc = objSenateGaugeItemsEN.senateGaugeItemDesc == "[null]" ? null :  objSenateGaugeItemsEN.senateGaugeItemDesc; //量表指标说明
}
if (arrFldSet.Contains(conSenateGaugeItems.senateGaugeItemWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.senateGaugeItemWeight = objSenateGaugeItemsEN.senateGaugeItemWeight; //量表指标权重
}
if (arrFldSet.Contains(conSenateGaugeItems.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.AnswerModeId = objSenateGaugeItemsEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(conSenateGaugeItems.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.AnswerTypeId = objSenateGaugeItemsEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conSenateGaugeItems.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.GridTitle = objSenateGaugeItemsEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(conSenateGaugeItems.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.QuestionIndex = objSenateGaugeItemsEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(conSenateGaugeItems.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.QuestionNo = objSenateGaugeItemsEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(conSenateGaugeItems.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.QuestionTypeId = objSenateGaugeItemsEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(conSenateGaugeItems.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.IsHaveAdditionalMemo = objSenateGaugeItemsEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(conSenateGaugeItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.UpdDate = objSenateGaugeItemsEN.UpdDate == "[null]" ? null :  objSenateGaugeItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSenateGaugeItems.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.UpdUserId = objSenateGaugeItemsEN.UpdUserId == "[null]" ? null :  objSenateGaugeItemsEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSenateGaugeItems.senateGaugeItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeItemsEN.senateGaugeItemMemo = objSenateGaugeItemsEN.senateGaugeItemMemo == "[null]" ? null :  objSenateGaugeItemsEN.senateGaugeItemMemo; //备注
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
 /// <param name = "objSenateGaugeItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
try
{
if (objSenateGaugeItemsEN.senateGaugeItemDesc == "[null]") objSenateGaugeItemsEN.senateGaugeItemDesc = null; //量表指标说明
if (objSenateGaugeItemsEN.UpdDate == "[null]") objSenateGaugeItemsEN.UpdDate = null; //修改日期
if (objSenateGaugeItemsEN.UpdUserId == "[null]") objSenateGaugeItemsEN.UpdUserId = null; //修改用户Id
if (objSenateGaugeItemsEN.senateGaugeItemMemo == "[null]") objSenateGaugeItemsEN.senateGaugeItemMemo = null; //备注
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
public static void CheckPropertyNew(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 SenateGaugeItemsDA.CheckPropertyNew(objSenateGaugeItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 SenateGaugeItemsDA.CheckProperty4Condition(objSenateGaugeItemsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSenateGaugeItem(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeItems.IdSenateGaugeItem); 
List<clsSenateGaugeItemsEN> arrObjLst = clsSenateGaugeItemsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN()
{
IdSenateGaugeItem = "0",
senateGaugeItemName = "选[量表指标]..."
};
arrObjLst.Insert(0, objSenateGaugeItemsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGaugeItems.IdSenateGaugeItem;
objComboBox.DisplayMember = conSenateGaugeItems.senateGaugeItemName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdSenateGaugeItem(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeItems.IdSenateGaugeItem); 
IEnumerable<clsSenateGaugeItemsEN> arrObjLst = clsSenateGaugeItemsBL.GetObjLst(strCondition);
objDDL.DataValueField = conSenateGaugeItems.IdSenateGaugeItem;
objDDL.DataTextField = conSenateGaugeItems.senateGaugeItemName;
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
public static void BindDdl_IdSenateGaugeItemCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标]...","0");
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst = GetAllSenateGaugeItemsObjLstCache(); 
objDDL.DataValueField = conSenateGaugeItems.IdSenateGaugeItem;
objDDL.DataTextField = conSenateGaugeItems.senateGaugeItemName;
objDDL.DataSource = arrSenateGaugeItemsObjLst;
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
if (clsSenateGaugeItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsBL没有刷新缓存机制(clsSenateGaugeItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeItem");
//if (arrSenateGaugeItemsObjLstCache == null)
//{
//arrSenateGaugeItemsObjLstCache = SenateGaugeItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeItemsEN GetObjByIdSenateGaugeItemCache(string strIdSenateGaugeItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel =
arrSenateGaugeItemsObjLstCache
.Where(x=> x.IdSenateGaugeItem == strIdSenateGaugeItem 
);
if (arrSenateGaugeItemsObjLst_Sel.Count() == 0)
{
   clsSenateGaugeItemsEN obj = clsSenateGaugeItemsBL.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSenateGaugeItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeItemNameByIdSenateGaugeItemCache(string strIdSenateGaugeItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeItemsEN objSenateGaugeItems = GetObjByIdSenateGaugeItemCache(strIdSenateGaugeItem);
if (objSenateGaugeItems == null) return "";
return objSenateGaugeItems.senateGaugeItemName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSenateGaugeItemCache(string strIdSenateGaugeItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeItemsEN objSenateGaugeItems = GetObjByIdSenateGaugeItemCache(strIdSenateGaugeItem);
if (objSenateGaugeItems == null) return "";
return objSenateGaugeItems.senateGaugeItemName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetAllSenateGaugeItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLstCache = GetObjLstCache(); 
return arrSenateGaugeItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeItemsObjLstCache;
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
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeItemsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSenateGaugeItemsEN._RefreshTimeLst.Count == 0) return "";
return clsSenateGaugeItemsEN._RefreshTimeLst[clsSenateGaugeItemsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSenateGaugeItemsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeItemsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSenateGaugeItemsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeItem)
{
if (strInFldName != conSenateGaugeItems.IdSenateGaugeItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSenateGaugeItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSenateGaugeItems.AttributeName));
throw new Exception(strMsg);
}
var objSenateGaugeItems = clsSenateGaugeItemsBL.GetObjByIdSenateGaugeItemCache(strIdSenateGaugeItem);
if (objSenateGaugeItems == null) return "";
return objSenateGaugeItems[strOutFldName].ToString();
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
int intRecCount = clsSenateGaugeItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsSenateGaugeItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSenateGaugeItemsDA.GetRecCount();
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
int intRecCount = clsSenateGaugeItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSenateGaugeItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSenateGaugeItemsEN objSenateGaugeItemsCond)
{
List<clsSenateGaugeItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeItems.AttributeName)
{
if (objSenateGaugeItemsCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeItemsCond[strFldName].ToString());
}
else
{
if (objSenateGaugeItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeItemsCond[strFldName]));
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
 List<string> arrList = clsSenateGaugeItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SenateGaugeItemsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeItemsDA.SetFldValue(clsSenateGaugeItemsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SenateGaugeItemsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeItemsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeItemsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeItemsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SenateGaugeItems] "); 
 strCreateTabCode.Append(" ( "); 
 // /**量表指标流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeItem char(4) primary key, "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) not Null, "); 
 // /**量表指标ID*/ 
 strCreateTabCode.Append(" senateGaugeItemID char(4) not Null, "); 
 // /**量表指标名称*/ 
 strCreateTabCode.Append(" senateGaugeItemName varchar(200) not Null, "); 
 // /**量表指标说明*/ 
 strCreateTabCode.Append(" senateGaugeItemDesc varchar(2000) Null, "); 
 // /**量表指标权重*/ 
 strCreateTabCode.Append(" senateGaugeItemWeight float Null, "); 
 // /**答案模式Id*/ 
 strCreateTabCode.Append(" AnswerModeId char(4) not Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) not Null, "); 
 // /**表格标题*/ 
 strCreateTabCode.Append(" GridTitle varchar(30) not Null, "); 
 // /**题目序号*/ 
 strCreateTabCode.Append(" QuestionIndex int not Null, "); 
 // /**题目编号*/ 
 strCreateTabCode.Append(" QuestionNo varchar(10) not Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) not Null, "); 
 // /**是否有附加说明*/ 
 strCreateTabCode.Append(" IsHaveAdditionalMemo bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" senateGaugeItemMemo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SenateGaugeItems : clsCommFun4BL
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
clsSenateGaugeItemsBL.ReFreshThisCache();
}
}

}