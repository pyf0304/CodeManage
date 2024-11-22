
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLDataItemBL
 表名:DDLDataItem(01120050)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsDDLDataItemBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngDDLDataItemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLDataItemEN GetObj(this K_DDLDataItemId_DDLDataItem myKey)
{
clsDDLDataItemEN objDDLDataItemEN = clsDDLDataItemBL.DDLDataItemDA.GetObjByDDLDataItemId(myKey.Value);
return objDDLDataItemEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDDLDataItemEN objDDLDataItemEN)
{
if (CheckUniqueness(objDDLDataItemEN) == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],数据项文本 = [{1}]的数据已经存在!(in clsDDLDataItemBL.AddNewRecord)", objDDLDataItemEN.DDLTabId,objDDLDataItemEN.DataItemText);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDDLDataItemBL.DDLDataItemDA.AddNewRecordBySQL2(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
public static bool AddRecordEx(this clsDDLDataItemEN objDDLDataItemEN)
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
objDDLDataItemEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objDDLDataItemEN.CheckUniqueness() == false)
{
strMsg = string.Format("(下拉框表Id(DDLTabId)=[{0}],数据项文本(DataItemText)=[{1}])已经存在,不能重复!", objDDLDataItemEN.DDLTabId, objDDLDataItemEN.DataItemText);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDDLDataItemEN.AddNewRecord();
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDDLDataItemEN objDDLDataItemEN)
{
if (CheckUniqueness(objDDLDataItemEN) == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],数据项文本 = [{1}]的数据已经存在!(in clsDDLDataItemBL.AddNewRecordWithReturnKey)", objDDLDataItemEN.DDLTabId,objDDLDataItemEN.DataItemText);
throw new Exception(strMsg);
}
try
{
string strKey = clsDDLDataItemBL.DDLDataItemDA.AddNewRecordBySQL2WithReturnKey(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetDDLDataItemId(this clsDDLDataItemEN objDDLDataItemEN, long lngDDLDataItemId, string strComparisonOp="")
	{
objDDLDataItemEN.DDLDataItemId = lngDDLDataItemId; //下拉框数据项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DDLDataItemId) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DDLDataItemId, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DDLDataItemId] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetDDLTabId(this clsDDLDataItemEN objDDLDataItemEN, string strDDLTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDDLTabId, conDDLDataItem.DDLTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDDLTabId, 4, conDDLDataItem.DDLTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDDLTabId, 4, conDDLDataItem.DDLTabId);
}
objDDLDataItemEN.DDLTabId = strDDLTabId; //下拉框表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DDLTabId) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DDLTabId, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DDLTabId] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemNo(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataItemNo, conDDLDataItem.DataItemNo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataItemNo, 20, conDDLDataItem.DataItemNo);
}
objDDLDataItemEN.DataItemNo = strDataItemNo; //数据项编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemNo) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemNo, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemNo] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemText(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataItemText, conDDLDataItem.DataItemText);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataItemText, 30, conDDLDataItem.DataItemText);
}
objDDLDataItemEN.DataItemText = strDataItemText; //数据项文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemText) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemText, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemText] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetDataItemMemo(this clsDDLDataItemEN objDDLDataItemEN, string strDataItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataItemMemo, 500, conDDLDataItem.DataItemMemo);
}
objDDLDataItemEN.DataItemMemo = strDataItemMemo; //数据项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.DataItemMemo) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.DataItemMemo, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.DataItemMemo] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetUpdDate(this clsDDLDataItemEN objDDLDataItemEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDDLDataItem.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDDLDataItem.UpdDate);
}
objDDLDataItemEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.UpdDate) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.UpdDate, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.UpdDate] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetUpdUser(this clsDDLDataItemEN objDDLDataItemEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDDLDataItem.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDDLDataItem.UpdUser);
}
objDDLDataItemEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.UpdUser) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.UpdUser, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.UpdUser] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLDataItemEN SetOrderNum(this clsDDLDataItemEN objDDLDataItemEN, int? intOrderNum, string strComparisonOp="")
	{
objDDLDataItemEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLDataItemEN.dicFldComparisonOp.ContainsKey(conDDLDataItem.OrderNum) == false)
{
objDDLDataItemEN.dicFldComparisonOp.Add(conDDLDataItem.OrderNum, strComparisonOp);
}
else
{
objDDLDataItemEN.dicFldComparisonOp[conDDLDataItem.OrderNum] = strComparisonOp;
}
}
return objDDLDataItemEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDDLDataItemEN objDDLDataItemEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDDLDataItemEN.CheckPropertyNew();
clsDDLDataItemEN objDDLDataItemCond = new clsDDLDataItemEN();
string strCondition = objDDLDataItemCond
.SetDDLDataItemId(objDDLDataItemEN.DDLDataItemId, "<>")
.SetDDLTabId(objDDLDataItemEN.DDLTabId, "=")
.SetDataItemText(objDDLDataItemEN.DataItemText, "=")
.GetCombineCondition();
objDDLDataItemEN._IsCheckProperty = true;
bool bolIsExist = clsDDLDataItemBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DDLTabId_DataItemText)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDDLDataItemEN.Update();
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
 /// <param name = "objDDLDataItem">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDDLDataItemEN objDDLDataItem)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDDLDataItemEN objDDLDataItemCond = new clsDDLDataItemEN();
string strCondition = objDDLDataItemCond
.SetDDLTabId(objDDLDataItem.DDLTabId, "=")
.SetDataItemText(objDDLDataItem.DataItemText, "=")
.GetCombineCondition();
objDDLDataItem._IsCheckProperty = true;
bool bolIsExist = clsDDLDataItemBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDDLDataItem.DDLDataItemId = clsDDLDataItemBL.GetFirstID_S(strCondition);
objDDLDataItem.UpdateWithCondition(strCondition);
}
else
{
objDDLDataItem.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLDataItemEN objDDLDataItemEN)
{
 if (objDDLDataItemEN.DDLDataItemId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLDataItemBL.DDLDataItemDA.UpdateBySql2(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLDataItemEN objDDLDataItemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDDLDataItemEN.DDLDataItemId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLDataItemBL.DDLDataItemDA.UpdateBySql2(objDDLDataItemEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLDataItemEN objDDLDataItemEN, string strWhereCond)
{
try
{
bool bolResult = clsDDLDataItemBL.DDLDataItemDA.UpdateBySqlWithCondition(objDDLDataItemEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLDataItemEN objDDLDataItemEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDDLDataItemBL.DDLDataItemDA.UpdateBySqlWithConditionTransaction(objDDLDataItemEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "lngDDLDataItemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsDDLDataItemEN objDDLDataItemEN)
{
try
{
int intRecNum = clsDDLDataItemBL.DDLDataItemDA.DelRecord(objDDLDataItemEN.DDLDataItemId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemENS">源对象</param>
 /// <param name = "objDDLDataItemENT">目标对象</param>
 public static void CopyTo(this clsDDLDataItemEN objDDLDataItemENS, clsDDLDataItemEN objDDLDataItemENT)
{
try
{
objDDLDataItemENT.DDLDataItemId = objDDLDataItemENS.DDLDataItemId; //下拉框数据项Id
objDDLDataItemENT.DDLTabId = objDDLDataItemENS.DDLTabId; //下拉框表Id
objDDLDataItemENT.DataItemNo = objDDLDataItemENS.DataItemNo; //数据项编号
objDDLDataItemENT.DataItemText = objDDLDataItemENS.DataItemText; //数据项文本
objDDLDataItemENT.DataItemMemo = objDDLDataItemENS.DataItemMemo; //数据项备注
objDDLDataItemENT.UpdDate = objDDLDataItemENS.UpdDate; //修改日期
objDDLDataItemENT.UpdUser = objDDLDataItemENS.UpdUser; //修改人
objDDLDataItemENT.OrderNum = objDDLDataItemENS.OrderNum; //序号
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
 /// <param name = "objDDLDataItemENS">源对象</param>
 /// <returns>目标对象=>clsDDLDataItemEN:objDDLDataItemENT</returns>
 public static clsDDLDataItemEN CopyTo(this clsDDLDataItemEN objDDLDataItemENS)
{
try
{
 clsDDLDataItemEN objDDLDataItemENT = new clsDDLDataItemEN()
{
DDLDataItemId = objDDLDataItemENS.DDLDataItemId, //下拉框数据项Id
DDLTabId = objDDLDataItemENS.DDLTabId, //下拉框表Id
DataItemNo = objDDLDataItemENS.DataItemNo, //数据项编号
DataItemText = objDDLDataItemENS.DataItemText, //数据项文本
DataItemMemo = objDDLDataItemENS.DataItemMemo, //数据项备注
UpdDate = objDDLDataItemENS.UpdDate, //修改日期
UpdUser = objDDLDataItemENS.UpdUser, //修改人
OrderNum = objDDLDataItemENS.OrderNum, //序号
};
 return objDDLDataItemENT;
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
public static void CheckPropertyNew(this clsDDLDataItemEN objDDLDataItemEN)
{
 clsDDLDataItemBL.DDLDataItemDA.CheckPropertyNew(objDDLDataItemEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDDLDataItemEN objDDLDataItemEN)
{
 clsDDLDataItemBL.DDLDataItemDA.CheckProperty4Condition(objDDLDataItemEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDDLDataItemEN objDDLDataItemCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.DDLDataItemId) == true)
{
string strComparisonOpDDLDataItemId = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.DDLDataItemId];
strWhereCond += string.Format(" And {0} {2} {1}", conDDLDataItem.DDLDataItemId, objDDLDataItemCond.DDLDataItemId, strComparisonOpDDLDataItemId);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.DDLTabId) == true)
{
string strComparisonOpDDLTabId = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.DDLTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DDLTabId, objDDLDataItemCond.DDLTabId, strComparisonOpDDLTabId);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.DataItemNo) == true)
{
string strComparisonOpDataItemNo = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.DataItemNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemNo, objDDLDataItemCond.DataItemNo, strComparisonOpDataItemNo);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.DataItemText) == true)
{
string strComparisonOpDataItemText = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.DataItemText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemText, objDDLDataItemCond.DataItemText, strComparisonOpDataItemText);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.DataItemMemo) == true)
{
string strComparisonOpDataItemMemo = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.DataItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.DataItemMemo, objDDLDataItemCond.DataItemMemo, strComparisonOpDataItemMemo);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.UpdDate) == true)
{
string strComparisonOpUpdDate = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.UpdDate, objDDLDataItemCond.UpdDate, strComparisonOpUpdDate);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.UpdUser) == true)
{
string strComparisonOpUpdUser = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLDataItem.UpdUser, objDDLDataItemCond.UpdUser, strComparisonOpUpdUser);
}
if (objDDLDataItemCond.IsUpdated(conDDLDataItem.OrderNum) == true)
{
string strComparisonOpOrderNum = objDDLDataItemCond.dicFldComparisonOp[conDDLDataItem.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDDLDataItem.OrderNum, objDDLDataItemCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DDLDataItem(下拉框数据项), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DDLTabId_DataItemText
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDDLDataItemEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDDLDataItemEN objDDLDataItemEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDDLDataItemEN == null) return true;
if (objDDLDataItemEN.DDLDataItemId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
if (clsDDLDataItemBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DDLDataItemId !=  {0}", objDDLDataItemEN.DDLDataItemId);
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
if (clsDDLDataItemBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DDLDataItem(下拉框数据项), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DDLTabId_DataItemText
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDDLDataItemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDDLDataItemEN objDDLDataItemEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDDLDataItemEN == null) return "";
if (objDDLDataItemEN.DDLDataItemId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DDLDataItemId !=  {0}", objDDLDataItemEN.DDLDataItemId);
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLDataItemEN.DDLTabId);
 sbCondition.AppendFormat(" and DataItemText = '{0}'", objDDLDataItemEN.DataItemText);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DDLDataItem
{
public virtual bool UpdRelaTabDate(long lngDDLDataItemId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 下拉框数据项(DDLDataItem)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDDLDataItemBL
{
public static RelatedActions_DDLDataItem relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDDLDataItemDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDDLDataItemDA DDLDataItemDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDDLDataItemDA();
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
 public clsDDLDataItemBL()
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
if (string.IsNullOrEmpty(clsDDLDataItemEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDDLDataItemEN._ConnectString);
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
public static DataTable GetDataTable_DDLDataItem(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DDLDataItemDA.GetDataTable_DDLDataItem(strWhereCond);
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
objDT = DDLDataItemDA.GetDataTable(strWhereCond);
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
objDT = DDLDataItemDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DDLDataItemDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DDLDataItemDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DDLDataItemDA.GetDataTable_Top(objTopPara);
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
objDT = DDLDataItemDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DDLDataItemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DDLDataItemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDDLDataItemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLstByDDLDataItemIdLst(List<long> arrDDLDataItemIdLst)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDDLDataItemIdLst);
 string strWhereCond = string.Format("DDLDataItemId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDDLDataItemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDDLDataItemEN> GetObjLstByDDLDataItemIdLstCache(List<long> arrDDLDataItemIdLst)
{
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName);
List<clsDDLDataItemEN> arrDDLDataItemObjLstCache = GetObjLstCache();
IEnumerable <clsDDLDataItemEN> arrDDLDataItemObjLst_Sel =
arrDDLDataItemObjLstCache
.Where(x => arrDDLDataItemIdLst.Contains(x.DDLDataItemId));
return arrDDLDataItemObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLst(string strWhereCond)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
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
public static List<clsDDLDataItemEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDDLDataItemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDDLDataItemEN> GetSubObjLstCache(clsDDLDataItemEN objDDLDataItemCond)
{
List<clsDDLDataItemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLDataItemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLDataItem.AttributeName)
{
if (objDDLDataItemCond.IsUpdated(strFldName) == false) continue;
if (objDDLDataItemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLDataItemCond[strFldName].ToString());
}
else
{
if (objDDLDataItemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLDataItemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLDataItemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLDataItemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLDataItemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLDataItemCond[strFldName]));
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
public static List<clsDDLDataItemEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
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
public static List<clsDDLDataItemEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
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
List<clsDDLDataItemEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDDLDataItemEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLDataItemEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDDLDataItemEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
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
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
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
public static List<clsDDLDataItemEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDDLDataItemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
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
public static List<clsDDLDataItemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDDLDataItemEN> arrObjLst = new List<clsDDLDataItemEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLDataItemEN objDDLDataItemEN = new clsDDLDataItemEN();
try
{
objDDLDataItemEN.DDLDataItemId = Int32.Parse(objRow[conDDLDataItem.DDLDataItemId].ToString().Trim()); //下拉框数据项Id
objDDLDataItemEN.DDLTabId = objRow[conDDLDataItem.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLDataItemEN.DataItemNo = objRow[conDDLDataItem.DataItemNo].ToString().Trim(); //数据项编号
objDDLDataItemEN.DataItemText = objRow[conDDLDataItem.DataItemText].ToString().Trim(); //数据项文本
objDDLDataItemEN.DataItemMemo = objRow[conDDLDataItem.DataItemMemo] == DBNull.Value ? null : objRow[conDDLDataItem.DataItemMemo].ToString().Trim(); //数据项备注
objDDLDataItemEN.UpdDate = objRow[conDDLDataItem.UpdDate].ToString().Trim(); //修改日期
objDDLDataItemEN.UpdUser = objRow[conDDLDataItem.UpdUser].ToString().Trim(); //修改人
objDDLDataItemEN.OrderNum = objRow[conDDLDataItem.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDDLDataItem.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLDataItemEN.DDLDataItemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLDataItemEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDDLDataItemEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDDLDataItem(ref clsDDLDataItemEN objDDLDataItemEN)
{
bool bolResult = DDLDataItemDA.GetDDLDataItem(ref objDDLDataItemEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngDDLDataItemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemId(long lngDDLDataItemId)
{
clsDDLDataItemEN objDDLDataItemEN = DDLDataItemDA.GetObjByDDLDataItemId(lngDDLDataItemId);
return objDDLDataItemEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDDLDataItemEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDDLDataItemEN objDDLDataItemEN = DDLDataItemDA.GetFirstObj(strWhereCond);
 return objDDLDataItemEN;
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
public static clsDDLDataItemEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDDLDataItemEN objDDLDataItemEN = DDLDataItemDA.GetObjByDataRow(objRow);
 return objDDLDataItemEN;
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
public static clsDDLDataItemEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDDLDataItemEN objDDLDataItemEN = DDLDataItemDA.GetObjByDataRow(objRow);
 return objDDLDataItemEN;
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
 /// <param name = "lngDDLDataItemId">所给的关键字</param>
 /// <param name = "lstDDLDataItemObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemIdFromList(long lngDDLDataItemId, List<clsDDLDataItemEN> lstDDLDataItemObjLst)
{
foreach (clsDDLDataItemEN objDDLDataItemEN in lstDDLDataItemObjLst)
{
if (objDDLDataItemEN.DDLDataItemId == lngDDLDataItemId)
{
return objDDLDataItemEN;
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
 long lngDDLDataItemId;
 try
 {
 lngDDLDataItemId = new clsDDLDataItemDA().GetFirstID(strWhereCond);
 return lngDDLDataItemId;
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
 arrList = DDLDataItemDA.GetID(strWhereCond);
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
bool bolIsExist = DDLDataItemDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngDDLDataItemId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngDDLDataItemId)
{
//检测记录是否存在
bool bolIsExist = DDLDataItemDA.IsExist(lngDDLDataItemId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngDDLDataItemId">下拉框数据项Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngDDLDataItemId, string strOpUser)
{
clsDDLDataItemEN objDDLDataItemEN = clsDDLDataItemBL.GetObjByDDLDataItemId(lngDDLDataItemId);
objDDLDataItemEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDDLDataItemEN.UpdUser = strOpUser;
return clsDDLDataItemBL.UpdateBySql2(objDDLDataItemEN);
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
 bolIsExist = clsDDLDataItemDA.IsExistTable();
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
 bolIsExist = DDLDataItemDA.IsExistTable(strTabName);
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDDLDataItemEN objDDLDataItemEN)
{
if (objDDLDataItemEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],数据项文本 = [{1}]的数据已经存在!(in clsDDLDataItemBL.AddNewRecordBySql2)", objDDLDataItemEN.DDLTabId,objDDLDataItemEN.DataItemText);
throw new Exception(strMsg);
}
try
{
bool bolResult = DDLDataItemDA.AddNewRecordBySQL2(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDDLDataItemEN objDDLDataItemEN)
{
if (objDDLDataItemEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],数据项文本 = [{1}]的数据已经存在!(in clsDDLDataItemBL.AddNewRecordBySql2WithReturnKey)", objDDLDataItemEN.DDLTabId,objDDLDataItemEN.DataItemText);
throw new Exception(strMsg);
}
try
{
string strKey = DDLDataItemDA.AddNewRecordBySQL2WithReturnKey(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDDLDataItemEN objDDLDataItemEN)
{
try
{
bool bolResult = DDLDataItemDA.Update(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "objDDLDataItemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDDLDataItemEN objDDLDataItemEN)
{
 if (objDDLDataItemEN.DDLDataItemId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DDLDataItemDA.UpdateBySql2(objDDLDataItemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLDataItemBL.ReFreshCache();

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
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
 /// <param name = "lngDDLDataItemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngDDLDataItemId)
{
try
{
 clsDDLDataItemEN objDDLDataItemEN = clsDDLDataItemBL.GetObjByDDLDataItemId(lngDDLDataItemId);

if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(objDDLDataItemEN.DDLDataItemId, objDDLDataItemEN.UpdUser);
}
if (objDDLDataItemEN != null)
{
int intRecNum = DDLDataItemDA.DelRecord(lngDDLDataItemId);
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
/// <param name="lngDDLDataItemId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngDDLDataItemId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDDLDataItemDA.GetSpecSQLObj();
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
//删除与表:[DDLDataItem]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDDLDataItem.DDLDataItemId,
//lngDDLDataItemId);
//        clsDDLDataItemBL.DelDDLDataItemsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLDataItemBL.DelRecord(lngDDLDataItemId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLDataItemBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngDDLDataItemId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngDDLDataItemId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngDDLDataItemId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsDDLDataItemBL.relatedActions != null)
{
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(lngDDLDataItemId, "UpdRelaTabDate");
}
bool bolResult = DDLDataItemDA.DelRecord(lngDDLDataItemId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrDDLDataItemIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelDDLDataItems(List<string> arrDDLDataItemIdLst)
{
if (arrDDLDataItemIdLst.Count == 0) return 0;
try
{
if (clsDDLDataItemBL.relatedActions != null)
{
foreach (var strDDLDataItemId in arrDDLDataItemIdLst)
{
long lngDDLDataItemId = long.Parse(strDDLDataItemId);
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(lngDDLDataItemId, "UpdRelaTabDate");
}
}
int intDelRecNum = DDLDataItemDA.DelDDLDataItem(arrDDLDataItemIdLst);
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
public static int DelDDLDataItemsByCond(string strWhereCond)
{
try
{
if (clsDDLDataItemBL.relatedActions != null)
{
List<string> arrDDLDataItemId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strDDLDataItemId in arrDDLDataItemId)
{
long lngDDLDataItemId = long.Parse(strDDLDataItemId);
clsDDLDataItemBL.relatedActions.UpdRelaTabDate(lngDDLDataItemId, "UpdRelaTabDate");
}
}
int intRecNum = DDLDataItemDA.DelDDLDataItem(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DDLDataItem]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngDDLDataItemId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngDDLDataItemId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDDLDataItemDA.GetSpecSQLObj();
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
//删除与表:[DDLDataItem]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLDataItemBL.DelRecord(lngDDLDataItemId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLDataItemBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngDDLDataItemId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDDLDataItemENS">源对象</param>
 /// <param name = "objDDLDataItemENT">目标对象</param>
 public static void CopyTo(clsDDLDataItemEN objDDLDataItemENS, clsDDLDataItemEN objDDLDataItemENT)
{
try
{
objDDLDataItemENT.DDLDataItemId = objDDLDataItemENS.DDLDataItemId; //下拉框数据项Id
objDDLDataItemENT.DDLTabId = objDDLDataItemENS.DDLTabId; //下拉框表Id
objDDLDataItemENT.DataItemNo = objDDLDataItemENS.DataItemNo; //数据项编号
objDDLDataItemENT.DataItemText = objDDLDataItemENS.DataItemText; //数据项文本
objDDLDataItemENT.DataItemMemo = objDDLDataItemENS.DataItemMemo; //数据项备注
objDDLDataItemENT.UpdDate = objDDLDataItemENS.UpdDate; //修改日期
objDDLDataItemENT.UpdUser = objDDLDataItemENS.UpdUser; //修改人
objDDLDataItemENT.OrderNum = objDDLDataItemENS.OrderNum; //序号
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
 /// <param name = "objDDLDataItemEN">源简化对象</param>
 public static void SetUpdFlag(clsDDLDataItemEN objDDLDataItemEN)
{
try
{
objDDLDataItemEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDDLDataItemEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDDLDataItem.DDLDataItemId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.DDLDataItemId = objDDLDataItemEN.DDLDataItemId; //下拉框数据项Id
}
if (arrFldSet.Contains(conDDLDataItem.DDLTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.DDLTabId = objDDLDataItemEN.DDLTabId; //下拉框表Id
}
if (arrFldSet.Contains(conDDLDataItem.DataItemNo, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.DataItemNo = objDDLDataItemEN.DataItemNo; //数据项编号
}
if (arrFldSet.Contains(conDDLDataItem.DataItemText, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.DataItemText = objDDLDataItemEN.DataItemText; //数据项文本
}
if (arrFldSet.Contains(conDDLDataItem.DataItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.DataItemMemo = objDDLDataItemEN.DataItemMemo == "[null]" ? null :  objDDLDataItemEN.DataItemMemo; //数据项备注
}
if (arrFldSet.Contains(conDDLDataItem.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.UpdDate = objDDLDataItemEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDDLDataItem.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.UpdUser = objDDLDataItemEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conDDLDataItem.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLDataItemEN.OrderNum = objDDLDataItemEN.OrderNum; //序号
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
 /// <param name = "objDDLDataItemEN">源简化对象</param>
 public static void AccessFldValueNull(clsDDLDataItemEN objDDLDataItemEN)
{
try
{
if (objDDLDataItemEN.DataItemMemo == "[null]") objDDLDataItemEN.DataItemMemo = null; //数据项备注
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
public static void CheckPropertyNew(clsDDLDataItemEN objDDLDataItemEN)
{
 DDLDataItemDA.CheckPropertyNew(objDDLDataItemEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDDLDataItemEN objDDLDataItemEN)
{
 DDLDataItemDA.CheckProperty4Condition(objDDLDataItemEN);
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
if (clsDDLDataItemBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDDLDataItemBL没有刷新缓存机制(clsDDLDataItemBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DDLDataItemId");
//if (arrDDLDataItemObjLstCache == null)
//{
//arrDDLDataItemObjLstCache = DDLDataItemDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngDDLDataItemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLDataItemEN GetObjByDDLDataItemIdCache(long lngDDLDataItemId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName);
List<clsDDLDataItemEN> arrDDLDataItemObjLstCache = GetObjLstCache();
IEnumerable <clsDDLDataItemEN> arrDDLDataItemObjLst_Sel =
arrDDLDataItemObjLstCache
.Where(x=> x.DDLDataItemId == lngDDLDataItemId 
);
if (arrDDLDataItemObjLst_Sel.Count() == 0)
{
   clsDDLDataItemEN obj = clsDDLDataItemBL.GetObjByDDLDataItemId(lngDDLDataItemId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDDLDataItemObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLDataItemEN> GetAllDDLDataItemObjLstCache()
{
//获取缓存中的对象列表
List<clsDDLDataItemEN> arrDDLDataItemObjLstCache = GetObjLstCache(); 
return arrDDLDataItemObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLDataItemEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName);
List<clsDDLDataItemEN> arrDDLDataItemObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDDLDataItemObjLstCache;
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
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName);
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
if (clsDDLDataItemBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDDLDataItemEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDDLDataItemBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DDLDataItem(下拉框数据项)
 /// 唯一性条件:DDLTabId_DataItemText
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDDLDataItemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDDLDataItemEN objDDLDataItemEN)
{
//检测记录是否存在
string strResult = DDLDataItemDA.GetUniCondStr(objDDLDataItemEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngDDLDataItemId)
{
if (strInFldName != conDDLDataItem.DDLDataItemId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDDLDataItem.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDDLDataItem.AttributeName));
throw new Exception(strMsg);
}
var objDDLDataItem = clsDDLDataItemBL.GetObjByDDLDataItemIdCache(lngDDLDataItemId);
if (objDDLDataItem == null) return "";
return objDDLDataItem[strOutFldName].ToString();
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
int intRecCount = clsDDLDataItemDA.GetRecCount(strTabName);
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
int intRecCount = clsDDLDataItemDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDDLDataItemDA.GetRecCount();
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
int intRecCount = clsDDLDataItemDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDDLDataItemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDDLDataItemEN objDDLDataItemCond)
{
List<clsDDLDataItemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLDataItemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLDataItem.AttributeName)
{
if (objDDLDataItemCond.IsUpdated(strFldName) == false) continue;
if (objDDLDataItemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLDataItemCond[strFldName].ToString());
}
else
{
if (objDDLDataItemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLDataItemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLDataItemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLDataItemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLDataItemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLDataItemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLDataItemCond[strFldName]));
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
 List<string> arrList = clsDDLDataItemDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DDLDataItemDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DDLDataItemDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DDLDataItemDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLDataItemDA.SetFldValue(clsDDLDataItemEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DDLDataItemDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLDataItemDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLDataItemDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLDataItemDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DDLDataItem] "); 
 strCreateTabCode.Append(" ( "); 
 // /**下拉框数据项Id*/ 
 strCreateTabCode.Append(" DDLDataItemId bigint primary key identity, "); 
 // /**下拉框表Id*/ 
 strCreateTabCode.Append(" DDLTabId char(4) not Null, "); 
 // /**数据项编号*/ 
 strCreateTabCode.Append(" DataItemNo varchar(20) not Null, "); 
 // /**数据项文本*/ 
 strCreateTabCode.Append(" DataItemText varchar(30) not Null, "); 
 // /**数据项备注*/ 
 strCreateTabCode.Append(" DataItemMemo varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 下拉框数据项(DDLDataItem)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DDLDataItem : clsCommFun4BL
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
clsDDLDataItemBL.ReFreshThisCache();
}
}

}