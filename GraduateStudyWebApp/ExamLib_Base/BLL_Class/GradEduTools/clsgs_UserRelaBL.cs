
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_UserRelaBL
 表名:gs_UserRela(01120773)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsgs_UserRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_UserRelaEN GetObj(this K_mId_gs_UserRela myKey)
{
clsgs_UserRelaEN objgs_UserRelaEN = clsgs_UserRelaBL.gs_UserRelaDA.GetObjBymId(myKey.Value);
return objgs_UserRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_UserRelaEN objgs_UserRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_UserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_UserRelaBL.AddNewRecord)", objgs_UserRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_UserRelaBL.gs_UserRelaDA.AddNewRecordBySQL2(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_UserRelaEN objgs_UserRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_UserRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_UserRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objgs_UserRelaEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_UserRelaEN.AddNewRecord();
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_UserRelaEN objgs_UserRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_UserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_UserRelaBL.AddNewRecordWithReturnKey)", objgs_UserRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_UserRelaBL.gs_UserRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetmId(this clsgs_UserRelaEN objgs_UserRelaEN, long lngmId, string strComparisonOp="")
	{
objgs_UserRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.mId) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.mId, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.mId] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUserId(this clsgs_UserRelaEN objgs_UserRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, congs_UserRela.UserId);
}
objgs_UserRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UserId) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UserId, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UserId] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUserRelaId(this clsgs_UserRelaEN objgs_UserRelaEN, string strUserRelaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserRelaId, 50, congs_UserRela.UserRelaId);
}
objgs_UserRelaEN.UserRelaId = strUserRelaId; //关系用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UserRelaId) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UserRelaId, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UserRelaId] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUpdUser(this clsgs_UserRelaEN objgs_UserRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_UserRela.UpdUser);
}
objgs_UserRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UpdUser) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UpdUser, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UpdUser] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUpdDate(this clsgs_UserRelaEN objgs_UserRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_UserRela.UpdDate);
}
objgs_UserRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UpdDate) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UpdDate, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UpdDate] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetMemo(this clsgs_UserRelaEN objgs_UserRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_UserRela.Memo);
}
objgs_UserRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.Memo) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.Memo, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.Memo] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUpdUserName(this clsgs_UserRelaEN objgs_UserRelaEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, congs_UserRela.UpdUserName);
}
objgs_UserRelaEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UpdUserName) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UpdUserName, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UpdUserName] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetUserRelaName(this clsgs_UserRelaEN objgs_UserRelaEN, string strUserRelaName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserRelaName, 50, congs_UserRela.UserRelaName);
}
objgs_UserRelaEN.UserRelaName = strUserRelaName; //UserRelaName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.UserRelaName) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.UserRelaName, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.UserRelaName] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetIdCurrEduCls(this clsgs_UserRelaEN objgs_UserRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_UserRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_UserRela.IdCurrEduCls);
}
objgs_UserRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.IdCurrEduCls) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetOrderNum(this clsgs_UserRelaEN objgs_UserRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_UserRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.OrderNum) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.OrderNum, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.OrderNum] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetXPosition(this clsgs_UserRelaEN objgs_UserRelaEN, float? fltXPosition, string strComparisonOp="")
	{
objgs_UserRelaEN.XPosition = fltXPosition; //X_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.XPosition) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.XPosition, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.XPosition] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_UserRelaEN SetYPosition(this clsgs_UserRelaEN objgs_UserRelaEN, float? fltYPosition, string strComparisonOp="")
	{
objgs_UserRelaEN.YPosition = fltYPosition; //Y_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_UserRelaEN.dicFldComparisonOp.ContainsKey(congs_UserRela.YPosition) == false)
{
objgs_UserRelaEN.dicFldComparisonOp.Add(congs_UserRela.YPosition, strComparisonOp);
}
else
{
objgs_UserRelaEN.dicFldComparisonOp[congs_UserRela.YPosition] = strComparisonOp;
}
}
return objgs_UserRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_UserRelaEN objgs_UserRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_UserRelaEN.CheckPropertyNew();
clsgs_UserRelaEN objgs_UserRelaCond = new clsgs_UserRelaEN();
string strCondition = objgs_UserRelaCond
.SetmId(objgs_UserRelaEN.mId, "<>")
.SetmId(objgs_UserRelaEN.mId, "=")
.GetCombineCondition();
objgs_UserRelaEN._IsCheckProperty = true;
bool bolIsExist = clsgs_UserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_UserRelaEN.Update();
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
 /// <param name = "objgs_UserRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_UserRelaEN objgs_UserRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_UserRelaEN objgs_UserRelaCond = new clsgs_UserRelaEN();
string strCondition = objgs_UserRelaCond
.SetmId(objgs_UserRela.mId, "=")
.GetCombineCondition();
objgs_UserRela._IsCheckProperty = true;
bool bolIsExist = clsgs_UserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_UserRela.mId = clsgs_UserRelaBL.GetFirstID_S(strCondition);
objgs_UserRela.UpdateWithCondition(strCondition);
}
else
{
objgs_UserRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_UserRelaEN objgs_UserRelaEN)
{
 if (objgs_UserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_UserRelaBL.gs_UserRelaDA.UpdateBySql2(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_UserRelaEN objgs_UserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_UserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_UserRelaBL.gs_UserRelaDA.UpdateBySql2(objgs_UserRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_UserRelaEN objgs_UserRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_UserRelaBL.gs_UserRelaDA.UpdateBySqlWithCondition(objgs_UserRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_UserRelaEN objgs_UserRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_UserRelaBL.gs_UserRelaDA.UpdateBySqlWithConditionTransaction(objgs_UserRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
public static int Delete(this clsgs_UserRelaEN objgs_UserRelaEN)
{
try
{
int intRecNum = clsgs_UserRelaBL.gs_UserRelaDA.DelRecord(objgs_UserRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaENS">源对象</param>
 /// <param name = "objgs_UserRelaENT">目标对象</param>
 public static void CopyTo(this clsgs_UserRelaEN objgs_UserRelaENS, clsgs_UserRelaEN objgs_UserRelaENT)
{
try
{
objgs_UserRelaENT.mId = objgs_UserRelaENS.mId; //mId
objgs_UserRelaENT.UserId = objgs_UserRelaENS.UserId; //用户ID
objgs_UserRelaENT.UserRelaId = objgs_UserRelaENS.UserRelaId; //关系用户Id
objgs_UserRelaENT.UpdUser = objgs_UserRelaENS.UpdUser; //修改人
objgs_UserRelaENT.UpdDate = objgs_UserRelaENS.UpdDate; //修改日期
objgs_UserRelaENT.Memo = objgs_UserRelaENS.Memo; //备注
objgs_UserRelaENT.UpdUserName = objgs_UserRelaENS.UpdUserName; //UpdUserName
objgs_UserRelaENT.UserRelaName = objgs_UserRelaENS.UserRelaName; //UserRelaName
objgs_UserRelaENT.IdCurrEduCls = objgs_UserRelaENS.IdCurrEduCls; //教学班流水号
objgs_UserRelaENT.OrderNum = objgs_UserRelaENS.OrderNum; //序号
objgs_UserRelaENT.XPosition = objgs_UserRelaENS.XPosition; //X_坐标
objgs_UserRelaENT.YPosition = objgs_UserRelaENS.YPosition; //Y_坐标
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
 /// <param name = "objgs_UserRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_UserRelaEN:objgs_UserRelaENT</returns>
 public static clsgs_UserRelaEN CopyTo(this clsgs_UserRelaEN objgs_UserRelaENS)
{
try
{
 clsgs_UserRelaEN objgs_UserRelaENT = new clsgs_UserRelaEN()
{
mId = objgs_UserRelaENS.mId, //mId
UserId = objgs_UserRelaENS.UserId, //用户ID
UserRelaId = objgs_UserRelaENS.UserRelaId, //关系用户Id
UpdUser = objgs_UserRelaENS.UpdUser, //修改人
UpdDate = objgs_UserRelaENS.UpdDate, //修改日期
Memo = objgs_UserRelaENS.Memo, //备注
UpdUserName = objgs_UserRelaENS.UpdUserName, //UpdUserName
UserRelaName = objgs_UserRelaENS.UserRelaName, //UserRelaName
IdCurrEduCls = objgs_UserRelaENS.IdCurrEduCls, //教学班流水号
OrderNum = objgs_UserRelaENS.OrderNum, //序号
XPosition = objgs_UserRelaENS.XPosition, //X_坐标
YPosition = objgs_UserRelaENS.YPosition, //Y_坐标
};
 return objgs_UserRelaENT;
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
public static void CheckPropertyNew(this clsgs_UserRelaEN objgs_UserRelaEN)
{
 clsgs_UserRelaBL.gs_UserRelaDA.CheckPropertyNew(objgs_UserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_UserRelaEN objgs_UserRelaEN)
{
 clsgs_UserRelaBL.gs_UserRelaDA.CheckProperty4Condition(objgs_UserRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_UserRelaEN objgs_UserRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.mId) == true)
{
string strComparisonOpmId = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_UserRela.mId, objgs_UserRelaCond.mId, strComparisonOpmId);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UserId) == true)
{
string strComparisonOpUserId = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UserId, objgs_UserRelaCond.UserId, strComparisonOpUserId);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UserRelaId) == true)
{
string strComparisonOpUserRelaId = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UserRelaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UserRelaId, objgs_UserRelaCond.UserRelaId, strComparisonOpUserRelaId);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UpdUser, objgs_UserRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UpdDate, objgs_UserRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.Memo) == true)
{
string strComparisonOpMemo = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.Memo, objgs_UserRelaCond.Memo, strComparisonOpMemo);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UpdUserName, objgs_UserRelaCond.UpdUserName, strComparisonOpUpdUserName);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.UserRelaName) == true)
{
string strComparisonOpUserRelaName = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.UserRelaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.UserRelaName, objgs_UserRelaCond.UserRelaName, strComparisonOpUserRelaName);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_UserRela.IdCurrEduCls, objgs_UserRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_UserRela.OrderNum, objgs_UserRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.XPosition) == true)
{
string strComparisonOpXPosition = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.XPosition];
strWhereCond += string.Format(" And {0} {2} {1}", congs_UserRela.XPosition, objgs_UserRelaCond.XPosition, strComparisonOpXPosition);
}
if (objgs_UserRelaCond.IsUpdated(congs_UserRela.YPosition) == true)
{
string strComparisonOpYPosition = objgs_UserRelaCond.dicFldComparisonOp[congs_UserRela.YPosition];
strWhereCond += string.Format(" And {0} {2} {1}", congs_UserRela.YPosition, objgs_UserRelaCond.YPosition, strComparisonOpYPosition);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_UserRela(用户关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_UserRelaEN objgs_UserRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_UserRelaEN == null) return true;
if (objgs_UserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_UserRelaEN.mId);
if (clsgs_UserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_UserRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_UserRelaEN.mId);
if (clsgs_UserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_UserRela(用户关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_UserRelaEN objgs_UserRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_UserRelaEN == null) return "";
if (objgs_UserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_UserRelaEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_UserRelaEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_UserRelaEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_UserRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户关系(gs_UserRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_UserRelaBL
{
public static RelatedActions_gs_UserRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_UserRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_UserRelaDA gs_UserRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_UserRelaDA();
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
 public clsgs_UserRelaBL()
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
if (string.IsNullOrEmpty(clsgs_UserRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_UserRelaEN._ConnectString);
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
public static DataTable GetDataTable_gs_UserRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_UserRelaDA.GetDataTable_gs_UserRela(strWhereCond);
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
objDT = gs_UserRelaDA.GetDataTable(strWhereCond);
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
objDT = gs_UserRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_UserRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_UserRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_UserRelaDA.GetDataTable_Top(objTopPara);
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
objDT = gs_UserRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_UserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_UserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_UserRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
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
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_UserRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsgs_UserRelaEN._CurrTabName, strIdCurrEduCls);
List<clsgs_UserRelaEN> arrgs_UserRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_UserRelaEN> arrgs_UserRelaObjLst_Sel =
arrgs_UserRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_UserRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_UserRelaEN> GetObjLst(string strWhereCond)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
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
public static List<clsgs_UserRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_UserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_UserRelaEN> GetSubObjLstCache(clsgs_UserRelaEN objgs_UserRelaCond)
{
 string strIdCurrEduCls = objgs_UserRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_UserRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_UserRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_UserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_UserRela.AttributeName)
{
if (objgs_UserRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_UserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_UserRelaCond[strFldName].ToString());
}
else
{
if (objgs_UserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_UserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_UserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_UserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_UserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_UserRelaCond[strFldName]));
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
public static List<clsgs_UserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
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
public static List<clsgs_UserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
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
List<clsgs_UserRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_UserRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_UserRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_UserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
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
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
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
public static List<clsgs_UserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_UserRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_UserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
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
public static List<clsgs_UserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_UserRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_UserRelaEN> arrObjLst = new List<clsgs_UserRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_UserRelaEN objgs_UserRelaEN = new clsgs_UserRelaEN();
try
{
objgs_UserRelaEN.mId = Int32.Parse(objRow[congs_UserRela.mId].ToString().Trim()); //mId
objgs_UserRelaEN.UserId = objRow[congs_UserRela.UserId] == DBNull.Value ? null : objRow[congs_UserRela.UserId].ToString().Trim(); //用户ID
objgs_UserRelaEN.UserRelaId = objRow[congs_UserRela.UserRelaId] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaId].ToString().Trim(); //关系用户Id
objgs_UserRelaEN.UpdUser = objRow[congs_UserRela.UpdUser] == DBNull.Value ? null : objRow[congs_UserRela.UpdUser].ToString().Trim(); //修改人
objgs_UserRelaEN.UpdDate = objRow[congs_UserRela.UpdDate] == DBNull.Value ? null : objRow[congs_UserRela.UpdDate].ToString().Trim(); //修改日期
objgs_UserRelaEN.Memo = objRow[congs_UserRela.Memo] == DBNull.Value ? null : objRow[congs_UserRela.Memo].ToString().Trim(); //备注
objgs_UserRelaEN.UpdUserName = objRow[congs_UserRela.UpdUserName] == DBNull.Value ? null : objRow[congs_UserRela.UpdUserName].ToString().Trim(); //UpdUserName
objgs_UserRelaEN.UserRelaName = objRow[congs_UserRela.UserRelaName] == DBNull.Value ? null : objRow[congs_UserRela.UserRelaName].ToString().Trim(); //UserRelaName
objgs_UserRelaEN.IdCurrEduCls = objRow[congs_UserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_UserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_UserRelaEN.OrderNum = objRow[congs_UserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_UserRela.OrderNum].ToString().Trim()); //序号
objgs_UserRelaEN.XPosition = objRow[congs_UserRela.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.XPosition].ToString().Trim()); //X_坐标
objgs_UserRelaEN.YPosition = objRow[congs_UserRela.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_UserRela.YPosition].ToString().Trim()); //Y_坐标
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_UserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_UserRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_UserRela(ref clsgs_UserRelaEN objgs_UserRelaEN)
{
bool bolResult = gs_UserRelaDA.Getgs_UserRela(ref objgs_UserRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_UserRelaEN GetObjBymId(long lngmId)
{
clsgs_UserRelaEN objgs_UserRelaEN = gs_UserRelaDA.GetObjBymId(lngmId);
return objgs_UserRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_UserRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_UserRelaEN objgs_UserRelaEN = gs_UserRelaDA.GetFirstObj(strWhereCond);
 return objgs_UserRelaEN;
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
public static clsgs_UserRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_UserRelaEN objgs_UserRelaEN = gs_UserRelaDA.GetObjByDataRow(objRow);
 return objgs_UserRelaEN;
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
public static clsgs_UserRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_UserRelaEN objgs_UserRelaEN = gs_UserRelaDA.GetObjByDataRow(objRow);
 return objgs_UserRelaEN;
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
 /// <param name = "lstgs_UserRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_UserRelaEN GetObjBymIdFromList(long lngmId, List<clsgs_UserRelaEN> lstgs_UserRelaObjLst)
{
foreach (clsgs_UserRelaEN objgs_UserRelaEN in lstgs_UserRelaObjLst)
{
if (objgs_UserRelaEN.mId == lngmId)
{
return objgs_UserRelaEN;
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
 lngmId = new clsgs_UserRelaDA().GetFirstID(strWhereCond);
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
 arrList = gs_UserRelaDA.GetID(strWhereCond);
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
bool bolIsExist = gs_UserRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_UserRelaDA.IsExist(lngmId);
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
 bolIsExist = clsgs_UserRelaDA.IsExistTable();
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
 bolIsExist = gs_UserRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_UserRelaEN objgs_UserRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_UserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_UserRelaBL.AddNewRecordBySql2)", objgs_UserRelaEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_UserRelaDA.AddNewRecordBySQL2(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_UserRelaEN objgs_UserRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_UserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_UserRelaBL.AddNewRecordBySql2WithReturnKey)", objgs_UserRelaEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_UserRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_UserRelaEN objgs_UserRelaEN)
{
try
{
bool bolResult = gs_UserRelaDA.Update(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_UserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_UserRelaEN objgs_UserRelaEN)
{
 if (objgs_UserRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_UserRelaDA.UpdateBySql2(objgs_UserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_UserRelaBL.ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
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
 clsgs_UserRelaEN objgs_UserRelaEN = clsgs_UserRelaBL.GetObjBymId(lngmId);

if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(objgs_UserRelaEN.mId, "SetUpdDate");
}
if (objgs_UserRelaEN != null)
{
int intRecNum = gs_UserRelaDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);
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
objSQL = clsgs_UserRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_UserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_UserRela.mId,
//lngmId);
//        clsgs_UserRelaBL.Delgs_UserRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_UserRelaBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_UserRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsgs_UserRelaBL.relatedActions != null)
{
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_UserRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int Delgs_UserRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_UserRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsgs_UserRelaEN objgs_UserRelaEN = clsgs_UserRelaBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = gs_UserRelaDA.Delgs_UserRela(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_UserRelaEN.IdCurrEduCls);
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
public static int Delgs_UserRelasByCond(string strWhereCond)
{
try
{
if (clsgs_UserRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_UserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(congs_UserRela.IdCurrEduCls, strWhereCond);
int intRecNum = gs_UserRelaDA.Delgs_UserRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_UserRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_UserRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_UserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_UserRelaBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_UserRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objgs_UserRelaENS">源对象</param>
 /// <param name = "objgs_UserRelaENT">目标对象</param>
 public static void CopyTo(clsgs_UserRelaEN objgs_UserRelaENS, clsgs_UserRelaEN objgs_UserRelaENT)
{
try
{
objgs_UserRelaENT.mId = objgs_UserRelaENS.mId; //mId
objgs_UserRelaENT.UserId = objgs_UserRelaENS.UserId; //用户ID
objgs_UserRelaENT.UserRelaId = objgs_UserRelaENS.UserRelaId; //关系用户Id
objgs_UserRelaENT.UpdUser = objgs_UserRelaENS.UpdUser; //修改人
objgs_UserRelaENT.UpdDate = objgs_UserRelaENS.UpdDate; //修改日期
objgs_UserRelaENT.Memo = objgs_UserRelaENS.Memo; //备注
objgs_UserRelaENT.UpdUserName = objgs_UserRelaENS.UpdUserName; //UpdUserName
objgs_UserRelaENT.UserRelaName = objgs_UserRelaENS.UserRelaName; //UserRelaName
objgs_UserRelaENT.IdCurrEduCls = objgs_UserRelaENS.IdCurrEduCls; //教学班流水号
objgs_UserRelaENT.OrderNum = objgs_UserRelaENS.OrderNum; //序号
objgs_UserRelaENT.XPosition = objgs_UserRelaENS.XPosition; //X_坐标
objgs_UserRelaENT.YPosition = objgs_UserRelaENS.YPosition; //Y_坐标
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
 /// <param name = "objgs_UserRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_UserRelaEN objgs_UserRelaEN)
{
try
{
objgs_UserRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_UserRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_UserRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.mId = objgs_UserRelaEN.mId; //mId
}
if (arrFldSet.Contains(congs_UserRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UserId = objgs_UserRelaEN.UserId == "[null]" ? null :  objgs_UserRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(congs_UserRela.UserRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UserRelaId = objgs_UserRelaEN.UserRelaId == "[null]" ? null :  objgs_UserRelaEN.UserRelaId; //关系用户Id
}
if (arrFldSet.Contains(congs_UserRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UpdUser = objgs_UserRelaEN.UpdUser == "[null]" ? null :  objgs_UserRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_UserRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UpdDate = objgs_UserRelaEN.UpdDate == "[null]" ? null :  objgs_UserRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_UserRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.Memo = objgs_UserRelaEN.Memo == "[null]" ? null :  objgs_UserRelaEN.Memo; //备注
}
if (arrFldSet.Contains(congs_UserRela.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UpdUserName = objgs_UserRelaEN.UpdUserName == "[null]" ? null :  objgs_UserRelaEN.UpdUserName; //UpdUserName
}
if (arrFldSet.Contains(congs_UserRela.UserRelaName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.UserRelaName = objgs_UserRelaEN.UserRelaName == "[null]" ? null :  objgs_UserRelaEN.UserRelaName; //UserRelaName
}
if (arrFldSet.Contains(congs_UserRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.IdCurrEduCls = objgs_UserRelaEN.IdCurrEduCls == "[null]" ? null :  objgs_UserRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_UserRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.OrderNum = objgs_UserRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_UserRela.XPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.XPosition = objgs_UserRelaEN.XPosition; //X_坐标
}
if (arrFldSet.Contains(congs_UserRela.YPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_UserRelaEN.YPosition = objgs_UserRelaEN.YPosition; //Y_坐标
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
 /// <param name = "objgs_UserRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_UserRelaEN objgs_UserRelaEN)
{
try
{
if (objgs_UserRelaEN.UserId == "[null]") objgs_UserRelaEN.UserId = null; //用户ID
if (objgs_UserRelaEN.UserRelaId == "[null]") objgs_UserRelaEN.UserRelaId = null; //关系用户Id
if (objgs_UserRelaEN.UpdUser == "[null]") objgs_UserRelaEN.UpdUser = null; //修改人
if (objgs_UserRelaEN.UpdDate == "[null]") objgs_UserRelaEN.UpdDate = null; //修改日期
if (objgs_UserRelaEN.Memo == "[null]") objgs_UserRelaEN.Memo = null; //备注
if (objgs_UserRelaEN.UpdUserName == "[null]") objgs_UserRelaEN.UpdUserName = null; //UpdUserName
if (objgs_UserRelaEN.UserRelaName == "[null]") objgs_UserRelaEN.UserRelaName = null; //UserRelaName
if (objgs_UserRelaEN.IdCurrEduCls == "[null]") objgs_UserRelaEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsgs_UserRelaEN objgs_UserRelaEN)
{
 gs_UserRelaDA.CheckPropertyNew(objgs_UserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_UserRelaEN objgs_UserRelaEN)
{
 gs_UserRelaDA.CheckProperty4Condition(objgs_UserRelaEN);
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
if (clsgs_UserRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_UserRelaBL没有刷新缓存机制(clsgs_UserRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_UserRelaObjLstCache == null)
//{
//arrgs_UserRelaObjLstCache = gs_UserRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_UserRelaEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_UserRelaEN._CurrTabName, strIdCurrEduCls);
List<clsgs_UserRelaEN> arrgs_UserRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_UserRelaEN> arrgs_UserRelaObjLst_Sel =
arrgs_UserRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_UserRelaObjLst_Sel.Count() == 0)
{
   clsgs_UserRelaEN obj = clsgs_UserRelaBL.GetObjBymId(lngmId);
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
return arrgs_UserRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_UserRelaEN> GetAllgs_UserRelaObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsgs_UserRelaEN> arrgs_UserRelaObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrgs_UserRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_UserRelaEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_UserRelaEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsgs_UserRelaEN> arrgs_UserRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_UserRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsgs_UserRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_UserRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_UserRelaEN._RefreshTimeLst.Count == 0) return "";
return clsgs_UserRelaEN._RefreshTimeLst[clsgs_UserRelaEN._RefreshTimeLst.Count - 1];
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
if (clsgs_UserRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_UserRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_UserRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_UserRelaBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_UserRela(用户关系)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_UserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_UserRelaEN objgs_UserRelaEN)
{
//检测记录是否存在
string strResult = gs_UserRelaDA.GetUniCondStr(objgs_UserRelaEN);
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
if (strInFldName != congs_UserRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_UserRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_UserRela.AttributeName));
throw new Exception(strMsg);
}
var objgs_UserRela = clsgs_UserRelaBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objgs_UserRela == null) return "";
return objgs_UserRela[strOutFldName].ToString();
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
int intRecCount = clsgs_UserRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_UserRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_UserRelaDA.GetRecCount();
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
int intRecCount = clsgs_UserRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_UserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_UserRelaEN objgs_UserRelaCond)
{
 string strIdCurrEduCls = objgs_UserRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_UserRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_UserRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_UserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_UserRela.AttributeName)
{
if (objgs_UserRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_UserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_UserRelaCond[strFldName].ToString());
}
else
{
if (objgs_UserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_UserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_UserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_UserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_UserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_UserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_UserRelaCond[strFldName]));
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
 List<string> arrList = clsgs_UserRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_UserRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_UserRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_UserRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_UserRelaDA.SetFldValue(clsgs_UserRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_UserRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_UserRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_UserRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_UserRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_UserRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**关系用户Id*/ 
 strCreateTabCode.Append(" UserRelaId varchar(50) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**UpdUserName*/ 
 strCreateTabCode.Append(" UpdUserName varchar(20) Null, "); 
 // /**UserRelaName*/ 
 strCreateTabCode.Append(" UserRelaName varchar(50) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**X_坐标*/ 
 strCreateTabCode.Append(" XPosition float Null, "); 
 // /**Y_坐标*/ 
 strCreateTabCode.Append(" YPosition float Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户关系(gs_UserRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_UserRela : clsCommFun4BLV2
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
clsgs_UserRelaBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}