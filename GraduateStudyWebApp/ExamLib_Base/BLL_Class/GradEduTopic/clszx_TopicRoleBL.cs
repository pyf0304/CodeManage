﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicRoleBL
 表名:zx_TopicRole(01120874)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:11:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clszx_TopicRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicRoleEN GetObj(this K_zxTopicRoleId_zx_TopicRole myKey)
{
clszx_TopicRoleEN objzx_TopicRoleEN = clszx_TopicRoleBL.zx_TopicRoleDA.GetObjByzxTopicRoleId(myKey.Value);
return objzx_TopicRoleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
if (CheckUniqueness(objzx_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名称 = [{0}]的数据已经存在!(in clszx_TopicRoleBL.AddNewRecord)", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TopicRoleBL.zx_TopicRoleDA.AddNewRecordBySQL2(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TopicRoleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TopicRoleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(菜单名称(MenuName)=[{0}])已经存在,不能重复!", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TopicRoleEN.AddNewRecord();
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
if (CheckUniqueness(objzx_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名称 = [{0}]的数据已经存在!(in clszx_TopicRoleBL.AddNewRecordWithMaxId)", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
string strzxTopicRoleId = clszx_TopicRoleBL.zx_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicRoleEN);
     objzx_TopicRoleEN.zxTopicRoleId = strzxTopicRoleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
}
return strzxTopicRoleId;
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
if (CheckUniqueness(objzx_TopicRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!菜单名称 = [{0}]的数据已经存在!(in clszx_TopicRoleBL.AddNewRecordWithReturnKey)", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
string strKey = clszx_TopicRoleBL.zx_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetzxTopicRoleId(this clszx_TopicRoleEN objzx_TopicRoleEN, string strzxTopicRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicRoleId, 10, conzx_TopicRole.zxTopicRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicRoleId, 10, conzx_TopicRole.zxTopicRoleId);
}
objzx_TopicRoleEN.zxTopicRoleId = strzxTopicRoleId; //主题权限Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.zxTopicRoleId) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.zxTopicRoleId, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.zxTopicRoleId] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetGroupTextId(this clszx_TopicRoleEN objzx_TopicRoleEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_TopicRole.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_TopicRole.GroupTextId);
}
objzx_TopicRoleEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.GroupTextId) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.GroupTextId, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.GroupTextId] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetMenuNum(this clszx_TopicRoleEN objzx_TopicRoleEN, string strMenuNum, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuNum, 10, conzx_TopicRole.MenuNum);
}
objzx_TopicRoleEN.MenuNum = strMenuNum; //菜单编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.MenuNum) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.MenuNum, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.MenuNum] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetMenuName(this clszx_TopicRoleEN objzx_TopicRoleEN, string strMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 100, conzx_TopicRole.MenuName);
}
objzx_TopicRoleEN.MenuName = strMenuName; //菜单名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.MenuName) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.MenuName, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.MenuName] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetMenuIsHide(this clszx_TopicRoleEN objzx_TopicRoleEN, bool bolMenuIsHide, string strComparisonOp="")
	{
objzx_TopicRoleEN.MenuIsHide = bolMenuIsHide; //菜单是否隐藏
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.MenuIsHide) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.MenuIsHide, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.MenuIsHide] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetUpdDate(this clszx_TopicRoleEN objzx_TopicRoleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TopicRole.UpdDate);
}
objzx_TopicRoleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.UpdDate) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.UpdDate, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.UpdDate] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetUpdUser(this clszx_TopicRoleEN objzx_TopicRoleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TopicRole.UpdUser);
}
objzx_TopicRoleEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.UpdUser) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.UpdUser, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.UpdUser] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetMemo(this clszx_TopicRoleEN objzx_TopicRoleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TopicRole.Memo);
}
objzx_TopicRoleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.Memo) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.Memo, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.Memo] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicRoleEN SetIsDefault(this clszx_TopicRoleEN objzx_TopicRoleEN, bool bolIsDefault, string strComparisonOp="")
	{
objzx_TopicRoleEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicRole.IsDefault) == false)
{
objzx_TopicRoleEN.dicFldComparisonOp.Add(conzx_TopicRole.IsDefault, strComparisonOp);
}
else
{
objzx_TopicRoleEN.dicFldComparisonOp[conzx_TopicRole.IsDefault] = strComparisonOp;
}
}
return objzx_TopicRoleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TopicRoleEN.CheckPropertyNew();
clszx_TopicRoleEN objzx_TopicRoleCond = new clszx_TopicRoleEN();
string strCondition = objzx_TopicRoleCond
.SetzxTopicRoleId(objzx_TopicRoleEN.zxTopicRoleId, "<>")
.SetMenuName(objzx_TopicRoleEN.MenuName, "=")
.GetCombineCondition();
objzx_TopicRoleEN._IsCheckProperty = true;
bool bolIsExist = clszx_TopicRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MenuName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TopicRoleEN.Update();
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
 /// <param name = "objzx_TopicRole">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TopicRoleEN objzx_TopicRole)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TopicRoleEN objzx_TopicRoleCond = new clszx_TopicRoleEN();
string strCondition = objzx_TopicRoleCond
.SetMenuName(objzx_TopicRole.MenuName, "=")
.GetCombineCondition();
objzx_TopicRole._IsCheckProperty = true;
bool bolIsExist = clszx_TopicRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TopicRole.zxTopicRoleId = clszx_TopicRoleBL.GetFirstID_S(strCondition);
objzx_TopicRole.UpdateWithCondition(strCondition);
}
else
{
objzx_TopicRole.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
objzx_TopicRole.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicRoleBL.zx_TopicRoleDA.UpdateBySql2(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicRoleEN objzx_TopicRoleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicRoleBL.zx_TopicRoleDA.UpdateBySql2(objzx_TopicRoleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicRoleEN objzx_TopicRoleEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TopicRoleBL.zx_TopicRoleDA.UpdateBySqlWithCondition(objzx_TopicRoleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicRoleEN objzx_TopicRoleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TopicRoleBL.zx_TopicRoleDA.UpdateBySqlWithConditionTransaction(objzx_TopicRoleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "strzxTopicRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
try
{
int intRecNum = clszx_TopicRoleBL.zx_TopicRoleDA.DelRecord(objzx_TopicRoleEN.zxTopicRoleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleENS">源对象</param>
 /// <param name = "objzx_TopicRoleENT">目标对象</param>
 public static void CopyTo(this clszx_TopicRoleEN objzx_TopicRoleENS, clszx_TopicRoleEN objzx_TopicRoleENT)
{
try
{
objzx_TopicRoleENT.zxTopicRoleId = objzx_TopicRoleENS.zxTopicRoleId; //主题权限Id
objzx_TopicRoleENT.GroupTextId = objzx_TopicRoleENS.GroupTextId; //小组Id
objzx_TopicRoleENT.MenuNum = objzx_TopicRoleENS.MenuNum; //菜单编号
objzx_TopicRoleENT.MenuName = objzx_TopicRoleENS.MenuName; //菜单名称
objzx_TopicRoleENT.MenuIsHide = objzx_TopicRoleENS.MenuIsHide; //菜单是否隐藏
objzx_TopicRoleENT.UpdDate = objzx_TopicRoleENS.UpdDate; //修改日期
objzx_TopicRoleENT.UpdUser = objzx_TopicRoleENS.UpdUser; //修改人
objzx_TopicRoleENT.Memo = objzx_TopicRoleENS.Memo; //备注
objzx_TopicRoleENT.IsDefault = objzx_TopicRoleENS.IsDefault; //是否默认
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
 /// <param name = "objzx_TopicRoleENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicRoleEN:objzx_TopicRoleENT</returns>
 public static clszx_TopicRoleEN CopyTo(this clszx_TopicRoleEN objzx_TopicRoleENS)
{
try
{
 clszx_TopicRoleEN objzx_TopicRoleENT = new clszx_TopicRoleEN()
{
zxTopicRoleId = objzx_TopicRoleENS.zxTopicRoleId, //主题权限Id
GroupTextId = objzx_TopicRoleENS.GroupTextId, //小组Id
MenuNum = objzx_TopicRoleENS.MenuNum, //菜单编号
MenuName = objzx_TopicRoleENS.MenuName, //菜单名称
MenuIsHide = objzx_TopicRoleENS.MenuIsHide, //菜单是否隐藏
UpdDate = objzx_TopicRoleENS.UpdDate, //修改日期
UpdUser = objzx_TopicRoleENS.UpdUser, //修改人
Memo = objzx_TopicRoleENS.Memo, //备注
IsDefault = objzx_TopicRoleENS.IsDefault, //是否默认
};
 return objzx_TopicRoleENT;
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
public static void CheckPropertyNew(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
 clszx_TopicRoleBL.zx_TopicRoleDA.CheckPropertyNew(objzx_TopicRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
 clszx_TopicRoleBL.zx_TopicRoleDA.CheckProperty4Condition(objzx_TopicRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TopicRoleEN objzx_TopicRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.zxTopicRoleId) == true)
{
string strComparisonOpzxTopicRoleId = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.zxTopicRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.zxTopicRoleId, objzx_TopicRoleCond.zxTopicRoleId, strComparisonOpzxTopicRoleId);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.GroupTextId, objzx_TopicRoleCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.MenuNum) == true)
{
string strComparisonOpMenuNum = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.MenuNum];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.MenuNum, objzx_TopicRoleCond.MenuNum, strComparisonOpMenuNum);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.MenuName) == true)
{
string strComparisonOpMenuName = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.MenuName, objzx_TopicRoleCond.MenuName, strComparisonOpMenuName);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.MenuIsHide) == true)
{
if (objzx_TopicRoleCond.MenuIsHide == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TopicRole.MenuIsHide);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TopicRole.MenuIsHide);
}
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.UpdDate, objzx_TopicRoleCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.UpdUser, objzx_TopicRoleCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.Memo) == true)
{
string strComparisonOpMemo = objzx_TopicRoleCond.dicFldComparisonOp[conzx_TopicRole.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicRole.Memo, objzx_TopicRoleCond.Memo, strComparisonOpMemo);
}
if (objzx_TopicRoleCond.IsUpdated(conzx_TopicRole.IsDefault) == true)
{
if (objzx_TopicRoleCond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TopicRole.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TopicRole.IsDefault);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TopicRole(中学主题权限表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MenuName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicRoleEN == null) return true;
if (objzx_TopicRoleEN.zxTopicRoleId == null || objzx_TopicRoleEN.zxTopicRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TopicRoleEN.MenuName == null)
{
 sbCondition.AppendFormat(" and MenuName is null", objzx_TopicRoleEN.MenuName);
}
else
{
 sbCondition.AppendFormat(" and MenuName = '{0}'", objzx_TopicRoleEN.MenuName);
}
if (clszx_TopicRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxTopicRoleId !=  '{0}'", objzx_TopicRoleEN.zxTopicRoleId);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objzx_TopicRoleEN.MenuName);
if (clszx_TopicRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TopicRole(中学主题权限表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MenuName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TopicRoleEN objzx_TopicRoleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicRoleEN == null) return "";
if (objzx_TopicRoleEN.zxTopicRoleId == null || objzx_TopicRoleEN.zxTopicRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TopicRoleEN.MenuName == null)
{
 sbCondition.AppendFormat(" and MenuName is null", objzx_TopicRoleEN.MenuName);
}
else
{
 sbCondition.AppendFormat(" and MenuName = '{0}'", objzx_TopicRoleEN.MenuName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxTopicRoleId !=  '{0}'", objzx_TopicRoleEN.zxTopicRoleId);
 sbCondition.AppendFormat(" and MenuName = '{0}'", objzx_TopicRoleEN.MenuName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TopicRole
{
public virtual bool UpdRelaTabDate(string strzxTopicRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学主题权限表(zx_TopicRole)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TopicRoleBL
{
public static RelatedActions_zx_TopicRole relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TopicRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TopicRoleDA zx_TopicRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TopicRoleDA();
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
 public clszx_TopicRoleBL()
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
if (string.IsNullOrEmpty(clszx_TopicRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicRoleEN._ConnectString);
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
public static DataTable GetDataTable_zx_TopicRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TopicRoleDA.GetDataTable_zx_TopicRole(strWhereCond);
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
objDT = zx_TopicRoleDA.GetDataTable(strWhereCond);
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
objDT = zx_TopicRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TopicRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TopicRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TopicRoleDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TopicRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TopicRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TopicRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTopicRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TopicRoleEN> GetObjLstByZxTopicRoleIdLst(List<string> arrZxTopicRoleIdLst)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTopicRoleIdLst, true);
 string strWhereCond = string.Format("zxTopicRoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTopicRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TopicRoleEN> GetObjLstByZxTopicRoleIdLstCache(List<string> arrZxTopicRoleIdLst)
{
string strKey = string.Format("{0}", clszx_TopicRoleEN._CurrTabName);
List<clszx_TopicRoleEN> arrzx_TopicRoleObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicRoleEN> arrzx_TopicRoleObjLst_Sel =
arrzx_TopicRoleObjLstCache
.Where(x => arrZxTopicRoleIdLst.Contains(x.zxTopicRoleId));
return arrzx_TopicRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicRoleEN> GetObjLst(string strWhereCond)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
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
public static List<clszx_TopicRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TopicRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TopicRoleEN> GetSubObjLstCache(clszx_TopicRoleEN objzx_TopicRoleCond)
{
List<clszx_TopicRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicRole.AttributeName)
{
if (objzx_TopicRoleCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicRoleCond[strFldName].ToString());
}
else
{
if (objzx_TopicRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicRoleCond[strFldName]));
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
public static List<clszx_TopicRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
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
public static List<clszx_TopicRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
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
List<clszx_TopicRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TopicRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TopicRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
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
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
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
public static List<clszx_TopicRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TopicRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TopicRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
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
public static List<clszx_TopicRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TopicRoleEN> arrObjLst = new List<clszx_TopicRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicRoleEN objzx_TopicRoleEN = new clszx_TopicRoleEN();
try
{
objzx_TopicRoleEN.zxTopicRoleId = objRow[conzx_TopicRole.zxTopicRoleId].ToString().Trim(); //主题权限Id
objzx_TopicRoleEN.GroupTextId = objRow[conzx_TopicRole.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicRole.GroupTextId].ToString().Trim(); //小组Id
objzx_TopicRoleEN.MenuNum = objRow[conzx_TopicRole.MenuNum] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuNum].ToString().Trim(); //菜单编号
objzx_TopicRoleEN.MenuName = objRow[conzx_TopicRole.MenuName] == DBNull.Value ? null : objRow[conzx_TopicRole.MenuName].ToString().Trim(); //菜单名称
objzx_TopicRoleEN.MenuIsHide = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.MenuIsHide].ToString().Trim()); //菜单是否隐藏
objzx_TopicRoleEN.UpdDate = objRow[conzx_TopicRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicRoleEN.UpdUser = objRow[conzx_TopicRole.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicRole.UpdUser].ToString().Trim(); //修改人
objzx_TopicRoleEN.Memo = objRow[conzx_TopicRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicRole.Memo].ToString().Trim(); //备注
objzx_TopicRoleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicRole.IsDefault].ToString().Trim()); //是否默认
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicRoleEN.zxTopicRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TopicRole(ref clszx_TopicRoleEN objzx_TopicRoleEN)
{
bool bolResult = zx_TopicRoleDA.Getzx_TopicRole(ref objzx_TopicRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicRoleEN GetObjByzxTopicRoleId(string strzxTopicRoleId)
{
if (strzxTopicRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTopicRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTopicRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTopicRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TopicRoleEN objzx_TopicRoleEN = zx_TopicRoleDA.GetObjByzxTopicRoleId(strzxTopicRoleId);
return objzx_TopicRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TopicRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TopicRoleEN objzx_TopicRoleEN = zx_TopicRoleDA.GetFirstObj(strWhereCond);
 return objzx_TopicRoleEN;
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
public static clszx_TopicRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TopicRoleEN objzx_TopicRoleEN = zx_TopicRoleDA.GetObjByDataRow(objRow);
 return objzx_TopicRoleEN;
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
public static clszx_TopicRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TopicRoleEN objzx_TopicRoleEN = zx_TopicRoleDA.GetObjByDataRow(objRow);
 return objzx_TopicRoleEN;
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
 /// <param name = "strzxTopicRoleId">所给的关键字</param>
 /// <param name = "lstzx_TopicRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicRoleEN GetObjByzxTopicRoleIdFromList(string strzxTopicRoleId, List<clszx_TopicRoleEN> lstzx_TopicRoleObjLst)
{
foreach (clszx_TopicRoleEN objzx_TopicRoleEN in lstzx_TopicRoleObjLst)
{
if (objzx_TopicRoleEN.zxTopicRoleId == strzxTopicRoleId)
{
return objzx_TopicRoleEN;
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
 string strMaxZxTopicRoleId;
 try
 {
 strMaxZxTopicRoleId = clszx_TopicRoleDA.GetMaxStrId();
 return strMaxZxTopicRoleId;
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
 string strzxTopicRoleId;
 try
 {
 strzxTopicRoleId = new clszx_TopicRoleDA().GetFirstID(strWhereCond);
 return strzxTopicRoleId;
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
 arrList = zx_TopicRoleDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TopicRoleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTopicRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTopicRoleId)
{
if (string.IsNullOrEmpty(strzxTopicRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTopicRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TopicRoleDA.IsExist(strzxTopicRoleId);
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
 bolIsExist = clszx_TopicRoleDA.IsExistTable();
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
 bolIsExist = zx_TopicRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TopicRoleEN objzx_TopicRoleEN)
{
if (objzx_TopicRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名称 = [{0}]的数据已经存在!(in clszx_TopicRoleBL.AddNewRecordBySql2)", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
bool bolResult = zx_TopicRoleDA.AddNewRecordBySQL2(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TopicRoleEN objzx_TopicRoleEN)
{
if (objzx_TopicRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!菜单名称 = [{0}]的数据已经存在!(in clszx_TopicRoleBL.AddNewRecordBySql2WithReturnKey)", objzx_TopicRoleEN.MenuName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true || clszx_TopicRoleBL.IsExist(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
     objzx_TopicRoleEN.zxTopicRoleId = clszx_TopicRoleBL.GetMaxStrId_S();
 }
string strKey = zx_TopicRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TopicRoleEN objzx_TopicRoleEN)
{
try
{
bool bolResult = zx_TopicRoleDA.Update(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TopicRoleEN objzx_TopicRoleEN)
{
 if (string.IsNullOrEmpty(objzx_TopicRoleEN.zxTopicRoleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TopicRoleDA.UpdateBySql2(objzx_TopicRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicRoleBL.ReFreshCache();

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
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
 /// <param name = "strzxTopicRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxTopicRoleId)
{
try
{
 clszx_TopicRoleEN objzx_TopicRoleEN = clszx_TopicRoleBL.GetObjByzxTopicRoleId(strzxTopicRoleId);

if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicRoleEN.zxTopicRoleId, "SetUpdDate");
}
if (objzx_TopicRoleEN != null)
{
int intRecNum = zx_TopicRoleDA.DelRecord(strzxTopicRoleId);
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
/// <param name="strzxTopicRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxTopicRoleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicRoleDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TopicRole.zxTopicRoleId,
//strzxTopicRoleId);
//        clszx_TopicRoleBL.Delzx_TopicRolesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicRoleBL.DelRecord(strzxTopicRoleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicRoleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxTopicRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxTopicRoleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TopicRoleBL.relatedActions != null)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(strzxTopicRoleId, "UpdRelaTabDate");
}
bool bolResult = zx_TopicRoleDA.DelRecord(strzxTopicRoleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxTopicRoleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TopicRoles(List<string> arrzxTopicRoleIdLst)
{
if (arrzxTopicRoleIdLst.Count == 0) return 0;
try
{
if (clszx_TopicRoleBL.relatedActions != null)
{
foreach (var strzxTopicRoleId in arrzxTopicRoleIdLst)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(strzxTopicRoleId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TopicRoleDA.Delzx_TopicRole(arrzxTopicRoleIdLst);
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
public static int Delzx_TopicRolesByCond(string strWhereCond)
{
try
{
if (clszx_TopicRoleBL.relatedActions != null)
{
List<string> arrzxTopicRoleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxTopicRoleId in arrzxTopicRoleId)
{
clszx_TopicRoleBL.relatedActions.UpdRelaTabDate(strzxTopicRoleId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TopicRoleDA.Delzx_TopicRole(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TopicRole]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxTopicRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxTopicRoleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicRoleDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicRoleBL.DelRecord(strzxTopicRoleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicRoleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TopicRoleENS">源对象</param>
 /// <param name = "objzx_TopicRoleENT">目标对象</param>
 public static void CopyTo(clszx_TopicRoleEN objzx_TopicRoleENS, clszx_TopicRoleEN objzx_TopicRoleENT)
{
try
{
objzx_TopicRoleENT.zxTopicRoleId = objzx_TopicRoleENS.zxTopicRoleId; //主题权限Id
objzx_TopicRoleENT.GroupTextId = objzx_TopicRoleENS.GroupTextId; //小组Id
objzx_TopicRoleENT.MenuNum = objzx_TopicRoleENS.MenuNum; //菜单编号
objzx_TopicRoleENT.MenuName = objzx_TopicRoleENS.MenuName; //菜单名称
objzx_TopicRoleENT.MenuIsHide = objzx_TopicRoleENS.MenuIsHide; //菜单是否隐藏
objzx_TopicRoleENT.UpdDate = objzx_TopicRoleENS.UpdDate; //修改日期
objzx_TopicRoleENT.UpdUser = objzx_TopicRoleENS.UpdUser; //修改人
objzx_TopicRoleENT.Memo = objzx_TopicRoleENS.Memo; //备注
objzx_TopicRoleENT.IsDefault = objzx_TopicRoleENS.IsDefault; //是否默认
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
 /// <param name = "objzx_TopicRoleEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TopicRoleEN objzx_TopicRoleEN)
{
try
{
objzx_TopicRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TopicRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TopicRole.zxTopicRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.zxTopicRoleId = objzx_TopicRoleEN.zxTopicRoleId; //主题权限Id
}
if (arrFldSet.Contains(conzx_TopicRole.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.GroupTextId = objzx_TopicRoleEN.GroupTextId == "[null]" ? null :  objzx_TopicRoleEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_TopicRole.MenuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.MenuNum = objzx_TopicRoleEN.MenuNum == "[null]" ? null :  objzx_TopicRoleEN.MenuNum; //菜单编号
}
if (arrFldSet.Contains(conzx_TopicRole.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.MenuName = objzx_TopicRoleEN.MenuName == "[null]" ? null :  objzx_TopicRoleEN.MenuName; //菜单名称
}
if (arrFldSet.Contains(conzx_TopicRole.MenuIsHide, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.MenuIsHide = objzx_TopicRoleEN.MenuIsHide; //菜单是否隐藏
}
if (arrFldSet.Contains(conzx_TopicRole.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.UpdDate = objzx_TopicRoleEN.UpdDate == "[null]" ? null :  objzx_TopicRoleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TopicRole.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.UpdUser = objzx_TopicRoleEN.UpdUser == "[null]" ? null :  objzx_TopicRoleEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TopicRole.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.Memo = objzx_TopicRoleEN.Memo == "[null]" ? null :  objzx_TopicRoleEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TopicRole.IsDefault, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicRoleEN.IsDefault = objzx_TopicRoleEN.IsDefault; //是否默认
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
 /// <param name = "objzx_TopicRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TopicRoleEN objzx_TopicRoleEN)
{
try
{
if (objzx_TopicRoleEN.GroupTextId == "[null]") objzx_TopicRoleEN.GroupTextId = null; //小组Id
if (objzx_TopicRoleEN.MenuNum == "[null]") objzx_TopicRoleEN.MenuNum = null; //菜单编号
if (objzx_TopicRoleEN.MenuName == "[null]") objzx_TopicRoleEN.MenuName = null; //菜单名称
if (objzx_TopicRoleEN.UpdDate == "[null]") objzx_TopicRoleEN.UpdDate = null; //修改日期
if (objzx_TopicRoleEN.UpdUser == "[null]") objzx_TopicRoleEN.UpdUser = null; //修改人
if (objzx_TopicRoleEN.Memo == "[null]") objzx_TopicRoleEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_TopicRoleEN objzx_TopicRoleEN)
{
 zx_TopicRoleDA.CheckPropertyNew(objzx_TopicRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TopicRoleEN objzx_TopicRoleEN)
{
 zx_TopicRoleDA.CheckProperty4Condition(objzx_TopicRoleEN);
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
if (clszx_TopicRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicRoleBL没有刷新缓存机制(clszx_TopicRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTopicRoleId");
//if (arrzx_TopicRoleObjLstCache == null)
//{
//arrzx_TopicRoleObjLstCache = zx_TopicRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicRoleEN GetObjByzxTopicRoleIdCache(string strzxTopicRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TopicRoleEN._CurrTabName);
List<clszx_TopicRoleEN> arrzx_TopicRoleObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicRoleEN> arrzx_TopicRoleObjLst_Sel =
arrzx_TopicRoleObjLstCache
.Where(x=> x.zxTopicRoleId == strzxTopicRoleId 
);
if (arrzx_TopicRoleObjLst_Sel.Count() == 0)
{
   clszx_TopicRoleEN obj = clszx_TopicRoleBL.GetObjByzxTopicRoleId(strzxTopicRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TopicRoleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicRoleEN> GetAllzx_TopicRoleObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TopicRoleEN> arrzx_TopicRoleObjLstCache = GetObjLstCache(); 
return arrzx_TopicRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TopicRoleEN._CurrTabName);
List<clszx_TopicRoleEN> arrzx_TopicRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TopicRoleObjLstCache;
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
string strKey = string.Format("{0}", clszx_TopicRoleEN._CurrTabName);
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
if (clszx_TopicRoleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TopicRoleEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TopicRoleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TopicRole(中学主题权限表)
 /// 唯一性条件:MenuName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TopicRoleEN objzx_TopicRoleEN)
{
//检测记录是否存在
string strResult = zx_TopicRoleDA.GetUniCondStr(objzx_TopicRoleEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxTopicRoleId)
{
if (strInFldName != conzx_TopicRole.zxTopicRoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TopicRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TopicRole.AttributeName));
throw new Exception(strMsg);
}
var objzx_TopicRole = clszx_TopicRoleBL.GetObjByzxTopicRoleIdCache(strzxTopicRoleId);
if (objzx_TopicRole == null) return "";
return objzx_TopicRole[strOutFldName].ToString();
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
int intRecCount = clszx_TopicRoleDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TopicRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TopicRoleDA.GetRecCount();
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
int intRecCount = clszx_TopicRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TopicRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TopicRoleEN objzx_TopicRoleCond)
{
List<clszx_TopicRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicRole.AttributeName)
{
if (objzx_TopicRoleCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicRoleCond[strFldName].ToString());
}
else
{
if (objzx_TopicRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicRoleCond[strFldName]));
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
 List<string> arrList = clszx_TopicRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TopicRoleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicRoleDA.SetFldValue(clszx_TopicRoleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TopicRoleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicRoleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicRoleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicRoleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TopicRole] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题权限Id*/ 
 strCreateTabCode.Append(" zxTopicRoleId char(10) primary key, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
 // /**菜单编号*/ 
 strCreateTabCode.Append(" MenuNum varchar(10) Null, "); 
 // /**菜单名称*/ 
 strCreateTabCode.Append(" MenuName varchar(100) Null, "); 
 // /**菜单是否隐藏*/ 
 strCreateTabCode.Append(" MenuIsHide bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否默认*/ 
 strCreateTabCode.Append(" IsDefault bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学主题权限表(zx_TopicRole)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TopicRole : clsCommFun4BL
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
clszx_TopicRoleBL.ReFreshThisCache();
}
}

}