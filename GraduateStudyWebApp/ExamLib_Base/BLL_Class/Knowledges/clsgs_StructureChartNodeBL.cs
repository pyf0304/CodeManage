﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_StructureChartNodeBL
 表名:gs_StructureChartNode(01120877)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsgs_StructureChartNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_StructureChartNodeEN GetObj(this K_mId_gs_StructureChartNode myKey)
{
clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.GetObjBymId(myKey.Value);
return objgs_StructureChartNodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_StructureChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_StructureChartNodeBL.AddNewRecord)", objgs_StructureChartNodeEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.AddNewRecordBySQL2(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_StructureChartNodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_StructureChartNodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objgs_StructureChartNodeEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_StructureChartNodeEN.AddNewRecord();
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_StructureChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_StructureChartNodeBL.AddNewRecordWithReturnKey)", objgs_StructureChartNodeEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.AddNewRecordBySQL2WithReturnKey(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetmId(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, long lngmId, string strComparisonOp="")
	{
objgs_StructureChartNodeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.mId) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.mId, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.mId] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetStructureChartId(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strStructureChartId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStructureChartId, congs_StructureChartNode.StructureChartId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureChartId, 10, congs_StructureChartNode.StructureChartId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureChartId, 10, congs_StructureChartNode.StructureChartId);
}
objgs_StructureChartNodeEN.StructureChartId = strStructureChartId; //结构图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.StructureChartId) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.StructureChartId, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.StructureChartId] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetNodeId(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNodeId, congs_StructureChartNode.NodeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNodeId, 20, congs_StructureChartNode.NodeId);
}
objgs_StructureChartNodeEN.NodeId = strNodeId; //节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.NodeId) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.NodeId, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.NodeId] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetNodeTitle(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strNodeTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNodeTitle, congs_StructureChartNode.NodeTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNodeTitle, 100, congs_StructureChartNode.NodeTitle);
}
objgs_StructureChartNodeEN.NodeTitle = strNodeTitle; //节点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.NodeTitle) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.NodeTitle, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.NodeTitle] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetParentId(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 20, congs_StructureChartNode.ParentId);
}
objgs_StructureChartNodeEN.ParentId = strParentId; //父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.ParentId) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.ParentId, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.ParentId] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetIsRoot(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsRoot, string strComparisonOp="")
	{
objgs_StructureChartNodeEN.IsRoot = bolIsRoot; //IsRoot
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.IsRoot) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.IsRoot, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.IsRoot] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetExpanded(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolExpanded, string strComparisonOp="")
	{
objgs_StructureChartNodeEN.Expanded = bolExpanded; //扩大
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.Expanded) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.Expanded, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.Expanded] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetDirection(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strDirection, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDirection, 50, congs_StructureChartNode.Direction);
}
objgs_StructureChartNodeEN.Direction = strDirection; //方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.Direction) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.Direction, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.Direction] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetBgColor(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strBgColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBgColor, 50, congs_StructureChartNode.BgColor);
}
objgs_StructureChartNodeEN.BgColor = strBgColor; //背景色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.BgColor) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.BgColor, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.BgColor] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetUpdDate(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_StructureChartNode.UpdDate);
}
objgs_StructureChartNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.UpdDate) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.UpdDate, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.UpdDate] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetUpdUser(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_StructureChartNode.UpdUser);
}
objgs_StructureChartNodeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.UpdUser) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.UpdUser, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.UpdUser] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_StructureChartNodeEN SetMemo(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_StructureChartNode.Memo);
}
objgs_StructureChartNodeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(congs_StructureChartNode.Memo) == false)
{
objgs_StructureChartNodeEN.dicFldComparisonOp.Add(congs_StructureChartNode.Memo, strComparisonOp);
}
else
{
objgs_StructureChartNodeEN.dicFldComparisonOp[congs_StructureChartNode.Memo] = strComparisonOp;
}
}
return objgs_StructureChartNodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_StructureChartNodeEN.CheckPropertyNew();
clsgs_StructureChartNodeEN objgs_StructureChartNodeCond = new clsgs_StructureChartNodeEN();
string strCondition = objgs_StructureChartNodeCond
.SetmId(objgs_StructureChartNodeEN.mId, "<>")
.SetmId(objgs_StructureChartNodeEN.mId, "=")
.GetCombineCondition();
objgs_StructureChartNodeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_StructureChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_StructureChartNodeEN.Update();
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
 /// <param name = "objgs_StructureChartNode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_StructureChartNodeEN objgs_StructureChartNode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_StructureChartNodeEN objgs_StructureChartNodeCond = new clsgs_StructureChartNodeEN();
string strCondition = objgs_StructureChartNodeCond
.SetmId(objgs_StructureChartNode.mId, "=")
.GetCombineCondition();
objgs_StructureChartNode._IsCheckProperty = true;
bool bolIsExist = clsgs_StructureChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_StructureChartNode.mId = clsgs_StructureChartNodeBL.GetFirstID_S(strCondition);
objgs_StructureChartNode.UpdateWithCondition(strCondition);
}
else
{
objgs_StructureChartNode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.UpdateBySql2(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_StructureChartNodeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.UpdateBySql2(objgs_StructureChartNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.UpdateBySqlWithCondition(objgs_StructureChartNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.UpdateBySqlWithConditionTransaction(objgs_StructureChartNodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
public static int Delete(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
try
{
int intRecNum = clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.DelRecord(objgs_StructureChartNodeEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeENS">源对象</param>
 /// <param name = "objgs_StructureChartNodeENT">目标对象</param>
 public static void CopyTo(this clsgs_StructureChartNodeEN objgs_StructureChartNodeENS, clsgs_StructureChartNodeEN objgs_StructureChartNodeENT)
{
try
{
objgs_StructureChartNodeENT.mId = objgs_StructureChartNodeENS.mId; //mId
objgs_StructureChartNodeENT.StructureChartId = objgs_StructureChartNodeENS.StructureChartId; //结构图Id
objgs_StructureChartNodeENT.NodeId = objgs_StructureChartNodeENS.NodeId; //节点Id
objgs_StructureChartNodeENT.NodeTitle = objgs_StructureChartNodeENS.NodeTitle; //节点标题
objgs_StructureChartNodeENT.ParentId = objgs_StructureChartNodeENS.ParentId; //父Id
objgs_StructureChartNodeENT.IsRoot = objgs_StructureChartNodeENS.IsRoot; //IsRoot
objgs_StructureChartNodeENT.Expanded = objgs_StructureChartNodeENS.Expanded; //扩大
objgs_StructureChartNodeENT.Direction = objgs_StructureChartNodeENS.Direction; //方向
objgs_StructureChartNodeENT.BgColor = objgs_StructureChartNodeENS.BgColor; //背景色
objgs_StructureChartNodeENT.UpdDate = objgs_StructureChartNodeENS.UpdDate; //修改日期
objgs_StructureChartNodeENT.UpdUser = objgs_StructureChartNodeENS.UpdUser; //修改人
objgs_StructureChartNodeENT.Memo = objgs_StructureChartNodeENS.Memo; //备注
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
 /// <param name = "objgs_StructureChartNodeENS">源对象</param>
 /// <returns>目标对象=>clsgs_StructureChartNodeEN:objgs_StructureChartNodeENT</returns>
 public static clsgs_StructureChartNodeEN CopyTo(this clsgs_StructureChartNodeEN objgs_StructureChartNodeENS)
{
try
{
 clsgs_StructureChartNodeEN objgs_StructureChartNodeENT = new clsgs_StructureChartNodeEN()
{
mId = objgs_StructureChartNodeENS.mId, //mId
StructureChartId = objgs_StructureChartNodeENS.StructureChartId, //结构图Id
NodeId = objgs_StructureChartNodeENS.NodeId, //节点Id
NodeTitle = objgs_StructureChartNodeENS.NodeTitle, //节点标题
ParentId = objgs_StructureChartNodeENS.ParentId, //父Id
IsRoot = objgs_StructureChartNodeENS.IsRoot, //IsRoot
Expanded = objgs_StructureChartNodeENS.Expanded, //扩大
Direction = objgs_StructureChartNodeENS.Direction, //方向
BgColor = objgs_StructureChartNodeENS.BgColor, //背景色
UpdDate = objgs_StructureChartNodeENS.UpdDate, //修改日期
UpdUser = objgs_StructureChartNodeENS.UpdUser, //修改人
Memo = objgs_StructureChartNodeENS.Memo, //备注
};
 return objgs_StructureChartNodeENT;
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
public static void CheckPropertyNew(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.CheckPropertyNew(objgs_StructureChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 clsgs_StructureChartNodeBL.gs_StructureChartNodeDA.CheckProperty4Condition(objgs_StructureChartNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_StructureChartNodeEN objgs_StructureChartNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.mId) == true)
{
string strComparisonOpmId = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_StructureChartNode.mId, objgs_StructureChartNodeCond.mId, strComparisonOpmId);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.StructureChartId) == true)
{
string strComparisonOpStructureChartId = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.StructureChartId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.StructureChartId, objgs_StructureChartNodeCond.StructureChartId, strComparisonOpStructureChartId);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.NodeId) == true)
{
string strComparisonOpNodeId = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.NodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.NodeId, objgs_StructureChartNodeCond.NodeId, strComparisonOpNodeId);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.NodeTitle) == true)
{
string strComparisonOpNodeTitle = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.NodeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.NodeTitle, objgs_StructureChartNodeCond.NodeTitle, strComparisonOpNodeTitle);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.ParentId) == true)
{
string strComparisonOpParentId = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.ParentId, objgs_StructureChartNodeCond.ParentId, strComparisonOpParentId);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.IsRoot) == true)
{
if (objgs_StructureChartNodeCond.IsRoot == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_StructureChartNode.IsRoot);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_StructureChartNode.IsRoot);
}
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.Expanded) == true)
{
if (objgs_StructureChartNodeCond.Expanded == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_StructureChartNode.Expanded);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_StructureChartNode.Expanded);
}
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.Direction) == true)
{
string strComparisonOpDirection = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.Direction];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.Direction, objgs_StructureChartNodeCond.Direction, strComparisonOpDirection);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.BgColor) == true)
{
string strComparisonOpBgColor = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.BgColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.BgColor, objgs_StructureChartNodeCond.BgColor, strComparisonOpBgColor);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.UpdDate, objgs_StructureChartNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.UpdUser, objgs_StructureChartNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_StructureChartNodeCond.IsUpdated(congs_StructureChartNode.Memo) == true)
{
string strComparisonOpMemo = objgs_StructureChartNodeCond.dicFldComparisonOp[congs_StructureChartNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_StructureChartNode.Memo, objgs_StructureChartNodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_StructureChartNode(结构图节点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_StructureChartNodeEN == null) return true;
if (objgs_StructureChartNodeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_StructureChartNodeEN.mId);
if (clsgs_StructureChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_StructureChartNodeEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_StructureChartNodeEN.mId);
if (clsgs_StructureChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_StructureChartNode(结构图节点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_StructureChartNodeEN == null) return "";
if (objgs_StructureChartNodeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_StructureChartNodeEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_StructureChartNodeEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_StructureChartNodeEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_StructureChartNode
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 结构图节点(gs_StructureChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_StructureChartNodeBL
{
public static RelatedActions_gs_StructureChartNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_StructureChartNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_StructureChartNodeDA gs_StructureChartNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_StructureChartNodeDA();
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
 public clsgs_StructureChartNodeBL()
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
if (string.IsNullOrEmpty(clsgs_StructureChartNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_StructureChartNodeEN._ConnectString);
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
public static DataTable GetDataTable_gs_StructureChartNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_StructureChartNodeDA.GetDataTable_gs_StructureChartNode(strWhereCond);
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
objDT = gs_StructureChartNodeDA.GetDataTable(strWhereCond);
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
objDT = gs_StructureChartNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_StructureChartNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_StructureChartNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_StructureChartNodeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_StructureChartNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_StructureChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_StructureChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_StructureChartNodeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
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
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_StructureChartNodeEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsgs_StructureChartNodeEN._CurrTabName);
List<clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLst_Sel =
arrgs_StructureChartNodeObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_StructureChartNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetObjLst(string strWhereCond)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
public static List<clsgs_StructureChartNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_StructureChartNodeEN> GetSubObjLstCache(clsgs_StructureChartNodeEN objgs_StructureChartNodeCond)
{
List<clsgs_StructureChartNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_StructureChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_StructureChartNode.AttributeName)
{
if (objgs_StructureChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objgs_StructureChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_StructureChartNodeCond[strFldName].ToString());
}
else
{
if (objgs_StructureChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_StructureChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_StructureChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_StructureChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_StructureChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_StructureChartNodeCond[strFldName]));
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
public static List<clsgs_StructureChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
public static List<clsgs_StructureChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
List<clsgs_StructureChartNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_StructureChartNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_StructureChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
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
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
public static List<clsgs_StructureChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_StructureChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
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
public static List<clsgs_StructureChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_StructureChartNodeEN> arrObjLst = new List<clsgs_StructureChartNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = new clsgs_StructureChartNodeEN();
try
{
objgs_StructureChartNodeEN.mId = Int32.Parse(objRow[congs_StructureChartNode.mId].ToString().Trim()); //mId
objgs_StructureChartNodeEN.StructureChartId = objRow[congs_StructureChartNode.StructureChartId].ToString().Trim(); //结构图Id
objgs_StructureChartNodeEN.NodeId = objRow[congs_StructureChartNode.NodeId].ToString().Trim(); //节点Id
objgs_StructureChartNodeEN.NodeTitle = objRow[congs_StructureChartNode.NodeTitle].ToString().Trim(); //节点标题
objgs_StructureChartNodeEN.ParentId = objRow[congs_StructureChartNode.ParentId] == DBNull.Value ? null : objRow[congs_StructureChartNode.ParentId].ToString().Trim(); //父Id
objgs_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objgs_StructureChartNodeEN.Expanded = clsEntityBase2.TransNullToBool_S(objRow[congs_StructureChartNode.Expanded].ToString().Trim()); //扩大
objgs_StructureChartNodeEN.Direction = objRow[congs_StructureChartNode.Direction] == DBNull.Value ? null : objRow[congs_StructureChartNode.Direction].ToString().Trim(); //方向
objgs_StructureChartNodeEN.BgColor = objRow[congs_StructureChartNode.BgColor] == DBNull.Value ? null : objRow[congs_StructureChartNode.BgColor].ToString().Trim(); //背景色
objgs_StructureChartNodeEN.UpdDate = objRow[congs_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objgs_StructureChartNodeEN.UpdUser = objRow[congs_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[congs_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objgs_StructureChartNodeEN.Memo = objRow[congs_StructureChartNode.Memo] == DBNull.Value ? null : objRow[congs_StructureChartNode.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_StructureChartNodeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_StructureChartNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_StructureChartNode(ref clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
bool bolResult = gs_StructureChartNodeDA.Getgs_StructureChartNode(ref objgs_StructureChartNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_StructureChartNodeEN GetObjBymId(long lngmId)
{
clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = gs_StructureChartNodeDA.GetObjBymId(lngmId);
return objgs_StructureChartNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_StructureChartNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = gs_StructureChartNodeDA.GetFirstObj(strWhereCond);
 return objgs_StructureChartNodeEN;
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
public static clsgs_StructureChartNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = gs_StructureChartNodeDA.GetObjByDataRow(objRow);
 return objgs_StructureChartNodeEN;
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
public static clsgs_StructureChartNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = gs_StructureChartNodeDA.GetObjByDataRow(objRow);
 return objgs_StructureChartNodeEN;
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
 /// <param name = "lstgs_StructureChartNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_StructureChartNodeEN GetObjBymIdFromList(long lngmId, List<clsgs_StructureChartNodeEN> lstgs_StructureChartNodeObjLst)
{
foreach (clsgs_StructureChartNodeEN objgs_StructureChartNodeEN in lstgs_StructureChartNodeObjLst)
{
if (objgs_StructureChartNodeEN.mId == lngmId)
{
return objgs_StructureChartNodeEN;
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
 lngmId = new clsgs_StructureChartNodeDA().GetFirstID(strWhereCond);
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
 arrList = gs_StructureChartNodeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_StructureChartNodeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_StructureChartNodeDA.IsExist(lngmId);
return bolIsExist;
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
 bolIsExist = clsgs_StructureChartNodeDA.IsExistTable();
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
 bolIsExist = gs_StructureChartNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_StructureChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_StructureChartNodeBL.AddNewRecordBySql2)", objgs_StructureChartNodeEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_StructureChartNodeDA.AddNewRecordBySQL2(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_StructureChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_StructureChartNodeBL.AddNewRecordBySql2WithReturnKey)", objgs_StructureChartNodeEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_StructureChartNodeDA.AddNewRecordBySQL2WithReturnKey(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
try
{
bool bolResult = gs_StructureChartNodeDA.Update(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 if (objgs_StructureChartNodeEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_StructureChartNodeDA.UpdateBySql2(objgs_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_StructureChartNodeBL.ReFreshCache();

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
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
 clsgs_StructureChartNodeEN objgs_StructureChartNodeEN = clsgs_StructureChartNodeBL.GetObjBymId(lngmId);

if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objgs_StructureChartNodeEN.mId, "SetUpdDate");
}
if (objgs_StructureChartNodeEN != null)
{
int intRecNum = gs_StructureChartNodeDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
//删除与表:[gs_StructureChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_StructureChartNode.mId,
//lngmId);
//        clsgs_StructureChartNodeBL.Delgs_StructureChartNodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_StructureChartNodeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_StructureChartNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_StructureChartNodeBL.relatedActions != null)
{
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_StructureChartNodeDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_StructureChartNodes(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_StructureChartNodeBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_StructureChartNodeDA.Delgs_StructureChartNode(arrmIdLst);
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
public static int Delgs_StructureChartNodesByCond(string strWhereCond)
{
try
{
if (clsgs_StructureChartNodeBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_StructureChartNodeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = gs_StructureChartNodeDA.Delgs_StructureChartNode(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_StructureChartNode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_StructureChartNodeDA.GetSpecSQLObj();
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
//删除与表:[gs_StructureChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_StructureChartNodeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_StructureChartNodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objgs_StructureChartNodeENS">源对象</param>
 /// <param name = "objgs_StructureChartNodeENT">目标对象</param>
 public static void CopyTo(clsgs_StructureChartNodeEN objgs_StructureChartNodeENS, clsgs_StructureChartNodeEN objgs_StructureChartNodeENT)
{
try
{
objgs_StructureChartNodeENT.mId = objgs_StructureChartNodeENS.mId; //mId
objgs_StructureChartNodeENT.StructureChartId = objgs_StructureChartNodeENS.StructureChartId; //结构图Id
objgs_StructureChartNodeENT.NodeId = objgs_StructureChartNodeENS.NodeId; //节点Id
objgs_StructureChartNodeENT.NodeTitle = objgs_StructureChartNodeENS.NodeTitle; //节点标题
objgs_StructureChartNodeENT.ParentId = objgs_StructureChartNodeENS.ParentId; //父Id
objgs_StructureChartNodeENT.IsRoot = objgs_StructureChartNodeENS.IsRoot; //IsRoot
objgs_StructureChartNodeENT.Expanded = objgs_StructureChartNodeENS.Expanded; //扩大
objgs_StructureChartNodeENT.Direction = objgs_StructureChartNodeENS.Direction; //方向
objgs_StructureChartNodeENT.BgColor = objgs_StructureChartNodeENS.BgColor; //背景色
objgs_StructureChartNodeENT.UpdDate = objgs_StructureChartNodeENS.UpdDate; //修改日期
objgs_StructureChartNodeENT.UpdUser = objgs_StructureChartNodeENS.UpdUser; //修改人
objgs_StructureChartNodeENT.Memo = objgs_StructureChartNodeENS.Memo; //备注
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
 /// <param name = "objgs_StructureChartNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
try
{
objgs_StructureChartNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_StructureChartNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_StructureChartNode.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.mId = objgs_StructureChartNodeEN.mId; //mId
}
if (arrFldSet.Contains(congs_StructureChartNode.StructureChartId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.StructureChartId = objgs_StructureChartNodeEN.StructureChartId; //结构图Id
}
if (arrFldSet.Contains(congs_StructureChartNode.NodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.NodeId = objgs_StructureChartNodeEN.NodeId; //节点Id
}
if (arrFldSet.Contains(congs_StructureChartNode.NodeTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.NodeTitle = objgs_StructureChartNodeEN.NodeTitle; //节点标题
}
if (arrFldSet.Contains(congs_StructureChartNode.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.ParentId = objgs_StructureChartNodeEN.ParentId == "[null]" ? null :  objgs_StructureChartNodeEN.ParentId; //父Id
}
if (arrFldSet.Contains(congs_StructureChartNode.IsRoot, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.IsRoot = objgs_StructureChartNodeEN.IsRoot; //IsRoot
}
if (arrFldSet.Contains(congs_StructureChartNode.Expanded, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.Expanded = objgs_StructureChartNodeEN.Expanded; //扩大
}
if (arrFldSet.Contains(congs_StructureChartNode.Direction, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.Direction = objgs_StructureChartNodeEN.Direction == "[null]" ? null :  objgs_StructureChartNodeEN.Direction; //方向
}
if (arrFldSet.Contains(congs_StructureChartNode.BgColor, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.BgColor = objgs_StructureChartNodeEN.BgColor == "[null]" ? null :  objgs_StructureChartNodeEN.BgColor; //背景色
}
if (arrFldSet.Contains(congs_StructureChartNode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.UpdDate = objgs_StructureChartNodeEN.UpdDate == "[null]" ? null :  objgs_StructureChartNodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_StructureChartNode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.UpdUser = objgs_StructureChartNodeEN.UpdUser == "[null]" ? null :  objgs_StructureChartNodeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_StructureChartNode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_StructureChartNodeEN.Memo = objgs_StructureChartNodeEN.Memo == "[null]" ? null :  objgs_StructureChartNodeEN.Memo; //备注
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
 /// <param name = "objgs_StructureChartNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
try
{
if (objgs_StructureChartNodeEN.ParentId == "[null]") objgs_StructureChartNodeEN.ParentId = null; //父Id
if (objgs_StructureChartNodeEN.Direction == "[null]") objgs_StructureChartNodeEN.Direction = null; //方向
if (objgs_StructureChartNodeEN.BgColor == "[null]") objgs_StructureChartNodeEN.BgColor = null; //背景色
if (objgs_StructureChartNodeEN.UpdDate == "[null]") objgs_StructureChartNodeEN.UpdDate = null; //修改日期
if (objgs_StructureChartNodeEN.UpdUser == "[null]") objgs_StructureChartNodeEN.UpdUser = null; //修改人
if (objgs_StructureChartNodeEN.Memo == "[null]") objgs_StructureChartNodeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 gs_StructureChartNodeDA.CheckPropertyNew(objgs_StructureChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
 gs_StructureChartNodeDA.CheckProperty4Condition(objgs_StructureChartNodeEN);
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
if (clsgs_StructureChartNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_StructureChartNodeBL没有刷新缓存机制(clsgs_StructureChartNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_StructureChartNodeObjLstCache == null)
//{
//arrgs_StructureChartNodeObjLstCache = gs_StructureChartNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_StructureChartNodeEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_StructureChartNodeEN._CurrTabName);
List<clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLst_Sel =
arrgs_StructureChartNodeObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_StructureChartNodeObjLst_Sel.Count() == 0)
{
   clsgs_StructureChartNodeEN obj = clsgs_StructureChartNodeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_StructureChartNodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetAllgs_StructureChartNodeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLstCache = GetObjLstCache(); 
return arrgs_StructureChartNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_StructureChartNodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_StructureChartNodeEN._CurrTabName);
List<clsgs_StructureChartNodeEN> arrgs_StructureChartNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_StructureChartNodeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_StructureChartNodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_StructureChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_StructureChartNodeEN._RefreshTimeLst.Count == 0) return "";
return clsgs_StructureChartNodeEN._RefreshTimeLst[clsgs_StructureChartNodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_StructureChartNodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_StructureChartNodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_StructureChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_StructureChartNodeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_StructureChartNode(结构图节点)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_StructureChartNodeEN objgs_StructureChartNodeEN)
{
//检测记录是否存在
string strResult = gs_StructureChartNodeDA.GetUniCondStr(objgs_StructureChartNodeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != congs_StructureChartNode.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_StructureChartNode.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_StructureChartNode.AttributeName));
throw new Exception(strMsg);
}
var objgs_StructureChartNode = clsgs_StructureChartNodeBL.GetObjBymIdCache(lngmId);
if (objgs_StructureChartNode == null) return "";
return objgs_StructureChartNode[strOutFldName].ToString();
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
int intRecCount = clsgs_StructureChartNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_StructureChartNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_StructureChartNodeDA.GetRecCount();
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
int intRecCount = clsgs_StructureChartNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_StructureChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_StructureChartNodeEN objgs_StructureChartNodeCond)
{
List<clsgs_StructureChartNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_StructureChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_StructureChartNode.AttributeName)
{
if (objgs_StructureChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objgs_StructureChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_StructureChartNodeCond[strFldName].ToString());
}
else
{
if (objgs_StructureChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_StructureChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_StructureChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_StructureChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_StructureChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_StructureChartNodeCond[strFldName]));
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
 List<string> arrList = clsgs_StructureChartNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_StructureChartNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_StructureChartNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_StructureChartNodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_StructureChartNodeDA.SetFldValue(clsgs_StructureChartNodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_StructureChartNodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_StructureChartNodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_StructureChartNodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_StructureChartNodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_StructureChartNode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**结构图Id*/ 
 strCreateTabCode.Append(" StructureChartId char(10) not Null, "); 
 // /**节点Id*/ 
 strCreateTabCode.Append(" NodeId varchar(20) not Null, "); 
 // /**节点标题*/ 
 strCreateTabCode.Append(" NodeTitle varchar(100) not Null, "); 
 // /**父Id*/ 
 strCreateTabCode.Append(" ParentId varchar(20) Null, "); 
 // /**IsRoot*/ 
 strCreateTabCode.Append(" IsRoot bit Null, "); 
 // /**扩大*/ 
 strCreateTabCode.Append(" Expanded bit Null, "); 
 // /**方向*/ 
 strCreateTabCode.Append(" Direction varchar(50) Null, "); 
 // /**背景色*/ 
 strCreateTabCode.Append(" BgColor varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 结构图节点(gs_StructureChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_StructureChartNode : clsCommFun4BL
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
clsgs_StructureChartNodeBL.ReFreshThisCache();
}
}

}