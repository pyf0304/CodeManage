
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreSummaryBL
 表名:SysScoreSummary(01120628)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:41
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
public static class  clsSysScoreSummaryBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysScoreSummaryEN GetObj(this K_mId_SysScoreSummary myKey)
{
clsSysScoreSummaryEN objSysScoreSummaryEN = clsSysScoreSummaryBL.SysScoreSummaryDA.GetObjBymId(myKey.Value);
return objSysScoreSummaryEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysScoreSummaryEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],用户ID = [{1}]的数据已经存在!(in clsSysScoreSummaryBL.AddNewRecord)", objSysScoreSummaryEN.mId,objSysScoreSummaryEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSysScoreSummaryBL.SysScoreSummaryDA.AddNewRecordBySQL2(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsNeedCheckUniqueness = true)
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
objSysScoreSummaryEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysScoreSummaryEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objSysScoreSummaryEN.mId, objSysScoreSummaryEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSysScoreSummaryEN.AddNewRecord();
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysScoreSummaryEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],用户ID = [{1}]的数据已经存在!(in clsSysScoreSummaryBL.AddNewRecordWithReturnKey)", objSysScoreSummaryEN.mId,objSysScoreSummaryEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsSysScoreSummaryBL.SysScoreSummaryDA.AddNewRecordBySQL2WithReturnKey(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetmId(this clsSysScoreSummaryEN objSysScoreSummaryEN, long lngmId, string strComparisonOp="")
	{
objSysScoreSummaryEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.mId) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.mId, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.mId] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetUserId(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conSysScoreSummary.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conSysScoreSummary.UserId);
}
objSysScoreSummaryEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.UserId) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.UserId, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.UserId] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetSchoolYear(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, conSysScoreSummary.SchoolYear);
}
objSysScoreSummaryEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.SchoolYear) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.SchoolYear, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.SchoolYear] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetUpdDate(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysScoreSummary.UpdDate);
}
objSysScoreSummaryEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.UpdDate) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.UpdDate, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.UpdDate] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetMemo(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysScoreSummary.Memo);
}
objSysScoreSummaryEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.Memo) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.Memo, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.Memo] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetScoreTypeId(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, conSysScoreSummary.ScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, conSysScoreSummary.ScoreTypeId);
}
objSysScoreSummaryEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.ScoreTypeId) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.ScoreTypeId, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.ScoreTypeId] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetUpdUser(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysScoreSummary.UpdUser);
}
objSysScoreSummaryEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.UpdUser) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.UpdUser, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.UpdUser] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetScore(this clsSysScoreSummaryEN objSysScoreSummaryEN, float? fltScore, string strComparisonOp="")
	{
objSysScoreSummaryEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.Score) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.Score, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.Score] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetIdCurrEduCls(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysScoreSummary.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysScoreSummary.IdCurrEduCls);
}
objSysScoreSummaryEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.IdCurrEduCls) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.IdCurrEduCls, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.IdCurrEduCls] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysScoreSummaryEN SetIsSubmit(this clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsSubmit, string strComparisonOp="")
	{
objSysScoreSummaryEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(conSysScoreSummary.IsSubmit) == false)
{
objSysScoreSummaryEN.dicFldComparisonOp.Add(conSysScoreSummary.IsSubmit, strComparisonOp);
}
else
{
objSysScoreSummaryEN.dicFldComparisonOp[conSysScoreSummary.IsSubmit] = strComparisonOp;
}
}
return objSysScoreSummaryEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysScoreSummaryEN.CheckPropertyNew();
clsSysScoreSummaryEN objSysScoreSummaryCond = new clsSysScoreSummaryEN();
string strCondition = objSysScoreSummaryCond
.SetmId(objSysScoreSummaryEN.mId, "<>")
.SetmId(objSysScoreSummaryEN.mId, "=")
.SetUserId(objSysScoreSummaryEN.UserId, "=")
.GetCombineCondition();
objSysScoreSummaryEN._IsCheckProperty = true;
bool bolIsExist = clsSysScoreSummaryBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysScoreSummaryEN.Update();
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
 /// <param name = "objSysScoreSummary">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysScoreSummaryEN objSysScoreSummary)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysScoreSummaryEN objSysScoreSummaryCond = new clsSysScoreSummaryEN();
string strCondition = objSysScoreSummaryCond
.SetmId(objSysScoreSummary.mId, "=")
.SetUserId(objSysScoreSummary.UserId, "=")
.GetCombineCondition();
objSysScoreSummary._IsCheckProperty = true;
bool bolIsExist = clsSysScoreSummaryBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysScoreSummary.mId = clsSysScoreSummaryBL.GetFirstID_S(strCondition);
objSysScoreSummary.UpdateWithCondition(strCondition);
}
else
{
objSysScoreSummary.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 if (objSysScoreSummaryEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysScoreSummaryBL.SysScoreSummaryDA.UpdateBySql2(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysScoreSummaryEN objSysScoreSummaryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysScoreSummaryEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysScoreSummaryBL.SysScoreSummaryDA.UpdateBySql2(objSysScoreSummaryEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strWhereCond)
{
try
{
bool bolResult = clsSysScoreSummaryBL.SysScoreSummaryDA.UpdateBySqlWithCondition(objSysScoreSummaryEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysScoreSummaryEN objSysScoreSummaryEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysScoreSummaryBL.SysScoreSummaryDA.UpdateBySqlWithConditionTransaction(objSysScoreSummaryEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
public static int Delete(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
try
{
int intRecNum = clsSysScoreSummaryBL.SysScoreSummaryDA.DelRecord(objSysScoreSummaryEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryENS">源对象</param>
 /// <param name = "objSysScoreSummaryENT">目标对象</param>
 public static void CopyTo(this clsSysScoreSummaryEN objSysScoreSummaryENS, clsSysScoreSummaryEN objSysScoreSummaryENT)
{
try
{
objSysScoreSummaryENT.mId = objSysScoreSummaryENS.mId; //mId
objSysScoreSummaryENT.UserId = objSysScoreSummaryENS.UserId; //用户ID
objSysScoreSummaryENT.SchoolYear = objSysScoreSummaryENS.SchoolYear; //学年
objSysScoreSummaryENT.UpdDate = objSysScoreSummaryENS.UpdDate; //修改日期
objSysScoreSummaryENT.Memo = objSysScoreSummaryENS.Memo; //备注
objSysScoreSummaryENT.ScoreTypeId = objSysScoreSummaryENS.ScoreTypeId; //分数类型Id
objSysScoreSummaryENT.UpdUser = objSysScoreSummaryENS.UpdUser; //修改人
objSysScoreSummaryENT.Score = objSysScoreSummaryENS.Score; //评分
objSysScoreSummaryENT.IdCurrEduCls = objSysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objSysScoreSummaryENT.IsSubmit = objSysScoreSummaryENS.IsSubmit; //是否提交
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
 /// <param name = "objSysScoreSummaryENS">源对象</param>
 /// <returns>目标对象=>clsSysScoreSummaryEN:objSysScoreSummaryENT</returns>
 public static clsSysScoreSummaryEN CopyTo(this clsSysScoreSummaryEN objSysScoreSummaryENS)
{
try
{
 clsSysScoreSummaryEN objSysScoreSummaryENT = new clsSysScoreSummaryEN()
{
mId = objSysScoreSummaryENS.mId, //mId
UserId = objSysScoreSummaryENS.UserId, //用户ID
SchoolYear = objSysScoreSummaryENS.SchoolYear, //学年
UpdDate = objSysScoreSummaryENS.UpdDate, //修改日期
Memo = objSysScoreSummaryENS.Memo, //备注
ScoreTypeId = objSysScoreSummaryENS.ScoreTypeId, //分数类型Id
UpdUser = objSysScoreSummaryENS.UpdUser, //修改人
Score = objSysScoreSummaryENS.Score, //评分
IdCurrEduCls = objSysScoreSummaryENS.IdCurrEduCls, //教学班流水号
IsSubmit = objSysScoreSummaryENS.IsSubmit, //是否提交
};
 return objSysScoreSummaryENT;
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
public static void CheckPropertyNew(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 clsSysScoreSummaryBL.SysScoreSummaryDA.CheckPropertyNew(objSysScoreSummaryEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 clsSysScoreSummaryBL.SysScoreSummaryDA.CheckProperty4Condition(objSysScoreSummaryEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysScoreSummaryEN objSysScoreSummaryCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.mId) == true)
{
string strComparisonOpmId = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSysScoreSummary.mId, objSysScoreSummaryCond.mId, strComparisonOpmId);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.UserId) == true)
{
string strComparisonOpUserId = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.UserId, objSysScoreSummaryCond.UserId, strComparisonOpUserId);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.SchoolYear, objSysScoreSummaryCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.UpdDate, objSysScoreSummaryCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.Memo) == true)
{
string strComparisonOpMemo = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.Memo, objSysScoreSummaryCond.Memo, strComparisonOpMemo);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.ScoreTypeId) == true)
{
string strComparisonOpScoreTypeId = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.ScoreTypeId, objSysScoreSummaryCond.ScoreTypeId, strComparisonOpScoreTypeId);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.UpdUser, objSysScoreSummaryCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.Score) == true)
{
string strComparisonOpScore = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conSysScoreSummary.Score, objSysScoreSummaryCond.Score, strComparisonOpScore);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysScoreSummaryCond.dicFldComparisonOp[conSysScoreSummary.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysScoreSummary.IdCurrEduCls, objSysScoreSummaryCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysScoreSummaryCond.IsUpdated(conSysScoreSummary.IsSubmit) == true)
{
if (objSysScoreSummaryCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSysScoreSummary.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSysScoreSummary.IsSubmit);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysScoreSummary(系统分数汇总表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysScoreSummaryEN == null) return true;
if (objSysScoreSummaryEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysScoreSummaryEN.UserId);
if (clsSysScoreSummaryBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysScoreSummaryEN.UserId);
if (clsSysScoreSummaryBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysScoreSummary(系统分数汇总表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysScoreSummaryEN objSysScoreSummaryEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysScoreSummaryEN == null) return "";
if (objSysScoreSummaryEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysScoreSummaryEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objSysScoreSummaryEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysScoreSummaryEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysScoreSummary
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 系统分数汇总表(SysScoreSummary)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysScoreSummaryBL
{
public static RelatedActions_SysScoreSummary relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysScoreSummaryDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysScoreSummaryDA SysScoreSummaryDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysScoreSummaryDA();
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
 public clsSysScoreSummaryBL()
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
if (string.IsNullOrEmpty(clsSysScoreSummaryEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysScoreSummaryEN._ConnectString);
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
public static DataTable GetDataTable_SysScoreSummary(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysScoreSummaryDA.GetDataTable_SysScoreSummary(strWhereCond);
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
objDT = SysScoreSummaryDA.GetDataTable(strWhereCond);
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
objDT = SysScoreSummaryDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysScoreSummaryDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysScoreSummaryDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysScoreSummaryDA.GetDataTable_Top(objTopPara);
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
objDT = SysScoreSummaryDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsSysScoreSummaryEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
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
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysScoreSummaryEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsSysScoreSummaryEN> arrSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysScoreSummaryEN> arrSysScoreSummaryObjLst_Sel =
arrSysScoreSummaryObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrSysScoreSummaryObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreSummaryEN> GetObjLst(string strWhereCond)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
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
public static List<clsSysScoreSummaryEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysScoreSummaryEN> GetSubObjLstCache(clsSysScoreSummaryEN objSysScoreSummaryCond)
{
 string strIdCurrEduCls = objSysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSysScoreSummaryBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysScoreSummary.AttributeName)
{
if (objSysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objSysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objSysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysScoreSummaryCond[strFldName]));
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
public static List<clsSysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
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
public static List<clsSysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
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
List<clsSysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreSummaryEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
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
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
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
public static List<clsSysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysScoreSummaryEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
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
public static List<clsSysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysScoreSummaryEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysScoreSummaryEN> arrObjLst = new List<clsSysScoreSummaryEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysScoreSummaryEN objSysScoreSummaryEN = new clsSysScoreSummaryEN();
try
{
objSysScoreSummaryEN.mId = Int32.Parse(objRow[conSysScoreSummary.mId].ToString().Trim()); //mId
objSysScoreSummaryEN.UserId = objRow[conSysScoreSummary.UserId].ToString().Trim(); //用户ID
objSysScoreSummaryEN.SchoolYear = objRow[conSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[conSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objSysScoreSummaryEN.UpdDate = objRow[conSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objSysScoreSummaryEN.Memo = objRow[conSysScoreSummary.Memo] == DBNull.Value ? null : objRow[conSysScoreSummary.Memo].ToString().Trim(); //备注
objSysScoreSummaryEN.ScoreTypeId = objRow[conSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[conSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objSysScoreSummaryEN.UpdUser = objRow[conSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[conSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objSysScoreSummaryEN.Score = objRow[conSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysScoreSummary.Score].ToString().Trim()); //评分
objSysScoreSummaryEN.IdCurrEduCls = objRow[conSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysScoreSummaryEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysScoreSummary(ref clsSysScoreSummaryEN objSysScoreSummaryEN)
{
bool bolResult = SysScoreSummaryDA.GetSysScoreSummary(ref objSysScoreSummaryEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysScoreSummaryEN GetObjBymId(long lngmId)
{
clsSysScoreSummaryEN objSysScoreSummaryEN = SysScoreSummaryDA.GetObjBymId(lngmId);
return objSysScoreSummaryEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysScoreSummaryEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysScoreSummaryEN objSysScoreSummaryEN = SysScoreSummaryDA.GetFirstObj(strWhereCond);
 return objSysScoreSummaryEN;
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
public static clsSysScoreSummaryEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysScoreSummaryEN objSysScoreSummaryEN = SysScoreSummaryDA.GetObjByDataRow(objRow);
 return objSysScoreSummaryEN;
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
public static clsSysScoreSummaryEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysScoreSummaryEN objSysScoreSummaryEN = SysScoreSummaryDA.GetObjByDataRow(objRow);
 return objSysScoreSummaryEN;
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
 /// <param name = "lstSysScoreSummaryObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysScoreSummaryEN GetObjBymIdFromList(long lngmId, List<clsSysScoreSummaryEN> lstSysScoreSummaryObjLst)
{
foreach (clsSysScoreSummaryEN objSysScoreSummaryEN in lstSysScoreSummaryObjLst)
{
if (objSysScoreSummaryEN.mId == lngmId)
{
return objSysScoreSummaryEN;
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
 lngmId = new clsSysScoreSummaryDA().GetFirstID(strWhereCond);
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
 arrList = SysScoreSummaryDA.GetID(strWhereCond);
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
bool bolIsExist = SysScoreSummaryDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = SysScoreSummaryDA.IsExist(lngmId);
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
clsSysScoreSummaryEN objSysScoreSummaryEN = clsSysScoreSummaryBL.GetObjBymId(lngmId);
objSysScoreSummaryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsSysScoreSummaryBL.UpdateBySql2(objSysScoreSummaryEN);
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
 bolIsExist = clsSysScoreSummaryDA.IsExistTable();
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
 bolIsExist = SysScoreSummaryDA.IsExistTable(strTabName);
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysScoreSummaryEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],用户ID = [{1}]的数据已经存在!(in clsSysScoreSummaryBL.AddNewRecordBySql2)", objSysScoreSummaryEN.mId,objSysScoreSummaryEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = SysScoreSummaryDA.AddNewRecordBySQL2(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysScoreSummaryEN objSysScoreSummaryEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysScoreSummaryEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],用户ID = [{1}]的数据已经存在!(in clsSysScoreSummaryBL.AddNewRecordBySql2WithReturnKey)", objSysScoreSummaryEN.mId,objSysScoreSummaryEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = SysScoreSummaryDA.AddNewRecordBySQL2WithReturnKey(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
try
{
bool bolResult = SysScoreSummaryDA.Update(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 /// <param name = "objSysScoreSummaryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 if (objSysScoreSummaryEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysScoreSummaryDA.UpdateBySql2(objSysScoreSummaryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysScoreSummaryBL.ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
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
 clsSysScoreSummaryEN objSysScoreSummaryEN = clsSysScoreSummaryBL.GetObjBymId(lngmId);

if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(objSysScoreSummaryEN.mId, "SetUpdDate");
}
if (objSysScoreSummaryEN != null)
{
int intRecNum = SysScoreSummaryDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);
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
objSQL = clsSysScoreSummaryDA.GetSpecSQLObj();
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
//删除与表:[SysScoreSummary]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysScoreSummary.mId,
//lngmId);
//        clsSysScoreSummaryBL.DelSysScoreSummarysByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysScoreSummaryBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysScoreSummaryBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsSysScoreSummaryBL.relatedActions != null)
{
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = SysScoreSummaryDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelSysScoreSummarys(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsSysScoreSummaryBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsSysScoreSummaryEN objSysScoreSummaryEN = clsSysScoreSummaryBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = SysScoreSummaryDA.DelSysScoreSummary(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysScoreSummaryEN.IdCurrEduCls);
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
public static int DelSysScoreSummarysByCond(string strWhereCond)
{
try
{
if (clsSysScoreSummaryBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsSysScoreSummaryBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conSysScoreSummary.IdCurrEduCls, strWhereCond);
int intRecNum = SysScoreSummaryDA.DelSysScoreSummary(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysScoreSummary]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysScoreSummaryDA.GetSpecSQLObj();
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
//删除与表:[SysScoreSummary]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysScoreSummaryBL.DelRecord(lngmId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysScoreSummaryBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objSysScoreSummaryENS">源对象</param>
 /// <param name = "objSysScoreSummaryENT">目标对象</param>
 public static void CopyTo(clsSysScoreSummaryEN objSysScoreSummaryENS, clsSysScoreSummaryEN objSysScoreSummaryENT)
{
try
{
objSysScoreSummaryENT.mId = objSysScoreSummaryENS.mId; //mId
objSysScoreSummaryENT.UserId = objSysScoreSummaryENS.UserId; //用户ID
objSysScoreSummaryENT.SchoolYear = objSysScoreSummaryENS.SchoolYear; //学年
objSysScoreSummaryENT.UpdDate = objSysScoreSummaryENS.UpdDate; //修改日期
objSysScoreSummaryENT.Memo = objSysScoreSummaryENS.Memo; //备注
objSysScoreSummaryENT.ScoreTypeId = objSysScoreSummaryENS.ScoreTypeId; //分数类型Id
objSysScoreSummaryENT.UpdUser = objSysScoreSummaryENS.UpdUser; //修改人
objSysScoreSummaryENT.Score = objSysScoreSummaryENS.Score; //评分
objSysScoreSummaryENT.IdCurrEduCls = objSysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objSysScoreSummaryENT.IsSubmit = objSysScoreSummaryENS.IsSubmit; //是否提交
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
 /// <param name = "objSysScoreSummaryEN">源简化对象</param>
 public static void SetUpdFlag(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
try
{
objSysScoreSummaryEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysScoreSummaryEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysScoreSummary.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.mId = objSysScoreSummaryEN.mId; //mId
}
if (arrFldSet.Contains(conSysScoreSummary.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.UserId = objSysScoreSummaryEN.UserId; //用户ID
}
if (arrFldSet.Contains(conSysScoreSummary.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.SchoolYear = objSysScoreSummaryEN.SchoolYear == "[null]" ? null :  objSysScoreSummaryEN.SchoolYear; //学年
}
if (arrFldSet.Contains(conSysScoreSummary.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.UpdDate = objSysScoreSummaryEN.UpdDate == "[null]" ? null :  objSysScoreSummaryEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysScoreSummary.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.Memo = objSysScoreSummaryEN.Memo == "[null]" ? null :  objSysScoreSummaryEN.Memo; //备注
}
if (arrFldSet.Contains(conSysScoreSummary.ScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.ScoreTypeId = objSysScoreSummaryEN.ScoreTypeId == "[null]" ? null :  objSysScoreSummaryEN.ScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(conSysScoreSummary.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.UpdUser = objSysScoreSummaryEN.UpdUser == "[null]" ? null :  objSysScoreSummaryEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysScoreSummary.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.Score = objSysScoreSummaryEN.Score; //评分
}
if (arrFldSet.Contains(conSysScoreSummary.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.IdCurrEduCls = objSysScoreSummaryEN.IdCurrEduCls == "[null]" ? null :  objSysScoreSummaryEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysScoreSummary.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objSysScoreSummaryEN.IsSubmit = objSysScoreSummaryEN.IsSubmit; //是否提交
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
 /// <param name = "objSysScoreSummaryEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
try
{
if (objSysScoreSummaryEN.SchoolYear == "[null]") objSysScoreSummaryEN.SchoolYear = null; //学年
if (objSysScoreSummaryEN.UpdDate == "[null]") objSysScoreSummaryEN.UpdDate = null; //修改日期
if (objSysScoreSummaryEN.Memo == "[null]") objSysScoreSummaryEN.Memo = null; //备注
if (objSysScoreSummaryEN.ScoreTypeId == "[null]") objSysScoreSummaryEN.ScoreTypeId = null; //分数类型Id
if (objSysScoreSummaryEN.UpdUser == "[null]") objSysScoreSummaryEN.UpdUser = null; //修改人
if (objSysScoreSummaryEN.IdCurrEduCls == "[null]") objSysScoreSummaryEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 SysScoreSummaryDA.CheckPropertyNew(objSysScoreSummaryEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
 SysScoreSummaryDA.CheckProperty4Condition(objSysScoreSummaryEN);
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
if (clsSysScoreSummaryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreSummaryBL没有刷新缓存机制(clsSysScoreSummaryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSysScoreSummaryObjLstCache == null)
//{
//arrSysScoreSummaryObjLstCache = SysScoreSummaryDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysScoreSummaryEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsSysScoreSummaryEN> arrSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysScoreSummaryEN> arrSysScoreSummaryObjLst_Sel =
arrSysScoreSummaryObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrSysScoreSummaryObjLst_Sel.Count() == 0)
{
   clsSysScoreSummaryEN obj = clsSysScoreSummaryBL.GetObjBymId(lngmId);
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
return arrSysScoreSummaryObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysScoreSummaryEN> GetAllSysScoreSummaryObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsSysScoreSummaryEN> arrSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrSysScoreSummaryObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysScoreSummaryEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsSysScoreSummaryEN> arrSysScoreSummaryObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSysScoreSummaryObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysScoreSummaryEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysScoreSummaryEN._RefreshTimeLst.Count == 0) return "";
return clsSysScoreSummaryEN._RefreshTimeLst[clsSysScoreSummaryEN._RefreshTimeLst.Count - 1];
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
if (clsSysScoreSummaryBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysScoreSummaryEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysScoreSummaryBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysScoreSummary(系统分数汇总表)
 /// 唯一性条件:mId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysScoreSummaryEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysScoreSummaryEN objSysScoreSummaryEN)
{
//检测记录是否存在
string strResult = SysScoreSummaryDA.GetUniCondStr(objSysScoreSummaryEN);
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
if (strInFldName != conSysScoreSummary.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysScoreSummary.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysScoreSummary.AttributeName));
throw new Exception(strMsg);
}
var objSysScoreSummary = clsSysScoreSummaryBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objSysScoreSummary == null) return "";
return objSysScoreSummary[strOutFldName].ToString();
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
int intRecCount = clsSysScoreSummaryDA.GetRecCount(strTabName);
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
int intRecCount = clsSysScoreSummaryDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysScoreSummaryDA.GetRecCount();
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
int intRecCount = clsSysScoreSummaryDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysScoreSummaryEN objSysScoreSummaryCond)
{
 string strIdCurrEduCls = objSysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSysScoreSummaryBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysScoreSummary.AttributeName)
{
if (objSysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objSysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objSysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysScoreSummaryCond[strFldName]));
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
 List<string> arrList = clsSysScoreSummaryDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysScoreSummaryDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysScoreSummaryDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysScoreSummaryDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysScoreSummaryDA.SetFldValue(clsSysScoreSummaryEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysScoreSummaryDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysScoreSummaryDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysScoreSummaryDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysScoreSummaryDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysScoreSummary] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**分数类型Id*/ 
 strCreateTabCode.Append(" ScoreTypeId char(4) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 系统分数汇总表(SysScoreSummary)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysScoreSummary : clsCommFun4BLV2
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
clsSysScoreSummaryBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}