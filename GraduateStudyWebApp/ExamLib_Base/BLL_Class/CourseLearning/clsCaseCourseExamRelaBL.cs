
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseExamRelaBL
 表名:CaseCourseExamRela(01120122)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsCaseCourseExamRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseExamRelaEN GetObj(this K_IdCaseCourseExamRela_CaseCourseExamRela myKey)
{
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.GetObjByIdCaseCourseExamRela(myKey.Value);
return objCaseCourseExamRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseCourseExamRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],题目Id = [{1}]的数据已经存在!(in clsCaseCourseExamRelaBL.AddNewRecord)", objCaseCourseExamRelaEN.CaseId,objCaseCourseExamRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.AddNewRecordBySQL2(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objCaseCourseExamRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCaseCourseExamRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例Id(CaseId)=[{0}],题目Id(QuestionId)=[{1}])已经存在,不能重复!", objCaseCourseExamRelaEN.CaseId, objCaseCourseExamRelaEN.QuestionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCaseCourseExamRelaEN.AddNewRecord();
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseCourseExamRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],题目Id = [{1}]的数据已经存在!(in clsCaseCourseExamRelaBL.AddNewRecordWithReturnKey)", objCaseCourseExamRelaEN.CaseId,objCaseCourseExamRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetIdCaseCourseExamRela(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, long lngIdCaseCourseExamRela, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = lngIdCaseCourseExamRela; //案例题库关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.IdCaseCourseExamRela) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.IdCaseCourseExamRela, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.IdCaseCourseExamRela] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetFuncModuleId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCourseExamRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
}
objCaseCourseExamRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.FuncModuleId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetCaseId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCourseExamRela.CaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCourseExamRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCourseExamRela.CaseId);
}
objCaseCourseExamRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.CaseId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.CaseId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.CaseId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetCaseName(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCourseExamRela.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCourseExamRela.CaseName);
}
objCaseCourseExamRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.CaseName) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.CaseName, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.CaseName] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetOwnerId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCourseExamRela.OwnerId);
}
objCaseCourseExamRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.OwnerId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.OwnerId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.OwnerId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetQuestionId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, long? lngQuestionId, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.QuestionId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.QuestionId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.QuestionId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetIdCaseCourseExamRelaType(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strIdCaseCourseExamRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseCourseExamRelaType, conCaseCourseExamRela.IdCaseCourseExamRelaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseCourseExamRelaType, 4, conCaseCourseExamRela.IdCaseCourseExamRelaType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseCourseExamRelaType, 4, conCaseCourseExamRela.IdCaseCourseExamRelaType);
}
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = strIdCaseCourseExamRelaType; //案例题库关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.IdCaseCourseExamRelaType) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.IdCaseCourseExamRelaType, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.IdCaseCourseExamRelaType] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetStartTime(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, double? dblStartTime, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.StartTime) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.StartTime, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.StartTime] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetBrowseCount(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseCourseExamRela.BrowseCount);
objCaseCourseExamRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.BrowseCount) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.BrowseCount, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.BrowseCount] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetOrderNum(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.OrderNum) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.OrderNum, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.OrderNum] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetUpdDate(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCourseExamRela.UpdDate);
}
objCaseCourseExamRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.UpdDate) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.UpdDate, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.UpdDate] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetUpdUserId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCourseExamRela.UpdUserId);
}
objCaseCourseExamRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.UpdUserId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.UpdUserId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.UpdUserId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetMemo(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCourseExamRela.Memo);
}
objCaseCourseExamRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.Memo) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.Memo, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.Memo] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseCourseExamRelaEN.CheckPropertyNew();
clsCaseCourseExamRelaEN objCaseCourseExamRelaCond = new clsCaseCourseExamRelaEN();
string strCondition = objCaseCourseExamRelaCond
.SetIdCaseCourseExamRela(objCaseCourseExamRelaEN.IdCaseCourseExamRela, "<>")
.SetCaseId(objCaseCourseExamRelaEN.CaseId, "=")
.SetQuestionId(objCaseCourseExamRelaEN.QuestionId, "=")
.GetCombineCondition();
objCaseCourseExamRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCaseCourseExamRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseId_QuestionID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseCourseExamRelaEN.Update();
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
 /// <param name = "objCaseCourseExamRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCaseCourseExamRelaEN objCaseCourseExamRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCaseCourseExamRelaEN objCaseCourseExamRelaCond = new clsCaseCourseExamRelaEN();
string strCondition = objCaseCourseExamRelaCond
.SetCaseId(objCaseCourseExamRela.CaseId, "=")
.SetQuestionId(objCaseCourseExamRela.QuestionId, "=")
.GetCombineCondition();
objCaseCourseExamRela._IsCheckProperty = true;
bool bolIsExist = clsCaseCourseExamRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCaseCourseExamRela.IdCaseCourseExamRela = clsCaseCourseExamRelaBL.GetFirstID_S(strCondition);
objCaseCourseExamRela.UpdateWithCondition(strCondition);
}
else
{
objCaseCourseExamRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.UpdateBySql2(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.UpdateBySql2(objCaseCourseExamRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.UpdateBySqlWithCondition(objCaseCourseExamRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.UpdateBySqlWithConditionTransaction(objCaseCourseExamRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
try
{
int intRecNum = clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.DelRecord(objCaseCourseExamRelaEN.IdCaseCourseExamRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(this clsCaseCourseExamRelaEN objCaseCourseExamRelaENS, clsCaseCourseExamRelaEN objCaseCourseExamRelaENT)
{
try
{
objCaseCourseExamRelaENT.IdCaseCourseExamRela = objCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objCaseCourseExamRelaENT.FuncModuleId = objCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objCaseCourseExamRelaENT.CaseId = objCaseCourseExamRelaENS.CaseId; //案例Id
objCaseCourseExamRelaENT.CaseName = objCaseCourseExamRelaENS.CaseName; //案例名称
objCaseCourseExamRelaENT.OwnerId = objCaseCourseExamRelaENS.OwnerId; //拥有者Id
objCaseCourseExamRelaENT.QuestionId = objCaseCourseExamRelaENS.QuestionId; //题目Id
objCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objCaseCourseExamRelaENT.StartTime = objCaseCourseExamRelaENS.StartTime; //开始时间(s)
objCaseCourseExamRelaENT.BrowseCount = objCaseCourseExamRelaENS.BrowseCount; //浏览次数
objCaseCourseExamRelaENT.OrderNum = objCaseCourseExamRelaENS.OrderNum; //序号
objCaseCourseExamRelaENT.UpdDate = objCaseCourseExamRelaENS.UpdDate; //修改日期
objCaseCourseExamRelaENT.UpdUserId = objCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objCaseCourseExamRelaENT.Memo = objCaseCourseExamRelaENS.Memo; //备注
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
 /// <param name = "objCaseCourseExamRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseCourseExamRelaEN:objCaseCourseExamRelaENT</returns>
 public static clsCaseCourseExamRelaEN CopyTo(this clsCaseCourseExamRelaEN objCaseCourseExamRelaENS)
{
try
{
 clsCaseCourseExamRelaEN objCaseCourseExamRelaENT = new clsCaseCourseExamRelaEN()
{
IdCaseCourseExamRela = objCaseCourseExamRelaENS.IdCaseCourseExamRela, //案例题库关系流水号
FuncModuleId = objCaseCourseExamRelaENS.FuncModuleId, //功能模块Id
CaseId = objCaseCourseExamRelaENS.CaseId, //案例Id
CaseName = objCaseCourseExamRelaENS.CaseName, //案例名称
OwnerId = objCaseCourseExamRelaENS.OwnerId, //拥有者Id
QuestionId = objCaseCourseExamRelaENS.QuestionId, //题目Id
IdCaseCourseExamRelaType = objCaseCourseExamRelaENS.IdCaseCourseExamRelaType, //案例题库关系类型流水号
StartTime = objCaseCourseExamRelaENS.StartTime, //开始时间(s)
BrowseCount = objCaseCourseExamRelaENS.BrowseCount, //浏览次数
OrderNum = objCaseCourseExamRelaENS.OrderNum, //序号
UpdDate = objCaseCourseExamRelaENS.UpdDate, //修改日期
UpdUserId = objCaseCourseExamRelaENS.UpdUserId, //修改用户Id
Memo = objCaseCourseExamRelaENS.Memo, //备注
};
 return objCaseCourseExamRelaENT;
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
public static void CheckPropertyNew(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.CheckPropertyNew(objCaseCourseExamRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 clsCaseCourseExamRelaBL.CaseCourseExamRelaDA.CheckProperty4Condition(objCaseCourseExamRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCourseExamRelaEN objCaseCourseExamRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRela) == true)
{
string strComparisonOpIdCaseCourseExamRela = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.IdCaseCourseExamRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.IdCaseCourseExamRela, objCaseCourseExamRelaCond.IdCaseCourseExamRela, strComparisonOpIdCaseCourseExamRela);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.FuncModuleId, objCaseCourseExamRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.CaseId) == true)
{
string strComparisonOpCaseId = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.CaseId, objCaseCourseExamRelaCond.CaseId, strComparisonOpCaseId);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.CaseName) == true)
{
string strComparisonOpCaseName = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.CaseName, objCaseCourseExamRelaCond.CaseName, strComparisonOpCaseName);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.OwnerId, objCaseCourseExamRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.QuestionId) == true)
{
string strComparisonOpQuestionId = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.QuestionId, objCaseCourseExamRelaCond.QuestionId, strComparisonOpQuestionId);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.IdCaseCourseExamRelaType) == true)
{
string strComparisonOpIdCaseCourseExamRelaType = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.IdCaseCourseExamRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.IdCaseCourseExamRelaType, objCaseCourseExamRelaCond.IdCaseCourseExamRelaType, strComparisonOpIdCaseCourseExamRelaType);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.StartTime) == true)
{
string strComparisonOpStartTime = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.StartTime, objCaseCourseExamRelaCond.StartTime, strComparisonOpStartTime);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.BrowseCount, objCaseCourseExamRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.OrderNum, objCaseCourseExamRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.UpdDate, objCaseCourseExamRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.UpdUserId, objCaseCourseExamRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCaseCourseExamRelaCond.IsUpdated(conCaseCourseExamRela.Memo) == true)
{
string strComparisonOpMemo = objCaseCourseExamRelaCond.dicFldComparisonOp[conCaseCourseExamRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.Memo, objCaseCourseExamRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseCourseExamRela(案例题库关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseExamRelaEN == null) return true;
if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 if (objCaseCourseExamRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objCaseCourseExamRelaEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objCaseCourseExamRelaEN.QuestionId);
}
if (clsCaseCourseExamRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCaseCourseExamRela !=  {0}", objCaseCourseExamRelaEN.IdCaseCourseExamRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objCaseCourseExamRelaEN.QuestionId);
if (clsCaseCourseExamRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CaseCourseExamRela(案例题库关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseExamRelaEN == null) return "";
if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 if (objCaseCourseExamRelaEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objCaseCourseExamRelaEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objCaseCourseExamRelaEN.QuestionId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCaseCourseExamRela !=  {0}", objCaseCourseExamRelaEN.IdCaseCourseExamRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objCaseCourseExamRelaEN.QuestionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseCourseExamRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseCourseExamRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例题库关系(CaseCourseExamRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseCourseExamRelaBL
{
public static RelatedActions_CaseCourseExamRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseCourseExamRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseCourseExamRelaDA CaseCourseExamRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseCourseExamRelaDA();
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
 public clsCaseCourseExamRelaBL()
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
if (string.IsNullOrEmpty(clsCaseCourseExamRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCourseExamRelaEN._ConnectString);
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
public static DataTable GetDataTable_CaseCourseExamRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseCourseExamRelaDA.GetDataTable_CaseCourseExamRela(strWhereCond);
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
objDT = CaseCourseExamRelaDA.GetDataTable(strWhereCond);
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
objDT = CaseCourseExamRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseCourseExamRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseCourseExamRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseCourseExamRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CaseCourseExamRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseCourseExamRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseCourseExamRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseCourseExamRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLstByIdCaseCourseExamRelaLst(List<long> arrIdCaseCourseExamRelaLst)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseCourseExamRelaLst);
 string strWhereCond = string.Format("IdCaseCourseExamRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseCourseExamRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseCourseExamRelaEN> GetObjLstByIdCaseCourseExamRelaLstCache(List<long> arrIdCaseCourseExamRelaLst)
{
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Sel =
arrCaseCourseExamRelaObjLstCache
.Where(x => arrIdCaseCourseExamRelaLst.Contains(x.IdCaseCourseExamRela));
return arrCaseCourseExamRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLst(string strWhereCond)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
public static List<clsCaseCourseExamRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseCourseExamRelaEN> GetSubObjLstCache(clsCaseCourseExamRelaEN objCaseCourseExamRelaCond)
{
List<clsCaseCourseExamRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseExamRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCourseExamRela.AttributeName)
{
if (objCaseCourseExamRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseCourseExamRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseExamRelaCond[strFldName].ToString());
}
else
{
if (objCaseCourseExamRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCourseExamRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseExamRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCourseExamRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCourseExamRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCourseExamRelaCond[strFldName]));
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
List<clsCaseCourseExamRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseCourseExamRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseCourseExamRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
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
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
public static List<clsCaseCourseExamRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseCourseExamRelaEN> arrObjLst = new List<clsCaseCourseExamRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = new clsCaseCourseExamRelaEN();
try
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = Int32.Parse(objRow[conCaseCourseExamRela.IdCaseCourseExamRela].ToString().Trim()); //案例题库关系流水号
objCaseCourseExamRelaEN.FuncModuleId = objRow[conCaseCourseExamRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseExamRelaEN.CaseId = objRow[conCaseCourseExamRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseExamRelaEN.CaseName = objRow[conCaseCourseExamRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseExamRelaEN.OwnerId = objRow[conCaseCourseExamRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseExamRelaEN.QuestionId = objRow[conCaseCourseExamRela.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.QuestionId].ToString().Trim()); //题目Id
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objRow[conCaseCourseExamRela.IdCaseCourseExamRelaType].ToString().Trim(); //案例题库关系类型流水号
objCaseCourseExamRelaEN.StartTime = objRow[conCaseCourseExamRela.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCaseCourseExamRela.StartTime].ToString().Trim()); //开始时间(s)
objCaseCourseExamRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseExamRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseExamRelaEN.OrderNum = objRow[conCaseCourseExamRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseExamRela.OrderNum].ToString().Trim()); //序号
objCaseCourseExamRelaEN.UpdDate = objRow[conCaseCourseExamRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseExamRelaEN.UpdUserId = objRow[conCaseCourseExamRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseExamRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseExamRelaEN.Memo = objRow[conCaseCourseExamRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseExamRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseExamRelaEN.IdCaseCourseExamRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseExamRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseCourseExamRela(ref clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
bool bolResult = CaseCourseExamRelaDA.GetCaseCourseExamRela(ref objCaseCourseExamRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseExamRelaEN GetObjByIdCaseCourseExamRela(long lngIdCaseCourseExamRela)
{
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = CaseCourseExamRelaDA.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);
return objCaseCourseExamRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseCourseExamRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = CaseCourseExamRelaDA.GetFirstObj(strWhereCond);
 return objCaseCourseExamRelaEN;
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
public static clsCaseCourseExamRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = CaseCourseExamRelaDA.GetObjByDataRow(objRow);
 return objCaseCourseExamRelaEN;
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
public static clsCaseCourseExamRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = CaseCourseExamRelaDA.GetObjByDataRow(objRow);
 return objCaseCourseExamRelaEN;
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
 /// <param name = "lngIdCaseCourseExamRela">所给的关键字</param>
 /// <param name = "lstCaseCourseExamRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseExamRelaEN GetObjByIdCaseCourseExamRelaFromList(long lngIdCaseCourseExamRela, List<clsCaseCourseExamRelaEN> lstCaseCourseExamRelaObjLst)
{
foreach (clsCaseCourseExamRelaEN objCaseCourseExamRelaEN in lstCaseCourseExamRelaObjLst)
{
if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == lngIdCaseCourseExamRela)
{
return objCaseCourseExamRelaEN;
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
 long lngIdCaseCourseExamRela;
 try
 {
 lngIdCaseCourseExamRela = new clsCaseCourseExamRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseCourseExamRela;
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
 arrList = CaseCourseExamRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CaseCourseExamRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseCourseExamRela)
{
//检测记录是否存在
bool bolIsExist = CaseCourseExamRelaDA.IsExist(lngIdCaseCourseExamRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdCaseCourseExamRela">案例题库关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdCaseCourseExamRela, string strOpUser)
{
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = clsCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);
objCaseCourseExamRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCaseCourseExamRelaEN.UpdUserId = strOpUser;
return clsCaseCourseExamRelaBL.UpdateBySql2(objCaseCourseExamRelaEN);
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
 bolIsExist = clsCaseCourseExamRelaDA.IsExistTable();
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
 bolIsExist = CaseCourseExamRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseCourseExamRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],题目Id = [{1}]的数据已经存在!(in clsCaseCourseExamRelaBL.AddNewRecordBySql2)", objCaseCourseExamRelaEN.CaseId,objCaseCourseExamRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CaseCourseExamRelaDA.AddNewRecordBySQL2(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseCourseExamRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],题目Id = [{1}]的数据已经存在!(in clsCaseCourseExamRelaBL.AddNewRecordBySql2WithReturnKey)", objCaseCourseExamRelaEN.CaseId,objCaseCourseExamRelaEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = CaseCourseExamRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
try
{
bool bolResult = CaseCourseExamRelaDA.Update(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 if (objCaseCourseExamRelaEN.IdCaseCourseExamRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseCourseExamRelaDA.UpdateBySql2(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaBL.ReFreshCache();

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdCaseCourseExamRela)
{
try
{
 clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = clsCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);

if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseExamRelaEN.IdCaseCourseExamRela, objCaseCourseExamRelaEN.UpdUserId);
}
if (objCaseCourseExamRelaEN != null)
{
int intRecNum = CaseCourseExamRelaDA.DelRecord(lngIdCaseCourseExamRela);
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
/// <param name="lngIdCaseCourseExamRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdCaseCourseExamRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseCourseExamRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseCourseExamRela.IdCaseCourseExamRela,
//lngIdCaseCourseExamRela);
//        clsCaseCourseExamRelaBL.DelCaseCourseExamRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCourseExamRelaBL.DelRecord(lngIdCaseCourseExamRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCourseExamRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseCourseExamRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdCaseCourseExamRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdCaseCourseExamRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseCourseExamRelaBL.relatedActions != null)
{
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseExamRela, "UpdRelaTabDate");
}
bool bolResult = CaseCourseExamRelaDA.DelRecord(lngIdCaseCourseExamRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCaseCourseExamRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseCourseExamRelas(List<string> arrIdCaseCourseExamRelaLst)
{
if (arrIdCaseCourseExamRelaLst.Count == 0) return 0;
try
{
if (clsCaseCourseExamRelaBL.relatedActions != null)
{
foreach (var strIdCaseCourseExamRela in arrIdCaseCourseExamRelaLst)
{
long lngIdCaseCourseExamRela = long.Parse(strIdCaseCourseExamRela);
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseExamRela, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseCourseExamRelaDA.DelCaseCourseExamRela(arrIdCaseCourseExamRelaLst);
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
public static int DelCaseCourseExamRelasByCond(string strWhereCond)
{
try
{
if (clsCaseCourseExamRelaBL.relatedActions != null)
{
List<string> arrIdCaseCourseExamRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCaseCourseExamRela in arrIdCaseCourseExamRela)
{
long lngIdCaseCourseExamRela = long.Parse(strIdCaseCourseExamRela);
clsCaseCourseExamRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseExamRela, "UpdRelaTabDate");
}
}
int intRecNum = CaseCourseExamRelaDA.DelCaseCourseExamRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseCourseExamRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdCaseCourseExamRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdCaseCourseExamRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCourseExamRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseCourseExamRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCourseExamRelaBL.DelRecord(lngIdCaseCourseExamRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCourseExamRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseCourseExamRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(clsCaseCourseExamRelaEN objCaseCourseExamRelaENS, clsCaseCourseExamRelaEN objCaseCourseExamRelaENT)
{
try
{
objCaseCourseExamRelaENT.IdCaseCourseExamRela = objCaseCourseExamRelaENS.IdCaseCourseExamRela; //案例题库关系流水号
objCaseCourseExamRelaENT.FuncModuleId = objCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objCaseCourseExamRelaENT.CaseId = objCaseCourseExamRelaENS.CaseId; //案例Id
objCaseCourseExamRelaENT.CaseName = objCaseCourseExamRelaENS.CaseName; //案例名称
objCaseCourseExamRelaENT.OwnerId = objCaseCourseExamRelaENS.OwnerId; //拥有者Id
objCaseCourseExamRelaENT.QuestionId = objCaseCourseExamRelaENS.QuestionId; //题目Id
objCaseCourseExamRelaENT.IdCaseCourseExamRelaType = objCaseCourseExamRelaENS.IdCaseCourseExamRelaType; //案例题库关系类型流水号
objCaseCourseExamRelaENT.StartTime = objCaseCourseExamRelaENS.StartTime; //开始时间(s)
objCaseCourseExamRelaENT.BrowseCount = objCaseCourseExamRelaENS.BrowseCount; //浏览次数
objCaseCourseExamRelaENT.OrderNum = objCaseCourseExamRelaENS.OrderNum; //序号
objCaseCourseExamRelaENT.UpdDate = objCaseCourseExamRelaENS.UpdDate; //修改日期
objCaseCourseExamRelaENT.UpdUserId = objCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objCaseCourseExamRelaENT.Memo = objCaseCourseExamRelaENS.Memo; //备注
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
 /// <param name = "objCaseCourseExamRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
try
{
objCaseCourseExamRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseCourseExamRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseCourseExamRela.IdCaseCourseExamRela, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.IdCaseCourseExamRela = objCaseCourseExamRelaEN.IdCaseCourseExamRela; //案例题库关系流水号
}
if (arrFldSet.Contains(conCaseCourseExamRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.FuncModuleId = objCaseCourseExamRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conCaseCourseExamRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.CaseId = objCaseCourseExamRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(conCaseCourseExamRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.CaseName = objCaseCourseExamRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(conCaseCourseExamRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.OwnerId = objCaseCourseExamRelaEN.OwnerId == "[null]" ? null :  objCaseCourseExamRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCaseCourseExamRela.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.QuestionId = objCaseCourseExamRelaEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conCaseCourseExamRela.IdCaseCourseExamRelaType, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.IdCaseCourseExamRelaType = objCaseCourseExamRelaEN.IdCaseCourseExamRelaType; //案例题库关系类型流水号
}
if (arrFldSet.Contains(conCaseCourseExamRela.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.StartTime = objCaseCourseExamRelaEN.StartTime; //开始时间(s)
}
if (arrFldSet.Contains(conCaseCourseExamRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.BrowseCount = objCaseCourseExamRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCaseCourseExamRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.OrderNum = objCaseCourseExamRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCaseCourseExamRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.UpdDate = objCaseCourseExamRelaEN.UpdDate == "[null]" ? null :  objCaseCourseExamRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCaseCourseExamRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.UpdUserId = objCaseCourseExamRelaEN.UpdUserId == "[null]" ? null :  objCaseCourseExamRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCaseCourseExamRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseExamRelaEN.Memo = objCaseCourseExamRelaEN.Memo == "[null]" ? null :  objCaseCourseExamRelaEN.Memo; //备注
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
 /// <param name = "objCaseCourseExamRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
try
{
if (objCaseCourseExamRelaEN.OwnerId == "[null]") objCaseCourseExamRelaEN.OwnerId = null; //拥有者Id
if (objCaseCourseExamRelaEN.UpdDate == "[null]") objCaseCourseExamRelaEN.UpdDate = null; //修改日期
if (objCaseCourseExamRelaEN.UpdUserId == "[null]") objCaseCourseExamRelaEN.UpdUserId = null; //修改用户Id
if (objCaseCourseExamRelaEN.Memo == "[null]") objCaseCourseExamRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 CaseCourseExamRelaDA.CheckPropertyNew(objCaseCourseExamRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 CaseCourseExamRelaDA.CheckProperty4Condition(objCaseCourseExamRelaEN);
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
if (clsCaseCourseExamRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaBL没有刷新缓存机制(clsCaseCourseExamRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseCourseExamRela");
//if (arrCaseCourseExamRelaObjLstCache == null)
//{
//arrCaseCourseExamRelaObjLstCache = CaseCourseExamRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseExamRelaEN GetObjByIdCaseCourseExamRelaCache(long lngIdCaseCourseExamRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Sel =
arrCaseCourseExamRelaObjLstCache
.Where(x=> x.IdCaseCourseExamRela == lngIdCaseCourseExamRela 
);
if (arrCaseCourseExamRelaObjLst_Sel.Count() == 0)
{
   clsCaseCourseExamRelaEN obj = clsCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRela(lngIdCaseCourseExamRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseCourseExamRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetAllCaseCourseExamRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLstCache = GetObjLstCache(); 
return arrCaseCourseExamRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCourseExamRelaObjLstCache;
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
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCourseExamRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCaseCourseExamRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCaseCourseExamRelaEN._RefreshTimeLst[clsCaseCourseExamRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCaseCourseExamRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCourseExamRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCaseCourseExamRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CaseCourseExamRela(案例题库关系)
 /// 唯一性条件:CaseId_QuestionID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检测记录是否存在
string strResult = CaseCourseExamRelaDA.GetUniCondStr(objCaseCourseExamRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseCourseExamRela)
{
if (strInFldName != conCaseCourseExamRela.IdCaseCourseExamRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseCourseExamRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseCourseExamRela.AttributeName));
throw new Exception(strMsg);
}
var objCaseCourseExamRela = clsCaseCourseExamRelaBL.GetObjByIdCaseCourseExamRelaCache(lngIdCaseCourseExamRela);
if (objCaseCourseExamRela == null) return "";
return objCaseCourseExamRela[strOutFldName].ToString();
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
int intRecCount = clsCaseCourseExamRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseCourseExamRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseCourseExamRelaDA.GetRecCount();
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
int intRecCount = clsCaseCourseExamRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseCourseExamRelaEN objCaseCourseExamRelaCond)
{
List<clsCaseCourseExamRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseExamRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCourseExamRela.AttributeName)
{
if (objCaseCourseExamRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseCourseExamRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseExamRelaCond[strFldName].ToString());
}
else
{
if (objCaseCourseExamRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCourseExamRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseExamRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCourseExamRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCourseExamRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCourseExamRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCourseExamRelaCond[strFldName]));
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
 List<string> arrList = clsCaseCourseExamRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseCourseExamRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseCourseExamRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseCourseExamRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCourseExamRelaDA.SetFldValue(clsCaseCourseExamRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseCourseExamRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCourseExamRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCourseExamRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCourseExamRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseCourseExamRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例题库关系流水号*/ 
 strCreateTabCode.Append(" IdCaseCourseExamRela bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**案例Id*/ 
 strCreateTabCode.Append(" CaseId char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" CaseName varchar(100) not Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint Null, "); 
 // /**案例题库关系类型流水号*/ 
 strCreateTabCode.Append(" IdCaseCourseExamRelaType char(4) not Null, "); 
 // /**开始时间(s)*/ 
 strCreateTabCode.Append(" StartTime decimal(12,2) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 案例题库关系(CaseCourseExamRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseCourseExamRela : clsCommFun4BL
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
clsCaseCourseExamRelaBL.ReFreshThisCache();
}
}

}