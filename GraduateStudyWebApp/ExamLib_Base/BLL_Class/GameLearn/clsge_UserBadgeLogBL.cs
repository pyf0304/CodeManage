
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_UserBadgeLogBL
 表名:ge_UserBadgeLog(01120881)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:47
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
public static class  clsge_UserBadgeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_UserBadgeLogEN GetObj(this K_mId_ge_UserBadgeLog myKey)
{
clsge_UserBadgeLogEN objge_UserBadgeLogEN = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.GetObjBymId(myKey.Value);
return objge_UserBadgeLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_UserBadgeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],用户ID = [{1}],徽章类型Id = [{2}],游戏关卡Id = [{3}],获取日期 = [{4}]的数据已经存在!(in clsge_UserBadgeLogBL.AddNewRecord)", objge_UserBadgeLogEN.IdCurrEduCls,objge_UserBadgeLogEN.UserId,objge_UserBadgeLogEN.BadgeTypeId,objge_UserBadgeLogEN.GameLevelId,objge_UserBadgeLogEN.GetDate);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.AddNewRecordBySQL2(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, bool bolIsNeedCheckUniqueness = true)
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
objge_UserBadgeLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_UserBadgeLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],用户ID(UserId)=[{1}],徽章类型Id(BadgeTypeId)=[{2}],游戏关卡Id(GameLevelId)=[{3}],获取日期(GetDate)=[{4}])已经存在,不能重复!", objge_UserBadgeLogEN.IdCurrEduCls, objge_UserBadgeLogEN.UserId, objge_UserBadgeLogEN.BadgeTypeId, objge_UserBadgeLogEN.GameLevelId, objge_UserBadgeLogEN.GetDate);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_UserBadgeLogEN.AddNewRecord();
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_UserBadgeLogEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],用户ID = [{1}],徽章类型Id = [{2}],游戏关卡Id = [{3}],获取日期 = [{4}]的数据已经存在!(in clsge_UserBadgeLogBL.AddNewRecordWithReturnKey)", objge_UserBadgeLogEN.IdCurrEduCls,objge_UserBadgeLogEN.UserId,objge_UserBadgeLogEN.BadgeTypeId,objge_UserBadgeLogEN.GameLevelId,objge_UserBadgeLogEN.GetDate);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.AddNewRecordBySQL2WithReturnKey(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetmId(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, long lngmId, string strComparisonOp="")
	{
objge_UserBadgeLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.mId) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.mId, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.mId] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetIdCurrEduCls(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conge_UserBadgeLog.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conge_UserBadgeLog.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conge_UserBadgeLog.IdCurrEduCls);
}
objge_UserBadgeLogEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.IdCurrEduCls) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.IdCurrEduCls, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.IdCurrEduCls] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetUserId(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conge_UserBadgeLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conge_UserBadgeLog.UserId);
}
objge_UserBadgeLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.UserId) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.UserId, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.UserId] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetBadgeTypeId(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strBadgeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBadgeTypeId, conge_UserBadgeLog.BadgeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBadgeTypeId, 2, conge_UserBadgeLog.BadgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBadgeTypeId, 2, conge_UserBadgeLog.BadgeTypeId);
}
objge_UserBadgeLogEN.BadgeTypeId = strBadgeTypeId; //徽章类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.BadgeTypeId) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.BadgeTypeId, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.BadgeTypeId] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetGameLevelId(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strGameLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGameLevelId, 8, conge_UserBadgeLog.GameLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGameLevelId, 8, conge_UserBadgeLog.GameLevelId);
}
objge_UserBadgeLogEN.GameLevelId = strGameLevelId; //游戏关卡Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.GameLevelId) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.GameLevelId, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.GameLevelId] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetGetInstructions(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strGetInstructions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetInstructions, 100, conge_UserBadgeLog.GetInstructions);
}
objge_UserBadgeLogEN.GetInstructions = strGetInstructions; //获取说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.GetInstructions) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.GetInstructions, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.GetInstructions] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetGetDate(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strGetDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetDate, 20, conge_UserBadgeLog.GetDate);
}
objge_UserBadgeLogEN.GetDate = strGetDate; //获取日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.GetDate) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.GetDate, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.GetDate] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetCourseChapterId(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conge_UserBadgeLog.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conge_UserBadgeLog.CourseChapterId);
}
objge_UserBadgeLogEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.CourseChapterId) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.CourseChapterId, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.CourseChapterId] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetUpdDate(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_UserBadgeLog.UpdDate);
}
objge_UserBadgeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.UpdDate) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.UpdDate, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.UpdDate] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetUpdUser(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_UserBadgeLog.UpdUser);
}
objge_UserBadgeLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.UpdUser) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.UpdUser, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.UpdUser] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_UserBadgeLogEN SetMemo(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_UserBadgeLog.Memo);
}
objge_UserBadgeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_UserBadgeLogEN.dicFldComparisonOp.ContainsKey(conge_UserBadgeLog.Memo) == false)
{
objge_UserBadgeLogEN.dicFldComparisonOp.Add(conge_UserBadgeLog.Memo, strComparisonOp);
}
else
{
objge_UserBadgeLogEN.dicFldComparisonOp[conge_UserBadgeLog.Memo] = strComparisonOp;
}
}
return objge_UserBadgeLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_UserBadgeLogEN.CheckPropertyNew();
clsge_UserBadgeLogEN objge_UserBadgeLogCond = new clsge_UserBadgeLogEN();
string strCondition = objge_UserBadgeLogCond
.SetmId(objge_UserBadgeLogEN.mId, "<>")
.SetIdCurrEduCls(objge_UserBadgeLogEN.IdCurrEduCls, "=")
.SetUserId(objge_UserBadgeLogEN.UserId, "=")
.SetBadgeTypeId(objge_UserBadgeLogEN.BadgeTypeId, "=")
.SetGameLevelId(objge_UserBadgeLogEN.GameLevelId, "=")
.SetGetDate(objge_UserBadgeLogEN.GetDate, "=")
.GetCombineCondition();
objge_UserBadgeLogEN._IsCheckProperty = true;
bool bolIsExist = clsge_UserBadgeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_UserId_BadgeTypeId_GameLevelId_GetDate)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_UserBadgeLogEN.Update();
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
 /// <param name = "objge_UserBadgeLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_UserBadgeLogEN objge_UserBadgeLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_UserBadgeLogEN objge_UserBadgeLogCond = new clsge_UserBadgeLogEN();
string strCondition = objge_UserBadgeLogCond
.SetIdCurrEduCls(objge_UserBadgeLog.IdCurrEduCls, "=")
.SetUserId(objge_UserBadgeLog.UserId, "=")
.SetBadgeTypeId(objge_UserBadgeLog.BadgeTypeId, "=")
.SetGameLevelId(objge_UserBadgeLog.GameLevelId, "=")
.SetGetDate(objge_UserBadgeLog.GetDate, "=")
.GetCombineCondition();
objge_UserBadgeLog._IsCheckProperty = true;
bool bolIsExist = clsge_UserBadgeLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_UserBadgeLog.mId = clsge_UserBadgeLogBL.GetFirstID_S(strCondition);
objge_UserBadgeLog.UpdateWithCondition(strCondition);
}
else
{
objge_UserBadgeLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 if (objge_UserBadgeLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.UpdateBySql2(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_UserBadgeLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.UpdateBySql2(objge_UserBadgeLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strWhereCond)
{
try
{
bool bolResult = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.UpdateBySqlWithCondition(objge_UserBadgeLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_UserBadgeLogEN objge_UserBadgeLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.UpdateBySqlWithConditionTransaction(objge_UserBadgeLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
public static int Delete(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
try
{
int intRecNum = clsge_UserBadgeLogBL.ge_UserBadgeLogDA.DelRecord(objge_UserBadgeLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogENS">源对象</param>
 /// <param name = "objge_UserBadgeLogENT">目标对象</param>
 public static void CopyTo(this clsge_UserBadgeLogEN objge_UserBadgeLogENS, clsge_UserBadgeLogEN objge_UserBadgeLogENT)
{
try
{
objge_UserBadgeLogENT.mId = objge_UserBadgeLogENS.mId; //mId
objge_UserBadgeLogENT.IdCurrEduCls = objge_UserBadgeLogENS.IdCurrEduCls; //教学班流水号
objge_UserBadgeLogENT.UserId = objge_UserBadgeLogENS.UserId; //用户ID
objge_UserBadgeLogENT.BadgeTypeId = objge_UserBadgeLogENS.BadgeTypeId; //徽章类型Id
objge_UserBadgeLogENT.GameLevelId = objge_UserBadgeLogENS.GameLevelId; //游戏关卡Id
objge_UserBadgeLogENT.GetInstructions = objge_UserBadgeLogENS.GetInstructions; //获取说明
objge_UserBadgeLogENT.GetDate = objge_UserBadgeLogENS.GetDate; //获取日期
objge_UserBadgeLogENT.CourseChapterId = objge_UserBadgeLogENS.CourseChapterId; //课程章节ID
objge_UserBadgeLogENT.UpdDate = objge_UserBadgeLogENS.UpdDate; //修改日期
objge_UserBadgeLogENT.UpdUser = objge_UserBadgeLogENS.UpdUser; //修改人
objge_UserBadgeLogENT.Memo = objge_UserBadgeLogENS.Memo; //备注
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
 /// <param name = "objge_UserBadgeLogENS">源对象</param>
 /// <returns>目标对象=>clsge_UserBadgeLogEN:objge_UserBadgeLogENT</returns>
 public static clsge_UserBadgeLogEN CopyTo(this clsge_UserBadgeLogEN objge_UserBadgeLogENS)
{
try
{
 clsge_UserBadgeLogEN objge_UserBadgeLogENT = new clsge_UserBadgeLogEN()
{
mId = objge_UserBadgeLogENS.mId, //mId
IdCurrEduCls = objge_UserBadgeLogENS.IdCurrEduCls, //教学班流水号
UserId = objge_UserBadgeLogENS.UserId, //用户ID
BadgeTypeId = objge_UserBadgeLogENS.BadgeTypeId, //徽章类型Id
GameLevelId = objge_UserBadgeLogENS.GameLevelId, //游戏关卡Id
GetInstructions = objge_UserBadgeLogENS.GetInstructions, //获取说明
GetDate = objge_UserBadgeLogENS.GetDate, //获取日期
CourseChapterId = objge_UserBadgeLogENS.CourseChapterId, //课程章节ID
UpdDate = objge_UserBadgeLogENS.UpdDate, //修改日期
UpdUser = objge_UserBadgeLogENS.UpdUser, //修改人
Memo = objge_UserBadgeLogENS.Memo, //备注
};
 return objge_UserBadgeLogENT;
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
public static void CheckPropertyNew(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 clsge_UserBadgeLogBL.ge_UserBadgeLogDA.CheckPropertyNew(objge_UserBadgeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 clsge_UserBadgeLogBL.ge_UserBadgeLogDA.CheckProperty4Condition(objge_UserBadgeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_UserBadgeLogEN objge_UserBadgeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.mId) == true)
{
string strComparisonOpmId = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_UserBadgeLog.mId, objge_UserBadgeLogCond.mId, strComparisonOpmId);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.IdCurrEduCls, objge_UserBadgeLogCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.UserId) == true)
{
string strComparisonOpUserId = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.UserId, objge_UserBadgeLogCond.UserId, strComparisonOpUserId);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.BadgeTypeId) == true)
{
string strComparisonOpBadgeTypeId = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.BadgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.BadgeTypeId, objge_UserBadgeLogCond.BadgeTypeId, strComparisonOpBadgeTypeId);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.GameLevelId) == true)
{
string strComparisonOpGameLevelId = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.GameLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.GameLevelId, objge_UserBadgeLogCond.GameLevelId, strComparisonOpGameLevelId);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.GetInstructions) == true)
{
string strComparisonOpGetInstructions = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.GetInstructions];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.GetInstructions, objge_UserBadgeLogCond.GetInstructions, strComparisonOpGetInstructions);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.GetDate) == true)
{
string strComparisonOpGetDate = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.GetDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.GetDate, objge_UserBadgeLogCond.GetDate, strComparisonOpGetDate);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.CourseChapterId, objge_UserBadgeLogCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.UpdDate, objge_UserBadgeLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.UpdUser, objge_UserBadgeLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_UserBadgeLogCond.IsUpdated(conge_UserBadgeLog.Memo) == true)
{
string strComparisonOpMemo = objge_UserBadgeLogCond.dicFldComparisonOp[conge_UserBadgeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_UserBadgeLog.Memo, objge_UserBadgeLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_UserBadgeLog(用户徽章日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_UserId_BadgeTypeId_GameLevelId_GetDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_UserBadgeLogEN == null) return true;
if (objge_UserBadgeLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objge_UserBadgeLogEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_UserBadgeLogEN.UserId);
 sbCondition.AppendFormat(" and BadgeTypeId = '{0}'", objge_UserBadgeLogEN.BadgeTypeId);
 if (objge_UserBadgeLogEN.GameLevelId == null)
{
 sbCondition.AppendFormat(" and GameLevelId is null", objge_UserBadgeLogEN.GameLevelId);
}
else
{
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_UserBadgeLogEN.GameLevelId);
}
 if (objge_UserBadgeLogEN.GetDate == null)
{
 sbCondition.AppendFormat(" and GetDate is null", objge_UserBadgeLogEN.GetDate);
}
else
{
 sbCondition.AppendFormat(" and GetDate = '{0}'", objge_UserBadgeLogEN.GetDate);
}
if (clsge_UserBadgeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_UserBadgeLogEN.mId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objge_UserBadgeLogEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_UserBadgeLogEN.UserId);
 sbCondition.AppendFormat(" and BadgeTypeId = '{0}'", objge_UserBadgeLogEN.BadgeTypeId);
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_UserBadgeLogEN.GameLevelId);
 sbCondition.AppendFormat(" and GetDate = '{0}'", objge_UserBadgeLogEN.GetDate);
if (clsge_UserBadgeLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_UserBadgeLog(用户徽章日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_UserId_BadgeTypeId_GameLevelId_GetDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_UserBadgeLogEN == null) return "";
if (objge_UserBadgeLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objge_UserBadgeLogEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_UserBadgeLogEN.UserId);
 sbCondition.AppendFormat(" and BadgeTypeId = '{0}'", objge_UserBadgeLogEN.BadgeTypeId);
 if (objge_UserBadgeLogEN.GameLevelId == null)
{
 sbCondition.AppendFormat(" and GameLevelId is null", objge_UserBadgeLogEN.GameLevelId);
}
else
{
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_UserBadgeLogEN.GameLevelId);
}
 if (objge_UserBadgeLogEN.GetDate == null)
{
 sbCondition.AppendFormat(" and GetDate is null", objge_UserBadgeLogEN.GetDate);
}
else
{
 sbCondition.AppendFormat(" and GetDate = '{0}'", objge_UserBadgeLogEN.GetDate);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_UserBadgeLogEN.mId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objge_UserBadgeLogEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_UserBadgeLogEN.UserId);
 sbCondition.AppendFormat(" and BadgeTypeId = '{0}'", objge_UserBadgeLogEN.BadgeTypeId);
 sbCondition.AppendFormat(" and GameLevelId = '{0}'", objge_UserBadgeLogEN.GameLevelId);
 sbCondition.AppendFormat(" and GetDate = '{0}'", objge_UserBadgeLogEN.GetDate);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_UserBadgeLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户徽章日志(ge_UserBadgeLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_UserBadgeLogBL
{
public static RelatedActions_ge_UserBadgeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_UserBadgeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_UserBadgeLogDA ge_UserBadgeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_UserBadgeLogDA();
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
 public clsge_UserBadgeLogBL()
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
if (string.IsNullOrEmpty(clsge_UserBadgeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_UserBadgeLogEN._ConnectString);
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
public static DataTable GetDataTable_ge_UserBadgeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_UserBadgeLogDA.GetDataTable_ge_UserBadgeLog(strWhereCond);
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
objDT = ge_UserBadgeLogDA.GetDataTable(strWhereCond);
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
objDT = ge_UserBadgeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_UserBadgeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_UserBadgeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_UserBadgeLogDA.GetDataTable_Top(objTopPara);
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
objDT = ge_UserBadgeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_UserBadgeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_UserBadgeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsge_UserBadgeLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
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
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_UserBadgeLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsge_UserBadgeLogEN._CurrTabName, strIdCurrEduCls);
List<clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLst_Sel =
arrge_UserBadgeLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrge_UserBadgeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetObjLst(string strWhereCond)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
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
public static List<clsge_UserBadgeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_UserBadgeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_UserBadgeLogEN> GetSubObjLstCache(clsge_UserBadgeLogEN objge_UserBadgeLogCond)
{
 string strIdCurrEduCls = objge_UserBadgeLogCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_UserBadgeLogBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_UserBadgeLogEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserBadgeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_UserBadgeLog.AttributeName)
{
if (objge_UserBadgeLogCond.IsUpdated(strFldName) == false) continue;
if (objge_UserBadgeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserBadgeLogCond[strFldName].ToString());
}
else
{
if (objge_UserBadgeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_UserBadgeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserBadgeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_UserBadgeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_UserBadgeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_UserBadgeLogCond[strFldName]));
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
public static List<clsge_UserBadgeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
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
public static List<clsge_UserBadgeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
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
List<clsge_UserBadgeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_UserBadgeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_UserBadgeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
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
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
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
public static List<clsge_UserBadgeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_UserBadgeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
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
public static List<clsge_UserBadgeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_UserBadgeLogEN> arrObjLst = new List<clsge_UserBadgeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_UserBadgeLogEN objge_UserBadgeLogEN = new clsge_UserBadgeLogEN();
try
{
objge_UserBadgeLogEN.mId = Int32.Parse(objRow[conge_UserBadgeLog.mId].ToString().Trim()); //mId
objge_UserBadgeLogEN.IdCurrEduCls = objRow[conge_UserBadgeLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_UserBadgeLogEN.UserId = objRow[conge_UserBadgeLog.UserId].ToString().Trim(); //用户ID
objge_UserBadgeLogEN.BadgeTypeId = objRow[conge_UserBadgeLog.BadgeTypeId].ToString().Trim(); //徽章类型Id
objge_UserBadgeLogEN.GameLevelId = objRow[conge_UserBadgeLog.GameLevelId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_UserBadgeLogEN.GetInstructions = objRow[conge_UserBadgeLog.GetInstructions] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetInstructions].ToString().Trim(); //获取说明
objge_UserBadgeLogEN.GetDate = objRow[conge_UserBadgeLog.GetDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.GetDate].ToString().Trim(); //获取日期
objge_UserBadgeLogEN.CourseChapterId = objRow[conge_UserBadgeLog.CourseChapterId] == DBNull.Value ? null : objRow[conge_UserBadgeLog.CourseChapterId].ToString().Trim(); //课程章节ID
objge_UserBadgeLogEN.UpdDate = objRow[conge_UserBadgeLog.UpdDate] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdDate].ToString().Trim(); //修改日期
objge_UserBadgeLogEN.UpdUser = objRow[conge_UserBadgeLog.UpdUser] == DBNull.Value ? null : objRow[conge_UserBadgeLog.UpdUser].ToString().Trim(); //修改人
objge_UserBadgeLogEN.Memo = objRow[conge_UserBadgeLog.Memo] == DBNull.Value ? null : objRow[conge_UserBadgeLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_UserBadgeLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_UserBadgeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_UserBadgeLog(ref clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
bool bolResult = ge_UserBadgeLogDA.Getge_UserBadgeLog(ref objge_UserBadgeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_UserBadgeLogEN GetObjBymId(long lngmId)
{
clsge_UserBadgeLogEN objge_UserBadgeLogEN = ge_UserBadgeLogDA.GetObjBymId(lngmId);
return objge_UserBadgeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_UserBadgeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_UserBadgeLogEN objge_UserBadgeLogEN = ge_UserBadgeLogDA.GetFirstObj(strWhereCond);
 return objge_UserBadgeLogEN;
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
public static clsge_UserBadgeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_UserBadgeLogEN objge_UserBadgeLogEN = ge_UserBadgeLogDA.GetObjByDataRow(objRow);
 return objge_UserBadgeLogEN;
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
public static clsge_UserBadgeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_UserBadgeLogEN objge_UserBadgeLogEN = ge_UserBadgeLogDA.GetObjByDataRow(objRow);
 return objge_UserBadgeLogEN;
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
 /// <param name = "lstge_UserBadgeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_UserBadgeLogEN GetObjBymIdFromList(long lngmId, List<clsge_UserBadgeLogEN> lstge_UserBadgeLogObjLst)
{
foreach (clsge_UserBadgeLogEN objge_UserBadgeLogEN in lstge_UserBadgeLogObjLst)
{
if (objge_UserBadgeLogEN.mId == lngmId)
{
return objge_UserBadgeLogEN;
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
 lngmId = new clsge_UserBadgeLogDA().GetFirstID(strWhereCond);
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
 arrList = ge_UserBadgeLogDA.GetID(strWhereCond);
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
bool bolIsExist = ge_UserBadgeLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ge_UserBadgeLogDA.IsExist(lngmId);
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
 bolIsExist = clsge_UserBadgeLogDA.IsExistTable();
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
 bolIsExist = ge_UserBadgeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_UserBadgeLogEN objge_UserBadgeLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_UserBadgeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],用户ID = [{1}],徽章类型Id = [{2}],游戏关卡Id = [{3}],获取日期 = [{4}]的数据已经存在!(in clsge_UserBadgeLogBL.AddNewRecordBySql2)", objge_UserBadgeLogEN.IdCurrEduCls,objge_UserBadgeLogEN.UserId,objge_UserBadgeLogEN.BadgeTypeId,objge_UserBadgeLogEN.GameLevelId,objge_UserBadgeLogEN.GetDate);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_UserBadgeLogDA.AddNewRecordBySQL2(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_UserBadgeLogEN objge_UserBadgeLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_UserBadgeLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],用户ID = [{1}],徽章类型Id = [{2}],游戏关卡Id = [{3}],获取日期 = [{4}]的数据已经存在!(in clsge_UserBadgeLogBL.AddNewRecordBySql2WithReturnKey)", objge_UserBadgeLogEN.IdCurrEduCls,objge_UserBadgeLogEN.UserId,objge_UserBadgeLogEN.BadgeTypeId,objge_UserBadgeLogEN.GameLevelId,objge_UserBadgeLogEN.GetDate);
throw new Exception(strMsg);
}
try
{
string strKey = ge_UserBadgeLogDA.AddNewRecordBySQL2WithReturnKey(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
try
{
bool bolResult = ge_UserBadgeLogDA.Update(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 /// <param name = "objge_UserBadgeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 if (objge_UserBadgeLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_UserBadgeLogDA.UpdateBySql2(objge_UserBadgeLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_UserBadgeLogBL.ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
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
 clsge_UserBadgeLogEN objge_UserBadgeLogEN = clsge_UserBadgeLogBL.GetObjBymId(lngmId);

if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(objge_UserBadgeLogEN.mId, "SetUpdDate");
}
if (objge_UserBadgeLogEN != null)
{
int intRecNum = ge_UserBadgeLogDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);
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
objSQL = clsge_UserBadgeLogDA.GetSpecSQLObj();
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
//删除与表:[ge_UserBadgeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_UserBadgeLog.mId,
//lngmId);
//        clsge_UserBadgeLogBL.Delge_UserBadgeLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_UserBadgeLogBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_UserBadgeLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsge_UserBadgeLogBL.relatedActions != null)
{
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ge_UserBadgeLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int Delge_UserBadgeLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsge_UserBadgeLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsge_UserBadgeLogEN objge_UserBadgeLogEN = clsge_UserBadgeLogBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ge_UserBadgeLogDA.Delge_UserBadgeLog(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_UserBadgeLogEN.IdCurrEduCls);
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
public static int Delge_UserBadgeLogsByCond(string strWhereCond)
{
try
{
if (clsge_UserBadgeLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsge_UserBadgeLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conge_UserBadgeLog.IdCurrEduCls, strWhereCond);
int intRecNum = ge_UserBadgeLogDA.Delge_UserBadgeLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_UserBadgeLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_UserBadgeLogDA.GetSpecSQLObj();
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
//删除与表:[ge_UserBadgeLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_UserBadgeLogBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_UserBadgeLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objge_UserBadgeLogENS">源对象</param>
 /// <param name = "objge_UserBadgeLogENT">目标对象</param>
 public static void CopyTo(clsge_UserBadgeLogEN objge_UserBadgeLogENS, clsge_UserBadgeLogEN objge_UserBadgeLogENT)
{
try
{
objge_UserBadgeLogENT.mId = objge_UserBadgeLogENS.mId; //mId
objge_UserBadgeLogENT.IdCurrEduCls = objge_UserBadgeLogENS.IdCurrEduCls; //教学班流水号
objge_UserBadgeLogENT.UserId = objge_UserBadgeLogENS.UserId; //用户ID
objge_UserBadgeLogENT.BadgeTypeId = objge_UserBadgeLogENS.BadgeTypeId; //徽章类型Id
objge_UserBadgeLogENT.GameLevelId = objge_UserBadgeLogENS.GameLevelId; //游戏关卡Id
objge_UserBadgeLogENT.GetInstructions = objge_UserBadgeLogENS.GetInstructions; //获取说明
objge_UserBadgeLogENT.GetDate = objge_UserBadgeLogENS.GetDate; //获取日期
objge_UserBadgeLogENT.CourseChapterId = objge_UserBadgeLogENS.CourseChapterId; //课程章节ID
objge_UserBadgeLogENT.UpdDate = objge_UserBadgeLogENS.UpdDate; //修改日期
objge_UserBadgeLogENT.UpdUser = objge_UserBadgeLogENS.UpdUser; //修改人
objge_UserBadgeLogENT.Memo = objge_UserBadgeLogENS.Memo; //备注
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
 /// <param name = "objge_UserBadgeLogEN">源简化对象</param>
 public static void SetUpdFlag(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
try
{
objge_UserBadgeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_UserBadgeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_UserBadgeLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.mId = objge_UserBadgeLogEN.mId; //mId
}
if (arrFldSet.Contains(conge_UserBadgeLog.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.IdCurrEduCls = objge_UserBadgeLogEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conge_UserBadgeLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.UserId = objge_UserBadgeLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(conge_UserBadgeLog.BadgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.BadgeTypeId = objge_UserBadgeLogEN.BadgeTypeId; //徽章类型Id
}
if (arrFldSet.Contains(conge_UserBadgeLog.GameLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.GameLevelId = objge_UserBadgeLogEN.GameLevelId == "[null]" ? null :  objge_UserBadgeLogEN.GameLevelId; //游戏关卡Id
}
if (arrFldSet.Contains(conge_UserBadgeLog.GetInstructions, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.GetInstructions = objge_UserBadgeLogEN.GetInstructions == "[null]" ? null :  objge_UserBadgeLogEN.GetInstructions; //获取说明
}
if (arrFldSet.Contains(conge_UserBadgeLog.GetDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.GetDate = objge_UserBadgeLogEN.GetDate == "[null]" ? null :  objge_UserBadgeLogEN.GetDate; //获取日期
}
if (arrFldSet.Contains(conge_UserBadgeLog.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.CourseChapterId = objge_UserBadgeLogEN.CourseChapterId == "[null]" ? null :  objge_UserBadgeLogEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conge_UserBadgeLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.UpdDate = objge_UserBadgeLogEN.UpdDate == "[null]" ? null :  objge_UserBadgeLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_UserBadgeLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.UpdUser = objge_UserBadgeLogEN.UpdUser == "[null]" ? null :  objge_UserBadgeLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_UserBadgeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_UserBadgeLogEN.Memo = objge_UserBadgeLogEN.Memo == "[null]" ? null :  objge_UserBadgeLogEN.Memo; //备注
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
 /// <param name = "objge_UserBadgeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
try
{
if (objge_UserBadgeLogEN.GameLevelId == "[null]") objge_UserBadgeLogEN.GameLevelId = null; //游戏关卡Id
if (objge_UserBadgeLogEN.GetInstructions == "[null]") objge_UserBadgeLogEN.GetInstructions = null; //获取说明
if (objge_UserBadgeLogEN.GetDate == "[null]") objge_UserBadgeLogEN.GetDate = null; //获取日期
if (objge_UserBadgeLogEN.CourseChapterId == "[null]") objge_UserBadgeLogEN.CourseChapterId = null; //课程章节ID
if (objge_UserBadgeLogEN.UpdDate == "[null]") objge_UserBadgeLogEN.UpdDate = null; //修改日期
if (objge_UserBadgeLogEN.UpdUser == "[null]") objge_UserBadgeLogEN.UpdUser = null; //修改人
if (objge_UserBadgeLogEN.Memo == "[null]") objge_UserBadgeLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 ge_UserBadgeLogDA.CheckPropertyNew(objge_UserBadgeLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
 ge_UserBadgeLogDA.CheckProperty4Condition(objge_UserBadgeLogEN);
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
if (clsge_UserBadgeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_UserBadgeLogBL没有刷新缓存机制(clsge_UserBadgeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrge_UserBadgeLogObjLstCache == null)
//{
//arrge_UserBadgeLogObjLstCache = ge_UserBadgeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_UserBadgeLogEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsge_UserBadgeLogEN._CurrTabName, strIdCurrEduCls);
List<clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLst_Sel =
arrge_UserBadgeLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrge_UserBadgeLogObjLst_Sel.Count() == 0)
{
   clsge_UserBadgeLogEN obj = clsge_UserBadgeLogBL.GetObjBymId(lngmId);
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
return arrge_UserBadgeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetAllge_UserBadgeLogObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrge_UserBadgeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_UserBadgeLogEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsge_UserBadgeLogEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsge_UserBadgeLogEN> arrge_UserBadgeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_UserBadgeLogObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsge_UserBadgeLogEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_UserBadgeLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_UserBadgeLogEN._RefreshTimeLst.Count == 0) return "";
return clsge_UserBadgeLogEN._RefreshTimeLst[clsge_UserBadgeLogEN._RefreshTimeLst.Count - 1];
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
if (clsge_UserBadgeLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_UserBadgeLogEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsge_UserBadgeLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_UserBadgeLogBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_UserBadgeLog(用户徽章日志)
 /// 唯一性条件:id_CurrEduCls_UserId_BadgeTypeId_GameLevelId_GetDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_UserBadgeLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_UserBadgeLogEN objge_UserBadgeLogEN)
{
//检测记录是否存在
string strResult = ge_UserBadgeLogDA.GetUniCondStr(objge_UserBadgeLogEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != conge_UserBadgeLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_UserBadgeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_UserBadgeLog.AttributeName));
throw new Exception(strMsg);
}
var objge_UserBadgeLog = clsge_UserBadgeLogBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objge_UserBadgeLog == null) return "";
return objge_UserBadgeLog[strOutFldName].ToString();
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
int intRecCount = clsge_UserBadgeLogDA.GetRecCount(strTabName);
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
int intRecCount = clsge_UserBadgeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_UserBadgeLogDA.GetRecCount();
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
int intRecCount = clsge_UserBadgeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_UserBadgeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_UserBadgeLogEN objge_UserBadgeLogCond)
{
 string strIdCurrEduCls = objge_UserBadgeLogCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_UserBadgeLogBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_UserBadgeLogEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsge_UserBadgeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_UserBadgeLog.AttributeName)
{
if (objge_UserBadgeLogCond.IsUpdated(strFldName) == false) continue;
if (objge_UserBadgeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserBadgeLogCond[strFldName].ToString());
}
else
{
if (objge_UserBadgeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_UserBadgeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_UserBadgeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_UserBadgeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_UserBadgeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_UserBadgeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_UserBadgeLogCond[strFldName]));
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
 List<string> arrList = clsge_UserBadgeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_UserBadgeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_UserBadgeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_UserBadgeLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_UserBadgeLogDA.SetFldValue(clsge_UserBadgeLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_UserBadgeLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_UserBadgeLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_UserBadgeLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_UserBadgeLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_UserBadgeLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**徽章类型Id*/ 
 strCreateTabCode.Append(" BadgeTypeId char(2) not Null, "); 
 // /**游戏关卡Id*/ 
 strCreateTabCode.Append(" GameLevelId char(8) Null, "); 
 // /**获取说明*/ 
 strCreateTabCode.Append(" GetInstructions varchar(100) Null, "); 
 // /**获取日期*/ 
 strCreateTabCode.Append(" GetDate varchar(20) Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**徽章类型名*/ 
 strCreateTabCode.Append(" BadgeTypeName varchar(50) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**游戏关卡名称*/ 
 strCreateTabCode.Append(" GameLevelName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户徽章日志(ge_UserBadgeLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_UserBadgeLog : clsCommFun4BLV2
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
clsge_UserBadgeLogBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}