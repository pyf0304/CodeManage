
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeSubItemsBL
 表名:SenateGaugeSubItems(01120478)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:21
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
public static class  clsSenateGaugeSubItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeSubItemsEN GetObj(this K_IdSenateGaugeSubItem_SenateGaugeSubItems myKey)
{
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.GetObjByIdSenateGaugeSubItem(myKey.Value);
return objSenateGaugeSubItemsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeSubItemsBL.IsExist(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.AddNewRecordBySQL2(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
public static bool AddRecordEx(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSenateGaugeSubItemsBL.IsExist(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSenateGaugeSubItemsEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSenateGaugeSubItemsEN.AddNewRecord();
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeSubItemsBL.IsExist(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetIdSenateGaugeSubItem(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strIdSenateGaugeSubItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeSubItem, 4, conSenateGaugeSubItems.IdSenateGaugeSubItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeSubItem, 4, conSenateGaugeSubItems.IdSenateGaugeSubItem);
}
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = strIdSenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.IdSenateGaugeSubItem) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.IdSenateGaugeSubItem, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.IdSenateGaugeSubItem] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetIdSenateGaugeItem(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeItem, conSenateGaugeSubItems.IdSenateGaugeItem);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, conSenateGaugeSubItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, conSenateGaugeSubItems.IdSenateGaugeItem);
}
objSenateGaugeSubItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.IdSenateGaugeItem) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemID(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
}
objSenateGaugeSubItemsEN.senateGaugeSubItemID = strsenateGaugeSubItemID; //量表指标子项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemID) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemID, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemID] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemName(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, conSenateGaugeSubItems.senateGaugeSubItemName);
}
objSenateGaugeSubItemsEN.senateGaugeSubItemName = strsenateGaugeSubItemName; //量表指标子项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemName) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemName, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemName] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemScore(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, float fltsenateGaugeSubItemScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeSubItemScore, conSenateGaugeSubItems.senateGaugeSubItemScore);
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = fltsenateGaugeSubItemScore; //量表指标子项分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemScore) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemScore, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemScore] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemDesc(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, conSenateGaugeSubItems.senateGaugeSubItemDesc);
}
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = strsenateGaugeSubItemDesc; //量表指标子项说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemDesc) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemDesc] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetAnswerTitle(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, conSenateGaugeSubItems.AnswerTitle);
}
objSenateGaugeSubItemsEN.AnswerTitle = strAnswerTitle; //答案标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.AnswerTitle) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.AnswerTitle, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.AnswerTitle] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetAnswerIndex(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, int? intAnswerIndex, string strComparisonOp="")
	{
objSenateGaugeSubItemsEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.AnswerIndex) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.AnswerIndex, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.AnswerIndex] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetUpdDate(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeSubItems.UpdDate);
}
objSenateGaugeSubItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.UpdDate) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetUpdUserId(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeSubItems.UpdUserId);
}
objSenateGaugeSubItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.UpdUserId) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemMemo(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, conSenateGaugeSubItems.senateGaugeSubItemMemo);
}
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = strsenateGaugeSubItemMemo; //量表指标子项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemMemo) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemMemo] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSenateGaugeSubItemsEN.CheckPropertyNew();
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsCond = new clsSenateGaugeSubItemsEN();
string strCondition = objSenateGaugeSubItemsCond
.SetIdSenateGaugeSubItem(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, "=")
.GetCombineCondition();
objSenateGaugeSubItemsEN._IsCheckProperty = true;
bool bolIsExist = clsSenateGaugeSubItemsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSenateGaugeSubItemsEN.Update();
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.UpdateBySql2(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.UpdateBySql2(objSenateGaugeSubItemsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strWhereCond)
{
try
{
bool bolResult = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.UpdateBySqlWithCondition(objSenateGaugeSubItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.UpdateBySqlWithConditionTransaction(objSenateGaugeSubItemsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
try
{
int intRecNum = clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.DelRecord(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENS, clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENT)
{
try
{
objSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objSenateGaugeSubItemsENT.IdSenateGaugeItem = objSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeSubItemsENT.senateGaugeSubItemID = objSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objSenateGaugeSubItemsENT.senateGaugeSubItemName = objSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objSenateGaugeSubItemsENT.senateGaugeSubItemScore = objSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objSenateGaugeSubItemsENT.AnswerTitle = objSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objSenateGaugeSubItemsENT.AnswerIndex = objSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objSenateGaugeSubItemsENT.UpdDate = objSenateGaugeSubItemsENS.UpdDate; //修改日期
objSenateGaugeSubItemsENT.UpdUserId = objSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
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
 /// <param name = "objSenateGaugeSubItemsENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeSubItemsEN:objSenateGaugeSubItemsENT</returns>
 public static clsSenateGaugeSubItemsEN CopyTo(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENS)
{
try
{
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENT = new clsSenateGaugeSubItemsEN()
{
IdSenateGaugeSubItem = objSenateGaugeSubItemsENS.IdSenateGaugeSubItem, //量表指标子项流水号
IdSenateGaugeItem = objSenateGaugeSubItemsENS.IdSenateGaugeItem, //量表指标流水号
senateGaugeSubItemID = objSenateGaugeSubItemsENS.senateGaugeSubItemID, //量表指标子项ID
senateGaugeSubItemName = objSenateGaugeSubItemsENS.senateGaugeSubItemName, //量表指标子项名称
senateGaugeSubItemScore = objSenateGaugeSubItemsENS.senateGaugeSubItemScore, //量表指标子项分数
senateGaugeSubItemDesc = objSenateGaugeSubItemsENS.senateGaugeSubItemDesc, //量表指标子项说明
AnswerTitle = objSenateGaugeSubItemsENS.AnswerTitle, //答案标题
AnswerIndex = objSenateGaugeSubItemsENS.AnswerIndex, //问答序号
UpdDate = objSenateGaugeSubItemsENS.UpdDate, //修改日期
UpdUserId = objSenateGaugeSubItemsENS.UpdUserId, //修改用户Id
senateGaugeSubItemMemo = objSenateGaugeSubItemsENS.senateGaugeSubItemMemo, //量表指标子项备注
};
 return objSenateGaugeSubItemsENT;
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
public static void CheckPropertyNew(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.CheckPropertyNew(objSenateGaugeSubItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 clsSenateGaugeSubItemsBL.SenateGaugeSubItemsDA.CheckProperty4Condition(objSenateGaugeSubItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeSubItem) == true)
{
string strComparisonOpIdSenateGaugeSubItem = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.IdSenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.IdSenateGaugeSubItem, objSenateGaugeSubItemsCond.IdSenateGaugeSubItem, strComparisonOpIdSenateGaugeSubItem);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.IdSenateGaugeItem, objSenateGaugeSubItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID) == true)
{
string strComparisonOpsenateGaugeSubItemID = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemID, objSenateGaugeSubItemsCond.senateGaugeSubItemID, strComparisonOpsenateGaugeSubItemID);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName) == true)
{
string strComparisonOpsenateGaugeSubItemName = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemName, objSenateGaugeSubItemsCond.senateGaugeSubItemName, strComparisonOpsenateGaugeSubItemName);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore) == true)
{
string strComparisonOpsenateGaugeSubItemScore = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeSubItems.senateGaugeSubItemScore, objSenateGaugeSubItemsCond.senateGaugeSubItemScore, strComparisonOpsenateGaugeSubItemScore);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOpsenateGaugeSubItemDesc = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemDesc, objSenateGaugeSubItemsCond.senateGaugeSubItemDesc, strComparisonOpsenateGaugeSubItemDesc);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.AnswerTitle) == true)
{
string strComparisonOpAnswerTitle = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.AnswerTitle, objSenateGaugeSubItemsCond.AnswerTitle, strComparisonOpAnswerTitle);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeSubItems.AnswerIndex, objSenateGaugeSubItemsCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.UpdDate, objSenateGaugeSubItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.UpdUserId, objSenateGaugeSubItemsCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSenateGaugeSubItemsCond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOpsenateGaugeSubItemMemo = objSenateGaugeSubItemsCond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemMemo, objSenateGaugeSubItemsCond.senateGaugeSubItemMemo, strComparisonOpsenateGaugeSubItemMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SenateGaugeSubItems
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeSubItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 量表指标子项(SenateGaugeSubItems)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeSubItemsBL
{
public static RelatedActions_SenateGaugeSubItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSenateGaugeSubItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSenateGaugeSubItemsDA SenateGaugeSubItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSenateGaugeSubItemsDA();
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
 public clsSenateGaugeSubItemsBL()
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
if (string.IsNullOrEmpty(clsSenateGaugeSubItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeSubItemsEN._ConnectString);
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
public static DataTable GetDataTable_SenateGaugeSubItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SenateGaugeSubItemsDA.GetDataTable_SenateGaugeSubItems(strWhereCond);
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
objDT = SenateGaugeSubItemsDA.GetDataTable(strWhereCond);
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
objDT = SenateGaugeSubItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SenateGaugeSubItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SenateGaugeSubItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SenateGaugeSubItemsDA.GetDataTable_Top(objTopPara);
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
objDT = SenateGaugeSubItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SenateGaugeSubItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SenateGaugeSubItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeSubItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLstByIdSenateGaugeSubItemLst(List<string> arrIdSenateGaugeSubItemLst)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeSubItemLst, true);
 string strWhereCond = string.Format("IdSenateGaugeSubItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeSubItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSenateGaugeSubItemsEN> GetObjLstByIdSenateGaugeSubItemLstCache(List<string> arrIdSenateGaugeSubItemLst)
{
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel =
arrSenateGaugeSubItemsObjLstCache
.Where(x => arrIdSenateGaugeSubItemLst.Contains(x.IdSenateGaugeSubItem));
return arrSenateGaugeSubItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLst(string strWhereCond)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSenateGaugeSubItemsEN> GetSubObjLstCache(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsCond)
{
List<clsSenateGaugeSubItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeSubItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeSubItems.AttributeName)
{
if (objSenateGaugeSubItemsCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeSubItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeSubItemsCond[strFldName].ToString());
}
else
{
if (objSenateGaugeSubItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeSubItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeSubItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeSubItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeSubItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeSubItemsCond[strFldName]));
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
List<clsSenateGaugeSubItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSenateGaugeSubItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSenateGaugeSubItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
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
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
public static List<clsSenateGaugeSubItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSenateGaugeSubItemsEN> arrObjLst = new List<clsSenateGaugeSubItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN();
try
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[conSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[conSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[conSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[conSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = Single.Parse(objRow[conSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objSenateGaugeSubItemsEN.AnswerTitle = objRow[conSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objSenateGaugeSubItemsEN.AnswerIndex = objRow[conSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objSenateGaugeSubItemsEN.UpdDate = objRow[conSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeSubItemsEN.UpdUserId = objRow[conSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[conSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeSubItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSenateGaugeSubItems(ref clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
bool bolResult = SenateGaugeSubItemsDA.GetSenateGaugeSubItems(ref objSenateGaugeSubItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItem(string strIdSenateGaugeSubItem)
{
if (strIdSenateGaugeSubItem.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeSubItem]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeSubItem]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = SenateGaugeSubItemsDA.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);
return objSenateGaugeSubItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSenateGaugeSubItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = SenateGaugeSubItemsDA.GetFirstObj(strWhereCond);
 return objSenateGaugeSubItemsEN;
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
public static clsSenateGaugeSubItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = SenateGaugeSubItemsDA.GetObjByDataRow(objRow);
 return objSenateGaugeSubItemsEN;
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
public static clsSenateGaugeSubItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = SenateGaugeSubItemsDA.GetObjByDataRow(objRow);
 return objSenateGaugeSubItemsEN;
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
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <param name = "lstSenateGaugeSubItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItemFromList(string strIdSenateGaugeSubItem, List<clsSenateGaugeSubItemsEN> lstSenateGaugeSubItemsObjLst)
{
foreach (clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN in lstSenateGaugeSubItemsObjLst)
{
if (objSenateGaugeSubItemsEN.IdSenateGaugeSubItem == strIdSenateGaugeSubItem)
{
return objSenateGaugeSubItemsEN;
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
 string strIdSenateGaugeSubItem;
 try
 {
 strIdSenateGaugeSubItem = new clsSenateGaugeSubItemsDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeSubItem;
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
 arrList = SenateGaugeSubItemsDA.GetID(strWhereCond);
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
bool bolIsExist = SenateGaugeSubItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeSubItem]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SenateGaugeSubItemsDA.IsExist(strIdSenateGaugeSubItem);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdSenateGaugeSubItem">量表指标子项流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdSenateGaugeSubItem, string strOpUser)
{
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = clsSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);
objSenateGaugeSubItemsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSenateGaugeSubItemsEN.UpdUserId = strOpUser;
return clsSenateGaugeSubItemsBL.UpdateBySql2(objSenateGaugeSubItemsEN);
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
 bolIsExist = clsSenateGaugeSubItemsDA.IsExistTable();
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
 bolIsExist = SenateGaugeSubItemsDA.IsExistTable(strTabName);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeSubItemsBL.IsExist(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SenateGaugeSubItemsDA.AddNewRecordBySQL2(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeSubItemsBL.IsExist(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SenateGaugeSubItemsDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
try
{
bool bolResult = SenateGaugeSubItemsDA.Update(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SenateGaugeSubItemsDA.UpdateBySql2(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsBL.ReFreshCache();

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdSenateGaugeSubItem)
{
try
{
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = clsSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);

if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(objSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objSenateGaugeSubItemsEN.UpdUserId);
}
if (objSenateGaugeSubItemsEN != null)
{
int intRecNum = SenateGaugeSubItemsDA.DelRecord(strIdSenateGaugeSubItem);
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
/// <param name="strIdSenateGaugeSubItem">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdSenateGaugeSubItem )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeSubItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSenateGaugeSubItems.IdSenateGaugeSubItem,
//strIdSenateGaugeSubItem);
//        clsSenateGaugeSubItemsBL.DelSenateGaugeSubItemssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeSubItemsBL.DelRecord(strIdSenateGaugeSubItem, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeSubItemsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeSubItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdSenateGaugeSubItem, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeSubItem, "UpdRelaTabDate");
}
bool bolResult = SenateGaugeSubItemsDA.DelRecord(strIdSenateGaugeSubItem,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdSenateGaugeSubItemLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSenateGaugeSubItemss(List<string> arrIdSenateGaugeSubItemLst)
{
if (arrIdSenateGaugeSubItemLst.Count == 0) return 0;
try
{
if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
foreach (var strIdSenateGaugeSubItem in arrIdSenateGaugeSubItemLst)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeSubItem, "UpdRelaTabDate");
}
}
int intDelRecNum = SenateGaugeSubItemsDA.DelSenateGaugeSubItems(arrIdSenateGaugeSubItemLst);
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
public static int DelSenateGaugeSubItemssByCond(string strWhereCond)
{
try
{
if (clsSenateGaugeSubItemsBL.relatedActions != null)
{
List<string> arrIdSenateGaugeSubItem = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdSenateGaugeSubItem in arrIdSenateGaugeSubItem)
{
clsSenateGaugeSubItemsBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeSubItem, "UpdRelaTabDate");
}
}
int intRecNum = SenateGaugeSubItemsDA.DelSenateGaugeSubItems(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SenateGaugeSubItems]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdSenateGaugeSubItem">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdSenateGaugeSubItem)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeSubItemsDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeSubItems]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeSubItemsBL.DelRecord(strIdSenateGaugeSubItem, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeSubItemsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeSubItem, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENS, clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENT)
{
try
{
objSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objSenateGaugeSubItemsENT.IdSenateGaugeItem = objSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objSenateGaugeSubItemsENT.senateGaugeSubItemID = objSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objSenateGaugeSubItemsENT.senateGaugeSubItemName = objSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objSenateGaugeSubItemsENT.senateGaugeSubItemScore = objSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objSenateGaugeSubItemsENT.AnswerTitle = objSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objSenateGaugeSubItemsENT.AnswerIndex = objSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objSenateGaugeSubItemsENT.UpdDate = objSenateGaugeSubItemsENS.UpdDate; //修改日期
objSenateGaugeSubItemsENT.UpdUserId = objSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
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
 /// <param name = "objSenateGaugeSubItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
try
{
objSenateGaugeSubItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSenateGaugeSubItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSenateGaugeSubItems.IdSenateGaugeSubItem, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objSenateGaugeSubItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
}
if (arrFldSet.Contains(conSenateGaugeSubItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.IdSenateGaugeItem = objSenateGaugeSubItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(conSenateGaugeSubItems.senateGaugeSubItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.senateGaugeSubItemID = objSenateGaugeSubItemsEN.senateGaugeSubItemID; //量表指标子项ID
}
if (arrFldSet.Contains(conSenateGaugeSubItems.senateGaugeSubItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.senateGaugeSubItemName = objSenateGaugeSubItemsEN.senateGaugeSubItemName; //量表指标子项名称
}
if (arrFldSet.Contains(conSenateGaugeSubItems.senateGaugeSubItemScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = objSenateGaugeSubItemsEN.senateGaugeSubItemScore; //量表指标子项分数
}
if (arrFldSet.Contains(conSenateGaugeSubItems.senateGaugeSubItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objSenateGaugeSubItemsEN.senateGaugeSubItemDesc == "[null]" ? null :  objSenateGaugeSubItemsEN.senateGaugeSubItemDesc; //量表指标子项说明
}
if (arrFldSet.Contains(conSenateGaugeSubItems.AnswerTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.AnswerTitle = objSenateGaugeSubItemsEN.AnswerTitle == "[null]" ? null :  objSenateGaugeSubItemsEN.AnswerTitle; //答案标题
}
if (arrFldSet.Contains(conSenateGaugeSubItems.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.AnswerIndex = objSenateGaugeSubItemsEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(conSenateGaugeSubItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.UpdDate = objSenateGaugeSubItemsEN.UpdDate == "[null]" ? null :  objSenateGaugeSubItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSenateGaugeSubItems.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.UpdUserId = objSenateGaugeSubItemsEN.UpdUserId == "[null]" ? null :  objSenateGaugeSubItemsEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSenateGaugeSubItems.senateGaugeSubItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objSenateGaugeSubItemsEN.senateGaugeSubItemMemo == "[null]" ? null :  objSenateGaugeSubItemsEN.senateGaugeSubItemMemo; //量表指标子项备注
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
 /// <param name = "objSenateGaugeSubItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
try
{
if (objSenateGaugeSubItemsEN.senateGaugeSubItemDesc == "[null]") objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = null; //量表指标子项说明
if (objSenateGaugeSubItemsEN.AnswerTitle == "[null]") objSenateGaugeSubItemsEN.AnswerTitle = null; //答案标题
if (objSenateGaugeSubItemsEN.UpdDate == "[null]") objSenateGaugeSubItemsEN.UpdDate = null; //修改日期
if (objSenateGaugeSubItemsEN.UpdUserId == "[null]") objSenateGaugeSubItemsEN.UpdUserId = null; //修改用户Id
if (objSenateGaugeSubItemsEN.senateGaugeSubItemMemo == "[null]") objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = null; //量表指标子项备注
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
public static void CheckPropertyNew(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 SenateGaugeSubItemsDA.CheckPropertyNew(objSenateGaugeSubItemsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 SenateGaugeSubItemsDA.CheckProperty4Condition(objSenateGaugeSubItemsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSenateGaugeSubItem(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeSubItems.IdSenateGaugeSubItem); 
List<clsSenateGaugeSubItemsEN> arrObjLst = clsSenateGaugeSubItemsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN()
{
IdSenateGaugeSubItem = "0",
senateGaugeSubItemName = "选[量表指标子项]..."
};
arrObjLst.Insert(0, objSenateGaugeSubItemsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGaugeSubItems.IdSenateGaugeSubItem;
objComboBox.DisplayMember = conSenateGaugeSubItems.senateGaugeSubItemName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdSenateGaugeSubItem(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标子项]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeSubItems.IdSenateGaugeSubItem); 
IEnumerable<clsSenateGaugeSubItemsEN> arrObjLst = clsSenateGaugeSubItemsBL.GetObjLst(strCondition);
objDDL.DataValueField = conSenateGaugeSubItems.IdSenateGaugeSubItem;
objDDL.DataTextField = conSenateGaugeSubItems.senateGaugeSubItemName;
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
public static void BindDdl_IdSenateGaugeSubItemCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标子项]...","0");
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst = GetAllSenateGaugeSubItemsObjLstCache(); 
objDDL.DataValueField = conSenateGaugeSubItems.IdSenateGaugeSubItem;
objDDL.DataTextField = conSenateGaugeSubItems.senateGaugeSubItemName;
objDDL.DataSource = arrSenateGaugeSubItemsObjLst;
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
if (clsSenateGaugeSubItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeSubItemsBL没有刷新缓存机制(clsSenateGaugeSubItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeSubItem");
//if (arrSenateGaugeSubItemsObjLstCache == null)
//{
//arrSenateGaugeSubItemsObjLstCache = SenateGaugeSubItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItemCache(string strIdSenateGaugeSubItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel =
arrSenateGaugeSubItemsObjLstCache
.Where(x=> x.IdSenateGaugeSubItem == strIdSenateGaugeSubItem 
);
if (arrSenateGaugeSubItemsObjLst_Sel.Count() == 0)
{
   clsSenateGaugeSubItemsEN obj = clsSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSenateGaugeSubItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeSubItemNameByIdSenateGaugeSubItemCache(string strIdSenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeSubItemsEN objSenateGaugeSubItems = GetObjByIdSenateGaugeSubItemCache(strIdSenateGaugeSubItem);
if (objSenateGaugeSubItems == null) return "";
return objSenateGaugeSubItems.senateGaugeSubItemName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSenateGaugeSubItemCache(string strIdSenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeSubItemsEN objSenateGaugeSubItems = GetObjByIdSenateGaugeSubItemCache(strIdSenateGaugeSubItem);
if (objSenateGaugeSubItems == null) return "";
return objSenateGaugeSubItems.senateGaugeSubItemName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetAllSenateGaugeSubItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLstCache = GetObjLstCache(); 
return arrSenateGaugeSubItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeSubItemsObjLstCache;
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
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeSubItemsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSenateGaugeSubItemsEN._RefreshTimeLst.Count == 0) return "";
return clsSenateGaugeSubItemsEN._RefreshTimeLst[clsSenateGaugeSubItemsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSenateGaugeSubItemsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeSubItemsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSenateGaugeSubItemsBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeSubItem)
{
if (strInFldName != conSenateGaugeSubItems.IdSenateGaugeSubItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSenateGaugeSubItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSenateGaugeSubItems.AttributeName));
throw new Exception(strMsg);
}
var objSenateGaugeSubItems = clsSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItemCache(strIdSenateGaugeSubItem);
if (objSenateGaugeSubItems == null) return "";
return objSenateGaugeSubItems[strOutFldName].ToString();
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
int intRecCount = clsSenateGaugeSubItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsSenateGaugeSubItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSenateGaugeSubItemsDA.GetRecCount();
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
int intRecCount = clsSenateGaugeSubItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsCond)
{
List<clsSenateGaugeSubItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeSubItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeSubItems.AttributeName)
{
if (objSenateGaugeSubItemsCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeSubItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeSubItemsCond[strFldName].ToString());
}
else
{
if (objSenateGaugeSubItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeSubItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeSubItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeSubItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeSubItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeSubItemsCond[strFldName]));
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
 List<string> arrList = clsSenateGaugeSubItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeSubItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeSubItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SenateGaugeSubItemsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeSubItemsDA.SetFldValue(clsSenateGaugeSubItemsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SenateGaugeSubItemsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeSubItemsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeSubItemsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeSubItemsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SenateGaugeSubItems] "); 
 strCreateTabCode.Append(" ( "); 
 // /**量表指标子项流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeSubItem char(4) primary key, "); 
 // /**量表指标流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeItem char(4) not Null, "); 
 // /**量表指标子项ID*/ 
 strCreateTabCode.Append(" senateGaugeSubItemID char(4) not Null, "); 
 // /**量表指标子项名称*/ 
 strCreateTabCode.Append(" senateGaugeSubItemName varchar(200) not Null, "); 
 // /**量表指标子项分数*/ 
 strCreateTabCode.Append(" senateGaugeSubItemScore float not Null, "); 
 // /**量表指标子项说明*/ 
 strCreateTabCode.Append(" senateGaugeSubItemDesc varchar(2000) Null, "); 
 // /**答案标题*/ 
 strCreateTabCode.Append(" AnswerTitle varchar(20) Null, "); 
 // /**问答序号*/ 
 strCreateTabCode.Append(" AnswerIndex int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**量表指标子项备注*/ 
 strCreateTabCode.Append(" senateGaugeSubItemMemo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 量表指标子项(SenateGaugeSubItems)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SenateGaugeSubItems : clsCommFun4BL
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
clsSenateGaugeSubItemsBL.ReFreshThisCache();
}
}

}