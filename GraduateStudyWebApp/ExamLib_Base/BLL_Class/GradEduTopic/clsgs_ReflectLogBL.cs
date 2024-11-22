
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ReflectLogBL
 表名:gs_ReflectLog(01120702)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:21
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
public static class  clsgs_ReflectLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ReflectLogEN GetObj(this K_mId_gs_ReflectLog myKey)
{
clsgs_ReflectLogEN objgs_ReflectLogEN = clsgs_ReflectLogBL.gs_ReflectLogDA.GetObjBymId(myKey.Value);
return objgs_ReflectLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_ReflectLogEN objgs_ReflectLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ReflectLogEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ReflectLogBL.AddNewRecord)", objgs_ReflectLogEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_ReflectLogBL.gs_ReflectLogDA.AddNewRecordBySQL2(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_ReflectLogEN objgs_ReflectLogEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_ReflectLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_ReflectLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}])已经存在,不能重复!", objgs_ReflectLogEN.mId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_ReflectLogEN.AddNewRecord();
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_ReflectLogEN objgs_ReflectLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ReflectLogEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ReflectLogBL.AddNewRecordWithReturnKey)", objgs_ReflectLogEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_ReflectLogBL.gs_ReflectLogDA.AddNewRecordBySQL2WithReturnKey(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetmId(this clsgs_ReflectLogEN objgs_ReflectLogEN, long lngmId, string strComparisonOp="")
	{
objgs_ReflectLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.mId) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.mId, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.mId] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetUserId(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, congs_ReflectLog.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, congs_ReflectLog.UserId);
}
objgs_ReflectLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.UserId) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.UserId, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.UserId] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetIdCurrEduCls(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, congs_ReflectLog.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_ReflectLog.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_ReflectLog.IdCurrEduCls);
}
objgs_ReflectLogEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.IdCurrEduCls) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetTopicId(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_ReflectLog.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_ReflectLog.TopicId);
}
objgs_ReflectLogEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.TopicId) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.TopicId, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.TopicId] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetReflectLogName(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strReflectLogName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReflectLogName, 1000, congs_ReflectLog.ReflectLogName);
}
objgs_ReflectLogEN.ReflectLogName = strReflectLogName; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.ReflectLogName) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.ReflectLogName, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.ReflectLogName] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetReflectLogContent(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strReflectLogContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReflectLogContent, 5000, congs_ReflectLog.ReflectLogContent);
}
objgs_ReflectLogEN.ReflectLogContent = strReflectLogContent; //内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.ReflectLogContent) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.ReflectLogContent, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.ReflectLogContent] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetUpdUser(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_ReflectLog.UpdUser);
}
objgs_ReflectLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.UpdUser) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.UpdUser, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.UpdUser] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetCreateDate(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, congs_ReflectLog.CreateDate);
}
objgs_ReflectLogEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.CreateDate) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.CreateDate, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.CreateDate] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetUpdDate(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_ReflectLog.UpdDate);
}
objgs_ReflectLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.UpdDate) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.UpdDate, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.UpdDate] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ReflectLogEN SetMemo(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_ReflectLog.Memo);
}
objgs_ReflectLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ReflectLogEN.dicFldComparisonOp.ContainsKey(congs_ReflectLog.Memo) == false)
{
objgs_ReflectLogEN.dicFldComparisonOp.Add(congs_ReflectLog.Memo, strComparisonOp);
}
else
{
objgs_ReflectLogEN.dicFldComparisonOp[congs_ReflectLog.Memo] = strComparisonOp;
}
}
return objgs_ReflectLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_ReflectLogEN.CheckPropertyNew();
clsgs_ReflectLogEN objgs_ReflectLogCond = new clsgs_ReflectLogEN();
string strCondition = objgs_ReflectLogCond
.SetmId(objgs_ReflectLogEN.mId, "<>")
.SetmId(objgs_ReflectLogEN.mId, "=")
.GetCombineCondition();
objgs_ReflectLogEN._IsCheckProperty = true;
bool bolIsExist = clsgs_ReflectLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_ReflectLogEN.Update();
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
 /// <param name = "objgs_ReflectLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_ReflectLogEN objgs_ReflectLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_ReflectLogEN objgs_ReflectLogCond = new clsgs_ReflectLogEN();
string strCondition = objgs_ReflectLogCond
.SetmId(objgs_ReflectLog.mId, "=")
.GetCombineCondition();
objgs_ReflectLog._IsCheckProperty = true;
bool bolIsExist = clsgs_ReflectLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_ReflectLog.mId = clsgs_ReflectLogBL.GetFirstID_S(strCondition);
objgs_ReflectLog.UpdateWithCondition(strCondition);
}
else
{
objgs_ReflectLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 if (objgs_ReflectLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ReflectLogBL.gs_ReflectLogDA.UpdateBySql2(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ReflectLogEN objgs_ReflectLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_ReflectLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ReflectLogBL.gs_ReflectLogDA.UpdateBySql2(objgs_ReflectLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_ReflectLogBL.gs_ReflectLogDA.UpdateBySqlWithCondition(objgs_ReflectLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ReflectLogEN objgs_ReflectLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_ReflectLogBL.gs_ReflectLogDA.UpdateBySqlWithConditionTransaction(objgs_ReflectLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
public static int Delete(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
try
{
int intRecNum = clsgs_ReflectLogBL.gs_ReflectLogDA.DelRecord(objgs_ReflectLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogENS">源对象</param>
 /// <param name = "objgs_ReflectLogENT">目标对象</param>
 public static void CopyTo(this clsgs_ReflectLogEN objgs_ReflectLogENS, clsgs_ReflectLogEN objgs_ReflectLogENT)
{
try
{
objgs_ReflectLogENT.mId = objgs_ReflectLogENS.mId; //mId
objgs_ReflectLogENT.UserId = objgs_ReflectLogENS.UserId; //用户ID
objgs_ReflectLogENT.IdCurrEduCls = objgs_ReflectLogENS.IdCurrEduCls; //教学班流水号
objgs_ReflectLogENT.TopicId = objgs_ReflectLogENS.TopicId; //主题Id
objgs_ReflectLogENT.ReflectLogName = objgs_ReflectLogENS.ReflectLogName; //标题
objgs_ReflectLogENT.ReflectLogContent = objgs_ReflectLogENS.ReflectLogContent; //内容
objgs_ReflectLogENT.UpdUser = objgs_ReflectLogENS.UpdUser; //修改人
objgs_ReflectLogENT.CreateDate = objgs_ReflectLogENS.CreateDate; //建立日期
objgs_ReflectLogENT.UpdDate = objgs_ReflectLogENS.UpdDate; //修改日期
objgs_ReflectLogENT.Memo = objgs_ReflectLogENS.Memo; //备注
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
 /// <param name = "objgs_ReflectLogENS">源对象</param>
 /// <returns>目标对象=>clsgs_ReflectLogEN:objgs_ReflectLogENT</returns>
 public static clsgs_ReflectLogEN CopyTo(this clsgs_ReflectLogEN objgs_ReflectLogENS)
{
try
{
 clsgs_ReflectLogEN objgs_ReflectLogENT = new clsgs_ReflectLogEN()
{
mId = objgs_ReflectLogENS.mId, //mId
UserId = objgs_ReflectLogENS.UserId, //用户ID
IdCurrEduCls = objgs_ReflectLogENS.IdCurrEduCls, //教学班流水号
TopicId = objgs_ReflectLogENS.TopicId, //主题Id
ReflectLogName = objgs_ReflectLogENS.ReflectLogName, //标题
ReflectLogContent = objgs_ReflectLogENS.ReflectLogContent, //内容
UpdUser = objgs_ReflectLogENS.UpdUser, //修改人
CreateDate = objgs_ReflectLogENS.CreateDate, //建立日期
UpdDate = objgs_ReflectLogENS.UpdDate, //修改日期
Memo = objgs_ReflectLogENS.Memo, //备注
};
 return objgs_ReflectLogENT;
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
public static void CheckPropertyNew(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 clsgs_ReflectLogBL.gs_ReflectLogDA.CheckPropertyNew(objgs_ReflectLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 clsgs_ReflectLogBL.gs_ReflectLogDA.CheckProperty4Condition(objgs_ReflectLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_ReflectLogEN objgs_ReflectLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.mId) == true)
{
string strComparisonOpmId = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ReflectLog.mId, objgs_ReflectLogCond.mId, strComparisonOpmId);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.UserId) == true)
{
string strComparisonOpUserId = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.UserId, objgs_ReflectLogCond.UserId, strComparisonOpUserId);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.IdCurrEduCls, objgs_ReflectLogCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.TopicId) == true)
{
string strComparisonOpTopicId = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.TopicId, objgs_ReflectLogCond.TopicId, strComparisonOpTopicId);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.ReflectLogName) == true)
{
string strComparisonOpReflectLogName = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.ReflectLogName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.ReflectLogName, objgs_ReflectLogCond.ReflectLogName, strComparisonOpReflectLogName);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.ReflectLogContent) == true)
{
string strComparisonOpReflectLogContent = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.ReflectLogContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.ReflectLogContent, objgs_ReflectLogCond.ReflectLogContent, strComparisonOpReflectLogContent);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.UpdUser, objgs_ReflectLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.CreateDate) == true)
{
string strComparisonOpCreateDate = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.CreateDate, objgs_ReflectLogCond.CreateDate, strComparisonOpCreateDate);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.UpdDate, objgs_ReflectLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_ReflectLogCond.IsUpdated(congs_ReflectLog.Memo) == true)
{
string strComparisonOpMemo = objgs_ReflectLogCond.dicFldComparisonOp[congs_ReflectLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ReflectLog.Memo, objgs_ReflectLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_ReflectLog(反思日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_ReflectLogEN == null) return true;
if (objgs_ReflectLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ReflectLogEN.mId);
if (clsgs_ReflectLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_ReflectLogEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ReflectLogEN.mId);
if (clsgs_ReflectLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_ReflectLog(反思日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_ReflectLogEN objgs_ReflectLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_ReflectLogEN == null) return "";
if (objgs_ReflectLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ReflectLogEN.mId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_ReflectLogEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objgs_ReflectLogEN.mId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_ReflectLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 反思日志(gs_ReflectLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_ReflectLogBL
{
public static RelatedActions_gs_ReflectLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_ReflectLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_ReflectLogDA gs_ReflectLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_ReflectLogDA();
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
 public clsgs_ReflectLogBL()
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
if (string.IsNullOrEmpty(clsgs_ReflectLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ReflectLogEN._ConnectString);
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
public static DataTable GetDataTable_gs_ReflectLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_ReflectLogDA.GetDataTable_gs_ReflectLog(strWhereCond);
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
objDT = gs_ReflectLogDA.GetDataTable(strWhereCond);
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
objDT = gs_ReflectLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_ReflectLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_ReflectLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_ReflectLogDA.GetDataTable_Top(objTopPara);
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
objDT = gs_ReflectLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_ReflectLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_ReflectLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_ReflectLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
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
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_ReflectLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsgs_ReflectLogEN._CurrTabName);
List<clsgs_ReflectLogEN> arrgs_ReflectLogObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ReflectLogEN> arrgs_ReflectLogObjLst_Sel =
arrgs_ReflectLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_ReflectLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ReflectLogEN> GetObjLst(string strWhereCond)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
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
public static List<clsgs_ReflectLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_ReflectLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_ReflectLogEN> GetSubObjLstCache(clsgs_ReflectLogEN objgs_ReflectLogCond)
{
List<clsgs_ReflectLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ReflectLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ReflectLog.AttributeName)
{
if (objgs_ReflectLogCond.IsUpdated(strFldName) == false) continue;
if (objgs_ReflectLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ReflectLogCond[strFldName].ToString());
}
else
{
if (objgs_ReflectLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ReflectLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ReflectLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ReflectLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ReflectLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ReflectLogCond[strFldName]));
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
public static List<clsgs_ReflectLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
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
public static List<clsgs_ReflectLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
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
List<clsgs_ReflectLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_ReflectLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ReflectLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_ReflectLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
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
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
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
public static List<clsgs_ReflectLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_ReflectLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_ReflectLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
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
public static List<clsgs_ReflectLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ReflectLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_ReflectLogEN> arrObjLst = new List<clsgs_ReflectLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ReflectLogEN objgs_ReflectLogEN = new clsgs_ReflectLogEN();
try
{
objgs_ReflectLogEN.mId = Int32.Parse(objRow[congs_ReflectLog.mId].ToString().Trim()); //mId
objgs_ReflectLogEN.UserId = objRow[congs_ReflectLog.UserId].ToString().Trim(); //用户ID
objgs_ReflectLogEN.IdCurrEduCls = objRow[congs_ReflectLog.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ReflectLogEN.TopicId = objRow[congs_ReflectLog.TopicId] == DBNull.Value ? null : objRow[congs_ReflectLog.TopicId].ToString().Trim(); //主题Id
objgs_ReflectLogEN.ReflectLogName = objRow[congs_ReflectLog.ReflectLogName] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogName].ToString().Trim(); //标题
objgs_ReflectLogEN.ReflectLogContent = objRow[congs_ReflectLog.ReflectLogContent] == DBNull.Value ? null : objRow[congs_ReflectLog.ReflectLogContent].ToString().Trim(); //内容
objgs_ReflectLogEN.UpdUser = objRow[congs_ReflectLog.UpdUser] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdUser].ToString().Trim(); //修改人
objgs_ReflectLogEN.CreateDate = objRow[congs_ReflectLog.CreateDate] == DBNull.Value ? null : objRow[congs_ReflectLog.CreateDate].ToString().Trim(); //建立日期
objgs_ReflectLogEN.UpdDate = objRow[congs_ReflectLog.UpdDate] == DBNull.Value ? null : objRow[congs_ReflectLog.UpdDate].ToString().Trim(); //修改日期
objgs_ReflectLogEN.Memo = objRow[congs_ReflectLog.Memo] == DBNull.Value ? null : objRow[congs_ReflectLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ReflectLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ReflectLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_ReflectLog(ref clsgs_ReflectLogEN objgs_ReflectLogEN)
{
bool bolResult = gs_ReflectLogDA.Getgs_ReflectLog(ref objgs_ReflectLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ReflectLogEN GetObjBymId(long lngmId)
{
clsgs_ReflectLogEN objgs_ReflectLogEN = gs_ReflectLogDA.GetObjBymId(lngmId);
return objgs_ReflectLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_ReflectLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_ReflectLogEN objgs_ReflectLogEN = gs_ReflectLogDA.GetFirstObj(strWhereCond);
 return objgs_ReflectLogEN;
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
public static clsgs_ReflectLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_ReflectLogEN objgs_ReflectLogEN = gs_ReflectLogDA.GetObjByDataRow(objRow);
 return objgs_ReflectLogEN;
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
public static clsgs_ReflectLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_ReflectLogEN objgs_ReflectLogEN = gs_ReflectLogDA.GetObjByDataRow(objRow);
 return objgs_ReflectLogEN;
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
 /// <param name = "lstgs_ReflectLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ReflectLogEN GetObjBymIdFromList(long lngmId, List<clsgs_ReflectLogEN> lstgs_ReflectLogObjLst)
{
foreach (clsgs_ReflectLogEN objgs_ReflectLogEN in lstgs_ReflectLogObjLst)
{
if (objgs_ReflectLogEN.mId == lngmId)
{
return objgs_ReflectLogEN;
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
 lngmId = new clsgs_ReflectLogDA().GetFirstID(strWhereCond);
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
 arrList = gs_ReflectLogDA.GetID(strWhereCond);
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
bool bolIsExist = gs_ReflectLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_ReflectLogDA.IsExist(lngmId);
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
clsgs_ReflectLogEN objgs_ReflectLogEN = clsgs_ReflectLogBL.GetObjBymId(lngmId);
objgs_ReflectLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_ReflectLogEN.UpdUser = strOpUser;
return clsgs_ReflectLogBL.UpdateBySql2(objgs_ReflectLogEN);
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
 bolIsExist = clsgs_ReflectLogDA.IsExistTable();
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
 bolIsExist = gs_ReflectLogDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_ReflectLogEN objgs_ReflectLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ReflectLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ReflectLogBL.AddNewRecordBySql2)", objgs_ReflectLogEN.mId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_ReflectLogDA.AddNewRecordBySQL2(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_ReflectLogEN objgs_ReflectLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ReflectLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsgs_ReflectLogBL.AddNewRecordBySql2WithReturnKey)", objgs_ReflectLogEN.mId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_ReflectLogDA.AddNewRecordBySQL2WithReturnKey(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
try
{
bool bolResult = gs_ReflectLogDA.Update(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 /// <param name = "objgs_ReflectLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 if (objgs_ReflectLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_ReflectLogDA.UpdateBySql2(objgs_ReflectLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ReflectLogBL.ReFreshCache();

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
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
 clsgs_ReflectLogEN objgs_ReflectLogEN = clsgs_ReflectLogBL.GetObjBymId(lngmId);

if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(objgs_ReflectLogEN.mId, objgs_ReflectLogEN.UpdUser);
}
if (objgs_ReflectLogEN != null)
{
int intRecNum = gs_ReflectLogDA.DelRecord(lngmId);
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
objSQL = clsgs_ReflectLogDA.GetSpecSQLObj();
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
//删除与表:[gs_ReflectLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_ReflectLog.mId,
//lngmId);
//        clsgs_ReflectLogBL.Delgs_ReflectLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ReflectLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ReflectLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsgs_ReflectLogBL.relatedActions != null)
{
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_ReflectLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int Delgs_ReflectLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_ReflectLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_ReflectLogDA.Delgs_ReflectLog(arrmIdLst);
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
public static int Delgs_ReflectLogsByCond(string strWhereCond)
{
try
{
if (clsgs_ReflectLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_ReflectLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = gs_ReflectLogDA.Delgs_ReflectLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_ReflectLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ReflectLogDA.GetSpecSQLObj();
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
//删除与表:[gs_ReflectLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ReflectLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ReflectLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objgs_ReflectLogENS">源对象</param>
 /// <param name = "objgs_ReflectLogENT">目标对象</param>
 public static void CopyTo(clsgs_ReflectLogEN objgs_ReflectLogENS, clsgs_ReflectLogEN objgs_ReflectLogENT)
{
try
{
objgs_ReflectLogENT.mId = objgs_ReflectLogENS.mId; //mId
objgs_ReflectLogENT.UserId = objgs_ReflectLogENS.UserId; //用户ID
objgs_ReflectLogENT.IdCurrEduCls = objgs_ReflectLogENS.IdCurrEduCls; //教学班流水号
objgs_ReflectLogENT.TopicId = objgs_ReflectLogENS.TopicId; //主题Id
objgs_ReflectLogENT.ReflectLogName = objgs_ReflectLogENS.ReflectLogName; //标题
objgs_ReflectLogENT.ReflectLogContent = objgs_ReflectLogENS.ReflectLogContent; //内容
objgs_ReflectLogENT.UpdUser = objgs_ReflectLogENS.UpdUser; //修改人
objgs_ReflectLogENT.CreateDate = objgs_ReflectLogENS.CreateDate; //建立日期
objgs_ReflectLogENT.UpdDate = objgs_ReflectLogENS.UpdDate; //修改日期
objgs_ReflectLogENT.Memo = objgs_ReflectLogENS.Memo; //备注
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
 /// <param name = "objgs_ReflectLogEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
try
{
objgs_ReflectLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_ReflectLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_ReflectLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.mId = objgs_ReflectLogEN.mId; //mId
}
if (arrFldSet.Contains(congs_ReflectLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.UserId = objgs_ReflectLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(congs_ReflectLog.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.IdCurrEduCls = objgs_ReflectLogEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_ReflectLog.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.TopicId = objgs_ReflectLogEN.TopicId == "[null]" ? null :  objgs_ReflectLogEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_ReflectLog.ReflectLogName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.ReflectLogName = objgs_ReflectLogEN.ReflectLogName == "[null]" ? null :  objgs_ReflectLogEN.ReflectLogName; //标题
}
if (arrFldSet.Contains(congs_ReflectLog.ReflectLogContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.ReflectLogContent = objgs_ReflectLogEN.ReflectLogContent == "[null]" ? null :  objgs_ReflectLogEN.ReflectLogContent; //内容
}
if (arrFldSet.Contains(congs_ReflectLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.UpdUser = objgs_ReflectLogEN.UpdUser == "[null]" ? null :  objgs_ReflectLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_ReflectLog.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.CreateDate = objgs_ReflectLogEN.CreateDate == "[null]" ? null :  objgs_ReflectLogEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(congs_ReflectLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.UpdDate = objgs_ReflectLogEN.UpdDate == "[null]" ? null :  objgs_ReflectLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_ReflectLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ReflectLogEN.Memo = objgs_ReflectLogEN.Memo == "[null]" ? null :  objgs_ReflectLogEN.Memo; //备注
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
 /// <param name = "objgs_ReflectLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
try
{
if (objgs_ReflectLogEN.TopicId == "[null]") objgs_ReflectLogEN.TopicId = null; //主题Id
if (objgs_ReflectLogEN.ReflectLogName == "[null]") objgs_ReflectLogEN.ReflectLogName = null; //标题
if (objgs_ReflectLogEN.ReflectLogContent == "[null]") objgs_ReflectLogEN.ReflectLogContent = null; //内容
if (objgs_ReflectLogEN.UpdUser == "[null]") objgs_ReflectLogEN.UpdUser = null; //修改人
if (objgs_ReflectLogEN.CreateDate == "[null]") objgs_ReflectLogEN.CreateDate = null; //建立日期
if (objgs_ReflectLogEN.UpdDate == "[null]") objgs_ReflectLogEN.UpdDate = null; //修改日期
if (objgs_ReflectLogEN.Memo == "[null]") objgs_ReflectLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 gs_ReflectLogDA.CheckPropertyNew(objgs_ReflectLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
 gs_ReflectLogDA.CheckProperty4Condition(objgs_ReflectLogEN);
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
if (clsgs_ReflectLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ReflectLogBL没有刷新缓存机制(clsgs_ReflectLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_ReflectLogObjLstCache == null)
//{
//arrgs_ReflectLogObjLstCache = gs_ReflectLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ReflectLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_ReflectLogEN._CurrTabName);
List<clsgs_ReflectLogEN> arrgs_ReflectLogObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ReflectLogEN> arrgs_ReflectLogObjLst_Sel =
arrgs_ReflectLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_ReflectLogObjLst_Sel.Count() == 0)
{
   clsgs_ReflectLogEN obj = clsgs_ReflectLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_ReflectLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ReflectLogEN> GetAllgs_ReflectLogObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_ReflectLogEN> arrgs_ReflectLogObjLstCache = GetObjLstCache(); 
return arrgs_ReflectLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ReflectLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_ReflectLogEN._CurrTabName);
List<clsgs_ReflectLogEN> arrgs_ReflectLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_ReflectLogObjLstCache;
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
string strKey = string.Format("{0}", clsgs_ReflectLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ReflectLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_ReflectLogEN._RefreshTimeLst.Count == 0) return "";
return clsgs_ReflectLogEN._RefreshTimeLst[clsgs_ReflectLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_ReflectLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_ReflectLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ReflectLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_ReflectLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_ReflectLog(反思日志)
 /// 唯一性条件:mId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ReflectLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_ReflectLogEN objgs_ReflectLogEN)
{
//检测记录是否存在
string strResult = gs_ReflectLogDA.GetUniCondStr(objgs_ReflectLogEN);
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
if (strInFldName != congs_ReflectLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_ReflectLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_ReflectLog.AttributeName));
throw new Exception(strMsg);
}
var objgs_ReflectLog = clsgs_ReflectLogBL.GetObjBymIdCache(lngmId);
if (objgs_ReflectLog == null) return "";
return objgs_ReflectLog[strOutFldName].ToString();
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
int intRecCount = clsgs_ReflectLogDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_ReflectLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_ReflectLogDA.GetRecCount();
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
int intRecCount = clsgs_ReflectLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_ReflectLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_ReflectLogEN objgs_ReflectLogCond)
{
List<clsgs_ReflectLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ReflectLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ReflectLog.AttributeName)
{
if (objgs_ReflectLogCond.IsUpdated(strFldName) == false) continue;
if (objgs_ReflectLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ReflectLogCond[strFldName].ToString());
}
else
{
if (objgs_ReflectLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ReflectLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ReflectLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ReflectLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ReflectLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ReflectLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ReflectLogCond[strFldName]));
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
 List<string> arrList = clsgs_ReflectLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_ReflectLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_ReflectLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_ReflectLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ReflectLogDA.SetFldValue(clsgs_ReflectLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_ReflectLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ReflectLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ReflectLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ReflectLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_ReflectLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**标题*/ 
 strCreateTabCode.Append(" ReflectLogName varchar(1000) Null, "); 
 // /**内容*/ 
 strCreateTabCode.Append(" ReflectLogContent varchar(5000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" CreateDateSim varchar(20) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 反思日志(gs_ReflectLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_ReflectLog : clsCommFun4BL
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
clsgs_ReflectLogBL.ReFreshThisCache();
}
}

}