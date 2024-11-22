
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRTUserRelaBL
 表名:RTUserRela(01120582)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsRTUserRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTUserRelaEN GetObj(this K_mId_RTUserRela myKey)
{
clsRTUserRelaEN objRTUserRelaEN = clsRTUserRelaBL.RTUserRelaDA.GetObjBymId(myKey.Value);
return objRTUserRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRTUserRelaEN objRTUserRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTUserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsRTUserRelaBL.AddNewRecord)", objRTUserRelaEN.TopicId,objRTUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsRTUserRelaBL.RTUserRelaDA.AddNewRecordBySQL2(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsRTUserRelaEN objRTUserRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objRTUserRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objRTUserRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题Id(TopicId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objRTUserRelaEN.TopicId, objRTUserRelaEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objRTUserRelaEN.AddNewRecord();
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsRTUserRelaEN objRTUserRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objRTUserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsRTUserRelaBL.AddNewRecordWithReturnKey)", objRTUserRelaEN.TopicId,objRTUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsRTUserRelaBL.RTUserRelaDA.AddNewRecordBySQL2WithReturnKey(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetmId(this clsRTUserRelaEN objRTUserRelaEN, long lngmId, string strComparisonOp="")
	{
objRTUserRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.mId) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.mId, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.mId] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetTopicId(this clsRTUserRelaEN objRTUserRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conRTUserRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conRTUserRela.TopicId);
}
objRTUserRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.TopicId) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.TopicId, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.TopicId] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetUserId(this clsRTUserRelaEN objRTUserRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conRTUserRela.UserId);
}
objRTUserRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.UserId) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.UserId, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.UserId] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetTopicUserRoleId(this clsRTUserRelaEN objRTUserRelaEN, string strTopicUserRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicUserRoleId, conRTUserRela.TopicUserRoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicUserRoleId, 4, conRTUserRela.TopicUserRoleId);
}
objRTUserRelaEN.TopicUserRoleId = strTopicUserRoleId; //主键Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.TopicUserRoleId) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.TopicUserRoleId, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.TopicUserRoleId] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetColorId(this clsRTUserRelaEN objRTUserRelaEN, string strColorId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColorId, 2, conRTUserRela.ColorId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strColorId, 2, conRTUserRela.ColorId);
}
objRTUserRelaEN.ColorId = strColorId; //颜色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.ColorId) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.ColorId, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.ColorId] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetOrderNum(this clsRTUserRelaEN objRTUserRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objRTUserRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.OrderNum) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.OrderNum, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.OrderNum] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetUserBgColor(this clsRTUserRelaEN objRTUserRelaEN, string strUserBgColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserBgColor, 200, conRTUserRela.UserBgColor);
}
objRTUserRelaEN.UserBgColor = strUserBgColor; //用户段落背景
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.UserBgColor) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.UserBgColor, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.UserBgColor] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetIdCurrEduCls(this clsRTUserRelaEN objRTUserRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conRTUserRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conRTUserRela.IdCurrEduCls);
}
objRTUserRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.IdCurrEduCls) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.IdCurrEduCls, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.IdCurrEduCls] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetAppraiseCount(this clsRTUserRelaEN objRTUserRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objRTUserRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.AppraiseCount) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.AppraiseCount, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.AppraiseCount] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetOkCount(this clsRTUserRelaEN objRTUserRelaEN, int? intOkCount, string strComparisonOp="")
	{
objRTUserRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.OkCount) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.OkCount, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.OkCount] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetScore(this clsRTUserRelaEN objRTUserRelaEN, float? fltScore, string strComparisonOp="")
	{
objRTUserRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.Score) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.Score, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.Score] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetStuScore(this clsRTUserRelaEN objRTUserRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objRTUserRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.StuScore) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.StuScore, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.StuScore] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetTeaScore(this clsRTUserRelaEN objRTUserRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objRTUserRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.TeaScore) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.TeaScore, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.TeaScore] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetIsSubmit(this clsRTUserRelaEN objRTUserRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objRTUserRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.IsSubmit) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.IsSubmit, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.IsSubmit] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetLastVisitedDate(this clsRTUserRelaEN objRTUserRelaEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, conRTUserRela.LastVisitedDate);
}
objRTUserRelaEN.LastVisitedDate = strLastVisitedDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.LastVisitedDate) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.LastVisitedDate, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.LastVisitedDate] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetUpdDate(this clsRTUserRelaEN objRTUserRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRTUserRela.UpdDate);
}
objRTUserRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.UpdDate) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.UpdDate, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.UpdDate] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetUpdUser(this clsRTUserRelaEN objRTUserRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRTUserRela.UpdUser);
}
objRTUserRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.UpdUser) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.UpdUser, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.UpdUser] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsRTUserRelaEN SetMemo(this clsRTUserRelaEN objRTUserRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRTUserRela.Memo);
}
objRTUserRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRTUserRelaEN.dicFldComparisonOp.ContainsKey(conRTUserRela.Memo) == false)
{
objRTUserRelaEN.dicFldComparisonOp.Add(conRTUserRela.Memo, strComparisonOp);
}
else
{
objRTUserRelaEN.dicFldComparisonOp[conRTUserRela.Memo] = strComparisonOp;
}
}
return objRTUserRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsRTUserRelaEN objRTUserRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objRTUserRelaEN.CheckPropertyNew();
clsRTUserRelaEN objRTUserRelaCond = new clsRTUserRelaEN();
string strCondition = objRTUserRelaCond
.SetmId(objRTUserRelaEN.mId, "<>")
.SetTopicId(objRTUserRelaEN.TopicId, "=")
.SetUserId(objRTUserRelaEN.UserId, "=")
.GetCombineCondition();
objRTUserRelaEN._IsCheckProperty = true;
bool bolIsExist = clsRTUserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objRTUserRelaEN.Update();
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
 /// <param name = "objRTUserRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsRTUserRelaEN objRTUserRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsRTUserRelaEN objRTUserRelaCond = new clsRTUserRelaEN();
string strCondition = objRTUserRelaCond
.SetTopicId(objRTUserRela.TopicId, "=")
.SetUserId(objRTUserRela.UserId, "=")
.GetCombineCondition();
objRTUserRela._IsCheckProperty = true;
bool bolIsExist = clsRTUserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objRTUserRela.mId = clsRTUserRelaBL.GetFirstID_S(strCondition);
objRTUserRela.UpdateWithCondition(strCondition);
}
else
{
objRTUserRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTUserRelaEN objRTUserRelaEN)
{
 if (objRTUserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTUserRelaBL.RTUserRelaDA.UpdateBySql2(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRTUserRelaEN objRTUserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRTUserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsRTUserRelaBL.RTUserRelaDA.UpdateBySql2(objRTUserRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTUserRelaEN objRTUserRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsRTUserRelaBL.RTUserRelaDA.UpdateBySqlWithCondition(objRTUserRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRTUserRelaEN objRTUserRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsRTUserRelaBL.RTUserRelaDA.UpdateBySqlWithConditionTransaction(objRTUserRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
public static int Delete(this clsRTUserRelaEN objRTUserRelaEN)
{
try
{
int intRecNum = clsRTUserRelaBL.RTUserRelaDA.DelRecord(objRTUserRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaENS">源对象</param>
 /// <param name = "objRTUserRelaENT">目标对象</param>
 public static void CopyTo(this clsRTUserRelaEN objRTUserRelaENS, clsRTUserRelaEN objRTUserRelaENT)
{
try
{
objRTUserRelaENT.mId = objRTUserRelaENS.mId; //mId
objRTUserRelaENT.TopicId = objRTUserRelaENS.TopicId; //主题Id
objRTUserRelaENT.UserId = objRTUserRelaENS.UserId; //用户ID
objRTUserRelaENT.TopicUserRoleId = objRTUserRelaENS.TopicUserRoleId; //主键Id
objRTUserRelaENT.ColorId = objRTUserRelaENS.ColorId; //颜色Id
objRTUserRelaENT.OrderNum = objRTUserRelaENS.OrderNum; //序号
objRTUserRelaENT.UserBgColor = objRTUserRelaENS.UserBgColor; //用户段落背景
objRTUserRelaENT.IdCurrEduCls = objRTUserRelaENS.IdCurrEduCls; //教学班流水号
objRTUserRelaENT.AppraiseCount = objRTUserRelaENS.AppraiseCount; //评论数
objRTUserRelaENT.OkCount = objRTUserRelaENS.OkCount; //点赞统计
objRTUserRelaENT.Score = objRTUserRelaENS.Score; //评分
objRTUserRelaENT.StuScore = objRTUserRelaENS.StuScore; //学生平均分
objRTUserRelaENT.TeaScore = objRTUserRelaENS.TeaScore; //教师评分
objRTUserRelaENT.IsSubmit = objRTUserRelaENS.IsSubmit; //是否提交
objRTUserRelaENT.LastVisitedDate = objRTUserRelaENS.LastVisitedDate; //修改日期
objRTUserRelaENT.UpdDate = objRTUserRelaENS.UpdDate; //修改日期
objRTUserRelaENT.UpdUser = objRTUserRelaENS.UpdUser; //修改人
objRTUserRelaENT.Memo = objRTUserRelaENS.Memo; //备注
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
 /// <param name = "objRTUserRelaENS">源对象</param>
 /// <returns>目标对象=>clsRTUserRelaEN:objRTUserRelaENT</returns>
 public static clsRTUserRelaEN CopyTo(this clsRTUserRelaEN objRTUserRelaENS)
{
try
{
 clsRTUserRelaEN objRTUserRelaENT = new clsRTUserRelaEN()
{
mId = objRTUserRelaENS.mId, //mId
TopicId = objRTUserRelaENS.TopicId, //主题Id
UserId = objRTUserRelaENS.UserId, //用户ID
TopicUserRoleId = objRTUserRelaENS.TopicUserRoleId, //主键Id
ColorId = objRTUserRelaENS.ColorId, //颜色Id
OrderNum = objRTUserRelaENS.OrderNum, //序号
UserBgColor = objRTUserRelaENS.UserBgColor, //用户段落背景
IdCurrEduCls = objRTUserRelaENS.IdCurrEduCls, //教学班流水号
AppraiseCount = objRTUserRelaENS.AppraiseCount, //评论数
OkCount = objRTUserRelaENS.OkCount, //点赞统计
Score = objRTUserRelaENS.Score, //评分
StuScore = objRTUserRelaENS.StuScore, //学生平均分
TeaScore = objRTUserRelaENS.TeaScore, //教师评分
IsSubmit = objRTUserRelaENS.IsSubmit, //是否提交
LastVisitedDate = objRTUserRelaENS.LastVisitedDate, //修改日期
UpdDate = objRTUserRelaENS.UpdDate, //修改日期
UpdUser = objRTUserRelaENS.UpdUser, //修改人
Memo = objRTUserRelaENS.Memo, //备注
};
 return objRTUserRelaENT;
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
public static void CheckPropertyNew(this clsRTUserRelaEN objRTUserRelaEN)
{
 clsRTUserRelaBL.RTUserRelaDA.CheckPropertyNew(objRTUserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsRTUserRelaEN objRTUserRelaEN)
{
 clsRTUserRelaBL.RTUserRelaDA.CheckProperty4Condition(objRTUserRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRTUserRelaEN objRTUserRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRTUserRelaCond.IsUpdated(conRTUserRela.mId) == true)
{
string strComparisonOpmId = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.mId, objRTUserRelaCond.mId, strComparisonOpmId);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.TopicId) == true)
{
string strComparisonOpTopicId = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.TopicId, objRTUserRelaCond.TopicId, strComparisonOpTopicId);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.UserId) == true)
{
string strComparisonOpUserId = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.UserId, objRTUserRelaCond.UserId, strComparisonOpUserId);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.TopicUserRoleId) == true)
{
string strComparisonOpTopicUserRoleId = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.TopicUserRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.TopicUserRoleId, objRTUserRelaCond.TopicUserRoleId, strComparisonOpTopicUserRoleId);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.ColorId) == true)
{
string strComparisonOpColorId = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.ColorId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.ColorId, objRTUserRelaCond.ColorId, strComparisonOpColorId);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.OrderNum, objRTUserRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.UserBgColor) == true)
{
string strComparisonOpUserBgColor = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.UserBgColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.UserBgColor, objRTUserRelaCond.UserBgColor, strComparisonOpUserBgColor);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.IdCurrEduCls, objRTUserRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.AppraiseCount, objRTUserRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.OkCount) == true)
{
string strComparisonOpOkCount = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.OkCount, objRTUserRelaCond.OkCount, strComparisonOpOkCount);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.Score) == true)
{
string strComparisonOpScore = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.Score, objRTUserRelaCond.Score, strComparisonOpScore);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.StuScore) == true)
{
string strComparisonOpStuScore = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.StuScore, objRTUserRelaCond.StuScore, strComparisonOpStuScore);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conRTUserRela.TeaScore, objRTUserRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.IsSubmit) == true)
{
if (objRTUserRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conRTUserRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conRTUserRela.IsSubmit);
}
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.LastVisitedDate, objRTUserRelaCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.UpdDate, objRTUserRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.UpdUser, objRTUserRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objRTUserRelaCond.IsUpdated(conRTUserRela.Memo) == true)
{
string strComparisonOpMemo = objRTUserRelaCond.dicFldComparisonOp[conRTUserRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRTUserRela.Memo, objRTUserRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--RTUserRela(主题用户关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objRTUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsRTUserRelaEN objRTUserRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objRTUserRelaEN == null) return true;
if (objRTUserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objRTUserRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objRTUserRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTUserRelaEN.TopicId);
}
 if (objRTUserRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objRTUserRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objRTUserRelaEN.UserId);
}
if (clsRTUserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTUserRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTUserRelaEN.TopicId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objRTUserRelaEN.UserId);
if (clsRTUserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--RTUserRela(主题用户关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRTUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsRTUserRelaEN objRTUserRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRTUserRelaEN == null) return "";
if (objRTUserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objRTUserRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objRTUserRelaEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTUserRelaEN.TopicId);
}
 if (objRTUserRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objRTUserRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objRTUserRelaEN.UserId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objRTUserRelaEN.mId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objRTUserRelaEN.TopicId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objRTUserRelaEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_RTUserRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题用户关系(RTUserRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsRTUserRelaBL
{
public static RelatedActions_RTUserRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsRTUserRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsRTUserRelaDA RTUserRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsRTUserRelaDA();
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
 public clsRTUserRelaBL()
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
if (string.IsNullOrEmpty(clsRTUserRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRTUserRelaEN._ConnectString);
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
public static DataTable GetDataTable_RTUserRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = RTUserRelaDA.GetDataTable_RTUserRela(strWhereCond);
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
objDT = RTUserRelaDA.GetDataTable(strWhereCond);
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
objDT = RTUserRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = RTUserRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = RTUserRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = RTUserRelaDA.GetDataTable_Top(objTopPara);
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
objDT = RTUserRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = RTUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = RTUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsRTUserRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
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
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsRTUserRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strUserId);
List<clsRTUserRelaEN> arrRTUserRelaObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsRTUserRelaEN> arrRTUserRelaObjLst_Sel =
arrRTUserRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrRTUserRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTUserRelaEN> GetObjLst(string strWhereCond)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
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
public static List<clsRTUserRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objRTUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsRTUserRelaEN> GetSubObjLstCache(clsRTUserRelaEN objRTUserRelaCond)
{
 string strUserId = objRTUserRelaCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsRTUserRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsRTUserRelaEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsRTUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTUserRela.AttributeName)
{
if (objRTUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTUserRelaCond[strFldName].ToString());
}
else
{
if (objRTUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTUserRelaCond[strFldName]));
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
public static List<clsRTUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
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
public static List<clsRTUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
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
List<clsRTUserRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsRTUserRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTUserRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsRTUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
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
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
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
public static List<clsRTUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsRTUserRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsRTUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
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
public static List<clsRTUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsRTUserRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsRTUserRelaEN> arrObjLst = new List<clsRTUserRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRTUserRelaEN objRTUserRelaEN = new clsRTUserRelaEN();
try
{
objRTUserRelaEN.mId = Int32.Parse(objRow[conRTUserRela.mId].ToString().Trim()); //mId
objRTUserRelaEN.TopicId = objRow[conRTUserRela.TopicId] == DBNull.Value ? null : objRow[conRTUserRela.TopicId].ToString().Trim(); //主题Id
objRTUserRelaEN.UserId = objRow[conRTUserRela.UserId] == DBNull.Value ? null : objRow[conRTUserRela.UserId].ToString().Trim(); //用户ID
objRTUserRelaEN.TopicUserRoleId = objRow[conRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objRTUserRelaEN.ColorId = objRow[conRTUserRela.ColorId] == DBNull.Value ? null : objRow[conRTUserRela.ColorId].ToString().Trim(); //颜色Id
objRTUserRelaEN.OrderNum = objRow[conRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OrderNum].ToString().Trim()); //序号
objRTUserRelaEN.UserBgColor = objRow[conRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[conRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objRTUserRelaEN.IdCurrEduCls = objRow[conRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[conRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRTUserRelaEN.AppraiseCount = objRow[conRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objRTUserRelaEN.OkCount = objRow[conRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conRTUserRela.OkCount].ToString().Trim()); //点赞统计
objRTUserRelaEN.Score = objRow[conRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.Score].ToString().Trim()); //评分
objRTUserRelaEN.StuScore = objRow[conRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.StuScore].ToString().Trim()); //学生平均分
objRTUserRelaEN.TeaScore = objRow[conRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conRTUserRela.TeaScore].ToString().Trim()); //教师评分
objRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objRTUserRelaEN.LastVisitedDate = objRow[conRTUserRela.LastVisitedDate] == DBNull.Value ? null : objRow[conRTUserRela.LastVisitedDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdDate = objRow[conRTUserRela.UpdDate] == DBNull.Value ? null : objRow[conRTUserRela.UpdDate].ToString().Trim(); //修改日期
objRTUserRelaEN.UpdUser = objRow[conRTUserRela.UpdUser] == DBNull.Value ? null : objRow[conRTUserRela.UpdUser].ToString().Trim(); //修改人
objRTUserRelaEN.Memo = objRow[conRTUserRela.Memo] == DBNull.Value ? null : objRow[conRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objRTUserRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objRTUserRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetRTUserRela(ref clsRTUserRelaEN objRTUserRelaEN)
{
bool bolResult = RTUserRelaDA.GetRTUserRela(ref objRTUserRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRTUserRelaEN GetObjBymId(long lngmId)
{
clsRTUserRelaEN objRTUserRelaEN = RTUserRelaDA.GetObjBymId(lngmId);
return objRTUserRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsRTUserRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsRTUserRelaEN objRTUserRelaEN = RTUserRelaDA.GetFirstObj(strWhereCond);
 return objRTUserRelaEN;
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
public static clsRTUserRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsRTUserRelaEN objRTUserRelaEN = RTUserRelaDA.GetObjByDataRow(objRow);
 return objRTUserRelaEN;
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
public static clsRTUserRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsRTUserRelaEN objRTUserRelaEN = RTUserRelaDA.GetObjByDataRow(objRow);
 return objRTUserRelaEN;
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
 /// <param name = "lstRTUserRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTUserRelaEN GetObjBymIdFromList(long lngmId, List<clsRTUserRelaEN> lstRTUserRelaObjLst)
{
foreach (clsRTUserRelaEN objRTUserRelaEN in lstRTUserRelaObjLst)
{
if (objRTUserRelaEN.mId == lngmId)
{
return objRTUserRelaEN;
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
 lngmId = new clsRTUserRelaDA().GetFirstID(strWhereCond);
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
 arrList = RTUserRelaDA.GetID(strWhereCond);
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
bool bolIsExist = RTUserRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = RTUserRelaDA.IsExist(lngmId);
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
clsRTUserRelaEN objRTUserRelaEN = clsRTUserRelaBL.GetObjBymId(lngmId);
objRTUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objRTUserRelaEN.UpdUser = strOpUser;
return clsRTUserRelaBL.UpdateBySql2(objRTUserRelaEN);
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
 bolIsExist = clsRTUserRelaDA.IsExistTable();
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
 bolIsExist = RTUserRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsRTUserRelaEN objRTUserRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTUserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsRTUserRelaBL.AddNewRecordBySql2)", objRTUserRelaEN.TopicId,objRTUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = RTUserRelaDA.AddNewRecordBySQL2(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsRTUserRelaEN objRTUserRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objRTUserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsRTUserRelaBL.AddNewRecordBySql2WithReturnKey)", objRTUserRelaEN.TopicId,objRTUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = RTUserRelaDA.AddNewRecordBySQL2WithReturnKey(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsRTUserRelaEN objRTUserRelaEN)
{
try
{
bool bolResult = RTUserRelaDA.Update(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 /// <param name = "objRTUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsRTUserRelaEN objRTUserRelaEN)
{
 if (objRTUserRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = RTUserRelaDA.UpdateBySql2(objRTUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRTUserRelaBL.ReFreshCache(objRTUserRelaEN.UserId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
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
 clsRTUserRelaEN objRTUserRelaEN = clsRTUserRelaBL.GetObjBymId(lngmId);

if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(objRTUserRelaEN.mId, objRTUserRelaEN.UpdUser);
}
if (objRTUserRelaEN != null)
{
int intRecNum = RTUserRelaDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objRTUserRelaEN.UserId);
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
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
//删除与表:[RTUserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conRTUserRela.mId,
//lngmId);
//        clsRTUserRelaBL.DelRTUserRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTUserRelaBL.DelRecord(lngmId, strUserId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTUserRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strUserId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsRTUserRelaBL.relatedActions != null)
{
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = RTUserRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strUserId);
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
public static int DelRTUserRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsRTUserRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsRTUserRelaEN objRTUserRelaEN = clsRTUserRelaBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = RTUserRelaDA.DelRTUserRela(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objRTUserRelaEN.UserId);
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
public static int DelRTUserRelasByCond(string strWhereCond)
{
try
{
if (clsRTUserRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsRTUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrUserId = GetFldValue(conRTUserRela.UserId, strWhereCond);
int intRecNum = RTUserRelaDA.DelRTUserRela(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrUserId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[RTUserRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strUserId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsRTUserRelaDA.GetSpecSQLObj();
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
//删除与表:[RTUserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsRTUserRelaBL.DelRecord(lngmId, strUserId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsRTUserRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objRTUserRelaENS">源对象</param>
 /// <param name = "objRTUserRelaENT">目标对象</param>
 public static void CopyTo(clsRTUserRelaEN objRTUserRelaENS, clsRTUserRelaEN objRTUserRelaENT)
{
try
{
objRTUserRelaENT.mId = objRTUserRelaENS.mId; //mId
objRTUserRelaENT.TopicId = objRTUserRelaENS.TopicId; //主题Id
objRTUserRelaENT.UserId = objRTUserRelaENS.UserId; //用户ID
objRTUserRelaENT.TopicUserRoleId = objRTUserRelaENS.TopicUserRoleId; //主键Id
objRTUserRelaENT.ColorId = objRTUserRelaENS.ColorId; //颜色Id
objRTUserRelaENT.OrderNum = objRTUserRelaENS.OrderNum; //序号
objRTUserRelaENT.UserBgColor = objRTUserRelaENS.UserBgColor; //用户段落背景
objRTUserRelaENT.IdCurrEduCls = objRTUserRelaENS.IdCurrEduCls; //教学班流水号
objRTUserRelaENT.AppraiseCount = objRTUserRelaENS.AppraiseCount; //评论数
objRTUserRelaENT.OkCount = objRTUserRelaENS.OkCount; //点赞统计
objRTUserRelaENT.Score = objRTUserRelaENS.Score; //评分
objRTUserRelaENT.StuScore = objRTUserRelaENS.StuScore; //学生平均分
objRTUserRelaENT.TeaScore = objRTUserRelaENS.TeaScore; //教师评分
objRTUserRelaENT.IsSubmit = objRTUserRelaENS.IsSubmit; //是否提交
objRTUserRelaENT.LastVisitedDate = objRTUserRelaENS.LastVisitedDate; //修改日期
objRTUserRelaENT.UpdDate = objRTUserRelaENS.UpdDate; //修改日期
objRTUserRelaENT.UpdUser = objRTUserRelaENS.UpdUser; //修改人
objRTUserRelaENT.Memo = objRTUserRelaENS.Memo; //备注
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
 /// <param name = "objRTUserRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsRTUserRelaEN objRTUserRelaEN)
{
try
{
objRTUserRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objRTUserRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conRTUserRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.mId = objRTUserRelaEN.mId; //mId
}
if (arrFldSet.Contains(conRTUserRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.TopicId = objRTUserRelaEN.TopicId == "[null]" ? null :  objRTUserRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conRTUserRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.UserId = objRTUserRelaEN.UserId == "[null]" ? null :  objRTUserRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(conRTUserRela.TopicUserRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.TopicUserRoleId = objRTUserRelaEN.TopicUserRoleId; //主键Id
}
if (arrFldSet.Contains(conRTUserRela.ColorId, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.ColorId = objRTUserRelaEN.ColorId == "[null]" ? null :  objRTUserRelaEN.ColorId; //颜色Id
}
if (arrFldSet.Contains(conRTUserRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.OrderNum = objRTUserRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conRTUserRela.UserBgColor, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.UserBgColor = objRTUserRelaEN.UserBgColor == "[null]" ? null :  objRTUserRelaEN.UserBgColor; //用户段落背景
}
if (arrFldSet.Contains(conRTUserRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.IdCurrEduCls = objRTUserRelaEN.IdCurrEduCls == "[null]" ? null :  objRTUserRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conRTUserRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.AppraiseCount = objRTUserRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conRTUserRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.OkCount = objRTUserRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conRTUserRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.Score = objRTUserRelaEN.Score; //评分
}
if (arrFldSet.Contains(conRTUserRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.StuScore = objRTUserRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conRTUserRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.TeaScore = objRTUserRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conRTUserRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.IsSubmit = objRTUserRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conRTUserRela.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.LastVisitedDate = objRTUserRelaEN.LastVisitedDate == "[null]" ? null :  objRTUserRelaEN.LastVisitedDate; //修改日期
}
if (arrFldSet.Contains(conRTUserRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.UpdDate = objRTUserRelaEN.UpdDate == "[null]" ? null :  objRTUserRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conRTUserRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.UpdUser = objRTUserRelaEN.UpdUser == "[null]" ? null :  objRTUserRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conRTUserRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objRTUserRelaEN.Memo = objRTUserRelaEN.Memo == "[null]" ? null :  objRTUserRelaEN.Memo; //备注
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
 /// <param name = "objRTUserRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsRTUserRelaEN objRTUserRelaEN)
{
try
{
if (objRTUserRelaEN.TopicId == "[null]") objRTUserRelaEN.TopicId = null; //主题Id
if (objRTUserRelaEN.UserId == "[null]") objRTUserRelaEN.UserId = null; //用户ID
if (objRTUserRelaEN.ColorId == "[null]") objRTUserRelaEN.ColorId = null; //颜色Id
if (objRTUserRelaEN.UserBgColor == "[null]") objRTUserRelaEN.UserBgColor = null; //用户段落背景
if (objRTUserRelaEN.IdCurrEduCls == "[null]") objRTUserRelaEN.IdCurrEduCls = null; //教学班流水号
if (objRTUserRelaEN.LastVisitedDate == "[null]") objRTUserRelaEN.LastVisitedDate = null; //修改日期
if (objRTUserRelaEN.UpdDate == "[null]") objRTUserRelaEN.UpdDate = null; //修改日期
if (objRTUserRelaEN.UpdUser == "[null]") objRTUserRelaEN.UpdUser = null; //修改人
if (objRTUserRelaEN.Memo == "[null]") objRTUserRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsRTUserRelaEN objRTUserRelaEN)
{
 RTUserRelaDA.CheckPropertyNew(objRTUserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsRTUserRelaEN objRTUserRelaEN)
{
 RTUserRelaDA.CheckProperty4Condition(objRTUserRelaEN);
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
if (clsRTUserRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTUserRelaBL没有刷新缓存机制(clsRTUserRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrRTUserRelaObjLstCache == null)
//{
//arrRTUserRelaObjLstCache = RTUserRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRTUserRelaEN GetObjBymIdCache(long lngmId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strUserId);
List<clsRTUserRelaEN> arrRTUserRelaObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsRTUserRelaEN> arrRTUserRelaObjLst_Sel =
arrRTUserRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrRTUserRelaObjLst_Sel.Count() == 0)
{
   clsRTUserRelaEN obj = clsRTUserRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrRTUserRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTUserRelaEN> GetAllRTUserRelaObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsRTUserRelaEN> arrRTUserRelaObjLstCache = GetObjLstCache(strUserId); 
return arrRTUserRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRTUserRelaEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsRTUserRelaEN> arrRTUserRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrRTUserRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsRTUserRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsRTUserRelaEN._RefreshTimeLst.Count == 0) return "";
return clsRTUserRelaEN._RefreshTimeLst[clsRTUserRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("缓存分类字段:[UserId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTUserRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsRTUserRelaEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsRTUserRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsRTUserRelaBL.objCommFun4BL.ReFreshCache(strUserId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--RTUserRela(主题用户关系)
 /// 唯一性条件:TopicId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objRTUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsRTUserRelaEN objRTUserRelaEN)
{
//检测记录是否存在
string strResult = RTUserRelaDA.GetUniCondStr(objRTUserRelaEN);
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
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strUserId)
{
if (strInFldName != conRTUserRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conRTUserRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conRTUserRela.AttributeName));
throw new Exception(strMsg);
}
var objRTUserRela = clsRTUserRelaBL.GetObjBymIdCache(lngmId, strUserId);
if (objRTUserRela == null) return "";
return objRTUserRela[strOutFldName].ToString();
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
int intRecCount = clsRTUserRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsRTUserRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsRTUserRelaDA.GetRecCount();
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
int intRecCount = clsRTUserRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objRTUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsRTUserRelaEN objRTUserRelaCond)
{
 string strUserId = objRTUserRelaCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsRTUserRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsRTUserRelaEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsRTUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conRTUserRela.AttributeName)
{
if (objRTUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objRTUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTUserRelaCond[strFldName].ToString());
}
else
{
if (objRTUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objRTUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objRTUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objRTUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objRTUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objRTUserRelaCond[strFldName]));
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
 List<string> arrList = clsRTUserRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = RTUserRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = RTUserRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = RTUserRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTUserRelaDA.SetFldValue(clsRTUserRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = RTUserRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTUserRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsRTUserRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsRTUserRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[RTUserRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**主键Id*/ 
 strCreateTabCode.Append(" TopicUserRoleId char(4) not Null, "); 
 // /**颜色Id*/ 
 strCreateTabCode.Append(" ColorId char(2) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**用户段落背景*/ 
 strCreateTabCode.Append(" UserBgColor varchar(200) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**颜色码*/ 
 strCreateTabCode.Append(" ColorCode varchar(200) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**主题用户角色*/ 
 strCreateTabCode.Append(" TopicUserRoleName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strTopicId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strTopicId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsRTUserRelaEN> arrRTUserRelaObjList = new clsRTUserRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRTUserRelaEN objRTUserRela in arrRTUserRelaObjList)
{
objRTUserRela.OrderNum = intIndex;
UpdateBySql2(objRTUserRela);
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
/// 调整所给关键字记录的序号。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strTopicId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strTopicId)
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
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsRTUserRelaEN objRTUserRela = clsRTUserRelaBL.GetObjBymId(lngmId);

intOrderNum = objRTUserRela.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);
intTabRecNum = clsRTUserRelaBL.GetRecCountByCond(clsRTUserRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conRTUserRela.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsRTUserRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsRTUserRelaBL.SetFldValue(clsRTUserRelaEN._CurrTabName, conRTUserRela.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conRTUserRela.mId, lngmId));
clsRTUserRelaBL.SetFldValue(clsRTUserRelaEN._CurrTabName, conRTUserRela.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conRTUserRela.mId, lngPrevmId));
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
sbCondition.AppendFormat(" {0} = {1} ", conRTUserRela.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);

lngNextmId = clsRTUserRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsRTUserRelaBL.SetFldValue(clsRTUserRelaEN._CurrTabName, conRTUserRela.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conRTUserRela.mId, lngmId));
clsRTUserRelaBL.SetFldValue(clsRTUserRelaEN._CurrTabName, conRTUserRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conRTUserRela.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strTopicId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conRTUserRela.mId, strKeyList);
List<clsRTUserRelaEN> arrRTUserRelaLst = GetObjLst(strCondition);
foreach (clsRTUserRelaEN objRTUserRela in arrRTUserRelaLst)
{
objRTUserRela.OrderNum = objRTUserRela.OrderNum + 10000;
UpdateBySql2(objRTUserRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsRTUserRelaEN> arrRTUserRelaObjList = new clsRTUserRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRTUserRelaEN objRTUserRela in arrRTUserRelaObjList)
{
objRTUserRela.OrderNum = intIndex;
UpdateBySql2(objRTUserRela);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：TopicId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strTopicId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strTopicId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conRTUserRela.mId, strKeyList);
List<clsRTUserRelaEN> arrRTUserRelaLst = GetObjLst(strCondition);
foreach (clsRTUserRelaEN objRTUserRela in arrRTUserRelaLst)
{
objRTUserRela.OrderNum = objRTUserRela.OrderNum - 10000;
UpdateBySql2(objRTUserRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conRTUserRela.TopicId, strTopicId);
 strCondition += string.Format(" order by OrderNum ");
List<clsRTUserRelaEN> arrRTUserRelaObjList = new clsRTUserRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsRTUserRelaEN objRTUserRela in arrRTUserRelaObjList)
{
objRTUserRela.OrderNum = intIndex;
UpdateBySql2(objRTUserRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 主题用户关系(RTUserRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4RTUserRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsRTUserRelaBL.ReFreshThisCache(strUserId);
}
}

}