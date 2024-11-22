
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_LogicChartSubmitResultsBL
 表名:ge_LogicChartSubmitResults(01120912)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:37
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
public static class  clsge_LogicChartSubmitResultsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_LogicChartSubmitResultsEN GetObj(this K_mId_ge_LogicChartSubmitResults myKey)
{
clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.GetObjBymId(myKey.Value);
return objge_LogicChartSubmitResultsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_LogicChartSubmitResultsEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程Id = [{1}]的数据已经存在!(in clsge_LogicChartSubmitResultsBL.AddNewRecord)", objge_LogicChartSubmitResultsEN.KnowledgeGraphId,objge_LogicChartSubmitResultsEN.CourseId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.AddNewRecordBySQL2(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
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
objge_LogicChartSubmitResultsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_LogicChartSubmitResultsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识点图Id(KnowledgeGraphId)=[{0}],课程Id(CourseId)=[{1}])已经存在,不能重复!", objge_LogicChartSubmitResultsEN.KnowledgeGraphId, objge_LogicChartSubmitResultsEN.CourseId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_LogicChartSubmitResultsEN.AddNewRecord();
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_LogicChartSubmitResultsEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程Id = [{1}]的数据已经存在!(in clsge_LogicChartSubmitResultsBL.AddNewRecordWithReturnKey)", objge_LogicChartSubmitResultsEN.KnowledgeGraphId,objge_LogicChartSubmitResultsEN.CourseId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.AddNewRecordBySQL2WithReturnKey(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetmId(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, long lngmId, string strComparisonOp="")
	{
objge_LogicChartSubmitResultsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.mId) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.mId, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.mId] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetKnowledgeGraphId(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeGraphId, conge_LogicChartSubmitResults.KnowledgeGraphId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, conge_LogicChartSubmitResults.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, conge_LogicChartSubmitResults.KnowledgeGraphId);
}
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.KnowledgeGraphId) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.KnowledgeGraphId, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.KnowledgeGraphId] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetCourseId(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_LogicChartSubmitResults.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_LogicChartSubmitResults.CourseId);
}
objge_LogicChartSubmitResultsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.CourseId) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.CourseId, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.CourseId] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetCreateUser(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conge_LogicChartSubmitResults.CreateUser);
}
objge_LogicChartSubmitResultsEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.CreateUser) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.CreateUser, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.CreateUser] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetTakeUpTime(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strTakeUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTakeUpTime, 50, conge_LogicChartSubmitResults.TakeUpTime);
}
objge_LogicChartSubmitResultsEN.TakeUpTime = strTakeUpTime; //耗时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.TakeUpTime) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.TakeUpTime, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.TakeUpTime] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetFraction(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, int? intFraction, string strComparisonOp="")
	{
objge_LogicChartSubmitResultsEN.Fraction = intFraction; //分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.Fraction) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.Fraction, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.Fraction] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetCorrectNum(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, int? intCorrectNum, string strComparisonOp="")
	{
objge_LogicChartSubmitResultsEN.CorrectNum = intCorrectNum; //正确数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.CorrectNum) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.CorrectNum, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.CorrectNum] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetErrorNum(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, int? intErrorNum, string strComparisonOp="")
	{
objge_LogicChartSubmitResultsEN.ErrorNum = intErrorNum; //错误数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.ErrorNum) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.ErrorNum, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.ErrorNum] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetUpdDate(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_LogicChartSubmitResults.UpdDate);
}
objge_LogicChartSubmitResultsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.UpdDate) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.UpdDate, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.UpdDate] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetUpdUser(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_LogicChartSubmitResults.UpdUser);
}
objge_LogicChartSubmitResultsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.UpdUser) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.UpdUser, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.UpdUser] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_LogicChartSubmitResultsEN SetMemo(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_LogicChartSubmitResults.Memo);
}
objge_LogicChartSubmitResultsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_LogicChartSubmitResultsEN.dicFldComparisonOp.ContainsKey(conge_LogicChartSubmitResults.Memo) == false)
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp.Add(conge_LogicChartSubmitResults.Memo, strComparisonOp);
}
else
{
objge_LogicChartSubmitResultsEN.dicFldComparisonOp[conge_LogicChartSubmitResults.Memo] = strComparisonOp;
}
}
return objge_LogicChartSubmitResultsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_LogicChartSubmitResultsEN.CheckPropertyNew();
clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsCond = new clsge_LogicChartSubmitResultsEN();
string strCondition = objge_LogicChartSubmitResultsCond
.SetmId(objge_LogicChartSubmitResultsEN.mId, "<>")
.SetKnowledgeGraphId(objge_LogicChartSubmitResultsEN.KnowledgeGraphId, "=")
.SetCourseId(objge_LogicChartSubmitResultsEN.CourseId, "=")
.GetCombineCondition();
objge_LogicChartSubmitResultsEN._IsCheckProperty = true;
bool bolIsExist = clsge_LogicChartSubmitResultsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(KnowledgeGraphId_CourseId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_LogicChartSubmitResultsEN.Update();
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
 /// <param name = "objge_LogicChartSubmitResults">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResults)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsCond = new clsge_LogicChartSubmitResultsEN();
string strCondition = objge_LogicChartSubmitResultsCond
.SetKnowledgeGraphId(objge_LogicChartSubmitResults.KnowledgeGraphId, "=")
.SetCourseId(objge_LogicChartSubmitResults.CourseId, "=")
.GetCombineCondition();
objge_LogicChartSubmitResults._IsCheckProperty = true;
bool bolIsExist = clsge_LogicChartSubmitResultsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_LogicChartSubmitResults.mId = clsge_LogicChartSubmitResultsBL.GetFirstID_S(strCondition);
objge_LogicChartSubmitResults.UpdateWithCondition(strCondition);
}
else
{
objge_LogicChartSubmitResults.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 if (objge_LogicChartSubmitResultsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.UpdateBySql2(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_LogicChartSubmitResultsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.UpdateBySql2(objge_LogicChartSubmitResultsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strWhereCond)
{
try
{
bool bolResult = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.UpdateBySqlWithCondition(objge_LogicChartSubmitResultsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.UpdateBySqlWithConditionTransaction(objge_LogicChartSubmitResultsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
public static int Delete(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
try
{
int intRecNum = clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.DelRecord(objge_LogicChartSubmitResultsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <param name = "objge_LogicChartSubmitResultsENT">目标对象</param>
 public static void CopyTo(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENS, clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENT)
{
try
{
objge_LogicChartSubmitResultsENT.mId = objge_LogicChartSubmitResultsENS.mId; //mId
objge_LogicChartSubmitResultsENT.KnowledgeGraphId = objge_LogicChartSubmitResultsENS.KnowledgeGraphId; //知识点图Id
objge_LogicChartSubmitResultsENT.CourseId = objge_LogicChartSubmitResultsENS.CourseId; //课程Id
objge_LogicChartSubmitResultsENT.CreateUser = objge_LogicChartSubmitResultsENS.CreateUser; //建立用户
objge_LogicChartSubmitResultsENT.TakeUpTime = objge_LogicChartSubmitResultsENS.TakeUpTime; //耗时
objge_LogicChartSubmitResultsENT.Fraction = objge_LogicChartSubmitResultsENS.Fraction; //分数
objge_LogicChartSubmitResultsENT.CorrectNum = objge_LogicChartSubmitResultsENS.CorrectNum; //正确数
objge_LogicChartSubmitResultsENT.ErrorNum = objge_LogicChartSubmitResultsENS.ErrorNum; //错误数
objge_LogicChartSubmitResultsENT.UpdDate = objge_LogicChartSubmitResultsENS.UpdDate; //修改日期
objge_LogicChartSubmitResultsENT.UpdUser = objge_LogicChartSubmitResultsENS.UpdUser; //修改人
objge_LogicChartSubmitResultsENT.Memo = objge_LogicChartSubmitResultsENS.Memo; //备注
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
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <returns>目标对象=>clsge_LogicChartSubmitResultsEN:objge_LogicChartSubmitResultsENT</returns>
 public static clsge_LogicChartSubmitResultsEN CopyTo(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENS)
{
try
{
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENT = new clsge_LogicChartSubmitResultsEN()
{
mId = objge_LogicChartSubmitResultsENS.mId, //mId
KnowledgeGraphId = objge_LogicChartSubmitResultsENS.KnowledgeGraphId, //知识点图Id
CourseId = objge_LogicChartSubmitResultsENS.CourseId, //课程Id
CreateUser = objge_LogicChartSubmitResultsENS.CreateUser, //建立用户
TakeUpTime = objge_LogicChartSubmitResultsENS.TakeUpTime, //耗时
Fraction = objge_LogicChartSubmitResultsENS.Fraction, //分数
CorrectNum = objge_LogicChartSubmitResultsENS.CorrectNum, //正确数
ErrorNum = objge_LogicChartSubmitResultsENS.ErrorNum, //错误数
UpdDate = objge_LogicChartSubmitResultsENS.UpdDate, //修改日期
UpdUser = objge_LogicChartSubmitResultsENS.UpdUser, //修改人
Memo = objge_LogicChartSubmitResultsENS.Memo, //备注
};
 return objge_LogicChartSubmitResultsENT;
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
public static void CheckPropertyNew(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.CheckPropertyNew(objge_LogicChartSubmitResultsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 clsge_LogicChartSubmitResultsBL.ge_LogicChartSubmitResultsDA.CheckProperty4Condition(objge_LogicChartSubmitResultsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.mId) == true)
{
string strComparisonOpmId = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_LogicChartSubmitResults.mId, objge_LogicChartSubmitResultsCond.mId, strComparisonOpmId);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.KnowledgeGraphId, objge_LogicChartSubmitResultsCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.CourseId) == true)
{
string strComparisonOpCourseId = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.CourseId, objge_LogicChartSubmitResultsCond.CourseId, strComparisonOpCourseId);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.CreateUser) == true)
{
string strComparisonOpCreateUser = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.CreateUser, objge_LogicChartSubmitResultsCond.CreateUser, strComparisonOpCreateUser);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.TakeUpTime) == true)
{
string strComparisonOpTakeUpTime = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.TakeUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.TakeUpTime, objge_LogicChartSubmitResultsCond.TakeUpTime, strComparisonOpTakeUpTime);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.Fraction) == true)
{
string strComparisonOpFraction = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.Fraction];
strWhereCond += string.Format(" And {0} {2} {1}", conge_LogicChartSubmitResults.Fraction, objge_LogicChartSubmitResultsCond.Fraction, strComparisonOpFraction);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.CorrectNum) == true)
{
string strComparisonOpCorrectNum = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.CorrectNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_LogicChartSubmitResults.CorrectNum, objge_LogicChartSubmitResultsCond.CorrectNum, strComparisonOpCorrectNum);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.ErrorNum) == true)
{
string strComparisonOpErrorNum = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.ErrorNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_LogicChartSubmitResults.ErrorNum, objge_LogicChartSubmitResultsCond.ErrorNum, strComparisonOpErrorNum);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.UpdDate, objge_LogicChartSubmitResultsCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.UpdUser, objge_LogicChartSubmitResultsCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_LogicChartSubmitResultsCond.IsUpdated(conge_LogicChartSubmitResults.Memo) == true)
{
string strComparisonOpMemo = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[conge_LogicChartSubmitResults.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_LogicChartSubmitResults.Memo, objge_LogicChartSubmitResultsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_LogicChartSubmitResults(知识逻辑图提交结果), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:KnowledgeGraphId_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_LogicChartSubmitResultsEN == null) return true;
if (objge_LogicChartSubmitResultsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objge_LogicChartSubmitResultsEN.KnowledgeGraphId);
 if (objge_LogicChartSubmitResultsEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null", objge_LogicChartSubmitResultsEN.CourseId);
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objge_LogicChartSubmitResultsEN.CourseId);
}
if (clsge_LogicChartSubmitResultsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_LogicChartSubmitResultsEN.mId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objge_LogicChartSubmitResultsEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objge_LogicChartSubmitResultsEN.CourseId);
if (clsge_LogicChartSubmitResultsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_LogicChartSubmitResults(知识逻辑图提交结果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:KnowledgeGraphId_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_LogicChartSubmitResultsEN == null) return "";
if (objge_LogicChartSubmitResultsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objge_LogicChartSubmitResultsEN.KnowledgeGraphId);
 if (objge_LogicChartSubmitResultsEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null", objge_LogicChartSubmitResultsEN.CourseId);
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objge_LogicChartSubmitResultsEN.CourseId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_LogicChartSubmitResultsEN.mId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objge_LogicChartSubmitResultsEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objge_LogicChartSubmitResultsEN.CourseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_LogicChartSubmitResults
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识逻辑图提交结果(ge_LogicChartSubmitResults)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_LogicChartSubmitResultsBL
{
public static RelatedActions_ge_LogicChartSubmitResults relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_LogicChartSubmitResultsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_LogicChartSubmitResultsDA ge_LogicChartSubmitResultsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_LogicChartSubmitResultsDA();
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
 public clsge_LogicChartSubmitResultsBL()
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
if (string.IsNullOrEmpty(clsge_LogicChartSubmitResultsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_LogicChartSubmitResultsEN._ConnectString);
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
public static DataTable GetDataTable_ge_LogicChartSubmitResults(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_LogicChartSubmitResultsDA.GetDataTable_ge_LogicChartSubmitResults(strWhereCond);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable(strWhereCond);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable_Top(objTopPara);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_LogicChartSubmitResultsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
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
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_LogicChartSubmitResultsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsge_LogicChartSubmitResultsEN._CurrTabName);
List<clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLstCache = GetObjLstCache();
IEnumerable <clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLst_Sel =
arrge_LogicChartSubmitResultsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrge_LogicChartSubmitResultsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetObjLst(string strWhereCond)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_LogicChartSubmitResultsEN> GetSubObjLstCache(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsCond)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_LogicChartSubmitResultsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_LogicChartSubmitResults.AttributeName)
{
if (objge_LogicChartSubmitResultsCond.IsUpdated(strFldName) == false) continue;
if (objge_LogicChartSubmitResultsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LogicChartSubmitResultsCond[strFldName].ToString());
}
else
{
if (objge_LogicChartSubmitResultsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LogicChartSubmitResultsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_LogicChartSubmitResultsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_LogicChartSubmitResultsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_LogicChartSubmitResultsCond[strFldName]));
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
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
List<clsge_LogicChartSubmitResultsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_LogicChartSubmitResultsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_LogicChartSubmitResultsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
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
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
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
public static List<clsge_LogicChartSubmitResultsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
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
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLst = new List<clsge_LogicChartSubmitResultsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = new clsge_LogicChartSubmitResultsEN();
try
{
objge_LogicChartSubmitResultsEN.mId = Int32.Parse(objRow[conge_LogicChartSubmitResults.mId].ToString().Trim()); //mId
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objRow[conge_LogicChartSubmitResults.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objge_LogicChartSubmitResultsEN.CourseId = objRow[conge_LogicChartSubmitResults.CourseId] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CourseId].ToString().Trim(); //课程Id
objge_LogicChartSubmitResultsEN.CreateUser = objRow[conge_LogicChartSubmitResults.CreateUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.CreateUser].ToString().Trim(); //建立用户
objge_LogicChartSubmitResultsEN.TakeUpTime = objRow[conge_LogicChartSubmitResults.TakeUpTime] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.TakeUpTime].ToString().Trim(); //耗时
objge_LogicChartSubmitResultsEN.Fraction = objRow[conge_LogicChartSubmitResults.Fraction] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.Fraction].ToString().Trim()); //分数
objge_LogicChartSubmitResultsEN.CorrectNum = objRow[conge_LogicChartSubmitResults.CorrectNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.CorrectNum].ToString().Trim()); //正确数
objge_LogicChartSubmitResultsEN.ErrorNum = objRow[conge_LogicChartSubmitResults.ErrorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_LogicChartSubmitResults.ErrorNum].ToString().Trim()); //错误数
objge_LogicChartSubmitResultsEN.UpdDate = objRow[conge_LogicChartSubmitResults.UpdDate] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdDate].ToString().Trim(); //修改日期
objge_LogicChartSubmitResultsEN.UpdUser = objRow[conge_LogicChartSubmitResults.UpdUser] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.UpdUser].ToString().Trim(); //修改人
objge_LogicChartSubmitResultsEN.Memo = objRow[conge_LogicChartSubmitResults.Memo] == DBNull.Value ? null : objRow[conge_LogicChartSubmitResults.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_LogicChartSubmitResultsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_LogicChartSubmitResultsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_LogicChartSubmitResults(ref clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
bool bolResult = ge_LogicChartSubmitResultsDA.Getge_LogicChartSubmitResults(ref objge_LogicChartSubmitResultsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_LogicChartSubmitResultsEN GetObjBymId(long lngmId)
{
clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = ge_LogicChartSubmitResultsDA.GetObjBymId(lngmId);
return objge_LogicChartSubmitResultsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_LogicChartSubmitResultsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = ge_LogicChartSubmitResultsDA.GetFirstObj(strWhereCond);
 return objge_LogicChartSubmitResultsEN;
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
public static clsge_LogicChartSubmitResultsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = ge_LogicChartSubmitResultsDA.GetObjByDataRow(objRow);
 return objge_LogicChartSubmitResultsEN;
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
public static clsge_LogicChartSubmitResultsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = ge_LogicChartSubmitResultsDA.GetObjByDataRow(objRow);
 return objge_LogicChartSubmitResultsEN;
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
 /// <param name = "lstge_LogicChartSubmitResultsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_LogicChartSubmitResultsEN GetObjBymIdFromList(long lngmId, List<clsge_LogicChartSubmitResultsEN> lstge_LogicChartSubmitResultsObjLst)
{
foreach (clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN in lstge_LogicChartSubmitResultsObjLst)
{
if (objge_LogicChartSubmitResultsEN.mId == lngmId)
{
return objge_LogicChartSubmitResultsEN;
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
 lngmId = new clsge_LogicChartSubmitResultsDA().GetFirstID(strWhereCond);
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
 arrList = ge_LogicChartSubmitResultsDA.GetID(strWhereCond);
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
bool bolIsExist = ge_LogicChartSubmitResultsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ge_LogicChartSubmitResultsDA.IsExist(lngmId);
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
 bolIsExist = clsge_LogicChartSubmitResultsDA.IsExistTable();
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
 bolIsExist = ge_LogicChartSubmitResultsDA.IsExistTable(strTabName);
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_LogicChartSubmitResultsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程Id = [{1}]的数据已经存在!(in clsge_LogicChartSubmitResultsBL.AddNewRecordBySql2)", objge_LogicChartSubmitResultsEN.KnowledgeGraphId,objge_LogicChartSubmitResultsEN.CourseId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_LogicChartSubmitResultsDA.AddNewRecordBySQL2(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_LogicChartSubmitResultsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程Id = [{1}]的数据已经存在!(in clsge_LogicChartSubmitResultsBL.AddNewRecordBySql2WithReturnKey)", objge_LogicChartSubmitResultsEN.KnowledgeGraphId,objge_LogicChartSubmitResultsEN.CourseId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_LogicChartSubmitResultsDA.AddNewRecordBySQL2WithReturnKey(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
try
{
bool bolResult = ge_LogicChartSubmitResultsDA.Update(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 /// <param name = "objge_LogicChartSubmitResultsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 if (objge_LogicChartSubmitResultsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_LogicChartSubmitResultsDA.UpdateBySql2(objge_LogicChartSubmitResultsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_LogicChartSubmitResultsBL.ReFreshCache();

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
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
 clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN = clsge_LogicChartSubmitResultsBL.GetObjBymId(lngmId);

if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(objge_LogicChartSubmitResultsEN.mId, "SetUpdDate");
}
if (objge_LogicChartSubmitResultsEN != null)
{
int intRecNum = ge_LogicChartSubmitResultsDA.DelRecord(lngmId);
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
objSQL = clsge_LogicChartSubmitResultsDA.GetSpecSQLObj();
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
//删除与表:[ge_LogicChartSubmitResults]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_LogicChartSubmitResults.mId,
//lngmId);
//        clsge_LogicChartSubmitResultsBL.Delge_LogicChartSubmitResultssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_LogicChartSubmitResultsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_LogicChartSubmitResultsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ge_LogicChartSubmitResultsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int Delge_LogicChartSubmitResultss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_LogicChartSubmitResultsDA.Delge_LogicChartSubmitResults(arrmIdLst);
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
public static int Delge_LogicChartSubmitResultssByCond(string strWhereCond)
{
try
{
if (clsge_LogicChartSubmitResultsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsge_LogicChartSubmitResultsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = ge_LogicChartSubmitResultsDA.Delge_LogicChartSubmitResults(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_LogicChartSubmitResults]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_LogicChartSubmitResultsDA.GetSpecSQLObj();
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
//删除与表:[ge_LogicChartSubmitResults]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_LogicChartSubmitResultsBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_LogicChartSubmitResultsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objge_LogicChartSubmitResultsENS">源对象</param>
 /// <param name = "objge_LogicChartSubmitResultsENT">目标对象</param>
 public static void CopyTo(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENS, clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsENT)
{
try
{
objge_LogicChartSubmitResultsENT.mId = objge_LogicChartSubmitResultsENS.mId; //mId
objge_LogicChartSubmitResultsENT.KnowledgeGraphId = objge_LogicChartSubmitResultsENS.KnowledgeGraphId; //知识点图Id
objge_LogicChartSubmitResultsENT.CourseId = objge_LogicChartSubmitResultsENS.CourseId; //课程Id
objge_LogicChartSubmitResultsENT.CreateUser = objge_LogicChartSubmitResultsENS.CreateUser; //建立用户
objge_LogicChartSubmitResultsENT.TakeUpTime = objge_LogicChartSubmitResultsENS.TakeUpTime; //耗时
objge_LogicChartSubmitResultsENT.Fraction = objge_LogicChartSubmitResultsENS.Fraction; //分数
objge_LogicChartSubmitResultsENT.CorrectNum = objge_LogicChartSubmitResultsENS.CorrectNum; //正确数
objge_LogicChartSubmitResultsENT.ErrorNum = objge_LogicChartSubmitResultsENS.ErrorNum; //错误数
objge_LogicChartSubmitResultsENT.UpdDate = objge_LogicChartSubmitResultsENS.UpdDate; //修改日期
objge_LogicChartSubmitResultsENT.UpdUser = objge_LogicChartSubmitResultsENS.UpdUser; //修改人
objge_LogicChartSubmitResultsENT.Memo = objge_LogicChartSubmitResultsENS.Memo; //备注
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
 /// <param name = "objge_LogicChartSubmitResultsEN">源简化对象</param>
 public static void SetUpdFlag(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
try
{
objge_LogicChartSubmitResultsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_LogicChartSubmitResultsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_LogicChartSubmitResults.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.mId = objge_LogicChartSubmitResultsEN.mId; //mId
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.KnowledgeGraphId = objge_LogicChartSubmitResultsEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.CourseId = objge_LogicChartSubmitResultsEN.CourseId == "[null]" ? null :  objge_LogicChartSubmitResultsEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.CreateUser = objge_LogicChartSubmitResultsEN.CreateUser == "[null]" ? null :  objge_LogicChartSubmitResultsEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.TakeUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.TakeUpTime = objge_LogicChartSubmitResultsEN.TakeUpTime == "[null]" ? null :  objge_LogicChartSubmitResultsEN.TakeUpTime; //耗时
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.Fraction, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.Fraction = objge_LogicChartSubmitResultsEN.Fraction; //分数
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.CorrectNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.CorrectNum = objge_LogicChartSubmitResultsEN.CorrectNum; //正确数
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.ErrorNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.ErrorNum = objge_LogicChartSubmitResultsEN.ErrorNum; //错误数
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.UpdDate = objge_LogicChartSubmitResultsEN.UpdDate == "[null]" ? null :  objge_LogicChartSubmitResultsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.UpdUser = objge_LogicChartSubmitResultsEN.UpdUser == "[null]" ? null :  objge_LogicChartSubmitResultsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_LogicChartSubmitResults.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_LogicChartSubmitResultsEN.Memo = objge_LogicChartSubmitResultsEN.Memo == "[null]" ? null :  objge_LogicChartSubmitResultsEN.Memo; //备注
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
 /// <param name = "objge_LogicChartSubmitResultsEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
try
{
if (objge_LogicChartSubmitResultsEN.CourseId == "[null]") objge_LogicChartSubmitResultsEN.CourseId = null; //课程Id
if (objge_LogicChartSubmitResultsEN.CreateUser == "[null]") objge_LogicChartSubmitResultsEN.CreateUser = null; //建立用户
if (objge_LogicChartSubmitResultsEN.TakeUpTime == "[null]") objge_LogicChartSubmitResultsEN.TakeUpTime = null; //耗时
if (objge_LogicChartSubmitResultsEN.UpdDate == "[null]") objge_LogicChartSubmitResultsEN.UpdDate = null; //修改日期
if (objge_LogicChartSubmitResultsEN.UpdUser == "[null]") objge_LogicChartSubmitResultsEN.UpdUser = null; //修改人
if (objge_LogicChartSubmitResultsEN.Memo == "[null]") objge_LogicChartSubmitResultsEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 ge_LogicChartSubmitResultsDA.CheckPropertyNew(objge_LogicChartSubmitResultsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
 ge_LogicChartSubmitResultsDA.CheckProperty4Condition(objge_LogicChartSubmitResultsEN);
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
if (clsge_LogicChartSubmitResultsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_LogicChartSubmitResultsBL没有刷新缓存机制(clsge_LogicChartSubmitResultsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrge_LogicChartSubmitResultsObjLstCache == null)
//{
//arrge_LogicChartSubmitResultsObjLstCache = ge_LogicChartSubmitResultsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_LogicChartSubmitResultsEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_LogicChartSubmitResultsEN._CurrTabName);
List<clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLstCache = GetObjLstCache();
IEnumerable <clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLst_Sel =
arrge_LogicChartSubmitResultsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrge_LogicChartSubmitResultsObjLst_Sel.Count() == 0)
{
   clsge_LogicChartSubmitResultsEN obj = clsge_LogicChartSubmitResultsBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_LogicChartSubmitResultsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetAllge_LogicChartSubmitResultsObjLstCache()
{
//获取缓存中的对象列表
List<clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLstCache = GetObjLstCache(); 
return arrge_LogicChartSubmitResultsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_LogicChartSubmitResultsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_LogicChartSubmitResultsEN._CurrTabName);
List<clsge_LogicChartSubmitResultsEN> arrge_LogicChartSubmitResultsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_LogicChartSubmitResultsObjLstCache;
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
string strKey = string.Format("{0}", clsge_LogicChartSubmitResultsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_LogicChartSubmitResultsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_LogicChartSubmitResultsEN._RefreshTimeLst.Count == 0) return "";
return clsge_LogicChartSubmitResultsEN._RefreshTimeLst[clsge_LogicChartSubmitResultsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_LogicChartSubmitResultsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_LogicChartSubmitResultsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_LogicChartSubmitResultsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_LogicChartSubmitResultsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_LogicChartSubmitResults(知识逻辑图提交结果)
 /// 唯一性条件:KnowledgeGraphId_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsEN)
{
//检测记录是否存在
string strResult = ge_LogicChartSubmitResultsDA.GetUniCondStr(objge_LogicChartSubmitResultsEN);
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
if (strInFldName != conge_LogicChartSubmitResults.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_LogicChartSubmitResults.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_LogicChartSubmitResults.AttributeName));
throw new Exception(strMsg);
}
var objge_LogicChartSubmitResults = clsge_LogicChartSubmitResultsBL.GetObjBymIdCache(lngmId);
if (objge_LogicChartSubmitResults == null) return "";
return objge_LogicChartSubmitResults[strOutFldName].ToString();
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
int intRecCount = clsge_LogicChartSubmitResultsDA.GetRecCount(strTabName);
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
int intRecCount = clsge_LogicChartSubmitResultsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_LogicChartSubmitResultsDA.GetRecCount();
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
int intRecCount = clsge_LogicChartSubmitResultsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_LogicChartSubmitResultsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_LogicChartSubmitResultsEN objge_LogicChartSubmitResultsCond)
{
List<clsge_LogicChartSubmitResultsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_LogicChartSubmitResultsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_LogicChartSubmitResults.AttributeName)
{
if (objge_LogicChartSubmitResultsCond.IsUpdated(strFldName) == false) continue;
if (objge_LogicChartSubmitResultsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LogicChartSubmitResultsCond[strFldName].ToString());
}
else
{
if (objge_LogicChartSubmitResultsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_LogicChartSubmitResultsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_LogicChartSubmitResultsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_LogicChartSubmitResultsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_LogicChartSubmitResultsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_LogicChartSubmitResultsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_LogicChartSubmitResultsCond[strFldName]));
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
 List<string> arrList = clsge_LogicChartSubmitResultsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_LogicChartSubmitResultsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_LogicChartSubmitResultsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_LogicChartSubmitResultsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_LogicChartSubmitResultsDA.SetFldValue(clsge_LogicChartSubmitResultsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_LogicChartSubmitResultsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_LogicChartSubmitResultsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_LogicChartSubmitResultsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_LogicChartSubmitResultsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_LogicChartSubmitResults] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**知识点图Id*/ 
 strCreateTabCode.Append(" KnowledgeGraphId char(10) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**耗时*/ 
 strCreateTabCode.Append(" TakeUpTime varchar(50) Null, "); 
 // /**分数*/ 
 strCreateTabCode.Append(" Fraction int Null, "); 
 // /**正确数*/ 
 strCreateTabCode.Append(" CorrectNum int Null, "); 
 // /**错误数*/ 
 strCreateTabCode.Append(" ErrorNum int Null, "); 
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
 /// 知识逻辑图提交结果(ge_LogicChartSubmitResults)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_LogicChartSubmitResults : clsCommFun4BL
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
clsge_LogicChartSubmitResultsBL.ReFreshThisCache();
}
}

}