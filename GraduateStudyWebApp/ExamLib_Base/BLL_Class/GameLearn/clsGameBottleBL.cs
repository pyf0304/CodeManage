
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGameBottleBL
 表名:GameBottle(01120974)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsGameBottleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngBottleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGameBottleEN GetObj(this K_BottleId_GameBottle myKey)
{
clsGameBottleEN objGameBottleEN = clsGameBottleBL.GameBottleDA.GetObjByBottleId(myKey.Value);
return objGameBottleEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGameBottleEN objGameBottleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGameBottleEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsGameBottleBL.AddNewRecord)", objGameBottleEN.QuestionId,objGameBottleEN.UserId_Throw);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsGameBottleBL.GameBottleDA.AddNewRecordBySQL2(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
public static bool AddRecordEx(this clsGameBottleEN objGameBottleEN, bool bolIsNeedCheckUniqueness = true)
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
objGameBottleEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGameBottleEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}],用户ID(UserId_Throw)=[{1}])已经存在,不能重复!", objGameBottleEN.QuestionId, objGameBottleEN.UserId_Throw);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objGameBottleEN.AddNewRecord();
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGameBottleEN objGameBottleEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGameBottleEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsGameBottleBL.AddNewRecordWithReturnKey)", objGameBottleEN.QuestionId,objGameBottleEN.UserId_Throw);
throw new Exception(strMsg);
}
try
{
string strKey = clsGameBottleBL.GameBottleDA.AddNewRecordBySQL2WithReturnKey(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetBottleId(this clsGameBottleEN objGameBottleEN, long lngBottleId, string strComparisonOp="")
	{
objGameBottleEN.BottleId = lngBottleId; //瓶子Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.BottleId) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.BottleId, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.BottleId] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetQuestionId(this clsGameBottleEN objGameBottleEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conGameBottle.QuestionId);
objGameBottleEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.QuestionId) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.QuestionId, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.QuestionId] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetUserId_Throw(this clsGameBottleEN objGameBottleEN, string strUserId_Throw, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId_Throw, conGameBottle.UserId_Throw);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId_Throw, 18, conGameBottle.UserId_Throw);
}
objGameBottleEN.UserId_Throw = strUserId_Throw; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.UserId_Throw) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.UserId_Throw, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.UserId_Throw] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetThrowTime(this clsGameBottleEN objGameBottleEN, string strThrowTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThrowTime, conGameBottle.ThrowTime);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThrowTime, 20, conGameBottle.ThrowTime);
}
objGameBottleEN.ThrowTime = strThrowTime; //扔的时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.ThrowTime) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.ThrowTime, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.ThrowTime] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetUserId_PickUp(this clsGameBottleEN objGameBottleEN, string strUserId_PickUp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId_PickUp, 18, conGameBottle.UserId_PickUp);
}
objGameBottleEN.UserId_PickUp = strUserId_PickUp; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.UserId_PickUp) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.UserId_PickUp, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.UserId_PickUp] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetPickUpTime(this clsGameBottleEN objGameBottleEN, string strPickUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPickUpTime, 20, conGameBottle.PickUpTime);
}
objGameBottleEN.PickUpTime = strPickUpTime; //捞的时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.PickUpTime) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.PickUpTime, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.PickUpTime] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetFinishedTime(this clsGameBottleEN objGameBottleEN, string strFinishedTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFinishedTime, 20, conGameBottle.FinishedTime);
}
objGameBottleEN.FinishedTime = strFinishedTime; //完成时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.FinishedTime) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.FinishedTime, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.FinishedTime] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetPosTop(this clsGameBottleEN objGameBottleEN, int? intPosTop, string strComparisonOp="")
	{
objGameBottleEN.PosTop = intPosTop; //位置Y
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.PosTop) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.PosTop, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.PosTop] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetPosLeft(this clsGameBottleEN objGameBottleEN, int? intPosLeft, string strComparisonOp="")
	{
objGameBottleEN.PosLeft = intPosLeft; //位置X
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.PosLeft) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.PosLeft, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.PosLeft] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetBottleStateId(this clsGameBottleEN objGameBottleEN, string strBottleStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBottleStateId, conGameBottle.BottleStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBottleStateId, 2, conGameBottle.BottleStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBottleStateId, 2, conGameBottle.BottleStateId);
}
objGameBottleEN.BottleStateId = strBottleStateId; //操作方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.BottleStateId) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.BottleStateId, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.BottleStateId] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetUpdUser(this clsGameBottleEN objGameBottleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conGameBottle.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGameBottle.UpdUser);
}
objGameBottleEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.UpdUser) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.UpdUser, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.UpdUser] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetUpdDate(this clsGameBottleEN objGameBottleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conGameBottle.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGameBottle.UpdDate);
}
objGameBottleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.UpdDate) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.UpdDate, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.UpdDate] = strComparisonOp;
}
}
return objGameBottleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGameBottleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGameBottleEN SetMemo(this clsGameBottleEN objGameBottleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMemo, conGameBottle.Memo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGameBottle.Memo);
}
objGameBottleEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGameBottleEN.dicFldComparisonOp.ContainsKey(conGameBottle.Memo) == false)
{
objGameBottleEN.dicFldComparisonOp.Add(conGameBottle.Memo, strComparisonOp);
}
else
{
objGameBottleEN.dicFldComparisonOp[conGameBottle.Memo] = strComparisonOp;
}
}
return objGameBottleEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGameBottleEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGameBottleEN objGameBottleEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGameBottleEN.CheckPropertyNew();
clsGameBottleEN objGameBottleCond = new clsGameBottleEN();
string strCondition = objGameBottleCond
.SetBottleId(objGameBottleEN.BottleId, "<>")
.SetQuestionId(objGameBottleEN.QuestionId, "=")
.SetUserId_Throw(objGameBottleEN.UserId_Throw, "=")
.GetCombineCondition();
objGameBottleEN._IsCheckProperty = true;
bool bolIsExist = clsGameBottleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGameBottleEN.Update();
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
 /// <param name = "objGameBottle">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGameBottleEN objGameBottle)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGameBottleEN objGameBottleCond = new clsGameBottleEN();
string strCondition = objGameBottleCond
.SetQuestionId(objGameBottle.QuestionId, "=")
.SetUserId_Throw(objGameBottle.UserId_Throw, "=")
.GetCombineCondition();
objGameBottle._IsCheckProperty = true;
bool bolIsExist = clsGameBottleBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGameBottle.BottleId = clsGameBottleBL.GetFirstID_S(strCondition);
objGameBottle.UpdateWithCondition(strCondition);
}
else
{
objGameBottle.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGameBottleEN objGameBottleEN)
{
 if (objGameBottleEN.BottleId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGameBottleBL.GameBottleDA.UpdateBySql2(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGameBottleEN objGameBottleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGameBottleEN.BottleId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGameBottleBL.GameBottleDA.UpdateBySql2(objGameBottleEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGameBottleEN objGameBottleEN, string strWhereCond)
{
try
{
bool bolResult = clsGameBottleBL.GameBottleDA.UpdateBySqlWithCondition(objGameBottleEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGameBottleEN objGameBottleEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGameBottleBL.GameBottleDA.UpdateBySqlWithConditionTransaction(objGameBottleEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGameBottleEN objGameBottleEN)
{
try
{
int intRecNum = clsGameBottleBL.GameBottleDA.DelRecord(objGameBottleEN.BottleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleENS">源对象</param>
 /// <param name = "objGameBottleENT">目标对象</param>
 public static void CopyTo(this clsGameBottleEN objGameBottleENS, clsGameBottleEN objGameBottleENT)
{
try
{
objGameBottleENT.BottleId = objGameBottleENS.BottleId; //瓶子Id
objGameBottleENT.QuestionId = objGameBottleENS.QuestionId; //题目Id
objGameBottleENT.UserId_Throw = objGameBottleENS.UserId_Throw; //用户ID
objGameBottleENT.ThrowTime = objGameBottleENS.ThrowTime; //扔的时间
objGameBottleENT.UserId_PickUp = objGameBottleENS.UserId_PickUp; //用户ID
objGameBottleENT.PickUpTime = objGameBottleENS.PickUpTime; //捞的时间
objGameBottleENT.FinishedTime = objGameBottleENS.FinishedTime; //完成时间
objGameBottleENT.PosTop = objGameBottleENS.PosTop; //位置Y
objGameBottleENT.PosLeft = objGameBottleENS.PosLeft; //位置X
objGameBottleENT.BottleStateId = objGameBottleENS.BottleStateId; //操作方式Id
objGameBottleENT.UpdUser = objGameBottleENS.UpdUser; //修改人
objGameBottleENT.UpdDate = objGameBottleENS.UpdDate; //修改日期
objGameBottleENT.Memo = objGameBottleENS.Memo; //备注
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
 /// <param name = "objGameBottleENS">源对象</param>
 /// <returns>目标对象=>clsGameBottleEN:objGameBottleENT</returns>
 public static clsGameBottleEN CopyTo(this clsGameBottleEN objGameBottleENS)
{
try
{
 clsGameBottleEN objGameBottleENT = new clsGameBottleEN()
{
BottleId = objGameBottleENS.BottleId, //瓶子Id
QuestionId = objGameBottleENS.QuestionId, //题目Id
UserId_Throw = objGameBottleENS.UserId_Throw, //用户ID
ThrowTime = objGameBottleENS.ThrowTime, //扔的时间
UserId_PickUp = objGameBottleENS.UserId_PickUp, //用户ID
PickUpTime = objGameBottleENS.PickUpTime, //捞的时间
FinishedTime = objGameBottleENS.FinishedTime, //完成时间
PosTop = objGameBottleENS.PosTop, //位置Y
PosLeft = objGameBottleENS.PosLeft, //位置X
BottleStateId = objGameBottleENS.BottleStateId, //操作方式Id
UpdUser = objGameBottleENS.UpdUser, //修改人
UpdDate = objGameBottleENS.UpdDate, //修改日期
Memo = objGameBottleENS.Memo, //备注
};
 return objGameBottleENT;
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
public static void CheckPropertyNew(this clsGameBottleEN objGameBottleEN)
{
 clsGameBottleBL.GameBottleDA.CheckPropertyNew(objGameBottleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGameBottleEN objGameBottleEN)
{
 clsGameBottleBL.GameBottleDA.CheckProperty4Condition(objGameBottleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGameBottleEN objGameBottleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGameBottleCond.IsUpdated(conGameBottle.BottleId) == true)
{
string strComparisonOpBottleId = objGameBottleCond.dicFldComparisonOp[conGameBottle.BottleId];
strWhereCond += string.Format(" And {0} {2} {1}", conGameBottle.BottleId, objGameBottleCond.BottleId, strComparisonOpBottleId);
}
if (objGameBottleCond.IsUpdated(conGameBottle.QuestionId) == true)
{
string strComparisonOpQuestionId = objGameBottleCond.dicFldComparisonOp[conGameBottle.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conGameBottle.QuestionId, objGameBottleCond.QuestionId, strComparisonOpQuestionId);
}
if (objGameBottleCond.IsUpdated(conGameBottle.UserId_Throw) == true)
{
string strComparisonOpUserId_Throw = objGameBottleCond.dicFldComparisonOp[conGameBottle.UserId_Throw];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.UserId_Throw, objGameBottleCond.UserId_Throw, strComparisonOpUserId_Throw);
}
if (objGameBottleCond.IsUpdated(conGameBottle.ThrowTime) == true)
{
string strComparisonOpThrowTime = objGameBottleCond.dicFldComparisonOp[conGameBottle.ThrowTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.ThrowTime, objGameBottleCond.ThrowTime, strComparisonOpThrowTime);
}
if (objGameBottleCond.IsUpdated(conGameBottle.UserId_PickUp) == true)
{
string strComparisonOpUserId_PickUp = objGameBottleCond.dicFldComparisonOp[conGameBottle.UserId_PickUp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.UserId_PickUp, objGameBottleCond.UserId_PickUp, strComparisonOpUserId_PickUp);
}
if (objGameBottleCond.IsUpdated(conGameBottle.PickUpTime) == true)
{
string strComparisonOpPickUpTime = objGameBottleCond.dicFldComparisonOp[conGameBottle.PickUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.PickUpTime, objGameBottleCond.PickUpTime, strComparisonOpPickUpTime);
}
if (objGameBottleCond.IsUpdated(conGameBottle.FinishedTime) == true)
{
string strComparisonOpFinishedTime = objGameBottleCond.dicFldComparisonOp[conGameBottle.FinishedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.FinishedTime, objGameBottleCond.FinishedTime, strComparisonOpFinishedTime);
}
if (objGameBottleCond.IsUpdated(conGameBottle.PosTop) == true)
{
string strComparisonOpPosTop = objGameBottleCond.dicFldComparisonOp[conGameBottle.PosTop];
strWhereCond += string.Format(" And {0} {2} {1}", conGameBottle.PosTop, objGameBottleCond.PosTop, strComparisonOpPosTop);
}
if (objGameBottleCond.IsUpdated(conGameBottle.PosLeft) == true)
{
string strComparisonOpPosLeft = objGameBottleCond.dicFldComparisonOp[conGameBottle.PosLeft];
strWhereCond += string.Format(" And {0} {2} {1}", conGameBottle.PosLeft, objGameBottleCond.PosLeft, strComparisonOpPosLeft);
}
if (objGameBottleCond.IsUpdated(conGameBottle.BottleStateId) == true)
{
string strComparisonOpBottleStateId = objGameBottleCond.dicFldComparisonOp[conGameBottle.BottleStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.BottleStateId, objGameBottleCond.BottleStateId, strComparisonOpBottleStateId);
}
if (objGameBottleCond.IsUpdated(conGameBottle.UpdUser) == true)
{
string strComparisonOpUpdUser = objGameBottleCond.dicFldComparisonOp[conGameBottle.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.UpdUser, objGameBottleCond.UpdUser, strComparisonOpUpdUser);
}
if (objGameBottleCond.IsUpdated(conGameBottle.UpdDate) == true)
{
string strComparisonOpUpdDate = objGameBottleCond.dicFldComparisonOp[conGameBottle.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.UpdDate, objGameBottleCond.UpdDate, strComparisonOpUpdDate);
}
if (objGameBottleCond.IsUpdated(conGameBottle.Memo) == true)
{
string strComparisonOpMemo = objGameBottleCond.dicFldComparisonOp[conGameBottle.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGameBottle.Memo, objGameBottleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GameBottle(游戏瓶), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionId_UserId_Throw
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGameBottleEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGameBottleEN objGameBottleEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGameBottleEN == null) return true;
if (objGameBottleEN.BottleId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objGameBottleEN.QuestionId);
 sbCondition.AppendFormat(" and UserId_Throw = '{0}'", objGameBottleEN.UserId_Throw);
if (clsGameBottleBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("BottleId !=  {0}", objGameBottleEN.BottleId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objGameBottleEN.QuestionId);
 sbCondition.AppendFormat(" and UserId_Throw = '{0}'", objGameBottleEN.UserId_Throw);
if (clsGameBottleBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GameBottle(游戏瓶), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionId_UserId_Throw
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGameBottleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGameBottleEN objGameBottleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGameBottleEN == null) return "";
if (objGameBottleEN.BottleId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objGameBottleEN.QuestionId);
 sbCondition.AppendFormat(" and UserId_Throw = '{0}'", objGameBottleEN.UserId_Throw);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("BottleId !=  {0}", objGameBottleEN.BottleId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objGameBottleEN.QuestionId);
 sbCondition.AppendFormat(" and UserId_Throw = '{0}'", objGameBottleEN.UserId_Throw);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GameBottle
{
public virtual bool UpdRelaTabDate(long lngBottleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 游戏瓶(GameBottle)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGameBottleBL
{
public static RelatedActions_GameBottle relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGameBottleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGameBottleDA GameBottleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGameBottleDA();
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
 public clsGameBottleBL()
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
if (string.IsNullOrEmpty(clsGameBottleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGameBottleEN._ConnectString);
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
public static DataTable GetDataTable_GameBottle(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GameBottleDA.GetDataTable_GameBottle(strWhereCond);
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
objDT = GameBottleDA.GetDataTable(strWhereCond);
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
objDT = GameBottleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GameBottleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GameBottleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GameBottleDA.GetDataTable_Top(objTopPara);
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
objDT = GameBottleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GameBottleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GameBottleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrBottleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGameBottleEN> GetObjLstByBottleIdLst(List<long> arrBottleIdLst)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrBottleIdLst);
 string strWhereCond = string.Format("BottleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrBottleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGameBottleEN> GetObjLstByBottleIdLstCache(List<long> arrBottleIdLst)
{
string strKey = string.Format("{0}", clsGameBottleEN._CurrTabName);
List<clsGameBottleEN> arrGameBottleObjLstCache = GetObjLstCache();
IEnumerable <clsGameBottleEN> arrGameBottleObjLst_Sel =
arrGameBottleObjLstCache
.Where(x => arrBottleIdLst.Contains(x.BottleId));
return arrGameBottleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGameBottleEN> GetObjLst(string strWhereCond)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
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
public static List<clsGameBottleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGameBottleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGameBottleEN> GetSubObjLstCache(clsGameBottleEN objGameBottleCond)
{
List<clsGameBottleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGameBottleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGameBottle.AttributeName)
{
if (objGameBottleCond.IsUpdated(strFldName) == false) continue;
if (objGameBottleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGameBottleCond[strFldName].ToString());
}
else
{
if (objGameBottleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGameBottleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGameBottleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGameBottleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGameBottleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGameBottleCond[strFldName]));
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
public static List<clsGameBottleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
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
public static List<clsGameBottleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
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
List<clsGameBottleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGameBottleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGameBottleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGameBottleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
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
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
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
public static List<clsGameBottleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGameBottleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGameBottleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
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
public static List<clsGameBottleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGameBottleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGameBottleEN> arrObjLst = new List<clsGameBottleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGameBottleEN objGameBottleEN = new clsGameBottleEN();
try
{
objGameBottleEN.BottleId = Int32.Parse(objRow[conGameBottle.BottleId].ToString().Trim()); //瓶子Id
objGameBottleEN.QuestionId = Int32.Parse(objRow[conGameBottle.QuestionId].ToString().Trim()); //题目Id
objGameBottleEN.UserId_Throw = objRow[conGameBottle.UserId_Throw].ToString().Trim(); //用户ID
objGameBottleEN.ThrowTime = objRow[conGameBottle.ThrowTime].ToString().Trim(); //扔的时间
objGameBottleEN.UserId_PickUp = objRow[conGameBottle.UserId_PickUp] == DBNull.Value ? null : objRow[conGameBottle.UserId_PickUp].ToString().Trim(); //用户ID
objGameBottleEN.PickUpTime = objRow[conGameBottle.PickUpTime] == DBNull.Value ? null : objRow[conGameBottle.PickUpTime].ToString().Trim(); //捞的时间
objGameBottleEN.FinishedTime = objRow[conGameBottle.FinishedTime] == DBNull.Value ? null : objRow[conGameBottle.FinishedTime].ToString().Trim(); //完成时间
objGameBottleEN.PosTop = objRow[conGameBottle.PosTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosTop].ToString().Trim()); //位置Y
objGameBottleEN.PosLeft = objRow[conGameBottle.PosLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGameBottle.PosLeft].ToString().Trim()); //位置X
objGameBottleEN.BottleStateId = objRow[conGameBottle.BottleStateId].ToString().Trim(); //操作方式Id
objGameBottleEN.UpdUser = objRow[conGameBottle.UpdUser].ToString().Trim(); //修改人
objGameBottleEN.UpdDate = objRow[conGameBottle.UpdDate].ToString().Trim(); //修改日期
objGameBottleEN.Memo = objRow[conGameBottle.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGameBottleEN.BottleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGameBottleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGameBottleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGameBottle(ref clsGameBottleEN objGameBottleEN)
{
bool bolResult = GameBottleDA.GetGameBottle(ref objGameBottleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngBottleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGameBottleEN GetObjByBottleId(long lngBottleId)
{
clsGameBottleEN objGameBottleEN = GameBottleDA.GetObjByBottleId(lngBottleId);
return objGameBottleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGameBottleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGameBottleEN objGameBottleEN = GameBottleDA.GetFirstObj(strWhereCond);
 return objGameBottleEN;
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
public static clsGameBottleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGameBottleEN objGameBottleEN = GameBottleDA.GetObjByDataRow(objRow);
 return objGameBottleEN;
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
public static clsGameBottleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGameBottleEN objGameBottleEN = GameBottleDA.GetObjByDataRow(objRow);
 return objGameBottleEN;
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
 /// <param name = "lngBottleId">所给的关键字</param>
 /// <param name = "lstGameBottleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGameBottleEN GetObjByBottleIdFromList(long lngBottleId, List<clsGameBottleEN> lstGameBottleObjLst)
{
foreach (clsGameBottleEN objGameBottleEN in lstGameBottleObjLst)
{
if (objGameBottleEN.BottleId == lngBottleId)
{
return objGameBottleEN;
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
 long lngBottleId;
 try
 {
 lngBottleId = new clsGameBottleDA().GetFirstID(strWhereCond);
 return lngBottleId;
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
 arrList = GameBottleDA.GetID(strWhereCond);
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
bool bolIsExist = GameBottleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngBottleId)
{
//检测记录是否存在
bool bolIsExist = GameBottleDA.IsExist(lngBottleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngBottleId">瓶子Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngBottleId, string strOpUser)
{
clsGameBottleEN objGameBottleEN = clsGameBottleBL.GetObjByBottleId(lngBottleId);
objGameBottleEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGameBottleEN.UpdUser = strOpUser;
return clsGameBottleBL.UpdateBySql2(objGameBottleEN);
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
 bolIsExist = clsGameBottleDA.IsExistTable();
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
 bolIsExist = GameBottleDA.IsExistTable(strTabName);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGameBottleEN objGameBottleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGameBottleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsGameBottleBL.AddNewRecordBySql2)", objGameBottleEN.QuestionId,objGameBottleEN.UserId_Throw);
throw new Exception(strMsg);
}
try
{
bool bolResult = GameBottleDA.AddNewRecordBySQL2(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGameBottleEN objGameBottleEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGameBottleEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsGameBottleBL.AddNewRecordBySql2WithReturnKey)", objGameBottleEN.QuestionId,objGameBottleEN.UserId_Throw);
throw new Exception(strMsg);
}
try
{
string strKey = GameBottleDA.AddNewRecordBySQL2WithReturnKey(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGameBottleEN objGameBottleEN)
{
try
{
bool bolResult = GameBottleDA.Update(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "objGameBottleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGameBottleEN objGameBottleEN)
{
 if (objGameBottleEN.BottleId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GameBottleDA.UpdateBySql2(objGameBottleEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGameBottleBL.ReFreshCache();

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
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
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngBottleId)
{
try
{
 clsGameBottleEN objGameBottleEN = clsGameBottleBL.GetObjByBottleId(lngBottleId);

if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(objGameBottleEN.BottleId, objGameBottleEN.UpdUser);
}
if (objGameBottleEN != null)
{
int intRecNum = GameBottleDA.DelRecord(lngBottleId);
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
/// <param name="lngBottleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngBottleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGameBottleDA.GetSpecSQLObj();
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
//删除与表:[GameBottle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGameBottle.BottleId,
//lngBottleId);
//        clsGameBottleBL.DelGameBottlesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGameBottleBL.DelRecord(lngBottleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGameBottleBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngBottleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngBottleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngBottleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGameBottleBL.relatedActions != null)
{
clsGameBottleBL.relatedActions.UpdRelaTabDate(lngBottleId, "UpdRelaTabDate");
}
bool bolResult = GameBottleDA.DelRecord(lngBottleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrBottleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGameBottles(List<string> arrBottleIdLst)
{
if (arrBottleIdLst.Count == 0) return 0;
try
{
if (clsGameBottleBL.relatedActions != null)
{
foreach (var strBottleId in arrBottleIdLst)
{
long lngBottleId = long.Parse(strBottleId);
clsGameBottleBL.relatedActions.UpdRelaTabDate(lngBottleId, "UpdRelaTabDate");
}
}
int intDelRecNum = GameBottleDA.DelGameBottle(arrBottleIdLst);
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
public static int DelGameBottlesByCond(string strWhereCond)
{
try
{
if (clsGameBottleBL.relatedActions != null)
{
List<string> arrBottleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strBottleId in arrBottleId)
{
long lngBottleId = long.Parse(strBottleId);
clsGameBottleBL.relatedActions.UpdRelaTabDate(lngBottleId, "UpdRelaTabDate");
}
}
int intRecNum = GameBottleDA.DelGameBottle(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GameBottle]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngBottleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngBottleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGameBottleDA.GetSpecSQLObj();
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
//删除与表:[GameBottle]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGameBottleBL.DelRecord(lngBottleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGameBottleBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngBottleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGameBottleENS">源对象</param>
 /// <param name = "objGameBottleENT">目标对象</param>
 public static void CopyTo(clsGameBottleEN objGameBottleENS, clsGameBottleEN objGameBottleENT)
{
try
{
objGameBottleENT.BottleId = objGameBottleENS.BottleId; //瓶子Id
objGameBottleENT.QuestionId = objGameBottleENS.QuestionId; //题目Id
objGameBottleENT.UserId_Throw = objGameBottleENS.UserId_Throw; //用户ID
objGameBottleENT.ThrowTime = objGameBottleENS.ThrowTime; //扔的时间
objGameBottleENT.UserId_PickUp = objGameBottleENS.UserId_PickUp; //用户ID
objGameBottleENT.PickUpTime = objGameBottleENS.PickUpTime; //捞的时间
objGameBottleENT.FinishedTime = objGameBottleENS.FinishedTime; //完成时间
objGameBottleENT.PosTop = objGameBottleENS.PosTop; //位置Y
objGameBottleENT.PosLeft = objGameBottleENS.PosLeft; //位置X
objGameBottleENT.BottleStateId = objGameBottleENS.BottleStateId; //操作方式Id
objGameBottleENT.UpdUser = objGameBottleENS.UpdUser; //修改人
objGameBottleENT.UpdDate = objGameBottleENS.UpdDate; //修改日期
objGameBottleENT.Memo = objGameBottleENS.Memo; //备注
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
 /// <param name = "objGameBottleEN">源简化对象</param>
 public static void SetUpdFlag(clsGameBottleEN objGameBottleEN)
{
try
{
objGameBottleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGameBottleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGameBottle.BottleId, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.BottleId = objGameBottleEN.BottleId; //瓶子Id
}
if (arrFldSet.Contains(conGameBottle.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.QuestionId = objGameBottleEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conGameBottle.UserId_Throw, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.UserId_Throw = objGameBottleEN.UserId_Throw; //用户ID
}
if (arrFldSet.Contains(conGameBottle.ThrowTime, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.ThrowTime = objGameBottleEN.ThrowTime; //扔的时间
}
if (arrFldSet.Contains(conGameBottle.UserId_PickUp, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.UserId_PickUp = objGameBottleEN.UserId_PickUp == "[null]" ? null :  objGameBottleEN.UserId_PickUp; //用户ID
}
if (arrFldSet.Contains(conGameBottle.PickUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.PickUpTime = objGameBottleEN.PickUpTime == "[null]" ? null :  objGameBottleEN.PickUpTime; //捞的时间
}
if (arrFldSet.Contains(conGameBottle.FinishedTime, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.FinishedTime = objGameBottleEN.FinishedTime == "[null]" ? null :  objGameBottleEN.FinishedTime; //完成时间
}
if (arrFldSet.Contains(conGameBottle.PosTop, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.PosTop = objGameBottleEN.PosTop; //位置Y
}
if (arrFldSet.Contains(conGameBottle.PosLeft, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.PosLeft = objGameBottleEN.PosLeft; //位置X
}
if (arrFldSet.Contains(conGameBottle.BottleStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.BottleStateId = objGameBottleEN.BottleStateId; //操作方式Id
}
if (arrFldSet.Contains(conGameBottle.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.UpdUser = objGameBottleEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conGameBottle.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.UpdDate = objGameBottleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGameBottle.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGameBottleEN.Memo = objGameBottleEN.Memo; //备注
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
 /// <param name = "objGameBottleEN">源简化对象</param>
 public static void AccessFldValueNull(clsGameBottleEN objGameBottleEN)
{
try
{
if (objGameBottleEN.UserId_PickUp == "[null]") objGameBottleEN.UserId_PickUp = null; //用户ID
if (objGameBottleEN.PickUpTime == "[null]") objGameBottleEN.PickUpTime = null; //捞的时间
if (objGameBottleEN.FinishedTime == "[null]") objGameBottleEN.FinishedTime = null; //完成时间
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
public static void CheckPropertyNew(clsGameBottleEN objGameBottleEN)
{
 GameBottleDA.CheckPropertyNew(objGameBottleEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGameBottleEN objGameBottleEN)
{
 GameBottleDA.CheckProperty4Condition(objGameBottleEN);
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
if (clsGameBottleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGameBottleBL没有刷新缓存机制(clsGameBottleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by BottleId");
//if (arrGameBottleObjLstCache == null)
//{
//arrGameBottleObjLstCache = GameBottleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngBottleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGameBottleEN GetObjByBottleIdCache(long lngBottleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGameBottleEN._CurrTabName);
List<clsGameBottleEN> arrGameBottleObjLstCache = GetObjLstCache();
IEnumerable <clsGameBottleEN> arrGameBottleObjLst_Sel =
arrGameBottleObjLstCache
.Where(x=> x.BottleId == lngBottleId 
);
if (arrGameBottleObjLst_Sel.Count() == 0)
{
   clsGameBottleEN obj = clsGameBottleBL.GetObjByBottleId(lngBottleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGameBottleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGameBottleEN> GetAllGameBottleObjLstCache()
{
//获取缓存中的对象列表
List<clsGameBottleEN> arrGameBottleObjLstCache = GetObjLstCache(); 
return arrGameBottleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGameBottleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGameBottleEN._CurrTabName);
List<clsGameBottleEN> arrGameBottleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGameBottleObjLstCache;
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
string strKey = string.Format("{0}", clsGameBottleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGameBottleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGameBottleEN._RefreshTimeLst.Count == 0) return "";
return clsGameBottleEN._RefreshTimeLst[clsGameBottleEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsGameBottleBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGameBottleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGameBottleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGameBottleBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GameBottle(游戏瓶)
 /// 唯一性条件:QuestionId_UserId_Throw
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGameBottleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGameBottleEN objGameBottleEN)
{
//检测记录是否存在
string strResult = GameBottleDA.GetUniCondStr(objGameBottleEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngBottleId)
{
if (strInFldName != conGameBottle.BottleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGameBottle.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGameBottle.AttributeName));
throw new Exception(strMsg);
}
var objGameBottle = clsGameBottleBL.GetObjByBottleIdCache(lngBottleId);
if (objGameBottle == null) return "";
return objGameBottle[strOutFldName].ToString();
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
int intRecCount = clsGameBottleDA.GetRecCount(strTabName);
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
int intRecCount = clsGameBottleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGameBottleDA.GetRecCount();
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
int intRecCount = clsGameBottleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGameBottleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGameBottleEN objGameBottleCond)
{
List<clsGameBottleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGameBottleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGameBottle.AttributeName)
{
if (objGameBottleCond.IsUpdated(strFldName) == false) continue;
if (objGameBottleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGameBottleCond[strFldName].ToString());
}
else
{
if (objGameBottleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGameBottleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGameBottleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGameBottleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGameBottleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGameBottleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGameBottleCond[strFldName]));
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
 List<string> arrList = clsGameBottleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GameBottleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GameBottleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GameBottleDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGameBottleDA.SetFldValue(clsGameBottleEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GameBottleDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGameBottleDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGameBottleDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGameBottleDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GameBottle] "); 
 strCreateTabCode.Append(" ( "); 
 // /**瓶子Id*/ 
 strCreateTabCode.Append(" BottleId bigint primary key identity, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId_Throw varchar(18) not Null, "); 
 // /**扔的时间*/ 
 strCreateTabCode.Append(" ThrowTime varchar(20) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId_PickUp varchar(18) Null, "); 
 // /**捞的时间*/ 
 strCreateTabCode.Append(" PickUpTime varchar(20) Null, "); 
 // /**完成时间*/ 
 strCreateTabCode.Append(" FinishedTime varchar(20) Null, "); 
 // /**位置Y*/ 
 strCreateTabCode.Append(" PosTop int Null, "); 
 // /**位置X*/ 
 strCreateTabCode.Append(" PosLeft int Null, "); 
 // /**操作方式Id*/ 
 strCreateTabCode.Append(" BottleStateId char(2) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) not Null, "); 
 // /**题目类型名*/ 
 strCreateTabCode.Append(" QuestionTypeName varchar(20) Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) Null, "); 
 // /**用户名_扔*/ 
 strCreateTabCode.Append(" UserName_Throw varchar(30) Null, "); 
 // /**用户名_捞*/ 
 strCreateTabCode.Append(" UserName_PickUp varchar(30) Null, "); 
 // /**难度等级名称*/ 
 strCreateTabCode.Append(" DifficultyLevelName varchar(1000) Null, "); 
 // /**知识点名s*/ 
 strCreateTabCode.Append(" KnowledgeNames varchar(20) Null, "); 
 // /**知识点Ids*/ 
 strCreateTabCode.Append(" CourseKnowledgeIds varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 游戏瓶(GameBottle)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GameBottle : clsCommFun4BL
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
clsGameBottleBL.ReFreshThisCache();
}
}

}