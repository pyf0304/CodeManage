﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewRelaTabBL
 表名:ViewRelaTab(00050100)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:02:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsViewRelaTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRelaTabEN GetObj(this K_mId_ViewRelaTab myKey)
{
clsViewRelaTabEN objViewRelaTabEN = clsViewRelaTabBL.ViewRelaTabDA.GetObjBymId(myKey.Value);
return objViewRelaTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewRelaTabEN objViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRelaTabEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],表ID = [{1}]的数据已经存在!(in clsViewRelaTabBL.AddNewRecord)", objViewRelaTabEN.ViewId,objViewRelaTabEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewRelaTabBL.ViewRelaTabDA.AddNewRecordBySQL2(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
public static bool AddRecordEx(this clsViewRelaTabEN objViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
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
objViewRelaTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewRelaTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(界面Id(ViewId)=[{0}],表ID(TabId)=[{1}])已经存在,不能重复!", objViewRelaTabEN.ViewId, objViewRelaTabEN.TabId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewRelaTabEN.AddNewRecord();
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewRelaTabEN objViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewRelaTabEN) == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],表ID = [{1}]的数据已经存在!(in clsViewRelaTabBL.AddNewRecordWithReturnKey)", objViewRelaTabEN.ViewId,objViewRelaTabEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewRelaTabBL.ViewRelaTabDA.AddNewRecordBySQL2WithReturnKey(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetmId(this clsViewRelaTabEN objViewRelaTabEN, long lngmId, string strComparisonOp="")
	{
objViewRelaTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.mId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.mId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.mId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetViewId(this clsViewRelaTabEN objViewRelaTabEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, conViewRelaTab.ViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewRelaTab.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewRelaTab.ViewId);
}
objViewRelaTabEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.ViewId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.ViewId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.ViewId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetRegionId(this clsViewRelaTabEN objViewRelaTabEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conViewRelaTab.RegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionId, 10, conViewRelaTab.RegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conViewRelaTab.RegionId);
}
objViewRelaTabEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.RegionId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.RegionId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.RegionId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetInOutTypeId(this clsViewRelaTabEN objViewRelaTabEN, string strInOutTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInOutTypeId, conViewRelaTab.InOutTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInOutTypeId, 2, conViewRelaTab.InOutTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strInOutTypeId, 2, conViewRelaTab.InOutTypeId);
}
objViewRelaTabEN.InOutTypeId = strInOutTypeId; //INOUT类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.InOutTypeId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.InOutTypeId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.InOutTypeId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetViewTabTypeId(this clsViewRelaTabEN objViewRelaTabEN, string strViewTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewTabTypeId, conViewRelaTab.ViewTabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewTabTypeId, 4, conViewRelaTab.ViewTabTypeId);
}
objViewRelaTabEN.ViewTabTypeId = strViewTabTypeId; //界面表类型码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.ViewTabTypeId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.ViewTabTypeId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.ViewTabTypeId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetTabId(this clsViewRelaTabEN objViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conViewRelaTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conViewRelaTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conViewRelaTab.TabId);
}
objViewRelaTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.TabId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.TabId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.TabId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetTabFunction(this clsViewRelaTabEN objViewRelaTabEN, string strTabFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFunction, 500, conViewRelaTab.TabFunction);
}
objViewRelaTabEN.TabFunction = strTabFunction; //表功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.TabFunction) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.TabFunction, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.TabFunction] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetPrjId(this clsViewRelaTabEN objViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewRelaTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewRelaTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewRelaTab.PrjId);
}
objViewRelaTabEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.PrjId) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.PrjId, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.PrjId] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetUpdDate(this clsViewRelaTabEN objViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewRelaTab.UpdDate);
}
objViewRelaTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.UpdDate) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.UpdDate, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.UpdDate] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetUpdUser(this clsViewRelaTabEN objViewRelaTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewRelaTab.UpdUser);
}
objViewRelaTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.UpdUser) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.UpdUser, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.UpdUser] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewRelaTabEN SetMemo(this clsViewRelaTabEN objViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewRelaTab.Memo);
}
objViewRelaTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewRelaTabEN.dicFldComparisonOp.ContainsKey(conViewRelaTab.Memo) == false)
{
objViewRelaTabEN.dicFldComparisonOp.Add(conViewRelaTab.Memo, strComparisonOp);
}
else
{
objViewRelaTabEN.dicFldComparisonOp[conViewRelaTab.Memo] = strComparisonOp;
}
}
return objViewRelaTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewRelaTabEN objViewRelaTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewRelaTabEN.CheckPropertyNew();
clsViewRelaTabEN objViewRelaTabCond = new clsViewRelaTabEN();
string strCondition = objViewRelaTabCond
.SetmId(objViewRelaTabEN.mId, "<>")
.SetViewId(objViewRelaTabEN.ViewId, "=")
.SetTabId(objViewRelaTabEN.TabId, "=")
.GetCombineCondition();
objViewRelaTabEN._IsCheckProperty = true;
bool bolIsExist = clsViewRelaTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewId_TabId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewRelaTabEN.Update();
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
 /// <param name = "objViewRelaTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewRelaTabEN objViewRelaTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewRelaTabEN objViewRelaTabCond = new clsViewRelaTabEN();
string strCondition = objViewRelaTabCond
.SetViewId(objViewRelaTab.ViewId, "=")
.SetTabId(objViewRelaTab.TabId, "=")
.GetCombineCondition();
objViewRelaTab._IsCheckProperty = true;
bool bolIsExist = clsViewRelaTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewRelaTab.mId = clsViewRelaTabBL.GetFirstID_S(strCondition);
objViewRelaTab.UpdateWithCondition(strCondition);
}
else
{
objViewRelaTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRelaTabEN objViewRelaTabEN)
{
 if (objViewRelaTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRelaTabBL.ViewRelaTabDA.UpdateBySql2(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewRelaTabEN objViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewRelaTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewRelaTabBL.ViewRelaTabDA.UpdateBySql2(objViewRelaTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRelaTabEN objViewRelaTabEN, string strWhereCond)
{
try
{
bool bolResult = clsViewRelaTabBL.ViewRelaTabDA.UpdateBySqlWithCondition(objViewRelaTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewRelaTabEN objViewRelaTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewRelaTabBL.ViewRelaTabDA.UpdateBySqlWithConditionTransaction(objViewRelaTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewRelaTabEN objViewRelaTabEN)
{
try
{
int intRecNum = clsViewRelaTabBL.ViewRelaTabDA.DelRecord(objViewRelaTabEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
 public static void CopyTo(this clsViewRelaTabEN objViewRelaTabENS, clsViewRelaTabEN objViewRelaTabENT)
{
try
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.InOutTypeId = objViewRelaTabENS.InOutTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.PrjId = objViewRelaTabENS.PrjId; //工程ID
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
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
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <returns>目标对象=>clsViewRelaTabEN:objViewRelaTabENT</returns>
 public static clsViewRelaTabEN CopyTo(this clsViewRelaTabEN objViewRelaTabENS)
{
try
{
 clsViewRelaTabEN objViewRelaTabENT = new clsViewRelaTabEN()
{
mId = objViewRelaTabENS.mId, //mId
ViewId = objViewRelaTabENS.ViewId, //界面Id
RegionId = objViewRelaTabENS.RegionId, //区域Id
InOutTypeId = objViewRelaTabENS.InOutTypeId, //INOUT类型ID
ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId, //界面表类型码
TabId = objViewRelaTabENS.TabId, //表ID
TabFunction = objViewRelaTabENS.TabFunction, //表功能说明
PrjId = objViewRelaTabENS.PrjId, //工程ID
UpdDate = objViewRelaTabENS.UpdDate, //修改日期
UpdUser = objViewRelaTabENS.UpdUser, //修改者
Memo = objViewRelaTabENS.Memo, //说明
};
 return objViewRelaTabENT;
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
public static void CheckPropertyNew(this clsViewRelaTabEN objViewRelaTabEN)
{
 clsViewRelaTabBL.ViewRelaTabDA.CheckPropertyNew(objViewRelaTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewRelaTabEN objViewRelaTabEN)
{
 clsViewRelaTabBL.ViewRelaTabDA.CheckProperty4Condition(objViewRelaTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewRelaTabEN objViewRelaTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.mId) == true)
{
string strComparisonOpmId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewRelaTab.mId, objViewRelaTabCond.mId, strComparisonOpmId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.ViewId) == true)
{
string strComparisonOpViewId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.ViewId, objViewRelaTabCond.ViewId, strComparisonOpViewId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.RegionId) == true)
{
string strComparisonOpRegionId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.RegionId, objViewRelaTabCond.RegionId, strComparisonOpRegionId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.InOutTypeId) == true)
{
string strComparisonOpInOutTypeId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.InOutTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.InOutTypeId, objViewRelaTabCond.InOutTypeId, strComparisonOpInOutTypeId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.ViewTabTypeId) == true)
{
string strComparisonOpViewTabTypeId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.ViewTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.ViewTabTypeId, objViewRelaTabCond.ViewTabTypeId, strComparisonOpViewTabTypeId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.TabId) == true)
{
string strComparisonOpTabId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.TabId, objViewRelaTabCond.TabId, strComparisonOpTabId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.TabFunction) == true)
{
string strComparisonOpTabFunction = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.TabFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.TabFunction, objViewRelaTabCond.TabFunction, strComparisonOpTabFunction);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.PrjId) == true)
{
string strComparisonOpPrjId = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.PrjId, objViewRelaTabCond.PrjId, strComparisonOpPrjId);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.UpdDate, objViewRelaTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.UpdUser, objViewRelaTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewRelaTabCond.IsUpdated(conViewRelaTab.Memo) == true)
{
string strComparisonOpMemo = objViewRelaTabCond.dicFldComparisonOp[conViewRelaTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewRelaTab.Memo, objViewRelaTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewRelaTab(界面相关表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewRelaTabEN objViewRelaTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewRelaTabEN == null) return true;
if (objViewRelaTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRelaTabEN.ViewId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objViewRelaTabEN.TabId);
if (clsViewRelaTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewRelaTabEN.mId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRelaTabEN.ViewId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objViewRelaTabEN.TabId);
if (clsViewRelaTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewRelaTab(界面相关表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewRelaTabEN objViewRelaTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewRelaTabEN == null) return "";
if (objViewRelaTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRelaTabEN.ViewId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objViewRelaTabEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewRelaTabEN.mId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewRelaTabEN.ViewId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objViewRelaTabEN.TabId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewRelaTab
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面相关表(ViewRelaTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewRelaTabBL
{
public static RelatedActions_ViewRelaTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewRelaTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewRelaTabDA ViewRelaTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewRelaTabDA();
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
 public clsViewRelaTabBL()
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
if (string.IsNullOrEmpty(clsViewRelaTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewRelaTabEN._ConnectString);
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
public static DataTable GetDataTable_ViewRelaTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewRelaTabDA.GetDataTable_ViewRelaTab(strWhereCond);
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
objDT = ViewRelaTabDA.GetDataTable(strWhereCond);
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
objDT = ViewRelaTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewRelaTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewRelaTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewRelaTabDA.GetDataTable_Top(objTopPara);
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
objDT = ViewRelaTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewRelaTabEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewRelaTabEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewRelaTabEN._CurrTabName, strPrjId);
List<clsViewRelaTabEN> arrViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRelaTabEN> arrViewRelaTabObjLst_Sel =
arrViewRelaTabObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRelaTabEN> GetObjLst(string strWhereCond)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
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
public static List<clsViewRelaTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewRelaTabEN> GetSubObjLstCache(clsViewRelaTabEN objViewRelaTabCond)
{
 string strPrjId = objViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewRelaTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRelaTab.AttributeName)
{
if (objViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRelaTabCond[strFldName].ToString());
}
else
{
if (objViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRelaTabCond[strFldName]));
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
public static List<clsViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
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
public static List<clsViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
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
List<clsViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
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
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
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
public static List<clsViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
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
public static List<clsViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewRelaTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewRelaTabEN> arrObjLst = new List<clsViewRelaTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewRelaTabEN objViewRelaTabEN = new clsViewRelaTabEN();
try
{
objViewRelaTabEN.mId = Int32.Parse(objRow[conViewRelaTab.mId].ToString().Trim()); //mId
objViewRelaTabEN.ViewId = objRow[conViewRelaTab.ViewId].ToString().Trim(); //界面Id
objViewRelaTabEN.RegionId = objRow[conViewRelaTab.RegionId].ToString().Trim(); //区域Id
objViewRelaTabEN.InOutTypeId = objRow[conViewRelaTab.InOutTypeId].ToString().Trim(); //INOUT类型ID
objViewRelaTabEN.ViewTabTypeId = objRow[conViewRelaTab.ViewTabTypeId].ToString().Trim(); //界面表类型码
objViewRelaTabEN.TabId = objRow[conViewRelaTab.TabId].ToString().Trim(); //表ID
objViewRelaTabEN.TabFunction = objRow[conViewRelaTab.TabFunction] == DBNull.Value ? null : objRow[conViewRelaTab.TabFunction].ToString().Trim(); //表功能说明
objViewRelaTabEN.PrjId = objRow[conViewRelaTab.PrjId].ToString().Trim(); //工程ID
objViewRelaTabEN.UpdDate = objRow[conViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objViewRelaTabEN.UpdUser = objRow[conViewRelaTab.UpdUser] == DBNull.Value ? null : objRow[conViewRelaTab.UpdUser].ToString().Trim(); //修改者
objViewRelaTabEN.Memo = objRow[conViewRelaTab.Memo] == DBNull.Value ? null : objRow[conViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewRelaTabEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewRelaTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewRelaTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewRelaTab(ref clsViewRelaTabEN objViewRelaTabEN)
{
bool bolResult = ViewRelaTabDA.GetViewRelaTab(ref objViewRelaTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewRelaTabEN GetObjBymId(long lngmId)
{
clsViewRelaTabEN objViewRelaTabEN = ViewRelaTabDA.GetObjBymId(lngmId);
return objViewRelaTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewRelaTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewRelaTabEN objViewRelaTabEN = ViewRelaTabDA.GetFirstObj(strWhereCond);
 return objViewRelaTabEN;
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
public static clsViewRelaTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewRelaTabEN objViewRelaTabEN = ViewRelaTabDA.GetObjByDataRow(objRow);
 return objViewRelaTabEN;
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
public static clsViewRelaTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewRelaTabEN objViewRelaTabEN = ViewRelaTabDA.GetObjByDataRow(objRow);
 return objViewRelaTabEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstViewRelaTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRelaTabEN GetObjBymIdFromList(long lngmId, List<clsViewRelaTabEN> lstViewRelaTabObjLst)
{
foreach (clsViewRelaTabEN objViewRelaTabEN in lstViewRelaTabObjLst)
{
if (objViewRelaTabEN.mId == lngmId)
{
return objViewRelaTabEN;
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
 long lngmId;
 try
 {
 lngmId = new clsViewRelaTabDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = ViewRelaTabDA.GetID(strWhereCond);
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
bool bolIsExist = ViewRelaTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = ViewRelaTabDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsViewRelaTabEN objViewRelaTabEN = clsViewRelaTabBL.GetObjBymId(lngmId);
objViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewRelaTabEN.UpdUser = strOpUser;
return clsViewRelaTabBL.UpdateBySql2(objViewRelaTabEN);
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
 bolIsExist = clsViewRelaTabDA.IsExistTable();
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
 bolIsExist = ViewRelaTabDA.IsExistTable(strTabName);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewRelaTabEN objViewRelaTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRelaTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],表ID = [{1}]的数据已经存在!(in clsViewRelaTabBL.AddNewRecordBySql2)", objViewRelaTabEN.ViewId,objViewRelaTabEN.TabId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewRelaTabDA.AddNewRecordBySQL2(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewRelaTabEN objViewRelaTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewRelaTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!界面Id = [{0}],表ID = [{1}]的数据已经存在!(in clsViewRelaTabBL.AddNewRecordBySql2WithReturnKey)", objViewRelaTabEN.ViewId,objViewRelaTabEN.TabId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewRelaTabDA.AddNewRecordBySQL2WithReturnKey(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewRelaTabEN objViewRelaTabEN)
{
try
{
bool bolResult = ViewRelaTabDA.Update(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "objViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewRelaTabEN objViewRelaTabEN)
{
 if (objViewRelaTabEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewRelaTabDA.UpdateBySql2(objViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewRelaTabBL.ReFreshCache(objViewRelaTabEN.PrjId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsViewRelaTabEN objViewRelaTabEN = clsViewRelaTabBL.GetObjBymId(lngmId);

if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(objViewRelaTabEN.mId, objViewRelaTabEN.UpdUser);
}
if (objViewRelaTabEN != null)
{
int intRecNum = ViewRelaTabDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRelaTabEN.PrjId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
//删除与表:[ViewRelaTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewRelaTab.mId,
//lngmId);
//        clsViewRelaTabBL.DelViewRelaTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRelaTabBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRelaTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewRelaTabBL.relatedActions != null)
{
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ViewRelaTabDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewRelaTabs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsViewRelaTabBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsViewRelaTabEN objViewRelaTabEN = clsViewRelaTabBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ViewRelaTabDA.DelViewRelaTab(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewRelaTabEN.PrjId);
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
public static int DelViewRelaTabsByCond(string strWhereCond)
{
try
{
if (clsViewRelaTabBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsViewRelaTabBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conViewRelaTab.PrjId, strWhereCond);
int intRecNum = ViewRelaTabDA.DelViewRelaTab(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewRelaTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewRelaTabDA.GetSpecSQLObj();
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
//删除与表:[ViewRelaTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewRelaTabBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewRelaTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewRelaTabENS">源对象</param>
 /// <param name = "objViewRelaTabENT">目标对象</param>
 public static void CopyTo(clsViewRelaTabEN objViewRelaTabENS, clsViewRelaTabEN objViewRelaTabENT)
{
try
{
objViewRelaTabENT.mId = objViewRelaTabENS.mId; //mId
objViewRelaTabENT.ViewId = objViewRelaTabENS.ViewId; //界面Id
objViewRelaTabENT.RegionId = objViewRelaTabENS.RegionId; //区域Id
objViewRelaTabENT.InOutTypeId = objViewRelaTabENS.InOutTypeId; //INOUT类型ID
objViewRelaTabENT.ViewTabTypeId = objViewRelaTabENS.ViewTabTypeId; //界面表类型码
objViewRelaTabENT.TabId = objViewRelaTabENS.TabId; //表ID
objViewRelaTabENT.TabFunction = objViewRelaTabENS.TabFunction; //表功能说明
objViewRelaTabENT.PrjId = objViewRelaTabENS.PrjId; //工程ID
objViewRelaTabENT.UpdDate = objViewRelaTabENS.UpdDate; //修改日期
objViewRelaTabENT.UpdUser = objViewRelaTabENS.UpdUser; //修改者
objViewRelaTabENT.Memo = objViewRelaTabENS.Memo; //说明
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
 /// <param name = "objViewRelaTabEN">源简化对象</param>
 public static void SetUpdFlag(clsViewRelaTabEN objViewRelaTabEN)
{
try
{
objViewRelaTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewRelaTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewRelaTab.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.mId = objViewRelaTabEN.mId; //mId
}
if (arrFldSet.Contains(conViewRelaTab.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.ViewId = objViewRelaTabEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewRelaTab.RegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.RegionId = objViewRelaTabEN.RegionId; //区域Id
}
if (arrFldSet.Contains(conViewRelaTab.InOutTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.InOutTypeId = objViewRelaTabEN.InOutTypeId; //INOUT类型ID
}
if (arrFldSet.Contains(conViewRelaTab.ViewTabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.ViewTabTypeId = objViewRelaTabEN.ViewTabTypeId; //界面表类型码
}
if (arrFldSet.Contains(conViewRelaTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.TabId = objViewRelaTabEN.TabId; //表ID
}
if (arrFldSet.Contains(conViewRelaTab.TabFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.TabFunction = objViewRelaTabEN.TabFunction == "[null]" ? null :  objViewRelaTabEN.TabFunction; //表功能说明
}
if (arrFldSet.Contains(conViewRelaTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.PrjId = objViewRelaTabEN.PrjId; //工程ID
}
if (arrFldSet.Contains(conViewRelaTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.UpdDate = objViewRelaTabEN.UpdDate == "[null]" ? null :  objViewRelaTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewRelaTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.UpdUser = objViewRelaTabEN.UpdUser == "[null]" ? null :  objViewRelaTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewRelaTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewRelaTabEN.Memo = objViewRelaTabEN.Memo == "[null]" ? null :  objViewRelaTabEN.Memo; //说明
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
 /// <param name = "objViewRelaTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewRelaTabEN objViewRelaTabEN)
{
try
{
if (objViewRelaTabEN.TabFunction == "[null]") objViewRelaTabEN.TabFunction = null; //表功能说明
if (objViewRelaTabEN.UpdDate == "[null]") objViewRelaTabEN.UpdDate = null; //修改日期
if (objViewRelaTabEN.UpdUser == "[null]") objViewRelaTabEN.UpdUser = null; //修改者
if (objViewRelaTabEN.Memo == "[null]") objViewRelaTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewRelaTabEN objViewRelaTabEN)
{
 ViewRelaTabDA.CheckPropertyNew(objViewRelaTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewRelaTabEN objViewRelaTabEN)
{
 ViewRelaTabDA.CheckProperty4Condition(objViewRelaTabEN);
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
if (clsViewRelaTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewRelaTabBL没有刷新缓存机制(clsViewRelaTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrViewRelaTabObjLstCache == null)
//{
//arrViewRelaTabObjLstCache = ViewRelaTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewRelaTabEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsViewRelaTabEN._CurrTabName, strPrjId);
List<clsViewRelaTabEN> arrViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRelaTabEN> arrViewRelaTabObjLst_Sel =
arrViewRelaTabObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrViewRelaTabObjLst_Sel.Count() == 0)
{
   clsViewRelaTabEN obj = clsViewRelaTabBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRelaTabEN> GetAllViewRelaTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewRelaTabEN> arrViewRelaTabObjLstCache = GetObjLstCache(strPrjId); 
return arrViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewRelaTabEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsViewRelaTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewRelaTabEN> arrViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewRelaTabObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewRelaTabEN._RefreshTimeLst.Count == 0) return "";
return clsViewRelaTabEN._RefreshTimeLst[clsViewRelaTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewRelaTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewRelaTabBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewRelaTab(界面相关表)
 /// 唯一性条件:ViewId_TabId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewRelaTabEN objViewRelaTabEN)
{
//检测记录是否存在
string strResult = ViewRelaTabDA.GetUniCondStr(objViewRelaTabEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conViewRelaTab.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewRelaTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewRelaTab.AttributeName));
throw new Exception(strMsg);
}
var objViewRelaTab = clsViewRelaTabBL.GetObjBymIdCache(lngmId, strPrjId);
if (objViewRelaTab == null) return "";
return objViewRelaTab[strOutFldName].ToString();
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
int intRecCount = clsViewRelaTabDA.GetRecCount(strTabName);
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
int intRecCount = clsViewRelaTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewRelaTabDA.GetRecCount();
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
int intRecCount = clsViewRelaTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewRelaTabEN objViewRelaTabCond)
{
 string strPrjId = objViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewRelaTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewRelaTab.AttributeName)
{
if (objViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRelaTabCond[strFldName].ToString());
}
else
{
if (objViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewRelaTabCond[strFldName]));
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
 List<string> arrList = clsViewRelaTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewRelaTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewRelaTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewRelaTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRelaTabDA.SetFldValue(clsViewRelaTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewRelaTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRelaTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewRelaTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewRelaTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewRelaTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) not Null, "); 
 // /**区域Id*/ 
 strCreateTabCode.Append(" RegionId char(10) not Null, "); 
 // /**INOUT类型ID*/ 
 strCreateTabCode.Append(" InOutTypeId char(2) not Null, "); 
 // /**界面表类型码*/ 
 strCreateTabCode.Append(" ViewTabTypeId varchar(4) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**表功能说明*/ 
 strCreateTabCode.Append(" TabFunction varchar(500) Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) not Null, "); 
 // /**视图中文名*/ 
 strCreateTabCode.Append(" ViewCnName varchar(100) Null, "); 
 // /**区域名称*/ 
 strCreateTabCode.Append(" RegionName varchar(50) not Null, "); 
 // /**区域类型名称*/ 
 strCreateTabCode.Append(" RegionTypeName varchar(30) not Null, "); 
 // /**INOUT类型名称*/ 
 strCreateTabCode.Append(" InOutTypeName varchar(30) not Null, "); 
 // /**ViewTabTypeName*/ 
 strCreateTabCode.Append(" ViewTabTypeName varchar(20) not Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**CM工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面相关表(ViewRelaTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewRelaTab : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsViewRelaTabBL.ReFreshThisCache(strPrjId);
}
}

}