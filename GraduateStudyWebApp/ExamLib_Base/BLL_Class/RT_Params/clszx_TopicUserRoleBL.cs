﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicUserRoleBL
 表名:zx_TopicUserRole(01120827)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
public static class  clszx_TopicUserRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicUserRoleEN GetObj(this K_zxTopicUserRoleId_zx_TopicUserRole myKey)
{
clszx_TopicUserRoleEN objzx_TopicUserRoleEN = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.GetObjByzxTopicUserRoleId(myKey.Value);
return objzx_TopicUserRoleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
if (CheckUniqueness(objzx_TopicUserRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主键Id = [{0}],主题用户角色 = [{1}]的数据已经存在!(in clszx_TopicUserRoleBL.AddNewRecord)", objzx_TopicUserRoleEN.zxTopicUserRoleId,objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.AddNewRecordBySQL2(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TopicUserRoleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TopicUserRoleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主键Id(zxTopicUserRoleId)=[{0}],主题用户角色(TopicUserRoleName)=[{1}])已经存在,不能重复!", objzx_TopicUserRoleEN.zxTopicUserRoleId, objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TopicUserRoleEN.AddNewRecord();
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
if (CheckUniqueness(objzx_TopicUserRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主键Id = [{0}],主题用户角色 = [{1}]的数据已经存在!(in clszx_TopicUserRoleBL.AddNewRecordWithMaxId)", objzx_TopicUserRoleEN.zxTopicUserRoleId,objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
string strzxTopicUserRoleId = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicUserRoleEN);
     objzx_TopicUserRoleEN.zxTopicUserRoleId = strzxTopicUserRoleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
}
return strzxTopicUserRoleId;
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
if (CheckUniqueness(objzx_TopicUserRoleEN) == false)
{
var strMsg = string.Format("记录已经存在!主键Id = [{0}],主题用户角色 = [{1}]的数据已经存在!(in clszx_TopicUserRoleBL.AddNewRecordWithReturnKey)", objzx_TopicUserRoleEN.zxTopicUserRoleId,objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
string strKey = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicUserRoleEN SetzxTopicUserRoleId(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strzxTopicUserRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicUserRoleId, 4, conzx_TopicUserRole.zxTopicUserRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicUserRoleId, 4, conzx_TopicUserRole.zxTopicUserRoleId);
}
objzx_TopicUserRoleEN.zxTopicUserRoleId = strzxTopicUserRoleId; //主键Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicUserRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicUserRole.zxTopicUserRoleId) == false)
{
objzx_TopicUserRoleEN.dicFldComparisonOp.Add(conzx_TopicUserRole.zxTopicUserRoleId, strComparisonOp);
}
else
{
objzx_TopicUserRoleEN.dicFldComparisonOp[conzx_TopicUserRole.zxTopicUserRoleId] = strComparisonOp;
}
}
return objzx_TopicUserRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicUserRoleEN SetTopicUserRoleName(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strTopicUserRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicUserRoleName, conzx_TopicUserRole.TopicUserRoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicUserRoleName, 100, conzx_TopicUserRole.TopicUserRoleName);
}
objzx_TopicUserRoleEN.TopicUserRoleName = strTopicUserRoleName; //主题用户角色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicUserRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicUserRole.TopicUserRoleName) == false)
{
objzx_TopicUserRoleEN.dicFldComparisonOp.Add(conzx_TopicUserRole.TopicUserRoleName, strComparisonOp);
}
else
{
objzx_TopicUserRoleEN.dicFldComparisonOp[conzx_TopicUserRole.TopicUserRoleName] = strComparisonOp;
}
}
return objzx_TopicUserRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicUserRoleEN SetUpdUserId(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conzx_TopicUserRole.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conzx_TopicUserRole.UpdUserId);
}
objzx_TopicUserRoleEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicUserRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicUserRole.UpdUserId) == false)
{
objzx_TopicUserRoleEN.dicFldComparisonOp.Add(conzx_TopicUserRole.UpdUserId, strComparisonOp);
}
else
{
objzx_TopicUserRoleEN.dicFldComparisonOp[conzx_TopicUserRole.UpdUserId] = strComparisonOp;
}
}
return objzx_TopicUserRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicUserRoleEN SetUpdDate(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TopicUserRole.UpdDate);
}
objzx_TopicUserRoleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicUserRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicUserRole.UpdDate) == false)
{
objzx_TopicUserRoleEN.dicFldComparisonOp.Add(conzx_TopicUserRole.UpdDate, strComparisonOp);
}
else
{
objzx_TopicUserRoleEN.dicFldComparisonOp[conzx_TopicUserRole.UpdDate] = strComparisonOp;
}
}
return objzx_TopicUserRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicUserRoleEN SetMemo(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TopicUserRole.Memo);
}
objzx_TopicUserRoleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicUserRoleEN.dicFldComparisonOp.ContainsKey(conzx_TopicUserRole.Memo) == false)
{
objzx_TopicUserRoleEN.dicFldComparisonOp.Add(conzx_TopicUserRole.Memo, strComparisonOp);
}
else
{
objzx_TopicUserRoleEN.dicFldComparisonOp[conzx_TopicUserRole.Memo] = strComparisonOp;
}
}
return objzx_TopicUserRoleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TopicUserRoleEN.CheckPropertyNew();
clszx_TopicUserRoleEN objzx_TopicUserRoleCond = new clszx_TopicUserRoleEN();
string strCondition = objzx_TopicUserRoleCond
.SetzxTopicUserRoleId(objzx_TopicUserRoleEN.zxTopicUserRoleId, "<>")
.SetzxTopicUserRoleId(objzx_TopicUserRoleEN.zxTopicUserRoleId, "=")
.SetTopicUserRoleName(objzx_TopicUserRoleEN.TopicUserRoleName, "=")
.GetCombineCondition();
objzx_TopicUserRoleEN._IsCheckProperty = true;
bool bolIsExist = clszx_TopicUserRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxTopicUserRoleId_TopicUserRoleName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TopicUserRoleEN.Update();
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
 /// <param name = "objzx_TopicUserRole">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TopicUserRoleEN objzx_TopicUserRole)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TopicUserRoleEN objzx_TopicUserRoleCond = new clszx_TopicUserRoleEN();
string strCondition = objzx_TopicUserRoleCond
.SetzxTopicUserRoleId(objzx_TopicUserRole.zxTopicUserRoleId, "=")
.SetTopicUserRoleName(objzx_TopicUserRole.TopicUserRoleName, "=")
.GetCombineCondition();
objzx_TopicUserRole._IsCheckProperty = true;
bool bolIsExist = clszx_TopicUserRoleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TopicUserRole.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetFirstID_S(strCondition);
objzx_TopicUserRole.UpdateWithCondition(strCondition);
}
else
{
objzx_TopicUserRole.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
objzx_TopicUserRole.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.UpdateBySql2(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.UpdateBySql2(objzx_TopicUserRoleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.UpdateBySqlWithCondition(objzx_TopicUserRoleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.UpdateBySqlWithConditionTransaction(objzx_TopicUserRoleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "strzxTopicUserRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
try
{
int intRecNum = clszx_TopicUserRoleBL.zx_TopicUserRoleDA.DelRecord(objzx_TopicUserRoleEN.zxTopicUserRoleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleENS">源对象</param>
 /// <param name = "objzx_TopicUserRoleENT">目标对象</param>
 public static void CopyTo(this clszx_TopicUserRoleEN objzx_TopicUserRoleENS, clszx_TopicUserRoleEN objzx_TopicUserRoleENT)
{
try
{
objzx_TopicUserRoleENT.zxTopicUserRoleId = objzx_TopicUserRoleENS.zxTopicUserRoleId; //主键Id
objzx_TopicUserRoleENT.TopicUserRoleName = objzx_TopicUserRoleENS.TopicUserRoleName; //主题用户角色
objzx_TopicUserRoleENT.UpdUserId = objzx_TopicUserRoleENS.UpdUserId; //修改用户Id
objzx_TopicUserRoleENT.UpdDate = objzx_TopicUserRoleENS.UpdDate; //修改日期
objzx_TopicUserRoleENT.Memo = objzx_TopicUserRoleENS.Memo; //备注
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
 /// <param name = "objzx_TopicUserRoleENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicUserRoleEN:objzx_TopicUserRoleENT</returns>
 public static clszx_TopicUserRoleEN CopyTo(this clszx_TopicUserRoleEN objzx_TopicUserRoleENS)
{
try
{
 clszx_TopicUserRoleEN objzx_TopicUserRoleENT = new clszx_TopicUserRoleEN()
{
zxTopicUserRoleId = objzx_TopicUserRoleENS.zxTopicUserRoleId, //主键Id
TopicUserRoleName = objzx_TopicUserRoleENS.TopicUserRoleName, //主题用户角色
UpdUserId = objzx_TopicUserRoleENS.UpdUserId, //修改用户Id
UpdDate = objzx_TopicUserRoleENS.UpdDate, //修改日期
Memo = objzx_TopicUserRoleENS.Memo, //备注
};
 return objzx_TopicUserRoleENT;
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
public static void CheckPropertyNew(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 clszx_TopicUserRoleBL.zx_TopicUserRoleDA.CheckPropertyNew(objzx_TopicUserRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 clszx_TopicUserRoleBL.zx_TopicUserRoleDA.CheckProperty4Condition(objzx_TopicUserRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TopicUserRoleEN objzx_TopicUserRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TopicUserRoleCond.IsUpdated(conzx_TopicUserRole.zxTopicUserRoleId) == true)
{
string strComparisonOpzxTopicUserRoleId = objzx_TopicUserRoleCond.dicFldComparisonOp[conzx_TopicUserRole.zxTopicUserRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicUserRole.zxTopicUserRoleId, objzx_TopicUserRoleCond.zxTopicUserRoleId, strComparisonOpzxTopicUserRoleId);
}
if (objzx_TopicUserRoleCond.IsUpdated(conzx_TopicUserRole.TopicUserRoleName) == true)
{
string strComparisonOpTopicUserRoleName = objzx_TopicUserRoleCond.dicFldComparisonOp[conzx_TopicUserRole.TopicUserRoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicUserRole.TopicUserRoleName, objzx_TopicUserRoleCond.TopicUserRoleName, strComparisonOpTopicUserRoleName);
}
if (objzx_TopicUserRoleCond.IsUpdated(conzx_TopicUserRole.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objzx_TopicUserRoleCond.dicFldComparisonOp[conzx_TopicUserRole.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicUserRole.UpdUserId, objzx_TopicUserRoleCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objzx_TopicUserRoleCond.IsUpdated(conzx_TopicUserRole.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TopicUserRoleCond.dicFldComparisonOp[conzx_TopicUserRole.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicUserRole.UpdDate, objzx_TopicUserRoleCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TopicUserRoleCond.IsUpdated(conzx_TopicUserRole.Memo) == true)
{
string strComparisonOpMemo = objzx_TopicUserRoleCond.dicFldComparisonOp[conzx_TopicUserRole.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicUserRole.Memo, objzx_TopicUserRoleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TopicUserRole(中学主题用户角色), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxTopicUserRoleId_TopicUserRoleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicUserRoleEN == null) return true;
if (objzx_TopicUserRoleEN.zxTopicUserRoleId == null || objzx_TopicUserRoleEN.zxTopicUserRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxTopicUserRoleId = '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and TopicUserRoleName = '{0}'", objzx_TopicUserRoleEN.TopicUserRoleName);
if (clszx_TopicUserRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxTopicUserRoleId !=  '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and zxTopicUserRoleId = '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and TopicUserRoleName = '{0}'", objzx_TopicUserRoleEN.TopicUserRoleName);
if (clszx_TopicUserRoleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TopicUserRole(中学主题用户角色), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxTopicUserRoleId_TopicUserRoleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicUserRoleEN == null) return "";
if (objzx_TopicUserRoleEN.zxTopicUserRoleId == null || objzx_TopicUserRoleEN.zxTopicUserRoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxTopicUserRoleId = '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and TopicUserRoleName = '{0}'", objzx_TopicUserRoleEN.TopicUserRoleName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxTopicUserRoleId !=  '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and zxTopicUserRoleId = '{0}'", objzx_TopicUserRoleEN.zxTopicUserRoleId);
 sbCondition.AppendFormat(" and TopicUserRoleName = '{0}'", objzx_TopicUserRoleEN.TopicUserRoleName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TopicUserRole
{
public virtual bool UpdRelaTabDate(string strzxTopicUserRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学主题用户角色(zx_TopicUserRole)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TopicUserRoleBL
{
public static RelatedActions_zx_TopicUserRole relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TopicUserRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TopicUserRoleDA zx_TopicUserRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TopicUserRoleDA();
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
 public clszx_TopicUserRoleBL()
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
if (string.IsNullOrEmpty(clszx_TopicUserRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicUserRoleEN._ConnectString);
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
public static DataTable GetDataTable_zx_TopicUserRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TopicUserRoleDA.GetDataTable_zx_TopicUserRole(strWhereCond);
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
objDT = zx_TopicUserRoleDA.GetDataTable(strWhereCond);
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
objDT = zx_TopicUserRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TopicUserRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TopicUserRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TopicUserRoleDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TopicUserRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TopicUserRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TopicUserRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTopicUserRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetObjLstByZxTopicUserRoleIdLst(List<string> arrZxTopicUserRoleIdLst)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTopicUserRoleIdLst, true);
 string strWhereCond = string.Format("zxTopicUserRoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTopicUserRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TopicUserRoleEN> GetObjLstByZxTopicUserRoleIdLstCache(List<string> arrZxTopicUserRoleIdLst)
{
string strKey = string.Format("{0}", clszx_TopicUserRoleEN._CurrTabName);
List<clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLst_Sel =
arrzx_TopicUserRoleObjLstCache
.Where(x => arrZxTopicUserRoleIdLst.Contains(x.zxTopicUserRoleId));
return arrzx_TopicUserRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetObjLst(string strWhereCond)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
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
public static List<clszx_TopicUserRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TopicUserRoleEN> GetSubObjLstCache(clszx_TopicUserRoleEN objzx_TopicUserRoleCond)
{
List<clszx_TopicUserRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicUserRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicUserRole.AttributeName)
{
if (objzx_TopicUserRoleCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicUserRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicUserRoleCond[strFldName].ToString());
}
else
{
if (objzx_TopicUserRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicUserRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicUserRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicUserRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicUserRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicUserRoleCond[strFldName]));
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
public static List<clszx_TopicUserRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
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
public static List<clszx_TopicUserRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
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
List<clszx_TopicUserRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TopicUserRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TopicUserRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
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
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
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
public static List<clszx_TopicUserRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TopicUserRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
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
public static List<clszx_TopicUserRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TopicUserRoleEN> arrObjLst = new List<clszx_TopicUserRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN();
try
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objRow[conzx_TopicUserRole.zxTopicUserRoleId].ToString().Trim(); //主键Id
objzx_TopicUserRoleEN.TopicUserRoleName = objRow[conzx_TopicUserRole.TopicUserRoleName].ToString().Trim(); //主题用户角色
objzx_TopicUserRoleEN.UpdUserId = objRow[conzx_TopicUserRole.UpdUserId].ToString().Trim(); //修改用户Id
objzx_TopicUserRoleEN.UpdDate = objRow[conzx_TopicUserRole.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicUserRole.UpdDate].ToString().Trim(); //修改日期
objzx_TopicUserRoleEN.Memo = objRow[conzx_TopicUserRole.Memo] == DBNull.Value ? null : objRow[conzx_TopicUserRole.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicUserRoleEN.zxTopicUserRoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicUserRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TopicUserRole(ref clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
bool bolResult = zx_TopicUserRoleDA.Getzx_TopicUserRole(ref objzx_TopicUserRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicUserRoleEN GetObjByzxTopicUserRoleId(string strzxTopicUserRoleId)
{
if (strzxTopicUserRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTopicUserRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTopicUserRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTopicUserRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TopicUserRoleEN objzx_TopicUserRoleEN = zx_TopicUserRoleDA.GetObjByzxTopicUserRoleId(strzxTopicUserRoleId);
return objzx_TopicUserRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TopicUserRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TopicUserRoleEN objzx_TopicUserRoleEN = zx_TopicUserRoleDA.GetFirstObj(strWhereCond);
 return objzx_TopicUserRoleEN;
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
public static clszx_TopicUserRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TopicUserRoleEN objzx_TopicUserRoleEN = zx_TopicUserRoleDA.GetObjByDataRow(objRow);
 return objzx_TopicUserRoleEN;
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
public static clszx_TopicUserRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TopicUserRoleEN objzx_TopicUserRoleEN = zx_TopicUserRoleDA.GetObjByDataRow(objRow);
 return objzx_TopicUserRoleEN;
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
 /// <param name = "strzxTopicUserRoleId">所给的关键字</param>
 /// <param name = "lstzx_TopicUserRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicUserRoleEN GetObjByzxTopicUserRoleIdFromList(string strzxTopicUserRoleId, List<clszx_TopicUserRoleEN> lstzx_TopicUserRoleObjLst)
{
foreach (clszx_TopicUserRoleEN objzx_TopicUserRoleEN in lstzx_TopicUserRoleObjLst)
{
if (objzx_TopicUserRoleEN.zxTopicUserRoleId == strzxTopicUserRoleId)
{
return objzx_TopicUserRoleEN;
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
 string strMaxZxTopicUserRoleId;
 try
 {
 strMaxZxTopicUserRoleId = clszx_TopicUserRoleDA.GetMaxStrId();
 return strMaxZxTopicUserRoleId;
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
 string strzxTopicUserRoleId;
 try
 {
 strzxTopicUserRoleId = new clszx_TopicUserRoleDA().GetFirstID(strWhereCond);
 return strzxTopicUserRoleId;
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
 arrList = zx_TopicUserRoleDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TopicUserRoleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTopicUserRoleId)
{
if (string.IsNullOrEmpty(strzxTopicUserRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTopicUserRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TopicUserRoleDA.IsExist(strzxTopicUserRoleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strzxTopicUserRoleId">主键Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strzxTopicUserRoleId, string strOpUser)
{
clszx_TopicUserRoleEN objzx_TopicUserRoleEN = clszx_TopicUserRoleBL.GetObjByzxTopicUserRoleId(strzxTopicUserRoleId);
objzx_TopicUserRoleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_TopicUserRoleBL.UpdateBySql2(objzx_TopicUserRoleEN);
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
 bolIsExist = clszx_TopicUserRoleDA.IsExistTable();
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
 bolIsExist = zx_TopicUserRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
if (objzx_TopicUserRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主键Id = [{0}],主题用户角色 = [{1}]的数据已经存在!(in clszx_TopicUserRoleBL.AddNewRecordBySql2)", objzx_TopicUserRoleEN.zxTopicUserRoleId,objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
bool bolResult = zx_TopicUserRoleDA.AddNewRecordBySQL2(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
if (objzx_TopicUserRoleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主键Id = [{0}],主题用户角色 = [{1}]的数据已经存在!(in clszx_TopicUserRoleBL.AddNewRecordBySql2WithReturnKey)", objzx_TopicUserRoleEN.zxTopicUserRoleId,objzx_TopicUserRoleEN.TopicUserRoleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true || clszx_TopicUserRoleBL.IsExist(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
     objzx_TopicUserRoleEN.zxTopicUserRoleId = clszx_TopicUserRoleBL.GetMaxStrId_S();
 }
string strKey = zx_TopicUserRoleDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
try
{
bool bolResult = zx_TopicUserRoleDA.Update(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "objzx_TopicUserRoleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 if (string.IsNullOrEmpty(objzx_TopicUserRoleEN.zxTopicUserRoleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TopicUserRoleDA.UpdateBySql2(objzx_TopicUserRoleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicUserRoleBL.ReFreshCache();

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
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
 /// <param name = "strzxTopicUserRoleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxTopicUserRoleId)
{
try
{
 clszx_TopicUserRoleEN objzx_TopicUserRoleEN = clszx_TopicUserRoleBL.GetObjByzxTopicUserRoleId(strzxTopicUserRoleId);

if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(objzx_TopicUserRoleEN.zxTopicUserRoleId, "SetUpdDate");
}
if (objzx_TopicUserRoleEN != null)
{
int intRecNum = zx_TopicUserRoleDA.DelRecord(strzxTopicUserRoleId);
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
/// <param name="strzxTopicUserRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxTopicUserRoleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicUserRoleDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicUserRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TopicUserRole.zxTopicUserRoleId,
//strzxTopicUserRoleId);
//        clszx_TopicUserRoleBL.Delzx_TopicUserRolesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicUserRoleBL.DelRecord(strzxTopicUserRoleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicUserRoleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicUserRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxTopicUserRoleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxTopicUserRoleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TopicUserRoleBL.relatedActions != null)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(strzxTopicUserRoleId, "UpdRelaTabDate");
}
bool bolResult = zx_TopicUserRoleDA.DelRecord(strzxTopicUserRoleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxTopicUserRoleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TopicUserRoles(List<string> arrzxTopicUserRoleIdLst)
{
if (arrzxTopicUserRoleIdLst.Count == 0) return 0;
try
{
if (clszx_TopicUserRoleBL.relatedActions != null)
{
foreach (var strzxTopicUserRoleId in arrzxTopicUserRoleIdLst)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(strzxTopicUserRoleId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_TopicUserRoleDA.Delzx_TopicUserRole(arrzxTopicUserRoleIdLst);
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
public static int Delzx_TopicUserRolesByCond(string strWhereCond)
{
try
{
if (clszx_TopicUserRoleBL.relatedActions != null)
{
List<string> arrzxTopicUserRoleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxTopicUserRoleId in arrzxTopicUserRoleId)
{
clszx_TopicUserRoleBL.relatedActions.UpdRelaTabDate(strzxTopicUserRoleId, "UpdRelaTabDate");
}
}
int intRecNum = zx_TopicUserRoleDA.Delzx_TopicUserRole(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TopicUserRole]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxTopicUserRoleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxTopicUserRoleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicUserRoleDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicUserRole]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicUserRoleBL.DelRecord(strzxTopicUserRoleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicUserRoleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicUserRoleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TopicUserRoleENS">源对象</param>
 /// <param name = "objzx_TopicUserRoleENT">目标对象</param>
 public static void CopyTo(clszx_TopicUserRoleEN objzx_TopicUserRoleENS, clszx_TopicUserRoleEN objzx_TopicUserRoleENT)
{
try
{
objzx_TopicUserRoleENT.zxTopicUserRoleId = objzx_TopicUserRoleENS.zxTopicUserRoleId; //主键Id
objzx_TopicUserRoleENT.TopicUserRoleName = objzx_TopicUserRoleENS.TopicUserRoleName; //主题用户角色
objzx_TopicUserRoleENT.UpdUserId = objzx_TopicUserRoleENS.UpdUserId; //修改用户Id
objzx_TopicUserRoleENT.UpdDate = objzx_TopicUserRoleENS.UpdDate; //修改日期
objzx_TopicUserRoleENT.Memo = objzx_TopicUserRoleENS.Memo; //备注
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
 /// <param name = "objzx_TopicUserRoleEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
try
{
objzx_TopicUserRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TopicUserRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TopicUserRole.zxTopicUserRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicUserRoleEN.zxTopicUserRoleId = objzx_TopicUserRoleEN.zxTopicUserRoleId; //主键Id
}
if (arrFldSet.Contains(conzx_TopicUserRole.TopicUserRoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicUserRoleEN.TopicUserRoleName = objzx_TopicUserRoleEN.TopicUserRoleName; //主题用户角色
}
if (arrFldSet.Contains(conzx_TopicUserRole.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicUserRoleEN.UpdUserId = objzx_TopicUserRoleEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conzx_TopicUserRole.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicUserRoleEN.UpdDate = objzx_TopicUserRoleEN.UpdDate == "[null]" ? null :  objzx_TopicUserRoleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TopicUserRole.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicUserRoleEN.Memo = objzx_TopicUserRoleEN.Memo == "[null]" ? null :  objzx_TopicUserRoleEN.Memo; //备注
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
 /// <param name = "objzx_TopicUserRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
try
{
if (objzx_TopicUserRoleEN.UpdDate == "[null]") objzx_TopicUserRoleEN.UpdDate = null; //修改日期
if (objzx_TopicUserRoleEN.Memo == "[null]") objzx_TopicUserRoleEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 zx_TopicUserRoleDA.CheckPropertyNew(objzx_TopicUserRoleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
 zx_TopicUserRoleDA.CheckProperty4Condition(objzx_TopicUserRoleEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_zxTopicUserRoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_TopicUserRole.zxTopicUserRoleId); 
List<clszx_TopicUserRoleEN> arrObjLst = clszx_TopicUserRoleBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_TopicUserRoleEN objzx_TopicUserRoleEN = new clszx_TopicUserRoleEN()
{
zxTopicUserRoleId = "0",
TopicUserRoleName = "选[中学主题用户角色]..."
};
arrObjLst.Insert(0, objzx_TopicUserRoleEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_TopicUserRole.zxTopicUserRoleId;
objComboBox.DisplayMember = conzx_TopicUserRole.TopicUserRoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_zxTopicUserRoleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学主题用户角色]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_TopicUserRole.zxTopicUserRoleId); 
IEnumerable<clszx_TopicUserRoleEN> arrObjLst = clszx_TopicUserRoleBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_TopicUserRole.zxTopicUserRoleId;
objDDL.DataTextField = conzx_TopicUserRole.TopicUserRoleName;
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
public static void BindDdl_zxTopicUserRoleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学主题用户角色]...","0");
List<clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLst = GetAllzx_TopicUserRoleObjLstCache(); 
objDDL.DataValueField = conzx_TopicUserRole.zxTopicUserRoleId;
objDDL.DataTextField = conzx_TopicUserRole.TopicUserRoleName;
objDDL.DataSource = arrzx_TopicUserRoleObjLst;
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
if (clszx_TopicUserRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicUserRoleBL没有刷新缓存机制(clszx_TopicUserRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTopicUserRoleId");
//if (arrzx_TopicUserRoleObjLstCache == null)
//{
//arrzx_TopicUserRoleObjLstCache = zx_TopicUserRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicUserRoleEN GetObjByzxTopicUserRoleIdCache(string strzxTopicUserRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_TopicUserRoleEN._CurrTabName);
List<clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLst_Sel =
arrzx_TopicUserRoleObjLstCache
.Where(x=> x.zxTopicUserRoleId == strzxTopicUserRoleId 
);
if (arrzx_TopicUserRoleObjLst_Sel.Count() == 0)
{
   clszx_TopicUserRoleEN obj = clszx_TopicUserRoleBL.GetObjByzxTopicUserRoleId(strzxTopicUserRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_TopicUserRoleObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTopicUserRoleNameByzxTopicUserRoleIdCache(string strzxTopicUserRoleId)
{
if (string.IsNullOrEmpty(strzxTopicUserRoleId) == true) return "";
//获取缓存中的对象列表
clszx_TopicUserRoleEN objzx_TopicUserRole = GetObjByzxTopicUserRoleIdCache(strzxTopicUserRoleId);
if (objzx_TopicUserRole == null) return "";
return objzx_TopicUserRole.TopicUserRoleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicUserRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxTopicUserRoleIdCache(string strzxTopicUserRoleId)
{
if (string.IsNullOrEmpty(strzxTopicUserRoleId) == true) return "";
//获取缓存中的对象列表
clszx_TopicUserRoleEN objzx_TopicUserRole = GetObjByzxTopicUserRoleIdCache(strzxTopicUserRoleId);
if (objzx_TopicUserRole == null) return "";
return objzx_TopicUserRole.TopicUserRoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetAllzx_TopicUserRoleObjLstCache()
{
//获取缓存中的对象列表
List<clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLstCache = GetObjLstCache(); 
return arrzx_TopicUserRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicUserRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_TopicUserRoleEN._CurrTabName);
List<clszx_TopicUserRoleEN> arrzx_TopicUserRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_TopicUserRoleObjLstCache;
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
string strKey = string.Format("{0}", clszx_TopicUserRoleEN._CurrTabName);
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
if (clszx_TopicUserRoleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_TopicUserRoleEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_TopicUserRoleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TopicUserRole(中学主题用户角色)
 /// 唯一性条件:zxTopicUserRoleId_TopicUserRoleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TopicUserRoleEN objzx_TopicUserRoleEN)
{
//检测记录是否存在
string strResult = zx_TopicUserRoleDA.GetUniCondStr(objzx_TopicUserRoleEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxTopicUserRoleId)
{
if (strInFldName != conzx_TopicUserRole.zxTopicUserRoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TopicUserRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TopicUserRole.AttributeName));
throw new Exception(strMsg);
}
var objzx_TopicUserRole = clszx_TopicUserRoleBL.GetObjByzxTopicUserRoleIdCache(strzxTopicUserRoleId);
if (objzx_TopicUserRole == null) return "";
return objzx_TopicUserRole[strOutFldName].ToString();
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
int intRecCount = clszx_TopicUserRoleDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TopicUserRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TopicUserRoleDA.GetRecCount();
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
int intRecCount = clszx_TopicUserRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TopicUserRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TopicUserRoleEN objzx_TopicUserRoleCond)
{
List<clszx_TopicUserRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_TopicUserRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicUserRole.AttributeName)
{
if (objzx_TopicUserRoleCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicUserRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicUserRoleCond[strFldName].ToString());
}
else
{
if (objzx_TopicUserRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicUserRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicUserRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicUserRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicUserRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicUserRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicUserRoleCond[strFldName]));
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
 List<string> arrList = clszx_TopicUserRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicUserRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicUserRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TopicUserRoleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicUserRoleDA.SetFldValue(clszx_TopicUserRoleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TopicUserRoleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicUserRoleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicUserRoleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicUserRoleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TopicUserRole] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主键Id*/ 
 strCreateTabCode.Append(" zxTopicUserRoleId char(4) primary key, "); 
 // /**主题用户角色*/ 
 strCreateTabCode.Append(" TopicUserRoleName varchar(100) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学主题用户角色(zx_TopicUserRole)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TopicUserRole : clsCommFun4BL
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
clszx_TopicUserRoleBL.ReFreshThisCache();
}
}

}