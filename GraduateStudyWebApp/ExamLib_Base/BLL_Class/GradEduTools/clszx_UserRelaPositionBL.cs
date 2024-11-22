﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_UserRelaPositionBL
 表名:zx_UserRelaPosition(01120876)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:11:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clszx_UserRelaPositionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_UserRelaPositionEN GetObj(this K_mId_zx_UserRelaPosition myKey)
{
clszx_UserRelaPositionEN objzx_UserRelaPositionEN = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.GetObjBymId(myKey.Value);
return objzx_UserRelaPositionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
if (CheckUniqueness(objzx_UserRelaPositionEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clszx_UserRelaPositionBL.AddNewRecord)", objzx_UserRelaPositionEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.AddNewRecordBySQL2(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
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
objzx_UserRelaPositionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_UserRelaPositionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objzx_UserRelaPositionEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_UserRelaPositionEN.AddNewRecord();
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
if (CheckUniqueness(objzx_UserRelaPositionEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clszx_UserRelaPositionBL.AddNewRecordWithReturnKey)", objzx_UserRelaPositionEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.AddNewRecordBySQL2WithReturnKey(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetmId(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, long lngmId, string strComparisonOp="")
	{
objzx_UserRelaPositionEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.mId) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.mId, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.mId] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetUserId(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conzx_UserRelaPosition.UserId);
}
objzx_UserRelaPositionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.UserId) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.UserId, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.UserId] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetUpdUser(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_UserRelaPosition.UpdUser);
}
objzx_UserRelaPositionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.UpdUser) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.UpdUser, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.UpdUser] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetUpdDate(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_UserRelaPosition.UpdDate);
}
objzx_UserRelaPositionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.UpdDate) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.UpdDate, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.UpdDate] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetIdCurrEduCls(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_UserRelaPosition.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_UserRelaPosition.IdCurrEduCls);
}
objzx_UserRelaPositionEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.IdCurrEduCls) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetOrderNum(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, int? intOrderNum, string strComparisonOp="")
	{
objzx_UserRelaPositionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.OrderNum) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.OrderNum, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.OrderNum] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetXPosition(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, float? fltXPosition, string strComparisonOp="")
	{
objzx_UserRelaPositionEN.XPosition = fltXPosition; //X_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.XPosition) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.XPosition, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.XPosition] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetYPosition(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, float? fltYPosition, string strComparisonOp="")
	{
objzx_UserRelaPositionEN.YPosition = fltYPosition; //Y_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.YPosition) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.YPosition, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.YPosition] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_UserRelaPositionEN SetMemo(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_UserRelaPosition.Memo);
}
objzx_UserRelaPositionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_UserRelaPositionEN.dicFldComparisonOp.ContainsKey(conzx_UserRelaPosition.Memo) == false)
{
objzx_UserRelaPositionEN.dicFldComparisonOp.Add(conzx_UserRelaPosition.Memo, strComparisonOp);
}
else
{
objzx_UserRelaPositionEN.dicFldComparisonOp[conzx_UserRelaPosition.Memo] = strComparisonOp;
}
}
return objzx_UserRelaPositionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_UserRelaPositionEN.CheckPropertyNew();
clszx_UserRelaPositionEN objzx_UserRelaPositionCond = new clszx_UserRelaPositionEN();
string strCondition = objzx_UserRelaPositionCond
.SetmId(objzx_UserRelaPositionEN.mId, "<>")
.SetmId(objzx_UserRelaPositionEN.mId, "=")
.GetCombineCondition();
objzx_UserRelaPositionEN._IsCheckProperty = true;
bool bolIsExist = clszx_UserRelaPositionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_UserRelaPositionEN.Update();
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
 /// <param name = "objzx_UserRelaPosition">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_UserRelaPositionEN objzx_UserRelaPosition)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_UserRelaPositionEN objzx_UserRelaPositionCond = new clszx_UserRelaPositionEN();
string strCondition = objzx_UserRelaPositionCond
.SetmId(objzx_UserRelaPosition.mId, "=")
.GetCombineCondition();
objzx_UserRelaPosition._IsCheckProperty = true;
bool bolIsExist = clszx_UserRelaPositionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_UserRelaPosition.mId = clszx_UserRelaPositionBL.GetFirstID_S(strCondition);
objzx_UserRelaPosition.UpdateWithCondition(strCondition);
}
else
{
objzx_UserRelaPosition.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 if (objzx_UserRelaPositionEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.UpdateBySql2(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_UserRelaPositionEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.UpdateBySql2(objzx_UserRelaPositionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strWhereCond)
{
try
{
bool bolResult = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.UpdateBySqlWithCondition(objzx_UserRelaPositionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.UpdateBySqlWithConditionTransaction(objzx_UserRelaPositionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
public static int Delete(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
try
{
int intRecNum = clszx_UserRelaPositionBL.zx_UserRelaPositionDA.DelRecord(objzx_UserRelaPositionEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionENS">源对象</param>
 /// <param name = "objzx_UserRelaPositionENT">目标对象</param>
 public static void CopyTo(this clszx_UserRelaPositionEN objzx_UserRelaPositionENS, clszx_UserRelaPositionEN objzx_UserRelaPositionENT)
{
try
{
objzx_UserRelaPositionENT.mId = objzx_UserRelaPositionENS.mId; //mId
objzx_UserRelaPositionENT.UserId = objzx_UserRelaPositionENS.UserId; //用户ID
objzx_UserRelaPositionENT.UpdUser = objzx_UserRelaPositionENS.UpdUser; //修改人
objzx_UserRelaPositionENT.UpdDate = objzx_UserRelaPositionENS.UpdDate; //修改日期
objzx_UserRelaPositionENT.IdCurrEduCls = objzx_UserRelaPositionENS.IdCurrEduCls; //教学班流水号
objzx_UserRelaPositionENT.OrderNum = objzx_UserRelaPositionENS.OrderNum; //序号
objzx_UserRelaPositionENT.XPosition = objzx_UserRelaPositionENS.XPosition; //X_坐标
objzx_UserRelaPositionENT.YPosition = objzx_UserRelaPositionENS.YPosition; //Y_坐标
objzx_UserRelaPositionENT.Memo = objzx_UserRelaPositionENS.Memo; //备注
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
 /// <param name = "objzx_UserRelaPositionENS">源对象</param>
 /// <returns>目标对象=>clszx_UserRelaPositionEN:objzx_UserRelaPositionENT</returns>
 public static clszx_UserRelaPositionEN CopyTo(this clszx_UserRelaPositionEN objzx_UserRelaPositionENS)
{
try
{
 clszx_UserRelaPositionEN objzx_UserRelaPositionENT = new clszx_UserRelaPositionEN()
{
mId = objzx_UserRelaPositionENS.mId, //mId
UserId = objzx_UserRelaPositionENS.UserId, //用户ID
UpdUser = objzx_UserRelaPositionENS.UpdUser, //修改人
UpdDate = objzx_UserRelaPositionENS.UpdDate, //修改日期
IdCurrEduCls = objzx_UserRelaPositionENS.IdCurrEduCls, //教学班流水号
OrderNum = objzx_UserRelaPositionENS.OrderNum, //序号
XPosition = objzx_UserRelaPositionENS.XPosition, //X_坐标
YPosition = objzx_UserRelaPositionENS.YPosition, //Y_坐标
Memo = objzx_UserRelaPositionENS.Memo, //备注
};
 return objzx_UserRelaPositionENT;
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
public static void CheckPropertyNew(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 clszx_UserRelaPositionBL.zx_UserRelaPositionDA.CheckPropertyNew(objzx_UserRelaPositionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 clszx_UserRelaPositionBL.zx_UserRelaPositionDA.CheckProperty4Condition(objzx_UserRelaPositionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_UserRelaPositionEN objzx_UserRelaPositionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.mId) == true)
{
string strComparisonOpmId = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_UserRelaPosition.mId, objzx_UserRelaPositionCond.mId, strComparisonOpmId);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.UserId) == true)
{
string strComparisonOpUserId = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_UserRelaPosition.UserId, objzx_UserRelaPositionCond.UserId, strComparisonOpUserId);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_UserRelaPosition.UpdUser, objzx_UserRelaPositionCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_UserRelaPosition.UpdDate, objzx_UserRelaPositionCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_UserRelaPosition.IdCurrEduCls, objzx_UserRelaPositionCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.OrderNum) == true)
{
string strComparisonOpOrderNum = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_UserRelaPosition.OrderNum, objzx_UserRelaPositionCond.OrderNum, strComparisonOpOrderNum);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.XPosition) == true)
{
string strComparisonOpXPosition = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.XPosition];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_UserRelaPosition.XPosition, objzx_UserRelaPositionCond.XPosition, strComparisonOpXPosition);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.YPosition) == true)
{
string strComparisonOpYPosition = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.YPosition];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_UserRelaPosition.YPosition, objzx_UserRelaPositionCond.YPosition, strComparisonOpYPosition);
}
if (objzx_UserRelaPositionCond.IsUpdated(conzx_UserRelaPosition.Memo) == true)
{
string strComparisonOpMemo = objzx_UserRelaPositionCond.dicFldComparisonOp[conzx_UserRelaPosition.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_UserRelaPosition.Memo, objzx_UserRelaPositionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_UserRelaPosition(中学用户关系坐标位置), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_UserRelaPositionEN == null) return true;
if (objzx_UserRelaPositionEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_UserRelaPositionEN.mId);
if (clszx_UserRelaPositionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objzx_UserRelaPositionEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_UserRelaPositionEN.mId);
if (clszx_UserRelaPositionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_UserRelaPosition(中学用户关系坐标位置), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_UserRelaPositionEN == null) return "";
if (objzx_UserRelaPositionEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_UserRelaPositionEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objzx_UserRelaPositionEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objzx_UserRelaPositionEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_UserRelaPosition
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学用户关系坐标位置(zx_UserRelaPosition)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_UserRelaPositionBL
{
public static RelatedActions_zx_UserRelaPosition relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_UserRelaPositionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_UserRelaPositionDA zx_UserRelaPositionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_UserRelaPositionDA();
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
 public clszx_UserRelaPositionBL()
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
if (string.IsNullOrEmpty(clszx_UserRelaPositionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_UserRelaPositionEN._ConnectString);
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
public static DataTable GetDataTable_zx_UserRelaPosition(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_UserRelaPositionDA.GetDataTable_zx_UserRelaPosition(strWhereCond);
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
objDT = zx_UserRelaPositionDA.GetDataTable(strWhereCond);
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
objDT = zx_UserRelaPositionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_UserRelaPositionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_UserRelaPositionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_UserRelaPositionDA.GetDataTable_Top(objTopPara);
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
objDT = zx_UserRelaPositionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_UserRelaPositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_UserRelaPositionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_UserRelaPositionEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
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
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_UserRelaPositionEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_UserRelaPositionEN._CurrTabName, strIdCurrEduCls);
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLst_Sel =
arrzx_UserRelaPositionObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrzx_UserRelaPositionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetObjLst(string strWhereCond)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
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
public static List<clszx_UserRelaPositionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_UserRelaPositionEN> GetSubObjLstCache(clszx_UserRelaPositionEN objzx_UserRelaPositionCond)
{
 string strIdCurrEduCls = objzx_UserRelaPositionCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_UserRelaPositionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_UserRelaPositionEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_UserRelaPositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_UserRelaPosition.AttributeName)
{
if (objzx_UserRelaPositionCond.IsUpdated(strFldName) == false) continue;
if (objzx_UserRelaPositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_UserRelaPositionCond[strFldName].ToString());
}
else
{
if (objzx_UserRelaPositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_UserRelaPositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_UserRelaPositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_UserRelaPositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_UserRelaPositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_UserRelaPositionCond[strFldName]));
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
public static List<clszx_UserRelaPositionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
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
public static List<clszx_UserRelaPositionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
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
List<clszx_UserRelaPositionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_UserRelaPositionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_UserRelaPositionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
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
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
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
public static List<clszx_UserRelaPositionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_UserRelaPositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
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
public static List<clszx_UserRelaPositionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_UserRelaPositionEN> arrObjLst = new List<clszx_UserRelaPositionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_UserRelaPositionEN objzx_UserRelaPositionEN = new clszx_UserRelaPositionEN();
try
{
objzx_UserRelaPositionEN.mId = Int32.Parse(objRow[conzx_UserRelaPosition.mId].ToString().Trim()); //mId
objzx_UserRelaPositionEN.UserId = objRow[conzx_UserRelaPosition.UserId] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UserId].ToString().Trim(); //用户ID
objzx_UserRelaPositionEN.UpdUser = objRow[conzx_UserRelaPosition.UpdUser] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdUser].ToString().Trim(); //修改人
objzx_UserRelaPositionEN.UpdDate = objRow[conzx_UserRelaPosition.UpdDate] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.UpdDate].ToString().Trim(); //修改日期
objzx_UserRelaPositionEN.IdCurrEduCls = objRow[conzx_UserRelaPosition.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_UserRelaPositionEN.OrderNum = objRow[conzx_UserRelaPosition.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_UserRelaPosition.OrderNum].ToString().Trim()); //序号
objzx_UserRelaPositionEN.XPosition = objRow[conzx_UserRelaPosition.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.XPosition].ToString().Trim()); //X_坐标
objzx_UserRelaPositionEN.YPosition = objRow[conzx_UserRelaPosition.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_UserRelaPosition.YPosition].ToString().Trim()); //Y_坐标
objzx_UserRelaPositionEN.Memo = objRow[conzx_UserRelaPosition.Memo] == DBNull.Value ? null : objRow[conzx_UserRelaPosition.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_UserRelaPositionEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_UserRelaPositionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_UserRelaPosition(ref clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
bool bolResult = zx_UserRelaPositionDA.Getzx_UserRelaPosition(ref objzx_UserRelaPositionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_UserRelaPositionEN GetObjBymId(long lngmId)
{
clszx_UserRelaPositionEN objzx_UserRelaPositionEN = zx_UserRelaPositionDA.GetObjBymId(lngmId);
return objzx_UserRelaPositionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_UserRelaPositionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_UserRelaPositionEN objzx_UserRelaPositionEN = zx_UserRelaPositionDA.GetFirstObj(strWhereCond);
 return objzx_UserRelaPositionEN;
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
public static clszx_UserRelaPositionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_UserRelaPositionEN objzx_UserRelaPositionEN = zx_UserRelaPositionDA.GetObjByDataRow(objRow);
 return objzx_UserRelaPositionEN;
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
public static clszx_UserRelaPositionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_UserRelaPositionEN objzx_UserRelaPositionEN = zx_UserRelaPositionDA.GetObjByDataRow(objRow);
 return objzx_UserRelaPositionEN;
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
 /// <param name = "lstzx_UserRelaPositionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_UserRelaPositionEN GetObjBymIdFromList(long lngmId, List<clszx_UserRelaPositionEN> lstzx_UserRelaPositionObjLst)
{
foreach (clszx_UserRelaPositionEN objzx_UserRelaPositionEN in lstzx_UserRelaPositionObjLst)
{
if (objzx_UserRelaPositionEN.mId == lngmId)
{
return objzx_UserRelaPositionEN;
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
 lngmId = new clszx_UserRelaPositionDA().GetFirstID(strWhereCond);
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
 arrList = zx_UserRelaPositionDA.GetID(strWhereCond);
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
bool bolIsExist = zx_UserRelaPositionDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_UserRelaPositionDA.IsExist(lngmId);
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
 bolIsExist = clszx_UserRelaPositionDA.IsExistTable();
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
 bolIsExist = zx_UserRelaPositionDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
if (objzx_UserRelaPositionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clszx_UserRelaPositionBL.AddNewRecordBySql2)", objzx_UserRelaPositionEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_UserRelaPositionDA.AddNewRecordBySQL2(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
if (objzx_UserRelaPositionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clszx_UserRelaPositionBL.AddNewRecordBySql2WithReturnKey)", objzx_UserRelaPositionEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_UserRelaPositionDA.AddNewRecordBySQL2WithReturnKey(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
try
{
bool bolResult = zx_UserRelaPositionDA.Update(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 /// <param name = "objzx_UserRelaPositionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 if (objzx_UserRelaPositionEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_UserRelaPositionDA.UpdateBySql2(objzx_UserRelaPositionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
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
 clszx_UserRelaPositionEN objzx_UserRelaPositionEN = clszx_UserRelaPositionBL.GetObjBymId(lngmId);

if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPositionEN.mId, "SetUpdDate");
}
if (objzx_UserRelaPositionEN != null)
{
int intRecNum = zx_UserRelaPositionDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_UserRelaPositionDA.GetSpecSQLObj();
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
//删除与表:[zx_UserRelaPosition]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_UserRelaPosition.mId,
//lngmId);
//        clszx_UserRelaPositionBL.Delzx_UserRelaPositionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_UserRelaPositionBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_UserRelaPositionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = zx_UserRelaPositionDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
public static int Delzx_UserRelaPositions(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clszx_UserRelaPositionBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clszx_UserRelaPositionEN objzx_UserRelaPositionEN = clszx_UserRelaPositionBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = zx_UserRelaPositionDA.Delzx_UserRelaPosition(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_UserRelaPositionEN.IdCurrEduCls);
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
public static int Delzx_UserRelaPositionsByCond(string strWhereCond)
{
try
{
if (clszx_UserRelaPositionBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_UserRelaPosition.IdCurrEduCls, strWhereCond);
int intRecNum = zx_UserRelaPositionDA.Delzx_UserRelaPosition(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_UserRelaPosition]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_UserRelaPositionDA.GetSpecSQLObj();
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
//删除与表:[zx_UserRelaPosition]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_UserRelaPositionBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_UserRelaPositionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_UserRelaPositionENS">源对象</param>
 /// <param name = "objzx_UserRelaPositionENT">目标对象</param>
 public static void CopyTo(clszx_UserRelaPositionEN objzx_UserRelaPositionENS, clszx_UserRelaPositionEN objzx_UserRelaPositionENT)
{
try
{
objzx_UserRelaPositionENT.mId = objzx_UserRelaPositionENS.mId; //mId
objzx_UserRelaPositionENT.UserId = objzx_UserRelaPositionENS.UserId; //用户ID
objzx_UserRelaPositionENT.UpdUser = objzx_UserRelaPositionENS.UpdUser; //修改人
objzx_UserRelaPositionENT.UpdDate = objzx_UserRelaPositionENS.UpdDate; //修改日期
objzx_UserRelaPositionENT.IdCurrEduCls = objzx_UserRelaPositionENS.IdCurrEduCls; //教学班流水号
objzx_UserRelaPositionENT.OrderNum = objzx_UserRelaPositionENS.OrderNum; //序号
objzx_UserRelaPositionENT.XPosition = objzx_UserRelaPositionENS.XPosition; //X_坐标
objzx_UserRelaPositionENT.YPosition = objzx_UserRelaPositionENS.YPosition; //Y_坐标
objzx_UserRelaPositionENT.Memo = objzx_UserRelaPositionENS.Memo; //备注
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
 /// <param name = "objzx_UserRelaPositionEN">源简化对象</param>
 public static void SetUpdFlag(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
try
{
objzx_UserRelaPositionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_UserRelaPositionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_UserRelaPosition.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.mId = objzx_UserRelaPositionEN.mId; //mId
}
if (arrFldSet.Contains(conzx_UserRelaPosition.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.UserId = objzx_UserRelaPositionEN.UserId == "[null]" ? null :  objzx_UserRelaPositionEN.UserId; //用户ID
}
if (arrFldSet.Contains(conzx_UserRelaPosition.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.UpdUser = objzx_UserRelaPositionEN.UpdUser == "[null]" ? null :  objzx_UserRelaPositionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_UserRelaPosition.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.UpdDate = objzx_UserRelaPositionEN.UpdDate == "[null]" ? null :  objzx_UserRelaPositionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_UserRelaPosition.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.IdCurrEduCls = objzx_UserRelaPositionEN.IdCurrEduCls == "[null]" ? null :  objzx_UserRelaPositionEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_UserRelaPosition.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.OrderNum = objzx_UserRelaPositionEN.OrderNum; //序号
}
if (arrFldSet.Contains(conzx_UserRelaPosition.XPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.XPosition = objzx_UserRelaPositionEN.XPosition; //X_坐标
}
if (arrFldSet.Contains(conzx_UserRelaPosition.YPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.YPosition = objzx_UserRelaPositionEN.YPosition; //Y_坐标
}
if (arrFldSet.Contains(conzx_UserRelaPosition.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_UserRelaPositionEN.Memo = objzx_UserRelaPositionEN.Memo == "[null]" ? null :  objzx_UserRelaPositionEN.Memo; //备注
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
 /// <param name = "objzx_UserRelaPositionEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
try
{
if (objzx_UserRelaPositionEN.UserId == "[null]") objzx_UserRelaPositionEN.UserId = null; //用户ID
if (objzx_UserRelaPositionEN.UpdUser == "[null]") objzx_UserRelaPositionEN.UpdUser = null; //修改人
if (objzx_UserRelaPositionEN.UpdDate == "[null]") objzx_UserRelaPositionEN.UpdDate = null; //修改日期
if (objzx_UserRelaPositionEN.IdCurrEduCls == "[null]") objzx_UserRelaPositionEN.IdCurrEduCls = null; //教学班流水号
if (objzx_UserRelaPositionEN.Memo == "[null]") objzx_UserRelaPositionEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 zx_UserRelaPositionDA.CheckPropertyNew(objzx_UserRelaPositionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
 zx_UserRelaPositionDA.CheckProperty4Condition(objzx_UserRelaPositionEN);
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
if (clszx_UserRelaPositionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_UserRelaPositionBL没有刷新缓存机制(clszx_UserRelaPositionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrzx_UserRelaPositionObjLstCache == null)
//{
//arrzx_UserRelaPositionObjLstCache = zx_UserRelaPositionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_UserRelaPositionEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clszx_UserRelaPositionEN._CurrTabName, strIdCurrEduCls);
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLst_Sel =
arrzx_UserRelaPositionObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrzx_UserRelaPositionObjLst_Sel.Count() == 0)
{
   clszx_UserRelaPositionEN obj = clszx_UserRelaPositionBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_UserRelaPositionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetAllzx_UserRelaPositionObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_UserRelaPositionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_UserRelaPositionEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clszx_UserRelaPositionEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_UserRelaPositionObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clszx_UserRelaPositionEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_UserRelaPositionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_UserRelaPositionEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_UserRelaPositionBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_UserRelaPosition(中学用户关系坐标位置)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_UserRelaPositionEN objzx_UserRelaPositionEN)
{
//检测记录是否存在
string strResult = zx_UserRelaPositionDA.GetUniCondStr(objzx_UserRelaPositionEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != conzx_UserRelaPosition.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_UserRelaPosition.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_UserRelaPosition.AttributeName));
throw new Exception(strMsg);
}
var objzx_UserRelaPosition = clszx_UserRelaPositionBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objzx_UserRelaPosition == null) return "";
return objzx_UserRelaPosition[strOutFldName].ToString();
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
int intRecCount = clszx_UserRelaPositionDA.GetRecCount(strTabName);
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
int intRecCount = clszx_UserRelaPositionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_UserRelaPositionDA.GetRecCount();
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
int intRecCount = clszx_UserRelaPositionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_UserRelaPositionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_UserRelaPositionEN objzx_UserRelaPositionCond)
{
 string strIdCurrEduCls = objzx_UserRelaPositionCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_UserRelaPositionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_UserRelaPositionEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_UserRelaPositionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_UserRelaPosition.AttributeName)
{
if (objzx_UserRelaPositionCond.IsUpdated(strFldName) == false) continue;
if (objzx_UserRelaPositionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_UserRelaPositionCond[strFldName].ToString());
}
else
{
if (objzx_UserRelaPositionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_UserRelaPositionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_UserRelaPositionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_UserRelaPositionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_UserRelaPositionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_UserRelaPositionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_UserRelaPositionCond[strFldName]));
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
 List<string> arrList = clszx_UserRelaPositionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_UserRelaPositionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_UserRelaPositionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_UserRelaPositionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_UserRelaPositionDA.SetFldValue(clszx_UserRelaPositionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_UserRelaPositionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_UserRelaPositionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_UserRelaPositionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_UserRelaPositionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_UserRelaPosition] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**X_坐标*/ 
 strCreateTabCode.Append(" XPosition float Null, "); 
 // /**Y_坐标*/ 
 strCreateTabCode.Append(" YPosition float Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conzx_UserRelaPosition.OrderNum); 
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjList = new clszx_UserRelaPositionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_UserRelaPositionEN objzx_UserRelaPosition in arrzx_UserRelaPositionObjList)
{
objzx_UserRelaPosition.OrderNum = intIndex;
UpdateBySql2(objzx_UserRelaPosition);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clszx_UserRelaPositionEN objzx_UserRelaPosition = clszx_UserRelaPositionBL.GetObjBymId(lngmId);

intOrderNum = objzx_UserRelaPosition.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clszx_UserRelaPositionBL.GetRecCountByCond(clszx_UserRelaPositionEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conzx_UserRelaPosition.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clszx_UserRelaPositionBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clszx_UserRelaPositionBL.SetFldValue(clszx_UserRelaPositionEN._CurrTabName, conzx_UserRelaPosition.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conzx_UserRelaPosition.mId, lngmId));
clszx_UserRelaPositionBL.SetFldValue(clszx_UserRelaPositionEN._CurrTabName, conzx_UserRelaPosition.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conzx_UserRelaPosition.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
strCondition.AppendFormat(" {0} = {1}", conzx_UserRelaPosition.OrderNum, intOrderNum + 1);

lngNextmId = clszx_UserRelaPositionBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clszx_UserRelaPositionBL.SetFldValue(clszx_UserRelaPositionEN._CurrTabName, conzx_UserRelaPosition.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conzx_UserRelaPosition.mId, lngmId));
clszx_UserRelaPositionBL.SetFldValue(clszx_UserRelaPositionEN._CurrTabName, conzx_UserRelaPosition.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conzx_UserRelaPosition.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clszx_UserRelaPositionBL.ReFreshCache(objzx_UserRelaPosition.IdCurrEduCls);
if (clszx_UserRelaPositionBL.relatedActions != null)
{
clszx_UserRelaPositionBL.relatedActions.UpdRelaTabDate(objzx_UserRelaPosition.mId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conzx_UserRelaPosition.mId, strKeyList);
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionLst = GetObjLst(strCondition);
foreach (clszx_UserRelaPositionEN objzx_UserRelaPosition in arrzx_UserRelaPositionLst)
{
objzx_UserRelaPosition.OrderNum = objzx_UserRelaPosition.OrderNum + 10000;
UpdateBySql2(objzx_UserRelaPosition);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_UserRelaPosition.OrderNum); 
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjList = new clszx_UserRelaPositionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_UserRelaPositionEN objzx_UserRelaPosition in arrzx_UserRelaPositionObjList)
{
objzx_UserRelaPosition.OrderNum = intIndex;
UpdateBySql2(objzx_UserRelaPosition);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conzx_UserRelaPosition.mId, strKeyList);
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionLst = GetObjLst(strCondition);
foreach (clszx_UserRelaPositionEN objzx_UserRelaPosition in arrzx_UserRelaPositionLst)
{
objzx_UserRelaPosition.OrderNum = objzx_UserRelaPosition.OrderNum - 10000;
UpdateBySql2(objzx_UserRelaPosition);
}
strCondition = string.Format("1 = 1 order by {0} ", conzx_UserRelaPosition.OrderNum); 
List<clszx_UserRelaPositionEN> arrzx_UserRelaPositionObjList = new clszx_UserRelaPositionDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clszx_UserRelaPositionEN objzx_UserRelaPosition in arrzx_UserRelaPositionObjList)
{
objzx_UserRelaPosition.OrderNum = intIndex;
UpdateBySql2(objzx_UserRelaPosition);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 中学用户关系坐标位置(zx_UserRelaPosition)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_UserRelaPosition : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clszx_UserRelaPositionBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}