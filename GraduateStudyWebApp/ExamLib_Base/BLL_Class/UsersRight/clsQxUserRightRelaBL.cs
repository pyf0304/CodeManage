﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRightRelaBL
 表名:QxUserRightRela(01120169)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:42:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsQxUserRightRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRightRelaEN GetObj(this K_mId_QxUserRightRela myKey)
{
clsQxUserRightRelaEN objQxUserRightRelaEN = clsQxUserRightRelaBL.QxUserRightRelaDA.GetObjBymId(myKey.Value);
return objQxUserRightRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
if (CheckUniqueness(objQxUserRightRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}]的数据已经存在!(in clsQxUserRightRelaBL.AddNewRecord)", objQxUserRightRelaEN.UserId,objQxUserRightRelaEN.RightId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsQxUserRightRelaBL.QxUserRightRelaDA.AddNewRecordBySQL2(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsQxUserRightRelaEN objQxUserRightRelaEN)
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
objQxUserRightRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objQxUserRightRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],权限编号(RightId)=[{1}])已经存在,不能重复!", objQxUserRightRelaEN.UserId, objQxUserRightRelaEN.RightId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objQxUserRightRelaEN.AddNewRecord();
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
if (CheckUniqueness(objQxUserRightRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}]的数据已经存在!(in clsQxUserRightRelaBL.AddNewRecordWithReturnKey)", objQxUserRightRelaEN.UserId,objQxUserRightRelaEN.RightId);
throw new Exception(strMsg);
}
try
{
string strKey = clsQxUserRightRelaBL.QxUserRightRelaDA.AddNewRecordBySQL2WithReturnKey(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetmId(this clsQxUserRightRelaEN objQxUserRightRelaEN, long lngmId, string strComparisonOp="")
	{
objQxUserRightRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.mId) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.mId, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.mId] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetUserId(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conQxUserRightRela.UserId);
}
objQxUserRightRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.UserId) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.UserId, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.UserId] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetRightId(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, conQxUserRightRela.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, conQxUserRightRela.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, conQxUserRightRela.RightId);
}
objQxUserRightRelaEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.RightId) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.RightId, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.RightId] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetQxAuthorizeTypeId(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strQxAuthorizeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxAuthorizeTypeId, conQxUserRightRela.QxAuthorizeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxAuthorizeTypeId, 2, conQxUserRightRela.QxAuthorizeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxAuthorizeTypeId, 2, conQxUserRightRela.QxAuthorizeTypeId);
}
objQxUserRightRelaEN.QxAuthorizeTypeId = strQxAuthorizeTypeId; //授权类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.QxAuthorizeTypeId) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.QxAuthorizeTypeId, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.QxAuthorizeTypeId] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetAuthorizer(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, conQxUserRightRela.Authorizer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthorizer, 18, conQxUserRightRela.Authorizer);
}
objQxUserRightRelaEN.Authorizer = strAuthorizer; //授权人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.Authorizer) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.Authorizer, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.Authorizer] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetPrjId(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conQxUserRightRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conQxUserRightRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conQxUserRightRela.PrjId);
}
objQxUserRightRelaEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.PrjId) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.PrjId, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.PrjId] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetUpdDate(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxUserRightRela.UpdDate);
}
objQxUserRightRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.UpdDate) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.UpdDate, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.UpdDate] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetUpdUser(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxUserRightRela.UpdUser);
}
objQxUserRightRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.UpdUser) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.UpdUser, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.UpdUser] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxUserRightRelaEN SetMemo(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxUserRightRela.Memo);
}
objQxUserRightRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxUserRightRelaEN.dicFldComparisonOp.ContainsKey(conQxUserRightRela.Memo) == false)
{
objQxUserRightRelaEN.dicFldComparisonOp.Add(conQxUserRightRela.Memo, strComparisonOp);
}
else
{
objQxUserRightRelaEN.dicFldComparisonOp[conQxUserRightRela.Memo] = strComparisonOp;
}
}
return objQxUserRightRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxUserRightRelaEN.CheckPropertyNew();
clsQxUserRightRelaEN objQxUserRightRelaCond = new clsQxUserRightRelaEN();
string strCondition = objQxUserRightRelaCond
.SetmId(objQxUserRightRelaEN.mId, "<>")
.SetUserId(objQxUserRightRelaEN.UserId, "=")
.SetRightId(objQxUserRightRelaEN.RightId, "=")
.GetCombineCondition();
objQxUserRightRelaEN._IsCheckProperty = true;
bool bolIsExist = clsQxUserRightRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_RightId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxUserRightRelaEN.Update();
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
 /// <param name = "objQxUserRightRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxUserRightRelaEN objQxUserRightRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxUserRightRelaEN objQxUserRightRelaCond = new clsQxUserRightRelaEN();
string strCondition = objQxUserRightRelaCond
.SetUserId(objQxUserRightRela.UserId, "=")
.SetRightId(objQxUserRightRela.RightId, "=")
.GetCombineCondition();
objQxUserRightRela._IsCheckProperty = true;
bool bolIsExist = clsQxUserRightRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxUserRightRela.mId = clsQxUserRightRelaBL.GetFirstID_S(strCondition);
objQxUserRightRela.UpdateWithCondition(strCondition);
}
else
{
objQxUserRightRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 if (objQxUserRightRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRightRelaBL.QxUserRightRelaDA.UpdateBySql2(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxUserRightRelaEN objQxUserRightRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQxUserRightRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxUserRightRelaBL.QxUserRightRelaDA.UpdateBySql2(objQxUserRightRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsQxUserRightRelaBL.QxUserRightRelaDA.UpdateBySqlWithCondition(objQxUserRightRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxUserRightRelaEN objQxUserRightRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxUserRightRelaBL.QxUserRightRelaDA.UpdateBySqlWithConditionTransaction(objQxUserRightRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
public static int Delete(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
try
{
int intRecNum = clsQxUserRightRelaBL.QxUserRightRelaDA.DelRecord(objQxUserRightRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaENS">源对象</param>
 /// <param name = "objQxUserRightRelaENT">目标对象</param>
 public static void CopyTo(this clsQxUserRightRelaEN objQxUserRightRelaENS, clsQxUserRightRelaEN objQxUserRightRelaENT)
{
try
{
objQxUserRightRelaENT.mId = objQxUserRightRelaENS.mId; //mId
objQxUserRightRelaENT.UserId = objQxUserRightRelaENS.UserId; //用户ID
objQxUserRightRelaENT.RightId = objQxUserRightRelaENS.RightId; //权限编号
objQxUserRightRelaENT.QxAuthorizeTypeId = objQxUserRightRelaENS.QxAuthorizeTypeId; //授权类型Id
objQxUserRightRelaENT.Authorizer = objQxUserRightRelaENS.Authorizer; //授权人
objQxUserRightRelaENT.PrjId = objQxUserRightRelaENS.PrjId; //PrjId
objQxUserRightRelaENT.UpdDate = objQxUserRightRelaENS.UpdDate; //修改日期
objQxUserRightRelaENT.UpdUser = objQxUserRightRelaENS.UpdUser; //修改人
objQxUserRightRelaENT.Memo = objQxUserRightRelaENS.Memo; //备注
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
 /// <param name = "objQxUserRightRelaENS">源对象</param>
 /// <returns>目标对象=>clsQxUserRightRelaEN:objQxUserRightRelaENT</returns>
 public static clsQxUserRightRelaEN CopyTo(this clsQxUserRightRelaEN objQxUserRightRelaENS)
{
try
{
 clsQxUserRightRelaEN objQxUserRightRelaENT = new clsQxUserRightRelaEN()
{
mId = objQxUserRightRelaENS.mId, //mId
UserId = objQxUserRightRelaENS.UserId, //用户ID
RightId = objQxUserRightRelaENS.RightId, //权限编号
QxAuthorizeTypeId = objQxUserRightRelaENS.QxAuthorizeTypeId, //授权类型Id
Authorizer = objQxUserRightRelaENS.Authorizer, //授权人
PrjId = objQxUserRightRelaENS.PrjId, //PrjId
UpdDate = objQxUserRightRelaENS.UpdDate, //修改日期
UpdUser = objQxUserRightRelaENS.UpdUser, //修改人
Memo = objQxUserRightRelaENS.Memo, //备注
};
 return objQxUserRightRelaENT;
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
public static void CheckPropertyNew(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 clsQxUserRightRelaBL.QxUserRightRelaDA.CheckPropertyNew(objQxUserRightRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 clsQxUserRightRelaBL.QxUserRightRelaDA.CheckProperty4Condition(objQxUserRightRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxUserRightRelaEN objQxUserRightRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.mId) == true)
{
string strComparisonOpmId = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQxUserRightRela.mId, objQxUserRightRelaCond.mId, strComparisonOpmId);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.UserId) == true)
{
string strComparisonOpUserId = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.UserId, objQxUserRightRelaCond.UserId, strComparisonOpUserId);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.RightId) == true)
{
string strComparisonOpRightId = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.RightId, objQxUserRightRelaCond.RightId, strComparisonOpRightId);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.QxAuthorizeTypeId) == true)
{
string strComparisonOpQxAuthorizeTypeId = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.QxAuthorizeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.QxAuthorizeTypeId, objQxUserRightRelaCond.QxAuthorizeTypeId, strComparisonOpQxAuthorizeTypeId);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.Authorizer) == true)
{
string strComparisonOpAuthorizer = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.Authorizer, objQxUserRightRelaCond.Authorizer, strComparisonOpAuthorizer);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.PrjId) == true)
{
string strComparisonOpPrjId = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.PrjId, objQxUserRightRelaCond.PrjId, strComparisonOpPrjId);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.UpdDate, objQxUserRightRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.UpdUser, objQxUserRightRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxUserRightRelaCond.IsUpdated(conQxUserRightRela.Memo) == true)
{
string strComparisonOpMemo = objQxUserRightRelaCond.dicFldComparisonOp[conQxUserRightRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxUserRightRela.Memo, objQxUserRightRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxUserRightRela(用户权限关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_RightId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRightRelaEN == null) return true;
if (objQxUserRightRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserRightRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserRightRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightRelaEN.UserId);
}
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightRelaEN.RightId);
if (clsQxUserRightRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRightRelaEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightRelaEN.UserId);
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightRelaEN.RightId);
if (clsQxUserRightRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxUserRightRela(用户权限关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_RightId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxUserRightRelaEN objQxUserRightRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxUserRightRelaEN == null) return "";
if (objQxUserRightRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objQxUserRightRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objQxUserRightRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightRelaEN.UserId);
}
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightRelaEN.RightId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQxUserRightRelaEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objQxUserRightRelaEN.UserId);
 sbCondition.AppendFormat(" and RightId = '{0}'", objQxUserRightRelaEN.RightId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxUserRightRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户权限关系(QxUserRightRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRightRelaBL
{
public static RelatedActions_QxUserRightRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxUserRightRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxUserRightRelaDA QxUserRightRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxUserRightRelaDA();
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
 public clsQxUserRightRelaBL()
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
if (string.IsNullOrEmpty(clsQxUserRightRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxUserRightRelaEN._ConnectString);
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
public static DataTable GetDataTable_QxUserRightRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxUserRightRelaDA.GetDataTable_QxUserRightRela(strWhereCond);
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
objDT = QxUserRightRelaDA.GetDataTable(strWhereCond);
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
objDT = QxUserRightRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxUserRightRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxUserRightRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxUserRightRelaDA.GetDataTable_Top(objTopPara);
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
objDT = QxUserRightRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxUserRightRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxUserRightRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsQxUserRightRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
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
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxUserRightRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsQxUserRightRelaEN._CurrTabName);
List<clsQxUserRightRelaEN> arrQxUserRightRelaObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightRelaEN> arrQxUserRightRelaObjLst_Sel =
arrQxUserRightRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrQxUserRightRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightRelaEN> GetObjLst(string strWhereCond)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
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
public static List<clsQxUserRightRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxUserRightRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxUserRightRelaEN> GetSubObjLstCache(clsQxUserRightRelaEN objQxUserRightRelaCond)
{
List<clsQxUserRightRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRightRela.AttributeName)
{
if (objQxUserRightRelaCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRightRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightRelaCond[strFldName].ToString());
}
else
{
if (objQxUserRightRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRightRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRightRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRightRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRightRelaCond[strFldName]));
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
public static List<clsQxUserRightRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
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
public static List<clsQxUserRightRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
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
List<clsQxUserRightRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxUserRightRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxUserRightRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
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
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
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
public static List<clsQxUserRightRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxUserRightRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxUserRightRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
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
public static List<clsQxUserRightRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRightRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxUserRightRelaEN> arrObjLst = new List<clsQxUserRightRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRightRelaEN objQxUserRightRelaEN = new clsQxUserRightRelaEN();
try
{
objQxUserRightRelaEN.mId = Int32.Parse(objRow[conQxUserRightRela.mId].ToString().Trim()); //mId
objQxUserRightRelaEN.UserId = objRow[conQxUserRightRela.UserId] == DBNull.Value ? null : objRow[conQxUserRightRela.UserId].ToString().Trim(); //用户ID
objQxUserRightRelaEN.RightId = objRow[conQxUserRightRela.RightId].ToString().Trim(); //权限编号
objQxUserRightRelaEN.QxAuthorizeTypeId = objRow[conQxUserRightRela.QxAuthorizeTypeId].ToString().Trim(); //授权类型Id
objQxUserRightRelaEN.Authorizer = objRow[conQxUserRightRela.Authorizer].ToString().Trim(); //授权人
objQxUserRightRelaEN.PrjId = objRow[conQxUserRightRela.PrjId].ToString().Trim(); //PrjId
objQxUserRightRelaEN.UpdDate = objRow[conQxUserRightRela.UpdDate] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdDate].ToString().Trim(); //修改日期
objQxUserRightRelaEN.UpdUser = objRow[conQxUserRightRela.UpdUser] == DBNull.Value ? null : objRow[conQxUserRightRela.UpdUser].ToString().Trim(); //修改人
objQxUserRightRelaEN.Memo = objRow[conQxUserRightRela.Memo] == DBNull.Value ? null : objRow[conQxUserRightRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxUserRightRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxUserRightRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRightRela(ref clsQxUserRightRelaEN objQxUserRightRelaEN)
{
bool bolResult = QxUserRightRelaDA.GetQxUserRightRela(ref objQxUserRightRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRightRelaEN GetObjBymId(long lngmId)
{
clsQxUserRightRelaEN objQxUserRightRelaEN = QxUserRightRelaDA.GetObjBymId(lngmId);
return objQxUserRightRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxUserRightRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxUserRightRelaEN objQxUserRightRelaEN = QxUserRightRelaDA.GetFirstObj(strWhereCond);
 return objQxUserRightRelaEN;
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
public static clsQxUserRightRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxUserRightRelaEN objQxUserRightRelaEN = QxUserRightRelaDA.GetObjByDataRow(objRow);
 return objQxUserRightRelaEN;
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
public static clsQxUserRightRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxUserRightRelaEN objQxUserRightRelaEN = QxUserRightRelaDA.GetObjByDataRow(objRow);
 return objQxUserRightRelaEN;
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
 /// <param name = "lstQxUserRightRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRightRelaEN GetObjBymIdFromList(long lngmId, List<clsQxUserRightRelaEN> lstQxUserRightRelaObjLst)
{
foreach (clsQxUserRightRelaEN objQxUserRightRelaEN in lstQxUserRightRelaObjLst)
{
if (objQxUserRightRelaEN.mId == lngmId)
{
return objQxUserRightRelaEN;
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
 lngmId = new clsQxUserRightRelaDA().GetFirstID(strWhereCond);
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
 arrList = QxUserRightRelaDA.GetID(strWhereCond);
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
bool bolIsExist = QxUserRightRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = QxUserRightRelaDA.IsExist(lngmId);
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
clsQxUserRightRelaEN objQxUserRightRelaEN = clsQxUserRightRelaBL.GetObjBymId(lngmId);
objQxUserRightRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxUserRightRelaEN.UpdUser = strOpUser;
return clsQxUserRightRelaBL.UpdateBySql2(objQxUserRightRelaEN);
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
 bolIsExist = clsQxUserRightRelaDA.IsExistTable();
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
 bolIsExist = QxUserRightRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
if (objQxUserRightRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}]的数据已经存在!(in clsQxUserRightRelaBL.AddNewRecordBySql2)", objQxUserRightRelaEN.UserId,objQxUserRightRelaEN.RightId);
throw new Exception(strMsg);
}
try
{
bool bolResult = QxUserRightRelaDA.AddNewRecordBySQL2(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
if (objQxUserRightRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],权限编号 = [{1}]的数据已经存在!(in clsQxUserRightRelaBL.AddNewRecordBySql2WithReturnKey)", objQxUserRightRelaEN.UserId,objQxUserRightRelaEN.RightId);
throw new Exception(strMsg);
}
try
{
string strKey = QxUserRightRelaDA.AddNewRecordBySQL2WithReturnKey(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
try
{
bool bolResult = QxUserRightRelaDA.Update(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 /// <param name = "objQxUserRightRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 if (objQxUserRightRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxUserRightRelaDA.UpdateBySql2(objQxUserRightRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxUserRightRelaBL.ReFreshCache();

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
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
 clsQxUserRightRelaEN objQxUserRightRelaEN = clsQxUserRightRelaBL.GetObjBymId(lngmId);

if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(objQxUserRightRelaEN.mId, objQxUserRightRelaEN.UpdUser);
}
if (objQxUserRightRelaEN != null)
{
int intRecNum = QxUserRightRelaDA.DelRecord(lngmId);
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
objSQL = clsQxUserRightRelaDA.GetSpecSQLObj();
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
//删除与表:[QxUserRightRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxUserRightRela.mId,
//lngmId);
//        clsQxUserRightRelaBL.DelQxUserRightRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRightRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRightRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsQxUserRightRelaBL.relatedActions != null)
{
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = QxUserRightRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelQxUserRightRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsQxUserRightRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxUserRightRelaDA.DelQxUserRightRela(arrmIdLst);
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
public static int DelQxUserRightRelasByCond(string strWhereCond)
{
try
{
if (clsQxUserRightRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsQxUserRightRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = QxUserRightRelaDA.DelQxUserRightRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxUserRightRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxUserRightRelaDA.GetSpecSQLObj();
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
//删除与表:[QxUserRightRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxUserRightRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxUserRightRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objQxUserRightRelaENS">源对象</param>
 /// <param name = "objQxUserRightRelaENT">目标对象</param>
 public static void CopyTo(clsQxUserRightRelaEN objQxUserRightRelaENS, clsQxUserRightRelaEN objQxUserRightRelaENT)
{
try
{
objQxUserRightRelaENT.mId = objQxUserRightRelaENS.mId; //mId
objQxUserRightRelaENT.UserId = objQxUserRightRelaENS.UserId; //用户ID
objQxUserRightRelaENT.RightId = objQxUserRightRelaENS.RightId; //权限编号
objQxUserRightRelaENT.QxAuthorizeTypeId = objQxUserRightRelaENS.QxAuthorizeTypeId; //授权类型Id
objQxUserRightRelaENT.Authorizer = objQxUserRightRelaENS.Authorizer; //授权人
objQxUserRightRelaENT.PrjId = objQxUserRightRelaENS.PrjId; //PrjId
objQxUserRightRelaENT.UpdDate = objQxUserRightRelaENS.UpdDate; //修改日期
objQxUserRightRelaENT.UpdUser = objQxUserRightRelaENS.UpdUser; //修改人
objQxUserRightRelaENT.Memo = objQxUserRightRelaENS.Memo; //备注
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
 /// <param name = "objQxUserRightRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
try
{
objQxUserRightRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxUserRightRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxUserRightRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.mId = objQxUserRightRelaEN.mId; //mId
}
if (arrFldSet.Contains(conQxUserRightRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.UserId = objQxUserRightRelaEN.UserId == "[null]" ? null :  objQxUserRightRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(conQxUserRightRela.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.RightId = objQxUserRightRelaEN.RightId; //权限编号
}
if (arrFldSet.Contains(conQxUserRightRela.QxAuthorizeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.QxAuthorizeTypeId = objQxUserRightRelaEN.QxAuthorizeTypeId; //授权类型Id
}
if (arrFldSet.Contains(conQxUserRightRela.Authorizer, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.Authorizer = objQxUserRightRelaEN.Authorizer; //授权人
}
if (arrFldSet.Contains(conQxUserRightRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.PrjId = objQxUserRightRelaEN.PrjId; //PrjId
}
if (arrFldSet.Contains(conQxUserRightRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.UpdDate = objQxUserRightRelaEN.UpdDate == "[null]" ? null :  objQxUserRightRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxUserRightRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.UpdUser = objQxUserRightRelaEN.UpdUser == "[null]" ? null :  objQxUserRightRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQxUserRightRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxUserRightRelaEN.Memo = objQxUserRightRelaEN.Memo == "[null]" ? null :  objQxUserRightRelaEN.Memo; //备注
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
 /// <param name = "objQxUserRightRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
try
{
if (objQxUserRightRelaEN.UserId == "[null]") objQxUserRightRelaEN.UserId = null; //用户ID
if (objQxUserRightRelaEN.UpdDate == "[null]") objQxUserRightRelaEN.UpdDate = null; //修改日期
if (objQxUserRightRelaEN.UpdUser == "[null]") objQxUserRightRelaEN.UpdUser = null; //修改人
if (objQxUserRightRelaEN.Memo == "[null]") objQxUserRightRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 QxUserRightRelaDA.CheckPropertyNew(objQxUserRightRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
 QxUserRightRelaDA.CheckProperty4Condition(objQxUserRightRelaEN);
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
if (clsQxUserRightRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRightRelaBL没有刷新缓存机制(clsQxUserRightRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQxUserRightRelaObjLstCache == null)
//{
//arrQxUserRightRelaObjLstCache = QxUserRightRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRightRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxUserRightRelaEN._CurrTabName);
List<clsQxUserRightRelaEN> arrQxUserRightRelaObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightRelaEN> arrQxUserRightRelaObjLst_Sel =
arrQxUserRightRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrQxUserRightRelaObjLst_Sel.Count() == 0)
{
   clsQxUserRightRelaEN obj = clsQxUserRightRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxUserRightRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRightRelaEN> GetAllQxUserRightRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsQxUserRightRelaEN> arrQxUserRightRelaObjLstCache = GetObjLstCache(); 
return arrQxUserRightRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxUserRightRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxUserRightRelaEN._CurrTabName);
List<clsQxUserRightRelaEN> arrQxUserRightRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxUserRightRelaObjLstCache;
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
string strKey = string.Format("{0}", clsQxUserRightRelaEN._CurrTabName);
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
if (clsQxUserRightRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxUserRightRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxUserRightRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxUserRightRela(用户权限关系)
 /// 唯一性条件:UserId_RightId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxUserRightRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxUserRightRelaEN objQxUserRightRelaEN)
{
//检测记录是否存在
string strResult = QxUserRightRelaDA.GetUniCondStr(objQxUserRightRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conQxUserRightRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxUserRightRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxUserRightRela.AttributeName));
throw new Exception(strMsg);
}
var objQxUserRightRela = clsQxUserRightRelaBL.GetObjBymIdCache(lngmId);
if (objQxUserRightRela == null) return "";
return objQxUserRightRela[strOutFldName].ToString();
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
int intRecCount = clsQxUserRightRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsQxUserRightRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxUserRightRelaDA.GetRecCount();
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
int intRecCount = clsQxUserRightRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxUserRightRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxUserRightRelaEN objQxUserRightRelaCond)
{
List<clsQxUserRightRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxUserRightRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxUserRightRela.AttributeName)
{
if (objQxUserRightRelaCond.IsUpdated(strFldName) == false) continue;
if (objQxUserRightRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightRelaCond[strFldName].ToString());
}
else
{
if (objQxUserRightRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxUserRightRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxUserRightRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxUserRightRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxUserRightRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxUserRightRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxUserRightRelaCond[strFldName]));
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
 List<string> arrList = clsQxUserRightRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxUserRightRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxUserRightRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxUserRightRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRightRelaDA.SetFldValue(clsQxUserRightRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxUserRightRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRightRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxUserRightRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxUserRightRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxUserRightRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**权限编号*/ 
 strCreateTabCode.Append(" RightId char(8) not Null, "); 
 // /**授权类型Id*/ 
 strCreateTabCode.Append(" QxAuthorizeTypeId char(2) not Null, "); 
 // /**授权人*/ 
 strCreateTabCode.Append(" Authorizer varchar(18) not Null, "); 
 // /**PrjId*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
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
 /// 用户权限关系(QxUserRightRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxUserRightRela : clsCommFun4BL
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
clsQxUserRightRelaBL.ReFreshThisCache();
}
}

}