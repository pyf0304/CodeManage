
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserLogBL
 表名:cc_CourseExamPaperUserLog(01120090)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clscc_CourseExamPaperUserLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperUserLogEN GetObj(this K_mId_cc_CourseExamPaperUserLog myKey)
{
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.GetObjBymId(myKey.Value);
return objcc_CourseExamPaperUserLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseExamPaperUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],考卷流水号 = [{1}],CreateTime = [{2}]的数据已经存在!(in clscc_CourseExamPaperUserLogBL.AddNewRecord)", objcc_CourseExamPaperUserLogEN.UserId,objcc_CourseExamPaperUserLogEN.CourseExamPaperId,objcc_CourseExamPaperUserLogEN.CreateTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.AddNewRecordBySQL2(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_CourseExamPaperUserLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperUserLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户ID(UserId)=[{0}],考卷流水号(CourseExamPaperId)=[{1}],CreateTime(CreateTime)=[{2}])已经存在,不能重复!", objcc_CourseExamPaperUserLogEN.UserId, objcc_CourseExamPaperUserLogEN.CourseExamPaperId, objcc_CourseExamPaperUserLogEN.CreateTime);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_CourseExamPaperUserLogEN.AddNewRecord();
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseExamPaperUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],考卷流水号 = [{1}],CreateTime = [{2}]的数据已经存在!(in clscc_CourseExamPaperUserLogBL.AddNewRecordWithReturnKey)", objcc_CourseExamPaperUserLogEN.UserId,objcc_CourseExamPaperUserLogEN.CourseExamPaperId,objcc_CourseExamPaperUserLogEN.CreateTime);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetmId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, long lngmId, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.mId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.mId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.mId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCreateTime(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, DateTime dteCreateTime, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.CreateTime = dteCreateTime; //CreateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CreateTime) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CreateTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CreateTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCourseExamPaperId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaperUserLog.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaperUserLog.CourseExamPaperId);
}
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CourseExamPaperId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetExamsTrueCount(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, int? intExamsTrueCount, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = intExamsTrueCount; //正确题目数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.ExamsTrueCount) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.ExamsTrueCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsTrueCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetExamsFalseCount(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, int? intExamsFalseCount, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = intExamsFalseCount; //错误题目数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.ExamsFalseCount) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.ExamsFalseCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsFalseCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetUserId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, concc_CourseExamPaperUserLog.UserId);
}
objcc_CourseExamPaperUserLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.UserId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.UserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.UserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCourseId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaperUserLog.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaperUserLog.CourseId);
}
objcc_CourseExamPaperUserLogEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CourseId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetTotalScore(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, double? dblTotalScore, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.TotalScore) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.TotalScore, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.TotalScore] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseExamPaperUserLogEN.CheckPropertyNew();
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogCond = new clscc_CourseExamPaperUserLogEN();
string strCondition = objcc_CourseExamPaperUserLogCond
.SetmId(objcc_CourseExamPaperUserLogEN.mId, "<>")
.SetUserId(objcc_CourseExamPaperUserLogEN.UserId, "=")
.SetCourseExamPaperId(objcc_CourseExamPaperUserLogEN.CourseExamPaperId, "=")
.SetCreateTime(objcc_CourseExamPaperUserLogEN.CreateTime, "=")
.GetCombineCondition();
objcc_CourseExamPaperUserLogEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseExamPaperUserLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_CourseExamPaperId_CreateTime)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseExamPaperUserLogEN.Update();
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
 /// <param name = "objcc_CourseExamPaperUserLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogCond = new clscc_CourseExamPaperUserLogEN();
string strCondition = objcc_CourseExamPaperUserLogCond
.SetUserId(objcc_CourseExamPaperUserLog.UserId, "=")
.SetCourseExamPaperId(objcc_CourseExamPaperUserLog.CourseExamPaperId, "=")
.SetCreateTime(objcc_CourseExamPaperUserLog.CreateTime, "=")
.GetCombineCondition();
objcc_CourseExamPaperUserLog._IsCheckProperty = true;
bool bolIsExist = clscc_CourseExamPaperUserLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_CourseExamPaperUserLog.mId = clscc_CourseExamPaperUserLogBL.GetFirstID_S(strCondition);
objcc_CourseExamPaperUserLog.UpdateWithCondition(strCondition);
}
else
{
objcc_CourseExamPaperUserLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 if (objcc_CourseExamPaperUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.UpdateBySql2(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_CourseExamPaperUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.UpdateBySql2(objcc_CourseExamPaperUserLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.UpdateBySqlWithCondition(objcc_CourseExamPaperUserLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.UpdateBySqlWithConditionTransaction(objcc_CourseExamPaperUserLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
public static int Delete(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
try
{
int intRecNum = clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.DelRecord(objcc_CourseExamPaperUserLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperUserLogENT">目标对象</param>
 public static void CopyTo(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS, clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENT)
{
try
{
objcc_CourseExamPaperUserLogENT.mId = objcc_CourseExamPaperUserLogENS.mId; //mId
objcc_CourseExamPaperUserLogENT.CreateTime = objcc_CourseExamPaperUserLogENS.CreateTime; //CreateTime
objcc_CourseExamPaperUserLogENT.CourseExamPaperId = objcc_CourseExamPaperUserLogENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperUserLogENT.ExamsTrueCount = objcc_CourseExamPaperUserLogENS.ExamsTrueCount; //正确题目数量
objcc_CourseExamPaperUserLogENT.ExamsFalseCount = objcc_CourseExamPaperUserLogENS.ExamsFalseCount; //错误题目数量
objcc_CourseExamPaperUserLogENT.UserId = objcc_CourseExamPaperUserLogENS.UserId; //用户ID
objcc_CourseExamPaperUserLogENT.CourseId = objcc_CourseExamPaperUserLogENS.CourseId; //课程Id
objcc_CourseExamPaperUserLogENT.TotalScore = objcc_CourseExamPaperUserLogENS.TotalScore; //总得分
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
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperUserLogEN:objcc_CourseExamPaperUserLogENT</returns>
 public static clscc_CourseExamPaperUserLogEN CopyTo(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS)
{
try
{
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENT = new clscc_CourseExamPaperUserLogEN()
{
mId = objcc_CourseExamPaperUserLogENS.mId, //mId
CreateTime = objcc_CourseExamPaperUserLogENS.CreateTime, //CreateTime
CourseExamPaperId = objcc_CourseExamPaperUserLogENS.CourseExamPaperId, //考卷流水号
ExamsTrueCount = objcc_CourseExamPaperUserLogENS.ExamsTrueCount, //正确题目数量
ExamsFalseCount = objcc_CourseExamPaperUserLogENS.ExamsFalseCount, //错误题目数量
UserId = objcc_CourseExamPaperUserLogENS.UserId, //用户ID
CourseId = objcc_CourseExamPaperUserLogENS.CourseId, //课程Id
TotalScore = objcc_CourseExamPaperUserLogENS.TotalScore, //总得分
};
 return objcc_CourseExamPaperUserLogENT;
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
public static void CheckPropertyNew(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.CheckPropertyNew(objcc_CourseExamPaperUserLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 clscc_CourseExamPaperUserLogBL.cc_CourseExamPaperUserLogDA.CheckProperty4Condition(objcc_CourseExamPaperUserLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.mId) == true)
{
string strComparisonOpmId = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.mId, objcc_CourseExamPaperUserLogCond.mId, strComparisonOpmId);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.CreateTime) == true)
{
string strComparisonOpCreateTime = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CreateTime, objcc_CourseExamPaperUserLogCond.CreateTime, strComparisonOpCreateTime);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CourseExamPaperId, objcc_CourseExamPaperUserLogCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.ExamsTrueCount) == true)
{
string strComparisonOpExamsTrueCount = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsTrueCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.ExamsTrueCount, objcc_CourseExamPaperUserLogCond.ExamsTrueCount, strComparisonOpExamsTrueCount);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.ExamsFalseCount) == true)
{
string strComparisonOpExamsFalseCount = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsFalseCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.ExamsFalseCount, objcc_CourseExamPaperUserLogCond.ExamsFalseCount, strComparisonOpExamsFalseCount);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.UserId) == true)
{
string strComparisonOpUserId = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.UserId, objcc_CourseExamPaperUserLogCond.UserId, strComparisonOpUserId);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CourseId, objcc_CourseExamPaperUserLogCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseExamPaperUserLogCond.IsUpdated(concc_CourseExamPaperUserLog.TotalScore) == true)
{
string strComparisonOpTotalScore = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[concc_CourseExamPaperUserLog.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.TotalScore, objcc_CourseExamPaperUserLogCond.TotalScore, strComparisonOpTotalScore);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaperUserLog(学生答试卷日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_CourseExamPaperId_CreateTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperUserLogEN == null) return true;
if (objcc_CourseExamPaperUserLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperUserLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objcc_CourseExamPaperUserLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
}
 if (objcc_CourseExamPaperUserLogEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
}
 if (objcc_CourseExamPaperUserLogEN.CreateTime == null)
{
 sbCondition.AppendFormat(" and CreateTime is null", objcc_CourseExamPaperUserLogEN.CreateTime);
}
else
{
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
}
if (clscc_CourseExamPaperUserLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_CourseExamPaperUserLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
if (clscc_CourseExamPaperUserLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_CourseExamPaperUserLog(学生答试卷日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_CourseExamPaperId_CreateTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperUserLogEN == null) return "";
if (objcc_CourseExamPaperUserLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperUserLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objcc_CourseExamPaperUserLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
}
 if (objcc_CourseExamPaperUserLogEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
}
 if (objcc_CourseExamPaperUserLogEN.CreateTime == null)
{
 sbCondition.AppendFormat(" and CreateTime is null", objcc_CourseExamPaperUserLogEN.CreateTime);
}
else
{
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_CourseExamPaperUserLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseExamPaperUserLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperUserLogBL
{
public static RelatedActions_cc_CourseExamPaperUserLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseExamPaperUserLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseExamPaperUserLogDA cc_CourseExamPaperUserLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseExamPaperUserLogDA();
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
 public clscc_CourseExamPaperUserLogBL()
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
if (string.IsNullOrEmpty(clscc_CourseExamPaperUserLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperUserLogEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseExamPaperUserLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseExamPaperUserLogDA.GetDataTable_cc_CourseExamPaperUserLog(strWhereCond);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseExamPaperUserLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
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
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseExamPaperUserLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName, strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Sel =
arrcc_CourseExamPaperUserLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrcc_CourseExamPaperUserLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseExamPaperUserLogEN> GetSubObjLstCache(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogCond)
{
 string strCourseId = objcc_CourseExamPaperUserLogCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_CourseExamPaperUserLogBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_CourseExamPaperUserLogEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseExamPaperUserLog.AttributeName)
{
if (objcc_CourseExamPaperUserLogCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseExamPaperUserLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperUserLogCond[strFldName].ToString());
}
else
{
if (objcc_CourseExamPaperUserLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperUserLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseExamPaperUserLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperUserLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperUserLogCond[strFldName]));
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
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
List<clscc_CourseExamPaperUserLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseExamPaperUserLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseExamPaperUserLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
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
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
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
public static List<clscc_CourseExamPaperUserLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseExamPaperUserLogEN> arrObjLst = new List<clscc_CourseExamPaperUserLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = new clscc_CourseExamPaperUserLogEN();
try
{
objcc_CourseExamPaperUserLogEN.mId = Int32.Parse(objRow[concc_CourseExamPaperUserLog.mId].ToString().Trim()); //mId
objcc_CourseExamPaperUserLogEN.CreateTime = clsEntityBase2.TransNullToDate_S(objRow[concc_CourseExamPaperUserLog.CreateTime].ToString().Trim()); //CreateTime
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objRow[concc_CourseExamPaperUserLog.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objRow[concc_CourseExamPaperUserLog.ExamsTrueCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsTrueCount].ToString().Trim()); //正确题目数量
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objRow[concc_CourseExamPaperUserLog.ExamsFalseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaperUserLog.ExamsFalseCount].ToString().Trim()); //错误题目数量
objcc_CourseExamPaperUserLogEN.UserId = objRow[concc_CourseExamPaperUserLog.UserId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.UserId].ToString().Trim(); //用户ID
objcc_CourseExamPaperUserLogEN.CourseId = objRow[concc_CourseExamPaperUserLog.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaperUserLog.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperUserLogEN.TotalScore = objRow[concc_CourseExamPaperUserLog.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaperUserLog.TotalScore].ToString().Trim()); //总得分
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperUserLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseExamPaperUserLog(ref clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
bool bolResult = cc_CourseExamPaperUserLogDA.Getcc_CourseExamPaperUserLog(ref objcc_CourseExamPaperUserLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperUserLogEN GetObjBymId(long lngmId)
{
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = cc_CourseExamPaperUserLogDA.GetObjBymId(lngmId);
return objcc_CourseExamPaperUserLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseExamPaperUserLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = cc_CourseExamPaperUserLogDA.GetFirstObj(strWhereCond);
 return objcc_CourseExamPaperUserLogEN;
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
public static clscc_CourseExamPaperUserLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = cc_CourseExamPaperUserLogDA.GetObjByDataRow(objRow);
 return objcc_CourseExamPaperUserLogEN;
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
public static clscc_CourseExamPaperUserLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = cc_CourseExamPaperUserLogDA.GetObjByDataRow(objRow);
 return objcc_CourseExamPaperUserLogEN;
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
 /// <param name = "lstcc_CourseExamPaperUserLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperUserLogEN GetObjBymIdFromList(long lngmId, List<clscc_CourseExamPaperUserLogEN> lstcc_CourseExamPaperUserLogObjLst)
{
foreach (clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN in lstcc_CourseExamPaperUserLogObjLst)
{
if (objcc_CourseExamPaperUserLogEN.mId == lngmId)
{
return objcc_CourseExamPaperUserLogEN;
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
 lngmId = new clscc_CourseExamPaperUserLogDA().GetFirstID(strWhereCond);
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
 arrList = cc_CourseExamPaperUserLogDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseExamPaperUserLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = cc_CourseExamPaperUserLogDA.IsExist(lngmId);
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
 bolIsExist = clscc_CourseExamPaperUserLogDA.IsExistTable();
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
 bolIsExist = cc_CourseExamPaperUserLogDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperUserLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],考卷流水号 = [{1}],CreateTime = [{2}]的数据已经存在!(in clscc_CourseExamPaperUserLogBL.AddNewRecordBySql2)", objcc_CourseExamPaperUserLogEN.UserId,objcc_CourseExamPaperUserLogEN.CourseExamPaperId,objcc_CourseExamPaperUserLogEN.CreateTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_CourseExamPaperUserLogDA.AddNewRecordBySQL2(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperUserLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户ID = [{0}],考卷流水号 = [{1}],CreateTime = [{2}]的数据已经存在!(in clscc_CourseExamPaperUserLogBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseExamPaperUserLogEN.UserId,objcc_CourseExamPaperUserLogEN.CourseExamPaperId,objcc_CourseExamPaperUserLogEN.CreateTime);
throw new Exception(strMsg);
}
try
{
string strKey = cc_CourseExamPaperUserLogDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
try
{
bool bolResult = cc_CourseExamPaperUserLogDA.Update(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 if (objcc_CourseExamPaperUserLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseExamPaperUserLogDA.UpdateBySql2(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogBL.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
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
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogBL.GetObjBymId(lngmId);

if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperUserLogEN.mId, "SetUpdDate");
}
if (objcc_CourseExamPaperUserLogEN != null)
{
int intRecNum = cc_CourseExamPaperUserLogDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseExamPaperUserLogDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseExamPaperUserLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseExamPaperUserLog.mId,
//lngmId);
//        clscc_CourseExamPaperUserLogBL.Delcc_CourseExamPaperUserLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseExamPaperUserLogBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseExamPaperUserLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseExamPaperUserLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
public static int Delcc_CourseExamPaperUserLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = cc_CourseExamPaperUserLogDA.Delcc_CourseExamPaperUserLog(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
public static int Delcc_CourseExamPaperUserLogsByCond(string strWhereCond)
{
try
{
if (clscc_CourseExamPaperUserLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clscc_CourseExamPaperUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_CourseExamPaperUserLog.CourseId, strWhereCond);
int intRecNum = cc_CourseExamPaperUserLogDA.Delcc_CourseExamPaperUserLog(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseExamPaperUserLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseExamPaperUserLogDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseExamPaperUserLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseExamPaperUserLogBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseExamPaperUserLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperUserLogENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS, clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENT)
{
try
{
objcc_CourseExamPaperUserLogENT.mId = objcc_CourseExamPaperUserLogENS.mId; //mId
objcc_CourseExamPaperUserLogENT.CreateTime = objcc_CourseExamPaperUserLogENS.CreateTime; //CreateTime
objcc_CourseExamPaperUserLogENT.CourseExamPaperId = objcc_CourseExamPaperUserLogENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperUserLogENT.ExamsTrueCount = objcc_CourseExamPaperUserLogENS.ExamsTrueCount; //正确题目数量
objcc_CourseExamPaperUserLogENT.ExamsFalseCount = objcc_CourseExamPaperUserLogENS.ExamsFalseCount; //错误题目数量
objcc_CourseExamPaperUserLogENT.UserId = objcc_CourseExamPaperUserLogENS.UserId; //用户ID
objcc_CourseExamPaperUserLogENT.CourseId = objcc_CourseExamPaperUserLogENS.CourseId; //课程Id
objcc_CourseExamPaperUserLogENT.TotalScore = objcc_CourseExamPaperUserLogENS.TotalScore; //总得分
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
try
{
objcc_CourseExamPaperUserLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseExamPaperUserLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.mId = objcc_CourseExamPaperUserLogEN.mId; //mId
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.CreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.CreateTime = objcc_CourseExamPaperUserLogEN.CreateTime; //CreateTime
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = objcc_CourseExamPaperUserLogEN.CourseExamPaperId == "[null]" ? null :  objcc_CourseExamPaperUserLogEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.ExamsTrueCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = objcc_CourseExamPaperUserLogEN.ExamsTrueCount; //正确题目数量
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.ExamsFalseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = objcc_CourseExamPaperUserLogEN.ExamsFalseCount; //错误题目数量
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.UserId = objcc_CourseExamPaperUserLogEN.UserId == "[null]" ? null :  objcc_CourseExamPaperUserLogEN.UserId; //用户ID
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.CourseId = objcc_CourseExamPaperUserLogEN.CourseId == "[null]" ? null :  objcc_CourseExamPaperUserLogEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseExamPaperUserLog.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperUserLogEN.TotalScore = objcc_CourseExamPaperUserLogEN.TotalScore; //总得分
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
try
{
if (objcc_CourseExamPaperUserLogEN.CourseExamPaperId == "[null]") objcc_CourseExamPaperUserLogEN.CourseExamPaperId = null; //考卷流水号
if (objcc_CourseExamPaperUserLogEN.UserId == "[null]") objcc_CourseExamPaperUserLogEN.UserId = null; //用户ID
if (objcc_CourseExamPaperUserLogEN.CourseId == "[null]") objcc_CourseExamPaperUserLogEN.CourseId = null; //课程Id
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
public static void CheckPropertyNew(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 cc_CourseExamPaperUserLogDA.CheckPropertyNew(objcc_CourseExamPaperUserLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 cc_CourseExamPaperUserLogDA.CheckProperty4Condition(objcc_CourseExamPaperUserLogEN);
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
if (clscc_CourseExamPaperUserLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperUserLogBL没有刷新缓存机制(clscc_CourseExamPaperUserLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_CourseExamPaperUserLogObjLstCache == null)
//{
//arrcc_CourseExamPaperUserLogObjLstCache = cc_CourseExamPaperUserLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperUserLogEN GetObjBymIdCache(long lngmId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName, strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Sel =
arrcc_CourseExamPaperUserLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrcc_CourseExamPaperUserLogObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperUserLogEN obj = clscc_CourseExamPaperUserLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_CourseExamPaperUserLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetAllcc_CourseExamPaperUserLogObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_CourseExamPaperUserLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_CourseExamPaperUserLogObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperUserLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseExamPaperUserLogEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseExamPaperUserLogEN._RefreshTimeLst[clscc_CourseExamPaperUserLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseExamPaperUserLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperUserLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseExamPaperUserLogBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_CourseExamPaperUserLog(学生答试卷日志)
 /// 唯一性条件:UserId_CourseExamPaperId_CreateTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
//检测记录是否存在
string strResult = cc_CourseExamPaperUserLogDA.GetUniCondStr(objcc_CourseExamPaperUserLogEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != concc_CourseExamPaperUserLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseExamPaperUserLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseExamPaperUserLog.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseExamPaperUserLog = clscc_CourseExamPaperUserLogBL.GetObjBymIdCache(lngmId, strCourseId);
if (objcc_CourseExamPaperUserLog == null) return "";
return objcc_CourseExamPaperUserLog[strOutFldName].ToString();
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
int intRecCount = clscc_CourseExamPaperUserLogDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseExamPaperUserLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseExamPaperUserLogDA.GetRecCount();
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
int intRecCount = clscc_CourseExamPaperUserLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogCond)
{
 string strCourseId = objcc_CourseExamPaperUserLogCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_CourseExamPaperUserLogBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_CourseExamPaperUserLogEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseExamPaperUserLog.AttributeName)
{
if (objcc_CourseExamPaperUserLogCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseExamPaperUserLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperUserLogCond[strFldName].ToString());
}
else
{
if (objcc_CourseExamPaperUserLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseExamPaperUserLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperUserLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseExamPaperUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseExamPaperUserLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperUserLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperUserLogCond[strFldName]));
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
 List<string> arrList = clscc_CourseExamPaperUserLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseExamPaperUserLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseExamPaperUserLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseExamPaperUserLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperUserLogDA.SetFldValue(clscc_CourseExamPaperUserLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseExamPaperUserLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperUserLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperUserLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperUserLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseExamPaperUserLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**CreateTime*/ 
 strCreateTabCode.Append(" CreateTime datetime Null, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**正确题目数量*/ 
 strCreateTabCode.Append(" ExamsTrueCount int Null, "); 
 // /**错误题目数量*/ 
 strCreateTabCode.Append(" ExamsFalseCount int Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**总得分*/ 
 strCreateTabCode.Append(" TotalScore decimal(10,1) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseExamPaperUserLog : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_CourseExamPaperUserLogBL.ReFreshThisCache(strCourseId);
}
}

}